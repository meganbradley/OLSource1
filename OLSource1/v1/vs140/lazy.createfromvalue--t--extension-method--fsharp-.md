---
title: "Lazy.CreateFromValue&lt;&#39;T&gt; Extension Method (F#)"
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
  - "Lazy.CreateFromValue<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.LazyExtensions.CreateFromValue"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CreateFromValue extension method [F#]"
  - "LazyExtensions.CreateFromValue extension method [F#]"
ms.assetid: a4cd810a-36cd-418c-b022-e1e737d1665d
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lazy.CreateFromValue&lt;&#39;T&gt; Extension Method (F#)
Creates a lazy computation that evaluates to the given value when forced.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control.LazyExtensions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
type System.Lazy with  
  member static CreateFromValue : Lazy<'T>  
  
// Usage:  
lazy.CreateFromValue (value)  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The input value.  
  
## Return Value  
 The created [Lazy](../vs140/control.lazy--t--type-abbreviation--fsharp-.md) object.  
  
## Remarks  
  
## Example  
 The following code example illustrates the use of the `Lazy.CreateFromValue` extension method. In this example, a dictionary is used to store previously computed values. When the factorial function is called, if the value is already computed, then `Lazy.CreateFromValue` is called with the cached result. If the value is not already computed, then `Lazy.Create` is used.  
  
 [!code[FsCoreLib2#12](../vs140/codesnippet/FSharp/lazy.createfromvalue--t--extension-method--fsharp-_1.fs)]  
  
 **Output**  
  
 **Creating lazy factorial for 12.**  
**Evaluating lazy factorial for 12.**  
**479001600**  
**Reading factorial for 10 from cache.**  
**3628800**  
**Reading factorial for 11 from cache.**  
**39916800**  
**Creating lazy factorial for 30.**  
**Evaluating lazy factorial for 30.**  
**265252859812191058636308480000000**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 <xref:System.Lazy`1*>   
 [Control.LazyExtensions Module (F#)](../vs140/control.lazyextensions-module--fsharp-.md)   
 [Lazy Computations (F#)](../vs140/lazy-computations--fsharp-.md)