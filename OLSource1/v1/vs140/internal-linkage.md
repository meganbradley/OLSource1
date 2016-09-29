---
title: "Internal Linkage"
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
  - "C"
helpviewer_keywords: 
  - "internal linkage"
  - "linkage [C++], internal"
ms.assetid: 80be7b51-c930-43db-94d6-4f09a64077bf
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Internal Linkage
If the declaration of a file-scope identifier for an object or a function contains the *storage-class-specifier* **static**, the identifier has internal linkage. Otherwise, the identifier has external linkage. See [Storage Classes](../vs140/c-storage-classes.md) for a discussion of the *storage-class-specifier* nonterminal.  
  
 Within one translation unit, each instance of an identifier with internal linkage denotes the same identifier or function. Internally linked identifiers are unique to a translation unit.  
  
## See Also  
 [Using extern to Specify Linkage](../vs140/using-extern-to-specify-linkage.md)