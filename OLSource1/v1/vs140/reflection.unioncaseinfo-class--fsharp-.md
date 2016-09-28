---
title: "Reflection.UnionCaseInfo Class (F#)"
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
  - "Reflection.UnionCaseInfo"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.UnionCaseInfo"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "UnionCaseInfo class [F#]"
ms.assetid: d97eb038-9521-4e20-89b4-dd0cd92d7221
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reflection.UnionCaseInfo Class (F#)
Represents a case of a discriminated union type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
type UnionCaseInfo =  
 class  
  member this.GetCustomAttributes : Type -> obj []  
  member this.GetCustomAttributes : unit -> obj []  member this.GetCustomAttributesData : unit -> IList<CustomAttributeData>  
  member this.GetFields : unit -> PropertyInfo []  
  member this.DeclaringType :  Type  
  member this.Name :  string  
  member this.Tag :  int  
 end  
```  
  
## Remarks  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[DeclaringType](../vs140/unioncaseinfo.declaringtype-property--fsharp-.md)|The type in which the case occurs.|  
|[GetCustomAttributes](../vs140/unioncaseinfo.getcustomattributes-method--fsharp-.md)|Returns the custom attributes associated with the case matching the given attribute type.|  
|[GetCustomAttributesData](../vs140/unioncaseinfo.getcustomattributesdata-method--fsharp-.md)|Returns the custom attributes data associated with the case.|  
|[GetFields](../vs140/unioncaseinfo.getfields-method--fsharp-.md)|The fields associated with the case, represented by a <xref:System.Reflection.PropertyInfo*>.|  
|[Name](../vs140/unioncaseinfo.name-property--fsharp-.md)|The name of the case.|  
|[Tag](../vs140/unioncaseinfo.tag-property--fsharp-.md)|The integer tag for the case.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)