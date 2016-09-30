---
title: "Core.&lt;&#39;T&gt; Type (F#)4"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Core.[,]<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
H1: "Core.&lt;&#39;T&gt; Type (F#)"
f1_keywords: 
  - "[, ]"
dev_langs: 
  - "FSharp"
ms.assetid: 077252f3-e6ce-441c-9d5b-a6030eaef7cd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.&lt;&#39;T&gt; Type (F#)4
Two dimensional arrays, typically zero-based.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type [,]<'T> =  
 class  
 end  
```  
  
## Remarks  
 Use the functions in the [Array2D module](../vs140/collections.array2d-module--fsharp-.md) to create and manipulate values of this type, or the notation `arr.[x,y]` to get or set array values. Non-zero-based arrays can also be created using methods on the \<xref:System.Array*> type. For more information on arrays, see [Arrays (F#)](../vs140/arrays--fsharp-.md).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)   
 [Arrays (F#)](../vs140/arrays--fsharp-.md)