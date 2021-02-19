using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TuFarmaApp.Models;

namespace TuFarmaApp.Interfaces
{
    public enum MediaFileType
    {
        Image,
        Video
    }

    public interface IMultiMediaPickerService
    {
        event EventHandler<MediaFile> OnMediaPicked;
        event EventHandler<IList<MediaFile>> OnMediaPickedCompleted;

        Task<IList<MediaFile>> PickPhotosAsync(int Limit = 0);

        //Task<IList<MediaFile>> PickPhotosAsync();
        Task<IList<MediaFile>> PickVideosAsync();
        void Clean();
    }
}
