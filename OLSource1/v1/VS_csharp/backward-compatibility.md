---
title: "Backward Compatibility"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.programs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CRT, compatibility"
  - "backward compatibility, C run-time libraries"
  - "compatibility, C run-time libraries"
  - "backward compatibility"
ms.assetid: cc3175cf-97fd-492f-b329-5791aea63090
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Backward Compatibility
For compatibility between product versions, the library OLDNAMES.LIB maps old names to new names. For instance, `open` maps to `_open`. You must explicitly link with OLDNAMES.LIB only when you compile with the following combinations of command-line options:  
  
-   `/Zl` (omit default library name from object file) and `/Ze` (the default — use Microsoft extensions)  
  
-   `/link` (linker-control), `/NOD` (no default-library search), and `/Ze`  
  
 For more information about compiler command-line options, see [Compiler Reference](../VS_csharp/compiler-options.md).  
  
## See Also  
 [Compatibility](../VS_csharp/compatibility.md)