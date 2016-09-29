---
title: "Type arguments for extension method &#39;&lt;methodName&gt;&#39; defined in &#39;&lt;typeName&gt;&#39; could not be inferred from the delegate &#39;&lt;delagateName&gt;&#39;"
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
  - "bc36581"
  - "vbc36581"
helpviewer_keywords: 
  - "BC36581"
ms.assetid: 2bb9ca8d-7293-40e9-9285-e20b8254b3af
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type arguments for extension method &#39;&lt;methodName&gt;&#39; defined in &#39;&lt;typeName&gt;&#39; could not be inferred from the delegate &#39;&lt;delagateName&gt;&#39;
An assignment statement uses `AddressOf` to assign the address of a generic extension method to a delegate, but it does not supply any type arguments to the extension method.  
  
 Normally, when you invoke a generic method, you supply a type argument for each type parameter that the generic method defines. If you do not supply any type arguments, the compiler attempts to infer the types to be passed to the type parameters. If the context does not provide enough information for the compiler to infer the types, an error is generated.  
  
 **Error ID:** BC36581  
  
### To correct this error  
  
-   In the `AddressOf` expression, specify the type arguments for the extension method.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)