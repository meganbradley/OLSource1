---
title: "FSharpValue.MakeTuple Method (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - FSharpValue.MakeTuple
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Reflection.FSharpValue.MakeTuple
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - FSharpValue.MakeTuple method [F#]
  - MakeTuple method [F#]
ms.assetid: 88678b0e-3669-4872-8f8f-c5343c4decfc
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# FSharpValue.MakeTuple Method (F#)
Creates an instance of a tuple type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member MakeTuple : obj [] * Type -> obj  
  
// Usage:  
FSharpValue.MakeTuple (tupleElements, tupleType)  
```  
  
#### Parameters  
 `tupleElements`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The array of tuple fields.  
  
 `tupleType`  
 Type: <xref:System.Type?qualifyHint=False>  
  
 The tuple type to create.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException?qualifyHint=False>|Thrown if no elements are given.|  
  
## Return Value  
 An instance of the tuple type with the given elements.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)