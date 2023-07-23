using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileLifetime = 2f;

    private void OnEnable()
    {
        StartCoroutine(DeactivateAfterLifetime());
    }

    private void OnDisable()
    {
        // Assicurati di fermare la Coroutine quando il proiettile viene disattivato.
        // Per qualche motivo quando riattivavo si rompeva.
        StopAllCoroutines();
    }

    private IEnumerator DeactivateAfterLifetime()
    {
        yield return new WaitForSeconds(projectileLifetime);
        GameManager.instance.ProjectilePool.ReturnProjectile(this.gameObject);
    }
}
