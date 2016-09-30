---
title: "operator&lt; (vector) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&lt; (vector) (STL/CLR)"
f1_keywords: 
  - "cliext::vector::operator<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator< member [STL/CLR]"
ms.assetid: 41fbd028-e937-4337-9429-57e79a993eef
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (vector) (STL-CLR)
Vector less than comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns true if, for the lowest position <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> it is also true that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Otherwise, it returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> You use it to test whether <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is ordered before <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when the two vectors are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] < [a b c] is False**  
**[a b c] < [a b d] is True**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [operator==](../vs140/operator==--vector---stl-clr-.md)   
 [operator!=](../vs140/operator!=--vector---stl-clr-.md)   
 [operator>=](../vs140/operator-=--vector---stl-clr-.md)   
 [operator>](../vs140/operator---vector---stl-clr-.md)   
 [operator<=](../vs140/operator-=--vector---stl-clr-.md)