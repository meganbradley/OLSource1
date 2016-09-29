---
title: "unordered_set::unordered_set"
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
  - "tr1.unordered_set.unordered_set"
  - "unordered_set.unordered_set"
  - "unordered_set::unordered_set"
  - "std.tr1.unordered_set.unordered_set"
  - "unordered_set"
  - "unordered_set/std::tr1::unordered_set::unordered_set"
  - "tr1::unordered_set::unordered_set"
  - "std::tr1::unordered_set::unordered_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_set constructor [TR1]"
  - "unordered_set method"
ms.assetid: 16bb6e69-a010-44b0-b43b-07508775785e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::unordered_set
Constructs a container object.  
  
## Syntax  
  
```  
unordered_set(  
    const unordered_set& Right  
);  
explicit unordered_set(  
    size_type bucket_count = N0,  
    const Hash& Hash = Hash(),  
    const Comp& Comp = Comp(),  
    const Allocator& Al = Alloc()  
);  
unordered_set(  
    unordered_set&& Right  
);  
unordered_set(  
    initializer_list<Type> IList  
);  
unordered_set(  
    initializer_list<Type> IList,   
    size_type bucket_count  
);  
unordered_set(  
    initializer_list<Type> IList,   
    size_type bucket_count,  
    const Hash& Hash  
);  
unordered_set(  
    initializer_list<Type> IList,   
    size_type bucket_count,  
    const Hash& Hash,  
    const Comp& Comp  
);  
unordered_set(  
    initializer_list<Type> IList,   
    size_type bucket_count,  
    const Hash& Hash,  
    const Comp& Comp,  
    const Allocator& Al  
);  
template<class InputIterator>  
    unordered_set(  
    InputIterator first,   
    InputIterator last,  
    size_type bucket_count = N0,  
    const Hash& Hash = Hash(),  
    const Comp& Comp = Comp(),  
    const Allocator& Al = Alloc());  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`InputIterator`|The iterator type.|  
|`Al`|The allocator object to store.|  
|`Comp`|The comparison function object to store.|  
|`Hash`|The hash function object to store.|  
|`bucket_count`|The minimum number of buckets.|  
|`Right`|The container to copy.|  
|`IList`|The initializer_list containing the elements to copy.|  
  
## Remarks  
 The first constructor specifies a copy of the sequence controlled by `Right`. The second constructor specifies an empty controlled sequence. The third constructor specifies a copy of the sequence by moving `Right` The fourth through eighth constructors use an initializer_list to specify the elements to copy. The ninth constructor inserts the sequence of element values `[first, last)`.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from `Right`. Otherwise:  
  
 The minimum number of buckets is the argument `bucket_count`, if present; otherwise it is a default value described here as the implementation-defined value `N0`.  
  
 The hash function object is the argument `Hash`, if present; otherwise it is `Hash()`.  
  
 The comparison function object is the argument `Comp`, if present; otherwise it is `Comp()`.  
  
 The allocator object is the argument `Al`, if present; otherwise, it is `Alloc()`.  
  
## Example  
  
### Code  
  
```  
/ std_tr1__unordered_set__unordered_set_construct.cpp   
// compile with: /EHsc   
#include <unordered_set>   
#include <iostream>   
  
using namespace std;  
  
typedef unordered_set<char> Myset;  
int main()  
{  
    Myset c1;  
  
    c1.insert('a');  
    c1.insert('b');  
    c1.insert('c');  
  
    // display contents " [c] [b] [a]"   
    for (auto& c : c1){  
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
    for (auto& c : c2){  
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
    for (auto& c : c3){  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
  
    Myset c4(move(c3));  
  
    // display contents " [c] [b] [a]"   
    for (auto& c : c4){  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
  
    Myset c5{ { 'a', 'b', 'c' } };  
  
    for (auto& c : c5){  
        cout << " [" << c << "]";  
    }  
    cout << endl;  
}  
```  
  
### Output  
  
```  
[a] [b] [c]  
 [d] [e] [f]  
 [a] [b] [c]  
 [a] [b] [c]  
```  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)