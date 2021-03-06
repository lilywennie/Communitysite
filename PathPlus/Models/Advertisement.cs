//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PathPlus.Models
{
    using Main.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(MetaAdvertisement))]
    public partial class Advertisement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Advertisement()
        {
            this.AdvertisementPhoto = new HashSet<AdvertisementPhoto>();
            this.Administrator = new HashSet<Administrator>();
        }
    
        public string AdvertisementID { get; set; }
        public string AdText { get; set; }
        public string City { get; set; }
        public string AgeRange { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<decimal> Money { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime Limitation { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public string CompanyID { get; set; }
        public string AdStatusCategoryID { get; set; }
    
        public virtual AdvertisemenStatusCategory AdvertisemenStatusCategory { get; set; }
        public virtual Advertisers Advertisers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvertisementPhoto> AdvertisementPhoto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administrator> Administrator { get; set; }
    }
}
