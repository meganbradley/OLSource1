---
title: "&#39;&lt;procedurename&gt;&#39; method for event &#39;&lt;eventname&gt;&#39; cannot be marked CLS compliant because its containing type &#39;&lt;typename&gt;&#39; is not CLS compliant"
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
  - "vbc40053"
  - "bc40053"
helpviewer_keywords: 
  - "BC40053"
ms.assetid: 5f7aaf64-b5e6-4f97-9ebd-44cd4c7e8bf5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;procedurename&gt;&#39; method for event &#39;&lt;eventname&gt;&#39; cannot be marked CLS compliant because its containing type &#39;&lt;typename&gt;&#39; is not CLS compliant
A custom event declares an `AddHandler` or `RemoveHandler` procedure and marks it as `<CLSCompliant(True)>`, but the event is defined in a type that is marked as `<CLSCompliant(False)>` or is not marked.  
  
 When you apply <xref:System.CLSCompliantAttribute*> to a programming element, you set the attribute's `isCompliant` parameter to either `True` or `False` to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply <xref:System.CLSCompliantAttribute*> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40053  
  
### To correct this error  
  
-   If you require CLS compliance, define the event within a type that is CLS compliant.  
  
-   If you require that the event remain within its containing type, remove <xref:System.CLSCompliantAttribute*> from its definition or mark it as `<CLSCompliant(False)>`.  
  
## See Also  
 [How to: Declare Events That Avoid Blocking](../vs140/how-to--declare-custom-events-to-avoid-blocking--visual-basic-.md)   
 [How to: Declare Events That Conserve Memory Use](../vs140/how-to--declare-custom-events-to-conserve-memory--visual-basic-.md)   
 [NOT IN BUILD:AddHandler and RemoveHandler](assetId:///a7a24bd2-519a-46fe-8a2c-2b9df2ca28ef)   
 [<PAVE OVER\> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)