---
title: "ostream_iterator::operator++"
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
  - iterator/std::ostream_iterator::operator++
  - std.ostream_iterator.operator++
  - ++
  - ostream_iterator::operator++
  - ostream_iterator.operator++
  - std::ostream_iterator::operator++
dev_langs: 
  - C++
helpviewer_keywords: 
  - ++ operator
  - operator++
  - ++ operator, with specific objects
ms.assetid: 71a74512-0f3c-4d21-8994-8236da470ef5
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ostream_iterator::operator++
A nonfunctional increment operator that returns an `ostream_iterator` to the same object it addressed before the operation was called.  
  
## Syntax  
  
```  
ostream_iterator<Type, CharType, Traits>& operator++( );  
ostream_iterator<Type, CharType, Traits> operator++( int );  
```  
  
## Return Value  
 A reference to the `ostream_iterator`.  
  
## Remarks  
 These member operators both return **\*this**.  
  
## Example  
  
```  
// ostream_iterator_op_incr.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // ostream_iterator for stream cout  
   // with new line delimiter  
   ostream_iterator<int> intOut ( cout , "\n" );  
  
   // standard iterator interface for writing  
   // elements to the output stream  
   cout << "Elements written to output stream:" << endl;  
   *intOut = 10;  
   intOut++;      // No effect on iterator position  
   *intOut = 20;  
   *intOut = 30;  
}  
```  
  
 **Elements written to output stream:**  
**10**  
**20**  
**30**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)