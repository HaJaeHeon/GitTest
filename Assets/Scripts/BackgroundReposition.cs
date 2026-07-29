using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundReposition : MonoBehaviour
{
    public float mapSize;

    [SerializeField] private Transform playerTransform;

    private float diffX;
    private float diffY;
    private float halfSize;

    private void Start()
    {
        float diffX = playerTransform.position.x - transform.position.x;
        float diffY = playerTransform.position.y - transform.position.y;
        halfSize = mapSize / 2;
    }

    private void Update()
    {
        float currentDistanceX = playerTransform.position.x - transform.position.x;
        float currentDistanceY = playerTransform.position.y - transform.position.y;

        if( Mathf.Abs(currentDistanceX - diffX) > halfSize)
        {
            if(currentDistanceX < 0)
            {
                transform.position = new Vector3(transform.position.x - mapSize, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x + mapSize, transform.position.y,  transform.position.z);
            }
        }
        if( Mathf.Abs(currentDistanceY - diffY) > halfSize)
        {
            if(currentDistanceY < 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - mapSize, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + mapSize, transform.position.z);
            }
        }
    }


    //하이라키에서 정렬하기
    //[ContextMenu("정렬")]
    //public void sorting()
    //{
    // int columns = 13;         // 가로 개수 (9x9 이므로 9)
    // float spacingX = 2.15f;   // 가로 간격
    // float spacingY = 2.15f;
    //// 1. 자식들을 리스트에 담습니다.
    //List<Transform> children = new List<Transform>();
    //    for (int i = 0; i < transform.childCount; i++)
    //    {
    //        children.Add(transform.GetChild(i));
    //    }

    //    // 2. 자연 정렬 (1, 2, ... 10, 11 순서)
    //    children.Sort((a, b) =>
    //    {
    //        string nameA = Regex.Replace(a.name, @"\d+", m => m.Value.PadLeft(10, '0'));
    //        string nameB = Regex.Replace(b.name, @"\d+", m => m.Value.PadLeft(10, '0'));
    //        return nameA.CompareTo(nameB);
    //    });

    //    // 3. 정렬 순서 적용 및 9x9 위치 배치
    //    for (int i = 0; i < children.Count; i++)
    //    {
    //        // 하이어라키(Hierarchy) 순서 적용
    //        children[i].SetSiblingIndex(i);

    //        // 행(Row)과 열(Column) 계산
    //        int row = i / columns; // 몫: 줄 바꿈 역할 (0, 0.. 1, 1.. 2, 2..)
    //        int col = i % columns; // 나머지: 가로 위치 역할 (0, 1, 2.. 8, 0, 1..)

    //        // 위치 계산 (Y축은 보통 아래로 쌓이므로 마이너스(-)를 붙여줍니다)
    //        float posX = col * spacingX;
    //        float posY = -row * spacingY;

    //        // 부모 기준으로 위치(LocalPosition) 이동
    //        children[i].localPosition = new Vector3(posX -12, posY +12, 0);
    //    }
    //}
}
