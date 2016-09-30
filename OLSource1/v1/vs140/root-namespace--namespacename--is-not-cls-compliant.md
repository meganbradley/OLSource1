---
title: "Root namespace &lt;namespacename&gt; is not CLS-compliant"
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
  - "bc40038"
  - "vbc40038"
helpviewer_keywords: 
  - "BC40038"
ms.assetid: ec850295-b2fe-4f19-b808-d22fe0aaa32d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Root namespace &lt;namespacename&gt; is not CLS-compliant
An assembly is marked as `<CLSCompliant(True)>`, but the root namespace name begins with an underscore (`_`).  
  
 A programming element can contain one or more underscores, but to be compliant with the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), it must not begin with an underscore. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
 When you apply the \<xref:System.CLSCompliantAttribute*> to a programming element, you set the attribute's `isCompliant` parameter to either `True` or `False` to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply the \<xref:System.CLSCompliantAttribute*> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40038  
  
### To correct this error  
  
-   If you require CLS compliance, change the root namespace name so that it does not begin with an underscore.  
  
-   If you require that the root namespace name remain unchanged, then remove the \<xref:System.CLSCompliantAttribute*> from the assembly or mark it as `<CLSCompliant(False)>`.  
  
## See Also  
 [Namespace Statement](../vs140/namespace-statement.md)   
 [Namespaces in Visual Basic](../vs140/namespaces-in-visual-basic.md)   
 [/rootnamespace](../vs140/-rootnamespace.md)   
 [NIB: How to: Change the Namespace for an Application (Visual Basic)](assetId:///029d85c0-e173-4f7a-afba-a29f3aaf6ebf)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Visual Basic Naming Conventions](../vs140/visual-basic-naming-conventions.md)   
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)