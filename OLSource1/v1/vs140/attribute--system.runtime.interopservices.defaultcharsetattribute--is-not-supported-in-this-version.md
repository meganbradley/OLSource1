---
title: "Attribute &#39;System.Runtime.InteropServices.DefaultCharSetAttribute&#39; is not supported in this version"
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
  - "bc32510"
  - "vbc32510"
helpviewer_keywords: 
  - "BC32510"
ms.assetid: e2eec233-6e0b-4f2f-a801-b0274e579c0e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attribute &#39;System.Runtime.InteropServices.DefaultCharSetAttribute&#39; is not supported in this version
The \<xref:System.Runtime.InteropServices.DefaultCharSetAttribute*?displayProperty=fullName> attribute allows you to specify the character set to be used in marshaled strings. Its value takes a member of the \<xref:System.Runtime.InteropServices.CharSet*?displayProperty=fullName> enumeration.  
  
 The current version of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] does not support this attribute. Support is possible in future versions.  
  
 **Error ID:** BC32510  
  
### To correct this error  
  
-   Use each [Declare Statement](../vs140/declare-statement.md) to specify the character set for the external procedure it is declaring. The following example illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     If you do not specify the character set in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement, it defaults to ANSI.  
  
## See Also  
 \<xref:System.Runtime.InteropServices.DefaultCharSetAttribute*>   
 \<xref:System.Runtime.InteropServices.CharSet*>   
 [NOT IN BUILD: Attributes in Visual Basic](assetId:///620bfc0e-4582-4c8b-8432-ebc5c3dccc22)   
 [Declare Statement](../vs140/declare-statement.md)