---
title: "Option.fold&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "Option.fold<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptionModule.Fold``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Option.fold function [F#]"
  - "fold function [F#]"
ms.assetid: af896794-3d53-406c-9411-316cd5c33ad8
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option.fold&lt;&#39;T,&#39;State&gt; Function (F#)
Evaluates the equivalent of [List.fold](../VS_csharp/list.fold--t--state--function--fsharp-.md) for an option.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.Option  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
fold : ('State -> 'T -> 'State) -> 'State -> 'T option -> 'State  
  
// Usage:  
fold folder state option  
```  
  
#### Parameters  
 `folder`  
 Type: `'State -> 'T -> 'State`  
  
 A function to update the state data when given a value from an option.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
 `option`  
 Type: `'T`[option](../VS_csharp/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 The original state if the option is `None`, otherwise it returns the updated state with the folder and the option value.  
  
## Remarks  
 The expression `fold f s inp` evaluates to `match inp with None -> s | Some x -> f s x`.  
  
 This function is named `Fold` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Option.fold`.  
  
 [!code[FsOptions#4](../VS_csharp/codesnippet/FSharp/option.fold--t--state--function--fsharp-_1.fs)]  
  
 Output  
  
 **[1; 2; 3; 4; 5; 6; 7; 8; 9; 10][0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10]Enter a number: New list: []Enter a number: 10New list: [10]Enter a number: 1New list: [1; 10]Enter a number: abcNew list: [1; 10]Enter a number: 9New list: [9; 1; 10]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option Module (F#)](../VS_csharp/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)