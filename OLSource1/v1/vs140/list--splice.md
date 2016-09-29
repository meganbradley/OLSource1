---
title: "list::splice"
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
  - "std.list.splice"
  - "list/std::list::splice"
  - "list::splice"
  - "list.splice"
  - "splice"
  - "std::list::splice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "splice method"
ms.assetid: 40420837-597b-434f-b865-bc36dbe7d59f
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::splice
Removes elements from a source list and inserts them into a destination list.  
  
## Syntax  
  
```  
// insert the entire source list  
void splice( const_iterator Where, list<Type, Allocator>& Source );  
void splice( const_iterator Where, list<Type, Allocator>&& Source );  
  
// insert one element of the source list  
void splice( const_iterator Where, list<Type, Allocator>& Source, const_iterator Iter );  
void splice( const_iterator Where, list<Type, Allocator>&& Source, const_iterator Iter );  
  
// insert a range of elements from the source list  
void splice( const_iterator Where, list<Type, Allocator>& Source, const_iterator First, const_iterator Last );  
 void splice( const_iterator Where, list<Type, Allocator>&& Source, const_iterator First, const_iterator Last );  
```  
  
#### Parameters  
 `Where`  
 The position in the destination list before which to insert.  
  
 `Source`  
 The source list that is to be inserted into the destination list.  
  
 `Iter`  
 The element to be inserted from the source list.  
  
 `First`  
 The first element in the range to be inserted from the source list.  
  
 `Last`  
 The first position beyond the last element in the range to be inserted from the source list.  
  
## Remarks  
 The first pair of member functions inserts all elements in the source list into the destination list before the position referred to by `Where` and removes all elements from the source list. (`&Source` must not equal `this`.)  
  
 The second pair of member functions inserts the element referred to by `Iter` before the position in the destination list referred to by `Where` and removes `Iter` from the source list. (If `Where == Iter || Where == ++Iter`, no change occurs.)  
  
 The third pair of member functions inserts the range designated by [`First`, `Last`) before the element in the destination list referred to by `Where` and removes that range of elements from the source list. (If `&Source == this`, the range `[First, Last)` must not include the element pointed to by `Where`.)  
  
 If the ranged splice inserts `N` elements, and `&Source != this`, an object of class [iterator](../vs140/forward_list--iterator.md) is incremented `N` times.  
  
 In all cases iterators, pointers, or references that refer to spliced elements remain valid and are transferred to the destination container.  
  
## Example  
  
```cpp  
// list_splice.cpp  
// compile with: /EHsc /W4  
#include <list>  
#include <iostream>  
  
using namespace std;  
  
template <typename S> void print(const S& s) {  
    cout << s.size() << " elements: ";  
  
    for (const auto& p : s) {  
        cout << "(" << p << ") ";  
    }  
  
    cout << endl;  
}  
  
int main()  
{  
    list<int> c1{10,11};  
    list<int> c2{20,21,22};  
    list<int> c3{30,31};  
    list<int> c4{40,41,42,43};  
  
    list<int>::iterator where_iter;  
    list<int>::iterator first_iter;  
    list<int>::iterator last_iter;  
  
    cout << "Beginning state of lists:" << endl;  
    cout << "c1 = ";  
    print(c1);  
    cout << "c2 = ";  
    print(c2);  
    cout << "c3 = ";  
    print(c3);  
    cout << "c4 = ";  
    print(c4);  
  
    where_iter = c2.begin();  
    ++where_iter; // start at second element  
    c2.splice(where_iter, c1);  
    cout << "After splicing c1 into c2:" << endl;  
    cout << "c1 = ";  
    print(c1);  
    cout << "c2 = ";  
    print(c2);  
  
    first_iter = c3.begin();  
    c2.splice(where_iter, c3, first_iter);  
    cout << "After splicing the first element of c3 into c2:" << endl;  
    cout << "c3 = ";  
    print(c3);  
    cout << "c2 = ";  
    print(c2);  
  
    first_iter = c4.begin();  
    last_iter = c4.end();  
    // set up to get the middle elements  
    ++first_iter;  
    --last_iter;  
    c2.splice(where_iter, c4, first_iter, last_iter);  
    cout << "After splicing a range of c4 into c2:" << endl;  
    cout << "c4 = ";  
    print(c4);  
    cout << "c2 = ";  
    print(c2);  
}  
  
```  
  
 **Beginning state of lists:c1 = 2 elements: (10) (11)c2 = 3 elements: (20) (21) (22)c3 = 2 elements: (30) (31)c4 = 4 elements: (40) (41) (42) (43)After splicing c1 into c2:c1 = 0 elements:c2 = 5 elements: (20) (10) (11) (21) (22)After splicing the first element of c3 into c2:c3 = 1 elements: (31)c2 = 6 elements: (20) (10) (11) (30) (21) (22)After splicing a range of c4 into c2:c4 = 2 elements: (40) (43)c2 = 8 elements: (20) (10) (11) (30) (41) (42) (21) (22)**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)