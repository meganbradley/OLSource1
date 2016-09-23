---
title: "Range variable name cannot match the name of a member of the &#39;Object&#39; class"
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
  - bc36606
  - vbc36606
helpviewer_keywords: 
  - BC36606
ms.assetid: 964245e6-2601-4de6-8a51-25c0d9633418
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Range variable name cannot match the name of a member of the &#39;Object&#39; class
A range variable in a LINQ query matches the name of a member of the <xref:System.Object?qualifyHint=False> class. This creates a conflict with the objects created by Visual Basic for the LINQ query.  
  
 **Error ID:** BC36606  
  
### To correct this error  
  
1.  Choose a new name for the range variable that does not match the name of any member of the <xref:System.Object?qualifyHint=False> class.  
  
## See Also  
 <xref:System.Object?qualifyHint=False>   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md)   
 [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md)   
 [Select Clause (Visual Basic)](../vs140/select-clause--visual-basic-.md)