---
title: "Collections.Set&lt;&#39;T&gt; Class (F#)"
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
  - "Collections.Set<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpSet`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Set class [F#]"
  - "FSharpSet class [F#]"
ms.assetid: 50cebdce-0cd7-4c5c-8ebc-f3a9e90b38d8
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Set&lt;&#39;T&gt; Class (F#)
Immutable sets based on binary trees, where comparison is the F# structural comparison function, potentially using implementations of the <xref:System.IComparable*> interface on key values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
type Set<[<EqualityConditionalOnAttribute>] 'T (requires comparison)> =  
 class  
  interface IComparable  
  interface IEnumerable  
  interface IEnumerable  
  interface ICollection  
  new Set : seq<'T> -> Set<'T>  
  member this.Add : 'T -> Set<'T>  
  member this.Contains : 'T -> bool  
  member this.IsProperSubsetOf : Set<'T> -> bool  
  member this.IsProperSupersetOf : Set<'T> -> bool  
  member this.IsSubsetOf : Set<'T> -> bool  
  member this.IsSupersetOf : Set<'T> -> bool  
  member this.Remove : 'T -> Set<'T>  
  member this.Count :  int  
  member this.IsEmpty :  bool  
  member this.MaximumElement :  'T  
  member this.MinimumElement :  'T  
  static member ( + ) : Set<'T> * Set<'T> -> Set<'T>  
  static member ( - ) : Set<'T> * Set<'T> -> Set<'T>  
 end  
```  
  
## Remarks  
 See the Set module for further operations on sets. All members of this class are thread-safe and may be used concurrently from multiple threads.  
  
 This type is named `FSharpSet` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/collections.set--t--constructor--fsharp-.md)|Create a set containing elements drawn from the given sequence.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Add](../vs140/set.add--t--method--fsharp-.md)|A useful shortcut for [Set.add](../vs140/set.add--t--function--fsharp-.md). Note this operation produces a new set and does not mutate the original set. The new set will share many storage nodes with the original.|  
|[Contains](../vs140/set.contains--t--method--fsharp-.md)|A useful shortcut for [Set.contains](../vs140/set.contains--t--function--fsharp-.md). See the Set module for further operations on sets.|  
|[Count](../vs140/set.count--t--property--fsharp-.md)|The number of elements in the set|  
|[IsEmpty](../vs140/set.isempty--t--property--fsharp-.md)|A useful shortcut for [Set.isEmpty](../vs140/set.isempty--t--function--fsharp-.md).|  
|[IsProperSubsetOf](../vs140/set.ispropersubsetof--t--method--fsharp-.md)|Evaluates to `true` if all elements of the first set are in the second, and at least one element of the second is not in the first.|  
|[IsProperSupersetOf](../vs140/set.ispropersupersetof--t--method--fsharp-.md)|Evaluates to `true` if all elements of the second set are in the first, and at least one element of the first is not in the second.|  
|[IsSubsetOf](../vs140/set.issubsetof--t--method--fsharp-.md)|Evaluates to `true` if all elements of the first set are in the second.|  
|[IsSupersetOf](../vs140/set.issupersetof--t--method--fsharp-.md)|Evaluates to `true` if all elements of the second set are in the first.|  
|[MaximumElement](../vs140/set.maximumelement--t--property--fsharp-.md)|Returns the highest element in the set according to the ordering being used for the set.|  
|[MinimumElement](../vs140/set.minimumelement--t--property--fsharp-.md)|Returns the lowest element in the set according to the ordering being used for the set.|  
|[Remove](../vs140/set.remove--t--method--fsharp-.md)|A useful shortcut for [Set.remove](../vs140/set.remove--t--function--fsharp-.md). Note this operation produces a new set and does not mutate the original set. The new set will share many storage nodes with the original.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[( + )](../vs140/set.-------t--method--fsharp-.md)|Compute the union of the two sets.|  
|[( - )](../vs140/set.-------t--method--fsharp-.md)|Returns a new set with the elements of the second set removed from the first.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)   
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)