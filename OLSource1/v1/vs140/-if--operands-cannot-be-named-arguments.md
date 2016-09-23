---
title: "&#39;If&#39; operands cannot be named arguments"
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
  - bc33105
  - vbc33105
helpviewer_keywords: 
  - BC33105
ms.assetid: 596baeb6-a44f-4d92-beb7-06624b60c00d
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;If&#39; operands cannot be named arguments
Using named arguments in the operands of the `If` operator is not valid. The following example causes this error:  
  
```  
Dim i As Integer  
Dim result As String  
' Not valid.  
' result = (If(i > 0, TruePart:="positive", FalsePart:="not positive")  
```  
  
 This differs from the `IIf` function, which does allow named arguments, as shown in the following code:  
  
```  
' Valid.  
IIf(i > 0, TruePart:="positive", FalsePart:="not positive")  
```  
  
 **Error ID:** BC33105  
  
### To correct this error  
  
-   Remove the name assignments from the operands, as shown in the following code.  
  
    ```  
    result = If(i > 0, "positive", "not positive")  
    ```  
  
## See Also  
 [If Operator](../vs140/if-operator--visual-basic-.md)   
 [Argument Passing by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)