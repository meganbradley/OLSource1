---
title: "Parallel.init&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Collections.ParallelModule.Initialize``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Parallel.Initialize function [F#]"
  - "init function [F#]"
  - "Parallel.init function [F#]"
  - "Initialize function [F#]"
ms.assetid: 96c71191-2fa4-42fc-9418-80e1a1906fef
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel.init&lt;&#39;T&gt; Function (F#)
Create an array given the dimension and a generator function to compute the elements.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.ArrayModule.Parallel  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The size of the array.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The function that generates the elements.  
  
## Return Value  
 The created array.  
  
## Remarks  
 Performs the operation in parallel using System.Threading.Tasks.Parallel.For. The order in which the given function is applied to indices is not specified.  
  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0  
  
## See Also  
 [Array.Parallel Module (F#)](../vs140/array.parallel-module--fsharp-.md)   
 [Microsoft.FSharp.Collections.ArrayModule Namespace (F#)](../vs140/collections.array-module--fsharp-.md)