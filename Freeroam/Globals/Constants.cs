using AltV.Net.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Freeroam.Globals
{
    class Constants
    {
        // Simple Text Colors.
        public static string COLOR_DISCONNECT = Core.Functions.GetHexColorcode(200, 0, 0);
        public static string COLOR_CONNECT = Core.Functions.GetHexColorcode(0, 200, 0);
        public static string COLOR_WHITE = Core.Functions.GetHexColorcode(255, 255, 255);
        public static string COLOR_GREEN = Core.Functions.GetHexColorcode(0, 255, 0);


        //Commands
        public const string COMMAND_POS = "pos"; //Get the Local Player Position [Usage : /pos]
        public const string COMMAND_GOTO = "goto"; //Go to the Targetet Player [Usage : /goto ClientName]
        public const string COMMAND_VEHICLE = "veh"; //Creates a Vehicle [Usage : /vehicle VehicleName, Color Optional]


        public static int GetRandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(0, max);
        }

        public static readonly List<Position> PLAYER_SPAWNS = new List<Position>
        {
            new Position(-117.03297f,-604.66815f,36.272583f),
            new Position(50.861538f,-136.21979f,55.194824f),
            new Position(213.27032f,-921.1517f,30.678345f),
            new Position(427.0681f,-978.989f,30.69519f),
            new Position(-10.892307f,-1118.6901f,27.578003f),
            new Position(130.66814f,-1032.8308f,29.431519f),
        };


        public static readonly List<string> PLAYER_SKIN_MODELS = new List<string>
        {
            "s_m_y_cop_01",
            "a_c_chimp",
            "s_m_y_airworker",
            "s_m_y_clown_01",
            "mp_m_freemode_01",
            "csb_agent",
            "a_m_y_golfer_01",
            "g_m_m_armlieut_01",
            "u_m_m_jesus_01",
            "u_m_y_abner",
            "g_m_y_korean_01",
            "u_f_y_bikerchic",
            "s_m_y_marine_01",
            "g_m_m_mexboss_02",
            "u_m_y_militarybum",
            "s_m_m_movprem_01",
            "a_m_y_musclbeac_01",
            "s_m_m_paramedic_01",
            "s_m_y_pilot_01",
            "s_m_y_doorman_01",
            "s_m_y_pilot_01",
            "s_m_y_cop_01",
            "s_m_y_prisoner_01",
            "a_f_y_fitness_01",
            "g_f_y_ballas_01",
            "s_m_m_security_01",
            "s_f_y_sheriff_01",
            "s_m_m_snowcop_01",
            "csb_grove_str_dlr",
            "a_m_m_farmer_01",
            "a_f_y_topless_01",
        };
    }
}
