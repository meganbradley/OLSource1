---
title: "BSCMAKE Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BSCMAKE, reference"
  - "Microsoft Browse Information Maintenance Utility"
  - "browse windows"
  - "browse information files (.bsc), building"
  - ".bsc files, building"
  - "bsc files, building"
  - "BSCMAKE"
ms.assetid: b97ad994-1355-4809-98db-6abc12c6fb13
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BSCMAKE Reference
> [!WARNING]
>  Although BSCMAKE is still installed with Visual Studio, it is no longer used by the IDE. Since Visual Studio 2008, browse and symbol information is stored automatically in a SQL Server .sdf file in the solution folder.  
  
 The Microsoft Browse Information Maintenance Utility (BSCMAKE.EXE) builds a browse information file (.bsc) from .sbr files created during compilation. You view a browse information file in the Object Browser. For information about the Object Browser, see [Navigating in the Object Browser](assetId:///53eb91aa-08c6-4299-8e3c-a877ae8d0c55).  
  
 When you build your program, you can create a browse information file for your program automatically, using BSCMAKE to build the file. You do not need to know how to run BSCMAKE if you create your browse information file in the Visual C++ development environment. However, you may want to read this topic to understand the choices available.  
  
 If you build your program outside of the development environment, you can still create a custom .bsc that you can examine in the environment. Run BSCMAKE on the .sbr files that you created during compilation.  
  
> [!NOTE]
>  You can start this tool only from the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] command prompt. You cannot start it from a system command prompt or from File Explorer.  
  
 This section includes the following topics:  
  
-   [Building Browse Information Files: Overview](../vs140/building-browse-information-files--overview.md)  
  
-   [Building a .bsc file](../vs140/building-a-.bsc-file.md)  
  
-   [BSCMAKE command line](../vs140/bscmake-command-line.md)  
  
-   [BSCMAKE command file](../vs140/bscmake-command-file--response-file-.md)  
  
-   [BSCMAKE options](../vs140/bscmake-options.md)  
  
-   [BSCMAKE exit codes](../vs140/bscmake-exit-codes.md)  
  
## See Also  
 [C/C++ Build Tools](../vs140/c-c---build-tools.md)