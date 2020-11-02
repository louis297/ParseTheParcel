using NUnit.Framework;
using ParseTheParcel.DTOs.ParseTheParcelDTOs;
using ParseTheParcel.Services.ParseAndParcelServices;
using ParseTheParcelTest.ServicesTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseTheParcelTest.ParseTheParcelControllersTest
{
    [TestFixture]
    class ParseTheParcelControllerTest
    {
        private IParseTheParcelService service;
        
        public ParseTheParcelControllerTest()
        {
            service = new ParseTheParcelServiceMock();
        }

        [Test]
        public void ParseTheParcel()
        {
            Assert.AreEqual(service.ParseTheParcel(new ParcelDTO {Length=100, Breadth=200, Height=100, Weight=1000}), 5.0);
            Assert.AreEqual(service.ParseTheParcel(new ParcelDTO { Length = 100, Breadth = 700, Height = 100, Weight = 1000 }), null);
            Assert.AreEqual(service.ParseTheParcel(new ParcelDTO { Length = 100, Breadth = 500, Height = 100, Weight = 1000 }), 8.5);
            Assert.AreEqual(service.ParseTheParcel(new ParcelDTO { Length = 100, Breadth = 200, Height = 180, Weight = 1000 }), 7.5);
            Assert.AreEqual(service.ParseTheParcel(new ParcelDTO { Length = 100, Breadth = 200, Height = 222, Weight = 1000 }), 8.5);
            Assert.AreEqual(service.ParseTheParcel(new ParcelDTO { Length = 100, Breadth = 200, Height = 100, Weight = 100000 }), null);
        }
    }
}
