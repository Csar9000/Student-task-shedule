//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duble2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curriculum
    {
        public string Group_2_GroupNum { get; set; }
        public string Subject_SubjectName { get; set; }
    
        public virtual Group_2 Group_2 { get; set; }
        public virtual Group_2 Group_21 { get; set; }
        public virtual Group_2 Group_22 { get; set; }
        public virtual Group_2 Group_23 { get; set; }
        public virtual Group_2 Group_24 { get; set; }
        public virtual Group_2 Group_25 { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Subject Subject1 { get; set; }
        public virtual Subject Subject2 { get; set; }
        public virtual Subject Subject3 { get; set; }
    }
}
