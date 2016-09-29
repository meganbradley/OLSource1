---
title: "CA1057: String URI overloads call System.Uri overloads"
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
  - "CA1057"
  - "StringUriOverloadsCallSystemUriOverloads"
helpviewer_keywords: 
  - "StringUriOverloadsCallSystemUriOverloads"
  - "CA1057"
ms.assetid: ef1e983e-9ca7-404b-82d7-65740ba0ce20
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1057: String URI overloads call System.Uri overloads
|||  
|-|-|  
|TypeName|StringUriOverloadsCallSystemUriOverloads|  
|CheckId|CA1057|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type declares method overloads that differ only by the replacement of a string parameter with a <xref:System.Uri*?displayProperty=fullName> parameter, and the overload that takes the string parameter does not call the overload that takes the <xref:System.Uri*> parameter.  
  
## Rule Description  
 Because the overloads differ only by the string/<xref:System.Uri*> parameter, the string is assumed to represent a uniform resource identifier (URI). A string representation of a URI is prone to parsing and encoding errors, and can lead to security vulnerabilities. The <xref:System.Uri*> class provides these services in a safe and secure manner. To reap the benefits of the <xref:System.Uri*> class, the string overload should call the <xref:System.Uri*> overload using the string argument.  
  
## How to Fix Violations  
 Re-implement the method that uses the string representation of the URI so that it creates an instance of the <xref:System.Uri*> class using the string argument, and then passes the <xref:System.Uri*> object to the overload that has the <xref:System.Uri*> parameter.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the string parameter does not represent a URI.  
  
## Example  
 The following example shows a correctly implemented string overload.  
  
 [!code[FxCop.Design.CallUriOverload#1](../VS_csharp/codesnippet/CSharp/ca1057--string-uri-overloads-call-system.uri-overloads_1.cs)]
[!code[FxCop.Design.CallUriOverload#1](../VS_csharp/codesnippet/CPP/ca1057--string-uri-overloads-call-system.uri-overloads_1.cpp)]
[!code[FxCop.Design.CallUriOverload#1](../VS_csharp/codesnippet/VisualBasic/ca1057--string-uri-overloads-call-system.uri-overloads_1.vb)]  
  
## Related Rules  
 [Pass system uri objects instead of strings](../VS_csharp/ca2234--pass-system.uri-objects-instead-of-strings.md)  
  
 [Uri properties should not be strings](../VS_csharp/ca1056--uri-properties-should-not-be-strings.md)  
  
 [Uri parameters should not be strings](../VS_csharp/ca1054--uri-parameters-should-not-be-strings.md)  
  
 [Uri return values should not be strings](../VS_csharp/ca1055--uri-return-values-should-not-be-strings.md)