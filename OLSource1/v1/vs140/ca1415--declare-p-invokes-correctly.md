---
title: "CA1415: Declare P-Invokes correctly"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "CA1415: Declare P/Invokes correctly"
f1_keywords: 
  - "CA1415"
  - "DeclarePInvokesCorrectly"
helpviewer_keywords: 
  - "CA1415"
  - "DeclarePInvokesCorrectly"
ms.assetid: 42a90796-0264-4460-bf97-2fb4a093dfdc
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1415: Declare P-Invokes correctly
|||  
|-|-|  
|TypeName|DeclarePInvokesCorrectly|  
|CheckId|CA1415|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking - If the P/Invoke that declares the parameter cannot be seen outside the assembly. Breaking - If the P/Invoke that declares the parameter can be seen outside the assembly.|  
  
## Cause  
 A platform invoke method is incorrectly declared.  
  
## Rule Description  
 A platform invoke method accesses unmanaged code and is defined by using the `Declare` keyword in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] or the <xref:System.Runtime.InteropServices.DllImportAttribute*?displayProperty=fullName>. Currently, this rule looks for platform invoke method declarations that target Win32 functions that have a pointer to an OVERLAPPED structure parameter and the corresponding managed parameter is not a pointer to a <xref:System.Threading.NativeOverlapped*?displayProperty=fullName> structure.  
  
## How to Fix Violations  
 To fix a violation of this rule, correctly declare the platform invoke method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows platform invoke methods that violate the rule and satisfy the rule.  
  
 [!code[FxCop.Interoperability.DeclarePInvokes#1](../vs140/codesnippet/CSharp/ca1415--declare-p-invokes-correctly_1.cs)]  
  
## See Also  
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)