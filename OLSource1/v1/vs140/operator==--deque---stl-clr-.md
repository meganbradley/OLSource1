---
title: "operator== (deque) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator== (deque) (STL/CLR)"
f1_keywords: 
  - "cliext::deque::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== member [STL/CLR]"
ms.assetid: b97de473-8a30-4278-b25f-79429f55a764
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (deque) (STL-CLR)
Deque equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns true only if the sequences controlled by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> have the same length and, for each position <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is ordered the same as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when the two deques are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] == [a b c] is True**  
**[a b c] == [a b d] is False**   
## Requirements  
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [operator!=](../vs140/deque--operator!=--stl-clr-.md)   
 [operator\<](../vs140/operator---deque---stl-clr-.md)   
 [operator>=](../vs140/operator-=--deque---stl-clr-.md)   
 [operator>](../vs140/operator---deque---stl-clr-.md)   
 [operator<=](../vs140/operator-=--deque---stl-clr-.md)