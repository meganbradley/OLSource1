---
title: "operator== (multimap) (STL-LR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator== (multimap) (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== member [STL/CLR]"
ms.assetid: 19f22238-7acf-47dc-b95e-310b39f554ad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (multimap) (STL-LR)
List equal comparison.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns true only if the sequences controlled by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> have the same length and, for each position <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You use it to test whether <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is ordered the same as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when the two multimaps are compared element by element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
 **[a 1] [b 2] [d 4]**  
**[a b c] == [a b c] is True**  
**[a b c] == [a b d] is False**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [operator!=](../vs140/operator!=--multimap---stl-clr-.md)   
 [operator\<](../vs140/operator---multimap---stl-clr-.md)   
 [operator>=](../vs140/operator-=--multimap---stl-clr-.md)   
 [operator>](../vs140/operator---multimap---stl-clr-.md)   
 [operator<=](../vs140/operator-=--multimap---stl-clr-.md)