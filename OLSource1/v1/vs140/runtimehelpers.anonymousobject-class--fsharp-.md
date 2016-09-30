---
title: "RuntimeHelpers.AnonymousObject Class (F#)"
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
  - "Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AnonymousObject class [F#]"
ms.assetid: e7deda0a-f18d-44a0-a5b9-2c7e34107f5f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeHelpers.AnonymousObject Class (F#)
A type that represents an aggregate object. This type supports the infrastructure for F# query expressions and is for internal use only.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.RuntimeHelpers  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type AnonymousObject<'T1 ... 'T8> =  
 class  
  new AnonymousObject : unit -> AnonymousObject<'T1 ... 'T8>  
  member this.Item1 : 'T1 with get, set  member this.Item2 : 'T2 with get, set  ...  
 end  
```  
  
## Remarks  
 This type is overloaded by arity. There are eight separate generic types with the same name, each with a different number of generic type parameters, depending on the number of items in the aggregate.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/runtimehelpers.anonymousobject-constructor--fsharp-.md)|Creates a new instance of the type.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Item1 to Item8](../vs140/anonymousobject.item1-to-item8-properties--fsharp-.md)|Provides access to the aggregated objects.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq.RuntimeHelpers Namespace (F#)](../vs140/microsoft.fsharp.linq.runtimehelpers-namespace--fsharp-.md)   
 [Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)