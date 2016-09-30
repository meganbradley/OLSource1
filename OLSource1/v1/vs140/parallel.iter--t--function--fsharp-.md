---
title: "Parallel.iter&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Collections.ParallelModule.Iterate``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Iterate function [F#]"
  - "iter function [F#]"
  - "Parallel.iter function [F#]"
  - "Parallel.Iterate function [F#]"
ms.assetid: 2484b54a-41b7-482e-8931-b528b32ba93e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel.iter&lt;&#39;T&gt; Function (F#)
Apply the given function to each element of the array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.ArrayModule.Parallel  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Remarks  
 Performs the operation in parallel using System.Threading.Parallel.For. The order in which the given function is applied to elements of the input array is not specified.  
  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0  
  
## See Also  
 [Array.Parallel Module (F#)](../vs140/array.parallel-module--fsharp-.md)   
 [Microsoft.FSharp.Collections.ArrayModule Namespace (F#)](../vs140/collections.array-module--fsharp-.md)