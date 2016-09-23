---
title: "CA2213: Disposable fields should be disposed"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - DisposableFieldsShouldBeDisposed
  - CA2213
helpviewer_keywords: 
  - CA2213
  - DisposableFieldsShouldBeDisposed
ms.assetid: e99442c9-70e2-47f3-b61a-d8ac003bc6e5
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA2213: Disposable fields should be disposed
|||  
|-|-|  
|TypeName|DisposableFieldsShouldBeDisposed|  
|CheckId|CA2213|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements <xref:System.IDisposable?qualifyHint=True> declares fields that are of types that also implement <xref:System.IDisposable?qualifyHint=False>. The <xref:System.IDisposable.Dispose?qualifyHint=False> method of the field is not called by the <xref:System.IDisposable.Dispose?qualifyHint=False> method of the declaring type.  
  
## Rule Description  
 A type is responsible for disposing of all its unmanaged resources; this is accomplished by implementing <xref:System.IDisposable?qualifyHint=False>. This rule checks to see whether a disposable type `T` declares a field `F` that is an instance of a disposable type `FT`. For each field `F`, the rule attempts to locate a call to `FT.Dispose`. The rule searches the methods called by `T.Dispose`, and one level lower (the methods called by the methods called by `FT.Dispose`).  
  
## How to Fix Violations  
 To fix a violation of this rule, call <xref:System.IDisposable.Dispose?qualifyHint=False> on fields that are of types that implement <xref:System.IDisposable?qualifyHint=False> if you are responsible for allocating and releasing the unmanaged resources held by the field.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if you are not responsible for releasing the resource held by the field, or if the call to <xref:System.IDisposable.Dispose?qualifyHint=False> occurs at a deeper calling level than the rule checks.  
  
## Example  
 The following example shows a type `TypeA` that implements <xref:System.IDisposable?qualifyHint=False> (`FT` in the previosu discussion).  
  
 [!code[FxCop.Usage.IDisposablePattern#1](../vs140/codesnippet/CSharp/ca2213--disposable-fields-should-be-disposed_1.cs)]
  
  
## Example  
 The following example shows a type `TypeB` that violates this rule by declaring a field `aFieldOfADisposableType` (`F` in the previous discussion) as a disposable type (`TypeA`) and not calling <xref:System.IDisposable.Dispose?qualifyHint=False> on the field. `TypeB` corresponds to `T` in the previous discussion.  
  
 [!code[FxCop.Usage.IDisposableFields#1](../vs140/codesnippet/CSharp/ca2213--disposable-fields-should-be-disposed_2.cs)]
  
  
## See Also  
 <xref:System.IDisposable?qualifyHint=True>   
 [Implementing Finalize and Dispose](assetId:///31a6c13b-d6a2-492b-9a9f-e5238c983bcb)