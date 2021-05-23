using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace HWIDSpoofer
{
	class Program
	{

		//generates random string
		private static Random random = new Random();
		public static string RandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}
		public static void spoofCentralProcessor(string generatedID)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("SystemProductName", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("Previous Update Revision", generatedID);
			registryKey.SetValue("ProcessorNameString", generatedID);
			registryKey.SetValue("VendorIdentifier", generatedID);
			registryKey.SetValue("Platform Specific Field1", generatedID);
			registryKey.SetValue("Component Information", generatedID);
			registryKey.Close();
		}

		public static void spoofDisk1(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
		public static void spoofDisk2(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
		public static void spoofDisk3(string generatedID)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 2\\Target Id 0\\Logical Unit Id 0", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
		public static void spoofDisk4(string generatedID)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 3\\Target Id 0\\Logical Unit Id 0", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
		public static void spoofDisk5(string generatedID)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
		public static void spoofDiskPort1(string generatedID)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 1\\Scsi Bus 0\\Initiator Id ", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
		public static void spoofSystemControllSet(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\SystemInformation", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("BIOSReleaseDate", "14/12/2020");
			registryKey.SetValue("BIOSVersion", generatedID);
			registryKey.SetValue("ComputerHardwareId", "{c2ca38ff-ab7f-5d23-ba6b-3f01afc1488d}");
			registryKey.SetValue("ComputerHardwareIds", "{id}");
			registryKey.SetValue("SystemManufacturer", generatedID);
			registryKey.SetValue("SystemProductName", generatedID);
			registryKey.Close();
		}
		public static void spoofBiosInfo(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("BIOSVendor", generatedID);
			registryKey.SetValue("BIOSReleaseDate", generatedID);
			registryKey.SetValue("ProductId", generatedID);
			registryKey.SetValue("ProcessorNameString", generatedID);
			registryKey.SetValue("BaseBoardProduct", generatedID);
			registryKey.SetValue("SystemProductName", generatedID);
			registryKey.SetValue("SystemSKU", generatedID);
			registryKey.Close();
		}
		public static void spoofCurrentConstrollSet(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("MatchingDeviceId", generatedID);
			registryKey.SetValue("InfPath", generatedID);
			registryKey.SetValue("InfSection", generatedID);
			registryKey.SetValue("DriverVersion", generatedID);
			registryKey.SetValue("DriverDateData", generatedID);
			registryKey.SetValue("DriverDate", generatedID);
			registryKey.Close();
		}
		public static void spoofCurrentConstrollSet2(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0001", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("MonitorCapabilityList", generatedID);
			registryKey.SetValue("MatchingDeviceId", generatedID);
			registryKey.SetValue("InfSection", generatedID);
			registryKey.SetValue("InfPath", generatedID);
			registryKey.Close();
		}
		public static void spoofWindows(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("SusClientId", generatedID);
			registryKey.SetValue("SusClientIdValidation", generatedID);
			registryKey.SetValue("LastDownloadsPurgeTime", "2020-14-04 06:29:29");
			registryKey.Close();
		}
		public static void spoofWindows2(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001", true);

			if (registryKey == null)
				return;

			registryKey.SetValue("ComponentId", generatedID);
			registryKey.SetValue("DeviceInstanceID", generatedID);
			registryKey.SetValue("DriverVersion", generatedID);
			registryKey.SetValue("InfPath", generatedID);
			registryKey.SetValue("InfSection", generatedID);
			registryKey.SetValue("MatchingDeviceId", generatedID);
			registryKey.SetValue("NetCfgInstanceId", generatedID);
			registryKey.Close();
		}
		public static void spoofWindowsActivation(string generatedID)
        {
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("", true);
		}
		static void Main(string[] args)
        {
			Console.WriteLine("Do you want to spoof, y - yes/n- no:");
			string generatedID = RandomString(10); //add here some id if want
			string str = Convert.ToString(Console.ReadLine());
            if (str == "y")
            {
				spoofCentralProcessor(generatedID);
				Console.WriteLine("[+] Central Processor successfully spoofed [+]");
				//-----------------------------------------------------
				spoofDisk1(generatedID);
				spoofDisk2(generatedID);
				spoofDisk3(generatedID);
				spoofDisk4(generatedID);
				spoofDisk5(generatedID);
				spoofDiskPort1(generatedID);
				Console.WriteLine("[+] Disks got spoofed [+]");
				//-----------------------------------------------------
				spoofSystemControllSet(generatedID);
				Console.WriteLine("[+] Controll Set was spofed [+]");
				//-----------------------------------------------------
				spoofBiosInfo(generatedID);
				Console.WriteLine("[+] Bios got spoofed [+]");
				//-----------------------------------------------------
				spoofCurrentConstrollSet(generatedID);
				spoofCurrentConstrollSet2(generatedID);
				Console.WriteLine("[+] Current controll set was spoofed [+]");
				//-----------------------------------------------------
				spoofWindows(generatedID);
				spoofWindows2(generatedID);
				Console.WriteLine("[+] Windows was spoofed [+]");
				//-----------------------------------------------------
				Console.WriteLine();
				Console.WriteLine("Press any key to exit program:");
				Console.ReadKey();
			}	
		}
    }
}
