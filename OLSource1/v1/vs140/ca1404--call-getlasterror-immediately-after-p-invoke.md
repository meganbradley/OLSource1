---
title: "CA1404: Call GetLastError immediately after P-Invoke"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
H1: CA1404: Call GetLastError immediately after P/Invoke
f1_keywords: 
  - CallGetLastErrorImmediatelyAfterPInvoke
  - CA1404
helpviewer_keywords: 
  - CallGetLastErrorImmediatelyAfterPInvoke
  - CA1404
ms.assetid: 52ae9eff-50f9-4b2f-8039-ca7e49fba88e
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA1404: Call GetLastError immediately after P-Invoke
|||  
|-|-|  
|TypeName|CallGetLastErrorImmediatelyAfterPInvoke|  
|CheckId|CA1404|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A call is made to the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=True> method or the equivalent Win32 `GetLastError` function, and the call that comes immediately before is not to a platform invoke method.  
  
## Rule Description  
 A platform invoke method accesses unmanaged code and is defined by using the `Declare` keyword in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] or the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=True> attribute. Generally, upon failure, unmanaged functions call the Win32 `SetLastError` function to set an error code that is associated with the failure. The caller of the failed function calls the Win32 `GetLastError` function to retrieve the error code and determine the cause of the failure. The error code is maintained on a per-thread basis and is overwritten by the next call to `SetLastError`. After a call to a failed platform invoke method, managed code can retrieve the error code by calling the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> method. Because the error code can be overwritten by internal calls from other managed class library methods, the `GetLastError` or <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> method should be called immediately after the platform invoke method call.  
  
 The rule ignores calls to the following managed members when they occur between the call to the platform invoke method and the call to <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False>. These members do not change the error code and are useful for determining the success of some platform invoke method calls.  
  
-   <xref:System.IntPtr.Zero?qualifyHint=True>  
  
-   <xref:System.IntPtr.op_Equality?qualifyHint=True>  
  
-   <xref:System.IntPtr.op_Inequality?qualifyHint=True>  
  
-   <xref:System.Runtime.InteropServices.SafeHandle.IsInvalid?qualifyHint=True>  
  
## How to Fix Violations  
 To fix a violation of this rule, move the call to <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> so that it immediately follows the call to the platform invoke method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the code between the platform invoke method call and the <xref:System.Runtime.InteropServices.Marshal.GetLastWin32Error?qualifyHint=False> method call cannot explicitly or implicitly cause the error code to change.  
  
## Example  
 The following example shows a method that violates the rule and a method that satisfies the rule.  
  
 [!code[FxCop.Interoperability.LastErrorPInvoke#1](../vs140/codesnippet/VisualBasic/ca1404--call-getlasterror-immediately-after-p-invoke_1.vb)]
[!code[FxCop.Interoperability.LastErrorPInvoke#1](../vs140/codesnippet/CSharp/ca1404--call-getlasterror-immediately-after-p-invoke_1.cs)]
  
  
## Related Rules  
 [Move pinvokes to native methods class](../vs140/ca1060--move-p-invokes-to-nativemethods-class.md)  
  
 [PInvoke entry points should exist](../vs140/ca1400--p-invoke-entry-points-should-exist.md)  
  
 [PInvokes should not be visible](../vs140/ca1401--p-invokes-should-not-be-visible.md)  
  
 [Specify marshaling for pinvoke string arguments](../vs140/ca2101--specify-marshaling-for-p-invoke-string-arguments.md)  
  
 [Use managed equivalents of win32 api](../vs140/ca2205--use-managed-equivalents-of-win32-api.md)