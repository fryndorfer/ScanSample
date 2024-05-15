﻿namespace ScanSample.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void ContentPage_Unloaded(object sender, EventArgs e)
    {
        try
        {
            myCameraView.Handler?.DisconnectHandler();
        }
        catch (Exception)
        {

        }
    }
}
