Instructions:

Download Yabber from:
https://www.github.com/JKAnderson/Yabber/

Put Yabber somewhere, then open Yabber.Context.exe, type "R", and press enter.
Now you should have Yabber added to your right-click menu.

Finding Params:
Next finding your params.
For Armored Core For Answer:
Find the "regulation.bin" file for dbp params in regulations.
Find the "boot.bnd" file for more dbp params.

regulation.bin can be found under this path for the US release:
RCPS3\dev_hdd0\game\BLUS30187\USRDIR\

While boot.bnd is found in either or both of these locations:
RCPS3\dev_hdd0\game\BLUS30187\USRDIR\bind\
[ACFA Game Folder]\PS3_GAME\USRDIR\bind\

If it exists at the first folder location you have at some point pressed:
Install to HDD in the System menu in the game.
I recommend deleting everything in this path except for regulation.bin:
RCPS3\dev_hdd0\game\BLUS30187\USRDIR\

Now edits will be easier to make without having to change two locations potentially.
I recommend you put your game folder inside of RPCS3\games\:
[ACFA Game Folder]\PS3_GAME\USRDIR\bind\

RPCS3 will auto-detect it and finding it will be easier.

For Armored Core 4:
Regulations are the only edits you can actually save right now until I get more tooling made.
This path has regulation.bin:
RCPS3\dev_hdd0\game\BLUS30027\USRDIR\bind\

As for the boot params they cannot be saved at this time,
However I will guide you to them.
Go to:
[AC4 Game Folder]\PS3_GAME\USRDIR\bind\

In here you will see:
app.000
app.001
app.002

This is a split container.
First use Yabber to extract each one of them as the pieces are in BND3.
Then put each of the "app" file pieces from those into the same folder.
Then use Yabber on the "app.000" piece.
Now it will be extracted and the pathing is similar to Armored Core For Answer,
Which we will be getting to.

For Armored Core V & Armored Core Verdict Day:
Even playing these games right now is not really feasible on RPCS3.
But the files from their main archives can be extracted to get at the data inside.
Right now I have not uploaded the program to do so.
I will be doing so later.

Making Edits:
Now then, the fun part.
For Armored Core For Answer:
Just use Yabber to open boot.bnd, then edit the params inside.
You can drag and drop files enmass into the editor.
Make sure the selected game dbps is set to ACFA is the bottom right corner of the program.
I have not yet made settings so they will default each time you restart the program.

Once loaded make edits and then save them, you should now see the status text at the bottom tell you how it went.
You should also see that the original files were renamed to add ".bak" to their extension for safe keeping.
Finally you should see a newly made param file with a fresh creation time.

If anything goes wrong with this report it to the issues tracker on my github.
Next you can right-click on the extracted "boot-bnd" folder and click Yabber.

The changes should now be saved.
Note that changing boot.bnd requires closing the entire game and restarting.

Now for editing regulation.bin,
regulation.bin has several regulations inside of it.
They are also BND3 archives like regulation.bin itself.
Extract regulation.bin, then extract your chosen regulation.

If you want to add a regulation,
First extract one to base it off of,
Go into the extracted regulation's xml file from Yabber and edit the version and name info.
Then edit the folder name to reflect this same info.
Repack it with Yabber,
Then find comment_{lang}.fmg, "lang" means whatever languages you want to support from the available ones.
Convert it to XML by using Yabber on it,
Edit the xml to add the new regulation entry text.
Make sure the IDs are in order and updated.
Then convert it back to FMG with Yabber.
Next go to the xml file in regulation-bin, the extracted overall regulations folder.
Add the new regulation entry, put it after the other existing regulation entries.
Make sure to update the IDs and keep them in order.
Now repack regulation.bin

Now you have added a new regulation based off of another one.
Inside of the regulations themselves several files are dbp params.
If you want to edit the params that use defs you will need either:
https://www.github.com/WarpZephyr/ACFAParamEditor/ (my previous terrible editor)
or
DSMapStudio (support for def params coming soon.)

AcParts and Stabilizer and AcParts files, they have part entries and stats.
Sadly I do not have an editor for these yet, if you want to edit them you will need:
https://www.github.com/WarpZephyr/ArmoredTemplates/

and 010Editor from Sweetscape, I will forgo adding the instructions to use it as that will make this README far longer.
For Armored Core 4:
You will need two extra programs:
https://www.github.com/WarpZephyr/AC4RawFormatCorrector/
https://www.github.com/WarpZephyr/RegulationHashCalculator/

Use AC4RawFormatCorrector on individual regulations after repacking them with Yabber.
Use RegulationHashCalculator on regulation.bin after repacking it with Yabber.

AC4RawFormatCorrector is used to correct a Yabber mistake for AC4 regulations.
RegulationHashCalculator corrects raw format for regulation.bin on its own,
For ease of use, and because it has a different raw format.

RegulationHashCalculator is primarily used to recalcuate the MD5 hash included with AC4 regulations.
The file for this hash is present in ACFA but unused.
AC4 does use it however to make sure you didn't download corrupted regulations.

If you do not use these programs you cannot enter the game without it asking you to restore the original regulations,
Or just outright crashing in the case of the raw format problems.

Edits otherwise are done the same way ACFA does them.

For Armored Core V & Armored Core Verdict Day:
As mentioned before this currently cannot be done.

Now you know how to make edits.
That is the end of this tutorial.

Find me on the armored core discord linked in r/armoredcore on reddit.
Or in a discord server known as "servername", a Dark Souls modding server that taught me how to do all this.
My user name is:
NatsuDragneelTheFireDragon#0441