// --------------------------------------------------------------------------------
// <copyright filename="PersonEntity.cs" date="12-13-2019">(c) 2019 All Rights Reserved</copyright>
// <author>Oliver Engels</author>
// --------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace EngUtil.CRUDService.CoreASP_Test.DataAccess.Entities
{
    public class PersonEntity : EntityBase
    {
        public string FullName { get; set; }

        public string Name { get; set; }

        public string Surename { get; set; }
        
        public ICollection<PhoneNumberEntity> Numbers { get; set; }

        public ICollection<EmailEntity> EMails { get; set; }
    }
}
