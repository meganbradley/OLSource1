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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Targets
In a dependency line, specify one or more targets, using any valid filename, directory name, or [pseudotarget](../VS_csharp/pseudotargets.md). Separate multiple targets with one or more spaces or tabs. Targets are not case sensitive. Paths are permitted with filenames. A target cannot exceed 256 characters. If the target preceding the colon is a single character, use a separating space; otherwise, NMAKE interprets the letter-colon combination as a drive specifier.  
  
## What do you want to know more about?  
 [Pseudotargets](../VS_csharp/pseudotargets.md)  
  
 [Multiple targets](../VS_csharp/multiple-targets.md)  
  
 [Cumulative dependencies](../VS_csharp/cumulative-dependencies.md)  
  
 [Targets in multiple description blocks](../VS_csharp/targets-in-multiple-description-blocks.md)  
  
 [Dependency side effects](../VS_csharp/dependency-side-effects.md)  
  
## See Also  
 [Description Blocks](../VS_csharp/description-blocks.md)