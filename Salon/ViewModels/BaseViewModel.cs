using Microsoft.WindowsAzure.Storage;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Salon.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public async void DisplayAlert(string title, string message, string okay)
        {
            await App.Current.MainPage.DisplayAlert(title, message, okay);
        }
        public async void DisplayActioSheet(string title, string cancel, string delete, params string[] others)
        {
            await App.Current.MainPage.DisplayActionSheet(title, cancel, delete, others);
        }
        private async void UpLoadImageButton_Clicked(Image  image)
        {
            //! added using Plugin.Media;
            await CrossMedia.Current.Initialize();

            //// if you want to take a picture use this
            // if(!CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.Current.IsCameraAvailable)
            /// if you want to select from the gallery use this
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                 DisplayAlert("Not supported", "Your device does not currently support this functionality", "Ok");
                return;
            }

            //! added using Plugin.Media.Abstractions;
            // if you want to take a picture use StoreCameraMediaOptions instead of PickMediaOptions
            var mediaOptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Medium
            };
            // if you want to take a picture use TakePhotoAsync instead of PickPhotoAsync
            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaOptions);

            if (image == null)
            {
                DisplayAlert("Error", "Could not get the image, please try again.", "Ok");
                return;
            }

             image.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());
            UploadImage(selectedImageFile.GetStream());

        }
        public async void UploadImage(Stream imageToUpload)
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=salonimages;AccountKey=jkYCUdbL4gQBdp/Q7nXj3Y+VWunKlqF9upxuHkYzJ798Us5bC5F8PhZ8elJV45ZnipaKAqgxSeydHWNR/WxcmQ==;EndpointSuffix=core.windows.net";
            var account = CloudStorageAccount.Parse(connectionString);
            var blobClient = account.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("salonimages");
            string uniqueName = Guid.NewGuid().ToString();
            var blockBlob = container.GetBlockBlobReference($"{uniqueName}.jpg");
            await blockBlob.UploadFromStreamAsync(imageToUpload);
            string thePlaceInTheInternetWhereThisImageIsNowLocated = blockBlob.Uri.OriginalString;
        }
    }
}
