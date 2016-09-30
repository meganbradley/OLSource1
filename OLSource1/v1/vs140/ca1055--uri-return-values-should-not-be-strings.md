---
title: "CA1055: URI return values should not be strings"
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
  - "CA1055"
  - "UriReturnValuesShouldNotBeStrings"
helpviewer_keywords: 
  - "UriReturnValuesShouldNotBeStrings"
  - "CA1055"
ms.assetid: 40e39873-7872-4988-8195-9eb0ade9ece0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1055: URI return values should not be strings
|||  
|-|-|  
|TypeName|UriReturnValuesShouldNotBeStrings|  
|CheckId|CA1055|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 The name of a method contains "uri", "Uri", "urn", "Urn", "url", or "Url", and the method returns a string.  
  
## Rule Description  
 This rule splits the method name into tokens based on the Pascal casing convention and checks whether each token equals "uri", "Uri", "urn", "Urn", "url", or "Url". If there is a match, the rule assumes that the method returns a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The \<xref:System.Uri*?displayProperty=fullName> class provides these services in a safe and secure manner.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the return type to a \<xref:System.Uri*>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the return value does not represent a URI.  
  
## Example  
 The following example shows a type, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, that violates this rule, and a type, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, that satisfies the rule.  
  
 [!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/CSharp/ca1055--uri-return-values-should-not-be-strings_1.cs)]
[!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/VisualBasic/ca1055--uri-return-values-should-not-be-strings_1.vb)]
[!code[FxCop.Design.UriNotString#1](../vs140/codesnippet/CPP/ca1055--uri-return-values-should-not-be-strings_1.cpp)]  
  
## Related Rules  
 [Uri properties should not be strings](../vs140/ca1056--uri-properties-should-not-be-strings.md)  
  
 [Uri parameters should not be strings](../vs140/ca1054--uri-parameters-should-not-be-strings.md)  
  
 [Pass system uri objects instead of strings](../vs140/ca2234--pass-system.uri-objects-instead-of-strings.md)  
  
 [String uri overloads call system uri overloads](../vs140/ca1057--string-uri-overloads-call-system.uri-overloads.md)