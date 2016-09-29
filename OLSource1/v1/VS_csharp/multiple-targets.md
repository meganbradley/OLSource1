---
title: "Multiple Targets"
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
  - "makefiles, targets"
  - "multiple targets in NMAKE"
  - "targets, multiple in NMAKE"
  - "NMAKE program, targets"
ms.assetid: b609a179-0b9f-4b08-9930-998047588ae0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multiple Targets
NMAKE evaluates multiple targets in a single dependency as if each were specified in a separate description block.  
  
 For example, this...  
  
 **bounce.exe leap.exe : jump.obj**  
 **echo Building...** ...is evaluated as this:  
  
 **bounce.exe : jump.obj**  
 **echo Building...**  
**leap.exe : jump.obj**  
 **echo Building...**   
## See Also  
 [Targets](../VS_csharp/targets.md)