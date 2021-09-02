using System;

namespace ProjectViewer.Models.Interfaces
{
    public interface ITimestampModel
    {
        DateTime CreationTimestamp { get; }
        DateTime LastModifyTimestamp { get; }
    }
}