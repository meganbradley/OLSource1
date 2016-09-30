---
title: "map::value_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::value_compare (STL/CLR)"
f1_keywords: 
  - "cliext::map::value_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_compare member [STL/CLR]"
ms.assetid: 04fab34b-c68a-4f61-97e8-a7d629b1ffed
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::value_compare (STL-CLR)
The ordering delegate for two element values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the delegate that determines the ordering of its value arguments.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare([L'a', 1], [L'a', 1]) = False**  
**compare([L'a', 1], [L'b', 2]) = True**  
**compare([L'b', 2], [L'a', 1]) = False**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [key_compare](../vs140/map--key_compare--stl-clr-.md)   
 [value_comp](../vs140/map--value_comp--stl-clr-.md)   
 [value_type](../vs140/map--value_type--stl-clr-.md)