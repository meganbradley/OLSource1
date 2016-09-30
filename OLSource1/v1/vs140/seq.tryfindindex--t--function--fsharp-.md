---
title: "Seq.tryFindIndex&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.tryFindIndex<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.TryFindIndex``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "tryFindIndex function [F#]"
  - "Seq.tryFindIndex function [F#]"
ms.assetid: c357b221-edf6-4f68-bf40-82a3156d945a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.tryFindIndex&lt;&#39;T&gt; Function (F#)
Attempts to find the first element that satisfies a given predicate, and returns the index of the matching element.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function that evaluates to a Boolean when given an item in the sequence.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 Returns the index of the first element in the sequence that satisfies the given predicate, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if no such element exists.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)