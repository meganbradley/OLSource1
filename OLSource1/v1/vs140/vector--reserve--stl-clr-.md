---
title: "vector::reserve (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::reserve (STL/CLR)"
f1_keywords: 
  - "cliext::vector::reserve"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve member [STL/CLR]"
ms.assetid: d1d5ede9-9628-4b55-95ec-f087a57205f2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::reserve (STL-CLR)
Ensures a minimum growth capacity for the container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 count  
 New minimum capacity of the container.  
  
## Remarks  
 The member function ensures that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> henceforth returns at least <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it to ensure that the container need not reallocate storage for the controlled sequence until it has grown to the specified size.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**capacity() = 4, ok = True**  
**capacity() = 9, ok = True**   
## Description  
 Note that the actual capacities may differ from the values shown here, so long as all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> tests report true.  
  
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [capacity](../vs140/vector--capacity--stl-clr-.md)   
 [resize](../vs140/vector--resize--stl-clr-.md)