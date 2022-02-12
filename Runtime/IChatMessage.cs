using FinTOKMAK.TextTimeline.Runtime.Core;
using UnityEngine;

namespace FinTOKMAK.TextTimeline.Runtime
{
    public interface IChatMessage : ITextMessage
    {
        /// <summary>
        /// The display user id.
        /// </summary>
        string userId { get; }
        
        /// <summary>
        /// The display user avatar.
        /// </summary>
        Sprite avatar { get; }
    }
}