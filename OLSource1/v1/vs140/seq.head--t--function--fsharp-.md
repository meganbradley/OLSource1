---
title: "Seq.head&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.hd<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Head``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "head function [F#]"
  - "Seq.head function [F#]"
ms.assetid: 75a3053e-4c20-4f6e-8347-3673c147517c
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.head&lt;&#39;T&gt; Function (F#)
Returns the first element of the sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input does not have any elements.|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The first element of the sequence.  
  
## Remarks  
 The first element of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> sequence is evaluated at each call. To avoid this reevaluation, you can create a cached version of a sequence by calling [Seq.cache](../vs140/seq.cache--t--function--fsharp-.md).  
  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [!code[FsSequences#41](../vs140/codesnippet/FSharp/seq.head--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)