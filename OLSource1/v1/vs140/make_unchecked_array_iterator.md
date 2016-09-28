---
title: "make_unchecked_array_iterator"
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
  - "make_unchecked_array_iterator"
  - "stdext::make_unchecked_array_iterator"
dev_langs: 
  - "C++"
ms.assetid: 10422011-d246-466f-bb5d-1729497ec47e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_unchecked_array_iterator
Creates an [unchecked_array_iterator](../vs140/unchecked_array_iterator-class.md) that can be used by other algorithms.  
  
> [!NOTE]
>  This function is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension.  
  
## Syntax  
  
```  
template <class Iter>  
  unchecked_array_iterator<Iter>   
    make_unchecked_array_iterator(  
      Iter Ptr  
);  
```  
  
#### Parameters  
 `Ptr`  
 A pointer to the destination array.  
  
## Return Value  
 An instance of `unchecked_array_iterator`.  
  
## Remarks  
 The `make_unchecked_array_iterator` function is defined in the `stdext` namespace.  
  
 This function takes a raw pointer and wraps it in a class that performs no checking and therefore optimizes away to nothing, but it also silences compiler warnings such as [C4996](../vs140/compiler-warning--level-3--c4996.md). Therefore, this is a targeted way to deal with unchecked-pointer warnings without globally silencing them or incurring the cost of checking. For more information and code examples, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
 In the following example, a [vector](../vs140/vector-class.md) is created and populated with 10 items. The contents of the vector are copied into an array by using the copy algorithm, and then `make_unchecked_array_iterator` is used to specify the destination.  
  
```cpp  
// make_unchecked_array_iterator.cpp  
// compile with: /EHsc /W4 /MTd  
  
#include <algorithm>  
#include <iterator> // stdext::make_unchecked_array_iterator  
#include <iostream>  
#include <vector>  
#include <string>  
  
using namespace std;  
  
template <typename C> void print(const string& s, const C& c) {  
    cout << s;  
  
    for (const auto& e : c) {  
        cout << e << " ";  
    }  
  
    cout << endl;  
}  
  
int main()  
{  
    const size_t dest_size = 10;  
    int *dest = new int[dest_size];  
    vector<int> v;  
  
    for (int i = 0; i < dest_size; ++i) {  
        v.push_back(i);  
    }  
    print("vector v: ", v);  
  
    // COMPILER WARNING SILENCED: stdext::unchecked_array_iterator is marked as checked in debug mode  
    // (it performs no checking, so an overrun will trigger undefined behavior)  
    copy(v.begin(), v.end(), stdext::make_unchecked_array_iterator(dest));  
  
    cout << "int array dest: ";  
    for (int i = 0; i < dest_size; ++i) {  
        cout << dest[i] << " ";  
    }  
    cout << endl;  
  
    delete[] dest;  
}  
  
```  
  
## Output  
  
```  
vector v: 0 1 2 3 4 5 6 7 8 9  
int array dest: 0 1 2 3 4 5 6 7 8 9  
```  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** stdext  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)