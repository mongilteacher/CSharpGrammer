using System.Collections;
using System.Collections.Generic; // 제네릭 컬렉션
using UnityEngine;

public class GenericCollectionExmaple : MonoBehaviour
{
    // 제네릭 컬렉션
    // - 기존 컬렉션이 가진 박싱/언박싱에 의한 성능 저하 문제를 해결한 자료구조
    // - 제네릭에 의해 사용할 때 타입이 결정된다.

    void Start()
    {
        // ArrayList -> List<T>
        List<string> myList = new List<string>();
        myList.Add("민예진");
        myList.Add("전민성");


        // Hashtable -> Dictionary<TKey, TValue>
        Dictionary<string, int> myTable = new Dictionary<string, int>();
        myTable.Add("민예진", 13);
        myTable.Add("전민성", 23);
        myTable["이성민"] = 22;

        // 제네릭 컬렉션의 제한 조건은 박싱/언박싱으로부터 벗어날 수 있게 해준다.
        // List<int>는 int 자료형의 데이터만 처리하므로 object 형변환이 일어나지 않는다.

        // 마이크로 소프트에서는 일반 컬렉션 의 사용을 권장하지 않는다.
        // -> 제네릭 컬렉션이 나중에 추가됐으므로 호환성을 위해 남겨놓았을 뿐...
    }
}
