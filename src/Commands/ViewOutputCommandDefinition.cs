using Gemini.Framework.Commands;
using Gemini.Modules.ActorSystem.Properties;

namespace Gemini.Modules.ActorSystem.Commands
{
    [CommandDefinition]
    public class ViewOutputCommandDefinition : CommandDefinition
    {
        public const string CommandName = "View.Output";

        public override string Name
        {
            get { return CommandName; }
        }

        public override string Text
        {
            get { return Resources.ViewOutputCommandText; }
        }

        public override string ToolTip
        {
            get { return Resources.ViewOutputCommandToolTip; }
        }
    }
}