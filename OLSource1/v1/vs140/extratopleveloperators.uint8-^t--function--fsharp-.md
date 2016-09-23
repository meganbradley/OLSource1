---
title: "ExtraTopLevelOperators.uint8&lt;^T&gt; Function (F#)"
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
  - ExtraTopLevelOperators.uint8<^T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.ExtraTopLevelOperators.ToByte``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - ExtraTopLevelOperators.ToByte function [F#]
  - uint8 function [F#]
  - ToByte function [F#]
  - ExtraTopLevelOperators.uint8 function [F#]
ms.assetid: 824ecbe9-2578-4339-8d0a-621f97a8a56a
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ExtraTopLevelOperators.uint8&lt;^T&gt; Function (F#)
Converts the argument to byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Byte.Parse?qualifyHint=False> on strings and otherwise requires a `ToByte` method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
uint8 : ^T -> byte (requires ^T with static member op_Explicit)  
  
// Usage:  
uint8 value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The value to convert.  
  
## Return Value  
 The converted value of type [byte](../vs140/core.byte-type-abbreviation--fsharp-.md).  
  
## Remarks  
 This function is named `ToByte` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)