---
title: "-IMPORTS (DUMPBIN)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /IMPORTS (DUMPBIN)
f1_keywords: 
  - /imports
dev_langs: 
  - C++
helpviewer_keywords: 
  - IMPORTS dumpbin option
  - /IMPORTS dumpbin option
  - -IMPORTS dumpbin option
ms.assetid: 6a296216-2b1b-40f8-8736-cd4553a22456
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -IMPORTS (DUMPBIN)
```  
/IMPORTS[:file]  
```  
  
 This option displays the list of DLLs (both statically linked and [delay loaded](../vs140/linker-support-for-delay-loaded-dlls.md)) that are imported to an executable file or DLL and all the individual imports from each of these DLLs.  
  
 The optional `file` specification allows you to specify that the imports for only that DLL will be displayed. For example:  
  
```  
dumpbin /IMPORTS:msvcrt.dll  
```  
  
## Remarks  
 The output displayed by this option is similar to the [/EXPORTS](../vs140/-exports.md) output.  
  
 Only the [/HEADERS](../vs140/-headers.md) DUMPBIN option is available for use on files produced with the [/GL](../vs140/-gl--whole-program-optimization-.md) compiler option.  
  
## See Also  
 [DUMPBIN Options](../vs140/dumpbin-options.md)