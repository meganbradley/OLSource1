---
title: "multimap::multimap"
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
  - "multimap"
  - "multimap::multimap"
  - "std.multimap.multimap"
  - "std::multimap::multimap"
  - "multimap.multimap"
  - "map/std::multimap::multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multimap method"
  - "multimap class, constructor"
ms.assetid: 522a21b7-1471-4f9e-9783-0656331b020c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::multimap
Constructs a multimap that is empty or that is a copy of all or part of some other multimap.  
  
## Syntax  
  
```  
multimap( );  
explicit multimap(  
    const Traits& Comp  
);  
multimap(  
    const Traits& Comp,  
    const Allocator& Al  
);  
map(  
    const multimap& Right  
);  
multimap(  
    multimap&& Right  
);  
multimap(  
    initializer_list<value_type> IList  
);  
multimap(  
    initializer_list<value_type> IList,  
    const Compare& Comp  
);  
multimap(  
    initializer_list<value_type> IList,  
    const Compare& Comp,   
    const Allocator& Al  
);  
template<class InputIterator>  
    multimap(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>  
    multimap(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp  
    );  
template<class InputIterator>  
    multimap(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp,  
    const Allocator& Al  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The storage allocator class to be used for this multimap object, which defaults to Allocator.|  
|`Comp`|The comparison function of type **constTraits** used to order the elements in the map, which defaults to **Traits**.|  
|`Right`|The map of which the constructed set is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list from which to copy the elements.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the multimap and that can later be returned by calling [get_allocator](../vs140/multimap--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their multimap.  
  
 All constructors store a function object of type `Traits` that is used to establish an order among the keys of the multimap and that can later be returned by calling [key_comp](../vs140/multimap--key_comp.md).  
  
 The first three constructors specify an empty initial multimap, the second specifying the type of comparison function (`Comp`) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (`Al`) to be used. The key word `explicit` suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the multimap `Right`.  
  
 The fifth constructor specifies a copy of the multimap by moving `Right`.  
  
 The sixth, seventh, and eighth constructors copy the members of an initializer_list.  
  
 The next three constructors copy the range `[First, Last)` of a map with increasing explicitness in specifying the type of comparison function of class **Traits** and allocator.  
  
## Example  
  
```  
// multimap_ctor.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    typedef pair <int, int> Int_Pair;  
  
    // Create an empty multimap m0 of key type integer  
    multimap <int, int> m0;  
  
    // Create an empty multimap m1 with the key comparison  
    // function of less than, then insert 4 elements  
    multimap <int, int, less<int> > m1;  
    m1.insert(Int_Pair(1, 10));  
    m1.insert(Int_Pair(2, 20));  
    m1.insert(Int_Pair(3, 30));  
    m1.insert(Int_Pair(4, 40));  
  
    // Create an empty multimap m2 with the key comparison  
    // function of geater than, then insert 2 elements  
    multimap <int, int, less<int> > m2;  
    m2.insert(Int_Pair(1, 10));  
    m2.insert(Int_Pair(2, 20));  
  
    // Create a multimap m3 with the   
    // allocator of multimap m1  
    multimap <int, int>::allocator_type m1_Alloc;  
    m1_Alloc = m1.get_allocator();  
    multimap <int, int> m3(less<int>(), m1_Alloc);  
    m3.insert(Int_Pair(3, 30));  
  
    // Create a copy, multimap m4, of multimap m1  
    multimap <int, int> m4(m1);  
  
    // Create a multimap m5 by copying the range m1[_First, _Last)  
    multimap <int, int>::const_iterator m1_bcIter, m1_ecIter;  
    m1_bcIter = m1.begin();  
    m1_ecIter = m1.begin();  
    m1_ecIter++;  
    m1_ecIter++;  
    multimap <int, int> m5(m1_bcIter, m1_ecIter);  
  
    // Create a multimap m6 by copying the range m4[_First, _Last)  
    // and with the allocator of multimap m2  
    multimap <int, int>::allocator_type m2_Alloc;  
    m2_Alloc = m2.get_allocator();  
    multimap <int, int> m6(m4.begin(), ++m4.begin(), less<int>(), m2_Alloc);  
  
    cout << "m1 =";  
    for (auto i : m1)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m2 =";  
    for (auto i : m2)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m3 =";  
    for (auto i : m3)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m4 =";  
    for (auto i : m4)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m5 =";  
    for (auto i : m5)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m6 =";  
    for (auto i : m6)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    // Create a multimap m8 by copying in an initializer_list  
    multimap<int, int> m8{ { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } } };  
    cout << "m8: = ";  
    for (auto i : m8)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    // Create a multimap m9 with an initializer_list and a comparator  
    multimap<int, int> m9({ { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 } }, less<int>());  
    cout << "m9: = ";  
    for (auto i : m9)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    // Create a multimap m10 with an initializer_list, a comparator, and an allocator  
    multimap<int, int> m10({ { 9, 9 }, { 10, 10 }, { 11, 11 }, { 12, 12 } }, less<int>(), m9.get_allocator());  
    cout << "m10: = ";  
    for (auto i : m10)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
}  
  
```  
  
## Output  
 **m1 =1 10, 2 20, 3 30, 4 40,m2 =1 10, 2 20,m3 =3 30,m4 =1 10, 2 20, 3 30, 4 40,m5 =1 10, 2 20,m6 =1 10,m8: = 1 1, 2 2, 3 3, 4 4,m9: = 5 5, 6 6, 7 7, 8 8,m10: = 9 9, 10 10, 11 11, 12 12,**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)