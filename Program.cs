//Look in a given directory

const string chaFilDir = "challengeFilesDir";
const string dirSeparator = "\\";
const string rootDirPath = "W:\\cSharpDotNetEssentialTrainingLinkedInLearning";
string basePath = Directory.GetCurrentDirectory();

string fullPath = Path.Combine(rootDirPath, dirSeparator, chaFilDir);

Directory.CreateDirectory(fullPath);

//Analyse file contents

//Print out

/*
 * Results
 * with bulleted list of 
 * Total files
 * Excel files: #
 * Word files: #
 * PPT files: #
 * ----
 */

/*
 * Total size of all files
 * Excel size:
 * Word size:
 * PPT size: 
 */

//Should also run for any newly added files
