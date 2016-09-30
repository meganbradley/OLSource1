---
title: "reverse_iterator::pointer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "reverse_iterator.pointer"
  - "std.reverse_iterator.pointer"
  - "reverse_iterator::pointer"
  - "pointer"
  - "std::reverse_iterator::pointer"
  - "xutility/std::reverse_iterator::pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer method"
  - "pointer typedef"
ms.assetid: 25df8dbc-d668-4954-9019-a0087fae2338
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::pointer
A type that provides a pointer to an element addressed by a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the iterator trait typename <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<*RandomIterator*>**::pointer**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec of integer pairs is:**  
**( ( 1, 2) ( 3, 4) ( 5, 6) )**  
**The vector vec reversed is:**  
**( ( 5, 6) ( 3, 4) ( 1, 2) )**  
**The iterator pos points to:**  
**( 3, 4 )**  
**The iterator rpos points to:**  
**( 1, 2 )**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)