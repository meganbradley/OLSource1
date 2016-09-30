---
title: "deque::resize (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::resize (STL/CLR)"
f1_keywords: 
  - "cliext::deque::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize member [STL/CLR]"
ms.assetid: c83f3c57-38b3-4706-a124-59bafbf88484
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::resize (STL-CLR)
Changes the number of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 new_size  
 New size of the controlled sequence.  
  
 val  
 Value of the padding element.  
  
## Remarks  
 The member functions both ensure that [size](../vs140/deque--size--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> henceforth returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If it must make the controlled sequence longer, the first member function appends elements with value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, while the second member function appends elements with value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. To make the controlled sequence shorter, both member functions effectively erase the last element [size](../vs140/deque--size--stl-clr-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> times. You use it to ensure that the controlled sequence has size <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, by either trimming or padding the current controlled sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **size() = 0**  
 **0 0 0 0**  
**size() = 0**  
 **x x x x x**   
## Requirements  
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [clear](../vs140/deque--clear--stl-clr-.md)   
 [erase](../vs140/deque--erase--stl-clr-.md)   
 [insert](../vs140/deque--insert--stl-clr-.md)