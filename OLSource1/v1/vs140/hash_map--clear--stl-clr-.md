---
title: "hash_map::clear (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::clear (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear member [STL/CLR]"
ms.assetid: a2782336-f130-4e27-923e-7dd43c542d30
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::clear (STL-CLR)
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function effectively calls [erase](../vs140/hash_map--erase--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/hash_map--begin--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/hash_map--end--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to ensure that the controlled sequence is empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**size() = 0**  
 **[a 1] [b 2]**  
**size() = 0**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [erase](../vs140/hash_map--erase--stl-clr-.md)