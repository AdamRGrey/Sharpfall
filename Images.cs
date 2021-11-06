using System;
using System.Collections.Generic;

namespace Sharpfall
{
    public class Images
    {
        public Uri png { get; set; } // 745 × 1040, PNG, A transparent, rounded full card PNG. This is the best image to use for videos or other high-quality content.
        public Uri border_crop { get; set; } //480 × 680, JPG, A full card image with the rounded corners and the majority of the border cropped off. Designed for dated contexts where rounded images can’t be used.
        public Uri art_crop { get; set; } //Varying resolution, JPG, A rectangular crop of the card’s art only. Not guaranteed to be perfect for cards with outlier designs or strange frame arrangements
        public Uri large { get; set; } //672 × 936, JPG, A large full card image
        public Uri normal { get; set; } //488 × 680, JPG, A medium-sized full card image
        public Uri small { get; set; } //146 × 204, JPG, A small full card image. Designed for use as thumbnail or list icon.
    }
}