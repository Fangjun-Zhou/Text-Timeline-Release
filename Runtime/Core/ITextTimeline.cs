using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FinTOKMAK.TextTimeline.Runtime.Core
{
    public interface ITextTimeline
    {
        #region Timeline callbacks

        /// <summary>
        /// The event triggered when the pause node is played,
        /// and the TextTimeline system automatically pause the timeline.
        /// </summary>
        Action onPauseNodeActivated { get; }
        
        /// <summary>
        /// The event triggered when a text message is played.
        /// </summary>
        Action<ITextMessage> onPlayMessage { get; }

        #endregion
        
        /// <summary>
        /// Load the ass file from a specific file path.
        /// </summary>
        /// <param name="filePath">the absolute path of the file</param>
        void LoadFile(string filePath);

        /// <summary>
        /// The async version of LoadFile method.
        /// </summary>
        /// <param name="filePath">the absolute path of the file</param>
        void LoadFileAsync(string filePath);

        /// <summary>
        /// Unload the ass file and clear all the cache.
        /// </summary>
        void Clear();

        /// <summary>
        /// Play the timeline.
        /// </summary>
        /// <param name="startTime">the start playing time</param>
        /// <param name="timeScale">the playing speed, set to negative to play backwards</param>
        void Play(float startTime = 0, float timeScale = 1);

        /// <summary>
        /// Offset the text timeline system to align the timeline.
        /// </summary>
        /// <param name="offset">the time to offset. Positive when need to delay the timeline.
        /// Negative when need to fast forward.</param>
        void Offset(float offset);

        /// <summary>
        /// Stop playing.
        /// </summary>
        void Stop();

        /// <summary>
        /// Resume timeline.
        /// </summary>
        void Resume();
    }
}
