---
title: "raw_storage_iterator::operator++"
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
  - operator++
  - std::raw_storage_iterator::operator++
  - memory/std::raw_storage_iterator::operator++
  - ++
  - std.raw_storage_iterator.operator++
  - raw_storage_iterator::operator++
  - raw_storage_iterator.operator++
dev_langs: 
  - C++
helpviewer_keywords: 
  - ++ operator
  - operator++
  - ++ operator, with specific objects
ms.assetid: 0bf1bd95-5358-4d62-ad29-752a905c60f3
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# raw_storage_iterator::operator++
Preincrement and postincrement operators for raw storage iterators.  
  
## Syntax  
  
```  
raw_storage_iterator<ForwardIterator, Type>& operator++( );  
raw_storage_iterator<ForwardIterator, Type> operator++(int);  
```  
  
## Return Value  
 An raw storage iterator or a reference to an raw storage iterator.  
  
## Remarks  
 The first operator eventually attempts to extract and store an object of type **CharType** from the associated input stream. The second operator makes a copy of the object, increments the object, and then returns the copy.  
  
 The first preincrement operator increments the stored output iterator object, and then returns **\*this**.  
  
 The second postincrement operator makes a copy of **\*this**, increments the stored output iterator object, and then returns the copy.  
  
 The constructor stores **first** as the output iterator object.  
  
## Example  
  
```  
// raw_storage_iterator_op_incr.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <iterator>  
#include <memory>  
#include <list>  
using namespace std;  
  
int main( void )  
{  
   int *pInt = new int[5];  
   std::raw_storage_iterator<int*,int> it( pInt );  
   for ( int i = 0; i < 5; i++, it++ ) {  
      *it = 2 * i;  
};  
  
   for ( int i = 0; i < 5; i++ ) cout << "array " << i << " = " << pInt[i] << endl;;  
  
   delete[] pInt;  
}  
```  
  
 **array 0 = 0**  
**array 1 = 2**  
**array 2 = 4**  
**array 3 = 6**  
**array 4 = 8**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [raw_storage_iterator Class](../vs140/raw_storage_iterator-class.md)