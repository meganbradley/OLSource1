---
title: "Operators.using&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Operators.using<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Using``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.using function [F#]"
  - "using function [F#]"
ms.assetid: de177834-c364-4a08-967b-8bd9dea1979d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.using&lt;&#39;T,&#39;U&gt; Function (F#)
Clean up resources associated with the input object after the completion of the given function. Cleanup occurs even when an exception is raised by the protected code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
using : 'T -> ('T -> 'U) -> 'U (requires 'T :> IDisposable)  
  
// Usage:  
using resource action  
```  
  
#### Parameters  
 `resource`  
 Type: `'T`  
  
 The resource to be disposed after action is called.  
  
 `action`  
 Type: `'T -> 'U`  
  
 The action that accepts the resource.  
  
## Return Value  
 The resulting value.  
  
## Remarks  
 This function is named `Using` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../VS_csharp/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)