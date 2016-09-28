---
title: "List.rev&lt;&#39;T&gt; Function (F#)"
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
  - "List.rev<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Reverse``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.rev function [F#]"
  - "Reverse function [F#]"
  - "List.Reverse function [F#]"
  - "rev function [F#]"
ms.assetid: 69d09a83-3cc3-4ddf-9535-61f9f0a087e6
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.rev&lt;&#39;T&gt; Function (F#)
Returns a new list with the elements in reverse order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.rev : 'T list -> 'T list  
  
// Usage:  
List.rev list  
```  
  
#### Parameters  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The reversed list.  
  
## Remarks  
 This function is named `Reverse` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates how to use `List.rev`.  
  
 [!code[FsLists#53](../vs140/codesnippet/FSharp/list.rev--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[10; 9; 8; 7; 6; 5; 4; 3; 2; 1]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)