---
title: "CA1054: URI parameters should not be strings"
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
  - "CA1054"
  - "UriParametersShouldNotBeStrings"
helpviewer_keywords: 
  - "CA1054"
  - "UriParametersShouldNotBeStrings"
ms.assetid: 8e99d72b-a658-47a7-8dd5-9784ce2c30b8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1054: URI parameters should not be strings
|||  
|-|-|  
|TypeName|UriParametersShouldNotBeStrings|  
|CheckId|CA1054|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A type declares a method with a string parameter whose name contains "uri", "Uri", "urn", "Urn", "url", or "Url" and the type does not declare a corresponding overload that takes a \<xref:System.Uri*?displayProperty=fullName> parameter.  
  
## Rule Description  
 This rule splits the parameter name into tokens based on the camel casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the parameter represents a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. If a method takes a string representation of a URI, a corresponding overload should be provided that takes an instance of the \<xref:System.Uri*> class, which provides these services in a safe and secure manner.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the parameter to a \<xref:System.Uri*> type; this is a breaking change. Alternately, provide an overload of the method which takes a \<xref:System.Uri*> parameter; this is a nonbreaking change.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the parameter does not represent a URI.  
  
## Example  
 The following example shows a type, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, that violates this rule, and a type, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, that satisfies the rule.  
  
 [!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/CSharp/ca1054--uri-parameters-should-not-be-strings_1.cs)]
[!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/VisualBasic/ca1054--uri-parameters-should-not-be-strings_1.vb)]
[!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/CPP/ca1054--uri-parameters-should-not-be-strings_1.cpp)]  
  
## Related Rules  
 [Uri properties should not be strings](../vs140/ca1056--uri-properties-should-not-be-strings.md)  
  
 [Uri return values should not be strings](../vs140/ca1055--uri-return-values-should-not-be-strings.md)  
  
 [Pass system uri objects instead of strings](../vs140/ca2234--pass-system.uri-objects-instead-of-strings.md)  
  
 [String uri overloads call system uri overloads](../vs140/ca1057--string-uri-overloads-call-system.uri-overloads.md)