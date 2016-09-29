---
title: "CompilerMessageAttribute.IsError Property (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerMessageAttribute.IsError"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IsError property [F#]"
ms.assetid: 995cbc3a-5756-442a-884c-70757ab03d2d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerMessageAttribute.IsError Property (F#)
Indicates if the message should indicate a compiler error. Error numbers less than 10000 are considered reserved for use by the F# compiler and libraries.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
member this.IsError :  bool with get, set  
  
// Usage:  
compilerMessageAttribute.IsError  
compilerMessageAttribute.IsError <- isError  
```  
  
#### Parameters  
 Type: [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
## Return Value  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.CompilerMessageAttribute Class (F#)](../VS_csharp/core.compilermessageattribute-class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)