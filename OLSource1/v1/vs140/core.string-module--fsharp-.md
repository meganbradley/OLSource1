---
title: "Core.String Module (F#)"
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
  - "Core.String"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "String module [F#]"
  - "StringModule module [F#]"
ms.assetid: a5fda9cd-d71f-4271-a6a4-ab4caa0be550
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.String Module (F#)
Functional programming operators for string processing. Further string operations are available via the member functions on strings and other functionality in \<xref:System.String*> and \<xref:System.Text.RegularExpressions.Regex*> types.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module String  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[collect](../vs140/string.collect-function--fsharp-.md)  `: (char -> string) -> string -> string`|Creates a new string whose characters are the results of applying a specified function to each of the characters of the input string and concatenating the resulting strings.|  
|[concat](../vs140/string.concat-function--fsharp-.md)  `: string -> seq<string> -> string`|Returns a new string made by concatenating the given strings with a separator.|  
|[exists](../vs140/string.exists-function--fsharp-.md)  `: (char -> bool) -> string -> bool`|Tests if any character of the string satisfies the given predicate.|  
|[forall](../vs140/string.forall-function--fsharp-.md)  `: (char -> bool) -> string -> bool`|Tests if all characters in the string satisfy the given predicate.|  
|[init](../vs140/string.init-function--fsharp-.md)  `: int -> (int -> string) -> string`|Creates a new string whose characters are the results of applying a specified function to each index and concatenating the resulting strings.|  
|[iter](../vs140/string.iter-function--fsharp-.md)  `: (char -> unit) -> string -> unit`|Applies a specified function to each character in the string.|  
|[iteri](../vs140/string.iteri-function--fsharp-.md)  `: (int -> char -> unit) -> string -> unit`|Applies a specified function to the index of each character in the string and the character itself.|  
|[length](../vs140/string.length-function--fsharp-.md)  `: string -> int`|Returns the length of the string.|  
|[map](../vs140/string.map-function--fsharp-.md)  `: (char -> char) -> string -> string`|Creates a new string whose characters are the results of applying a specified function to each of the characters of the input string.|  
|[mapi](../vs140/string.mapi-function--fsharp-.md)  `: (int -> char -> char) -> string -> string`|Creates a new string whose characters are the results of applying a specified function to each character and index of the input string.|  
|[replicate](../vs140/string.replicate-function--fsharp-.md)  `: int -> string -> string`|Returns a string by concatenating a specified number of instances of a string.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)