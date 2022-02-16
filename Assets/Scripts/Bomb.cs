using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public bool ActiveBomb;
    [SerializeField] private ParticleSystem _explode;
    [SerializeField] private float _timeToDestroyBomb;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (ActiveBomb)
        {
            IDamageble idamage = other.GetComponent<IDamageble>();
            if (idamage != null)
            {
                Instantiate(_explode, transform.position, Quaternion.identity);
                idamage.TakeDamage();
                Destroy(gameObject, _timeToDestroyBomb);

            }
        }
    }
    private void Start() => StartCoroutine(c_Blinking(GetComponent<SpriteRenderer>()));

    private IEnumerator c_Blinking(SpriteRenderer image)
    {
        yield return new WaitForSeconds(2f);
        ActiveBomb = true;

        Color c = image.color;

        float alpha = 1.0f;

        while (true)
        {
            c.a = Mathf.MoveTowards(c.a, alpha, Time.deltaTime);

            image.color = c;

            if (c.a == alpha)
            {
                if (alpha == 1.0f)
                {
                    alpha = 0.3f;
                }
                else
                    alpha = 1.0f;
            }

            yield return null;
        }
    }
}
