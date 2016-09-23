---
title: "Operators.int&lt;^T&gt; Function (F#)"
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
  - Operators.int<^T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.ToInt``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Operators.ToInt function [F#]
  - ToInt function [F#]
  - int function [F#]
  - Operators.int function [F#]
ms.assetid: ed07c5c9-2686-4e62-82c7-147ca9b0b9ef
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators.int&lt;^T&gt; Function (F#)
Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int32.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
int : ^T -> int (requires ^T with static member op_Explicit)  
  
// Usage:  
int value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted int  
  
## Remarks  
 This function is named `ToInt` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)