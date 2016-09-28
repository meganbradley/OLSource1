---
title: "list::remove (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::remove (STL/CLR)"
f1_keywords: 
  - "cliext::list::remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove member [STL/CLR]"
ms.assetid: eaf598ee-e8fd-4cc0-be69-ca81a80e1d51
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::remove (STL-CLR)
Removes an element with a specified value.  
  
## Syntax  
  
```  
void remove(value_type val);  
```  
  
#### Parameters  
 val  
 Value of the element to remove.  
  
## Remarks  
 The member function removes an element in the controlled sequence for which `((System::Object^)``val``)->Equals((System::Object^)x)` is true (if any). You use it to erase an arbitrary element with the specified value.  
  
## Example  
  
```  
// cliext_list_remove.cpp   
// compile with: /clr   
#include <cliext/list>   
  
int main()   
    {   
    cliext::list<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// fail to remove and redisplay   
    c1.remove(L'A');   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();  
  
// remove and redisplay   
    c1.remove(L'b');   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **a b c**  
 **a c**   
## Requirements  
 **Header:** <cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [clear](../vs140/list--clear--stl-clr-.md)   
 [erase](../vs140/list--erase--stl-clr-.md)   
 [remove_if](../vs140/list--remove_if--stl-clr-.md)