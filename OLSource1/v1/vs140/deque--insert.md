---
title: "deque::insert"
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
  - std::deque::insert
  - deque::insert
  - Insert
  - insert
  - deque.insert
  - std.deque.insert
  - deque/std::deque::insert
dev_langs: 
  - C++
helpviewer_keywords: 
  - insert method
ms.assetid: e926d4c4-a1eb-42f1-a90a-0446f2fafefc
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::insert
Inserts an element or a number of elements or a range of elements into the deque at a specified position.  
  
## Syntax  
  
```  
iterator insert(  
    const_iterator Where,  
    const Type& Val  
);  
iterator insert(  
    const_iterator Where,  
    Type&& Val  
);  
void insert(  
    iterator Where,  
    size_type Count,  
    const Type& Val  
);  
template<class InputIterator>  
    void insert(  
        iterator Where,  
        InputIteratorFirst,  
        InputIteratorLast  
    );  
iterator insert(  
    iterator Where,initializer_list<Type> IList);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Where`|The position in the target deque where the first element is inserted.|  
|`Val`|The value of the element being inserted into the deque.|  
|`Count`|The number of elements being inserted into the deque.|  
|`First`|The position of the first element in the range of elements in the argument deque to be copied.|  
|`Last`|The position of the first element beyond the range of elements in the argument deque to be copied.|  
|`IList`|The initializer_list of elements to insert.|  
  
## Return Value  
 The first two insert functions return an iterator that points to the position where the new element was inserted into the deque.  
  
## Remarks  
 Any insertion operation can be expensive.  
  
## Code  
  
```  
// deque_insert.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
#include <string>  
  
int main()  
{  
    using namespace std;  
    deque <int> c1, c2;  
    deque <int>::iterator Iter;  
  
    c1.push_back(10);  
    c1.push_back(20);  
    c1.push_back(30);  
    c2.push_back(40);  
    c2.push_back(50);  
    c2.push_back(60);  
  
    cout << "[ c1 = ";  
    for (auto c1_iter : c1)  
        cout << c1_iter << " ";  
    cout << "]" << endl;  
  
    Iter = c1.begin();  
    Iter++;  
    c1.insert(Iter, 100);  
    cout << "[ c1 = ";  
    for (auto c1_iter : c1)  
        cout << c1_iter << " ";  
    cout << "]" << endl;  
  
    Iter = c1.begin();  
    Iter++;  
    Iter++;  
    c1.insert(Iter, 2, 200);  
  
    cout << "[ c1 = ";  
    for (auto c1_iter : c1)  
        cout << c1_iter << " ";  
    cout << "]" << endl;  
  
    c1.insert(++c1.begin(), c2.begin(), --c2.end());  
  
    cout << "[ c1 = ";  
    for (auto c1_iter : c1)  
        cout << c1_iter << " ";  
    cout << "]" << endl;  
  
    // initialize a deque of strings by moving  
    deque < string > c3;  
    string str("a");  
  
    c3.insert(c3.begin(), move(str));  
    cout << "Moved first element: " << c3.front() << endl;  
  
    c1.insert(c1.end(), { 70, 80, 90 });  
    for (auto c1_iter : c1)  
        cout << c1_iter << " ";  
    cout << endl;  
}// deque_insert.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
#include <string>  
  
int main( )   
{  
    using namespace std;  
    deque <int> c1, c2;  
    deque <int>::iterator Iter;  
  
    c1.push_back( 10 );  
    c1.push_back( 20 );  
    c1.push_back( 30 );  
    c2.push_back( 40 );  
    c2.push_back( 50 );  
    c2.push_back( 60 );  
  
    cout << "[ c1 = ";  
    for ( Iter = c1.begin( ); Iter != c1.end( ); Iter++ )  
        cout << *Iter << " ";  
    cout << "]" << endl;  
  
    Iter = c1.begin( );  
    Iter++;  
    c1.insert( Iter, 100 );  
    cout << "[ c1 = ";  
    for ( Iter = c1.begin( ); Iter != c1.end( ); Iter++ )  
        cout << *Iter << " ";  
    cout << "]" << endl;  
  
    Iter = c1.begin( );  
    Iter++;  
    Iter++;  
    c1.insert( Iter, 2, 200 );  
  
    cout << "[ c1 = ";  
    for ( Iter = c1.begin( ); Iter != c1.end( ); Iter++ )  
        cout << *Iter << " ";  
    cout << "]" << endl;  
  
    c1.insert( ++c1.begin( ), c2.begin( ),--c2.end( ) );  
  
    cout << "[ c1 = ";  
    for ( Iter = c1.begin( ); Iter != c1.end( ); Iter++ )  
        cout << *Iter << " ";  
    cout << "]" << endl;  
  
// initialize a deque of strings by moving  
    deque < string > c3;  
    string str("a");  
  
    c3.insert( c3.begin(), move( str ) );  
    cout << "Moved first element: " << c3.front( ) << endl;  
}  
```  
  
## Output  
  
```  
[ c1 = 10 20 30 ]  
[ c1 = 10 100 20 30 ]  
[ c1 = 10 100 200 200 20 30 ]  
[ c1 = 10 40 50 100 200 200 20 30 ]  
Moved first element: a  
10 40 50 100 200 200 20 30 70 80 90  
```  
  
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::insert](../vs140/deque--insert--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)