---
title: "-NXCOMPAT (Compatible with Data Execution Prevention)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/NXCOMPAT (Compatible with Data Execution Prevention)"
f1_keywords: 
  - "/NXCOMPAT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/NXCOMPAT linker option"
  - "-NXCOMPAT linker option"
  - "NXCOMPAT linker option"
ms.assetid: 5858e7ff-24d3-4ac3-9046-af2c9e220d9b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -NXCOMPAT (Compatible with Data Execution Prevention)
Indicates that an executable was tested to be compatible with the Windows Data Execution Prevention feature.  
  
## Syntax  
  
```  
/NXCOMPAT[:NO]  
```  
  
## Remarks  
 By default, **/NXCOMPAT** is on.  
  
 **/NXCOMPAT:NO** can be used to explicitly specify an executable as incompatible with Data Execution Prevention.  
  
 For more information about Data Execution Prevention, see these articles:  
  
-   [A detailed description of the Data Execution Prevention (DEP) feature](http://go.microsoft.com/fwlink/?LinkID=157771) on the Microsoft Help and Support Web site  
  
-   [Data Execution Prevention](http://go.microsoft.com/fwlink/?LinkID=157770) on the MSDN Web site  
  
-   [Data Execution Prevention (Windows Embedded)](http://go.microsoft.com/fwlink/?LinkID=157768) on the MSDN Web site  
  
### To set this linker option in Visual Studio  
  
1.  Open the project **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the option in the **Additional Options** box.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)