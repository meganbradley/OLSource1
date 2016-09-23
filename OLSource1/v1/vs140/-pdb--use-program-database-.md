---
title: "-PDB (Use Program Database)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /PDB (Use Program Database)
f1_keywords: 
  - /pdb
  - VC.Project.VCLinkerTool.ProgramDatabaseFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - -PDB linker option
  - /PDB linker option
  - PDB linker option
  - PDB files, creating
  - .pdb files, creating
ms.assetid: d23db0ce-10cb-427a-bc60-d6b2a852723d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -PDB (Use Program Database)
```  
/PDB:filename  
```  
  
## Remarks  
 where:  
  
 *filename*  
 A user-specified name for the program database (PDB) that the linker creates. It replaces the default name.  
  
## Remarks  
 By default, when [/DEBUG](../vs140/-debug--generate-debug-info-.md) is specified, the linker creates a program database (PDB) which holds debugging information. The default file name for the PDB has the base name of the program and the extension .pdb.  
  
 Use /PDB:*filename* to specify the name of the PDB file. If /DEBUG is not specified, the /PDB option is ignored.  
  
 A PDB file can be up to 2GB.  
  
 For more information, see [.pdb Files as Linker Input](../vs140/.pdb-files-as-linker-input.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Debug** property page.  
  
4.  Modify the **Generate Program Database File** property.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.ProgramDatabaseFile?qualifyHint=False>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)