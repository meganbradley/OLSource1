---
title: "Microsoft.FSharp.Linq Namespace (F#)"
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
  - "Microsoft.FSharp.Linq"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Microsoft.FSharp.Linq namespace [F#]"
ms.assetid: 4765b4e8-4006-4d8c-a405-39c218b3c82d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft.FSharp.Linq Namespace (F#)
This namespace includes types that support F# query expressions. This includes functions and operators for working with nullable values frequently encountered when working with databases, and the types that are used to implement the query expressions language feature. For more information, see [Query Expressions (F#)](../VS_csharp/query-expressions--fsharp-.md).  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
namespace Microsoft.FSharp.Linq  
```  
  
## Namespaces  
  
|Namespace|Description|  
|---------------|-----------------|  
|namespace Microsoft.FSharp.Linq.QueryRunExtensions|Contains modules and functions that support the F# query syntax.|  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [Nullable](../VS_csharp/linq.nullable-module--fsharp-.md)|Functions for converting nullable values.|  
|module [NullableOperators](../VS_csharp/linq.nullableoperators-module--fsharp-.md)|Operators for working with nullable values.|  
  
## Type Definitions  
  
|Type|Description|  
|----------|-----------------|  
|type [QueryBuilder](../VS_csharp/linq.querybuilder-class--fsharp-.md)|The type used to support the F# query syntax.|  
|type [QuerySource<'T,'Q>](../VS_csharp/linq.querysource--t--q--class--fsharp-.md)|A partial input or result in an F# query.|  
  
## See Also  
 [F# Library Reference](../VS_csharp/fsharp-core-library-reference.md)   
 [Nullable Operators (F#)](../VS_csharp/nullable-operators--fsharp-.md)