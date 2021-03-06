﻿using JCMG.JTween;
using UnityEngine;

namespace SampleContent
{
	internal class LocalRotationExample : MonoBehaviour
	{
		private void Start()
		{
			transform.RotateYLocal(360f, 2f, loopType:LoopType.Restart, loopCount:-1);
		}

		#if UNITY_EDITOR

		private void OnDrawGizmos()
		{
			UnityEditor.Handles.color = Color.green;
			UnityEditor.Handles.DrawWireDisc(transform.position, transform.up, 1f);
		}

		#endif
	}
}
