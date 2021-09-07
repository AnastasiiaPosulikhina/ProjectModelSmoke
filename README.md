# Project model smoke
## Explorer (Solution/File System/Assembly/Unity Views)
### Main actions
_Precondition:_ open MainActionsSmoke project
#### Rename
1. Rename projects
2. Rename `Rename` and `ClientApp | src | Rename` folders and files inside

-  Rename via Refactor This... action
-  Rename via Right-click | Edit | Rename
-  Rename via a shortcut

#### Copy + paste
Use `Copy` folder to
- Copy to the same location
- Copy to another folder of the same project
- Copy to a `ClientApp | src` folder
- Copy to another project
- Copy to another solution, opened separately

#### Move
1. Move `Copy` folder
2. Move separate files from this folder

- Move inside a project between different folders
- Move to a `ClientApp | src` folder
- Move to another project
- Move to another solution, opened separately
#### Delete
1. Delete `Rename` folder and undo
3. Delete `ClientApp | src | Rename` and undo
#### Include/exclude files + nested files, folders + subfolders
1. Include/exclude `Rename` folder
2. Include/exclude different files in this folder
### Attached folders
1. Attach an ASP.NET core app to this solution / здесь должны быть спец проекты и папки для репро багов, а не обычный проект
Expected: node_modules folder npm packages, listed in package.json, are indexed, others are not
### Stop index feature
_Precondition:_ open StopIndexSmoke project
- **Excluded folder** - folder is out of solution and isn't indexed
- **ExcludedFromSolutionButInIndex** - folder is out of solution, but is indexed
- **FolderInIndex** - folder is in solution and is indexed
- **FolderOutOfIndex** - folder is in solution, but isn't indexed
### Speed Search in Explorer
### Locate/Select in Solution View
### Saving state between Rider restart
Refer to [RIDER-5094](https://youtrack.jetbrains.com/issue/RIDER-5094)
## Nav bar
## Copy Path
## Scopes
There are 3 custom scopes predefined:
- Scope From 211 - 
- Blazor Project Scope - 
- Attached Folder Scope - in progress

Check:
- file colors in Explorer
- adding a new custom scope
- search in scope using Search Everywhere, Find/Replace in Files
## Navigation
### Search Everywhere (Go to All, Go to File)
### Find/Replace in Files
## Web 
### node_modules
### Angular CLI
### Custom JS libraries

