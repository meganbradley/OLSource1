---
title: "List.find&lt;&#39;T&gt; Function (F#)"
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
  - "List.find<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Find``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.find function [F#]"
  - "find function [F#]"
ms.assetid: 0594593e-9c75-44c1-8f5a-a37b2e561c06
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.find&lt;&#39;T&gt; Function (F#)
Returns the first element for which the given function returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Raises \<xref:System.Collections.Generic.KeyNotFoundException*> if no such element exists.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown if the predicate evaluates to false for all the elements of the list.|  
  
## Return Value  
 The first element that satisfies the predicate.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#8](../vs140/codesnippet/FSharp/list.find--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **5**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)