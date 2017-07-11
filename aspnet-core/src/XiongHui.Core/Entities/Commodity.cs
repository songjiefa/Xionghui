using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace XiongHui.Entities
{
    public class Commodity: Entity,IHasCreationTime
    {
		public virtual DateTime CreationTime { get; set; }
		public virtual string BarCode { get;  }
		public virtual string FullName { get; set; }

		public virtual string Surname { get; set; }

		public Commodity(string i_barCode,string i_fullName,string i_surname)
		{
			BarCode = i_barCode;
			FullName = i_fullName;
			Surname = i_surname;
		}
    }
}
