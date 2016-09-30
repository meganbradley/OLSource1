---
title: "operator!= (vector) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator!= (vector) (STL/CLR)"
f1_keywords: 
  - "cliext::vector::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= member [STL/CLR]"
ms.assetid: 6f7b0569-b2d1-4f36-8520-31839bf6db9b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (vector) (STL-CLR)
Vector not equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered the same as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two vectors are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] != [a b c] is False**  
**[a b c] != [a b d] is True**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [operator==](../vs140/operator==--vector---stl-clr-.md)   
 [operator\<](../vs140/operator---vector---stl-clr-.md)   
 [operator>=](../vs140/operator-=--vector---stl-clr-.md)   
 [operator>](../vs140/operator---vector---stl-clr-.md)   
 [operator<=](../vs140/operator-=--vector---stl-clr-.md)