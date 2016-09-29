---
title: "deque::operator="
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
  - "deque::operator="
  - "="
  - "operator="
  - "std::deque::operator="
  - "deque/std::deque::operator="
  - "std.deque.operator="
  - "deque.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific standard C++ objects"
  - "operator =, deque objects"
  - "operator=, deque objects"
ms.assetid: 77db5b35-e6e8-4a5c-a4df-821a8e68b446
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::operator=
Replaces the elements of this deque using the elements from another deque.  
  
## Syntax  
  
```  
deque& operator=(  
   const deque& _Right  
);  
deque& operator=(  
   deque&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The deque that provides the new content.|  
  
## Remarks  
 The first override copies elements to this deque from `_Right`, the source of the assignment. The second override moves elements to this deque from `_Right`.  
  
 Elements that are contained in this deque before the operator executes are removed.  
  
## Example  
  
```  
// deque_operator_as.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
using namespace std;  
  
typedef deque<int> MyDeque;  
  
template<typename MyDeque> struct S;  
  
template<typename MyDeque> struct S<MyDeque&> {  
  static void show( MyDeque& d ) {  
    MyDeque::const_iterator iter;  
    for (iter = d.cbegin(); iter != d.cend(); iter++)  
       cout << *iter << " ";  
    cout << endl;  
  }  
};  
  
template<typename MyDeque> struct S<MyDeque&&> {  
  static void show( MyDeque&& d ) {  
    MyDeque::const_iterator iter;  
    for (iter = d.cbegin(); iter != d.cend(); iter++)  
       cout << *iter << " ";  
cout << " via unnamed rvalue reference " << endl;  
  }  
};  
  
int main( )  
{  
   MyDeque d1, d2;  
  
   d1.push_back(10);  
   d1.push_back(20);  
   d1.push_back(30);  
   d1.push_back(40);  
   d1.push_back(50);  
  
   cout << "d1 = " ;  
   S<MyDeque&>::show( d1 );  
  
   d2 = d1;  
   cout << "d2 = ";  
   S<MyDeque&>::show( d2 );  
  
   cout << "     ";  
   S<MyDeque&&>::show ( move< MyDeque& > (d1) );  
 }  
```  
  
## Output  
  
```  
d1 = 10 20 30 40 50   
d2 = 10 20 30 40 50   
     10 20 30 40 50 via unnamed rvalue reference  
```  
  
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)