---
title: "CA2138: Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CA2138"
ms.assetid: a14c4d32-f079-4f3a-956c-a1657cde0f66
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2138: Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute
|||  
|-|-|  
|TypeName|TransparentMethodsMustNotCallSuppressUnmanagedCodeSecurityMethods|  
|CheckId|CA2138|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A security transparent method calls a method that is marked with the \<xref:System.Security.SuppressUnmanagedCodeSecurityAttribute*> attribute.  
  
## Rule Description  
 This rule fires on any transparent method that calls directly into native code, for example, by using a via a P/Invoke (platform invoke) call. P/Invoke and COM interop methods that are marked with the \<xref:System.Security.SuppressUnmanagedCodeSecurityAttribute*> attribute result in a LinkDemand being done against the calling method. Because security transparent code cannot satisfy LinkDemands, the code also cannot call methods that are marked with the SuppressUnmanagedCodeSecurity attribute, or methods of class that is marked with SuppressUnmanagedCodeSecurity attribute. The method will fail, or the demand will be converted to a full demand.  
  
 Violations of this rule lead to a \<xref:System.MethodAccessException*> in the Level 2 security transparency model, and a full demand for \<xref:System.Security.Permissions.SecurityPermissionAttribute.UnmanagedCode*> in the Level 1 transparency model.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the \<xref:System.Security.SuppressUnmanagedCodeSecurityAttribute*> attribute and mark the method with the \<xref:System.Security.SecurityCriticalAttribute*> or the \<xref:System.Security.SecuritySafeCriticalAttribute*> attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 [!code[FxCop.Security.CA2138.TransparentMethodsMustNotCallSuppressUnmanagedCodeSecurityMethods#1](../vs140/codesnippet/CSharp/ca2138--transparent-methods-must-not-call-methods-with-the-suppressunmanagedcodesecurity-attribute_1.cs)]