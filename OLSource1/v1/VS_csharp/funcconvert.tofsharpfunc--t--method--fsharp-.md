---
title: "FuncConvert.ToFSharpFunc&lt;&#39;T&gt; Method (F#)"
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
  - "FuncConvert.ToFSharpFunc<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FuncConvert.ToFSharpFunc``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ToFSharpFunc method [F#]"
  - "FuncConvert.ToFSharpFunc method [F#]"
ms.assetid: ca2f654a-14bd-4348-a73d-2c0e0645abf6
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FuncConvert.ToFSharpFunc&lt;&#39;T&gt; Method (F#)
Convert the given <xref:System.Action`1*> delegate object to an F# function value.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member ToFSharpFunc : Action<'T> -> 'T -> unit  
  
// Usage:  
FuncConvert.ToFSharpFunc (action)  
```  
  
#### Parameters  
 `action`  
 Type: <xref:System.Action`1*>`<'T>`  
  
 The input action.  
  
## Return Value  
 The F# function.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.FuncConvert Class (F#)](../VS_csharp/core.funcconvert-class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)