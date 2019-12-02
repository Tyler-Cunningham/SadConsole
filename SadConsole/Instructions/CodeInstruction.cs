﻿using System;

namespace SadConsole.Instructions
{
    /// <summary>
    /// An instruction with a code callback.
    /// </summary>
    public class CodeInstruction : InstructionBase
    {
        private Func<IScreenObject, bool> _callback;

        /// <summary>
        /// Friendly ID to help track what this code instruction was created from since it cannot be fully serialized.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Creates a new instruction with the specified callback.
        /// </summary>
        /// <param name="callback">The code invoked by this instruction. Return <see langword="true"/> to set <see cref="InstructionBase.IsFinished"/>.</param>
        public CodeInstruction(Func<IScreenObject, bool> callback) =>
            _callback = callback;

        private CodeInstruction() { }

        /// <inheritdoc />
        public override void Update(IScreenObject componentHost)
        {
            IsFinished = _callback(componentHost);

            base.Update(componentHost);
        }

        /// <summary>
        /// Sets the callback used by the instruction.
        /// </summary>
        /// <param name="callback">The code invoked by this instruction. Return <see langword="true"/> to set <see cref="InstructionBase.IsFinished"/>.</param>
        public void SetCallback(Func<IScreenObject, bool> callback) =>
            _callback = callback;
    }
}