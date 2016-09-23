---
title: "LINK Environment Variables"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - link
dev_langs: 
  - C++
helpviewer_keywords: 
  - variables, environment
  - LINK tool [C++], environment variables
  - LIB environment variable
  - environment variables [C++], LINK
ms.assetid: 9a3d3291-0cc4-4a7d-9d50-80e351b90708
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# LINK Environment Variables
The LINK tool uses the following environment variables:  
  
-   LINK and _LINK\_, if defined. The LINK tool prepends the options and arguments defined in the LINK environment variable and appends the options and arguments defined in the _LINK\_ environment variable to the command line arguments before processing.  
  
-   LIB, if defined. The LINK tools uses the LIB path when searching for an object, library, or other file specified on the command line or by the [/BASE](../vs140/-base--base-address-.md) option. It also uses the LIB path to find a .pdb file named in an object. The LIB variable can contain one or more path specifications, separated by semicolons. One path must point to the \lib subdirectory of your Visual C++ installation.  
  
-   PATH, if the tool needs to run CVTRES and cannot find the file in the same directory as LINK itself. (LINK requires CVTRES to link a .res file.) PATH must point to the \bin subdirectory of your Visual C++ installation.  
  
-   TMP, to specify a directory when linking OMF or .res files.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)   
 [Setting the Path and Environment Variables for Command-Line Builds](../vs140/setting-the-path-and-environment-variables-for-command-line-builds.md)