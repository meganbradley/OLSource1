---
title: "valarray::cshift"
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
  - "std::valarray::cshift"
  - "valarray/std::valarray::cshift"
  - "cshift"
  - "std.valarray.cshift"
  - "valarray.cshift"
  - "valarray::cshift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cshift method"
ms.assetid: 9e26038d-66ff-4c5b-bac0-d70747c7572f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::cshift
Cyclically shifts all the elements in a valarray by a specified number of positions.  
  
## Syntax  
  
```  
  
      valarray<Type> cshift(  
   int _Count  
) const;  
```  
  
#### Parameters  
 `_Count`  
 The number of places the elements are to be shifted forward.  
  
## Return Value  
 A new valarray in which all the elements have been moved `_Count` positions cyclically toward the front of the valarray, left with respect to their positions in the operand valarray.  
  
## Remarks  
 A positive value of `_Count` shifts the elements cyclically left `_Count` places.  
  
 A negative value of `_Count` shifts the elements cyclically right `_Count` places.  
  
## Example  
  
```  
// valarray_cshift.cpp  
// compile with: /EHsc  
  
#include <valarray>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    int i;  
  
    valarray<int> va1(10), va2(10);  
    for (i = 0; i < 10; i+=1)  
        va1[i] = i;  
    for (i = 0; i < 10; i+=1)  
        va2[i] = 10 - i;  
  
    cout << "The operand valarray va1 is: (";  
    for (i = 0; i < 10; i++)  
        cout << " " << va1[i];  
    cout << ")" << endl;  
  
    // A positive parameter shifts elements right  
    va1 = va1.cshift(4);  
    cout << "The cyclically shifted valarray va1 is:\nva1.cshift (4) = (";  
    for (i = 0; i < 10; i++)  
        cout << " " << va1[i];  
    cout << ")" << endl;  
  
    cout << "The operand valarray va2 is: (";  
    for (i = 0; i < 10; i++)  
        cout << " " << va2[i];  
    cout << ")" << endl;  
  
    // A negative parameter shifts elements left  
    va2 = va2.cshift(-4);  
    cout << "The cyclically shifted valarray va2 is:\nva2.shift (-4) = (";  
    for (i = 0; i < 10; i++)  
        cout << " " << va2[i];  
    cout << ")" << endl;  
}  
```  
  
 **The operand valarray va1 is: ( 0 1 2 3 4 5 6 7 8 9)**  
**The cyclically shifted valarray va1 is:**  
**va1.cshift (4) = ( 4 5 6 7 8 9 0 1 2 3)**  
**The operand valarray va2 is: ( 10 9 8 7 6 5 4 3 2 1)**  
**The cyclically shifted valarray va2 is:**  
**va2.shift (-4) = ( 4 3 2 1 10 9 8 7 6 5)**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)