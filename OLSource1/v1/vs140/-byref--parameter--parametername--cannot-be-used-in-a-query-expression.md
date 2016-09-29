---
title: "&#39;ByRef&#39; parameter &lt;parametername&gt; cannot be used in a query expression"
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
  - "vbc36533"
  - "bc36533"
helpviewer_keywords: 
  - "BC36533"
ms.assetid: 8067ac87-dd6b-4869-87d0-8a4ce272de41
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;ByRef&#39; parameter &lt;parametername&gt; cannot be used in a query expression
A parameter included in a LINQ query is a pointer type. Parameters used in query expressions cannot be passed by reference.  
  
 **Error ID:** BC36533  
  
### To correct this error  
  
1.  Declare a new variable and assign the value of the new variable to a copy of the value that is passed by reference. Use the copied variable in the LINQ query. The following is an example:  
  
    ```vb#  
    Sub RunQuery(ByVal collection As List(Of Integer), _  
                 ByRef filterValue As Integer)  
        Dim fv = filterValue  
        Dim queryResult = From num In collection _  
                          Where num < fv  
    End Sub  
    ```  
  
### To correct this error  
  
1.  Replace the `ByRef` keyword with the `ByVal` keyword for the parameter used in the query.  
  
## See Also  
 [Differences Between Passing an Argument By Value and By Reference](../vs140/differences-between-passing-an-argument-by-value-and-by-reference--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)