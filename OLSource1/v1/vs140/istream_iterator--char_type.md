---
title: "istream_iterator::char_type"
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
  - char_type
  - std::istream_iterator::char_type
  - iterator/std::istream_iterator::char_type
  - istream_iterator.char_type
  - std.istream_iterator.char_type
  - istream_iterator::char_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - char_type typedef
ms.assetid: 71fb41d1-91ed-4ffd-bd62-55ac996140f3
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# istream_iterator::char_type
A type that provides for the character type of the `istream_iterator`.  
  
## Syntax  
  
```  
  
typedef CharType char_type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Chartype**.  
  
## Example  
  
```  
// istream_iterator_char_type.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   typedef istream_iterator<int>::char_type CHT1;  
   typedef istream_iterator<int>::traits_type CHTR1;  
  
   // Standard iterator interface for reading  
   // elements from the input stream:  
   cout << "Enter integers separated by spaces & then\n"  
        << " any character ( try example: '2 4 f' ): ";  
  
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
  
  **`2 4 f` `2 4 f`Enter integers separated by spaces & then**  
 **any character ( try example: '2 4 f' ): 2 4 f**  
**Reading:  2**  
**Reading:  4**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istream_iterator Class](../vs140/istream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)