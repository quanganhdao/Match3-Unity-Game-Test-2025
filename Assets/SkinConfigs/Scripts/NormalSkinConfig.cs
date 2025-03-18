using System.Collections.Generic;
using UnityEngine;
using static NormalItem;

[CreateAssetMenu(fileName = "NormalSkinConfig", menuName = "NormalSkinConfig", order = 0)]
public class NormalSkinConfig : ScriptableObject
{
	[SerializeField] private List<PairConfig<eNormalType, Sprite>> typeToSprites;


	public Sprite GetSprite(eNormalType type)
	{
		foreach (var pair in typeToSprites)
		{
			if (pair.Key == type)
			{
				return pair.Value;
			}
		}

		return null;
	}
}