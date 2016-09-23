---
title: "FuncConvert.FuncFromTupled&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;U&gt; Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.FuncConvert.FuncFromTupled``6
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - FuncFromTupled method [F#]
ms.assetid: 98f6866f-d4dc-44b9-94ea-23972a55f94e
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# FuncConvert.FuncFromTupled&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;U&gt; Method (F#)
A utility function to convert function values from tupled to curried form.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member FuncFromTupled : ('T1 * 'T2 * 'T3 * 'T4 * 'T5 -> 'U) -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'U  
  
// Usage:  
FuncConvert.FuncFromTupled (func)  
```  
  
#### Parameters  
 `func`  
 Type: `'T1 * 'T2 * 'T3 * 'T4 * 'T5 ->   'U`  
  
 The input function that has tupled arguments.  
  
## Return Value  
 The output curried function.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.FuncConvert Class (F#)](../vs140/core.funcconvert-class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)