---
title: "operator&gt;= (multimap) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&gt;= (multimap) (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>= member [STL/CLR]"
ms.assetid: a9e2451b-476f-48ad-a305-50798c2991f2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (multimap) (STL-CLR)
List greater than or equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not ordered before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the two multimaps are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
 **[a 1] [b 2] [d 4]**  
**[a b c] >= [a b c] is True**  
**[a b c] >= [a b d] is False**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [operator==](../vs140/operator==--multimap---stl-lr-.md)   
 [operator!=](../vs140/operator!=--multimap---stl-clr-.md)   
 [operator\<](../vs140/operator---multimap---stl-clr-.md)   
 [operator>](../vs140/operator---multimap---stl-clr-.md)   
 [operator<=](../vs140/operator-=--multimap---stl-clr-.md)