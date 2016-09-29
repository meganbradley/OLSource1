---
title: "Collections.Map&lt;&#39;Key,&#39;Value&gt; Class (F#)"
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
  - "Collections.Map<'Key,'Value>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpMap`2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpMap class [F#]"
  - "Map class [F#]"
ms.assetid: 975316ea-55e3-4987-9994-90897ad45664
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.Map&lt;&#39;Key,&#39;Value&gt; Class (F#)
Immutable maps. Keys are ordered by F# generic comparison.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
type Map<[<EqualityConditionalOnAttribute>] 'Key,[<ComparisonConditionalOnAttribute>] [<EqualityConditionalOnAttribute>] 'Value (requires comparison)> =  
 class  
  interface IEnumerable  
  interface IComparable  
  interface IEnumerable  
  interface ICollection  
  interface IDictionary  
  new Map : seq<'Key * 'Value> -> Map< 'Key, 'Value>  
  member this.Add : 'Key * 'Value -> Map<'Key, 'Value>  
  member this.ContainsKey : 'Key -> bool  
  member this.Remove : 'Key -> Map<'Key, 'Value>  
  member this.TryFind : 'Key -> 'Value option  
  member this.Count :  int  
  member this.IsEmpty :  bool  
  member this.Item ('Key) : 'Value  
 end  
```  
  
## Remarks  
 Maps based on generic comparison are efficient for small keys. They are not a suitable choice if keys are recursive data structures or if keys require bespoke comparison semantics. All members of this class are thread-safe and may be used concurrently from multiple threads.  
  
 This type is named `FSharpMap` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/collections.map--key--value--constructor--fsharp-.md)|Builds a map that contains the bindings of the given <xref:System.Collections.Generic.IEnumerable`1*>.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Add](../vs140/map.add--key--value--method--fsharp-.md)|Returns a new map with the binding added to the given map.|  
|[ContainsKey](../vs140/map.containskey--key--value--method--fsharp-.md)|Tests if an element is in the domain of the map.|  
|[Count](../vs140/map.count--key--value--property--fsharp-.md)|The number of bindings in the map.|  
|[IsEmpty](../vs140/map.isempty--key--value--property--fsharp-.md)|Returns true if there are no bindings in the map.|  
|[Item](../vs140/map.item--key--value--property--fsharp-.md)|Lookup an element in the map. Raise <xref:System.Collections.Generic.KeyNotFoundException*> if no binding exists in the map.|  
|[Remove](../vs140/map.remove--key--value--method--fsharp-.md)|Removes an element from the domain of the map. No exception is raised if the element is not present.|  
|[TryFind](../vs140/map.tryfind--key--value--method--fsharp-.md)|Lookup an element in the map, returning a `Some` value if the element is in the domain of the map and `None` if not.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)