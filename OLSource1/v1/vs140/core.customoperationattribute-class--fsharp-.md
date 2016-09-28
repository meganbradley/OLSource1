---
title: "Core.CustomOperationAttribute Class (F#)"
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
  - "Microsoft.FSharp.Core.CustomOperationAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CustomOperationAttribute class [F#]"
ms.assetid: 199f3927-79df-484b-ba66-85f58cc49b19
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CustomOperationAttribute Class (F#)
Indicates that a member on a computation builder type is a custom query operator, and indicates the name of that operator.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false)>][<Sealed>]type CustomOperationAttribute = class  new CustomOperationAttribute : string -> CustomOperationAttribute  member this.AllowIntoPattern : bool with get, set  member this.IsLikeGroupJoin : bool with get, set  member this.IsLikeJoin : bool with get, set  member this.IsLikeZip : bool with get, set  member this.MaintainsVariableSpace : bool with get, set  member this.MaintainsVariableSpaceUsingBind : bool with get, set  member this.Name : string  member this.IsLikeGroupJoin : bool with get, set  member this.IsLikeJoin : bool with get, set  member this.IsLikeZip : bool with get, set  member this.JoinConditionWord : string with get, set  member this.MaintainsVariableSpace : bool with get, set  member this.MaintainsVariableSpaceUsingBind  : bool with get, set end  
```  
  
## Remarks  
 You can also use the short form of the name, `CustomOperation`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.customoperationattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[AllowIntoPattern](../vs140/customoperationattribute.allowintopattern-property--fsharp-.md) : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md) with get, set|Indicates if the custom operation supports the use of `into` immediately after the use of the operation in a query or other computation expression to consume the results of the operation.|  
|[IsLikeGroupJoin](../vs140/customoperationattribute.islikegroupjoin-property--fsharp-.md) : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md) with get, set|Indicates if the custom operation is an operation similar to a group join in a sequence computation, in that it supports two inputs and a correlation constraint, and generates a group.|  
|[IsLikeJoin](../vs140/customoperationattribute.islikejoin-property--fsharp-.md) : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md) with get, set|Indicates if the custom operation is an operation similar to a join in a sequence computation, in that it supports two inputs and a correlation constraint.|  
|[IsLikeZip](../vs140/customoperationattribute.islikezip-property--fsharp-.md) : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md) with get, set|Indicates if the custom operation is an operation similar to a zip in a sequence computation, in that it supports two inputs.|  
|[JoinConditionWord](../vs140/customoperationattribute.joinconditionword-property--fsharp-.md) : string|Indicates the name used for the "on" part of the custom query operator for join-like operators.|  
|[MaintainsVariableSpace](../vs140/customoperationattribute.maintainsvariablespace-property--fsharp-.md) : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md) with get, set|Indicates if the custom operation maintains the variable space of the query of computation expression.|  
|[MaintainsVariableSpaceUsingBind](../vs140/customoperationattribute.maintainsvariablespaceusingbind-property--fsharp-.md) : [bool](../vs140/core.bool-type-abbreviation--fsharp-.md) with get, set|Indicates if the custom operation maintains the variable space of the query of computation expression through the use of a bind operation.|  
|[Name](../vs140/customoperationattribute.name-property--fsharp-.md) : [string](../vs140/core.string-type-abbreviation--fsharp-.md)|The name of the custom operation when used in a query or other computation expression.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)