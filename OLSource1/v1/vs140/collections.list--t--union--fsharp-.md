---
title: "Collections.List&lt;&#39;T&gt; Union (F#)"
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
  - "Collections.List<'T> Union (F#)"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpList`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpList union [F#]"
  - "List union [F#]"
  - "[] union case [F#]"
  - ":: union case [F#]"
ms.assetid: c627b668-477b-4409-91ed-06d7f1b3e4a7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.List&lt;&#39;T&gt; Union (F#)
The type of immutable singly-linked lists.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Use the constructors <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (infix) to create values of this type, or the notation <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Use the values in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> module to manipulate values of this type, or pattern match against the values directly.  
  
 This type is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the .NET assembly. If accessing the type from a .NET language other than F#, or through reflection, use this name.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Head](../vs140/list.head--t--property--fsharp-.md)|Gets the first element of the list.|  
|[IsEmpty](../vs140/list.isempty--t--property--fsharp-.md)|Gets a value indicating if the list contains no entries.|  
|[Item](../vs140/list.item--t--property--fsharp-.md)|Gets the element of the list at the given position.|  
|[Length](../vs140/list.length--t--property--fsharp-.md)|Gets the number of items contained in the list.|  
|[Tail](../vs140/list.tail--t--property--fsharp-.md)|Gets the tail of the list, which is a list containing all the elements of the list, excluding the first element.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[Cons](../vs140/list.cons--t--method--fsharp-.md)|Returns a list with the first argument as its first element and the second argument as its subsequent elements.|  
|[Empty](../vs140/empty--t--property--fsharp-.md)|Returns an empty list of a particular type.|  
  
## Union Cases  
  
|Case|Description|  
|----------|-----------------|  
|( :: ) of 'T * 'T list|The cons operator.|  
|( [] )|The empty list.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)   
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)