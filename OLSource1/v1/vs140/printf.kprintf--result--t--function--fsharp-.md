---
title: "Printf.kprintf&lt;&#39;Result,&#39;T&gt; Function (F#)"
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
  - Printf.kprintf<'Result,'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.PrintfModule.PrintFormatThen``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Printf.kprintf function [F#]
  - kprintf function [F#]
  - PrintFormatThen function [F#]
  - Printf.PrintFormatThen function [F#]
ms.assetid: fa31f68e-f039-4406-b9e1-688945430124
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Printf.kprintf&lt;&#39;Result,&#39;T&gt; Function (F#)
Like [printf](../vs140/printf.printf--t--function--fsharp-.md), but calls the specified function to generate the result. For example, these let the printing force a flush after all output has been entered onto the channel, but not before.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
kprintf : (string -> 'Result) -> StringFormat<'T,'Result> -> 'T  
  
// Usage:  
kprintf continutation format  
```  
  
#### Parameters  
 `continutation`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md) `-> 'Result`  
  
 The function called after formatting to generate the format result.  
  
 `format`  
 Type: [StringFormat](../vs140/printf.stringformat--t--result--type-abbreviation--fsharp-.md)`<'T,'Result>`  
  
 The input formatter.  
  
## Return Value  
 The arguments of the formatter.  
  
## Remarks  
 This function is named `PrintFormatThen` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Printf Module (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)