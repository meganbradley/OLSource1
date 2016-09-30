---
title: "CA1056: URI properties should not be strings"
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
  - "UriPropertiesShouldNotBeStrings"
  - "CA1056"
helpviewer_keywords: 
  - "UriPropertiesShouldNotBeStrings"
  - "CA1056"
ms.assetid: fdc99d29-0904-4a65-baa8-4f76833c953e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1056: URI properties should not be strings
|||  
|-|-|  
|TypeName|UriPropertiesShouldNotBeStrings|  
|CheckId|CA1056|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A type declares a string property whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url".  
  
## Rule Description  
 This rule splits the property name into tokens based on the Pascal casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the property represents a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The \<xref:System.Uri*?displayProperty=fullName> class provides these services in a safe and secure manner.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the property to a \<xref:System.Uri*> type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the property does not represent a URI.  
  
## Example  
 The following example shows a type, `ErrorProne`, that violates this rule, and a type, `SaferWay`, that satisfies the rule.  
  
 [!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/CSharp/ca1056--uri-properties-should-not-be-strings_1.cs)]
[!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/VisualBasic/ca1056--uri-properties-should-not-be-strings_1.vb)]
[!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/CPP/ca1056--uri-properties-should-not-be-strings_1.cpp)]  
  
## Related Rules  
 [Uri parameters should not be strings](../vs140/ca1054--uri-parameters-should-not-be-strings.md)  
  
 [Uri return values should not be strings](../vs140/ca1055--uri-return-values-should-not-be-strings.md)  
  
 [Pass system uri objects instead of strings](../vs140/ca2234--pass-system.uri-objects-instead-of-strings.md)  
  
 [String uri overloads call system uri overloads](../vs140/ca1057--string-uri-overloads-call-system.uri-overloads.md)