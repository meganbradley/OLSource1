---
title: "operator&gt;= (queue) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&gt;= (queue) (STL/CLR)"
f1_keywords: 
  - "cliext::queue::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>= member [STL/CLR]"
ms.assetid: 55504da4-90a9-4c02-94df-10ba51b6b7cc
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (queue) (STL-CLR)
Queue greater than or equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two queues are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] >= [a b c] is True**  
**[a b c] >= [a b d] is False**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [queue](../vs140/queue--stl-clr-.md)   
 [operator==](../vs140/operator==--queue---stl-clr-.md)   
 [operator!=](../vs140/operator!=--queue---stl-clr-.md)   
 [operator\<](../vs140/operator---queue---stl-clr-.md)   
 [operator>](../vs140/operator---queue---stl-clr-.md)   
 [operator<=](../vs140/operator-=--queue---stl-clr-.md)