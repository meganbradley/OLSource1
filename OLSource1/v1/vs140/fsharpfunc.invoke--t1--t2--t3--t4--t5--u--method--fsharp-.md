---
title: "FSharpFunc.Invoke&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;U&gt; Method (F#)"
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
  - "FSharpFunc.Invoke<'T1,'T2,'T3,'T4,'T5,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptimizedClosures.FSharpFunc`6.Invoke"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpFunc.Invoke method [F#]"
  - "Invoke method [F#]"
ms.assetid: f0e772d3-ebcc-43af-a255-acbd4b846dc8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpFunc.Invoke&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;U&gt; Method (F#)
Invoke an F# first class function value that accepts five curried arguments without intervening execution.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.OptimizedClosures  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.Invoke : FSharpFunc<'T1,'T2,'T3,'T4,'T5,'U> -> 'T1 * 'T2 * 'T3 * 'T4 * 'T5 -> 'U  
  
// Usage:  
fSharpFunc.Invoke (arg1, arg2, arg3, arg4, arg5)  
```  
  
#### Parameters  
 `arg1`  
 Type: `'T1`  
  
 The first argument.  
  
 `arg2`  
 Type: `'T2`  
  
 The second argument.  
  
 `arg3`  
 Type: `'T3`  
  
 The third argument.  
  
 `arg4`  
 Type: `'T4`  
  
 The fourth argument.  
  
 `arg5`  
 Type: `'T5`  
  
 The fifth argument.  
  
## Return Value  
 The function result.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [OptimizedClosures.FSharpFunc\<'T1,'T2,'T3,'T4,'T5,'U> Class (F#)](../vs140/optimizedclosures.fsharpfunc--t1--t2--t3--t4--t5--u--class--fsharp-.md)   
 [Microsoft.FSharp.Core.OptimizedClosures Namespace (F#)](../vs140/core.optimizedclosures-module--fsharp-.md)