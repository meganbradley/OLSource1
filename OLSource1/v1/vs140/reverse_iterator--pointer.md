---
title: "reverse_iterator::pointer"
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
  - "reverse_iterator.pointer"
  - "std.reverse_iterator.pointer"
  - "reverse_iterator::pointer"
  - "pointer"
  - "std::reverse_iterator::pointer"
  - "xutility/std::reverse_iterator::pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer method"
  - "pointer typedef"
ms.assetid: 25df8dbc-d668-4954-9019-a0087fae2338
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::pointer
A type that provides a pointer to an element addressed by a `reverse_iterator`.  
  
## Syntax  
  
```  
typedef typename iterator_traits<RandomIterator>::pointer pointer;  
```  
  
## Remarks  
 The type is a synonym for the iterator trait typename `iterator_traits`<*RandomIterator*>**::pointer**.  
  
## Example  
  
```  
// reverse_iterator_pointer.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <algorithm>  
#include <vector>  
#include <utility>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   typedef vector<pair<int,int> > pVector;  
   pVector vec;  
   vec.push_back( pVector::value_type( 1,2 ) );  
   vec.push_back( pVector::value_type( 3,4 ) );  
   vec.push_back( pVector::value_type( 5,6 ) );  
  
   pVector::iterator pvIter;  
   cout << "The vector vec of integer pairs is:\n" << "( ";  
   for ( pvIter = vec.begin ( ) ; pvIter != vec.end ( ); pvIter++)  
      cout << "( " << pvIter -> first << ", " << pvIter -> second << ") ";  
   cout << ")" << endl;  
  
   pVector::reverse_iterator rpvIter;  
   cout << "\nThe vector vec reversed is:\n" << "( ";  
   for ( rpvIter = vec.rbegin( ) ; rpvIter != vec.rend( ); rpvIter++)  
      cout << "( " << rpvIter -> first << ", " << rpvIter -> second << ") ";  
   cout << ")" << endl;  
  
   pVector::iterator pos = vec.begin ( );  
   pos++;  
   cout << "\nThe iterator pos points to:\n"  
        << "( " << pos -> first << ", "  
        << pos -> second << " )" << endl;  
  
   pVector::reverse_iterator rpos (pos);  
   cout << "\nThe iterator rpos points to:\n"  
        << "( " << rpos -> first << ", "  
        << rpos -> second << " )" << endl;  
}  
```  
  
 **The vector vec of integer pairs is:**  
**( ( 1, 2) ( 3, 4) ( 5, 6) )**  
**The vector vec reversed is:**  
**( ( 5, 6) ( 3, 4) ( 1, 2) )**  
**The iterator pos points to:**  
**( 3, 4 )**  
**The iterator rpos points to:**  
**( 1, 2 )**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)