---
title: "CA1816: Call GC.SuppressFinalize correctly"
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
  - "CA1816"
  - "DisposeMethodsShouldCallSuppressFinalize"
helpviewer_keywords: 
  - "DisposeMethodsShouldCallSuppressFinalize"
  - "CA1816"
ms.assetid: 47915fbb-103f-4333-b157-1da16bf49660
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1816: Call GC.SuppressFinalize correctly
|||  
|-|-|  
|TypeName|CallGCSuppressFinalizeCorrectly|  
|CheckId|CA1816|  
|Category|Microsoft. Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
  
-   A method that is an implementation of <xref:System.IDisposable.Dispose*?displayProperty=fullName> does not call [GC.SuppressFinalize](assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True).  
  
-   A method that is not an implementation of <xref:System.IDisposable.Dispose*?displayProperty=fullName> calls assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True.  
  
-   A method calls assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True and passes something other than this (Me in Visual Basic).  
  
## Rule Description  
 The <xref:System.IDisposable.Dispose*?displayProperty=fullName> method lets users release resources at any time before the object becoming available for garbage collection. If the <xref:System.IDisposable.Dispose*?displayProperty=fullName> method is called, it frees resources of the object. This makes finalization unnecessary. <xref:System.IDisposable.Dispose*?displayProperty=fullName> should call assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True so the garbage collector does not call the finalizer of the object.  
  
 To prevent derived types with finalizers from having to re-implement [System.IDisposable](assetId:///System.IDisposable?qualifyHint=True&autoUpgrade=False) and to call it, unsealed types without finalizers should still call assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True.  
  
## How to Fix Violations  
 To fix a violation of this rule:  
  
 If the method is an implementation of <xref:System.IDisposable.Dispose*>, add a call to assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True.  
  
 If the method is not an implementation of <xref:System.IDisposable.Dispose*>, either remove the call to assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True or move it to the type's <xref:System.IDisposable.Dispose*> implementation.  
  
 Change all calls to assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True to pass this (Me in Visual Basic).  
  
## When to Suppress Warnings  
 Only suppress a warning from this rule if you are deliberating using assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True to control the lifetime of other objects. Do not suppress a warning from this rule if an implementation of <xref:System.IDisposable.Dispose*> does not call assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True. In this situation, failing to suppress finalization degrades performance and provide no benefits.  
  
## Example  
 The following example shows a method that incorrectly calls assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True.  
  
 [!code[FxCop.Usage.CallGCSuppressFinalizeCorrectly#1](../vs140/codesnippet/VisualBasic/ca1816--call-gc.suppressfinalize-correctly_1.vb)][!code[FxCop.Usage.CallGCSuppressFinalizeCorrectly#1](../vs140/codesnippet/CSharp/ca1816--call-gc.suppressfinalize-correctly_1.cs)]  
  
## Example  
 The following example shows a method that correctly calls assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True.  
  
 [!code[FxCop.Usage.CallGCSuppressFinalizeCorrectly2#1](../vs140/codesnippet/VisualBasic/ca1816--call-gc.suppressfinalize-correctly_2.vb)][!code[FxCop.Usage.CallGCSuppressFinalizeCorrectly2#1](../vs140/codesnippet/CSharp/ca1816--call-gc.suppressfinalize-correctly_2.cs)]  
  
## Related Rules  
 [Dispose methods should call base class dispose](../vs140/ca2215--dispose-methods-should-call-base-class-dispose.md)  
  
 [Disposable types should declare finalizer](../vs140/ca2216--disposable-types-should-declare-finalizer.md)  
  
## See Also  
 [Implementing Finalize and Dispose](assetId:///31a6c13b-d6a2-492b-9a9f-e5238c983bcb)