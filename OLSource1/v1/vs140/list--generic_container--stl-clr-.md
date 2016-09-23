---
title: "list::generic_container (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: list::generic_container (STL/CLR)
f1_keywords: 
  - cliext::list::generic_container
dev_langs: 
  - C++
helpviewer_keywords: 
  - generic_container member [STL/CLR]
ms.assetid: 1a8b708e-3c75-4551-a86e-5b50d6be706a
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# list::generic_container (STL-CLR)
The type of the generic interface for the container.  
  
## Syntax  
  
```  
typedef Microsoft::VisualC::StlClr::  
    IList<generic_value>  
    generic_container;  
```  
  
## Remarks  
 The type describes the generic interface for this template container class.  
  
## Example  
  
```  
// cliext_list_generic_container.cpp   
// compile with: /clr   
#include <cliext/list>   
  
int main()   
    {   
    cliext::list<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// construct a generic container   
    cliext::list<wchar_t>::generic_container^ gc1 = %c1;   
    for each (wchar_t elem in gc1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// modify generic and display original   
    gc1->insert(gc1->end(), L'd');   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// modify original and display generic   
    c1.push_back(L'e');   
  
    System::Collections::IEnumerator^ enum1 =   
        gc1->GetEnumerator();   
    while (enum1->MoveNext())   
        System::Console::Write(" {0}", enum1->Current);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **a b c**  
 **a b c d**  
 **a b c d e**   
## Requirements  
 **Header:** <cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 <xref:Microsoft.VisualC.StlClr.IList`1?qualifyHint=False>   
 [list](../vs140/list--stl-clr-.md)   
 [generic_iterator](../vs140/list--generic_iterator--stl-clr-.md)   
 [generic_reverse_iterator](../vs140/list--generic_reverse_iterator--stl-clr-.md)   
 [generic_value](../vs140/list--generic_value--stl-clr-.md)