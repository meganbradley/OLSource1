---
title: "unordered_multimap::unordered_multimap"
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
  - "std::tr1::unordered_multimap::unordered_multimap"
  - "unordered_map/std::tr1::unordered_multimap::unordered_multimap"
  - "tr1.unordered_multimap.unordered_multimap"
  - "unordered_multimap.unordered_multimap"
  - "unordered_multimap::unordered_multimap"
  - "tr1::unordered_multimap::unordered_multimap"
  - "std.tr1.unordered_multimap.unordered_multimap"
  - "unordered_multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_multimap constructor [TR1]"
  - "unordered_multimap method"
ms.assetid: 7d1bb097-55a1-49fc-b59f-c9eb56f7f673
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::unordered_multimap
Constructs a container object.  
  
## Syntax  
  
```  
unordered_multimap(  
    const unordered_multimap& Right  
);  
explicit unordered_multimap(  
    size_type Bucket_count = N0,  
    const Hash& Hash = Hash(),  
    const Comp& Comp = Pred(),  
    const Allocator& Al = Alloc()  
);  
unordered_multimap(  
    unordered_multimap&& Right  
);  
unordered_multimap(  
    initializer_list<Type> IList  
);  
unordered_multimap(  
    initializer_list< Type > IList,  
    size_type Bucket_count  
);  
unordered_multimap(  
    initializer_list< Type > IList,  
    size_type Bucket_count,   
    const Hash& Hash  
);  
unordered_multimap(  
    initializer_list< Type > IList,  
    size_type Bucket_count,   
    const Hash& Hash,  
    const Key& Key  
);  
unordered_multimap(  
    initializer_list<Type> IList,  
    size_type Bucket_count,   
    const Hash& Hash,  
    const Key& Key,   
    const Allocator& Al  
);  
template<class InputIterator>  
    unordered_multimap(  
        InputIterator first,         InputIterator last,  
        size_type Bucket_count = N0,  
        const Hash& Hash = Hash(),  
        const Comp& Comp = Pred(),  
        const Allocator& Al = Alloc()  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`InputIterator`|The iterator type.|  
|`Al`|The allocator object to store.|  
|`Comp`|The comparison function object to store.|  
|`Hash`|The hash function object to store.|  
|`Bucket_count`|The minimum number of buckets.|  
|`Right`|The container to copy.|  
|`IList`|The initializer_list from which to copy the elements.|  
  
## Remarks  
 The first constructor specifies a copy of the sequence controlled by `Right`. The second constructor specifies an empty controlled sequence. The third constructor. specifies a copy of the sequence by moving `Right`. The fourth, fifth, sixth, seventh, and eighth constructors use an initializer_list for the members. The ninth constructor inserts the sequence of element values `[First, Last)`.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from `Right`. Otherwise:  
  
 The minimum number of buckets is the argument `Bucket_count`, if present; otherwise it is a default value described here as the implementation-defined value `N0`.  
  
 The hash function object is the argument `Hash`, if present; otherwise it is `Hash()`.  
  
 The comparison function object is the argument `Comp`, if present; otherwise it is `Pred()`.  
  
 The allocator object is the argument `Al`, if present; otherwise, it is `Alloc()`.  
  
## Example  
  
```  
// std__unordered_map__unordered_multimap_construct.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
  
using namespace std;  
  
using  Mymap = unordered_multimap<char, int> ;  
int main()  
{  
    Mymap c1;  
  
    c1.insert(Mymap::value_type('a', 1));  
    c1.insert(Mymap::value_type('b', 2));  
    c1.insert(Mymap::value_type('c', 3));  
  
    // display contents " [c 3] [b 2] [a 1]"   
    for (const auto& c : c1) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    Mymap c2(8,  
        hash<char>(),  
        equal_to<char>(),  
        allocator<pair<const char, int> >());  
  
    c2.insert(Mymap::value_type('d', 4));  
    c2.insert(Mymap::value_type('e', 5));  
    c2.insert(Mymap::value_type('f', 6));  
  
    // display contents " [f 6] [e 5] [d 4]"   
    for (const auto& c : c2) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    Mymap c3(c1.begin(),  
        c1.end(),  
        8,  
        hash<char>(),  
        equal_to<char>(),  
        allocator<pair<const char, int> >());  
  
    // display contents " [c 3] [b 2] [a 1]"   
    for (const auto& c : c3) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    Mymap c4(move(c3));  
  
    // display contents " [c 3] [b 2] [a 1]"   
    for (const auto& c : c4) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    // Construct with an initializer_list  
    unordered_multimap<int, char> c5({ { 5, 'g' }, { 6, 'h' }, { 7, 'i' }, { 8, 'j' } });  
    for (const auto& c : c5) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    // Initializer_list plus size  
    unordered_multimap<int, char> c6({ { 5, 'g' }, { 6, 'h' }, { 7, 'i' }, { 8, 'j' } }, 4);  
    for (const auto& c : c1) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    // Initializer_list plus size and hash  
    unordered_multimap<int, char, tr1::hash<char>> c7(  
        { { 5, 'g' }, { 6, 'h' }, { 7, 'i' }, { 8, 'j' } },  
        4,  
        tr1::hash<char>()  
    );  
  
    for (const auto& c : c1) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    // Initializer_list plus size, hash, and key_equal  
    unordered_multimap<int, char, tr1::hash<char>, equal_to<char>> c8(  
        { { 5, 'g' }, { 6, 'h' }, { 7, 'i' }, { 8, 'j' } },  
        4,  
        tr1::hash<char>(),  
        equal_to<char>()  
    );  
  
    for (const auto& c : c1) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
  
    // Initializer_list plus size, hash, key_equal, and allocator  
    unordered_multimap<int, char, tr1::hash<char>, equal_to<char>> c9(  
        { { 5, 'g' }, { 6, 'h' }, { 7, 'i' }, { 8, 'j' } },  
        4,  
        tr1::hash<char>(),  
        equal_to<char>(),  
        allocator<pair<const char, int> >()  
    );  
  
    for (const auto& c : c1) {  
        cout << " [" << c.first << ", " << c.second << "]";  
    }  
    cout << endl;  
}  
  
```  
  
 **[a, 1] [b, 2] [c, 3] [d, 4] [e, 5] [f, 6] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [5, g] [6, h] [7, i] [8, j] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [c, 3] [b, 2] [a, 1]**  
 **[f, 6] [e, 5] [d, 4]**  
 **[c, 3] [b, 2] [a, 1]**  
 **[c, 3] [b, 2] [a, 1]**   
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)