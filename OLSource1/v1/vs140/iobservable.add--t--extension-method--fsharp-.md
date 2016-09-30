---
title: "IObservable.Add&lt;&#39;T&gt; Extension Method (F#)"
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
  - "IObservable.Add<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.CommonExtensions.AddToObservable"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CommonExtensions.AddToObservable extension method [F#]"
  - "AddToObservable extension method [F#]"
  - "Add extension method [F#]"
  - "CommonExtensions.Add extension method [F#]"
ms.assetid: cf21f284-ab78-4628-9585-090df11336c5
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObservable.Add&lt;&#39;T&gt; Extension Method (F#)
Permanently connects a listener function to the observable. The listener will be invoked for each observation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.CommonExtensions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
type System.IObservable with  
  member Add : ('T -> unit) -> unit  
  
// Usage:  
iObservable.Add (callback)  
```  
  
#### Parameters  
 `callback`  
 Type: `'T ->`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to be called for each observation.  
  
## Remarks  
 This member is named `AddToObservable` in compiled assemblies. If you are accessing the method from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 \<xref:System*>   
 [Control.CommonExtensions Module (F#)](../vs140/control.commonextensions-module--fsharp-.md)   
 [IObservable.Subscribe\<'T> Extension Method (F#)](../vs140/iobservable.subscribe--t--extension-method--fsharp-.md)   
 [System.IObservable\<'T> Interface](../vs140/system.iobservable--t--interface--fsharp-.md)