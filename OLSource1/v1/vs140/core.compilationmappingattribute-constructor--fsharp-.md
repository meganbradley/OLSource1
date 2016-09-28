---
title: "Core.CompilationMappingAttribute Constructor (F#)"
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
  - "CompilationMappingAttribute.CompilationMappingAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilationMappingAttribute.#ctor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CompilationMappingAttribute constructor [F#]"
ms.assetid: 979300ad-606c-48b0-b6f1-aa31fcca2600
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CompilationMappingAttribute Constructor (F#)
Creates an instance of the attribute.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
new CompilationMappingAttribute : SourceConstructFlags * int * int -> CompilationMappingAttribute  
new CompilationMappingAttribute : SourceConstructFlags * int -> CompilationMappingAttribute  
new CompilationMappingAttribute : SourceConstructFlags -> CompilationMappingAttribute  
  
// Usage:  
new CompilationMappingAttribute (sourceConstructFlags, variantNumber, sequenceNumber)  
new CompilationMappingAttribute (sourceConstructFlags, sequenceNumber)  
new CompilationMappingAttribute (sourceConstructFlags)  
```  
  
#### Parameters  
 `sourceConstructFlags`  
 Type: [SourceConstructFlags](../vs140/core.sourceconstructflags-enumeration--fsharp-.md)  
  
 Indicates the type of source construct.  
  
 `variantNumber`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 `sequenceNumber`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
## Return Value  
 A new `CompilationMappingAttribute` instance.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Core.CompilationMappingAttribute Class (F#)](../vs140/core.compilationmappingattribute-class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)