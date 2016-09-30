---
title: "&#39;Class&#39; constraint and &#39;Structure&#39; constraint cannot be combined"
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
  - "vbc32104"
  - "bc32104"
helpviewer_keywords: 
  - "BC32104"
ms.assetid: f41a581b-afca-4173-bc82-b35ed49caba0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Class&#39; constraint and &#39;Structure&#39; constraint cannot be combined
A constraint list includes both the [Class (Visual Basic)](assetId:///0777c6e6-46bc-451b-ad70-57b49d4ef4f7) constraint and the [Structure (Visual Basic)](assetId:///263ce115-ac36-4c05-8cb7-0e0eead5c6d0) constraint.  
  
 A constraint list on a type parameter can specify that the type argument passed to that type parameter must be a value type (with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> constraint) or must be a reference type (with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> constraint). You cannot specify both constraints on the same type parameter, and you cannot specify either one more than once.  
  
 **Error ID:** BC32104  
  
### To correct this error  
  
1.  Decide whether you want to require a value type or a reference type for the type argument.  
  
    -   If you want the type argument to be a value type, remove the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword from the constraint list.  
  
    -   If you want the type argument to be a reference type, remove the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword from the constraint list.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)