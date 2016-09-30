---
title: "Name &lt;namespacename&gt; in the root namespace &lt;fullnamespacename&gt; is not CLS-compliant"
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
  - "vbc40039"
  - "bc40039"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40039"
ms.assetid: c5bd5914-ae71-416a-8bed-f76f644f78be
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Name &lt;namespacename&gt; in the root namespace &lt;fullnamespacename&gt; is not CLS-compliant
An assembly is marked as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, but an element of the root namespace name begins with an underscore (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>).  
  
 A programming element can contain one or more underscores, but to be compliant with the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), it must not begin with an underscore. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
 When you apply the \<xref:System.CLSCompliantAttribute*> to a programming element, you set the attribute's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter to either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply the \<xref:System.CLSCompliantAttribute*> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40039  
  
### To correct this error  
  
-   If you require CLS compliance, change the root namespace name so that none of its elements begins with an underscore.  
  
-   If you require that the namespace name remain unchanged, then remove the \<xref:System.CLSCompliantAttribute*> from the assembly or mark it as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## See Also  
 [Namespace Statement](../vs140/namespace-statement.md)   
 [Namespaces in Visual Basic](../vs140/namespaces-in-visual-basic.md)   
 [/rootnamespace](../vs140/-rootnamespace.md)   
 [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Visual Basic Naming Conventions](../vs140/visual-basic-naming-conventions.md)   
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)