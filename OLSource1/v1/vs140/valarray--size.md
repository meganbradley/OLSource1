---
title: "valarray::size"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "valarray.size"
  - "size"
  - "std::valarray::size"
  - "valarray::size"
  - "std.valarray.size"
  - "valarray/std::valarray::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 53cf762f-2132-46e4-bd75-87d9576aa1ef
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# valarray::size
Finds the number of elements in a valarray.  
  
## Syntax  
  
```  
  
size  
_  
t size( ) const;  
  
```  
  
## Return Value  
 The number of elements in the operand valarray.  
  
## Example  
 The following example demonstrates the use of the valarray::size member function.  
  
```  
// valarray_size.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    int i;  
    size_t size1, size2;  
  
    valarray<int> va1(10), va2(12);  
    for (i = 0; i < 10; i += 1)  
        va1[i] =  i;  
    for (i = 0; i < 10; i += 1)  
        va2[i] =  i;  
  
    cout << "The operand valarray va1(10) is: ( ";  
        for (i = 0; i < 10; i++)  
            cout << va1[i] << " ";  
    cout << ")." << endl;  
  
    size1 = va1.size();  
    cout << "The number of elements in the valarray va1 is: va1.size = "  
         << size1  << "." <<endl << endl;  
  
    cout << "The operand valarray va2(12) is: ( ";  
        for (i = 0; i < 10; i++)  
            cout << va2[i] << " ";  
    cout << ")." << endl;  
  
    size2 = va2.size();  
    cout << "The number of elements in the valarray va2 is: va2.size = "  
         << size2  << "." << endl << endl;  
  
    // Initializing two more elements to va2  
    va2[10] = 10;  
    va2[11] = 11;  
    cout << "After initializing two more elements,\n "  
         << "the operand valarray va2(12) is now: ( ";  
        for (i = 0; i < 12; i++)  
            cout << va2[i] << " ";  
    cout << ")." << endl;  
    cout << "The number of elements in the valarray va2 is still: "  
         << size2  << "." << endl;  
}  
```  
  
 **The operand valarray va1(10) is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The number of elements in the valarray va1 is: va1.size = 10.**  
**The operand valarray va2(12) is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The number of elements in the valarray va2 is: va2.size = 12.**  
**After initializing two more elements,**  
 **the operand valarray va2(12) is now: ( 0 1 2 3 4 5 6 7 8 9 10 11 ).**  
**The number of elements in the valarray va2 is still: 12.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)