---
title: "move_backward"
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
  - "xutility/std::move_backward"
  - "std.move_backward"
  - "move_backward"
  - "std::move_backward"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move_backward"
  - "move_backward function"
ms.assetid: 82872773-11ce-45b9-aa73-c47d237511f5
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# move_backward
Moves the elements of one iterator to another. The move starts with the last element in a specified range, and ends with the first element in that range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An iterator that indicates the start of a range to move elements from.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An iterator that indicates the end of a range to move elements from. This element is not moved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of one past the final element in the destination range.  
  
## Property Value/Return Value  
 Returns an iterator that refers to the first element that is not moved.  
  
## Remarks  
 The template function evaluates <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> once for each <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> starting with the lowest value. It then returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are functionally equivalent to using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> with a move iterator.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [copy_backward](../vs140/copy_backward.md)   
 [Standard Template Library](../vs140/standard-template-library.md)