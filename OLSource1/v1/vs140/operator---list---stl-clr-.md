---
title: "operator&gt; (list) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&gt; (list) (STL/CLR)"
f1_keywords: 
  - "cliext::list::operator>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator> member [STL/CLR]"
ms.assetid: 58584708-1fa6-4908-84f6-790d53f46d9a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (list) (STL-CLR)
List greater than comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is ordered after <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two lists are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] > [a b c] is False**  
**[a b d] > [a b c] is True**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [operator==](../vs140/operator==--list---stl-clr-.md)   
 [operator!=](../vs140/operator!=--list---stl-clr-.md)   
 [operator\<](../vs140/operator---list---stl-clr-.md)   
 [operator>=](../vs140/operator-=--list---stl-clr-.md)   
 [operator<=](../vs140/operator-=--list---stl-clr-.md)