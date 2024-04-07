using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Example : MonoBehaviour
{
	[SerializeField] MstItems mstItems;
	[SerializeField] Dialog mDialogs;
	[SerializeField] Text text;

	void Start()
	{
		ShowItems2();
	}

	void ShowItems()
	{
		string str = "";

		mstItems.Entities
			.ForEach(entity => str += DescribeMstItemEntity(entity) + "\n");

		text.text = str;
	}

	string DescribeMstItemEntity(MstItemEntity entity)
	{
		return string.Format(
			"{0} : {1}, {2}, {3}, {4}, {5}",
			entity.id,
			entity.name,
			entity.price,
			entity.isNotForSale,
			entity.rate,
			entity.category
		);
	}

    void ShowItems2()
    {
        string str = "";

        mDialogs.Entities
            .ForEach(entity => str += DescribeMstItemEntity2(entity) + "\n");

        text.text = str;
    }

    string DescribeMstItemEntity2(DialogEntity entity)
    {
        return string.Format(
            "{0} : {1}, {2}",
            entity.index,
            entity.name,
			entity.dialog
        );
    }
}

