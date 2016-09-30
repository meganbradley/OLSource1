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
Functional programming operators related to the [Set](../vs140/collections.set--t--class--fsharp-.md) type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../vs140/set.add--t--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Returns a new set with an element added to the set. No exception is raised if the set already contains the given element.|  
|[contains](../vs140/set.contains--t--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Evaluates to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the given element is in the given set.|  
|[count](../vs140/set.count--t--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Returns the number of elements in the set.|  
|[difference](../vs140/set.difference--t--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Returns a new set with the elements of the second set removed from the first.|  
|[empty](../vs140/set.empty--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The empty set for the specified type.|  
|[exists](../vs140/set.exists--t--function--fsharp-.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Tests if any element of the collection satisfies the given predicate. If the input function is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the elements are <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, then this function computes <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[filter](../vs140/set.filter--t--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Returns a new collection containing only the elements of the collection for which the given predicate returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|[fold](../vs140/set.fold--t--state--function--fsharp-.md)  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Applies the given accumulating function to all the elements of the set|  
|[foldBack](../vs140/set.foldback--t--state--function--fsharp-.md)  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Applies the given accumulating function to all the elements of the set.|  
|[forall](../vs140/set.forall--t--function--fsharp-.md)  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Tests if all elements of the collection satisfy the given predicate. If the input function is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the elements are <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> then this function computes <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|[intersect](../vs140/set.intersect--t--function--fsharp-.md)  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Computes the intersection of the two sets.|  
|[intersectMany](../vs140/set.intersectmany--t--function--fsharp-.md)  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Computes the intersection of a sequence of sets. The sequence must be non-empty.|  
|[isEmpty](../vs140/set.isempty--t--function--fsharp-.md)  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if the set is empty.|  
|[isProperSubset](../vs140/set.ispropersubset--t--function--fsharp-.md)  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Evaluates to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if all elements of the first set are in the second, and at least one element of the second is not in the first.|  
|[isProperSuperset](../vs140/set.ispropersuperset--t--function--fsharp-.md)  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Evaluates to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if all elements of the second set are in the first, and at least one element of the first is not in the second.|  
|[isSubset](../vs140/set.issubset--t--function--fsharp-.md)  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Evaluates to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if all elements of the first set are in the second|  
|[isSuperset](../vs140/set.issuperset--t--function--fsharp-.md)  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Evaluates to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if all elements of the second set are in the first.|  
|[iter](../vs140/set.iter--t--function--fsharp-.md)  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Applies the given function to each element of the set, in order according to the comparison function.|  
|[map](../vs140/set.map--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Returns a new collection containing the results of applying the given function to each element of the input set.|  
|[maxElement](../vs140/set.maxelement--t--function--fsharp-.md)  <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Returns the highest element in the set according to the ordering being used for the set.|  
|[minElement](../vs140/set.minelement--t--function--fsharp-.md)  <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Returns the lowest element in the set according to the ordering being used for the set.|  
|[ofArray](../vs140/set.ofarray--t--function--fsharp-.md)  <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Creates a set that contains the same elements as the given array.|  
|[ofList](../vs140/set.oflist--t--function--fsharp-.md)  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Creates a set that contains the same elements as the given list.|  
|[ofSeq](../vs140/set.ofseq--t--function--fsharp-.md)  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Creates a new collection from the given enumerable object.|  
|[partition](../vs140/set.partition--t--function--fsharp-.md)  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Splits the set into two sets containing the elements for which the given predicate returns true and false respectively.|  
|[remove](../vs140/set.remove--t--function--fsharp-.md)  <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Returns a new set with the given element removed. No exception is raised if the set doesn't contain the given element.|  
|[singleton](../vs140/set.singleton--t--function--fsharp-.md)  <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|The set containing the given element.|  
|[toArray](../vs140/set.toarray--t--function--fsharp-.md)  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Creates an array that contains the elements of the set in order.|  
|[toList](../vs140/set.tolist--t--function--fsharp-.md) <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Creates a list that contains the elements of the set in order.|  
|[toSeq](../vs140/set.toseq--t--function--fsharp-.md)  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Returns an ordered view of the collection as an enumerable object.|  
|[union](../vs140/set.union--t--function--fsharp-.md)  <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Computes the union of the two sets.|  
|[unionMany](../vs140/set.unionmany--t--function--fsharp-.md)  <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Computes the union of a sequence of sets.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)