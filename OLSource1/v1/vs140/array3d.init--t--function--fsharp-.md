---
title: "Array3D.init&lt;&#39;T&gt; Function (F#)"
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
  - "Array3D.init<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array3DModule.Initialize``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array3D.init function [F#]"
  - "init function [F#]"
  - "Array3D.Initialize function [F#]"
  - "Initialize function [F#]"
ms.assetid: fcd89119-995c-4f28-9e79-7e8b14ca6f08
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array3D.init&lt;&#39;T&gt; Function (F#)
Creates an array given the dimensions and a generator function to compute the elements.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array3D  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the first dimension.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the second dimension.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the third dimension.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [int](../vs140/core.int-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> [int](../vs140/core.int-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 The function to create an initial value at each index into the array.  
  
## Return Value  
 The created array.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array3D Module (F#)](../vs140/collections.array3d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)