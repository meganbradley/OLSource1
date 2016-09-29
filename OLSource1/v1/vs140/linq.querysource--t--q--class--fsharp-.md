---
title: "Linq.QuerySource&lt;&#39;T,&#39;Q&gt; Class (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Linq.QuerySource``2.#ctor"
dev_langs: 
  - "FSharp"
ms.assetid: 873589c1-c5dc-47d9-8abf-fee7258dfb00
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linq.QuerySource&lt;&#39;T,&#39;Q&gt; Class (F#)
A partial input or result in an F# query.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<NoComparison>]  
[<NoEquality>]  
[<Sealed>]  
type QuerySource<'T,'Q> =  
 class  
  new QuerySource : seq<'T> -> QuerySource<'T,'Q>  
  member this.Source : seq<'T>  
 end  
```  
  
## Remarks  
 This type is used to implement the query expression functionality and should not be used directly.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/linq.querysource--t--q--constructor--fsharp-.md)|Create a new QuerySource object from an enumerable sequence.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Source](../vs140/querysource.source--t--q--property--fsharp-.md): seq<'T>|The enumerable sequence that is associated with a query.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)