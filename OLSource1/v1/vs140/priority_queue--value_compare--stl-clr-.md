---
title: "priority_queue::value_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue::value_compare (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue::value_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_compare member [STL/CLR]"
ms.assetid: 40832c80-426f-42af-b4a3-bab27d2abd7e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::value_compare (STL-CLR)
The ordering delegate for two values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the delegate that determines whether the first argument is ordered before the second.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare(L'a', L'a') = False**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**  
**compare(L'a', L'a') = False**  
**compare(L'a', L'b') = False**  
**compare(L'b', L'a') = True**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [value_comp](../vs140/priority_queue--value_comp--stl-clr-.md)   
 [value_type](../vs140/priority_queue--value_type--stl-clr-.md)