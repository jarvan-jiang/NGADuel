//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NGADuel
{
    using System;
    using System.Collections.Generic;
    
    public partial class duelinfo
    {
        public int DuelID { get; set; }
        public Nullable<int> DuelType { get; set; }
        public Nullable<int> DuelServer { get; set; }
        public string DuelUser { get; set; }
        public string DuelToUser { get; set; }
        public Nullable<int> DuelHero { get; set; }
        public Nullable<int> DuelToHero { get; set; }
        public Nullable<int> DuelResult { get; set; }
        public string DuelImage { get; set; }
    }
}