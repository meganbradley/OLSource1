---
title: "list::merge (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::merge (STL/CLR)"
f1_keywords: 
  - "cliext::list::merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "merge member [STL/CLR]"
ms.assetid: f8e93cd3-bd08-4086-859b-08a2899cc9a6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::merge (STL-CLR)
Merges two ordered controlled sequences.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pred  
 Comparer for element pairs.  
  
 right  
 Container to merge in.  
  
## Remarks  
 The first member function removes all elements from the sequence controlled by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and insert them in the controlled sequence. Both sequences must be previously ordered by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> -- elements must not decrease in value as you progress through either sequence. The resulting sequence is also ordered by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use this member function to merge two sequences that increase in value into a sequence that also increases in value.  
  
 The second member function behaves the same as the first, except that the sequences are ordered by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> -- <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must be false for any element <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that follows element <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the sequence. You use it to merge two sequences ordered by a predicate function or delegate that you specify.  
  
 Both functions perform a stable merge -- no pair of elements in either of the original controlled sequences is reversed in the resulting controlled sequence. Also, if a pair of elements <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the resulting controlled sequence has equivalent ordering -- <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> -- an element from the original controlled sequence appears before an element from the sequence controlled by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a c e**  
 **b d f**  
 **a b c d e f**  
**c2.size() = 0**  
 **e c a**  
 **f e d c b a**  
 **f e e d c c b a a**  
**c1.size() = 0**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [sort](../vs140/list--sort--stl-clr-.md)   
 [splice](../vs140/list--splice--stl-clr-.md)