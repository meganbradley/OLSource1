---
title: "Core.CompilationMappingAttribute Class (F#)"
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
  - "Core.CompilationMappingAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilationMappingAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CompilationMappingAttribute class [F#]"
  - "CompilationMapping attribute [F#]"
ms.assetid: 59f72aa6-2c04-4318-8243-02875407da29
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CompilationMappingAttribute Class (F#)
This attribute is inserted automatically by the F# compiler to tag types and methods in the generated Common Language Infrastructure (CLI) code with flags indicating the correspondence with original source constructs. It is used by the functions in the [Microsoft.FSharp.Reflection](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md) namespace to reverse-map compiled constructs to their original forms. It is not intended for use from user code.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.All, AllowMultiple = false)>]  
[<Sealed>]  
type CompilationMappingAttribute =  
 class  
  new CompilationMappingAttribute : SourceConstructFlags * int * int -> CompilationMappingAttribute  
  new CompilationMappingAttribute : SourceConstructFlags * int -> CompilationMappingAttribute  
  new CompilationMappingAttribute : SourceConstructFlags -> CompilationMappingAttribute  
  member this.SequenceNumber :  int  
  member this.SourceConstructFlags :  SourceConstructFlags  
  member this.VariantNumber :  int  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `CompilationMapping`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.compilationmappingattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[SequenceNumber](../vs140/compilationmappingattribute.sequencenumber-property--fsharp-.md)|Indicates the sequence number of the entity, if any, in a linear sequence of elements with F# source code.|  
|[SourceConstructFlags](../vs140/compilationmappingattribute.sourceconstructflags-property--fsharp-.md)|Indicates the relationship between the compiled entity and F# source code.|  
|[VariantNumber](../vs140/compilationmappingattribute.variantnumber-property--fsharp-.md)|Indicates the variant number of the entity, if any, in a linear sequence of elements with F# source code.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)