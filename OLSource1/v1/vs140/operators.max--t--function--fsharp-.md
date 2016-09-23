---
title: "Operators.max&lt;&#39;T&gt; Function (F#)"
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
  - Operators.max<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.Max``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Operators.max function [F#]
  - max function [F#]
ms.assetid: 9a988328-00e9-467b-8dfa-e7a6990f6cce
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Operators.max&lt;&#39;T&gt; Function (F#)
Maximum based on generic comparison.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
max : 'T -> 'T -> 'T (requires comparison)  
  
// Usage:  
max e1 e2  
```  
  
#### Parameters  
 `e1`  
 Type: `'T`  
  
 The first value.  
  
 `e2`  
 Type: `'T`  
  
 The second value.  
  
## Return Value  
 The maximum value.  
  
## Remarks  
 This function is named `Max` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)