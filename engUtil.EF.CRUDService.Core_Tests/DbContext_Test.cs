// --------------------------------------------------------------------------------
// <copyright filename="DbContext_Test.cs" date="12-13-2019">(c) 2019 All Rights Reserved</copyright>
// <author>Oliver Engels</author>
// --------------------------------------------------------------------------------
using engUtil.EF.CRUDService.Core_Tests.DataAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace engUtil.EF.CRUDService.Core_Tests
{
    public class DbContext_Test
    {
        [Test]
        public void DatabaseEnsureCreated_Test()
        {
            string tempPath = Path.GetTempPath();
            var session = new PhoneBookSession($"Data Source={Path.Combine(tempPath, "phonebook.sqlite")}");
            using (var ctx = session.GetContext())                      
                ctx.Database.EnsureCreated();
            Assert.Pass();
        }
    }
}