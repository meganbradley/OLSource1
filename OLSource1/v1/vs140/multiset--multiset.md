---
title: "multiset::multiset"
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
  - std.multiset.multiset
  - multiset.multiset
  - std::multiset::multiset
  - multiset
  - set/std::multiset::multiset
  - multiset::multiset
dev_langs: 
  - C++
helpviewer_keywords: 
  - multiset method
  - multiset class, constructor
ms.assetid: 9e73b658-6f3d-408d-b9ab-a0f62153f021
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::multiset
Constructs a multiset that is empty or that is a copy of all or part of some other multiset.  
  
## Syntax  
  
```  
multiset( );  
explicit multiset (  
    const Compare& Comp  
);  
multiset (  
    const Compare& Comp,  
    const Allocator& Al  
);  
multiset(  
    const multiset& Right  
);  
multiset(  
    multiset&& Right  
);  
multiset(  
    initializer_list<Type> IList  
);  
multiset(  
    initializer_list<Type> IList,   
    const Compare& Comp  
);  
multiset(  
    initializer_list<Type> IList,   
    const Compare& Comp,   
    const Allocator& Al  
);  
  
template<class InputIterator>   
    multiset (  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>   
    multiset (  
        InputIterator First,  
        InputIterator Last,  
        const Compare& Comp  
    );  
template<class InputIterator>  
    multiset (  
        InputIterator First,  
        InputIterator Last,  
        const Compare& Comp,  
        const Allocator& Al  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The storage allocator class to be used for this multiset object, which defaults to `Allocator`.|  
|`Comp`|The comparison function of type `const Compare` used to order the elements in the multiset, which defaults to `Compare`.|  
|`Right`|The multiset of which the constructed multiset is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list from which to copy the elements.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the multiset and that can later be returned by calling [get_allocator](../vs140/multiset--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their multiset.  
  
 All constructors store a function object of type Compare that is used to establish an order among the keys of the multiset and that can later be returned by calling [key_comp](../vs140/multiset--key_comp.md).  
  
 The first three constructors specify an empty initial multiset, the second specifying the type of comparison function (`Comp`) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (`Al`) to be used. The keyword `explicit` suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the multiset `Right`.  
  
 The fifth constructor specifies a copy of the multiset by moving `Right`.  
  
 The sixth, seventh, and eighth constructors specify an initializer_list from which to copy the elements.  
  
 The next three constructors copy the range `[First, Last)` of a multiset with increasing explicitness in specifying the type of comparison function and allocator.  
  
## Example  
  
```  
// multiset_ctor.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    //multiset <int>::iterator ms1_Iter, ms2_Iter, ms3_Iter;  
    multiset <int>::iterator ms4_Iter, ms5_Iter, ms6_Iter, ms7_Iter;  
  
    // Create an empty multiset ms0 of key type integer  
    multiset <int> ms0;  
  
    // Create an empty multiset ms1 with the key comparison  
    // function of less than, then insert 4 elements  
    multiset <int, less<int> > ms1;  
    ms1.insert(10);  
    ms1.insert(20);  
    ms1.insert(20);  
    ms1.insert(40);  
  
    // Create an empty multiset ms2 with the key comparison  
    // function of geater than, then insert 2 elements  
    multiset <int, less<int> > ms2;  
    ms2.insert(10);  
    ms2.insert(20);  
  
    // Create a multiset ms3 with the   
    // allocator of multiset ms1  
    multiset <int>::allocator_type ms1_Alloc;  
    ms1_Alloc = ms1.get_allocator();  
    multiset <int> ms3(less<int>(), ms1_Alloc);  
    ms3.insert(30);  
  
    // Create a copy, multiset ms4, of multiset ms1  
    multiset <int> ms4(ms1);  
  
    // Create a multiset ms5 by copying the range ms1[_First, _Last)  
    multiset <int>::const_iterator ms1_bcIter, ms1_ecIter;  
    ms1_bcIter = ms1.begin();  
    ms1_ecIter = ms1.begin();  
    ms1_ecIter++;  
    ms1_ecIter++;  
    multiset <int> ms5(ms1_bcIter, ms1_ecIter);  
  
    // Create a multiset ms6 by copying the range ms4[_First, _Last)  
    // and with the allocator of multiset ms2  
    multiset <int>::allocator_type ms2_Alloc;  
    ms2_Alloc = ms2.get_allocator();  
    multiset <int> ms6(ms4.begin(), ++ms4.begin(), less<int>(), ms2_Alloc);  
  
    cout << "ms1 =";  
    for (auto i : ms1)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "ms2 =";  
    for (auto i : ms2)  
        cout << " " << i;  
   cout << endl;  
  
   cout << "ms3 =";  
   for (auto i : ms3)  
       cout << " " << i;  
    cout << endl;  
  
    cout << "ms4 =";  
    for (auto i : ms4)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "ms5 =";  
    for (auto i : ms5)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "ms6 =";  
    for (auto i : ms6)  
        cout << " " << i;  
    cout << endl;  
  
    // Create a multiset by moving ms5  
    multiset<int> ms7(move(ms5));  
    cout << "ms7 =";  
    for (auto i : ms7)  
        cout << " " << i;  
    cout << endl;  
  
    // Create a multiset with an initializer_list  
    multiset<int> ms8({1, 2, 3, 4});  
    cout << "ms8=";  
    for (auto i : ms8)  
        cout << " " << i;  
    cout << endl;  
}  
```  
  
## Output  
  
```  
ms1 = 10 20 20 40  
ms2 = 10 20  
ms3 = 30  
ms4 = 10 20 20 40  
ms5 = 10 20  
ms6 = 10  
ms7 = 10 20  
ms8= 1 2 3 4  
```  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)