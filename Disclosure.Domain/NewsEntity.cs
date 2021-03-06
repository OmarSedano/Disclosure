﻿using System;

namespace Disclosure.Domain
{
    public class NewsEntity
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public DateTime? PublicationDate { get; set; }
    }
}
