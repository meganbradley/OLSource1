---
title: "&#39;And&#39; expected"
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
  - "vbc36620"
  - "bc36620"
helpviewer_keywords: 
  - "BC36620"
ms.assetid: b3d21d4d-86c0-44d2-8afc-c19d375e9ddd
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;And&#39; expected
A comparison operator other than `And` has been used to combine two or more `Equals` operators in a `Join` or `Group Join` clause. Only the `And` operator is allowed to combine multiple `Equals` operators in a `Join` or `Group Join` clause.  
  
 **Error ID:** BC36620  
  
### To correct this error  
  
1.  Restructure the `Equals` clauses to make comparisons by using only the `And` operator. The following is an example:  
  
    ```vb#  
    Dim petOwnersJoin = From pers In people _  
                        Join pet In pets _  
                        On pet.Owner Equals pers And _  
                           pet.Name = pers.PetName_  
                        Select pers, pet  
    ```  
  
## See Also  
 [How To: Combine Data with LINQ by Using Joins (Visual Basic)](../vs140/how-to--combine-data-with-linq-by-using-joins--visual-basic-.md)   
 [Join Clause (Visual Basic)](../vs140/join-clause--visual-basic-.md)   
 [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)