---
title: "CA2213: Disposable fields should be disposed"
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
  - "DisposableFieldsShouldBeDisposed"
  - "CA2213"
helpviewer_keywords: 
  - "CA2213"
  - "DisposableFieldsShouldBeDisposed"
ms.assetid: e99442c9-70e2-47f3-b61a-d8ac003bc6e5
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2213: Disposable fields should be disposed
|||  
|-|-|  
|TypeName|DisposableFieldsShouldBeDisposed|  
|CheckId|CA2213|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type that implements \<xref:System.IDisposable*?displayProperty=fullName> declares fields that are of types that also implement \<xref:System.IDisposable*>. The \<xref:System.IDisposable.Dispose*> method of the field is not called by the \<xref:System.IDisposable.Dispose*> method of the declaring type.  
  
## Rule Description  
 A type is responsible for disposing of all its unmanaged resources; this is accomplished by implementing \<xref:System.IDisposable*>. This rule checks to see whether a disposable type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> declares a field <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that is an instance of a disposable type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For each field <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the rule attempts to locate a call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The rule searches the methods called by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and one level lower (the methods called by the methods called by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## How to Fix Violations  
 To fix a violation of this rule, call \<xref:System.IDisposable.Dispose*> on fields that are of types that implement \<xref:System.IDisposable*> if you are responsible for allocating and releasing the unmanaged resources held by the field.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if you are not responsible for releasing the resource held by the field, or if the call to \<xref:System.IDisposable.Dispose*> occurs at a deeper calling level than the rule checks.  
  
## Example  
 The following example shows a type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that implements \<xref:System.IDisposable*> (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the previosu discussion).  
  
 [!code[FxCop.Usage.IDisposablePattern#1](../vs140/codesnippet/CSharp/ca2213--disposable-fields-should-be-disposed_1.cs)]  
  
## Example  
 The following example shows a type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that violates this rule by declaring a field <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the previous discussion) as a disposable type (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) and not calling \<xref:System.IDisposable.Dispose*> on the field. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> corresponds to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the previous discussion.  
  
 [!code[FxCop.Usage.IDisposableFields#1](../vs140/codesnippet/CSharp/ca2213--disposable-fields-should-be-disposed_2.cs)]  
  
## See Also  
 \<xref:System.IDisposable*?displayProperty=fullName>   
 [Implementing Finalize and Dispose](assetId:///31a6c13b-d6a2-492b-9a9f-e5238c983bcb)