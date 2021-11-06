using System;
using System.Collections.Generic;

namespace Sharpfall
{
    using UUID = System.String;
    public class RelatedCard
    {
        public UUID id { get; set; } //An unique ID for this card in Scryfall’s database.
                                     //public string object { get; set; } //A content type for this object, always related_card.
        public string component { get; set; } //A field explaining what role this card plays in this relationship, one of token, meld_part, meld_result, or combo_piece.
        public string name { get; set; } //The name of this particular related card.
        public string type_line { get; set; } //The type line of this card.
        public Uri uri { get; set; } //A URI where you can retrieve a full object describing this card on Scryfall’s API. 
    }
}