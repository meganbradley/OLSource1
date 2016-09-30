---
title: "set::set"
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
  - "set::set"
  - "std::set::set"
  - "std.set.set"
  - "set"
  - "set/std::set::set"
  - "set.set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set class, using custom comparators"
  - "set method"
  - "set class, constructor"
ms.assetid: 592c1d24-12a7-436b-9bca-d6c90de86f4e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::set
Constructs a set that is empty or that is a copy of all or part of some other set.  
  
## Syntax  
  
```  
set( );  
explicit set(  
    const Traits& Comp  
);  
set(  
    const Traits& Comp,  
    const Allocator& Al  
);  
set(  
    const set& Right  
);  
set(  
    set&& Right  
);  
set(  
    initializer_list<Type> IList  
);  
set(  
    initializer_list<Type> IList,  
    const Compare& Comp  
);  
set(  
    initializer_list<Type> IList,  
    const Compare& Comp,   
    const Allocator& Al  
);  
  
template<class InputIterator>  
    set(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>  
    set(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp  
    );  
template<class InputIterator>  
    set(  
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
|`Al`|The storage allocator class to be used for this set object, which defaults to **Allocator**.|  
|`Comp`|The comparison function of type `const Traits` used to order the elements in the set, which defaults to `Compare`.|  
|`Rght`|The set of which the constructed set is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list from which to copy the elements.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the set and that can later be returned by calling [get_allocator](../vs140/set--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their sets.  
  
 All constructors store a function object of type **Traits** that is used to establish an order among the keys of the set and that can later be returned by calling [key_comp](../vs140/set--key_comp.md).  
  
 The first three constructors specify an empty initial set, the second specifying the type of comparison function (`comp`) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (`al`) to be used. The keyword **explicit** suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the set `right`.  
  
 The next three constructors use an initializer_list to specify the elements.  
  
 The next three constructors copy the range [`first`, `last`) of a set with increasing explicitness in specifying the type of comparison function of class **Traits** and **Allocator**.  
  
 The eighth constructor specifies a copy of the set by moving `right`.  
  
## Example  
  
```  
// set_set.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
  
    // Create an empty set s0 of key type integer  
    set <int> s0;  
  
    // Create an empty set s1 with the key comparison  
    // function of less than, then insert 4 elements  
    set <int, less<int> > s1;  
    s1.insert(10);  
    s1.insert(20);  
    s1.insert(30);  
    s1.insert(40);  
  
    // Create an empty set s2 with the key comparison  
    // function of less than, then insert 2 elements  
    set <int, less<int> > s2;  
    s2.insert(10);  
    s2.insert(20);  
  
    // Create a set s3 with the   
    // allocator of set s1  
    set <int>::allocator_type s1_Alloc;  
    s1_Alloc = s1.get_allocator();  
    set <int> s3(less<int>(), s1_Alloc);  
    s3.insert(30);  
  
    // Create a copy, set s4, of set s1  
    set <int> s4(s1);  
  
    // Create a set s5 by copying the range s1[_First, _Last)  
    set <int>::const_iterator s1_bcIter, s1_ecIter;  
    s1_bcIter = s1.begin();  
    s1_ecIter = s1.begin();  
    s1_ecIter++;  
    s1_ecIter++;  
    set <int> s5(s1_bcIter, s1_ecIter);  
  
    // Create a set s6 by copying the range s4[_First, _Last)  
    // and with the allocator of set s2  
    set <int>::allocator_type s2_Alloc;  
    s2_Alloc = s2.get_allocator();  
    set <int> s6(s4.begin(), ++s4.begin(), less<int>(), s2_Alloc);  
  
    cout << "s1 =";  
    for (auto i : s1)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "s2 = " << *s2.begin() << " " << *++s2.begin() << endl;  
  
    cout << "s3 =";  
    for (auto i : s3)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "s4 =";  
    for (auto i : s4)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "s5 =";  
    for (auto i : s5)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "s6 =";  
    for (auto i : s6)  
        cout << " " << i;  
    cout << endl;  
  
    // Create a set by moving s5  
    set<int> s7(move(s5));  
    cout << "s7 =";  
    for (auto i : s7)  
        cout << " " << i;  
    cout << endl;  
  
    // Create a set with an initializer_list  
    cout << "s8 =";  
    set<int> s8{ { 1, 2, 3, 4 } };  
    for (auto i : s8)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "s9 =";  
    set<int> s9{ { 5, 6, 7, 8 }, less<int>() };  
    for (auto i : s9)  
        cout << " " << i;  
    cout << endl;  
  
    cout << "s10 =";  
    set<int> s10{ { 10, 20, 30, 40 }, less<int>(), s9.get_allocator() };  
    for (auto i : s10)  
        cout << " " << i;  
    cout << endl;  
}  
  
```  
  
 **s1 = 10 20 30 40s2 = 10 20s3 = 30s4 = 10 20 30 40s5 = 10 20s6 = 10s7 = 10 20s8 = 1 2 3 4s9 = 5 6 7 8s10 = 10 20 30 40**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)