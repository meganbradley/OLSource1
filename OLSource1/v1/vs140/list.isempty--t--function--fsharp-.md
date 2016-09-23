---
title: "List.isEmpty&lt;&#39;T&gt; Function (F#)"
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
  - List.isEmpty<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ListModule.IsEmpty``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - isEmpty function [F#]
  - List.isEmpty function [F#]
ms.assetid: a7941d44-9e92-427c-b806-c378f4558107
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# List.isEmpty&lt;&#39;T&gt; Function (F#)
Tests whether a list is empty.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
List.isEmpty : 'T list -> bool  
  
// Usage:  
List.isEmpty list  
```  
  
#### Parameters  
 `list`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 `true` if the list is empty. Otherwise, returns `false`.  
  
## Remarks  
 This function is named `IsEmpty` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `List.isEmpty`.  
  
 [!code[FsLists#47](../vs140/codesnippet/FSharp/list.isempty--t--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **This list contains the following elements:**  
**"test1" "test2"**   
**There are no elements in this list.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)