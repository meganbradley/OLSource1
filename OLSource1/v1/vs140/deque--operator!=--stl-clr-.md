---
title: "deque::operator!= (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::operator!= (STL/CLR)"
f1_keywords: 
  - "cliext::deque::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= member [STL/CLR]"
ms.assetid: c23c7bd1-813e-4518-9947-eb13d1176a13
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::operator!= (STL-CLR)
Deque not equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered the same as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two deques are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] != [a b c] is False**  
**[a b c] != [a b d] is True**   
## Requirements  
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [operator==](../vs140/operator==--deque---stl-clr-.md)   
 [operator\<](../vs140/operator---deque---stl-clr-.md)   
 [operator>=](../vs140/operator-=--deque---stl-clr-.md)   
 [operator>](../vs140/operator---deque---stl-clr-.md)   
 [operator<=](../vs140/operator-=--deque---stl-clr-.md)