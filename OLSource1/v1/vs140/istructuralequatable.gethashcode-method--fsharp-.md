---
title: "IStructuralEquatable.GetHashCode Method (F#)"
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
  - IStructuralEquatable.GetHashCode
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - System.Collections.IStructuralEquatable.GetHashCode
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - IStructuralEquatable.GetHashCode method [F#]
  - GetHashCode method [F#]
ms.assetid: 1aeeb426-e8a9-4a4a-8151-55f1073a86c2
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IStructuralEquatable.GetHashCode Method (F#)
Returns a hash code for the current instance.  
  
 **Namespace/Module Path**: System.Collections  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.GetHashCode : IEqualityComparer -> int  
  
// Usage:  
iStructuralEquatable.GetHashCode (comparer)  
```  
  
#### Parameters  
 `comparer`  
 Type: <xref:System.Collections.IEqualityComparer?qualifyHint=False>  
  
 An object that computes the hash code of the current object.  
  
## Return Value  
 The hash code for the current instance.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.Collections.IStructuralEquatable.GetHashCode?qualifyHint=False>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Collections.IStructuralEquatable Interface (F#)](../vs140/collections.istructuralequatable-interface--fsharp-.md)   
 [System.Collections Namespace (F#)](../vs140/system.collections-namespace--fsharp-.md)