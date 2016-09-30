---
title: "vector::swap (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::swap (STL/CLR)"
f1_keywords: 
  - "cliext::vector::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap member [STL/CLR]"
ms.assetid: 9ad083fe-f79b-4b97-8013-581fd00c059a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::swap (STL-CLR)
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
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [assign](../vs140/vector--assign--stl-clr-.md)   
 [operator=](../vs140/vector--operator=--stl-clr-.md)