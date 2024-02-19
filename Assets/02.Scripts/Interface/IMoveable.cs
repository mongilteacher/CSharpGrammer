using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인터페이스: 두 사물의 접점에서 통신을 할 수 있는 방법이나 수단
// ex). TV 리모콘, USB 포트
// 특징.
// 1. 통신을 할 수 있는 수단
// 2. 지켜야 하는 약속!

// 장점.
// - 표준화가 가능하다. (개발 시간을 단축시킬 수 있다.)
// - 서로 관계가 없는 클래스들에게 관계를 맺어줄 수 있다.
// - 독립적인 프로그래밍이 가능하다.
public interface IMoveable     // 움직일 수 있는 약속
{
    void Move();
}