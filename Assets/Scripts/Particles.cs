using UnityEngine;

public class Particles : MonoBehaviour
{

    private ParticleSystemRenderer _PSR;
    private float _inputX;

    private void Start()
    {
        _PSR = GetComponent<ParticleSystemRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _inputX = Input.GetAxis("Horizontal");

        if (_inputX > 0)
            _PSR.flip = new Vector3(1, 0, 0);
        else
            _PSR.flip = new Vector3(0, 0, 0);
    }
}
