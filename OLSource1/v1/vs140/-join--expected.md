---
title: "&#39;Join&#39; expected"
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
  - vbc36631
  - bc36631
helpviewer_keywords: 
  - BC36631
ms.assetid: bb2b03b6-6784-423a-b91a-cb7066c1d093
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;Join&#39; expected
A `Group Join` clause has been specified without a `Join` keyword.  
  
 **Error ID:** BC36631  
  
### To correct this error  
  
1.  Add the `Join` keyword to the `Group Join` clause, as shown in the following example:  
  
    ```vb#  
    Dim query = From var1 In collection1 _  
                Join var2 In collection2 _  
                Group Join var3 In collection3 _  
                On var2.ID Equals var3 Into Matches = Group _  
                On var1 Equals var2.ID _  
                Select JoinID = var1, var2.Name, Matches  
    ```  
  
## See Also  
 [How To: Combine Data with LINQ by Using Joins (Visual Basic)](../vs140/how-to--combine-data-with-linq-by-using-joins--visual-basic-.md)   
 [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)