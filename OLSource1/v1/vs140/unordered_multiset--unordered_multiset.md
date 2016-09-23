---
title: "unordered_multiset::unordered_multiset"
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
  - tr1.unordered_multiset.unordered_multiset
  - unordered_multiset::unordered_multiset
  - unordered_multiset.unordered_multiset
  - unordered_set/std::tr1::unordered_multiset::unordered_multiset
  - unordered_multiset
  - tr1::unordered_multiset::unordered_multiset
  - std.tr1.unordered_multiset.unordered_multiset
  - std::tr1::unordered_multiset::unordered_multiset
dev_langs: 
  - C++
helpviewer_keywords: 
  - unordered_multiset constructor [TR1]
  - unordered_multiset method
ms.assetid: 2f38c584-cbc2-4094-9a11-03a6d8a60584
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# unordered_multiset::unordered_multiset
Constructs a container object.  
  
## Syntax  
  
```  
unordered_multiset(  
    const unordered_multiset& Right  
);  
explicit unordered_multiset(  
    size_type Bucket_count = N0,  
    const Hash& Hash = Hash(),  
    const Comp& Comp = Comp(),  
    const Allocator& Al = Alloc()  
);  
unordered_multiset(  
    unordered_multiset&& Right  
);  
unordered_set(  
    initializer_list<Type> IList  
);  
unordered_set(  
    initializer_list<Typ > IList,  
    size_type Bucket_count  
);  
unordered_set(  
    initializer_list<Type> IList,   
    size_type Bucket_count,   
    const Hash& Hash  
);   
unordered_set(  
    initializer_list<Type> IList,   
    size_type Bucket_count,   
    const Hash& Hash,   
    const Key& Key  
);  
unordered_set(  
    initializer_list<Type> IList,   
    size_type Bucket_count,   
    const Hash& Hash,   
    const Key& Key,   
    const Allocator& Al  
);  
template<class InputIterator>  
    unordered_multiset(  
        InputIterator First,   
        InputIterator Last,  
        size_type Bucket_count = N0,  
        const Hash& Hash = Hash(),  
        const Comp& Comp = Comp(),  
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
|`IList`|The initializer_list from which to copy.|  
  
## Remarks  
 The first constructor specifies a copy of the sequence controlled by `Right`. The second constructor specifies an empty controlled sequence. The third constructor inserts the sequence of element values `[First, Last)`. The fourth constructor specifies a copy of the sequence by moving `Right`.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from `Right`. Otherwise:  
  
 The minimum number of buckets is the argument `Bucket_count`, if present; otherwise it is a default value described here as the implementation-defined value `N0`.  
  
 The hash function object is the argument `Hash`, if present; otherwise it is `Hash()`.  
  
 The comparison function object is the argument `Comp`, if present; otherwise it is `Comp()`.  
  
 The allocator object is the argument `Al`, if present; otherwise, it is `Alloc()`.  
  
## Example  
  
### Code  
  
```  
/ std_tr1__unordered_set__unordered_multiset_construct.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
using namespace std;  
  
typedef unordered_multiset<char> Myset;  
  
int main()  
{  
    Myset c1;  
  
    c1.insert('a');  
    c1.insert('b');  
    c1.insert('c');  
  
    // display contents " [c] [b] [a]"   
    for (auto& c : c1) {  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
  
    Myset c2(8,  
        hash<char>(),  
        equal_to<char>(),  
        allocator<pair<const char, int> >());  
  
    c2.insert('d');  
    c2.insert('e');  
    c2.insert('f');  
  
    // display contents " [f] [e] [d]"   
    for (auto& c : c2) {  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
  
    Myset c3(c1.begin(),  
        c1.end(),  
        8,  
        hash<char>(),  
        equal_to<char>(),  
        allocator<pair<const char, int> >());  
  
    // display contents " [c] [b] [a]"   
    for (auto& c : c3) {  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
  
    Myset c4(move(c3));  
  
    // display contents " [c] [b] [a]"   
    for (auto& c : c4) {  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
  
    Myset c5{ { 'g', 'h' } };  
    for (auto& c : c5) {  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
}  
// std_tr1__unordered_set__unordered_multiset_construct.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
typedef std::unordered_multiset<char> Myset;   
int main()   
    {   
    Myset c1;   
  
    c1.insert('a');   
    c1.insert('b');   
    c1.insert('c');   
  
// display contents " [c] [b] [a]"   
    for (Myset::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    Myset c2(8,   
        std::hash<char>(),   
        std::equal_to<char>(),   
        std::allocator<std::pair<const char, int> >());   
  
    c2.insert('d');   
    c2.insert('e');   
    c2.insert('f');   
  
// display contents " [f] [e] [d]"   
    for (Myset::const_iterator it = c2.begin();   
        it != c2.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    Myset c3(c1.begin(),   
        c1.end(),   
        8,   
        std::hash<char>(),   
        std::equal_to<char>(),   
        std::allocator<std::pair<const char, int> >());   
  
// display contents " [c] [b] [a]"   
    for (Myset::const_iterator it = c3.begin();   
        it != c3.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    Myset c4(std::move(c3));  
  
// display contents " [c] [b] [a]"   
    for (Myset::const_iterator it = c3.begin();   
        it != c3.end(); ++it)   
        std::cout << " [" << *it << "]";   
    std::cout << std::endl;   
  
    return (0);   
    }  
  
```  
  
### Output  
  
```  
[a] [b] [c]  
 [d] [e] [f]  
 [a] [b] [c]  
 [a] [b] [c]  
 [g] [h]  
```  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)