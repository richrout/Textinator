using System;
using Android.App;
using Android.Telephony;
using Xamarin.Forms;
using RichRout.Textinator.Droid;
using RichRout.Textinator.Interfaces;
using RichRout.Textinator.Repository;

[assembly: Dependency(typeof(SmsService))]

namespace RichRout.Textinator.Droid
{
    public class SmsService : ISmsService
    {
        public void Send(string to, string message)
        {
            SmsManager.Default.SendTextMessage(to, null, message, null, null);
        }
    }
}