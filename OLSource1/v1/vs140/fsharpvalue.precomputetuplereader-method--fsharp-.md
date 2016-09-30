---
title: "FSharpValue.PreComputeTupleReader Method (F#)"
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
  - "FSharpValue.PreComputeTupleReader"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeTupleReader"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.PreComputeTupleReader method [F#]"
  - "PreComputeTupleReader method [F#]"
ms.assetid: da980eb2-1ebd-466c-8c3f-f241549961db
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeTupleReader Method (F#)
Generates a function for reading the values of a particular tuple type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: \<xref:System.Type*>  
  
 The tuple type to read.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the given type is not a tuple type.|  
  
## Return Value  
 A function to read values of the given tuple type.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)