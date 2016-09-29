---
title: "List.choose&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "List.choose<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Choose``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.choose function [F#]"
  - "choose function [F#]"
ms.assetid: 2e21d3fb-ce35-4824-8a57-c4404616093d
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.choose&lt;&#39;T,&#39;U&gt; Function (F#)
Applies the given function `f` to each element `x` of the list. Returns the list comprised of the results for each element where the function returns `Some(f(x))`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.choose : ('T -> 'U option) -> 'T list -> 'U list  
  
// Usage:  
List.choose chooser list  
```  
  
#### Parameters  
 `chooser`  
 Type: `'T -> 'U`[option](../VS_csharp/core.option--t--union--fsharp-.md)  
  
 The function to generate options from the elements.  
  
 `list`  
 Type: `'T`[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The list comprising the values selected from the chooser function.  
  
## Remarks  
 This function is named `Choose` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates the use of `List.choose` to select capitalized words out of a list of words.  
  
 [!code[FsLists#25](../VS_csharp/codesnippet/FSharp/list.choose--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **["Rome's"; "Bob's"]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../VS_csharp/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)