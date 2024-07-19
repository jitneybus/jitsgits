/**
* <author>Kelrae and Jitney</author>
* <email>Kelrae.Vante@gmail.com</email>
* <url>RPCLIF.com</url>
* <credits>Kelrae, Jitney</credits>
* <description>Updating recipes and object types to match canon lore of RPCLiF.</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(RPCLiFCanonRecipes))
{
    new ScriptObject(RPCLiFCanonRecipes)
    {
    };
}

package RPCLiFCanonRecipes

{
    function RPCLiFCanonRecipes::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, RPCLiFCanonRecipes);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, DbChanges, RPCLiFCanonRecipes);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, ConChanges, RPCLiFCanonRecipes);
       
    }
    function RPCLiFCanonRecipes::version() {
        return "1.0.0";
    }

    function RPCLiFCanonRecipes::dbChanges() {
           //// Update Recipes to match canon lore ////
      dbi.Update("UPDATE `objects_types` SET `name`='Kheldir\'s Cobbler' WHERE ID='986'"); // Confiture Object
      dbi.Update("UPDATE `recipe` SET `name`='Idol of Betong' WHERE ID='481'"); // Confiture Recipe

    }

};

activatePackage(RPCLiFCanonRecipes);
LiFx::registerCallback($LiFx::hooks::mods, setup, RPCLiFCanonRecipes);