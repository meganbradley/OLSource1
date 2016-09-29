---
title: "-ERRORREPORT (Report Internal Linker Errors)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ERRORREPORT (Report Internal Linker Errors)"
f1_keywords: 
  - "/ERRORREPORT"
  - "VC.Project.VCLinkerTool.ErrorReporting"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/ERRORREPORT linker option"
  - "ERRORREPORT linker option"
  - "-ERRORREPORT linker option"
ms.assetid: f5fab595-a2f1-4eb0-ab5c-1c0fbd3d8c28
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ERRORREPORT (Report Internal Linker Errors)
```  
/errorReport:[ none | prompt | queue | send ]  
```  
  
## Remarks  
 Lets you provide internal compiler error (ICE) information directly to Microsoft.  
  
 The option **/errorReport:send** tries to automatically send error information to Microsoft, but success depends on registry settings. For more information about how to set the appropriate values in the registry, see [How to Turn on Automatic Error Reporting in Visual Studio 2008 Command-line Tools](http://go.microsoft.com/fwlink/?LinkID=184695) on the MSDN Web site.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project **Property Pages** dialog box. For more information, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **Configuration Properties** folder.  
  
3.  Click the **Linker** folder.  
  
4.  Click the **Advanced** property page.  
  
5.  Modify the **Error Reporting**property.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.ErrorReporting*>.  
  
## See Also  
 [/errorReport (Report Internal Compiler Errors)](../vs140/-errorreport--report-internal-compiler-errors-.md)   
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)