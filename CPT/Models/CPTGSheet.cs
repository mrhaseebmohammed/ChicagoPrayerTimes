/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
    public class Category
    {
        [XmlAttribute(AttributeName = "scheme")]
        public string Scheme { get; set; }
        [XmlAttribute(AttributeName = "term")]
        public string Term { get; set; }
    }

    [XmlRoot(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
    public class Title
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
    public class Link
    {
        [XmlAttribute(AttributeName = "rel")]
        public string Rel { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
    public class Author
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
        public string Name { get; set; }
        [XmlElement(ElementName = "email", Namespace = "http://www.w3.org/2005/Atom")]
        public string Email { get; set; }
    }

    [XmlRoot(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
    public class Content
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
    public class Entry
    {
        [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
        public string Id { get; set; }
        [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
        public string Updated { get; set; }
        [XmlElement(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
        public Category Category { get; set; }
        [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
        public Content Content { get; set; }
        [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
        public Link Link { get; set; }
        [XmlElement(ElementName = "masjid", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Masjid { get; set; }
        [XmlElement(ElementName = "fajr", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Fajr { get; set; }
        [XmlElement(ElementName = "zuhr", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Zuhr { get; set; }
        [XmlElement(ElementName = "asr", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Asr { get; set; }
        [XmlElement(ElementName = "maghrib", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Maghrib { get; set; }
        [XmlElement(ElementName = "isha", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Isha { get; set; }
        [XmlElement(ElementName = "jummah", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Jummah { get; set; }
        [XmlElement(ElementName = "jummah2", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Jummah2 { get; set; }
        [XmlElement(ElementName = "address", Namespace = "http://schemas.google.com/spreadsheets/2006/extended")]
        public string Address { get; set; }
    }

    [XmlRoot(ElementName = "feed", Namespace = "http://www.w3.org/2005/Atom")]
    public class Feed
    {
        [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
        public string Id { get; set; }
        [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
        public string Updated { get; set; }
        [XmlElement(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
        public Category Category { get; set; }
        [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
        public List<Link> Link { get; set; }
        [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
        public Author Author { get; set; }
        [XmlElement(ElementName = "totalResults", Namespace = "http://a9.com/-/spec/opensearchrss/1.0/")]
        public string TotalResults { get; set; }
        [XmlElement(ElementName = "startIndex", Namespace = "http://a9.com/-/spec/opensearchrss/1.0/")]
        public string StartIndex { get; set; }
        [XmlElement(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
        public List<Entry> Entry { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "openSearch", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string OpenSearch { get; set; }
        [XmlAttribute(AttributeName = "gsx", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gsx { get; set; }
    }

}
