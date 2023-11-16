using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BonerPlugin
{
    public sealed class Config : IConfig
    {
        [Description("Turn the plugin on and off (true for on, false for off)")]
        public bool IsEnabled { get; set; } = true;
        [Description("Exiled makes me add 'Debug', no clue what it does so I wouldn't touch it")]
        public bool Debug { get; set; } = false;
        [Description("The default rule for this plugin ('false') is to not make 3114 a 100 percent spawn chance (leaving it to the default game system with a 30 percent chance) if someone spawns as 079, set this to 'true' to make the plugin ignore this rule (this should be used for events like 'the max players for the server is 100 for 2 hours')")]
        public bool NoComputerOveride { get; set; } = false;
        [Description("This sets what the playercount needs to be above to run the plugin (ex. if you want the pugin to run when there are 30 or more players on the server then set it to 29)")]
        public int PlayersToRun { get; set; } = 29;
    }
}