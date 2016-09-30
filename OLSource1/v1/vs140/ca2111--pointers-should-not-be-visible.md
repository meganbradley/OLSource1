---
title: "CA2111: Pointers should not be visible"
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
  - "PointersShouldNotBeVisible"
  - "CA2111"
helpviewer_keywords: 
  - "CA2111"
  - "PointersShouldNotBeVisible"
ms.assetid: b3a8d466-895b-43bc-a2df-5d7058fe915f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2111: Pointers should not be visible
|||  
|-|-|  
|TypeName|PointersShouldNotBeVisible|  
|CheckId|CA2111|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected \<xref:System.IntPtr*?displayProperty=fullName> or \<xref:System.UIntPtr*?displayProperty=fullName> field is not read-only.  
  
## Rule Description  
 \<xref:System.IntPtr*> and \<xref:System.UIntPtr*> are pointer types that are used to access unmanaged memory. If a pointer is not private, internal, or read-only, malicious code can change the value of the pointer, potentially allowing access to arbitrary locations in memory or causing application or system failures.  
  
 If you intend to secure access to the type that contains the pointer field, see [Secured types should not expose fields](../vs140/ca2112--secured-types-should-not-expose-fields.md).  
  
## How to Fix Violations  
 Secure the pointer by making it read-only, internal, or private.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if you do not rely on the value of the pointer.  
  
## Example  
 The following code shows pointers that violate and satisfy the rule. Notice that the non-private pointers also violate the rule [Do not declare visible instance fields](../vs140/ca1051--do-not-declare-visible-instance-fields.md).  
  
 [!code[FxCop.Security.PointersArePrivate#1](../vs140/codesnippet/CSharp/ca2111--pointers-should-not-be-visible_1.cs)]  
  
## Related Rules  
 [Secured types should not expose fields](../vs140/ca2112--secured-types-should-not-expose-fields.md)  
  
 [Do not declare visible instance fields](../vs140/ca1051--do-not-declare-visible-instance-fields.md)  
  
## See Also  
 \<xref:System.IntPtr*?displayProperty=fullName>   
 \<xref:System.UIntPtr*?displayProperty=fullName>