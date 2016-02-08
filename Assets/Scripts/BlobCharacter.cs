using UnityEngine;
using System.Collections;
using Fungus;

[ExecuteInEditMode]
public class BlobCharacter : Fungus.Character {

	static private Color DEFAULT = new Color(178f/255f, 1f, 241f/255f);
	static private Color GOLD = new Color(1f, 226f/255, 139f/255f);

	public bool isGold = false;

	private bool wasGold = false;
	private SpriteRenderer spriteRenderer = null;

	// Use this for initialization
	void Start () {
		this.spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

		this.UpdateProperties();
	}

	// Update is called once per frame
	void Update () {
		if (this.isGold != this.wasGold) {
			this.UpdateProperties();
		}

	}

	private void UpdateProperties() {	
		if (this.isGold) {
			this.spriteRenderer.color = BlobCharacter.GOLD;
		}
		else {
			this.spriteRenderer.color = BlobCharacter.DEFAULT;
		}

		this.wasGold = this.isGold;
	}
}
