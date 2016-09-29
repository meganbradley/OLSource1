---
title: "Option.iter&lt;&#39;T&gt; Function (F#)"
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
  - "Option.iter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptionModule.Iterate``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Iterate function [F#]"
  - "iter function [F#]"
  - "Option.iter function [F#]"
  - "Option.Iterate function [F#]"
ms.assetid: 83389eef-3dff-4074-b4cc-f69581c25191
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option.iter&lt;&#39;T&gt; Function (F#)
Executes a function for an option value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Option  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
iter : ('T -> unit) -> 'T option -> unit  
  
// Usage:  
iter action option  
```  
  
#### Parameters  
 `action`  
 Type: `'T ->`[unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)  
  
 A function to apply to the option value.  
  
 `option`  
 Type: `'T`[option](../VS_csharp/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Remarks  
 The expression `iter f inp` executes `match inp with None -> () | Some x -> f x`.  
  
 This function is named `Iterate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option Module (F#)](../VS_csharp/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)