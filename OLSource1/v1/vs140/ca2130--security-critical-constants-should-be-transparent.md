---
title: "CA2130: Security critical constants should be transparent"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CA2130
ms.assetid: 344c7f7b-9130-4675-ae7f-9fa260cc9789
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA2130: Security critical constants should be transparent
|||  
|-|-|  
|TypeName|ConstantsShouldBeTransparent|  
|CheckId|CA2130|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A constant field or an enumeration member is marked with the <xref:System.Security.SecurityCriticalAttribute?qualifyHint=False>.  
  
## Rule Description  
 Transparency enforcement is not enforced for constant values because compilers inline constant values so that no lookup is required at run time. Constant fields should be security transparent so that code reviewers do not assume that transparent code cannot access the constant.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the SecurityCritical attribute from the field or value.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 In the following examples, the enum value `EnumWithCriticalValues.CriticalEnumValue` and the constant `CriticalConstant` raise this warning. To fix the issues, remove the [`SecurityCritical`] attribute to make them security transparent.  
  
 [!code[FxCop.Security.CA2130.ConstantsShouldBeTransparent#1](../vs140/codesnippet/CSharp/ca2130--security-critical-constants-should-be-transparent_1.cs)]
