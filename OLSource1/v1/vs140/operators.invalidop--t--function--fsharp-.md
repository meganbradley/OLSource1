---
title: "Operators.invalidOp&lt;&#39;T&gt; Function (F#)"
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
  - "Operators.invalidOp<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.InvalidOp``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.InvalidOp function [F#]"
  - "Operators.invalidOp function [F#]"
  - "invalidOp function [F#]"
ms.assetid: c4df4f23-dfdd-4b3e-9fea-da9886634c9e
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.invalidOp&lt;&#39;T&gt; Function (F#)
Throw a \<xref:System.InvalidOperationException*> exception.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
invalidOp : string -> 'T  
  
// Usage:  
invalidOp message  
```  
  
#### Parameters  
 `message`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The exception message.  
  
## Return Value  
 The result value.  
  
## Remarks  
 This function is named `InvalidOp` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)