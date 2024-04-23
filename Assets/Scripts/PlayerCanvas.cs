using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCanvas : MonoBehaviour
{

    private void Awake()
    {
        PlayerController.OnLifeChanged += DisplayDamage;
    }

    void DisplayDamage(int life)
    {
        GameObject damage = new GameObject("Damage");
        TextMeshProUGUI damageText = damage.AddComponent<TextMeshProUGUI>();
        damageText.fontSize = 0.5f;
        damageText.text = "-1";
        damageText.alignment = TextAlignmentOptions.Center;

        GameObject instantiated = Instantiate(damage, transform);

        StartCoroutine(DestroyInstantiated(instantiated));

    }

    IEnumerator DestroyInstantiated(GameObject instantiated)
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(instantiated);
    }

}
