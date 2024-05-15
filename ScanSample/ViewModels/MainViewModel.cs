using BarcodeScanning;

namespace ScanSample.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    bool isCameraEnabled;

    [ObservableProperty]
    bool isPauseScanning;

    [RelayCommand]
    private async Task OnAppearing()
    {
        await Methods.AskForRequiredPermissionAsync();
        IsCameraEnabled = true;
        IsPauseScanning = false;
    }

    [RelayCommand]
    private void OnDisappearing()
    {
        IsCameraEnabled = false;
    }

    [RelayCommand]
    private void OnDetectionFinished(BarcodeResult[] result)
    {
        if (result != null && result.Length > 0)
        {
            IsPauseScanning = true;
            string barcode = result[0].RawValue;

            // do something ...

            IsPauseScanning = false;
        }
    }
}
