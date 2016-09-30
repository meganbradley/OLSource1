---
title: "map::key_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::key_compare (STL/CLR)"
f1_keywords: 
  - "cliext::map::key_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_compare member [STL/CLR]"
ms.assetid: 6cde0e22-f1cb-4b92-b76d-bab6cbd9c825
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::key_compare (STL-CLR)
The ordering delegate for two keys.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the delegate that determines the ordering of its key arguments.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare(L'a', L'a') = False**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**  
**compare(L'a', L'a') = False**  
**compare(L'a', L'b') = False**  
**compare(L'b', L'a') = True**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [key_comp](../vs140/map--key_comp--stl-clr-.md)   
 [key_type](../vs140/map--key_type--stl-clr-.md)   
 [value_compare](../vs140/map--value_compare--stl-clr-.md)