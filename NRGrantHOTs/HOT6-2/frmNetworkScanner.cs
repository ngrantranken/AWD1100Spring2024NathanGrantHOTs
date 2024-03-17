using Accessibility;
using System.Net;
using System.Xml.Serialization;

namespace HOT6_2
{
    public partial class frmNetworkScanner : Form
    {
        List<Computer> computers;

        public frmNetworkScanner()
        {
            InitializeComponent();
            InitializeComputers();
        }

        private void InitializeComputers()
        {
            computers = new List<Computer>()
            {
                new Computer("My-Desktop", "127.0.0.1", new int[]{ 20, 21, 23, 25, 53, 80, 123, 389, 443}),
                new Computer("google-public-dns-a", "8.8.8.8", new int[] { 53 }),
                new Computer("ranken.edu", "47.44.246.80", new int[]{ 25, 80, 443})
            };
        }

        private Computer ScanIpAddress(string ipAddress)
        {
            foreach (var computer in computers)
            {
                if (computer.IpAddress ==  ipAddress)
                {
                    return computer;
                }
            }
            return null;
        }

        private void ShowComputer(Computer computer)
        {
            if (computer != null)
            {
                string servicesInfo = "";
                foreach (var service in computer.Services)
                {
                    string serviceName;
                    switch(service)
                    {
                        case 20:
                            serviceName = "FTP_DATA";
                            break;
                        case 21:
                            serviceName = "FTP_CONTROL";
                            break;
                        case 23:
                            serviceName = "TELNET";
                            break;
                        case 25:
                            serviceName = "SMTP";
                            break;
                        case 53:
                            serviceName = "DNS";
                            break;
                        case 80:
                            serviceName = "HTTP";
                            break;
                        case 123:
                            serviceName = "NTP";
                            break;
                        case 389:
                            serviceName = "LDAP";
                            break;
                        case 443:
                            serviceName = "HTTPS";
                            break;
                        default:
                            serviceName = "Unknown";
                            break;
                    }
                    servicesInfo += $"{service}: {serviceName}\n";
                }
                lblComputerName.Text = computer.Name;
                lblComputerIpAddress.Text = computer.IpAddress;
                lblServices.Text = "Services";
                lblDisplayServices.Text = servicesInfo;
            }
            else
            {
                lblComputerName.Text = "Request Timed Out";
                lblComputerIpAddress.Text = txtIpAddress.Text;
                lblDisplayServices.Text = "NONE";
            }
        }

        private void ValidateAndPerformScan()
        {
            string ipAddress = txtIpAddress.Text.Trim();
            if (!string.IsNullOrEmpty(ipAddress) ) 
            {
                Computer computer = ScanIpAddress(ipAddress);
                ShowComputer(computer);
            }
            else
            {
                MessageBox.Show("Please enter an IP Address.", "ERROR: NULL ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ValidateAndPerformScan();
        }
    }
}
