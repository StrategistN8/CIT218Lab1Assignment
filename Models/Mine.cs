using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIT218Lab1Assignment.Models
{
    public class Mine
    {

        #region PROPERTIES

        public int ID { get; set; }
        public string MineName { get; set; }
        public string MineSystem { get; set; }
        public List<Bot> MineRobots { get; set; }

        #endregion

        #region CONSTRUCTORS
        public Mine()
        {

        }
        #endregion

        #region METHODS

        public static List<Mine> GenerateMineSeedData()
        {
            List<Mine> seedData = new List<Mine>
        {
                new Mine
                {
                    MineName = "Ahayweh Gate",
                    MineSystem = "Zeta Aquilae",
                    MineRobots = new List<Bot>
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
                    }
                },
                new Mine
                {
                    MineName = "Turnabout Bore",
                    MineSystem = "Zeta Aquilae",
                    MineRobots = new List<Bot>
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
                        
                    }
                },
                new Mine
                {
                    MineName = "Wenl Mine",
                    MineSystem = "Zeta Aquilae",
                    MineRobots = new List<Bot>
                    {
                        new Bot
                          {
                             BotName = "Internal Tactical Droid",
                             BotFunction = "Selective Security System" ,
                             BotMineSystem = "Zeta Aquilae",
                             BotImgSrC = "~/Content/PTMCLogo.png"

                         },
                        new Bot
                        {
                            BotName = "Preliminary Intergration Groundbot",
                            BotFunction = "Intersection Guard" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Portable Equalizing Standard Transport",
                            BotFunction = "Mine Transportation System" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Bandit",
                            BotFunction = "Rubble Removal Droid" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Smelter",
                            BotFunction = "Overseer Of Slag Determination" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Diamond Claw",
                            BotFunction = "Second Generation Standard Issue Drilling Robot" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Sidearm",
                            BotFunction = "Multipurpose Defense Robot" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"
                        },
                        new Bot
                        {
                            BotName = "Sidearm Modula",
                            BotFunction = "Primary Regrouping Format for Sidearm" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"
                        },
                    }
                }, 
                new Mine
                {
                    MineName = "Robby Station",
                    MineSystem = "Zeta Aquilae",
                    MineRobots = new List<Bot>
                    {
                        new Bot
                          {
                             BotName = "Internal Tactical Droid",
                             BotFunction = "Selective Security System" ,
                             BotMineSystem = "Zeta Aquilae",
                             BotImgSrC = "~/Content/PTMCLogo.png"

                         },
                        new Bot
                        {
                            BotName = "Preliminary Intergration Groundbot",
                            BotFunction = "Intersection Guard" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Portable Equalizing Standard Transport",
                            BotFunction = "Mine Transportation System" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Bandit",
                            BotFunction = "Rubble Removal Droid" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Smelter",
                            BotFunction = "Overseer Of Slag Determination" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Diamond Claw",
                            BotFunction = "Second Generation Standard Issue Drilling Robot" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"

                        },
                        new Bot
                        {
                            BotName = "Sidearm",
                            BotFunction = "Multipurpose Defense Robot" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"
                        },
                        new Bot
                        {
                            BotName = "Sidearm Modula",
                            BotFunction = "Primary Regrouping Format for Sidearm" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"
                        },
                        new Bot
                        {
                            BotName = "Lou Guard",
                            BotFunction = "Mine Enterance Protector" ,
                            BotMineSystem = "Zeta Aquilae",
                            BotImgSrC = "~/Content/PTMCLogo.png"
                        }
                    }
                }

        };

            return seedData;
        }
        #endregion

    }
}