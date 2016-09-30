---
title: "set::value_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set::value_compare (STL/CLR)"
f1_keywords: 
  - "cliext::set::value_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_compare member [STL/CLR]"
ms.assetid: cf45d7ae-5cd1-4633-9fe6-f0b97730465c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::value_compare (STL-CLR)
The ordering delegate for two element values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the delegate that determines the ordering of its value arguments.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare(L'a', L'a') = False**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [set](../vs140/set--stl-clr-.md)   
 [key_compare](../vs140/set--key_compare--stl-clr-.md)   
 [value_comp](../vs140/set--value_comp--stl-clr-.md)   
 [value_type](../vs140/set--value_type--stl-clr-.md)