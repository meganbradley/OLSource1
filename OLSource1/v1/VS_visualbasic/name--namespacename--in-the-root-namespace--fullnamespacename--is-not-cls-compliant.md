---
title: "Name &lt;namespacename&gt; in the root namespace &lt;fullnamespacename&gt; is not CLS-compliant"
ms.custom: na
ms.date: "10/10/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc40039"
  - "bc40039"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40039"
ms.assetid: c5bd5914-ae71-416a-8bed-f76f644f78be
caps.latest.revision: 10
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Name &lt;namespacename&gt; in the root namespace &lt;fullnamespacename&gt; is not CLS-compliant
An assembly is marked as `<CLSCompliant(True)>`, but an element of the root namespace name begins with an underscore (`_`).  
  
 A programming element can contain one or more underscores, but to be compliant with the [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md) (CLS), it must not begin with an underscore. See [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md).  
  
 When you apply the \<xref:System.CLSCompliantAttribute> to a programming element, you set the attribute's `isCompliant` parameter to either `True` or `False` to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply the \<xref:System.CLSCompliantAttribute> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../Topic/Configuring%20Warnings%20in%20Visual%20Basic.md).  
  
 **Error ID:** BC40039  
  
### To correct this error  
  
-   If you require CLS compliance, change the root namespace name so that none of its elements begins with an underscore.  
  
-   If you require that the namespace name remain unchanged, then remove the \<xref:System.CLSCompliantAttribute> from the assembly or mark it as `<CLSCompliant(False)>`.  
  
## See Also  
 [Namespace Statement](../VS_visualbasic/namespace-statement.md)   
 [Namespaces in Visual Basic](../VS_visualbasic/namespaces-in-visual-basic.md)   
 [/rootnamespace](../VS_visualbasic/-rootnamespace.md)   
 [Application Page, Project Designer (Visual Basic)](../Topic/Application%20Page,%20Project%20Designer%20\(Visual%20Basic\).md)   
 [Declared Element Names](../VS_visualbasic/declared-element-names--visual-basic-.md)   
 [Visual Basic Naming Conventions](../VS_visualbasic/visual-basic-naming-conventions.md)   
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)