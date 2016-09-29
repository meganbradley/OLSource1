---
title: "Type of &#39;&lt;variablename&gt;&#39; is ambiguous because the loop bounds and the step variable do not widen to the same type"
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
  - "vbc30983"
  - "bc30983"
helpviewer_keywords: 
  - "BC30983"
ms.assetid: 6b97153c-dee3-4429-b92a-2e5a212c864b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type of &#39;&lt;variablename&gt;&#39; is ambiguous because the loop bounds and the step variable do not widen to the same type
Your code contains a `For...Next` loop in which the compiler cannot infer a data type for the loop control variable because the following conditions is true:  
  
-   The data type of the loop control variable is not specified with an `As` clause.  
  
-   The loop bounds and step variable contain at least two data types.  
  
-   More than one possible conversion exists between the data types.  
  
-   There is no best type among the candidates, so that the choice of type for the loop control variable is ambiguous.  
  
 For example, the following loop has one loop bound of type `Integer` and one loop bound of type `UInteger`:  
  
```vb#  
Dim m As Integer = 1  
Dim n As UInteger = 10  
' Not valid.  
' For i = m To n  
    ' Loop processing.  
' Next  
```  
  
 There is a possible conversion between `Integer` and `UInteger`, and a possible conversion between `UInteger` and `Integer`, but both are narrowing conversions so neither is the best choice.  
  
 In the next example, a third variable of type `Double` is added. Both `Integer` and `UInteger` have standard widening conversions to `Double`, which makes conversion to `Double` the best choice. Type inference assigns to loop control variable `i` the data type `Double`.  
  
```vb#  
Dim stepVar As Double = 1  
' Valid.  
For i = m To n Step stepVar  
    ' Loop processing.  
Next  
```  
  
 **Error ID:** BC30983  
  
### To correct this error  
  
-   Explicitly convert one of the variables to a type that the others have a widening conversion to, for example:  
  
    ```  
    For i = m To CLng(n)  
    ```  
  
-   Use an `As` clause to specify the type of the control variable:  
  
    ```  
    For i As Double = m To n   
    ```  
  
## See Also  
 [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)