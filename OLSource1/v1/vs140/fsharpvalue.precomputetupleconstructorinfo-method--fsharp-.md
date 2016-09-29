---
title: "FSharpValue.PreComputeTupleConstructorInfo Method (F#)"
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
  - "FSharpValue.PreComputeTupleConstructorInfo"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeTupleConstructorInfo"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PreComputeTupleConstructorInfo method [F#]"
  - "FSharpValue.PreComputeTupleConstructorInfo method [F#]"
ms.assetid: 846fd770-b6a2-47b0-a295-cfa5cd86b7c4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeTupleConstructorInfo Method (F#)
Gets a method that constructs objects of the given tuple type. For small tuples, no additional type will be returned.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeTupleConstructorInfo : Type -> ConstructorInfo * Type option  
  
// Usage:  
FSharpValue.PreComputeTupleConstructorInfo (tupleType)  
```  
  
#### Parameters  
 `tupleType`  
 Type: <xref:System.Type*>  
  
 The input tuple type.  
  
## Return Value  
 The description of the tuple type constructor and an optional extra type for large tuples.  
  
## Remarks  
 For large tuples, an additional type is returned indicating that a nested encoding has been used for the tuple type. In this case the suffix portion of the tuple type has the given type and an object of this type must be created and passed as the last argument to the <xref:System.Reflection.ConstructorInfo*>. A recursive call to `PreComputeTupleConstructorInfo` can be used to determine the constructor for that the suffix type.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)