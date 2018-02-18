using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace TestsLibrary
{
	[TestFixture]
	public class MyClassTest
	{
		[Test]
		public void FirstAppiumTest ()
		{
			DesiredCapabilities capabilities = new DesiredCapabilities();
			capabilities.SetCapability("deviceName", "emulator-5554");
			capabilities.SetCapability("platformVersion","7.1.1");
			capabilities.SetCapability("fullReset","True");
			capabilities.SetCapability(MobileCapabilityType.App, "Focus-4.0.2.apk");
			capabilities.SetCapability("platformName", "Android");
			AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);

			driver.GetAppStringDictionary ();
		}
	}
}

