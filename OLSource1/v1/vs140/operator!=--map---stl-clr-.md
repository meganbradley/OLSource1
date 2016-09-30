---
title: "operator!= (map) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator!= (map) (STL/CLR)"
f1_keywords: 
  - "cliext::map::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= member [STL/CLR]"
ms.assetid: 335c3b24-27ed-4cc8-b49d-02b83ec5fd0b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (map) (STL-CLR)
List not equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered the same as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two maps are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
 **[a 1] [b 2] [d 4]**  
**[a b c] != [a b c] is False**  
**[a b c] != [a b d] is True**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [operator==](../vs140/operator==--map---stl-clr-.md)   
 [operator\<](../vs140/operator---map---stl-clr-.md)   
 [operator>=](../vs140/operator-=--map---stl-clr-.md)   
 [operator>](../vs140/operator---map---stl-clr-.md)   
 [operator<=](../vs140/operator-=--map---stl-clr-.md)