---
title: "RuntimeHelpers.EnumerateFromFunctions&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "RuntimeHelpers.EnumerateFromFunctions<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.EnumerateFromFunctions``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "EnumerateFromFunctions function [F#]"
  - "RuntimeHelpers.EnumerateFromFunctions function [F#]"
ms.assetid: a7e754e2-4766-4d17-990a-61bc858393c6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeHelpers.EnumerateFromFunctions&lt;&#39;T,&#39;U&gt; Function (F#)
The F# compiler emits calls to this function to implement the compiler-intrinsic conversions from weakly typed \<xref:System.Collections.IEnumerable*> sequences to typed sequences.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 An initializer function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to iterate and test if end of sequence is reached.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 A function to retrieve the current element.  
  
## Return Value  
 The resulting typed sequence.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [CompilerServices.RuntimeHelpers Module (F#)](../vs140/compilerservices.runtimehelpers-module--fsharp-.md)   
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../vs140/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)