---
title: "Option.toArray&lt;&#39;T&gt; Function (F#)"
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
  - "Option.to_array<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptionModule.ToArray``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Option.toArray function [F#]"
  - "toArray function [F#]"
ms.assetid: c8044873-ba17-4b52-8231-eb1a28318c64
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option.toArray&lt;&#39;T&gt; Function (F#)
Convert the option to an array of length 0 or 1.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Option  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
toArray : 'T option -> 'T []  
  
// Usage:  
toArray option  
```  
  
#### Parameters  
 `option`  
 Type: `'T`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 The result array.  
  
## Remarks  
 This function is named `ToArray` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option Module (F#)](../vs140/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)