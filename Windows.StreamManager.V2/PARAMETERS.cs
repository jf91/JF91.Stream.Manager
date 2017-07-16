using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.StreamManager
{
    class PARAMETERS
    {
        public static string Project = "";

        public static string T_WebsiteChannels_ID = "ID";
        public static string T_WebsiteChannels_Name = "name";
        public static string T_WebsiteChannels_FlashID = "flash_id";

        public static string T_Streamers_ID = "ID";
        public static string T_Streamers_Name = "name";
        public static string T_Streamers_PageURL = "page_url";
        public static string T_Streamers_PlayerURL = "player_url";
        public static string T_Streamers_Token = "token";

        public static string T_StreamersChannels_ID = "ID";
        public static string T_StreamersChannels_Name = "name";
        public static string T_StreamersChannels_StreamerID = "streamer_id";

        public static string Q_Search_Projects = "SELECT * FROM projects";
        public static string Q_Search_WebsiteChannels = "SELECT * FROM website_channels" + PARAMETERS.Project + "";
        public static string Q_Search_Streamers = "SELECT * FROM streamers" + PARAMETERS.Project + "";
        public static string Q_Search_StreamersChannels = "SELECT * FROM streamers_channels" + PARAMETERS.Project + "";

        public static string L_BAT = Environment.GetFolderPath(
    Environment.SpecialFolder.ApplicationData).ToString() + @"\StreamManager";

    }
}
