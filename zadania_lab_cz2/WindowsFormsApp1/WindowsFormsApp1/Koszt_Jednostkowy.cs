//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Koszt_Jednostkowy
    {
        public int ID_Koszt_Jednostkowy { get; set; }
        public Nullable<int> ID_Element { get; set; }
        public int Koszt_Produkcji { get; set; }
    
        public virtual Elementy Elementy { get; set; }
    }
}
