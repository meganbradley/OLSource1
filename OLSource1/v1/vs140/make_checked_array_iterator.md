---
title: "make_checked_array_iterator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - make_checked_array_iterator
  - stdext::make_checked_array_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - make_checked_array_iterator
  - make_checked_array_iterator function
ms.assetid: aa9e15b0-c090-49b0-b552-8afa434cf9d8
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# make_checked_array_iterator
Creates a [checked_array_iterator](../vs140/checked_array_iterator-class.md) that can be used by other algorithms.  
  
> [!NOTE]
>  This function is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension.  
  
## Syntax  
  
```  
template <class Iter>  
  checked_array_iterator<Iter>   
    make_checked_array_iterator(  
      Iter Ptr,  
      size_t Size,  
      size_t Index = 0  
);  
```  
  
#### Parameters  
 `Ptr`  
 A pointer to the destination array.  
  
 `Size`  
 The size of the destination array.  
  
 `Index`  
 Optional index into the array.  
  
## Return Value  
 An instance of `checked_array_iterator`.  
  
## Remarks  
 The `make_checked_array_iterator` function is defined in the `stdext` namespace.  
  
 This function takes a raw pointer—which would ordinarily cause concern about bounds overrun—and wraps it in a [checked_array_iterator](../vs140/checked_array_iterator-class.md) class that does checking. Because that class is marked as checked, the STL doesn't warn about it. For more information and code examples, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
 In the following example, a [vector](../vs140/vector-class.md) is created and populated with 10 items. The contents of the vector are copied into an array by using the copy algorithm, and then `make_checked_array_iterator` is used to specify the destination. This is followed by an intentional violation of the bounds checking so that a debug assertion failure is triggered.  
  
```cpp  
// make_checked_array_iterator.cpp  
// compile with: /EHsc /W4 /MTd  
  
#include <algorithm>  
#include <iterator> // stdext::make_checked_array_iterator  
#include <memory> // std::make_unique  
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
    // Old-school but not exception safe, favor make_unique<int[]>  
    // int* dest = new int[dest_size];  
    unique_ptr<int[]> updest = make_unique<int[]>(dest_size);  
    int* dest = updest.get(); // get a raw pointer for the demo  
  
    vector<int> v;  
  
    for (int i = 0; i < dest_size; ++i) {  
        v.push_back(i);  
    }  
    print("vector v: ", v);  
  
    copy(v.begin(), v.end(), stdext::make_checked_array_iterator(dest, dest_size));  
  
    cout << "int array dest: ";  
    for (int i = 0; i < dest_size; ++i) {  
        cout << dest[i] << " ";  
    }  
    cout << endl;  
  
    // Add another element to the vector to force an overrun.  
    v.push_back(10);  
    // The next line causes a debug assertion when it executes.  
    copy(v.begin(), v.end(), stdext::make_checked_array_iterator(dest, dest_size));  
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