# ParamDbpEditor
Allows you to edit params that use dbps and the dbps themselves.  
The only games I've found so far using them are:  
Armored Core 4  
Armored Core For Answer  
Armored Core V  
Armored Core Verdict Day  

The dbps within these games come with the program to be able to read params without having to have the user go get them.  
The dbp set from each game can be switched with a simple combobox in the bottom right corner of the window.  
There is also support to dynamically load dbps from any new entries added into the Resources folder.  
Games.txt has the names of the games to check for, the program will check for a folder of the same name in Resources.  
Then it will check for a folder named dbp inside of that one and get all files inside.  
Supported dbp formats for loading are:  
dbp  
txt  
xml  
json  

The extra formats come from the program's exporting abilities.  
Params and dbps can be exported back and forth between multiple formats.  
Some formats are tougher to implement and do not work at this time.  
For example converting json params back to params.  

The program also has converting abilities to convert the endianness of dbps.  
Armored Core 4 has two depreciated dbps that are unique, acbehavior.dbp, and movementparam.dbp.  
These dbps are written in the little endian byte order.  
In the program's library I added the ability to detect endianness, but this converter is nice to have.  
primalarmor.dbp is another depreciated Armored Core 4 dbp, but it is written in big endian.  

The editor supports recreating params from their dbps as well by setting default values.  
The editor will allow editing dbps, but the edits will be saved to the dbps in Resources,  
The originals will be backed up though of course.  

I don't know what I'll be adding in the future or if I'll have a better editor by then.