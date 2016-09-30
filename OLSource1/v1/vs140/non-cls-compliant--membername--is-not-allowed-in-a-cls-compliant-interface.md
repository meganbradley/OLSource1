---
title: "Non-CLS-compliant &lt;membername&gt; is not allowed in a CLS-compliant interface"
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
  - "bc40033"
  - "vbc40033"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40033"
ms.assetid: 060c4b08-798e-40f1-94cf-c05c524f1b8a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Non-CLS-compliant &lt;membername&gt; is not allowed in a CLS-compliant interface
A property, procedure, or event in an interface is marked as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> when the interface itself is marked as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or is not marked.  
  
 For an interface to be compliant with the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), all its members must be compliant.  
  
 When you apply the \<xref:System.CLSCompliantAttribute*> to a programming element, you set the attribute's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter to either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply the \<xref:System.CLSCompliantAttribute*> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40033  
  
### To correct this error  
  
-   If you require CLS compliance and have control over the interface source code, mark the interface as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if all its members are compliant.  
  
-   If you require CLS compliance and do not have control over the interface source code, or if it does not qualify to be compliant, define this member within a different interface.  
  
-   If you require that this member remain within its current interface, remove the \<xref:System.CLSCompliantAttribute*> from its definition or mark it as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [Interface Statement (Visual Basic)](../vs140/interface-statement--visual-basic-.md)   
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)