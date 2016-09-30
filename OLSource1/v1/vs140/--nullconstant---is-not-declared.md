---
title: "&#39;&lt;nullconstant&gt;&#39; is not declared"
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
  - "bc30822"
  - "vbc30822"
helpviewer_keywords: 
  - "BC30822"
ms.assetid: dda0e2c1-46a3-4cc4-b36c-0858a5259bac
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;nullconstant&gt;&#39; is not declared
'\<nullconstant>' is not declared. Null constant is no longer supported; use System.DBNull instead.  
  
 A statement uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword, which is no longer supported in Visual Basic.  
  
 **Error ID:** BC30822  
  
### To correct this error  
  
1.  Use \<xref:System.DBNull*> instead of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The following example demonstrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Use the [Nothing](../vs140/nothing--visual-basic-.md) keyword for assignments and comparisons when you use object variables. The following example demonstrates this.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.DBNull*>   
 [Nothing](../vs140/nothing--visual-basic-.md)   
 [Programming Element Support Changes Summary](assetId:///0483590a-6309-449c-a2fa-effa26a03b95)