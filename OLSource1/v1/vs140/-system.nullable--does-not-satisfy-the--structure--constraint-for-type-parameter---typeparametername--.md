---
title: "&#39;System.Nullable&#39; does not satisfy the &#39;Structure&#39; constraint for type parameter &#39;&lt;typeparametername&gt;&#39;"
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
  - "bc32115"
  - "vbc32115"
helpviewer_keywords: 
  - "BC32115"
ms.assetid: 98053645-fa76-4826-a7c1-f1bdf3511863
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;System.Nullable&#39; does not satisfy the &#39;Structure&#39; constraint for type parameter &#39;&lt;typeparametername&gt;&#39;
A generic type is invoked passing a type argument of <xref:System.Nullable`1*> to a type parameter with a `Structure` constraint.  
  
 The common language runtime (CLR) specifically disallows the <xref:System.Nullable`1*> structure as a type argument to itself. Even though it is a structure and would otherwise satisfy a `Structure` constraint, using it recursively could lead to awkward constructions such as `Nullable(Of Nullable(Of Nullable))`.  
  
 **Error ID:** BC32115  
  
### To correct this error  
  
-   Either remove the `Structure` constraint from the type parameter, or change the type argument to some value type other than <xref:System.Nullable`1*>.  
  
## See Also  
 <xref:System.Nullable`1*>   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Structure (Visual Basic)](assetId:///263ce115-ac36-4c05-8cb7-0e0eead5c6d0)