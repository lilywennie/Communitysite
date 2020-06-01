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
    using System;
    using System.Collections.Generic;
    
    public partial class Term
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Term()
        {
            this.Administrator = new HashSet<Administrator>();
        }
    
        public string TermID { get; set; }
        public string Content { get; set; }
        public System.DateTime PostDate { get; set; }
        public System.DateTime EditDate { get; set; }
        public System.DateTime RevokeDate { get; set; }
        public string Editor { get; set; }
        public string StatusCategoryID { get; set; }
    
        public virtual TermStatusCategory TermStatusCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administrator> Administrator { get; set; }
    }
}
