---
title: "istream_iterator::istream_iterator"
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
  - "iterator/std::istream_iterator::istream_iterator"
  - "istream_iterator.istream_iterator"
  - "istream_iterator"
  - "std::istream_iterator::istream_iterator"
  - "std.istream_iterator.istream_iterator"
  - "istream_iterator::istream_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istream_iterator class, constructor"
  - "istream_iterator method"
ms.assetid: 6150d495-c4da-40c6-aa23-dde98ea1e806
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istream_iterator::istream_iterator
Constructs either an end-of-stream iterator as the default `istream_iterator` or a `istream_iterator` initialized to the iterator's stream type from which it reads.  
  
## Syntax  
  
```  
  
      istream_iterator( );   
istream_iterator(  
   istream_type& _Istr  
);  
```  
  
#### Parameters  
 `_Istr`  
 The input stream to be read use to initialize the `istream_iterator`.  
  
## Remarks  
 The First constructor initializes the input stream pointer with a null pointer and creates an end-of-stream iterator. The second constructor initializes the input stream pointer with *&_Istr*, then attempts to extract and store an object of type **Type**.  
  
 The end-of-stream iterator can be use to test whether an `istream_iterator` has reached the end of a stream.  
  
## Example  
  
```  
// istream_iterator_istream_iterator.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Used in conjunction with copy algorithm  
   // to put elements into a vector read from cin  
   vector<int> vec ( 4 );  
   vector <int>::iterator Iter;  
  
   cout << "Enter 4 integers separated by spaces & then\n"  
        << " a character ( try example: '2 4 6 8 a' ): ";  
   istream_iterator<int> intvecRead ( cin );  
  
   // Default constructor will test equal to end of stream  
   // for delimiting source range of vecor  
   copy ( intvecRead , istream_iterator<int>( ) , vec.begin ( ) );  
   cin.clear ( );  
  
   cout << "vec = ";  
   for ( Iter = vec.begin( ) ; Iter != vec.end( ) ; Iter++ )  
      cout << *Iter << " "; cout << endl;  
}  
```  
  
  **`2 4 6 8 a` `2 4 6 8 a`Enter 4 integers separated by spaces & then**  
 **a character ( try example: '2 4 6 8 a' ): 2 4 6 8 a**  
**vec = 2 4 6 8**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istream_iterator Class](../vs140/istream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)