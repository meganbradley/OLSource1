---
title: "copy_n"
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
  - "copy_n"
  - "xutility/std::copy_n"
  - "std.copy_n"
  - "std::copy_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_n"
  - "copy_n function"
ms.assetid: 22620efb-2fc0-477f-88ed-837e2f595539
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_n
Copies a specified number of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An input iterator that indicates where to copy elements from.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A signed or unsigned integer type specifying the number of elements to copy.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An output iterator that indicates where to copy elements to.  
  
## Return Value  
 Returns an output iterator where elements have been copied to. It is the same as the returned value of the third parameter, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The template function evaluates <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> once for each <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> starting with the lowest value. It then returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)