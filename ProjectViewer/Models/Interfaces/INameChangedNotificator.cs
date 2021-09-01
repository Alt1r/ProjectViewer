using System;
using ProjectViewer.Models.EventArgs;

namespace ProjectViewer.Models.Interfaces
{
    public interface INameChangedNotificator
    {
         event EventHandler<NameChangedEventArgs> NameChanged;
    }
}