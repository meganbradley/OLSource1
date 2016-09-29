---
title: "FSharpFunc.Invoke&lt;&#39;T1,&#39;T2,&#39;U&gt; Method (F#)"
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
  - "FSharpFunc.Invoke<'T1,'T2,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptimizedClosures.FSharpFunc`3.Invoke"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpFunc.Invoke method [F#]"
  - "Invoke method [F#]"
ms.assetid: 3373e0ad-8a6e-4998-b906-35fb92bc8ca4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpFunc.Invoke&lt;&#39;T1,&#39;T2,&#39;U&gt; Method (F#)
Invoke the optimized function value with two curried arguments.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.OptimizedClosures  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.Invoke : FSharpFunc<'T1,'T2,'U> -> 'T1 * 'T2 -> 'U  
  
// Usage:  
fSharpFunc.Invoke (arg1, arg2)  
```  
  
#### Parameters  
 `arg1`  
 Type: `'T1`  
  
 The first argument.  
  
 `arg2`  
 Type: `'T2`  
  
 The second argument.  
  
## Return Value  
 The function result.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [OptimizedClosures.FSharpFunc<'T1,'T2,'U> Class (F#)](../vs140/optimizedclosures.fsharpfunc--t1--t2--u--class--fsharp-.md)   
 [Microsoft.FSharp.Core.OptimizedClosures Namespace (F#)](../vs140/core.optimizedclosures-module--fsharp-.md)