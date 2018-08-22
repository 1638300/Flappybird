using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour 
{
  [SerializeField] private float destroyDelayInSeconds = 20f;

  private void OnEnable()
  {
    StartCoroutine(DestroyRoot());
  }
  private void OnDisable()
  {
    StopAllCoroutines();
  }

  private IEnumerator DestroyRoot()
  {
    while (true)
    {
      yield return new WaitForSeconds(destroyDelayInSeconds);
      DeletePrefab();
    }
  }

  private void DeletePrefab()
  {
    Destroy(transform.root.gameObject);
  }
}
