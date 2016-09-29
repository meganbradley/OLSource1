---
title: "Observable.pairwise&lt;&#39;T&gt; Function (F#)"
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
  - "Observable.pairwise<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule.Pairwise``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "pairwise function [F#]"
  - "Observable.pairwise function [F#]"
ms.assetid: 62641615-858c-41f3-8bd3-bc5e71eec783
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Observable.pairwise&lt;&#39;T&gt; Function (F#)
Returns a new observable that triggers on the second and subsequent triggerings of the input observable. The Nth triggering of the input observable passes the arguments from the N-1th and Nth triggering as a pair. The argument passed to the N-1th triggering is held in hidden internal state until the Nth triggering occurs.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.Observable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Observable.pairwise : IObservable<'T> -> IObservable<'T * 'T>  
  
// Usage:  
Observable.pairwise source  
```  
  
#### Parameters  
 `source`  
 Type: [IObservable](../VS_csharp/system.iobservable--t--interface--fsharp-.md)`<'T>`  
  
 The input observable.  
  
## Return Value  
 An observable that triggers on successive pairs of observations from the input observable.  
  
## Remarks  
 For each observer, the registered intermediate observing object is not thread safe. That is, observations arising from the source must not be triggered concurrently on different threads.  
  
 This function is named `Pairwise` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Observable Module (F#)](../VS_csharp/control.observable-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)