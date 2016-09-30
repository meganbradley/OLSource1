---
title: "Expression of type &#39;&lt;typename&gt;&#39; cannot be converted to &#39;Object&#39; or &#39;ValueType&#39;"
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
  - "bc31394"
  - "vbc31394"
helpviewer_keywords: 
  - "BC31394"
ms.assetid: e6f76257-65bb-4954-99f9-90f282648354
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expression of type &#39;&lt;typename&gt;&#39; cannot be converted to &#39;Object&#39; or &#39;ValueType&#39;
An expression evaluates to a type that cannot be boxed by the common language runtime (CLR).  
  
 *Boxing* refers to the processing necessary to convert a type to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or, on occasion, to \<xref:System.ValueType*>. The common language runtime cannot box certain types, for example \<xref:System.ArgIterator*> and \<xref:System.TypedReference*>.  
  
 If you have not used <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the statement containing this expression, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] has attempted an implicit conversion that causes this error.  
  
 **Error ID:** BC31394  
  
### To correct this error  
  
1.  Locate the expression that evaluates to the cited type.  
  
2.  Locate the part of your statement that attempts to box the cited type.  
  
3.  Rewrite the statement to avoid the boxing conversion.  
  
## See Also  
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)