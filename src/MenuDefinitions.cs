using System.ComponentModel.Composition;
using Gemini.Framework.Menus;
using Gemini.Modules.ActorSystem.Commands;

namespace Gemini.Modules.ActorSystem
{
    public static class MenuDefinitions
    {
        [Export]
        public static MenuItemDefinition ViewOutputMenuItem = new CommandMenuItemDefinition<ViewOutputCommandDefinition>(
            MainMenu.MenuDefinitions.ViewToolsMenuGroup, 1);
    }
}