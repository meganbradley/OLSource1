---
title: "Collections.Set Module (F#)"
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
  - "Collections.Set"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SetModule module [F#]"
  - "Set module [F#]"
ms.assetid: 61efa732-d55d-4c32-993f-628e2f98e6a0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Set Module (F#)
Functional programming operators related to the [Set](../VS_csharp/collections.set--t--class--fsharp-.md) type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Set  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../VS_csharp/set.add--t--function--fsharp-.md)  `: 'T -> Set<'T> -> Set<'T>`|Returns a new set with an element added to the set. No exception is raised if the set already contains the given element.|  
|[contains](../VS_csharp/set.contains--t--function--fsharp-.md)  `: 'T -> Set<'T> -> bool`|Evaluates to `true` if the given element is in the given set.|  
|[count](../VS_csharp/set.count--t--function--fsharp-.md)  `: Set<'T> -> int`|Returns the number of elements in the set.|  
|[difference](../VS_csharp/set.difference--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> Set<'T>`|Returns a new set with the elements of the second set removed from the first.|  
|[empty](../VS_csharp/set.empty--t--type-function--fsharp-.md)  `: Set<'T>`|The empty set for the specified type.|  
|[exists](../VS_csharp/set.exists--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> bool`|Tests if any element of the collection satisfies the given predicate. If the input function is `predicate` and the elements are `i0...iN`, then this function computes `predicate i0 or ... or predicate iN`.|  
|[filter](../VS_csharp/set.filter--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> Set<'T>`|Returns a new collection containing only the elements of the collection for which the given predicate returns `true`.|  
|[fold](../VS_csharp/set.fold--t--state--function--fsharp-.md)  `: ('State -> 'T -> 'State) -> 'State -> Set<'T> -> 'State`|Applies the given accumulating function to all the elements of the set|  
|[foldBack](../VS_csharp/set.foldback--t--state--function--fsharp-.md)  `: ('T -> 'State -> 'State) -> Set<'T> -> 'State -> 'State`|Applies the given accumulating function to all the elements of the set.|  
|[forall](../VS_csharp/set.forall--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> bool`|Tests if all elements of the collection satisfy the given predicate. If the input function is `p` and the elements are `i0...iN,` then this function computes `p i0 && ... && p iN`.|  
|[intersect](../VS_csharp/set.intersect--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> Set<'T>`|Computes the intersection of the two sets.|  
|[intersectMany](../VS_csharp/set.intersectmany--t--function--fsharp-.md)  `: seq<Set<'T>> -> Set<'T>`|Computes the intersection of a sequence of sets. The sequence must be non-empty.|  
|[isEmpty](../VS_csharp/set.isempty--t--function--fsharp-.md)  `: Set<'T> -> bool`|Returns `true` if the set is empty.|  
|[isProperSubset](../VS_csharp/set.ispropersubset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the first set are in the second, and at least one element of the second is not in the first.|  
|[isProperSuperset](../VS_csharp/set.ispropersuperset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the second set are in the first, and at least one element of the first is not in the second.|  
|[isSubset](../VS_csharp/set.issubset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the first set are in the second|  
|[isSuperset](../VS_csharp/set.issuperset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the second set are in the first.|  
|[iter](../VS_csharp/set.iter--t--function--fsharp-.md)  `: ('T -> unit) -> Set<'T> -> unit`|Applies the given function to each element of the set, in order according to the comparison function.|  
|[map](../VS_csharp/set.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> Set<'T> -> Set<'U>`|Returns a new collection containing the results of applying the given function to each element of the input set.|  
|[maxElement](../VS_csharp/set.maxelement--t--function--fsharp-.md)  `: Set<'T> -> 'T`|Returns the highest element in the set according to the ordering being used for the set.|  
|[minElement](../VS_csharp/set.minelement--t--function--fsharp-.md)  `: Set<'T> -> 'T`|Returns the lowest element in the set according to the ordering being used for the set.|  
|[ofArray](../VS_csharp/set.ofarray--t--function--fsharp-.md)  `: 'T array -> Set<'T>`|Creates a set that contains the same elements as the given array.|  
|[ofList](../VS_csharp/set.oflist--t--function--fsharp-.md)  `: 'T list -> Set<'T>`|Creates a set that contains the same elements as the given list.|  
|[ofSeq](../VS_csharp/set.ofseq--t--function--fsharp-.md)  `: seq<'T> -> Set<'T>`|Creates a new collection from the given enumerable object.|  
|[partition](../VS_csharp/set.partition--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> Set<'T> * Set<'T>`|Splits the set into two sets containing the elements for which the given predicate returns true and false respectively.|  
|[remove](../VS_csharp/set.remove--t--function--fsharp-.md)  `: 'T -> Set<'T> -> Set<'T>`|Returns a new set with the given element removed. No exception is raised if the set doesn't contain the given element.|  
|[singleton](../VS_csharp/set.singleton--t--function--fsharp-.md)  `: 'T -> Set<'T>`|The set containing the given element.|  
|[toArray](../VS_csharp/set.toarray--t--function--fsharp-.md)  `: Set<'T> -> 'T array`|Creates an array that contains the elements of the set in order.|  
|[toList](../VS_csharp/set.tolist--t--function--fsharp-.md) `: Set<'T> -> 'T list`|Creates a list that contains the elements of the set in order.|  
|[toSeq](../VS_csharp/set.toseq--t--function--fsharp-.md)  `: Set<'T> -> seq<'T>`|Returns an ordered view of the collection as an enumerable object.|  
|[union](../VS_csharp/set.union--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> Set<'T>`|Computes the union of the two sets.|  
|[unionMany](../VS_csharp/set.unionmany--t--function--fsharp-.md)  `: seq<Set<'T>> -> Set<'T>`|Computes the union of a sequence of sets.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)