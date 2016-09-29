---
title: "iota"
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
  - "std.iota"
  - "std::iota"
  - "iota"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iota function"
ms.assetid: ccde879c-5cf7-4963-bb91-e5455c3edd61
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iota
Stores a starting value, beginning with the first element and filling with successive increments of that value (`_Value++`) in each of the elements in the interval `[_First, _Last)`.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator, class Type>  
void iota(  
   ForwardIterator _First,   
   ForwardIterator _Last,  
   Type _Value   
);  
  
```  
  
#### Parameters  
 `_First`  
 An input iterator that addresses the first element in the range to be filled.  
  
 `_Last`  
 An input iterator that addresses the last element in the range to be filled.  
  
 `_Value`  
 The starting value to store in the first element and to successively increment for subsequent elements.  
  
## Remarks  
  
## Example  
 The following example demonstrates some uses for the `iota` function by filling a [list](../vs140/-list-.md) of integers and then filling a [vector](../vs140/-vector-.md) with the `list` so that the [random_shuffle](../vs140/random_shuffle.md) function can be used.  
  
```cpp  
// compile by using: cl /EHsc /nologo /W4 /MTd  
#include <algorithm>  
#include <numeric>  
#include <list>  
#include <vector>  
#include <iostream>  
  
using namespace std;  
  
int main(void)  
{  
    list <int> intList(10);  
    vector <list<int>::iterator> intVec(intList.size());  
  
    // Fill the list  
    iota(intList.begin(), intList.end(), 0);  
  
    // Fill the vector with the list so we can shuffle it  
    iota(intVec.begin(), intVec.end(), intList.begin());  
  
    random_shuffle(intVec.begin(), intVec.end());  
  
    // Output results  
    cout << "Contents of the integer list: " << endl;  
    for (auto i: intList) {  
        cout << i << ' ';  
    }  
    cout << endl << endl;  
  
    cout << "Contents of the integer list, shuffled by using a vector: " << endl;  
    for (auto i: intVec) {  
        cout << *i << ' ';  
    }  
    cout << endl;  
}  
```  
  
## Output  
 `Contents of the integer list:`  
  
 `0 1 2 3 4 5 6 7 8 9`  
  
 `Contents of the integer list, shuffled by using a vector:`  
  
 `8 1 9 2 0 5 7 3 4 6`  
  
## Requirements  
 **Header:** <numeric\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)