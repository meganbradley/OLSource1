---
title: "RuntimeHelpers.EnumerateUsing&lt;&#39;T,&#39;Collection,&#39;U&gt; Function (F#)"
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
  - RuntimeHelpers.EnumerateUsing<'T,'Collection,'U>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.EnumerateUsing``3
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - RuntimeHelpers.EnumerateUsing function [F#]
  - EnumerateUsing function [F#]
ms.assetid: b25ee067-a8ad-4b81-a58c-072f127d69f5
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# RuntimeHelpers.EnumerateUsing&lt;&#39;T,&#39;Collection,&#39;U&gt; Function (F#)
The F# compiler emits calls to this function to implement the `use` keyword for F# sequence expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RuntimeHelpers.EnumerateUsing : 'T -> ('T -> 'Collection) -> seq<'U> (requires 'T :> IDisposable and 'Collection :> seq<'U>)  
  
// Usage:  
RuntimeHelpers.EnumerateUsing resource source  
```  
  
#### Parameters  
 `resource`  
 Type: `'T`  
  
 The resource to be used and disposed.  
  
 `source`  
 Type: `'T -> 'Collection`  
  
 The input sequence.  
  
## Return Value  
 The result sequence.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 <xref:System.IDisposable?qualifyHint=False>   
 [CompilerServices.RuntimeHelpers Module (F#)](../vs140/compilerservices.runtimehelpers-module--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)