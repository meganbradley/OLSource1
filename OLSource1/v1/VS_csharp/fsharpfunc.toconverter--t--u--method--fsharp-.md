---
title: "FSharpFunc.ToConverter&lt;&#39;T,&#39;U&gt; Method (F#)"
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
  - "FSharpFunc.ToConverter<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpFunc`2.ToConverter"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpFunc.ToConverter method [F#]"
  - "ToConverter method [F#]"
ms.assetid: 52fb0fb5-8581-4e48-9425-b7819a547d86
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpFunc.ToConverter&lt;&#39;T,&#39;U&gt; Method (F#)
Convert an F# first class function value to a value of type <xref:System.Converter`2*>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member ToConverter : ('T -> 'U) -> Converter<'T,'U>  
  
// Usage:  
FSharpFunc.ToConverter (func)  
```  
  
#### Parameters  
 `func`  
 Type: `'T -> 'U`  
  
 The input function.  
  
## Return Value  
 An instance of <xref:System.Converter`2*> that represents the input function.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Core.FSharpFunc<'T,'U> Class (F#)](../VS_csharp/core.fsharpfunc--t--u--class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)