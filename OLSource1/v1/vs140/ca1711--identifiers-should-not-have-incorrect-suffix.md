---
title: "CA1711: Identifiers should not have incorrect suffix"
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
  - "CA1711"
  - "IdentifiersShouldNotHaveIncorrectSuffix"
helpviewer_keywords: 
  - "CA1711"
  - "IdentifiersShouldNotHaveIncorrectSuffix"
ms.assetid: a63359ab-386d-44ae-b381-ee3a983aca29
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1711: Identifiers should not have incorrect suffix
|||  
|-|-|  
|TypeName|IdentifiersShouldNotHaveIncorrectSuffix|  
|CheckId|CA1711|  
|Category|Microsoft.Naming|  
|Breaking Change|Breaking|  
  
## Cause  
 An identifier has an incorrect suffix.  
  
## Rule Description  
 By convention, only the names of types that extend certain base types or that implement certain interfaces, or types derived from these types, should end with specific reserved suffixes. Other type names should not use these reserved suffixes.  
  
 The following table lists the reserved suffixes and the base types and interfaces with which they are associated.  
  
|Suffix|Base type/Interface|  
|------------|--------------------------|  
|Attribute|\<xref:System.Attribute*?displayProperty=fullName>|  
|Collection|\<xref:System.Collections.ICollection*?displayProperty=fullName>\<br />\<br /> \<xref:System.Collections.IEnumerable*?displayProperty=fullName>\<br />\<br /> \<xref:System.Collections.Queue*?displayProperty=fullName>\<br />\<br /> \<xref:System.Collections.Stack*?displayProperty=fullName>\<br />\<br /> <xref:System.Collections.Generic.ICollection<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>2*?displayProperty=fullName>|  
|EventArgs|\<xref:System.EventArgs*?displayProperty=fullName>|  
|EventHandler|An event-handler delegate|  
|Exception|\<xref:System.Exception*?displayProperty=fullName>|  
|Permission|\<xref:System.Security.IPermission*?displayProperty=fullName>|  
|Queue|\<xref:System.Collections.Queue*?displayProperty=fullName>|  
|Stack|\<xref:System.Collections.Stack*?displayProperty=fullName>|  
|Stream|\<xref:System.IO.Stream*?displayProperty=fullName>|  
  
 In addition, the following suffixes should **not** be used:  
  
-   Delegate  
  
-   Enum  
  
-   Impl - use 'Core' instead  
  
-   Ex or similar suffix to distinguish it from an earlier version of the same type  
  
 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.  
  
## How to Fix Violations  
 Remove the suffix from the type name.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule unless the suffix has an unambiguous meaning in the application domain.  
  
## Related Rules  
 [Identifiers should have correct suffix](../vs140/ca1710--identifiers-should-have-correct-suffix.md)  
  
## See Also  
 [Attribute Usage Guidelines](assetId:///ee0038ef-b247-4747-a650-3c5c5cd58d8b)   
 [NIB: Events and Delegates](assetId:///d98fd58b-fa4f-4598-8378-addf4355a115)