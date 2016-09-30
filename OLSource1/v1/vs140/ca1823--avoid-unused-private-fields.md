---
title: "CA1823: Avoid unused private fields"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AvoidUnusedPrivateFields"
  - "CA1823"
helpviewer_keywords: 
  - "AvoidUnusedPrivateFields"
  - "CA1823"
ms.assetid: 614f94f6-0dc7-430f-8124-cb889a4a720f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1823: Avoid unused private fields
|||  
|-|-|  
|TypeName|AvoidUnusedPrivateFields|  
|CheckId|CA1823|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 This rule is reported when a private field in your code exists but is not used by any code path.  
  
## Rule Description  
 Private fields were detected that do not appear to be accessed in the assembly.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the field or add code that uses it.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule.  
  
## Related Rules  
 [Avoid uninstantiated internal classes](../vs140/ca1812--avoid-uninstantiated-internal-classes.md)  
  
 [Avoid unused parameters](../vs140/ca1801--review-unused-parameters.md)  
  
 [Remove unused locals](../vs140/ca1804--remove-unused-locals.md)  
  
 [Avoid uncalled private code](../vs140/ca1811--avoid-uncalled-private-code.md)