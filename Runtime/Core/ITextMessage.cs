namespace FinTOKMAK.TextTimeline.Runtime.Core
{
    public interface ITextMessage
    {
        /// <summary>
        /// The scaled time stamp in the timeline.
        /// </summary>
        float timelineTimeStamp { get; }
        
        /// <summary>
        /// The unscaled time stamp in the timeline.
        /// Take the pause node into consideration.
        /// </summary>
        float unscaledTimeStamp { get; }
        
        /// <summary>
        /// The content of the message.
        /// </summary>
        string content { get; }
    }
}