---
title: "-FR, -Fr (Create .Sbr File)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/FR, /Fr (Create .Sbr File)"
f1_keywords: 
  - "VC.Project.VCCLWCECompilerTool.BrowseInformation"
  - "VC.Project.VCCLCompilerTool.BrowseInformation"
  - "/fr"
  - "VC.Project.VCCLCompilerTool.BrowseInformationFile"
  - "VC.Project.VCCLWCECompilerTool.BrowseInformationFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/FR compiler option [C++]"
  - "-FR compiler option [C++]"
  - "FR compiler option [C++]"
  - "symbolic browser information"
ms.assetid: 3fd8f88b-3924-4feb-9393-287036a28896
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -FR, -Fr (Create .Sbr File)
Creates .sbr files.  
  
## Syntax  
  
```  
/FR[pathname[\filename]]  
/Fr[pathname[\filename]]  
```  
  
## Remarks  
 During the build process, the Microsoft Browse Information File Maintenance Utility (BSCMAKE) uses these files to create a .BSC file, which is used to display browse information.  
  
 **/FR** creates an .sbr file with complete symbolic information.  
  
 **/Fr** creates an .sbr file without information on local variables.  
  
 If you do not specify `filename`, the .sbr file gets the same base name as the source file.  
  
 **/Fr** is deprecated; use **/FR** instead. For more information, see Deprecated and Removed Compiler Options in [Compiler Options Listed by Category](../vs140/compiler-options-listed-by-category.md).  
  
> [!NOTE]
>  Do not change the .sbr extension. BSCMAKE requires the intermediary files to have that extension.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  In the navigation pane, choose the **C/C++**, **Browse Information** property page.  
  
3.  Modify the **Browse Information File** or **Enable Browse Information** property.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.BrowseInformation*> and <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.BrowseInformationFile*>.  
  
## See Also  
 [Output-File (/F) Options](../vs140/output-file---f--options.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [Specifying the Pathname](../vs140/specifying-the-pathname.md)