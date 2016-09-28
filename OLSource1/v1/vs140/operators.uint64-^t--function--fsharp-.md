---
title: "Operators.uint64&lt;^T&gt; Function (F#)"
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
  - "Operators.uint64<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.ToUInt64``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "uint64 function [F#]"
  - "ToUInt64 function [F#]"
  - "Operators.uint64 function [F#]"
  - "Operators.ToUInt64 function [F#]"
ms.assetid: b934a391-204c-49fa-8137-b73a6faf15d6
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.uint64&lt;^T&gt; Function (F#)
Converts the argument to unsigned 64-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using [Parse](assetId:///M:System.UInt64.Parse(System.String)?qualifyHint=False&autoUpgrade=True) with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
uint64 : ^T -> uint64 (requires ^T with static member op_Explicit)  
  
// Usage:  
uint64 value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted `uint64` value.  
  
## Remarks  
 This function is named `ToUInt64` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)