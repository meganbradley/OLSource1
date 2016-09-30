---
title: "list::unique (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::unique (STL/CLR)"
f1_keywords: 
  - "cliext::list::unique"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique member [STL/CLR]"
ms.assetid: c3a29e4e-0ec1-4472-b050-7a9511037132
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::unique (STL-CLR)
Removes adjacent elements that pass a specified test.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pred  
 Comparer for element pairs.  
  
## Remarks  
 The first member function removes from the controlled sequence (erases) every element that compares equal to its preceding element -- if element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> precedes element <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the member function removes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to remove all but one copy of every subsequence of adjacent elements that compare equal. Note that if the controlled sequence is ordered, such as by calling [sort](../vs140/list--sort--stl-clr-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the member function leaves only elements with unique values. (Hence the name).  
  
 The second member function behaves the same as the first, except that it removes each element <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> following an element <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. You use it to remove all but one copy of every subsequence of adjacent elements that satisfy a predicate function or delegate that you specify. Note that if the controlled sequence is ordered, such as by calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the member function leaves only elements that do not have equivalent ordering with any other elements.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a a b c**  
 **a b c**  
 **a a**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [remove](../vs140/list--remove--stl-clr-.md)   
 [remove_if](../vs140/list--remove_if--stl-clr-.md)   
 [sort](../vs140/list--sort--stl-clr-.md)