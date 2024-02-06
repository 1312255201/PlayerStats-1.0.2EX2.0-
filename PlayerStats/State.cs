using System.Collections.Generic;
using MEC;
using UnityEngine;
using System.Collections;
namespace YYYLike
{
	internal static class State {

		private static List<CoroutineHandle> _coroutines;
		public static Queue hint_q;
		internal static void Refresh() {
			if (_coroutines != null) {
				foreach (CoroutineHandle coroutineHandle in _coroutines)
				{
					Timing.KillCoroutines(coroutineHandle);
				}
			}
			_coroutines = new List<CoroutineHandle>();
			hint_q = new Queue();

		}

		internal static void RunCoroutine(IEnumerator<float> coroutine) {
			AddCoroutine(Timing.RunCoroutine(coroutine));
		}

		internal static void AddCoroutine(CoroutineHandle handle) {
			_coroutines.Add(handle);
		}
	}
}