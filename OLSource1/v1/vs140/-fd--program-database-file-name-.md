---
title: "-Fd (Program Database File Name)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Fd (Program Database File Name)"
f1_keywords: 
  - "/FD"
  - "VC.Project.VCCLWCECompilerTool.ProgramDataBaseFileName"
  - "VC.Project.VCCLCompilerTool.ProgramDataBaseFileName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/FD compiler option [C++]"
  - "program database file name [C++]"
  - "-FD compiler option [C++]"
  - "PDB files, creating"
  - "program database compiler option [C++]"
  - ".pdb files, creating"
  - "FD compiler option [C++]"
ms.assetid: 3977a9ed-f0ac-45df-bf06-01cedd2ba85a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Fd (Program Database File Name)
Specifies a file name for the program database (PDB) file created by [/Z7, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Without **/Fd**, the PDB file name defaults to VC<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>0.pdb., where <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the major version of Visual C++ in use.  
  
 If you specify a path name that does not include a file name (the path ends in backslash), the compiler creates a .pdb file named VC<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>0.pdb. in the specified directory.  
  
 If you specify a file name that does not include an extension, the compiler uses .pdb as the extension.  
  
 This option also names the state (.idb) file used for minimal rebuild and incremental compilation.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Output Files** property page.  
  
4.  Modify the **Program Database File Name** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.ProgramDataBaseFileName*>.  
  
## Example  
 This command line creates a .pdb file named PROG.pdb and an .idb file named PROG.idb:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Output-File (/F) Options](../vs140/output-file---f--options.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [Specifying the Pathname](../vs140/specifying-the-pathname.md)