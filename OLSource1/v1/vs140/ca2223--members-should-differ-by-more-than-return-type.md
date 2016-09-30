---
title: "CA2223: Members should differ by more than return type"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MembersShouldDifferByMoreThanReturnType"
  - "CA2223"
helpviewer_keywords: 
  - "CA2223"
  - "MembersShouldDifferByMoreThanReturnType"
ms.assetid: eb326d9f-50d9-48cb-84be-d41c84a8fe09
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2223: Members should differ by more than return type
|||  
|-|-|  
|TypeName|MembersShouldDifferByMoreThanReturnType|  
|CheckId|CA2223|  
|Category|Microsoft.Usage|  
|Breaking Change|Breaking|  
  
## Cause  
 Two public or protected members have signatures that are identical except for return type.  
  
## Rule Description  
 Although the common language runtime permits the use of return types to differentiate between otherwise identical members, this feature is not in the Common Language Specification, nor is it a common feature of .NET programming languages. When members differ only by return type, developers and development tools might not correctly distinguish between them.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design of the members so that they are unique based only on their names and parameter types, or do not expose the members.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example, in Microsoft intermediate language (MSIL), shows a type that violates this rule. Notice that this rule cannot be violated by using C# or Visual Basic .NET.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>