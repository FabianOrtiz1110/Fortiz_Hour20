using UnityEngine;

public class TextureScroller : MonoBehaviour
{
		public float speed = .5f;

		Renderer Renderer;
		float offset;

	void Start()
	{
		Renderer = GetComponent<Renderer>();
	}

	void Update()
	{
		offset += Time.deltaTime * speed;
		
		if (offset >1)
			offset -= 1;
		Renderer.material.mainTextureOffset = new Vector2(0, offset);
	}
}

