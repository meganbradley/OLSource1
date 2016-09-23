---
title: "Loop control variable cannot be a property or a late-bound indexed array"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc30039
  - vbc30039
helpviewer_keywords: 
  - BC30039
ms.assetid: 63846449-b1df-4626-bf99-36fa9b187799
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Loop control variable cannot be a property or a late-bound indexed array
The variable used to iterate through a `For` loop must be of a numeric data type.  
  
 **Error ID:** BC30039  
  
### To correct this error  
  
-   Change the declaration of the loop control variable to specify `Integer`, `Short`, `Long`, `Byte`, `Single`, `Double`, or `Decimal`.  
  
## See Also  
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)