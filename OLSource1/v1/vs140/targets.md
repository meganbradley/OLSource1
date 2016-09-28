---
title: "Targets"
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
  - "targets, specifying in NMAKE"
ms.assetid: 826ee849-4278-4c6e-97c3-79a2b5fe6463
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Targets
In a dependency line, specify one or more targets, using any valid filename, directory name, or [pseudotarget](../vs140/pseudotargets.md). Separate multiple targets with one or more spaces or tabs. Targets are not case sensitive. Paths are permitted with filenames. A target cannot exceed 256 characters. If the target preceding the colon is a single character, use a separating space; otherwise, NMAKE interprets the letter-colon combination as a drive specifier.  
  
## What do you want to know more about?  
 [Pseudotargets](../vs140/pseudotargets.md)  
  
 [Multiple targets](../vs140/multiple-targets.md)  
  
 [Cumulative dependencies](../vs140/cumulative-dependencies.md)  
  
 [Targets in multiple description blocks](../vs140/targets-in-multiple-description-blocks.md)  
  
 [Dependency side effects](../vs140/dependency-side-effects.md)  
  
## See Also  
 [Description Blocks](../vs140/description-blocks.md)