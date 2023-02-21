using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Core.ConfigModel;
namespace TestAPI.Core.ConfigModel
{
    public class TextRequestConfig
    {
        public string BaseUrl { get; set; } = null!;
        public int PhoneNumberId { get; set; }
        public string TextMetricsApiKey { get; set; } = null!;
    }
}
