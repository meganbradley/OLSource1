---
title: "Operators.hash&lt;&#39;T&gt; Function (F#)"
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
  - "Operators.hash<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Hash``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "hash function [F#]"
  - "Operators.hash function [F#]"
ms.assetid: a83c0432-919e-407d-9ffc-8cf34fbc6daa
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.hash&lt;&#39;T&gt; Function (F#)
A generic hash function, designed to return equal hash values for items that are equal according to the `=` operator. By default it will use structural hashing for F# union, record and tuple types, hashing the complete contents of the type. The exact behavior of the function can be adjusted on a type-by-type basis by implementing <xref:System.Object.GetHashCode*> for each type.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.Operators  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
hash : 'T -> int (requires equality)  
  
// Usage:  
hash obj  
```  
  
#### Parameters  
 `obj`  
 Type: `'T`  
  
 The input object.  
  
## Return Value  
 The computed hash.  
  
## Remarks  
 This function is named `Hash` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following examples shows the use of the hash function to generate hashes for a variety of data types.  
  
 [!code[FsSamples101#1010](../vs140/codesnippet/FSharp/operators.hash--t--function--fsharp-_1.fs)]  
  
 **hash(1) : 1**  
**hash(2) : 2**  
**hash("1") : -842352753**  
**hash("2") : -842352754**  
**hash("abb") : 2103075711**  
**hash("aBc") : 539088922**  
**hash(<null\>) : 0**  
**hash(Some 1) : -1640531462**  
**hash(Some 0) : -1640531463**  
**hash([1; 2; 3]) : 1956583134**  
**hash([1; 2; 3; 4; 5; 6; 7; 8]) : 922428386**  
**hash([1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11]) : 1771492728**  
**hash([1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14; 15]) : -926589492**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)