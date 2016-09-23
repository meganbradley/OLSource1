---
title: "FOR (MASM)"
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
  - for
dev_langs: 
  - C++
helpviewer_keywords: 
  - FOR directive
ms.assetid: 99872e61-f503-4d34-b305-59f8556ba6b7
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# FOR (MASM)
Marks a block that will be repeated once for each `argument`, with the current `argument` replacing `parameter` on each repetition.  
  
## Syntax  
  
```  
  
   FOR   
   parameter [[:REQ | :=default]] , <argument [[, argument]]...>  
statements  
ENDM  
```  
  
## Remarks  
 Same as [IRP](../vs140/irp.md).  
  
## See Also  
 [Directives Reference](../vs140/directives-reference.md)