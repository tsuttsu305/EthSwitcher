using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EthSwitcher {
    public class NetworkUtil {
        private NetworkUtil() {}

        public static bool IsIPAddressFomat(String address, bool allowNull) {
            IPAddress adress;
            if (allowNull && (String.IsNullOrEmpty(address) || String.IsNullOrWhiteSpace(address))) {
                return true;
            }
            if (IPAddress.TryParse(address, out adress)) {
                return true;
            }
            return false;
        }
    }
}
