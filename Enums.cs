using System;
using System.Collections.Generic;

namespace Sharpfall
{
    public enum Color { W, U, G, B, R, C }


    //a lot of these could potentially be enums, but
    //  1: might be difficult to make into enums (frames are identified by the year they started, scryfall loves the word "object" where I would prefer the term "type")
    //  2: they update often enough that I'd rather not have to recompile and re-release, how often do I even want to check the specific type
    public class Known
    {
        public List<string> Game = new List<string>()
        {
            //"astral",
            //"sega",
            "paper",
            "arena", 
            "mtgo"
        };
        public List<string> Layout = new List<string>() {
            "normal", //A standard Magic card with one face
            "split", //A split-faced card
            "flip", //Cards that invert vertically with the flip keyword
            "transform", //Double-sided cards that transform
            "modal_dfc", //Double-sided cards that can be played either-side
            "meld", //Cards with meld parts printed on the back
            "leveler", //Cards with Level Up
            "class", //Class-type enchantment cards
            "saga", //Saga-type cards
            "adventure", //Cards with an Adventure spell part
            "planar", //Plane and Phenomenon-type cards
            "scheme", //Scheme-type cards
            "vanguard", //Vanguard-type cards
            "token", //Token cards
            "double_faced_token", //Tokens with another token printed on the back
            "emblem", //Emblem cards
            "augment", //Cards with Augment
            "host", //Host-type cards
            "art_series", //Art Series collectable double-faced cards
            "double_sided" //A Magic card with two sides that are unrelated
        };
        public List<string> Frame = new List<string>(){
            "1993", //The original Magic card frame, starting from Limited Edition Alpha.
            "1997", //The updated classic frame starting from Mirage block
            "2003", //The “modern” Magic card frame, introduced in Eighth Edition and Mirrodin block.
            "2015", //The holofoil-stamp Magic card frame, introduced in Magic 2015.
            "future" //The frame used on cards from the future (i.e., Timeshifted)
        };
        public List<string> FrameEffect = new List<string>(){
            "legendary", //The cards have a legendary crown
            "miracle", //The miracle frame effect
            "nyxtouched", //The Nyx-touched frame effect
            "draft", //The draft-matters frame effect
            "devoid", //The Devoid frame effect
            "tombstone", //The Odyssey tombstone mark
            "colorshifted", //A colorshifted frame
            "inverted", //The FNM-style inverted frame
            "sunmoondfc", //The sun and moon transform marks
            "compasslanddfc", //The compass and land transform marks
            "originpwdfc", //The Origins and planeswalker transform marks
            "mooneldrazidfc", //The moon and Eldrazi transform marks
            "waxingandwaningmoondfc", //The waxing and waning crescent moon transform marks
            "showcase", //A custom Showcase frame
            "extendedart", //An extended art frame
            "companion", //The cards have a companion frame
            "etched", //The cards have an etched foil treatment
            "snow" //The cards have the snowy frame effect
        };
    }
}