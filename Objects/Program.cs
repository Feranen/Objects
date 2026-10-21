// Must have subfolders: /Models/  /Services/  /Helpers/ /Tools/

/*
Name Convention: PascalCase 
 Class:
    Fields first:
        ...
        
    Methods last:
        ...
 
 
 Solution/
    Project1:
        ...
    Project2:
        ...
    ...
 */

using Objects.Models;

List<Hero> team = new List<Hero>();

Hero Arthas = new Hero();
Arthas.name = "Arthas";
Arthas.className = "Death Knight";
Arthas.health = 100;

team.Add(Arthas);