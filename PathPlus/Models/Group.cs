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
    
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.JoinGroup = new HashSet<JoinGroup>();
            this.GroupManagement = new HashSet<GroupManagement>();
            this.GroupPost = new HashSet<GroupPost>();
        }
    
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public string Photo { get; set; }
        public string GroupIntroduction { get; set; }
        public string GroupInformation { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string MemberID { get; set; }
        public string PrivateCategoryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JoinGroup> JoinGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupManagement> GroupManagement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupPost> GroupPost { get; set; }
        public virtual GroupPrivateCategory GroupPrivateCategory { get; set; }
        public virtual Member Member { get; set; }
    }
}
