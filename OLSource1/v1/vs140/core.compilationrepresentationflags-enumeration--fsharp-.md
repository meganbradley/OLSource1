---
title: "Core.CompilationRepresentationFlags Enumeration (F#)"
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
  - "Core.CompilationRepresentationFlags"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilationRepresentationFlags"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CompilationRepresentationFlags.None enumeration case [F#]"
  - "CompilationRepresentationFlags.UseNullAsTrueValue enumeration case [F#]"
  - "CompilationRepresentationFlags.Event enumeration case [F#]"
  - "CompilationRepresentationFlags.ModuleSuffix enumeration case [F#]"
  - "CompilationRepresentationFlags.Static enumeration case [F#]"
  - "CompilationRepresentationFlags enumeration [F#]"
ms.assetid: e32f2b3e-34f0-4e03-8bcc-05ed535c0b51
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CompilationRepresentationFlags Enumeration (F#)
Indicates one or more adjustments to the compiled representation of an F# type or member.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Flags>]  
type CompilationRepresentationFlags =  
 | None = 0  
 | Static = 1  
 | Instance = 2  
 | ModuleSuffix = 4  
 | UseNullAsTrueValue = 8  
 | Event  
```  
  
## Remarks  
 The following table shows the possible values and their meaning.  
  
|Value|Description|  
|-----------|-----------------|  
|None|No special compilation representation.|  
|Static|Compile an instance member as static.|  
|Instance|Compile a member as instance even if null is used as a representation for this type.|  
|ModuleSuffix|Append `Module` to the end of a module whose name clashes with a type name in the same namespace.|  
|UseNullAsTrueValue|Permit the use of null as a representation for nullary discriminators in a discriminated union.|  
|Event|Compile a property as a Common Language Infrastructure (CLI) event.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)