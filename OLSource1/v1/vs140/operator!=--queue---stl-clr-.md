---
title: "operator!= (queue) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator!= (queue) (STL/CLR)"
f1_keywords: 
  - "cliext::queue::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= member [STL/CLR]"
ms.assetid: aa9e23e5-518e-473c-b15c-9b610bb215d6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (queue) (STL-CLR)
Queue not equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered the same as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two queues are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] != [a b c] is False**  
**[a b c] != [a b d] is True**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [queue](../vs140/queue--stl-clr-.md)   
 [operator==](../vs140/operator==--queue---stl-clr-.md)   
 [operator\<](../vs140/operator---queue---stl-clr-.md)   
 [operator>=](../vs140/operator-=--queue---stl-clr-.md)   
 [operator>](../vs140/operator---queue---stl-clr-.md)   
 [operator<=](../vs140/operator-=--queue---stl-clr-.md)