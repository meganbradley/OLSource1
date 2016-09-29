---
title: "Casing of namespace name &#39;&lt;namespacename1&gt;&#39; does not match casing of namespace name &#39;&lt;namespacename2&gt;&#39; in file &#39;&lt;filepath&gt;&#39;"
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
  - "vbc40055"
  - "bc40055"
helpviewer_keywords: 
  - "BC40055"
ms.assetid: adaac2fe-1513-4234-afe7-633a76089f36
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Casing of namespace name &#39;&lt;namespacename1&gt;&#39; does not match casing of namespace name &#39;&lt;namespacename2&gt;&#39; in file &#39;&lt;filepath&gt;&#39;
A namespace appears more than once in the project, but with different casings.  
  
 *Casing* refers to the use of upper-case and lower-case characters in the name of a programming element. Visual Basic is case-insensitive, but the common language runtime (CLR) is case-sensitive. For more information, see "Case Sensitivity in Names" in [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40055  
  
### To correct this error  
  
-   As a precaution, always use the identical casing in every reference to a namespace. This can prevent misinterpretation by the common language runtime.  
  
## See Also  
 [Namespace Statement](../vs140/namespace-statement.md)   
 [Namespaces in Visual Basic](../vs140/namespaces-in-visual-basic.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Visual Basic Naming Conventions](../vs140/visual-basic-naming-conventions.md)