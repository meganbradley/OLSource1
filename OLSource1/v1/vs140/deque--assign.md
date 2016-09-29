---
title: "deque::assign"
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
  - "assign"
  - "deque.assign"
  - "Assign"
  - "std.deque.assign"
  - "std::deque::assign"
  - "deque/std::deque::assign"
  - "deque::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
  - "assign function"
ms.assetid: 07b57b31-474d-486a-8e3f-9a015031860b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::assign
Erases elements from a deque and copies a new set of elements to the target deque.  
  
## Syntax  
  
```  
template<class InputIterator>  
    void assign(  
    InputIterator First,  
    InputIterator Last);  
void assign(  
    size_type Count,  
    const Type& Val  
);  
void assign(  
    initializer_list<Type> IList  
);  
```  
  
#### Parameters  
 `First`  
 Position of the first element in the range of elements to be copied from the argument deque.  
  
 `Last`  
 Position of the first element beyond the range of elements to be copied from the argument deque.  
  
 `Count`  
 The number of copies of an element being inserted into the deque.  
  
 `Val`  
 The value of the element being inserted into the deque.  
  
 `IList`  
 The initializer_list being inserted into the deque.  
  
## Remarks  
 After any existing elements in the target deque are erased, `assign` either inserts a specified range of elements from the original deque or from some other deque into the target deque, or inserts copies of a new element of a specified value into the target deque.  
  
## Example  
  
```  
// deque_assign.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
#include <initializer_list>  
  
int main()  
{  
    using namespace std;  
    deque <int> c1, c2;  
    deque <int>::const_iterator cIter;  
  
    c1.push_back(10);  
    c1.push_back(20);  
    c1.push_back(30);  
    c2.push_back(40);  
    c2.push_back(50);  
    c2.push_back(60);  
  
    deque<int> d1{ 1, 2, 3, 4 };  
    initializer_list<int> iList{ 5, 6, 7, 8 };  
    d1.assign(iList);  
  
    cout << "d1 = ";  
    for (int i : d1)  
        cout << i;  
    cout << endl;  
  
    cout << "c1 =";  
    for (int i : c1)  
        cout << i;  
    cout << endl;  
  
    c1.assign(++c2.begin(), c2.end());  
    cout << "c1 =";  
    for (int i : c1)  
        cout << i;  
    cout << endl;  
  
    c1.assign(7, 4);  
    cout << "c1 =";  
    for (int i : c1)  
        cout << i;  
    cout << endl;  
  
}  
  
```  
  
 **d1 = 5678c1 =102030c1 =5060c1 =4444444**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::assign and deque::swap](../vs140/deque--assign-and-deque--swap.md)   
 [Standard Template Library](../vs140/standard-template-library.md)