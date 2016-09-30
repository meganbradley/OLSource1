---
title: "deque::swap (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::swap (STL/CLR)"
f1_keywords: 
  - "cliext::deque::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap member [STL/CLR]"
ms.assetid: 511e1aa8-3069-43f3-aa77-150f1de1e195
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::swap (STL-CLR)
Swaps the contents of two containers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 right  
 Container to swap contents with.  
  
## Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. It does so in constant time and it throws no exceptions. You use it as a quick way to exchange the contents of two containers.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **x x x x x**  
 **x x x x x**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [assign](../vs140/deque--assign--stl-clr-.md)   
 [operator=](../vs140/operator=--deque---stl-clr-.md)