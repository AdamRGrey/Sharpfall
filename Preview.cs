using System;
using System.Collections.Generic;

namespace Sharpfall
{
    public class Preview
    {
        public DateTime previewed_at; //The date this card was previewed.
        public Uri source_uri; //A link to the preview for this card.
        public string source; //The name of the source that previewed this card.
    }
}