---
title: "Constraint &#39;&lt;constraint1&gt;&#39; conflicts with the indirect constraint &#39;&lt;constraint2&gt;&#39; obtained from the type parameter constraint &#39;&lt;typeparameter1&gt;&#39;"
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
  - "bc32110"
  - "vbc32110"
helpviewer_keywords: 
  - "BC32110"
ms.assetid: e799214d-23b4-4a3f-b61a-0b9d3387ead3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constraint &#39;&lt;constraint1&gt;&#39; conflicts with the indirect constraint &#39;&lt;constraint2&gt;&#39; obtained from the type parameter constraint &#39;&lt;typeparameter1&gt;&#39;
A generic type is declared with conflicting constraints due to a combination of direct and indirect constraints.  
  
 The following statement can generate this error.  
  
 `Public Class testClass(Of t1 As {Structure, t2}, t2 As Class)`  
  
 The direct constraint `Structure` and the indirect constraint `Class` cause a conflict for type parameter `t1`, because the `Structure` constraint requires that the corresponding type argument be a value type, while `Class` requires that it be a reference type.  
  
 **Error ID:** BC32110  
  
### To correct this error  
  
-   Change the type parameter constraints to avoid conflicting constraints.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Structure (Visual Basic)](assetId:///263ce115-ac36-4c05-8cb7-0e0eead5c6d0)   
 [Class (Visual Basic)](assetId:///0777c6e6-46bc-451b-ad70-57b49d4ef4f7)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)