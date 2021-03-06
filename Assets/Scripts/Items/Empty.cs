using System;
using System.Collections;
using System.Collections.Generic;
using FallingSandSimultion;
using UnityEngine;

namespace FallingSandSimulation.Items {
    public class Empty : BaseSandItem {
        protected override void Start() {
            base.Start();
        }

        protected override void Update() {
            base.Update();
        }

        public Empty() : base(SandTypeEnum.Empty) {
        }
    }
}