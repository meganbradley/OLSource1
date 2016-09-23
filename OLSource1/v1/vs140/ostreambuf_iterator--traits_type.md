---
title: "ostreambuf_iterator::traits_type"
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
  - std.ostreambuf_iterator.traits_type
  - streambuf/std::ostreambuf_iterator::traits_type
  - ostreambuf_iterator::traits_type
  - std::ostreambuf_iterator::traits_type
  - ostreambuf_iterator.traits_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - traits_type typedef
ms.assetid: 8bc700fb-37be-4aa3-964b-0cb61549e5e2
caps.latest.revision: 17
translation.priority.mt: 
  - de-de
  - ja-jp
---
# ostreambuf_iterator::traits_type
A type that provides for the character traits type of the `ostream_iterator`.  
  
## Syntax  
  
```  
  
typedef Traits traits_type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Traits**.  
  
## Example  
  
```  
// ostreambuf_iterator_traits_type.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   typedef ostreambuf_iterator<char>::char_type CHT1;  
   typedef ostreambuf_iterator<char>::traits_type CHTR1;  
  
   // ostreambuf_iterator for stream cout  
   // with new line delimiter:  
    ostreambuf_iterator< CHT1, CHTR1> charOutBuf ( cout );  
  
   // Standard iterator interface for writing  
   // elements to the output streambuf:  
   cout << "The characters written to the output stream\n"  
        << " by charOutBuf are: ";  
   *charOutBuf = 'O';  
   charOutBuf++;  
   *charOutBuf = 'U';  
   charOutBuf++;  
   *charOutBuf = 'T';  
   charOutBuf++;  
   cout << "." << endl;  
}  
```  
  
 **The characters written to the output stream**  
 **by charOutBuf are: OUT.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)