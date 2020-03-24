﻿namespace Anomaly
{
    public static class Globals
    {
        //This Class Stores strings to be used in other Functions. I store them here to keep them safe.
        public static string VersionNumber { get; set; } = "0.01";

        public static string ChangelogURL { get; set; } = "https://raw.githubusercontent.com/PurityWasHere/OpenBullet-Anomaly-Plugin/master/Changelog.txt";
        public static string VersionURL { get; set; } = "https://raw.githubusercontent.com/PurityWasHere/OpenBullet-Anomaly-Plugin/master/VersionNumber.txt";
        public static string LatestDownload { get; set; } = "https://github.com/PurityWasHere/OpenBullet-Anomaly-Plugin/releases/latest/download/Anomaly.dll";
        public static string LatestAPIVersion { get; set; } = "https://api.github.com/repos/PurityWasHere/OpenBullet-Anomaly-Plugin/releases/latest";
    }
}