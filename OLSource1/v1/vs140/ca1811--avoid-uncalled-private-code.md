---
title: "CA1811: Avoid uncalled private code"
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
  - "AvoidUncalledPrivateCode"
  - "CA1811"
helpviewer_keywords: 
  - "CA1811"
  - "AvoidUncalledPrivateCode"
ms.assetid: aadbba74-7821-475f-8980-34d17c0a0a8b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1811: Avoid uncalled private code
|||  
|-|-|  
|TypeName|AvoidUncalledPrivateCode|  
|CheckId|CA1811|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A private or internal (assembly-level) member does not have callers in the assembly, is not invoked by the common language runtime, and is not invoked by a delegate. The following members are not checked by this rule:  
  
-   Explicit interface members.  
  
-   Static constructors.  
  
-   Serialization constructors.  
  
-   Methods marked with \<xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute*?displayProperty=fullName> or \<xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute*?displayProperty=fullName>.  
  
-   Members that are overrides.  
  
## Rule Description  
 This rule can report false positives if entry points occur that are not currently identified by the rule logic. Also, a compiler may emit noncallable code into an assembly.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the noncallable code or add code that calls it.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule.  
  
## Related Rules  
 [Avoid uninstantiated internal classes](../vs140/ca1812--avoid-uninstantiated-internal-classes.md)  
  
 [Avoid unused parameters](../vs140/ca1801--review-unused-parameters.md)  
  
 [Remove unused locals](../vs140/ca1804--remove-unused-locals.md)