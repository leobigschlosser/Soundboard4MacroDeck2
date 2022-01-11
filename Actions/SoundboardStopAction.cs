﻿using Soundboard4MacroDeck.Models;
using Soundboard4MacroDeck.Services;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;

namespace Soundboard4MacroDeck.Actions
{
    public class SoundboardStopAction : PluginAction
    {
        /// <summary>
        /// Name of the action
        /// </summary>
        public override string Name => LocalizationManager.Instance.ActionStopSoundName;

        /// <summary>
        /// A short description what this action does
        /// </summary>
        public override string Description => LocalizationManager.Instance.ActionStopSoundDescription;

        /// <summary>
        /// Set true if the plugin can be configured.
        /// </summary>
        public override bool CanConfigure => false;

        /// <summary>
        /// Gets called when the button with this action gets pressed.
        /// </summary>
        /// <param name="clientId">Returns the client id</param>
        /// <param name="actionButton">Returns the pressed action button</param>
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            SoundPlayer.StopAll();
        }
    }
}
