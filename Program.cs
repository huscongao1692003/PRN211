namespace PRNProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1nQ1BMaV1CX2BZd1l3TWlcfU4BCV5EYF5SRHBeSl1qSHZWdE1rWHs=;Mgo+DSMBPh8sVXJ1S0R+X1pDaV5KQmFJfFBmTGlYd1R1dkU3HVdTRHRcQltiQX5ad01mW3ZdcnU=;ORg4AjUWIQA/Gnt2VFhiQlJPcUBDVXxLflF1VWpTflZ6cVdWESFaRnZdQV1lSHZTf0RrXH1XdXVU;MjQ1Mzg2M0AzMjMxMmUzMDJlMzBLVXZOUXcyZ0pCTVpORnNOYURRQlBTNWg3Zy9FcW9sYVpVRFJyV2V4NUJrPQ==;MjQ1Mzg2NEAzMjMxMmUzMDJlMzBHWWV0a3AzL2plbGNSejhvMHV2Z04vdlpYdWxCaE1mM1FwbEovZEVSUHE0PQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVhdXGtWfFN0RnNQdV94flBEcC0sT3RfQF5jT39bdkxiUXpdcXVWRw==;MjQ1Mzg2NkAzMjMxMmUzMDJlMzBHTFdmVzNGSjlJQ1RNL3cwbEI4UlVURVZZK1RPeThnUUhLUDlnZHhDSHJJPQ==;MjQ1Mzg2N0AzMjMxMmUzMDJlMzBsdnZJOHpRNFQxZll0bHU1NXpISWk3RmFsTnREZDFzYVE0NW9oSGRWQXpVPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPcUBDVXxLflF1VWpTflZ6cVdWESFaRnZdQV1lSHZTf0RrXHxfeXxU;MjQ1Mzg2OUAzMjMxMmUzMDJlMzBiYnZqZzU1c1NxbDNBUVhZdUxQbTEvV3QwdE04ZlJ2N1p2Q0VsaGhCM1E0PQ==;MjQ1Mzg3MEAzMjMxMmUzMDJlMzBnOEtNaG9RamxNZlY1dnJSK0VjYWM1bUR1RVVESWVqYUJKaTRONlZ0UStZPQ==;MjQ1Mzg3MUAzMjMxMmUzMDJlMzBHTFdmVzNGSjlJQ1RNL3cwbEI4UlVURVZZK1RPeThnUUhLUDlnZHhDSHJJPQ==");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}