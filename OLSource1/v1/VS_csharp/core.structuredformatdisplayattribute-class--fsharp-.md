---
title: "Core.StructuredFormatDisplayAttribute Class (F#)"
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
  - "Core.StructuredFormatDisplayAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StructuredFormatDisplayAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "StructuredFormatDisplayAttribute class [F#]"
  - "StructuredFormatDisplay attribute [F#]"
ms.assetid: 1a860822-bc8c-4137-9f25-e95483b5b781
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.StructuredFormatDisplayAttribute Class (F#)
This attribute is used to mark how a type is displayed by default when using `%A`[printf](../VS_csharp/core.printf-module--fsharp-.md) formatting patterns and other two-dimensional text-based display layouts. In this version of F# the only valid values are of the form `PreText {PropertyName} PostText`. The property name indicates a property to evaluate and to display instead of the object itself.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Class ||| AttributeTargets.Interface ||| AttributeTargets.Struct ||| AttributeTargets.Delegate ||| AttributeTargets.Enum, AllowMultiple = false)>]  
[<Sealed>]  
type StructuredFormatDisplayAttribute =  
 class  
  new StructuredFormatDisplayAttribute : string -> StructuredFormatDisplayAttribute  
  member this.Value :  string  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `StructuredFormatDisplay`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../VS_csharp/core.structuredformatdisplayattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Value](../VS_csharp/structuredformatdisplayattribute.value-property--fsharp-.md)|Indicates the text to display by default when objects of this type are displayed using `%A`[printf](../VS_csharp/core.printf-module--fsharp-.md) formatting patterns and other two-dimensional text-based display layouts.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)