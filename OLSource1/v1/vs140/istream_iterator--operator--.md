---
title: "istream_iterator::operator-&gt;"
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
  - iterator/std::istream_iterator::operator->
  - istream_iterator::operator->
  - std::istream_iterator::operator->
  - istream_iterator.operator->
  - std.istream_iterator.operator->
dev_langs: 
  - C++
helpviewer_keywords: 
  - -> operator
  - -> operator, with specific objects
  - operator->
ms.assetid: 3206701d-ab62-41c2-8b50-cab9dedee6b1
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# istream_iterator::operator-&gt;
Returns the value of a member, if any.  
  
## Syntax  
  
```  
  
const Type* operator->( ) const;  
  
```  
  
## Return Value  
 The value of a member, if any.  
  
## Remarks  
 *i* -> is equivalent to (\**i*).*m*  
  
 The operator returns **&\*\*this**.  
  
## Example  
  
```  
// istream_iterator_operator_vm.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <iostream>  
#include <complex>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Enter complex numbers separated by spaces & then\n"  
        << " a character pair ( try example: '(1,2) (3,4) (a,b)' ): ";  
  
   // istream_iterator from stream cin  
   istream_iterator< complex<double> > intRead ( cin );  
  
   // End-of-stream iterator  
   istream_iterator<complex<double> > EOFintRead;  
  
   while ( intRead != EOFintRead )  
   {  
      cout << "Reading the real part: " << intRead ->real( ) << endl;  
      cout << "Reading the imaginary part: " << intRead ->imag( ) << endl;  
      ++intRead;  
   }  
   cout << endl;  
}  
```  
  
  **`(1,2) (3,4) (a,b)` `(1,2) (3,4) (a,b)`Enter complex numbers separated by spaces & then**  
 **a character pair ( try example: '(1,2) (3,4) (a,b)' ): (1,2) (3,4) (a,b)**  
**Reading the real part: 1**  
**Reading the imaginary part: 2**  
**Reading the real part: 3**  
**Reading the imaginary part: 4**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istream_iterator Class](../vs140/istream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)