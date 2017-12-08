using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerRotation : MonoBehaviour {

    public float rotateSpeed = 1;
	public bool smooth;
	public float smoothTime = 5f;
	public Transform cam;
	private Quaternion m_CharacterTargetRot;
	
	// Update is called once per frame
	void Start()
	{
		m_CharacterTargetRot = transform.localRotation;
	}
	void Update () {
		LookRotation (gameObject.transform, cam.transform);
    }

	public void LookRotation(Transform character, Transform camera)
	{
		float xRot = CrossPlatformInputManager.GetAxis("Mouse Y") * rotateSpeed;
		float yRot = CrossPlatformInputManager.GetAxis("Mouse X") * rotateSpeed;
		m_CharacterTargetRot *= Quaternion.Euler (0f, yRot, 0f);
		if(smooth)
			character.localRotation = Quaternion.Slerp (character.localRotation, m_CharacterTargetRot,
				smoothTime * Time.deltaTime);
		else
			character.localRotation = m_CharacterTargetRot;
	}
}
