---
title: "Checked.byte&lt;^T&gt; Function (F#)"
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
  - "Checked.byte<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Checked.ToByte``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "byte function [F#]"
  - "ToByte function [F#]"
  - "Checked.byte function [F#]"
  - "Checked.ToByte function [F#]"
ms.assetid: 31fafa71-165c-4d79-9e99-551a0334cd4b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Checked.byte&lt;^T&gt; Function (F#)
Converts the argument to `byte`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Byte.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Checked  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
byte : ^T -> byte (requires ^T with static member op_Explicit)  
  
// Usage:  
byte value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted byte.  
  
## Remarks  
 This function is named `ToByte` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Operators.Checked Module (F#)](../vs140/operators.checked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)