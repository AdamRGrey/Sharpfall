using System;
using System.Collections.Generic;

namespace Sharpfall
{
    using UUID = System.String;
    public class CardFace
    {
        public string artist { get; set; } //The name of the illustrator of this card face. Newly spoiled cards may not have this field yet.
        public IEnumerable<Color> color_indicator { get; set; } //The colors in this face’s color indicator, if any.
        public IEnumerable<Color> colors { get; set; } //This face’s colors, if the game defines colors for the individual face of this card.
        public string flavor_text { get; set; } //The flavor text printed on this face, if any.
        public UUID illustration_id { get; set; } //A unique identifier for the card face artwork that remains consistent across reprints. Newly spoiled cards may not have this field yet.
        public Images image_uris { get; set; } //An object providing URIs to imagery for this face, if this is a double-sided card. If this card is not double-sided, then the image_uris property will be part of the parent object instead.
        public string loyalty { get; set; } //This face’s loyalty, if any.
        public string mana_cost { get; set; } //The mana cost for this face. This value will be any empty string "" if the cost is absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are different values.
        public string name { get; set; } //The name of this particular face.
                                         //public  string object { get; set; } //A content type for this object, always card_face.
        public string oracle_text { get; set; } //The Oracle text for this face, if any.
        public string power { get; set; } //This face’s power, if any. Note that some cards have powers that are not numeric, such as *.
        public string printed_name { get; set; } //The localized name printed on this face, if any.
        public string printed_text { get; set; } //The localized text printed on this face, if any.
        public string printed_type_line { get; set; } //The localized type line printed on this face, if any.
        public string toughness { get; set; } //This face’s toughness, if any.
        public string type_line { get; set; } //The type line of this particular face.
        public string watermark { get; set; } //The watermark on this particulary card face, if any. 
    }
}