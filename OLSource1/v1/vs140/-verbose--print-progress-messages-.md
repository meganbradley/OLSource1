---
title: "-VERBOSE (Print Progress Messages)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/VERBOSE (Print Progress Messages)"
f1_keywords: 
  - "/verbose"
  - "VC.Project.VCLinkerTool.ShowProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-VERBOSE linker option"
  - "linking [C++], session progress information"
  - "Print Progress Messages linker option"
  - "linker [C++], output dependency information"
  - "/VERBOSE linker option"
  - "dependencies [C++], dependency information in linker output"
  - "VERBOSE linker option"
ms.assetid: 9c347d98-4c37-4724-a39e-0983934693ab
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -VERBOSE (Print Progress Messages)
```  
/VERBOSE[:{ICF|INCR|LIB|REF|SAFESEH|UNUSEDLIBS}]  
```  
  
## Remarks  
 The linker sends information about the progress of the linking session to the **Output** window. On the command line, the information is sent to standard output and can be redirected to a file.  
  
|Option|Description|  
|------------|-----------------|  
|/VERBOSE|Displays details about the linking process.|  
|/VERBOSE:ICF|Display information about linker activity that results from the use of [/OPT:ICF](../vs140/-opt--optimizations-.md).|  
|/VERBOSE:INCR|Displays information about the incremental link process.|  
|/VERBOSE:LIB|Displays progress messages that indicate just the libraries searched.<br /><br /> The displayed information includes the library search process and lists each library and object name (with full path), the symbol being resolved from the library, and a list of objects that reference the symbol.|  
|/VERBOSE:REF|Displays information about linker activity that results from the use of [/OPT:REF](../vs140/-opt--optimizations-.md).|  
|/VERBOSE:SAFESEH|Displays information about modules that are not compatible with safe exception handling when [/SAFESEH](../vs140/-safeseh--image-has-safe-exception-handlers-.md) is not specified.|  
|/VERBOSE:UNUSEDLIBS|Displays information about any library files that are unused when the image is created.|  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Expand the **Linker** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  Add the option to the **Additional Options** box.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.ShowProgress*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)