using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGLMClient.ToolChain
{
    public class StockTrack
    {
        public string name { get; set; }
        public string description { get; set; }
        public Parameters parameters { get; set; }

        public StockTrack()
        {
            name = "stocktrack";
            description = "追踪指定股票的实时价格";
            parameters = new Parameters();
        }
    }

    public class Parameters
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public string[] required { get; set; }

        public Parameters()
        {
            type = "object";
            properties = new Properties();
            required = new string[] { "symbol" };
        }
    }

    public class Properties
    {
        public Symbol symbol { get; set; }

        public Properties()
        {
            symbol = new Symbol();
        }
    }

    public class Symbol
    {
        public string description { get; set; }

        public Symbol()
        {
            description = "需要追踪的股票代码";
        }
    }
}
