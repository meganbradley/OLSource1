---
title: "Option.count&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Option.count<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.OptionModule.Count``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - count function [F#]
  - Option.count function [F#]
ms.assetid: 2dac83a9-684e-4d0f-b50e-ff722a8bb876
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Option.count&lt;&#39;T&gt; Function (F#)
Evaluates the equivalent of [Set.count](../vs140/set.count--t--function--fsharp-.md) for an option.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Option  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
count : 'T option -> int  
  
// Usage:  
count option  
```  
  
#### Parameters  
 `option`  
 Type: `'T`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 A zero if the option is `None`, a one otherwise.  
  
## Remarks  
 The expression `count inp` evaluates to `match inp with None -> 0 | Some _ -> 1`.  
  
 This function is named `Count` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Option.count`.  
  
 [!code[FsOptions#2](../vs140/codesnippet/FSharp/option.count--t--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **1 035**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option Module (F#)](../vs140/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)