//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserSkills { get; set; }
        public string FIO { get; set; }
        public int RoleID { get; set; }
    
        public virtual RoleID RoleID1 { get; set; }
    }
}
