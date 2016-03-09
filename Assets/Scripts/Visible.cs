using UnityEngine;
using Fungus;

[ExecuteInEditMode]
public class Visible : Fungus.Character
{
	static private float VISIBLE = 1f;
	static private float RUNTIME_INVISIBLE = 0;
	static private float DESGINTIME_INVISIBLE = 0.5f;

	public bool isVisible = true;
	private bool wasVisible;

	protected SpriteRenderer spriteRenderer = null;

	public virtual void Start()
	{
		this.spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();	

		this.wasVisible = !this.isVisible;
		this.UpdateVisibilityProperties();
	}

	// Update is called once per frame
	public virtual void Update() {
		if (this.isVisible != this.wasVisible) {
			this.UpdateVisibilityProperties();
		}
	}

	private void UpdateVisibilityProperties() {	
		Color tmpColor = this.spriteRenderer.color;
		if (this.isVisible) {
			tmpColor.a = BlobCharacter.VISIBLE;
		}
		else {
			if (Application.isPlaying) {
				tmpColor.a = BlobCharacter.RUNTIME_INVISIBLE;
			}
			else {
				tmpColor.a = BlobCharacter.DESGINTIME_INVISIBLE;
			}
		}
		this.spriteRenderer.color = tmpColor;

		this.wasVisible = this.isVisible;
	}
}

