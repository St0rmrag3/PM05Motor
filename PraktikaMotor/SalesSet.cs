//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikaMotor
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesSet
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdCar { get; set; }
        public string Date { get; set; }
    
        public virtual CarsSet CarsSet { get; set; }
        public virtual ClientsSet ClientsSet { get; set; }
    }
}