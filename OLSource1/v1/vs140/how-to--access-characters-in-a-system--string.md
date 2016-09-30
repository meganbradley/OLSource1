---
title: "How to: Access Characters in a System::String"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "characters [C++], accessing in System::String"
  - "examples [C++], strings"
  - "strings [C++], accessing characters"
ms.assetid: cfc89756-aef3-4988-907e-fb236dcb7087
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access Characters in a System::String
You can access characters of a \<xref:System.String*> object for high-performance calls to unmanaged functions that take <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> strings. The method yields an interior pointer to the first character of the \<xref:System.String*> object. This pointer can be manipulated directly or pinned and passed to a function expecting an ordinary <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> string.  
  
## Example  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a \<xref:System.Char*>, which is an interior pointer (also known as a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). As such, it is subject to garbage collection. You don't have to pin this pointer unless you're going to pass it to a native function.  
  
 Consider the following code.  Pinning is not needed because <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an interior pointer, and if the garbage collector moves the string it points to, it will also update <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Without a [pin_ptr](../vs140/pin_ptr--c---cli-.md), the code will work and not have the potential performance hit caused by pinning.  
  
 If you pass <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to a native function, then it must be a pinning pointer; the garbage collector will not be able to update any pointers on the unmanaged stack frame.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **abcdefg**   
## Example  
 This example shows where pinning is needed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **7**   
## Example  
 An interior pointer has all the properties of a native C++ pointer. For example, you can use it to walk a linked data structure and do insertions and deletions using only one pointer:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)