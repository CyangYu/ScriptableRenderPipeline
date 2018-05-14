using System;
using UnityEngine;

namespace UnityEditor.VFX.Operator
{
    [VFXInfo(category = "Math/Arithmetic")]
    class Modulo : VFXOperatorNumericUniformNew
    {
        public class InputProperties
        {
            [Tooltip("The numerator operand.")]
            public float a = 1.0f;
            [Tooltip("The denominator operand.")]
            public float b = 1.0f;
        }

        override public string name { get { return "Modulo"; } }

        protected override VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            return new[] { VFXOperatorUtility.Modulo(inputExpression[0], inputExpression[1]) };
        }
    }
}
