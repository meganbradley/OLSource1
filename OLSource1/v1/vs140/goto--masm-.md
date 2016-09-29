---
title: "GOTO (MASM)"
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
  - "goto"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GOTO directive"
ms.assetid: 6a5f73e7-6784-4eae-ac52-4fc77a7f369f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GOTO (MASM)
Transfers assembly to the line marked **:***macrolabel*.  
  
## Syntax  
  
```  
  
GOTO   
macrolabel  
  
```  
  
## Remarks  
 **GOTO** is permitted only inside [MACRO](../vs140/macro.md), [FOR](../vs140/for--masm-.md), [FORC](../vs140/forc.md), [REPEAT](../vs140/repeat.md), and **WHILE** blocks. The label must be the only directive on the line and must be preceded by a leading colon.  
  
## See Also  
 [Directives Reference](../vs140/directives-reference.md)