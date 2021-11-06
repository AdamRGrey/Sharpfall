using System;
using System.Collections.Generic;

namespace Sharpfall
{
    public enum LegalCategory { not_legal, legal, restricted, banned }
    public class Legalities
    {
        public LegalCategory standard { get; set; }
        public LegalCategory future { get; set; }
        public LegalCategory historic { get; set; }
        public LegalCategory gladiator { get; set; }
        public LegalCategory pioneer { get; set; }
        public LegalCategory modern { get; set; }
        public LegalCategory legacy { get; set; }
        public LegalCategory pauper { get; set; }
        public LegalCategory vintage { get; set; }
        public LegalCategory penny { get; set; }
        public LegalCategory commander { get; set; }
        public LegalCategory brawl { get; set; }
        public LegalCategory historicbrawl { get; set; }
        public LegalCategory paupercommander { get; set; }
        public LegalCategory duel { get; set; }
        public LegalCategory oldschool { get; set; }
        public LegalCategory premodern { get; set; }
    }
}