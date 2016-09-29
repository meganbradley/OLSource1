---
title: "Observable.scan&lt;&#39;U,&#39;T&gt; Function (F#)"
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
  - "Observable.scan<'U,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule.Scan``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "scan function [F#]"
  - "Observable.scan function [F#]"
ms.assetid: a51f3116-1588-442a-b200-9e370155b9ff
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Observable.scan&lt;&#39;U,&#39;T&gt; Function (F#)
Returns an observable which, for each observer, allocates an item of state and applies the given accumulating function to successive values arising from the input. The returned object will trigger observations for each computed state value, excluding the initial value. The returned object propagates all errors arising from the source and completes when the source completes.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.Observable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Observable.scan : ('U -> 'T -> 'U) -> 'U -> IObservable<'T> -> IObservable<'U>  
  
// Usage:  
Observable.scan collector state source  
```  
  
#### Parameters  
 `collector`  
 Type: `'U -> 'T -> 'U`  
  
 The function to update the state with each observation.  
  
 `state`  
 Type: `'U`  
  
 The initial state.  
  
 `source`  
 Type: [IObservable](../vs140/system.iobservable--t--interface--fsharp-.md)`<'T>`  
  
 The input Observable.  
  
## Return Value  
 An observable that triggers on the updated state values.  
  
## Remarks  
 For each observer, the registered intermediate observing object is not thread safe. That is, observations arising from the source must not be triggered concurrently on different threads.  
  
 This function is named `Scan` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Observable Module (F#)](../vs140/control.observable-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)