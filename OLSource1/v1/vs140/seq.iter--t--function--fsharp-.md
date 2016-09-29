---
title: "Seq.iter&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.iter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Iterate``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.Iterate function [F#]"
  - "Iterate function [F#]"
  - "iter function [F#]"
  - "Seq.iter function [F#]"
ms.assetid: 85690abf-48da-4668-afe3-6bd64fce30b7
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.iter&lt;&#39;T&gt; Function (F#)
Applies the given function to each element of the collection.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.iter : ('T -> unit) -> seq<'T> -> unit  
  
// Usage:  
Seq.iter action source  
```  
  
#### Parameters  
 `action`  
 Type: `'T ->`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 A function to apply to each element of the sequence.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Remarks  
 This function is named `Iterate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example illustrates the use of `Seq.iter`.  
  
 [!code[FsSamples101#1003](../vs140/codesnippet/FSharp/seq.iter--t--function--fsharp-_1.fs)]  
  
 **Seq.iter: (1, 1) (2, 4) (3, 9) (4, 16) (5, 25)**   
## Example  
 The following example illustrates the use of `Seq.iter` to work with CSV (Comma-Separated Value) files.  
  
 [!code[FsSamples101#2003](../vs140/codesnippet/FSharp/seq.iter--t--function--fsharp-_2.fs)]  
  
 **-------Enumeration 1------**  
**line System.String[]**  
**line System.String[]**  
**-------Enumeration 2------**  
**line has 8 entries**  
**line has 7 entries**  
**-------Enumeration 3------**  
**lengths of entries: [&#124;7; 0; 6; 0; 6; 5; 0; 1&#124;]**  
**lengths of entries: [&#124;5; 0; 6; 0; 4; 0; 2&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)