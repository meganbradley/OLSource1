---
title: "FSharpValue.MakeRecord Method (F#)"
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
  - "FSharpValue.MakeRecord"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.MakeRecord"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MakeRecord method [F#]"
  - "FSharpValue.MakeRecord method [F#]"
ms.assetid: ad2aac30-6120-4cc9-a5cf-046ca43d53b9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.MakeRecord Method (F#)
Creates an instance of a record type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: \<xref:System.Type*>  
  
 The type of record to make.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The array of values to initialize the record.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: \<xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags for the record.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input type is not a record type.|  
  
## Return Value  
 The created record.  
  
## Remarks  
 Assumes the given input is a record type.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)