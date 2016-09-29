---
title: "-MANIFESTUAC (Embeds UAC information in manifest)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/MANIFESTUAC (Embeds UAC information in manifest)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.UACUIAccess"
  - "VC.Project.VCLinkerTool.UACExecutionLevel"
  - "VC.Project.VCLinkerTool.EnableUAC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/MANIFESTUAC linker option"
  - "MANIFESTUAC linker option"
  - "-MANIFESTUAC linker option"
ms.assetid: 2d243c39-fa13-493c-b56f-d0d972a1603a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -MANIFESTUAC (Embeds UAC information in manifest)
Specifies whether User Account Control (UAC) information is embedded in the program manifest.  
  
## Syntax  
  
```  
/MANIFESTUAC  
/MANIFESTUAC:NO  
/MANIFESTUAC:fragment  
/MANIFESTUAC:level=_level  
/MANIFESTUAC:uiAccess=_uiAccess  
```  
  
#### Parameters  
 `fragment`  
 A string that contains the `level` and `uiAccess` values. For more information, see the Remarks section later in this topic.  
  
 `_level`  
 One of *asInvoker*, *highestAvailable*, or *requireAdministrator*. Defaults to asInvoker. For more information, see the Remarks section later in this topic.  
  
 `_uiAccess`  
 `true` if you want the application to bypass user interface protection levels and drive input to higher-permission windows on the desktop; otherwise, `false`. Defaults to `false`. Set to `true` only for user interface accessibility applications.  
  
## Remarks  
 If you specify multiple /MANIFESTUAC options on the command-line, the last one entered takes precedence.  
  
 The choices for /MANIFESTUAC:level are as follows:  
  
-   `asInvoker`: The application will run with the same permissions as the process that started it. The application can be elevated to a higher permission level by selecting **Run as Administrator**.  
  
-   highestAvailable: The application will run with the highest permission level that it can. If the user who starts the application is a member of the Administrators group, this option is the same as requireAdministrator. If the highest available permission level is higher than the level of the opening process, the system will prompt for credentials.  
  
-   requireAdministrator: The application will run with administrator permissions. The user who starts the application must be a member of the Administrators group. If the opening process is not running with administrative permissions, the system will prompt for credentials.  
  
 You can specify the level and uiAccess values in one step by using the /MANIFESTUAC:fragment option. The fragment must be in the following form:  
  
```  
"level=[ asInvoker | highestAvailable | requireAdministrator ] uiAccess=[ true | false ]"  
```  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Expand the **Configuration Properties** node.  
  
3.  Expand the **Linker** node.  
  
4.  Select the **Manifest File** property page.  
  
5.  Modify the **Enable User Account Control (UAC)**, **UAC Execution Level**, and **UAC Bypass UI Protection** properties.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.EnableUAC*>, <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.UACExecutionLevel*>, and <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.UACUIAccess*>.  
  
## See Also  
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Linker Options](../VS_csharp/linker-options.md)