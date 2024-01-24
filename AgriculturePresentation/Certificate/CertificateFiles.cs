using System.Security.Cryptography.X509Certificates;

public class CertificateFiles
{
    public void LoadCertificate()
    {
        try
        {
            string pfxFilePath = "C:\\Users\\TOPRAK\\OneDrive\\Masaüstü\\AgriculturePresentation\\Cert.pfx";
            string password = "testPassword";

            // Create a collection object and populate it using the PFX file
            X509Certificate2Collection collection = new X509Certificate2Collection();
            collection.Import("C:\\Users\\TOPRAK\\OneDrive\\Masaüstü\\AgriculturePresentation\\Cert.pfx", "testPassword", X509KeyStorageFlags.PersistKeySet);

            // Your certificate is in the collection now
            X509Certificate2 certificate = collection[0];
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

