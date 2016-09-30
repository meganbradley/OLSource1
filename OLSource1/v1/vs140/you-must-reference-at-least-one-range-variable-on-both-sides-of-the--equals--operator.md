---
title: "You must reference at least one range variable on both sides of the &#39;Equals&#39; operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc36622"
  - "bc36622"
helpviewer_keywords: 
  - "BC36622"
ms.assetid: 8d301227-131d-4977-b3ff-1fc4e427f8fa
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# You must reference at least one range variable on both sides of the &#39;Equals&#39; operator
You must reference at least one range variable on both sides of the 'Equals' operator. Range variable(s) \<variable(s)> must appear on one side of the 'Equals' operator, and range variable(s) \<variable(s)> must appear on the other.  
  
 Range variables identified for collections to be joined in a LINQ query must be on opposite sides of the `Equals` operator, depending on the collection they are identified for. That is, range variables identified for one of the collections being joined must be on the opposite side of the `Equals` operator from range variables for the other collection being joined. Range variables from separate collections cannot be mixed on the same side of the `Equals` operator.  
  
 At least one variable from each collection being joined must be referenced on each side of the `Equals` operator.  
  
 **Error ID:** BC36622  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Join Clause (Visual Basic)](../vs140/join-clause--visual-basic-.md)   
 [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md)   
 [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md)   
 [Select Clause (Visual Basic)](../vs140/select-clause--visual-basic-.md)