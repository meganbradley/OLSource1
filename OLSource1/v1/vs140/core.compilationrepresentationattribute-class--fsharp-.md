---
title: "Core.CompilationRepresentationAttribute Class (F#)"
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
  - "Core.CompilationRepresentationAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilationRepresentationAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CompilationRepresentation attribute [F#]"
  - "CompilationRepresentationAttribute class [F#]"
ms.assetid: 44f25078-a62b-4fcc-9143-344e0af97399
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CompilationRepresentationAttribute Class (F#)
This attribute is used to adjust the runtime representation for a type. For example, it may be used to note that the `null` representation may be used for a type. This affects how some constructs are compiled.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.All, AllowMultiple = false)>]  
[<Sealed>]  
type CompilationRepresentationAttribute =  
 class  
  new CompilationRepresentationAttribute : CompilationRepresentationFlags -> CompilationRepresentationAttribute  
  member this.Flags :  CompilationRepresentationFlags  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, CompilationRepresentation.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.compilationrepresentationattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Flags](../vs140/compilationrepresentationattribute.flags-property--fsharp-.md)|Indicates one or more adjustments to the compiled representation of an F# type or member|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)