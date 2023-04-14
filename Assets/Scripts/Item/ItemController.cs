using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UniRx;

public class ItemController : MonoBehaviour
{
    [SerializeField] private ItemModel _itemModel;

    [SerializeField] private ItemView _itemView;
    // Start is called before the first frame update
    void Start()
    {
        _itemView.num
            .Subscribe(n => _itemModel.SetNum(n)).AddTo(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
