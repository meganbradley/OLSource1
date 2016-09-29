---
title: "ostreambuf_iterator::operator++"
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
  - "operator++"
  - "streambuf/std::ostreambuf_iterator::operator++"
  - "std.ostreambuf_iterator.operator++"
  - "ostreambuf_iterator.operator++"
  - "++"
  - "std::ostreambuf_iterator::operator++"
  - "ostreambuf_iterator::operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "++ operator"
  - "operator++"
  - "++ operator, with specific objects"
ms.assetid: e3866818-c9fd-44fd-9661-b61e707578a8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator::operator++
A nonfunctional increment operator that returns an ostream iterator to the same character it addressed before the operation was called.  
  
## Syntax  
  
```  
ostreambuf_iterator<CharType, Traits>& operator++( );  
ostreambuf_iterator<CharType, Traits>& operator++( int );  
```  
  
## Return Value  
 A reference to the character originally addressed or to an implementation-defined object that is convertible to `ostreambuf_iterator`<**CharType**, **Traits**>.  
  
## Remarks  
 The operator is used to implement the output iterator expression \**i* = *x*.  
  
## Example  
  
```  
// ostreambuf_iterator_op_incr.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // ostreambuf_iterator for stream cout  
   // with new line delimiter  
   ostreambuf_iterator<char> charOutBuf ( cout );  
  
   // Standard iterator interface for writing  
   // elements to the output stream  
   cout << "Elements written to output stream:" << endl;  
   *charOutBuf = 'O';  
   charOutBuf++;      // No effect on iterator position  
   *charOutBuf = 'U';  
   *charOutBuf = 'T';     
}  
```  
  
 **Elements written to output stream:**  
**OUT**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)