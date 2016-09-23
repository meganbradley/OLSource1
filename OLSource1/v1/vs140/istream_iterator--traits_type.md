---
title: "istream_iterator::traits_type"
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
  - traits_type
  - istream_iterator.traits_type
  - iterator/std::istream_iterator::traits_type
  - std::istream_iterator::traits_type
  - istream_iterator::traits_type
  - std.istream_iterator.traits_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - traits_type typedef
ms.assetid: aed80bdd-d9ea-48da-9bf0-6c8139db538d
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# istream_iterator::traits_type
A type that provides for the character traits type of the `istream_iterator`.  
  
## Syntax  
  
```  
  
typedef Traits traits_type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Traits**.  
  
## Example  
  
```  
// istream_iterator_traits_type.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   typedef istream_iterator<int>::char_type CHT1;  
   typedef istream_iterator<int>::traits_type CHTR1;  
  
   // Standard iterator interface for reading  
   // elements from the input stream:  
   cout << "Enter integers separated by spaces & then\n"  
        << " any character ( try example: '10 20 a' ): ";  
  
   // istream_iterator for reading int stream  
   istream_iterator<int, CHT1, CHTR1> intRead ( cin );  
  
   // End-of-stream iterator  
   istream_iterator<int, CHT1, CHTR1> EOFintRead;  
  
   while ( intRead != EOFintRead )  
   {  
      cout << "Reading:  " << *intRead << endl;  
      ++intRead;  
   }  
   cout << endl;  
}  
```  
  
  **`10 20 a` `10 20 a`Enter integers separated by spaces & then**  
 **any character ( try example: '10 20 a' ): 10 20 a**  
**Reading:  10**  
**Reading:  20**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istream_iterator Class](../vs140/istream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)