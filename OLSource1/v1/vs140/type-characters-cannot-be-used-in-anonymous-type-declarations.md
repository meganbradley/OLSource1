---
title: "Type characters cannot be used in anonymous type declarations"
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
  - "bc36560"
  - "vbc36560"
helpviewer_keywords: 
  - "BC36560"
ms.assetid: 70eee559-d6fc-409b-b835-2c84511b160e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type characters cannot be used in anonymous type declarations
You cannot use a type character on a property name when you declare an instance of an anonymous type. The data type of the property is inferred from the value assigned to it. For example, the following declarations are not valid.  
  
```vb#  
'' Not valid.  
'Dim anon1 = New With {.ID$ = "abc"}  
'Dim anon2 = New With {.ID$ = 42}  
```  
  
 **Error ID:** BC36560  
  
### To correct this error  
  
-   Remove the type character from the initializer list. You can explicitly convert the assigned value if this is necessary to establish the data type you want for the property.  
  
    ```vb#  
    ' Valid.  
    Dim anon1 = New With {.ID = "abc"}  
    Dim anon2 = New With {.ID = CStr(42)}  
    ```  
  
## See Also  
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [How to: Infer Property Names and Types in Anonymous Type Declarations](../vs140/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)