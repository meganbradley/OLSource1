---
title: "CA1719: Parameter names should not match member names"
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
  - "ParameterNamesShouldNotMatchMemberNames"
  - "CA1719"
helpviewer_keywords: 
  - "CA1719"
  - "ParameterNamesShouldNotMatchMemberNames"
ms.assetid: c6fea690-1659-4ee7-a1c5-125ad6754525
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1719: Parameter names should not match member names
|||  
|-|-|  
|TypeName|ParameterNamesShouldNotMatchMemberNames|  
|CheckId|CA1719|  
|Category|Microsoft.Naming|  
|Breaking Change|Breaking|  
  
## Cause  
 The name of an externally visible member matches, in a case-insensitive comparison, the name of one of its parameters.  
  
## Rule Description  
 A parameter name should communicate the meaning of a parameter and a member name should communicate the meaning of a member. It would be a rare design where these were the same. Naming a parameter the same as its member name is unintuitive and makes the library difficult to use.  
  
## How to Fix Violations  
 Select a parameter name that does not match the member name.  
  
## When to Suppress Warnings  
 For new development, no known scenarios occur where you must suppress a warning from this rule. For shipping libraries, you might have to suppress a warning from this rule.  
  
## Related Rules  
 [Identifiers should be cased correctly](../VS_csharp/ca1709--identifiers-should-be-cased-correctly.md)  
  
 [Identifiers should differ by more than case](../VS_csharp/ca1708--identifiers-should-differ-by-more-than-case.md)  
  
 [Identifiers should not contain underscores](../VS_csharp/ca1707--identifiers-should-not-contain-underscores.md)