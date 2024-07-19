/**
* <author>Kelrae and Jitneybus</author>
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
      dbi.Update("UPDATE `recipe` SET `name`='Kheldir\'s Cobbler' WHERE ID='481'"); // Confiture Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Cavalier\'s Carnage Kabobs' WHERE ID='1021'"); // Meat Kabobs Object
      dbi.Update("UPDATE `recipe` SET `name`='Cavalier\'s Carnage Kabobs' WHERE ID='519'"); // Meat Kabobs Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Siraye Sushi' WHERE ID='980'"); // Rollmops Object
      dbi.Update("UPDATE `recipe` SET `name`='Siraye Sushi' WHERE ID='478'"); // Rollmops Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Crescian Beefcake' WHERE ID='1004'"); // Yorkshire Pudding Object
      dbi.Update("UPDATE `recipe` SET `name`='Crescian Beefcake' WHERE ID='503'"); // Yorkshire Pudding Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Fayeth\'s Nectar' WHERE ID='981'"); // Mulled Wine Object
      dbi.Update("UPDATE `recipe` SET `name`='Fayeth\'s Nectar' WHERE ID='485'"); // Mulled Wine Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Queen\'s Buns' WHERE ID='978'"); // Cheese buns Object
      dbi.Update("UPDATE `recipe` SET `name`='Queen\'s Buns' WHERE ID='468'"); // Cheese buns Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Prisoner\'s Mead' WHERE ID='966'"); // Compote Object
      dbi.Update("UPDATE `recipe` SET `name`='Prisoner\'s Mead' WHERE ID='461'"); // Compote Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Chieftain\'s Feast' WHERE ID='1020'"); // Waterzooi Object
      dbi.Update("UPDATE `recipe` SET `name`='Chieftain\'s Feast' WHERE ID='518'"); // Waterzooi Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Rocky Bread' WHERE ID='976'"); // Samsa Object
      dbi.Update("UPDATE `recipe` SET `name`='Rocky Bread' WHERE ID='467'"); // Samsa Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Iskar\'s Demise' WHERE ID='968'"); // Cake with Giblets Object
      dbi.Update("UPDATE `recipe` SET `name`='Iskar\'s Demise' WHERE ID='465'"); // Cake with Giblets Recipe
	  dbi.Update("UPDATE `objects_types` SET `name`='Tea' WHERE ID='982'"); // Eggnog Object
      dbi.Update("UPDATE `recipe` SET `name`='Tea' WHERE ID='479'"); // Eggnog Recipe

    }

};

activatePackage(RPCLiFCanonRecipes);
LiFx::registerCallback($LiFx::hooks::mods, setup, RPCLiFCanonRecipes);