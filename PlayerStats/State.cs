using System.Collections.Generic;
using MEC;
using UnityEngine;

namespace YYYLike
{
	internal static class State {
		internal static int LuresCount;
		internal static int CleanupTime;

		internal static List<BreakableWindow> BreakableWindows;
		internal static Dictionary<ReferenceHub, int> AfkTime;
		internal static Dictionary<ReferenceHub, Vector3> PrevPos;

		internal static Dictionary<Pickup, int> Pickups;
		internal static Dictionary<Ragdoll, int> Ragdolls;

		private static List<CoroutineHandle> _coroutines;

		internal static void Refresh() {
			if (_coroutines != null) {
				Timing.KillCoroutines(_coroutines);
			}

			_coroutines = new List<CoroutineHandle>();

			LuresCount = 0;
			CleanupTime = 0;

			Pickups = new Dictionary<Pickup, int>();
			Ragdolls = new Dictionary<Ragdoll, int>();
			AfkTime = new Dictionary<ReferenceHub, int>();
			PrevPos = new Dictionary<ReferenceHub, Vector3>();
			BreakableWindows = new List<BreakableWindow>();
		}

		internal static void RunCoroutine(IEnumerator<float> coroutine) {
			AddCoroutine(Timing.RunCoroutine(coroutine));
		}

		internal static void AddCoroutine(CoroutineHandle handle) {
			_coroutines.Add(handle);
		}
	}
}