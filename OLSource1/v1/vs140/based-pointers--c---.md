---
title: "Based Pointers (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__based"
  - "__based_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__based keyword [C++]"
  - "based pointers"
  - "pointers, based"
ms.assetid: 1e5f2e96-c52e-4738-8e14-87278681205e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Based Pointers (C++)
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword allows you to declare pointers based on pointers (pointers that are offsets from existing pointers).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Pointers based on pointer addresses are the only form of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword valid in 32-bit or 64-bit compilations. For the Microsoft 32-bit C/C++ compiler, a based pointer is a 32-bit offset from a 32-bit pointer base. A similar restriction holds for 64-bit environments, where a based pointer is a 64-bit offset from the 64-bit base.  
  
 One use for pointers based on pointers is for persistent identifiers that contain pointers. A linked list that consists of pointers based on a pointer can be saved to disk, then reloaded to another place in memory, with the pointers remaining valid. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The pointer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned the address of memory allocated at some later point in the program. The linked list is relocated relative to the value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Persisting identifiers containing pointers can also be accomplished by using [memory-mapped files](http://msdn.microsoft.com/library/windows/desktop/aa366556).  
  
 When dereferencing a based pointer, the base must be either explicitly specified or implicitly known through the declaration.  
  
 For compatibility with previous versions, **_based** is a synonym for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
 The following code demonstrates changing a based pointer by changing its base.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **1**  
**2**  
**10**  
**11**   
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [alloc_text](../vs140/alloc_text.md)