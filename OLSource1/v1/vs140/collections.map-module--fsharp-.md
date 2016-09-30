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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../vs140/map.add--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Returns a new map with the binding added to the given map.|  
|[containsKey](../vs140/map.containskey--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Tests if an element is in the domain of the map.|  
|[empty](../vs140/map.empty--key--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The empty map.|  
|[exists](../vs140/map.exists--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the given predicate returns true for one of the bindings in the map.|  
|[filter](../vs140/map.filter--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Creates a new map containing only the bindings for which the given predicate returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[find](../vs140/map.find--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Looks up an element in the map.|  
|[findKey](../vs140/map.findkey--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Evaluates the function on each mapping in the collection. Returns the key for the first mapping where the function returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[fold](../vs140/map.fold--key--t--state--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Folds over the bindings in the map|  
|[foldBack](../vs140/map.foldback--key--t--state--function--fsharp-.md)  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Folds over the bindings in the map.|  
|[forall](../vs140/map.forall--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Returns true if the given predicate returns true for all of the bindings in the map.|  
|[isEmpty](../vs140/map.isempty--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Tests whether the map has any bindings.|  
|[iter](../vs140/map.iter--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Applies the given function to each binding in the dictionary|  
|[map](../vs140/map.map--key--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The key passed to the function indicates the key of element being transformed.|  
|[ofArray](../vs140/map.ofarray--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Returns a new map made from the given bindings.|  
|[ofList](../vs140/map.oflist--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Returns a new map made from the given bindings.|  
|[ofSeq](../vs140/map.ofseq--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Returns a new map made from the given bindings.|  
|[partition](../vs140/map.partition--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Creates two new maps, one containing the bindings for which the given predicate returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and the other the remaining bindings.|  
|[pick](../vs140/map.pick--key--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Searches the map looking for the first element where the given function returns a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> value|  
|[remove](../vs140/map.remove--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Removes an element from the domain of the map. No exception is raised if the element is not present.|  
|[toArray](../vs140/map.toarray--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Returns an array of all key/value pairs in the mapping. The array will be ordered by the keys of the map.|  
|[toList](../vs140/map.tolist--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Returns a list of all key/value pairs in the mapping. The list will be ordered by the keys of the map.|  
|[toSeq](../vs140/map.toseq--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Views the collection as an enumerable sequence of pairs. The sequence will be ordered by the keys of the map.|  
|[tryFind](../vs140/map.tryfind--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Looks up an element in the map, returning a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value if the element is in the domain of the map, or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if not.|  
|[tryFindKey](../vs140/map.tryfindkey--key--t--function--fsharp-.md)  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Returns the key of the first mapping in the collection that satisfies the given predicate, or returns <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if no such element exists.|  
|[tryPick](../vs140/map.trypick--key--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Searches the map looking for the first element where the given function returns a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> value.|  
  
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