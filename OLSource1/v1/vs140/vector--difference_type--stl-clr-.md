---
title: "vector::difference_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::difference_type (STL/CLR)"
f1_keywords: 
  - "cliext::vector::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type member [STL/CLR]"
ms.assetid: 1e47c569-107b-4a44-adf4-b1473e1f8d4c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::difference_type (STL-CLR)
The types of a signed distance between two elements.  
  
## Syntax  
  
```  
typedef int difference_type;  
```  
  
## Remarks  
 The type describes a signed element count.  
  
## Example  
  
```  
// cliext_vector_difference_type.cpp   
// compile with: /clr   
#include <cliext/vector>   
  
int main()   
    {   
    cliext::vector<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// compute positive difference   
    cliext::vector<wchar_t>::difference_type diff = 0;   
    for (cliext::vector<wchar_t>::iterator it = c1.begin();   
        it != c1.end(); ++it) ++diff;   
    System::Console::WriteLine("end()-begin() = {0}", diff);   
  
// compute negative difference   
    diff = 0;   
    for (cliext::vector<wchar_t>::iterator it = c1.end();   
        it != c1.begin(); --it) --diff;   
    System::Console::WriteLine("begin()-end() = {0}", diff);   
    return (0);   
    }  
  
```  
  
  **a b c**  
**end()-begin() = 3**  
**begin()-end() = -3**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [size_type](../vs140/vector--size_type--stl-clr-.md)