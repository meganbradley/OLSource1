---
title: "CA1049: Types that own native resources should be disposable"
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
  - "CA1049"
  - "TypesThatOwnNativeResourcesShouldBeDisposable"
helpviewer_keywords: 
  - "TypesThatOwnNativeResourcesShouldBeDisposable"
  - "CA1049"
ms.assetid: 084e587d-0e45-4092-b767-49eed30d6a35
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1049: Types that own native resources should be disposable
|||  
|-|-|  
|TypeName|TypesThatOwnNativeResourcesShouldBeDisposable|  
|CheckId|CA1049|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type references a <xref:System.IntPtr*?displayProperty=fullName> field, a <xref:System.UIntPtr*?displayProperty=fullName> field, or a <xref:System.Runtime.InteropServices.HandleRef*?displayProperty=fullName> field, but does not implement <xref:System.IDisposable*?displayProperty=fullName>.  
  
## Rule Description  
 This rule assumes that <xref:System.IntPtr*>, <xref:System.UIntPtr*>, and <xref:System.Runtime.InteropServices.HandleRef*> fields store pointers to unmanaged resources. Types that allocate unmanaged resources should implement <xref:System.IDisposable*> to let callers to release those resources on demand and shorten the lifetimes of the objects that hold the resources.  
  
 The recommended design pattern to clean up unmanaged resources is to provide both an implicit and an explicit means to free those resources by using the <xref:System.Object.Finalize*?displayProperty=fullName> method and the <xref:System.IDisposable.Dispose*?displayProperty=fullName> method, respectively. The garbage collector calls the <xref:System.Object.Finalize*> method of an object at some indeterminate time after the object is determined to be no longer reachable. After <xref:System.Object.Finalize*> is called, an additional garbage collection is required to free the object. The <xref:System.IDisposable.Dispose*> method allows the caller to explicitly release resources on demand, earlier than the resources would be released if left to the garbage collector. After it cleans up the unmanaged resources, <xref:System.IDisposable.Dispose*> should call the [GC.SuppressFinalize](assetId:///M:System.GC.SuppressFinalize(System.Object)?qualifyHint=True&autoUpgrade=True) method to let the garbage collector know that <xref:System.Object.Finalize*> no longer has to be called; this eliminates the need for the additional garbage collection and shortens the lifetime of the object.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement <xref:System.IDisposable*>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the type does not reference an unmanaged resource. Otherwise, do not suppress a warning from this rule because failure to implement <xref:System.IDisposable*> can cause unmanaged resources to become unavailable or underused.  
  
## Example  
 The following example shows a type that implements <xref:System.IDisposable*> to clean up an unmanaged resource.  
  
 [!code[FxCop.Design.UnmanagedResources#1](../vs140/codesnippet/CSharp/ca1049--types-that-own-native-resources-should-be-disposable_1.cs)]
[!code[FxCop.Design.UnmanagedResources#1](../vs140/codesnippet/VisualBasic/ca1049--types-that-own-native-resources-should-be-disposable_1.vb)]  
  
## Related Rules  
 [Call GC.KeepAlive when using native resources](../vs140/ca2115--call-gc.keepalive-when-using-native-resources.md)  
  
 [Dispose methods should call SuppressFinalize](../vs140/ca1816--call-gc.suppressfinalize-correctly.md)  
  
 [Disposable types should declare finalizer](../vs140/ca2216--disposable-types-should-declare-finalizer.md)  
  
 [Types that own disposable fields should be disposable](../vs140/ca1001--types-that-own-disposable-fields-should-be-disposable.md)  
  
## See Also  
 [Cleaning Up Unmanaged Resources](assetId:///a17b0066-71c2-4ba4-9822-8e19332fc213)   
 [Implementing Finalize and Dispose to Clean Up Unmanaged Resources](assetId:///31a6c13b-d6a2-492b-9a9f-e5238c983bcb)