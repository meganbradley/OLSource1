---
title: "&#39;&lt;elementname&gt;&#39; is obsolete (Visual Basic Warning)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc40008"
  - "bc40008"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40008"
ms.assetid: 729e3eb5-76ac-4c55-9fdd-78350e0de55e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;elementname&gt;&#39; is obsolete (Visual Basic Warning)
A statement attempts to access a programming element which has been marked with the \<xref:System.ObsoleteAttribute*> attribute and the directive to treat it as a warning.  
  
 You can mark any programming element as being no longer in use by applying \<xref:System.ObsoleteAttribute*> to it. If you do this, you can set the attribute's \<xref:System.ObsoleteAttribute.IsError*> property to either <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. If you set it to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the compiler treats an attempt to use the element as an error. If you set it to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or let it default to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the compiler issues a warning if there is an attempt to use the element.  
  
 By default, this message is a warning, because the \<xref:System.ObsoleteAttribute.IsError*> property of \<xref:System.ObsoleteAttribute*> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information about hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40008  
  
### To correct this error  
  
-   Ensure that the source-code reference is spelling the element name correctly.  
  
## See Also  
 [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md)