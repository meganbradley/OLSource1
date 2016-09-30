---
title: "list::resize"
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
  - "std.list.resize"
  - "Resize"
  - "list.resize"
  - "std::list::resize"
  - "list/std::list::resize"
  - "resize"
  - "list::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: 4a69f5ae-8125-4753-aead-1a500b917d78
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::resize
Specifies a new size for a list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new size of the list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of the new elements to be added to the list if the new size is larger that the original size. If the value is omitted, the new elements are assigned the default value for the class.  
  
## Remarks  
 If the list's size is less than the requested size, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, elements are added to the list until it reaches the requested size.  
  
 If the list's size is larger than the requested size, the elements closest to the end of the list are deleted until the list reaches the size <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 If the present size of the list is the same as the requested size, no action is taken.  
  
 [size](../vs140/list--size.md) reflects the current size of the list.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The size of c1 is 4**  
**The value of the last element is 40**  
**The size of c1 is now 5**  
**The value of the last element is now 0**  
**The reduced size of c1 is: 2**  
**The value of the last element is now 20**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)