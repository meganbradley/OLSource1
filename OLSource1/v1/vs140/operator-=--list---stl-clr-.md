---
title: "operator&gt;= (list) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&gt;= (list) (STL/CLR)"
f1_keywords: 
  - "cliext::list::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>= member [STL/CLR]"
ms.assetid: c6142241-8e85-4759-98fd-4f2b7d37b255
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (list) (STL-CLR)
List greater than or equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two lists are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] >= [a b c] is True**  
**[a b c] >= [a b d] is False**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [operator==](../vs140/operator==--list---stl-clr-.md)   
 [operator!=](../vs140/operator!=--list---stl-clr-.md)   
 [operator\<](../vs140/operator---list---stl-clr-.md)   
 [operator>](../vs140/operator---list---stl-clr-.md)   
 [operator<=](../vs140/operator-=--list---stl-clr-.md)