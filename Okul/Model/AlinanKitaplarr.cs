//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Okul.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlinanKitaplarr
    {
        public int Id { get; set; }
        public Nullable<int> KullaniciId { get; set; }
        public Nullable<int> KitapId { get; set; }
    
        public virtual Kitap Kitap { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}