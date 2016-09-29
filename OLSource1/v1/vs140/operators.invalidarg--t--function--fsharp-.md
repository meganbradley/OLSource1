---
title: "Operators.invalidArg&lt;&#39;T&gt; Function (F#)"
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
  - "Operators.invalidArg<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.InvalidArg``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.invalidArg function [F#]"
  - "invalidArg function [F#]"
ms.assetid: d9f49313-8f14-4b1a-a31c-881615e307f8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.invalidArg&lt;&#39;T&gt; Function (F#)
Throw a <xref:System.ArgumentException*> exception.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
invalidArg : string -> string -> 'T  
  
// Usage:  
invalidArg argumentName message  
```  
  
#### Parameters  
 `argumentName`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The argument name.  
  
 `message`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The exception message.  
  
## Return Value  
 The result value.  
  
## Remarks  
 This function is named `InvalidArg` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)