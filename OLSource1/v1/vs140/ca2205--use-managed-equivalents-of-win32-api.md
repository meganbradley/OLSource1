---
title: "CA2205: Use managed equivalents of Win32 API"
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
  - "UseManagedEquivalentsOfWin32Api"
  - "CA2205"
helpviewer_keywords: 
  - "UseManagedEquivalentsOfWin32Api"
  - "CA2205"
ms.assetid: 1c65ab59-3e50-4488-a727-3969c7f6cbe4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2205: Use managed equivalents of Win32 API
|||  
|-|-|  
|TypeName|UseManagedEquivalentsOfWin32Api|  
|CheckId|CA2205|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A platform invoke method is defined and a method with the equivalent functionality exists in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] class library.  
  
## Rule Description  
 A platform invoke method is used to call an unmanaged DLL function and is defined using the <xref:System.Runtime.InteropServices.DllImportAttribute*?displayProperty=fullName> attribute, or the `Declare` keyword in Visual Basic. An incorrectly defined platform invoke method can lead to runtime exceptions because of issues such as a misnamed function, faulty mapping of parameter and return value data types, and incorrect field specifications, such as the calling convention and character set. If available, it is generally simpler and less error prone to call the equivalent managed method than to define and call the unmanaged method directly. Calling a platform invoke method can also lead to additional security issues that need to be addressed.  
  
## How to Fix Violations  
 To fix a violation of this rule, replace the call to the unmanaged function with a call to its managed equivalent.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if the suggested replacement method does not provide the needed functionality.  
  
## Example  
 The following example shows a platform invoke method definition that violates the rule. In addition, the calls to the platform invoke method and the equivalent managed method are shown.  
  
 [!code[FxCop.Usage.ManagedEquivalents#1](../vs140/codesnippet/CSharp/ca2205--use-managed-equivalents-of-win32-api_1.cs)]
[!code[FxCop.Usage.ManagedEquivalents#1](../vs140/codesnippet/VisualBasic/ca2205--use-managed-equivalents-of-win32-api_1.vb)]  
  
## Related Rules  
 [Call GetLastError immediately after pinvoke](../vs140/ca1404--call-getlasterror-immediately-after-p-invoke.md)  
  
 [Move pinvokes to native methods class](../vs140/ca1060--move-p-invokes-to-nativemethods-class.md)  
  
 [PInvoke entry points should exist](../vs140/ca1400--p-invoke-entry-points-should-exist.md)  
  
 [PInvokes should not be visible](../vs140/ca1401--p-invokes-should-not-be-visible.md)  
  
 [Specify marshaling for pinvoke string arguments](../vs140/ca2101--specify-marshaling-for-p-invoke-string-arguments.md)