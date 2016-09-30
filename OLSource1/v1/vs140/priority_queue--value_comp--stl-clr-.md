---
title: "priority_queue::value_comp (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue::value_comp (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue::value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp member [STL/CLR]"
ms.assetid: af28e541-087d-4837-9ff0-cd36d4cfc57a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::value_comp (STL-CLR)
Copies the ordering delegate for two elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the ordering delegate used to order the controlled sequence. You use it to compare two values.  
  
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
 [value_compare](../vs140/priority_queue--value_compare--stl-clr-.md)   
 [value_type](../vs140/priority_queue--value_type--stl-clr-.md)