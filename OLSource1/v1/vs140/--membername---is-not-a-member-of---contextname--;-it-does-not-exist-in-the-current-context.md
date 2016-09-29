---
title: "&#39;&lt;membername&gt;&#39; is not a member of &#39;&lt;contextname&gt;&#39;; it does not exist in the current context"
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
  - "vbc36557"
  - "bc36557"
helpviewer_keywords: 
  - "BC36557"
ms.assetid: d8671f1c-d545-44da-89b3-7d892e01e8be
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;membername&gt;&#39; is not a member of &#39;&lt;contextname&gt;&#39;; it does not exist in the current context
A non-existent member name has been assigned to a property in an anonymous type declaration. In the following example, `.Prop1` and `.Prop2` are the properties of the anonymous type. The attempt to assign `.Prop3` to `.Prop2` causes the error.  
  
```vb#  
' Not valid.  
Dim anon1 = New With {.Prop1 = 27, .Prop2 = .Prop3}  
  
' The assignment is valid if the assigned property has been declared   
' and initialized.  
Dim anon2 = New With {.Prop1 = 27, .Prop2 = .Prop1}  
```  
  
 **Error ID:** BC36657  
  
### To correct this error  
  
-   Examine your code to determine what you want to assign. The variable name might be misspelled, or it might require qualification if it is a property of another object.  
  
## See Also  
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [How to: Infer Property Names and Types in Anonymous Type Declarations](../vs140/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md)