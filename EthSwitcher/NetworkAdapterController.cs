using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace EthSwitcher {
    public class NetworkAdapterController {

        private ManagementClass _managementClass;
        private ManagementObjectCollection _nics;

        public NetworkAdapterController() {
            init();
        }

        public void init() {
            _managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            _nics = _managementClass.GetInstances();
        }

        public List<String> GetAdapters() {
            init();
            List<String> list = new List<string>();
            foreach (ManagementBaseObject nic in _nics) {
                list.Add((string) nic["Caption"]);
            }
            return list;
        }

        public String GetIPAddress(String adapter) {
            init();
            String ip = "NoIPAddress";
            foreach (ManagementBaseObject nic in _nics) {
                if (nic["Caption"].Equals(adapter)) {
                    if ((bool) nic["IPEnabled"]) {
                        if ((bool) nic["DHCPEnabled"]) {
                            if (nic["IPAddress"] != null) {
                                ip = "DHCP:" + ((String[])nic["IPAddress"])[0];
                                break;
                            } else {
                                ip = "DHCP";
                                break;
                            }
                        } else if (nic["IPAddress"] != null) {
                            ip = ((String[]) nic["IPAddress"])[0];
                            break;
                        }
                    } else {
                        ip = "IP Not Active";
                    }
                }
            }
            return ip;
        }

        public String GetSubnetMask(String adapter) {
            init();
            String mask = "";
            foreach (ManagementBaseObject nic in _nics) {
                if (nic["Caption"].Equals(adapter)) {
                    if ((bool)nic["IPEnabled"]) {
                        if (nic["IPSubnet"] != null) {
                            mask = ((String[]) nic["IPSubnet"])[0];
                        }
                    }

                    break;
                }
            }
            return mask;
        }

        public String GetGateway(String adapter) {
            init();
            String gw = "";
            foreach (ManagementBaseObject nic in _nics) {
                if (nic["Caption"].Equals(adapter)) {
                    if ((bool)nic["IPEnabled"]) {
                        if (nic["DefaultIPGateway"] != null) {
                            gw = ((String[])nic["DefaultIPGateway"])[0];
                        }
                    }
                    break;
                }
            }
            return gw;
        }

        public String[] GetDnsServers(String adapter) {
            init();
            String[] dns = {"", ""};
            foreach (ManagementBaseObject nic in _nics) {
                if (nic["Caption"].Equals(adapter)) {
                    if ((bool)nic["IPEnabled"]) {
                        if (nic["DNSServerSearchOrder"] != null) {
                            String[] d = (string[]) nic["DNSServerSearchOrder"];
                            dns[0] = d[0];
                            if (d.Count() >= 2) {
                                dns[1] = d[1];
                            }
                        }
                    }
                    break;
                }
            }
            return dns;
        }

        public String GetMacAddress(String adapter) {
            init();
            String mac = "";
            foreach (ManagementBaseObject nic in _nics) {
                if (nic["Caption"].Equals(adapter)) {
                    mac = (string) nic["MACAddress"];
                    break;
                }
            }
            return mac;
        }

        /*Adapter Setting*/
        public bool SetIPAddress(String adapter, String ip_address, String subnet_mask) {
            init();
            if (String.IsNullOrWhiteSpace(ip_address) || String.IsNullOrWhiteSpace(subnet_mask)) {
                foreach (var o in _nics) {
                    var nic = (ManagementObject) o;
                    if (nic["Caption"].Equals(adapter)) {
                        nic.InvokeMethod("EnableDHCP", null, null);
                        return false;
                    }
                }
                return true;
            } else {
                foreach (var o in _nics) {
                    var nic = (ManagementObject) o;
                    if (nic["Caption"].Equals(adapter)) {
                        var newIP = nic.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new[] {ip_address};
                        newIP["SubnetMask"] = new[] {subnet_mask};

                        nic.InvokeMethod("EnableStatic", newIP, null);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool SetGateway(String adapter, String gateway) {
            init();
            if (String.IsNullOrWhiteSpace(gateway)) {
                gateway = null;
            }
            foreach (var o in _nics) {
                var nic = (ManagementObject) o;
                if (nic["Caption"].Equals(adapter)) {
                    var newGateway = nic.GetMethodParameters("SetGateways");
                    if (gateway != null) {
                        newGateway["DefaultIPGateway"] = new[] {gateway};
                        newGateway["GatewayCostMetric"] = new[] {1};
                    } else
                    {
                        newGateway = null;
                    }

                    nic.InvokeMethod("SetGateways", newGateway, null);
                    return true;
                }
            }
            return false;
        }

        public bool SetDNSServers(String adapter, String[] dnsservers) {
            init();
            if (String.IsNullOrWhiteSpace(dnsservers[0])) {
                dnsservers = null;
            } else if(String.IsNullOrWhiteSpace(dnsservers[1])) {
                dnsservers = new[] {dnsservers[0]};
            }

            foreach (var o in _nics) {
                var nic = (ManagementObject) o;
                if (nic["Caption"].Equals(adapter)) {
                    var newDNS = nic.GetMethodParameters("SetDNSServerSearchOrder");

                    if (dnsservers != null) {
                        newDNS["DNSServerSearchOrder"] = dnsservers;
                    } else {
                        newDNS["DNSServerSearchOrder"] = new string[]{};
                    }

                    nic.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    return true;
                }
            }
            return false;
        }
    }
}
