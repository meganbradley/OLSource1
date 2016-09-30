---
title: "operator&lt;= (multiset) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&lt;= (multiset) (STL/CLR)"
f1_keywords: 
  - "cliext::multiset::operator<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<= member [STL/CLR]"
ms.assetid: 58eb92fd-eac2-462d-b5e9-582bf95b501b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (multiset) (STL-CLR)
List less than or equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered after <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two multisets are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b d**  
**[a b c] <= [a b c] is True**  
**[a b d] <= [a b c] is False**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [multiset](../vs140/multiset--stl-clr-.md)   
 [operator==](../vs140/operator==--multiset---stl-clr-.md)   
 [operator!=](../vs140/operator!=--multiset---stl-clr-.md)   
 [operator\<](../vs140/operator---multiset---stl-clr-.md)   
 [operator>=](../vs140/operator-=--multiset---stl-clr-.md)   
 [operator>](../vs140/operator---multiset---stl-clr-.md)