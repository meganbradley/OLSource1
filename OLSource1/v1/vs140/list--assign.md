---
title: "list::assign"
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
  - "list::assign"
  - "list.assign"
  - "assign"
  - "std.list.assign"
  - "list/std::list::assign"
  - "Assign"
  - "std::list::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
  - "assign function"
ms.assetid: 11910f04-6827-48c8-97a3-01043b566df7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::assign
Erases elements from a list and copies a new set of elements to a target list.  
  
## Syntax  
  
```  
void assign(  
    size_type Count,  
    const Type& Val  
);  
void assign  
    initializer_list<Type> IList  
);  
template<class InputIterator>  
    void assign(  
        InputIterator First,  
        InputIterator Last  
    );  
  
```  
  
#### Parameters  
 `First`  
 Position of the first element in the range of elements to be copied from the argument list.  
  
 `Last`  
 Position of the first element just beyond the range of elements to be copied from the argument list.  
  
 `Count`  
 The number of copies of an element being inserted into the list.  
  
 `Val`  
 The value of the element being inserted into the list.  
  
 `IList`  
 The initializer_list that contains the elements to be inserted.  
  
## Remarks  
 After erasing any existing elements in the target list, assign either inserts a specified range of elements from the original list or from some other list into the target list or inserts copies of a new element of a specified value into the target list  
  
## Example  
  
```  
// list_assign.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    list<int> c1, c2;  
    list<int>::const_iterator cIter;  
  
    c1.push_back(10);  
    c1.push_back(20);  
    c1.push_back(30);  
    c2.push_back(40);  
    c2.push_back(50);  
    c2.push_back(60);  
  
    cout << "c1 =";  
    for (auto c : c1)  
        cout << " " << c;  
    cout << endl;  
  
    c1.assign(++c2.begin(), c2.end());  
    cout << "c1 =";  
    for (auto c : c1)  
        cout << " " << c;  
    cout << endl;  
  
    c1.assign(7, 4);  
    cout << "c1 =";  
    for (auto c : c1)  
        cout << " " << c;  
    cout << endl;  
  
    c1.assign({ 10, 20, 30, 40 });  
    cout << "c1 =";  
    for (auto c : c1)  
        cout << " " << c;  
    cout << endl;  
}  
```  
  
 **c1 = 10 20 30c1 = 50 60c1 = 4 4 4 4 4 4 4c1 = 10 20 30 40**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)