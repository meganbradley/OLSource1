---
title: "Microsoft.FSharp.Collections Namespace (F#)"
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
  - Microsoft.FSharp.Collections
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Microsoft.FSharp.Collections namespace [F#]
ms.assetid: 24f64e5f-5030-47d0-9759-8d3e398ed13f
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Microsoft.FSharp.Collections Namespace (F#)
This namespace contains some common collections in an object-oriented style well suited for use from F#.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
namespace Microsoft.FSharp.Collections  
```  
  
## Remarks  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [Array](../vs140/collections.array-module--fsharp-.md)|Basic operations on arrays.|  
|module [Array2D](../vs140/collections.array2d-module--fsharp-.md)|Basic operations on 2-dimensional arrays.|  
|module [Array3D](../vs140/collections.array3d-module--fsharp-.md)|Basic operations on rank 3 arrays.|  
|module [Array4D](../vs140/collections.array4d-module--fsharp-.md)|Basic operations on rank 4 arrays.|  
|module [ComparisonIdentity](../vs140/collections.comparisonidentity-module--fsharp-.md)|Common notions of comparison identity used with sorted data structures.|  
|module [HashIdentity](../vs140/collections.hashidentity-module--fsharp-.md)|Common notions of value identity used with hash tables.|  
|module [List](../vs140/collections.list-module--fsharp-.md)|Basic operations on lists.|  
|module [Map](../vs140/collections.map-module--fsharp-.md)|Functional programming operators related to the [Map](../vs140/collections.map--key--value--class--fsharp-.md) type.|  
|module [Seq](../vs140/collections.seq-module--fsharp-.md)|Basic operations on enumerable collections.|  
|module [Set](../vs140/collections.set-module--fsharp-.md)|Functional programming operators related to the [Set](../vs140/collections.set--t--class--fsharp-.md) type.|  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [List<'T>](../vs140/collections.list--t--union--fsharp-.md)|The type of immutable singly-linked lists.|  
|type [Map< 'Key, 'Value>](../vs140/collections.map--key--value--class--fsharp-.md)|Immutable maps. Keys are ordered by F# generic comparison.|  
|type [Set< 'T>](../vs140/collections.set--t--class--fsharp-.md)|Immutable sets based on binary trees, where comparison is the F# structural comparison function, potentially using implementations of the <xref:System.IComparable?qualifyHint=False> interface on key values.|  
  
## Type Abbreviations  
  
|Type|Description|  
|----------|-----------------|  
|type [list<'T>](../vs140/collections.list--t--type-abbreviation--fsharp-.md)|An abbreviation for the type of immutable singly-linked lists.|  
|type [ResizeArray<'T>](../vs140/collections.resizearray--t--type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Collections.Generic.List`1?qualifyHint=False>.|  
|type [seq<'T>](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)|An abbreviation for the CLI type <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>|  
  
## See Also  
 [F# Library Reference](../vs140/fsharp-core-library-reference.md)