using UnityEngine;

// 보간: 시작점과 끝점이 주여졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율) -> 0 ~ 1 사이의 값
// 뭔가를 "부드럽게"할 때 사용

// 구면선형보간(Slerp: Sphercial Linear Interpolation) ->
// 직선 형태가 아닌 "구면" 형태로 값을 추론한다.
// 시작점과 종료점은 느리게 증가하고, 중간지점은 빠르게 이동하는 특성 
// -> 자연스러운 회전 로직에 많이 사용한다.
public class SlerpExample : MonoBehaviour
{
    public Transform Start;
    public Transform End;

    public float Duration = 3f;
    
    private float _progress;    // 진행률: 0 ~ 1
    
    void Update()
    {
        _progress += Time.deltaTime / Duration;
        // Vector3.Lerp(시작 좌표, 종료 좌표, 진행률)
        transform.position = Vector3.Slerp(Start.position, End.position, _progress);
    }
}