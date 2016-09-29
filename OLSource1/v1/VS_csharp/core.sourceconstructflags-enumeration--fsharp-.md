---
title: "Core.SourceConstructFlags Enumeration (F#)"
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
  - "Core.SourceConstructFlags"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.SourceConstructFlags"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SourceConstructFlags.RecordType enumeration case [F#]"
  - "SourceConstructFlags.KindMask enumeration case [F#]"
  - "SourceConstructFlags.UnionCase enumeration case [F#]"
  - "SourceConstructFlags.SumType enumeration case [F#]"
  - "SourceConstructFlags.Exception enumeration case [F#]"
  - "SourceConstructFlags.Closure enumeration case [F#]"
  - "SourceConstructFlags.Value enumeration case [F#]"
  - "SourceConstructFlags enumeration [F#]"
  - "SourceConstructFlags.Module enumeration case [F#]"
  - "SourceConstructFlags.NonPublicRepresentation enumeration case [F#]"
  - "SourceConstructFlags.ObjectType enumeration case [F#]"
  - "SourceConstructFlags.Field enumeration case [F#]"
  - "SourceConstructFlags.None enumeration case [F#]"
ms.assetid: 6da6a0c5-25d0-407d-8536-70182654d738
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.SourceConstructFlags Enumeration (F#)
Indicates the relationship between a compiled entity in a .NET Framework binary and an element in F# source code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type SourceConstructFlags =  
 | None = 0  
 | SumType = 1  
 | RecordType = 2  
 | ObjectType = 3  
 | Field = 4  
 | Exception = 5  
 | Closure = 6  
 | Module = 7  
 | UnionCase = 8  
 | Value = 9  
 | KindMask = 31  
 | NonPublicRepresentation = 32  
```  
  
## Remarks  
 The following table shows the possible values and their meaning.  
  
|Value|Description|  
|-----------|-----------------|  
|None|Indicates that the compiled entity has no relationship to an element in F# source code.|  
|SumType|Indicates that the compiled entity is part of the representation of an F# union type declaration.|  
|RecordType|Indicates that the compiled entity is part of the representation of an F# record type declaration.|  
|ObjectType|Indicates that the compiled entity is part of the representation of an F# class or other object type declaration.|  
|Field|Indicates that the compiled entity is part of the representation of an F# record or union case declaration.|  
|Exception|Indicates that the compiled entity is part of the representation of an F# exception declaration.|  
|Closure|Indicates that the compiled entity is part of the representation of an F# closure.|  
|Module|Indicates that the compiled entity is part of the representation of an F# module declaration.|  
|UnionCase|Indicates that the compiled entity is part of the representation of an F# union case declaration.|  
|Value|Indicates that the compiled entity is part of an F# value declaration.|  
|KindMask|The mask of values related to the kind of the compiled entity.|  
|NonPublicRepresentation|Indicates that the compiled entity had private or internal representation in F# source code.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)