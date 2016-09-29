---
title: "lastprivate"
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
  - "lastprivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lastprivate OpenMP clause"
ms.assetid: 6ef87b31-375a-47e8-8d0d-281be45fb56a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lastprivate
Specifies that the enclosing context's version of the variable is set equal to the private version of whichever thread executes the final iteration (for-loop construct) or last section (#pragma sections).  
  
## Syntax  
  
```  
lastprivate(var)  
```  
  
## Remarks  
 where,  
  
 `var`  
 The variable that is set equal to the private version of whichever thread executes the final iteration (for-loop construct) or last section (#pragma sections).  
  
## Remarks  
 `lastprivate` applies to the following directives:  
  
-   [for](../VS_csharp/for--openmp-.md)  
  
-   [sections](../VS_csharp/sections--openmp-.md)  
  
 For more information, see [2.7.2.3 lastprivate](../VS_csharp/2.7.2.3-lastprivate.md).  
  
## Example  
 See [schedule](../VS_csharp/schedule.md) for an example of using `lastprivate` clause.  
  
## See Also  
 [Clauses](../VS_csharp/openmp-clauses.md)