using ParseTheParcel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParseTheParcel.Config
{
    public static class ParseTheParcelEventID
    {
        //private static readonly ParseTheParcelEventID instance = new ParseTheParcelEventID();
        //static ParseTheParcelEventID()
        //{

        //}

        //private ParseTheParcelEventID()
        //{

        //}
        //public static ParseTheParcelEventID Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}
        public static int Done = 0x10_10_00_01;
        public static int TooLarge = 0x20_10_00_01;
        public static int InternalError = 0x50_10_00_01;

        //public LoggingEventModel parseTheParcelDone = new LoggingEventModel(0x10_00_00_01, null, "");
        //public LoggingEventModel parseTheParcelDone = new LoggingEventModel(0x10_00_00_01, null, "a");
    }
}
