﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Supplier2Presta.Entities.XmlPrice
{
    [Serializable, XmlRoot("p5s")]
    public class FullXmlItemList : IPriceXmlItem
    {
        public FullXmlItemList()
        {
            Items = new List<XmlItem>();
        }

        [XmlElement("product")]
        public List<XmlItem> Items { get; set; }
    }
}
