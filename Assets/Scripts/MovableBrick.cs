using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MovableBrick : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;

    [SerializeField] private float distanceThreshold;

    [SerializeField] private List<Vector3> points;

    private bool _ballIsNear;

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, ballTransform.position);
        if (distance < distanceThreshold && !_ballIsNear)
        {
            _ballIsNear = true;
            var otherPoints = new List<Vector3>(points);
            otherPoints.Remove(transform.position);
            var index = Random.Range(0, otherPoints.Count);
            var pos = otherPoints[index];
            transform.DOMove(pos, 1).OnComplete(OnMoved);
        }
    }

    private void OnMoved()
    {
        _ballIsNear = false;
    }
}
