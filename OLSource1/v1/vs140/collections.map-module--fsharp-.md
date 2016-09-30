---
title: "Collections.Map Module (F#)"
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
  - "Collections.Map"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Map module [F#]"
  - "MapModule module [F#]"
ms.assetid: bfe61ead-f16c-416f-af98-56dbcbe23e4f
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Map Module (F#)
Functional programming operators related to the [Map](../vs140/collections.map--key--value--class--fsharp-.md) type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Map  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../vs140/map.add--key--t--function--fsharp-.md)  `: 'Key -> 'T -> Map<'Key,'T> -> Map<'Key,'T>`|Returns a new map with the binding added to the given map.|  
|[containsKey](../vs140/map.containskey--key--t--function--fsharp-.md)  `: 'Key -> Map<'Key,'T> -> bool`|Tests if an element is in the domain of the map.|  
|[empty](../vs140/map.empty--key--t--type-function--fsharp-.md)  `: Map<'Key,'T>`|The empty map.|  
|[exists](../vs140/map.exists--key--t--function--fsharp-.md)  `: ('Key -> 'T -> bool) -> Map<'Key,'T> -> bool`|Returns `true` if the given predicate returns true for one of the bindings in the map.|  
|[filter](../vs140/map.filter--key--t--function--fsharp-.md)  `: ('Key -> 'T -> bool) -> Map<'Key,'T> -> Map<'Key,'T>`|Creates a new map containing only the bindings for which the given predicate returns `true`.|  
|[find](../vs140/map.find--key--t--function--fsharp-.md)  `: 'Key -> Map<'Key,'T> -> 'T`|Looks up an element in the map.|  
|[findKey](../vs140/map.findkey--key--t--function--fsharp-.md)  `: ('Key -> 'T -> bool) -> Map<'Key,'T> -> 'Key`|Evaluates the function on each mapping in the collection. Returns the key for the first mapping where the function returns `true`.|  
|[fold](../vs140/map.fold--key--t--state--function--fsharp-.md)  `: ('State -> 'Key -> 'T -> 'State) -> 'State -> Map<'Key,'T> -> 'State`|Folds over the bindings in the map|  
|[foldBack](../vs140/map.foldback--key--t--state--function--fsharp-.md)  `: ('Key -> 'T -> 'State -> 'State) -> Map<'Key,'T> -> 'State -> 'State`|Folds over the bindings in the map.|  
|[forall](../vs140/map.forall--key--t--function--fsharp-.md)  `: ('Key -> 'T -> bool) -> Map<'Key,'T> -> bool`|Returns true if the given predicate returns true for all of the bindings in the map.|  
|[isEmpty](../vs140/map.isempty--key--t--function--fsharp-.md)  `: Map<'Key,'T> -> bool`|Tests whether the map has any bindings.|  
|[iter](../vs140/map.iter--key--t--function--fsharp-.md)  `: ('Key -> 'T -> unit) -> Map<'Key,'T> -> unit`|Applies the given function to each binding in the dictionary|  
|[map](../vs140/map.map--key--t--u--function--fsharp-.md)  `: ('Key -> 'T -> 'U) -> Map<'Key,'T> -> Map<'Key,'U>`|Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The key passed to the function indicates the key of element being transformed.|  
|[ofArray](../vs140/map.ofarray--key--t--function--fsharp-.md)  `: ('Key * 'T) [] -> Map<'Key,'T>`|Returns a new map made from the given bindings.|  
|[ofList](../vs140/map.oflist--key--t--function--fsharp-.md)  `: 'Key * 'T list -> Map<'Key,'T>`|Returns a new map made from the given bindings.|  
|[ofSeq](../vs140/map.ofseq--key--t--function--fsharp-.md)  `: seq<'Key * 'T> -> Map<'Key,'T>`|Returns a new map made from the given bindings.|  
|[partition](../vs140/map.partition--key--t--function--fsharp-.md)  `: ('Key -> 'T -> bool) -> Map<'Key,'T> -> Map<'Key,'T> * Map<'Key,'T>`|Creates two new maps, one containing the bindings for which the given predicate returns `true`, and the other the remaining bindings.|  
|[pick](../vs140/map.pick--key--t--u--function--fsharp-.md)  `: ('Key -> 'T -> 'U option) -> Map<'Key,'T> -> 'U`|Searches the map looking for the first element where the given function returns a `Some` value|  
|[remove](../vs140/map.remove--key--t--function--fsharp-.md)  `: 'Key -> Map<'Key,'T> -> Map<'Key,'T>`|Removes an element from the domain of the map. No exception is raised if the element is not present.|  
|[toArray](../vs140/map.toarray--key--t--function--fsharp-.md)  `: Map<'Key,'T> -> ('Key * 'T) []`|Returns an array of all key/value pairs in the mapping. The array will be ordered by the keys of the map.|  
|[toList](../vs140/map.tolist--key--t--function--fsharp-.md)  `: Map<'Key,'T> -> ('Key * 'T) list`|Returns a list of all key/value pairs in the mapping. The list will be ordered by the keys of the map.|  
|[toSeq](../vs140/map.toseq--key--t--function--fsharp-.md)  `: Map<'Key,'T> -> seq<'Key * 'T>`|Views the collection as an enumerable sequence of pairs. The sequence will be ordered by the keys of the map.|  
|[tryFind](../vs140/map.tryfind--key--t--function--fsharp-.md)  `: 'Key -> Map<'Key,'T> -> 'T option`|Looks up an element in the map, returning a `Some` value if the element is in the domain of the map, or `None` if not.|  
|[tryFindKey](../vs140/map.tryfindkey--key--t--function--fsharp-.md)  `: ('Key -> 'T -> bool) -> Map<'Key,'T> -> 'Key option`|Returns the key of the first mapping in the collection that satisfies the given predicate, or returns `None` if no such element exists.|  
|[tryPick](../vs140/map.trypick--key--t--u--function--fsharp-.md)  `: ('Key -> 'T -> 'U option) -> Map<'Key,'T> -> 'U option`|Searches the map looking for the first element where the given function returns a `Some` value.|  
  
## Example  
 The following code example uses functions in the Map module to create a histogram of the occurrences of particular Unicode characters using a [Microsoft.FSharp.Collections.Map](../vs140/collections.map--key--value--class--fsharp-.md).  
  
 [!code[FsSamples101#2002](../vs140/codesnippet/FSharp/collections.map-module--fsharp-_1.fs)]  
  
 **Number of ' ' characters = 8**  
**Number of 'T' characters = 1**  
**Number of 'a' characters = 1**  
**Number of 'b' characters = 1**  
**Number of 'c' characters = 1**  
**Number of 'd' characters = 1**  
**Number of 'e' characters = 3**  
**Number of 'f' characters = 1**  
**...**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)