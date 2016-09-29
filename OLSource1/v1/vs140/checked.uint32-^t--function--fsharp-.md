---
title: "Checked.uint32&lt;^T&gt; Function (F#)"
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
  - "Checked.uint32<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Checked.ToUInt32``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Checked.uint32 function [F#]"
  - "Checked.ToUInt32 function [F#]"
  - "uint32 function [F#]"
  - "ToUInt32 function [F#]"
ms.assetid: cccb755b-2e72-47f9-a1ae-cdf53a5aac7f
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Checked.uint32&lt;^T&gt; Function (F#)
Converts the argument to `uint32`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using [Parse](assetId:///M:System.UInt32.Parse(System.String)?qualifyHint=False&autoUpgrade=True) with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
uint32 : ^T -> uint32 (requires ^T with static member op_Explicit)  
  
// Usage:  
uint32 value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted `uint32`.  
  
## Remarks  
 This function is named `ToUInt32` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Operators.Checked Module (F#)](../vs140/operators.checked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)