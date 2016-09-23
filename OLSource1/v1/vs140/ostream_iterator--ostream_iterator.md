---
title: "ostream_iterator::ostream_iterator"
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
  - ostream_iterator
  - ostream_iterator::ostream_iterator
  - std.ostream_iterator.ostream_iterator
  - ostream_iterator.ostream_iterator
  - iterator/std::ostream_iterator::ostream_iterator
  - std::ostream_iterator::ostream_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - ostream_iterator class, constructor
  - ostream_iterator method
ms.assetid: ebbd7573-50b8-46dd-8345-0cad6bae6d86
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ostream_iterator::ostream_iterator
Constructs an `ostream_iterator` that is initialized and delimited to write to the output stream.  
  
## Syntax  
  
```  
ostream_iterator(  
   ostream_type& _Ostr  
);  
ostream_iterator(  
   ostream_type& _Ostr,   
   const CharType* _Delimiter  
);  
```  
  
#### Parameters  
 `_Ostr`  
 The output stream of type [ostream_iterator::ostream_type](../vs140/ostream_iterator--ostream_type.md) to be iterated over.  
  
 `_Delimiter`  
 The delimiter that is inserted into the output stream between values.  
  
## Remarks  
 The first constructor initializes the output stream pointer with `&_Ostr`. The delimiter string pointer designates an empty string.  
  
 The second constructor initializes the output stream pointer with `&_Ostr` and the delimiter string pointer with `_Delimiter`.  
  
## Example  
  
```  
// ostream_iterator_ostream_iterator.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // ostream_iterator for stream cout  
   ostream_iterator<int> intOut ( cout , "\n" );  
   *intOut = 10;  
   intOut++;  
   *intOut = 20;  
   intOut++;  
  
   int i;  
   vector<int> vec;  
   for ( i = 1 ; i < 7 ; ++i )  
   {  
      vec.push_back (  i );  
   }  
  
   // Write elements to standard output stream  
   cout << "Elements output without delimiter: ";  
   copy ( vec.begin ( ), vec.end ( ),  
          ostream_iterator<int> ( cout ) );  
   cout << endl;  
  
   // Write elements with delimiter " : " to output stream  
   cout << "Elements output with delimiter: ";  
   copy ( vec.begin ( ), vec.end ( ),  
          ostream_iterator<int> ( cout, " : " ) );  
   cout << endl;  
}  
```  
  
 **10**  
**20**  
**Elements output without delimiter: 123456**  
**Elements output with delimiter: 1 : 2 : 3 : 4 : 5 : 6 :**    
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)