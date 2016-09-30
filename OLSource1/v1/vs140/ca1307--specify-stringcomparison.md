---
title: "CA1307: Specify StringComparison"
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
  - "CA1307"
  - "SpecifyStringComparison"
helpviewer_keywords: 
  - "CA1307"
  - "SpecifyStringComparison"
ms.assetid: 9b0d5e71-1683-4a0d-bc4a-68b2fbd8af71
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1307: Specify StringComparison
|||  
|-|-|  
|TypeName|SpecifyStringComparison|  
|CheckId|CA1307|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A string comparison operation uses a method overload that does not set a \<xref:System.StringComparison*> parameter.  
  
## Rule Description  
 Many string operations, most important the \<xref:System.String.Compare*> and \<xref:System.String.Equals*> methods, provide an overload that accepts a \<xref:System.StringComparison*> enumeration value as a parameter.  
  
 Whenever an overload exists that takes a \<xref:System.StringComparison*> parameter, it should be used instead of an overload that does not take this parameter. By explicitly setting this parameter, your code is often made clearer and easier to maintain.  
  
## How to Fix Violations  
 To fix a violation of this rule, change string comparison methods to overloads that accept the \<xref:System.StringComparison*> enumeration as a parameter. For example: change `String.Compare(str1, str2)` to `String.Compare(str1, str2, StringComparison.Ordinal)`.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule when the library or application is intended for a limited local audience and will therefore not be localized.  
  
## See Also  
 [Globalization Warnings](../vs140/globalization-warnings.md)   
 [Use ordinal string comparison](../vs140/ca1309--use-ordinal-stringcomparison.md)