---
title: "operator== (pair) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator== (pair) (STL/CLR)"
f1_keywords: 
  - "cliext::pair::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== member [STL/CLR]"
ms.assetid: 2b4879a1-f326-4fb3-b113-bd8d457f9802
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (pair) (STL-CLR)
Pair equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left pair to compare.  
  
 right  
 Right pair to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is ordered the same as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when the two pairs are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **[x, 3]**  
**[x, 4]**  
**[x 3] == [x 3] is True**  
**[x 3] == [x 4] is False**   
## Requirements  
 **Header:** \<cliext/utility>  
  
 **Namespace:** cliext  
  
## See Also  
 [pair](../vs140/pair--stl-clr-.md)   
 [operator!=](../vs140/operator!=--pair---stl-clr-.md)   
 [operator\<](../vs140/operator---pair---stl-clr-.md)   
 [operator>=](../vs140/operator-=--pair---stl-clr-.md)   
 [operator>](../vs140/operator---pair---stl-clr-.md)   
 [operator<=](../vs140/operator-=--pair---stl-clr-.md)