---
title: "Lazy.Force&lt;&#39;T&gt; Extension Method (F#)"
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
  - "Lazy.Force<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.LazyExtensions.Force"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LazyExtensions.Force extension method [F#]"
  - "Force extension method [F#]"
ms.assetid: 0e18f26b-baa9-4254-98b4-beb858ea7730
caps.latest.revision: 26
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lazy.Force&lt;&#39;T&gt; Extension Method (F#)
Forces the execution of this value and returns its result. Same as <xref:System.Lazy`1.Value*>. Mutual exclusion is used to prevent other threads from also computing the value.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control.LazyExtensions  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
type System.Lazy with  
  member Force : unit -> 'T  
  
// Usage:  
lazy.Force ()  
```  
  
## Return Value  
 The value of the [Lazy](../vs140/control.lazy--t--type-abbreviation--fsharp-.md) object.  
  
## Remarks  
  
## Example  
 The following code illustrates the use of the `Force` extension method.  
  
 [!code[FsCoreLib2#13](../vs140/codesnippet/FSharp/lazy.force--t--extension-method--fsharp-_1.fs)]  
  
 The output indicates that when `Force` is called to create the value for `lazyVal1`, the computed value is retrieved when printing the values.  
  
 **Retrieving stored value: 479001600**  
**Computing value: 3628800**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 <xref:System.Lazy`1*>   
 [Control.LazyExtensions Module (F#)](../vs140/control.lazyextensions-module--fsharp-.md)   
 [Lazy Computations (F#)](../vs140/lazy-computations--fsharp-.md)