using UnityEngine;
public class Weapon : MonoBehaviour
{
    public GameObject _bulletPrefab;
    public CharacterClass _larme;

    public void Start()
    {
        _bulletPrefab = _larme.Tears.larme;
    }
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;

        Vector3 shootDirection = mouseWorldPosition - transform.position;

        GameObject bullet = Instantiate(_bulletPrefab);

        bullet.transform.position = transform.position;

        Bullet bulletBehaviour = bullet.GetComponent<Bullet>();
        bulletBehaviour.Direction = shootDirection;
    }
}
