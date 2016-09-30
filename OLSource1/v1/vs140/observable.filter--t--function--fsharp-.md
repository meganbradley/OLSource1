---
title: "Observable.filter&lt;&#39;T&gt; Function (F#)"
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
  - "Observable.filter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule.Filter``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "filter function [F#]"
  - "Observable.filter function [F#]"
ms.assetid: c7957b74-9d92-4a5d-9f0a-43b51179e6c8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Observable.filter&lt;&#39;T&gt; Function (F#)
Returns an observable which filters the observations of the source by the given function. The observable will see only those observations for which the predicate returns true. The predicate is executed once for each subscribed observer. The returned object also propagates error observations arising from the source and completes when the source completes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.Observable  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Observable.filter : ('T -> bool) -> IObservable<'T> -> IObservable<'T>  
  
// Usage:  
Observable.filter predicate source  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to apply to observations to determine if it should be kept.  
  
 `source`  
 Type: [IObservable](../vs140/system.iobservable--t--interface--fsharp-.md)`<'T>`  
  
 The input Observable.  
  
## Return Value  
 An Observable that filters observations based on `filter`.  
  
## Remarks  
 This function is named `Filter` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Observable Module (F#)](../vs140/control.observable-module--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)