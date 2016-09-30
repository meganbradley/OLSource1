---
title: "FSharpFunc.InvokeFast&lt;&#39;T,&#39;U,&#39;V,&#39;W,&#39;X&gt; Method (F#)"
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
  - "FSharpFunc.InvokeFast<'T,'U,'V,'W,'X>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpFunc`2.InvokeFast``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpFunc.InvokeFast method [F#]"
  - "InvokeFast method [F#]"
ms.assetid: bbaf542c-8d63-440f-b552-5520f09749d8
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpFunc.InvokeFast&lt;&#39;T,&#39;U,&#39;V,&#39;W,&#39;X&gt; Method (F#)
Invoke an F# first class function value with four curried arguments. In some cases this will result in a more efficient application than applying the arguments successively.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member InvokeFast : FSharpFunc<'T,('U -> 'V -> 'W -> 'X)> * 'T * 'U * 'V * 'W -> 'X  
  
// Usage:  
FSharpFunc.InvokeFast (func, arg1, arg2, arg3, arg4)  
```  
  
#### Parameters  
 `func`  
 Type: [FSharpFunc](../vs140/core.fsharpfunc--t--u--class--fsharp-.md)`<'T,('U -> 'V ->'W -> 'X)>`  
  
 The input function.  
  
 `arg1`  
 Type: `'T`  
  
 The first arg.  
  
 `arg2`  
 Type: `'U`  
  
 The second arg.  
  
 `arg3`  
 Type: `'V`  
  
 The third arg.  
  
 `arg4`  
 Type: `'W`  
  
 The fourth arg.  
  
## Return Value  
 The function result.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.FSharpFunc<'T,'U> Class (F#)](../vs140/core.fsharpfunc--t--u--class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)