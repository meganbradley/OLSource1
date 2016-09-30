---
title: "Option.bind&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Option.bind<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptionModule.Bind``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Option.bind function [F#]"
  - "bind function [F#]"
ms.assetid: c3406192-24ac-49b5-bc3b-8f805187f1c0
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option.bind&lt;&#39;T,&#39;U&gt; Function (F#)
Invokes a function on an optional value that itself yields an option.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.Option  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
bind : ('T -> 'U option) -> 'T option -> 'U option  
  
// Usage:  
bind binder option  
```  
  
#### Parameters  
 `binder`  
 Type: `'T -> 'U`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 A function that takes the value of type T from an option and transforms it into an option containing a value of type U.  
  
 `option`  
 Type: `'T`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 An option of the output type of the binder.  
  
## Remarks  
 The expression `Option.bind f inp` evaluates to `match inp with None -> None | Some x -> f x.`  
  
 This function is named `Bind` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Option.bind`.  
  
 [!code[FsOptions#1](../vs140/codesnippet/FSharp/option.bind--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Some "egamI rorriM"\<null>**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option Module (F#)](../vs140/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)