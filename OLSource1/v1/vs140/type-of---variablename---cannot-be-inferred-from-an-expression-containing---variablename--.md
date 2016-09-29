---
title: "Type of &#39;&lt;variablename&gt;&#39; cannot be inferred from an expression containing &#39;&lt;variablename&gt;&#39;"
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
  - "vbc30980"
  - "bc30980"
helpviewer_keywords: 
  - "BC30980"
ms.assetid: 43a5d008-5362-481b-845b-b9bb00a61a83
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type of &#39;&lt;variablename&gt;&#39; cannot be inferred from an expression containing &#39;&lt;variablename&gt;&#39;
The compiler cannot infer the data type of a variable if the variable is used in establishing its initial value in the declaration.  
  
 For example, with `Option Infer` set to `On`, the following examples do not compile:  
  
-   Declarations  
  
    ```  
    ' Does not compile with Option Infer on.  
    Dim m = m  
    Dim d = someFunction(d)  
    ```  
  
-   `For` loop  
  
    ```  
    ' Does not compile with Option Infer on.  
    For j = 1 To j  
    Next  
    ```  
  
-   `For Each` loop  
  
    ```  
    ' Does not compile with Option Infer on.  
    For Each customer In customer.Orders  
    Next  
    ```  
  
 **Error ID:** BC30980  
  
### To correct this error  
  
-   If the two variables were intended to refer to different values, change the name of the variable that you are declaring.  
  
-   Use a literal value instead of the variable name in the initial value, on the right side of the assignment.  
  
-   Use an `As` clause to specify the type of the variable you are declaring.  
  
## See Also  
 [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md)   
 [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md)   
 [For Statement](../vs140/for...next-statement--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)