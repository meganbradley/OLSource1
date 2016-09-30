---
title: "operator&lt; (queue) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&lt; (queue) (STL/CLR)"
f1_keywords: 
  - "cliext::queue::operator<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator< member [STL/CLR]"
ms.assetid: 2c981e2b-9a88-4b4a-8060-9ac24d5631f5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (queue) (STL-CLR)
Queue less than comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns true if, for the lowest position <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> it is also true that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Otherwise, it returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[size](../vs140/queue--size--stl-clr-.md)<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> You use it to test whether <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is ordered before <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when the two queues are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] < [a b c] is False**  
**[a b c] < [a b d] is True**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [queue](../vs140/queue--stl-clr-.md)   
 [operator==](../vs140/operator==--queue---stl-clr-.md)   
 [operator!=](../vs140/operator!=--queue---stl-clr-.md)   
 [operator>=](../vs140/operator-=--queue---stl-clr-.md)   
 [operator>](../vs140/operator---queue---stl-clr-.md)   
 [operator<=](../vs140/operator-=--queue---stl-clr-.md)