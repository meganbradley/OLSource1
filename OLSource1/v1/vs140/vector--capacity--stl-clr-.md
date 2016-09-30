---
title: "vector::capacity (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::capacity (STL/CLR)"
f1_keywords: 
  - "cliext::vector::capacity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "capacity member [STL/CLR]"
ms.assetid: f82d8da9-8b4d-4288-8d18-8e9ca5911d87
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::capacity (STL-CLR)
Reports the size of allocated storage for the container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the storage currently allocated to hold the controlled sequence, a value at least as large as [size](../vs140/vector--size--stl-clr-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You use it to determine how much the container can grow before it must reallocate storage for the controlled sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**capacity() = 4, ok = True**  
**capacity() = 9, ok = True**   
## Description  
 Note that the actual capacities may differ from the values shown here, so long as all <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> tests report true.  
  
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [reserve](../vs140/vector--reserve--stl-clr-.md)