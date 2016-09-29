---
title: "UnionCaseInfo.GetCustomAttributes Method (F#)"
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
  - "UnionCaseInfo.GetCustomAttributes"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.UnionCaseInfo.GetCustomAttributes"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GetCustomAttributes method [F#]"
  - "UnionCaseInfo.GetCustomAttributes method [F#]"
ms.assetid: ce087bae-8d3b-4d64-b9a5-0b37e6af2b64
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UnionCaseInfo.GetCustomAttributes Method (F#)
Returns the custom attributes associated with the case matching the given attribute type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
member this.GetCustomAttributes : Type -> obj []  
member this.GetCustomAttributes : unit -> obj []  
  
// Usage:  
unionCaseInfo.GetCustomAttributes (attributeType)  
unionCaseInfo.GetCustomAttributes ()  
```  
  
#### Parameters  
 `attributeType`  
 Type: <xref:System.Type*>  
  
 The type of attributes to return.  
  
## Return Value  
 An array of custom attributes.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.UnionCaseInfo Class (F#)](../vs140/reflection.unioncaseinfo-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)