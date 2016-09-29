---
title: "IObservable.Subscribe&lt;&#39;T&gt; Extension Method (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "IObservable.Subscribe<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.IObservable`1.Subscribe"
  - "System.CommonExtensions.SubscribeToObservable"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SubscribeToObservable extension method [F#]"
  - "IObservable.Subscribe method [F#]"
  - "CommonExtensions.SubscribeToObservable extension method [F#]"
  - "CommonExtensions.Subscribe extension method [F#]"
  - "Subscribe extension method [F#]"
  - "Subscribe method [F#]"
ms.assetid: 8c8702c2-caa8-4a72-94bb-025f0922e04a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObservable.Subscribe&lt;&#39;T&gt; Extension Method (F#)
Connects a listener function to the observable. The listener will be invoked for each observation. The listener can be removed by calling Dispose on the returned IDisposable object.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.CommonExtensions  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
type System.IObservable with  
  member Subscribe : ('T -> unit) -> IDisposable  
  
// Usage:  
iObservable.Subscribe (callback)  
```  
  
#### Parameters  
 `callback`  
 Type: `'T ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to be called for each observation.  
  
## Return Value  
  
## Remarks  
 This member is named `SubscribeToObservable` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 <xref:System*>   
 [Control.CommonExtensions Module (F#)](../vs140/control.commonextensions-module--fsharp-.md)