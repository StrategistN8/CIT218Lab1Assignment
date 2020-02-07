using System;
using System.Collections.Generic;

public class Bot
{

    #region PROPERTIES

    public int Quantity { get; set; }
    public string BotName { get; set; }
    public string BotFunction { get; set; }
    public string BotMineSystem { get; set; }
    public string BotImgSrC { get; set; }

    #endregion

    #region CONSTRUCTOR
       
    /// <summary>
    /// Default Constructor
    /// </summary>
    public Bot()
	{
		
	}

    #endregion

    #region METHODS

    public static List<Bot> GenerateBotSeedData()
    {
        List<Bot> seedData = new List<Bot>
        {
            new Bot
            {
                BotName = "Internal Tactical Droid",
                BotFunction = "Selective Security System" ,
                BotMineSystem = "Zeta Aquale",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Preliminary Intergration Groundbot",
                BotFunction = "Intersection Guard" ,
                BotMineSystem = "Zeta Aquale",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Portable Equalizing Standard Transport",
                BotFunction = "Mine Transportation System" ,
                BotMineSystem = "Zeta Aquale",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Bandit",
                BotFunction = "Rubble Removal Droid" ,
                BotMineSystem = "Zeta Aquale",
               BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Smelter",
                BotFunction = "Overseer Of Slag Determination" ,
                BotMineSystem = "Zeta Aquale",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Diamond Claw",
                BotFunction = "Second Generation Standard Issue Drilling Robot" ,
                BotMineSystem = "Zeta Aquale",
               BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Sidearm",
                BotFunction = "Multipurpose Defense Robot" ,
                BotMineSystem = "Zeta Aquale",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Sidearm Modula",
                BotFunction = "Primary Regrouping Format for Sidearm" ,
                BotMineSystem = "Zeta Aquale",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
               new Bot
            {
                BotName = "Lou Guard",
                BotFunction = "Mine Enterance Protector" ,
                BotMineSystem = "Zeta Aquale",
               BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Internal Tactical Security Control",
                BotFunction = "Central Security System" ,
                BotMineSystem = "Quartzon",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
               new Bot
            {
                BotName = "Fox Attack Robot",
                BotFunction = "External Operations Emergency Response Security System",
                BotMineSystem = "Quartzon",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Seeker",
                BotFunction = "Roving Attack Robot" ,
                BotMineSystem = "Quartzon",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "TRN Racer",
                BotFunction = "Tunnel Negotiating Pest Control" ,
                BotMineSystem = "Brimspark",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Red Hornet",
                BotFunction = "Mine Recon/Attack Robot" ,
                BotMineSystem = "Brimspark",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "E-Bandit",
                BotFunction = "Static Removal Droid" ,
                BotMineSystem = "Brimspark",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Omega Defense Spawn",
                BotFunction = "Final Defense Line Guard" ,
                BotMineSystem = "Brimspark",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Bulk Destroyer",
                BotFunction = "Large Quantity Rock Pulverizer" ,
                BotMineSystem = "Brimspark",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "Ice Spindle Attack Robot",
                BotFunction = "Outer Planet Tunnel Negotiator" ,
                BotMineSystem = "Limefrost Sprial",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
            new Bot
            {
                BotName = "BPER",
                BotFunction = "Excavation and Refinement Worker" ,
                BotMineSystem = "Baloris Prime",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
             new Bot
            {
                BotName = "Spider",
                BotFunction = "Segmented Rock Collector" ,
                BotMineSystem = "Pumma Sphere",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
              new Bot
            {
                BotName = "Green Hornet",
                BotFunction = "Regrouping format for Spider" ,
                BotMineSystem = "Pumma Sphere",
                BotImgSrC = "~/Content/PTMCLogo.png"

            },
              new Bot
            {
                BotName = "Boarshed",
                BotFunction = "Rock Smasher System" ,
                BotMineSystem = "Pumma Sphere",
                BotImgSrC = "~/Content/PTMCLogo.png"

            }
        };

        return seedData;
    }

    #endregion

}
