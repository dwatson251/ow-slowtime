using OWML.ModHelper;
using OWML.Common;
using UnityEngine;

namespace SlowTime
{
    public class SlowTime : ModBehaviour
    {
		private readonly float loopLengthSeconds = 60 * 60; // 1 hour loop time

		private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"My mod {nameof(SlowTime)} is loaded!", MessageType.Success);
        }

        private void Update()
        {
            float multiplier = TimeLoop.GetLoopDuration() / this.loopLengthSeconds;
            float timeRemaining = TimeLoop.GetLoopDuration() - (Time.timeSinceLevelLoad * multiplier);
            TimeLoop.SetSecondsRemaining(timeRemaining);
        }
    }
}
