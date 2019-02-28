﻿namespace InvvardDev.EZLayoutDisplay.Console
{
    public class KeyDefinition
    {
        public string KeyCode { get; set; }
        public string Label { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Command { get; set; }
        public object MenuLabel { get; set; }
        public string AltLabel { get; set; }
        public bool? PrecedingKey { get; set; }
        public string Glyph { get; set; }
    }
}