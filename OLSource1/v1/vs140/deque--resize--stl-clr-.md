---
title: "deque::resize (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::resize (STL/CLR)"
f1_keywords: 
  - "cliext::deque::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize member [STL/CLR]"
ms.assetid: c83f3c57-38b3-4706-a124-59bafbf88484
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::resize (STL-CLR)
Changes the number of elements.  
  
## Syntax  
  
```  
void resize(size_type new_size);  
void resize(size_type new_size, value_type val);  
```  
  
#### Parameters  
 new_size  
 New size of the controlled sequence.  
  
 val  
 Value of the padding element.  
  
## Remarks  
 The member functions both ensure that [size](../vs140/deque--size--stl-clr-.md)`()` henceforth returns `new_size`. If it must make the controlled sequence longer, the first member function appends elements with value `value_type()`, while the second member function appends elements with value `val`. To make the controlled sequence shorter, both member functions effectively erase the last element [size](../vs140/deque--size--stl-clr-.md)`() -` `new_size` times. You use it to ensure that the controlled sequence has size `new_size`, by either trimming or padding the current controlled sequence.  
  
## Example  
  
```  
// cliext_deque_resize.cpp   
// compile with: /clr   
#include <cliext/deque>   
  
int main()   
    {   
// construct an empty container and pad with default values   
    cliext::deque<wchar_t> c1;   
    System::Console::WriteLine("size() = {0}", c1.size());   
    c1.resize(4);   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", (int)elem);   
    System::Console::WriteLine();   
  
// resize to empty   
    c1.resize(0);   
    System::Console::WriteLine("size() = {0}", c1.size());   
  
// resize and pad   
    c1.resize(5, L'x');   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
 **size() = 0**  
 **0 0 0 0**  
**size() = 0**  
 **x x x x x**   
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [clear](../vs140/deque--clear--stl-clr-.md)   
 [erase](../vs140/deque--erase--stl-clr-.md)   
 [insert](../vs140/deque--insert--stl-clr-.md)