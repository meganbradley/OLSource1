---
title: "operator&lt; (map) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&lt; (map) (STL/CLR)"
f1_keywords: 
  - "cliext::map::operator<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator< member [STL/CLR]"
ms.assetid: 9ff87b44-663e-4b99-9dba-d775d9f6f853
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (map) (STL-CLR)
List less than comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns true if, for the lowest position <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> it is also true that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Otherwise, it returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> You use it to test whether <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is ordered before <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when the two maps are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
 **[a 1] [b 2] [d 4]**  
**[a b c] < [a b c] is False**  
**[a b c] < [a b d] is True**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [operator==](../vs140/operator==--map---stl-clr-.md)   
 [operator!=](../vs140/operator!=--map---stl-clr-.md)   
 [operator>=](../vs140/operator-=--map---stl-clr-.md)   
 [operator>](../vs140/operator---map---stl-clr-.md)   
 [operator<=](../vs140/operator-=--map---stl-clr-.md)