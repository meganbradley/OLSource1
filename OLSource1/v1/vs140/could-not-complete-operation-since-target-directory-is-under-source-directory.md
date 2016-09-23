---
title: "Could not complete operation since target directory is under source directory"
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
  - vbrIO_CyclicOperation
ms.assetid: 850d3a24-5d51-4ac8-a912-630efcd75278
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Could not complete operation since target directory is under source directory
A cyclic operation has failed. Cyclic operations cycle and therefore cannot complete. For example, Object A may attempt to inherit from Object B, which in turn inherits from Object A.  
  
### To correct this error  
  
-   When inheriting, make sure that there are no cyclic references.  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)   
 [Debugging Basics: Breakpoints](assetId:///752a02c2-0ac7-4c8b-aa1b-4b2b3b21152e)