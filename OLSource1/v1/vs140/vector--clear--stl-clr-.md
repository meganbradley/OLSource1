---
title: "vector::clear (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::clear (STL/CLR)"
f1_keywords: 
  - "cliext::vector::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear member [STL/CLR]"
ms.assetid: 4ed20ec8-3089-4c36-b68f-1b51c639041f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::clear (STL-CLR)
Removes all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function effectively calls [erase](../vs140/vector--erase--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [begin](../vs140/vector--begin--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [end](../vs140/vector--end--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to ensure that the controlled sequence is empty.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**size() = 0**  
 **a b**  
**size() = 0**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [erase](../vs140/vector--erase--stl-clr-.md)