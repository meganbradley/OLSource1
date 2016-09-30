---
title: "Delegate type &#39;&lt;delegatename&gt;&#39; of event &#39;&lt;eventname&gt;&#39; is not CLS-compliant"
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
  - "bc40050"
  - "vbc40050"
helpviewer_keywords: 
  - "BC40050"
ms.assetid: 92f5be26-9a82-46d4-bf97-005f2c7ca424
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delegate type &#39;&lt;delegatename&gt;&#39; of event &#39;&lt;eventname&gt;&#39; is not CLS-compliant
An [Event Statement](../vs140/event-statement.md) uses a delegate to specify its signature, but the [Delegate Statement](../vs140/delegate-statement.md) is marked as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or is not marked.  
  
 When you apply the \<xref:System.CLSCompliantAttribute*> attribute to a programming element, you set the attribute's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter to either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply \<xref:System.CLSCompliantAttribute*> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40050  
  
### To correct this error  
  
-   If you require CLS compliance and have control over the definition of the delegate, apply \<xref:System.CLSCompliantAttribute*> to its declaration to mark it as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
-   If you do not have control over the definition of the delegate or cannot mark it as compliant, remove the \<xref:System.CLSCompliantAttribute*> from the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement or mark it as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)