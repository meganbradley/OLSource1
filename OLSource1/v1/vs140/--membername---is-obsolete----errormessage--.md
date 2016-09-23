---
title: "&#39;&lt;membername&gt;&#39; is obsolete: &#39;&lt;errormessage&gt;&#39;"
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
  - bc30668
  - vbc30668
helpviewer_keywords: 
  - BC30668
ms.assetid: 25e5606c-2734-4f42-a2bc-1ad28ec1e892
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;&lt;membername&gt;&#39; is obsolete: &#39;&lt;errormessage&gt;&#39;
A statement attempts to access a class or structure member which has been marked with the <xref:System.ObsoleteAttribute?qualifyHint=False> attribute and the directive to treat it as an error.  
  
 You can mark any programming element as being no longer in use by applying <xref:System.ObsoleteAttribute?qualifyHint=False> to it. If you do this, you can set the attribute's <xref:System.ObsoleteAttribute.IsError?qualifyHint=False> property to either `True` or `False`. If you set it to `True`, the compiler treats an attempt to use the element as an error. If you set it to `False`, or let it default to `False`, the compiler issues a warning if there is an attempt to use the element.  
  
 **Error ID:** BC30668  
  
### To correct this error  
  
1.  Examine the quoted error message and take appropriate action.  
  
2.  Ensure that the source code reference is spelling the member name correctly.  
  
## See Also  
 [NOT IN BUILD: Attributes Used in Visual Basic](assetId:///22231318-8a40-49af-9245-e0aab723563b)   
 [NOT IN BUILD: Application of Attributes](assetId:///2b1703ed-4437-49b3-bc0b-568094324f47)