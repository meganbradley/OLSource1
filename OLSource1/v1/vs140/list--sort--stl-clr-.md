---
title: "list::sort (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::sort (STL/CLR)"
f1_keywords: 
  - "cliext::list::sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sort member [STL/CLR]"
ms.assetid: f811d5f4-a19e-4194-8765-1e68097c52f0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::sort (STL-CLR)
Orders the controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pred  
 Comparer for element pairs.  
  
## Remarks  
 The first member function rearranges the elements in the controlled sequence so that they are ordered by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> -- elements do not decrease in value as you progress through the sequence. You use this member function to sort the sequence in increasing order.  
  
 The second member function behaves the same as the first, except that the sequence is ordered by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> -- <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is false for any element <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that follows element <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the resultant sequence. You use it to sort the sequence in an order that you specify by a predicate function or delegate.  
  
 Both functions perform a stable sort -- no pair of elements in the original controlled sequence is reversed in the resulting controlled sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **c b a**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [merge](../vs140/list--merge--stl-clr-.md)   
 [reverse](../vs140/list--reverse--stl-clr-.md)   
 [splice](../vs140/list--splice--stl-clr-.md)   
 [unique](../vs140/list--unique--stl-clr-.md)