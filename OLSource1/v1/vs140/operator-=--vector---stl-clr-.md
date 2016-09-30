---
title: "operator&gt;= (vector) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&gt;= (vector) (STL/CLR)"
f1_keywords: 
  - "cliext::vector::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>= member [STL/CLR]"
ms.assetid: c06f4489-f65a-4bd6-944f-9b23a2bb4e35
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (vector) (STL-CLR)
Vector greater than or equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two vectors are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] >= [a b c] is True**  
**[a b c] >= [a b d] is False**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [operator==](../vs140/operator==--vector---stl-clr-.md)   
 [operator!=](../vs140/operator!=--vector---stl-clr-.md)   
 [operator\<](../vs140/operator---vector---stl-clr-.md)   
 [operator>](../vs140/operator---vector---stl-clr-.md)   
 [operator<=](../vs140/operator-=--vector---stl-clr-.md)