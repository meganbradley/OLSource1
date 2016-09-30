---
title: "operator&lt;= (pair) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&lt;= (pair) (STL/CLR)"
f1_keywords: 
  - "cliext::pair::operator<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<= member [STL/CLR]"
ms.assetid: 94a4cc0a-cef4-4050-bd59-f826bd318e7b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (pair) (STL-CLR)
Pair less than or equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left pair to compare.  
  
 right  
 Right pair to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered after <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two pairs are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **[x, 3]**  
**[x, 4]**  
**[x 3] <= [x 3] is True**  
**[x 4] <= [x 3] is False**   
## Requirements  
 **Header:** \<cliext/utility>  
  
 **Namespace:** cliext  
  
## See Also  
 [pair](../vs140/pair--stl-clr-.md)   
 [operator==](../vs140/operator==--pair---stl-clr-.md)   
 [operator!=](../vs140/operator!=--pair---stl-clr-.md)   
 [operator\<](../vs140/operator---pair---stl-clr-.md)   
 [operator>=](../vs140/operator-=--pair---stl-clr-.md)   
 [operator>](../vs140/operator---pair---stl-clr-.md)