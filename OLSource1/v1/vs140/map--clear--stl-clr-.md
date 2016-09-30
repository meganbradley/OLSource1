---
title: "map::clear (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::clear (STL/CLR)"
f1_keywords: 
  - "cliext::map::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear member [STL/CLR]"
ms.assetid: 2a6a01fe-2998-447d-9ae8-6cb6343d0dfa
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::clear (STL-CLR)
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function effectively calls [erase](../vs140/map--erase--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/map--begin--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/map--end--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to ensure that the controlled sequence is empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**size() = 0**  
 **[a 1] [b 2]**  
**size() = 0**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [erase](../vs140/map--erase--stl-clr-.md)