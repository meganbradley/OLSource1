---
title: "-MAP (Generate Mapfile)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /MAP (Generate Mapfile)
f1_keywords: 
  - /map
  - VC.Project.VCLinkerTool.MapFileName
  - VC.Project.VCLinkerTool.GenerateMapFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - mapfiles, creating linker
  - generate mapfile linker option
  - mapfile linker option
  - mapfiles, information about program being linked
  - MAP linker option
  - -MAP linker option
  - mapfiles, specifying file name
  - /MAP linker option
ms.assetid: 9ccce53d-4e36-43da-87b0-7603ddfdea63
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -MAP (Generate Mapfile)
```  
/MAP[:filename]  
```  
  
## Remarks  
 where:  
  
 *filename*  
 A user-specified name for the mapfile. It replaces the default name.  
  
## Remarks  
 The /MAP option tells the linker to create a mapfile.  
  
 By default, the linker names the mapfile with the base name of the program and the extension .map. The optional *filename* allows you to override the default name for a mapfile.  
  
 A mapfile is a text file that contains the following information about the program being linked:  
  
-   The module name, which is the base name of the file  
  
-   The timestamp from the program file header (not from the file system)  
  
-   A list of groups in the program, with each group's start address (as *section*:*offset*), length, group name, and class  
  
-   A list of public symbols, with each address (as *section*:*offset*), symbol name, flat address, and .obj file where the symbol is defined  
  
-   The entry point (as *section*:*offset*)  
  
 The [/MAPINFO](../vs140/-mapinfo--include-information-in-mapfile-.md) option specifies additional information to be included in the mapfile.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Debug** property page.  
  
4.  Modify the **Generate Map File** property.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.GenerateMapFile?qualifyHint=False> and <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.MapFileName?qualifyHint=False>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)