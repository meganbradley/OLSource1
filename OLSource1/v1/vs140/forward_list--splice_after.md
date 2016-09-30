---
title: "forward_list::splice_after"
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
  - "forward_list.splice_after"
  - "forward_list::splice_after"
  - "splice_after"
  - "std.forward_list.splice_after"
  - "forward_list/std::forward_list::splice_after"
  - "std::forward_list::splice_after"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "splice_after method"
ms.assetid: 93c4f10b-473e-4c39-ba1f-3de79c210094
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::splice_after
Removes elements from a source forward_list and inserts them into a destination forward_list.  
  
## Syntax  
  
```  
// insert the entire source forward_list  
void splice_after( const_iterator Where, forward_list& Source );  
void splice_after( const_iterator Where, forward_list&& Source );  
  
// insert one element of the source forward_list  
void splice_after( const_iterator Where, forward_list& Source, const_iterator Iter );  
void splice_after( const_iterator Where, forward_list&& Source, const_iterator Iter );  
  
// insert a range of elements from the source forward_list  
void splice_after( const_iterator Where, forward_list& Source, const_iterator First, const_iterator Last );  
void splice_after( const_iterator Where, forward_list&& Source, const_iterator First, const_iterator Last );  
```  
  
#### Parameters  
 `Where`  
 The position in the destination forward_list after which to insert.  
  
 `Source`  
 The source forward_list that is to be inserted into the destination forward_list.  
  
 `Iter`  
 The element to be inserted from the source forward_list.  
  
 `First`  
 The first element in the range to be inserted from source forward_list.  
  
 `Last`  
 The first position beyond the range to be inserted from the source forward_list.  
  
## Remarks  
 The first pair of member functions inserts the sequence controlled by `Source` just after the element in the controlled sequence pointed to by `Where`. It also removes all elements from `Source`. (`&Source` must not equal `this`.)  
  
 The second pair of member functions removes the element just after `Iter` in the sequence controlled by `Source` and inserts it just after the element in the controlled sequence pointed to by `Where`. (If `Where == Iter || Where == ++Iter`, no change occurs.)  
  
 The third pair of member functions (ranged splice) inserts the subrange designated by `(First, Last)` from the sequence controlled by `Source` just after the element in the controlled sequence pointed to by `Where`. It also removes the original subrange from the sequence controlled by `Source`. (If `&Source == this`, the range `(First, Last)` must not include the element pointed to by `Where`.)  
  
 If the ranged splice inserts `N` elements, and `&Source != this`, an object of class [iterator](../vs140/forward_list--iterator.md) is incremented `N` times.  
  
 No iterators, pointers, or references that designate spliced elements become invalid.  
  
## Example  
  
```cpp  
// forward_list_splice_after.cpp  
// compile with: /EHsc /W4  
#include <forward_list>  
#include <iostream>  
  
using namespace std;  
  
template <typename S> void print(const S& s) {  
    for (const auto& p : s) {  
        cout << "(" << p << ") ";  
    }  
  
    cout << endl;  
}  
  
int main()  
{  
    forward_list<int> c1{ 10, 11 };  
    forward_list<int> c2{ 20, 21, 22 };  
    forward_list<int> c3{ 30, 31 };  
    forward_list<int> c4{ 40, 41, 42, 43 };  
  
    forward_list<int>::iterator where_iter;  
    forward_list<int>::iterator first_iter;  
    forward_list<int>::iterator last_iter;  
  
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
    c2.splice_after(where_iter, c1);  
    cout << "After splicing c1 into c2:" << endl;  
    cout << "c1 = ";  
    print(c1);  
    cout << "c2 = ";  
    print(c2);  
  
    first_iter = c3.begin();  
    c2.splice_after(where_iter, c3, first_iter);  
    cout << "After splicing the first element of c3 into c2:" << endl;  
    cout << "c3 = ";  
    print(c3);  
    cout << "c2 = ";  
    print(c2);  
  
    first_iter = c4.begin();  
    last_iter = c4.end();  
    // set up to get the middle elements  
    ++first_iter;  
    c2.splice_after(where_iter, c4, first_iter, last_iter);  
    cout << "After splicing a range of c4 into c2:" << endl;  
    cout << "c4 = ";  
    print(c4);  
    cout << "c2 = ";  
    print(c2);  
}  
  
```  
  
 **Beginning state of lists:c1 = (10) (11)c2 = (20) (21) (22)c3 = (30) (31)c4 = (40) (41) (42) (43)After splicing c1 into c2:c1 =c2 = (20) (21) (10) (11) (22)After splicing the first element of c3 into c2:c3 = (30)c2 = (20) (21) (31) (10) (11) (22)After splicing a range of c4 into c2:c4 = (40) (41)c2 = (20) (21) (42) (43) (31) (10) (11) (22)**   
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)