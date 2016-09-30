---
title: "deque::clear (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::clear (STL/CLR)"
f1_keywords: 
  - "cliext::deque::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear member [STL/CLR]"
ms.assetid: 1d9a3d11-b3fa-43a7-a508-7a05cbcd91bf
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::clear (STL-CLR)
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function effectively calls [erase](../vs140/deque--erase--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/deque--begin--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/deque--end--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to ensure that the controlled sequence is empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**size() = 0**  
 **a b**  
**size() = 0**   
## Requirements  
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [erase](../vs140/deque--erase--stl-clr-.md)