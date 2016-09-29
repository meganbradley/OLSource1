---
title: "IStructuralComparable.CompareTo Method (F#)"
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
  - "IStructuralComparable.CompareTo"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Collections.IStructuralComparable.CompareTo"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CompareTo method [F#]"
  - "IStructuralComparable.CompareTo method [F#]"
ms.assetid: 0aa85582-a8a5-4cdb-a75e-e91bab0e4139
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IStructuralComparable.CompareTo Method (F#)
Determines whether the current object precedes, occurs in the same position as, or follows another object in the sort order.  
  
 **Namespace/Module Path**: System.Collections  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.CompareTo : obj * IComparer -> int  
  
// Usage:  
iStructuralComparable.CompareTo (obj, comparer)  
```  
  
#### Parameters  
 `obj`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The object to compare with the current instance.  
  
 `comparer`  
 Type: <xref:System.Collections.IComparer*>  
  
 An object that performs comparisons.  
  
## Return Value  
 An integer that indicates the relationship of the current object to the target object.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.Collections.IStructuralComparable.CompareTo*>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Collections.IStructuralComparable Interface (F#)](../vs140/collections.istructuralcomparable-interface--fsharp-.md)   
 [System.Collections Namespace (F#)](../vs140/system.collections-namespace--fsharp-.md)