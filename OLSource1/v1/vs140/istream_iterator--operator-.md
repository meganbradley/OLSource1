---
title: "istream_iterator::operator*"
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
  - "istream_iterator.operator*"
  - "std::istream_iterator::operator*"
  - "std.istream_iterator.operator*"
  - "operator*"
  - "iterator/std::istream_iterator::operator*"
  - "istream_iterator::operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "* operator"
  - "operator*"
  - "* operator, with specific iterator expressions"
ms.assetid: e81996bb-e0c3-40cd-8765-2be6ceb3d0ef
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istream_iterator::operator*
The dereferencing operator returns the stored object of type **Type** addressed by the `istream_iterator`.  
  
## Syntax  
  
```  
  
const Type& operator*( ) const;  
  
```  
  
## Return Value  
 The stored object of type **Type**.  
  
## Example  
  
```  
// istream_iterator_operator.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   cout << "Enter integers separated by spaces & then\n"  
        << " a character ( try example: '2 4 6 8 a' ): ";  
  
   // istream_iterator from stream cin  
   istream_iterator<int> intRead ( cin );  
  
   // End-of-stream iterator  
   istream_iterator<int> EOFintRead;  
  
   while ( intRead != EOFintRead )  
   {  
      cout << "Reading:  " << *intRead << endl;  
      ++intRead;  
   }  
   cout << endl;  
}  
```  
  
  **`2 4 6 8 a` `2 4 6 8 a`Enter integers separated by spaces & then**  
 **a character ( try example: '2 4 6 8 a' ): 2 4 6 8 a**  
**Reading:  2**  
**Reading:  4**  
**Reading:  6**  
**Reading:  8**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istream_iterator Class](../vs140/istream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)