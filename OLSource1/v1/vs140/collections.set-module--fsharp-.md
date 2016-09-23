---
title: "Collections.Set Module (F#)"
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
  - Collections.Set
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SetModule
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - SetModule module [F#]
  - Set module [F#]
ms.assetid: 61efa732-d55d-4c32-993f-628e2f98e6a0
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Collections.Set Module (F#)
Functional programming operators related to the [Set](../vs140/collections.set--t--class--fsharp-.md) type.  
  
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
|[add](../vs140/set.add--t--function--fsharp-.md)  `: 'T -> Set<'T> -> Set<'T>`|Returns a new set with an element added to the set. No exception is raised if the set already contains the given element.|  
|[contains](../vs140/set.contains--t--function--fsharp-.md)  `: 'T -> Set<'T> -> bool`|Evaluates to `true` if the given element is in the given set.|  
|[count](../vs140/set.count--t--function--fsharp-.md)  `: Set<'T> -> int`|Returns the number of elements in the set.|  
|[difference](../vs140/set.difference--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> Set<'T>`|Returns a new set with the elements of the second set removed from the first.|  
|[empty](../vs140/set.empty--t--type-function--fsharp-.md)  `: Set<'T>`|The empty set for the specified type.|  
|[exists](../vs140/set.exists--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> bool`|Tests if any element of the collection satisfies the given predicate. If the input function is `predicate` and the elements are `i0...iN`, then this function computes `predicate i0 or ... or predicate iN`.|  
|[filter](../vs140/set.filter--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> Set<'T>`|Returns a new collection containing only the elements of the collection for which the given predicate returns `true`.|  
|[fold](../vs140/set.fold--t--state--function--fsharp-.md)  `: ('State -> 'T -> 'State) -> 'State -> Set<'T> -> 'State`|Applies the given accumulating function to all the elements of the set|  
|[foldBack](../vs140/set.foldback--t--state--function--fsharp-.md)  `: ('T -> 'State -> 'State) -> Set<'T> -> 'State -> 'State`|Applies the given accumulating function to all the elements of the set.|  
|[forall](../vs140/set.forall--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> bool`|Tests if all elements of the collection satisfy the given predicate. If the input function is `p` and the elements are `i0...iN,` then this function computes `p i0 && ... && p iN`.|  
|[intersect](../vs140/set.intersect--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> Set<'T>`|Computes the intersection of the two sets.|  
|[intersectMany](../vs140/set.intersectmany--t--function--fsharp-.md)  `: seq<Set<'T>> -> Set<'T>`|Computes the intersection of a sequence of sets. The sequence must be non-empty.|  
|[isEmpty](../vs140/set.isempty--t--function--fsharp-.md)  `: Set<'T> -> bool`|Returns `true` if the set is empty.|  
|[isProperSubset](../vs140/set.ispropersubset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the first set are in the second, and at least one element of the second is not in the first.|  
|[isProperSuperset](../vs140/set.ispropersuperset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the second set are in the first, and at least one element of the first is not in the second.|  
|[isSubset](../vs140/set.issubset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the first set are in the second|  
|[isSuperset](../vs140/set.issuperset--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> bool`|Evaluates to `true` if all elements of the second set are in the first.|  
|[iter](../vs140/set.iter--t--function--fsharp-.md)  `: ('T -> unit) -> Set<'T> -> unit`|Applies the given function to each element of the set, in order according to the comparison function.|  
|[map](../vs140/set.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> Set<'T> -> Set<'U>`|Returns a new collection containing the results of applying the given function to each element of the input set.|  
|[maxElement](../vs140/set.maxelement--t--function--fsharp-.md)  `: Set<'T> -> 'T`|Returns the highest element in the set according to the ordering being used for the set.|  
|[minElement](../vs140/set.minelement--t--function--fsharp-.md)  `: Set<'T> -> 'T`|Returns the lowest element in the set according to the ordering being used for the set.|  
|[ofArray](../vs140/set.ofarray--t--function--fsharp-.md)  `: 'T array -> Set<'T>`|Creates a set that contains the same elements as the given array.|  
|[ofList](../vs140/set.oflist--t--function--fsharp-.md)  `: 'T list -> Set<'T>`|Creates a set that contains the same elements as the given list.|  
|[ofSeq](../vs140/set.ofseq--t--function--fsharp-.md)  `: seq<'T> -> Set<'T>`|Creates a new collection from the given enumerable object.|  
|[partition](../vs140/set.partition--t--function--fsharp-.md)  `: ('T -> bool) -> Set<'T> -> Set<'T> * Set<'T>`|Splits the set into two sets containing the elements for which the given predicate returns true and false respectively.|  
|[remove](../vs140/set.remove--t--function--fsharp-.md)  `: 'T -> Set<'T> -> Set<'T>`|Returns a new set with the given element removed. No exception is raised if the set doesn't contain the given element.|  
|[singleton](../vs140/set.singleton--t--function--fsharp-.md)  `: 'T -> Set<'T>`|The set containing the given element.|  
|[toArray](../vs140/set.toarray--t--function--fsharp-.md)  `: Set<'T> -> 'T array`|Creates an array that contains the elements of the set in order.|  
|[toList](../vs140/set.tolist--t--function--fsharp-.md) `: Set<'T> -> 'T list`|Creates a list that contains the elements of the set in order.|  
|[toSeq](../vs140/set.toseq--t--function--fsharp-.md)  `: Set<'T> -> seq<'T>`|Returns an ordered view of the collection as an enumerable object.|  
|[union](../vs140/set.union--t--function--fsharp-.md)  `: Set<'T> -> Set<'T> -> Set<'T>`|Computes the union of the two sets.|  
|[unionMany](../vs140/set.unionmany--t--function--fsharp-.md)  `: seq<Set<'T>> -> Set<'T>`|Computes the union of a sequence of sets.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)