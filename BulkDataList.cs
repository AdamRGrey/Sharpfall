using System;
namespace Sharpfall
{
    public class BulkDataList
    {
        public string @object { get; set; }
        public string has_more { get; set; } = "";
        public BulkMetaEntry[] data { get; set; }
    }
    public class BulkMetaEntry
    {
        public string @object { get; set; }
        public Guid id { get; set; }
        public string type { get; set; }
        public DateTime updated_at { get; set; }
        public Uri uri { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int compressed_size { get; set; }
        public Uri download_uri { get; set; }
        public string content_type { get; set; }
        public string content_encoding { get; set; }
    }
}