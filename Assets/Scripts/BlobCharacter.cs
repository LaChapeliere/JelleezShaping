using UnityEngine;
using System.Collections;
using Fungus;

[ExecuteInEditMode]
public class BlobCharacter : Fungus.Character {

	public enum BlobTypes { TypeI=0, TypeII=1, TypeIII=2, TypeIV=3, TypeV=4, TypeVI=5, TypeVII=6 };

	static private Color DEFAULT = new Color(178f/255f, 1f, 241f/255f);
	static private Color GOLD = new Color(1f, 226f/255, 139f/255f);

	public bool isGold = false;
	private bool wasGold = false;

	public BlobTypes blobType = BlobTypes.TypeIV;
	private BlobTypes previousBlobType = BlobTypes.TypeIV;

	private Animator animator = null;
	private SpriteRenderer spriteRenderer = null;

	// Use this for initialization
	void Start() {
		this.spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
		this.animator = this.gameObject.GetComponent<Animator>();

		this.UpdateColorProperties();
		this.UpdateShapeProperties(this.blobType);
	}

	// Update is called once per frame
	void Update() {
		if (this.isGold != this.wasGold) {
			this.UpdateColorProperties();
		}

		if (this.blobType != this.previousBlobType) {
			this.UpdateShapeProperties(this.blobType);
		}
	}

	public void SetBlobType(BlobCharacter.BlobTypes blobType) {
		this.blobType = blobType;
	}

	public BlobCharacter.BlobTypes GetBlobType() {
		return this.blobType;
	}

	private void UpdateColorProperties() {	
		if (this.isGold) {
			this.spriteRenderer.color = BlobCharacter.GOLD;
		}
		else {
			this.spriteRenderer.color = BlobCharacter.DEFAULT;
		}

		this.wasGold = this.isGold;
	}

	private void UpdateShapeProperties(BlobCharacter.BlobTypes blobType) {	
		this.spriteRenderer.sprite = Resources.Load<Sprite>("Images/Blob_" + ((int) blobType +1) + "/Blob_" + ((int) blobType+1));
		this.animator.runtimeAnimatorController = Resources.Load<AnimatorOverrideController>("Animators/Blob" + ((int) blobType+1));

		this.previousBlobType = this.blobType;
	}
}
