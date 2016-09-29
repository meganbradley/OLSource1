---
title: "list::insert"
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
  - "std::list::insert"
  - "Insert"
  - "insert"
  - "list.insert"
  - "list::insert"
  - "list/std::list::insert"
  - "std.list.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 9df9f43b-30cd-43a5-b349-c43f741edd4b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::insert
Inserts an element or a number of elements or a range of elements into a list at a specified position.  
  
## Syntax  
  
```  
iterator insert(  
    iterator Where,  
    const Type& Val  
);  
iterator insert(  
    iterator Where,  
    Type&& Val  
);  
void insert(  
    iterator Where,  
    size_type Count,  
    const Type& Val  
);  
iterator insert(  
    iterator Where,  
    initializer_list<Type> IList  
);  
template<class InputIterator>  
    void insert(  
        iterator Where,  
        InputIterator First,  
        InputIterator Last  
    );  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Where`|The position in the target list where the first element is inserted.|  
|`Val`|The value of the element being inserted into the list.|  
|`Count`|The number of elements being inserted into the list.|  
|`First`|The position of the first element in the range of elements in the argument list to be copied.|  
|`Last`|The position of the first element beyond the range of elements in the argument list to be copied.|  
  
## Return Value  
 The first two insert functions return an iterator that points to the position where the new element was inserted into the list.  
  
## Example  
  
```  
// list_class_insert.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
#include <string>  
  
int main()  
{  
    using namespace std;  
    list <int> c1, c2;  
    list <int>::iterator Iter;  
  
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
  
    Iter = c1.begin();  
    Iter++;  
    c1.insert(Iter, 100);  
    cout << "c1 =";  
    for (auto c : c1)  
        cout << " " << c;  
    cout << endl;  
  
    Iter = c1.begin();  
    Iter++;  
    Iter++;  
    c1.insert(Iter, 2, 200);  
  
    cout << "c1 =";  
    for(auto c : c1)  
        cout << " " << c;  
    cout << endl;  
  
    c1.insert(++c1.begin(), c2.begin(), --c2.end());  
  
    cout << "c1 =";  
    for (auto c : c1)  
        cout << " " << c;  
    cout << endl;  
  
    // initialize a list of strings by moving  
    list < string > c3;  
    string str("a");  
  
    c3.insert(c3.begin(), move(str));  
    cout << "Moved first element: " << c3.front() << endl;  
  
    // Assign with an initializer_list  
    list <int> c4{ {1, 2, 3, 4} };  
    c4.insert(c4.begin(), { 5, 6, 7, 8 });  
  
    cout << "c4 =";  
    for (auto c : c4)  
        cout << " " << c;  
    cout << endl;  
}  
```  
  
## Output  
 c1 = 10 20 30c1 = 10 100 20 30c1 = 10 100 200 200 20 30c1 = 10 40 50 100 200 200 20 30Moved first element: ac4 = 5 6 7 8 1 2 3 4  
  
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)