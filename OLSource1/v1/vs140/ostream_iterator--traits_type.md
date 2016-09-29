---
title: "ostream_iterator::traits_type"
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
  - "ostream_iterator.traits_type"
  - "traits_type"
  - "std.ostream_iterator.traits_type"
  - "std::ostream_iterator::traits_type"
  - "iterator/std::ostream_iterator::traits_type"
  - "ostream_iterator::traits_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "traits_type typedef"
ms.assetid: fef0e94c-1590-41d0-9f98-87b09348f6a7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator::traits_type
A type that provides for the character traits type of the iterator.  
  
## Syntax  
  
```  
  
typedef Traits traits_type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Traits**.  
  
## Example  
  
```  
// ostream_iterator_traits_type.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // The following not OK, but are just the default values:  
   typedef ostream_iterator<int>::char_type CHT1;  
   typedef ostream_iterator<int>::traits_type CHTR1;  
  
   // ostream_iterator for stream cout  
   // with new line delimiter:  
    ostream_iterator<int, CHT1, CHTR1> intOut ( cout , "\n" );  
  
   // Standard iterator interface for writing  
   // elements to the output stream:  
   cout << "The integers written to output stream\n"  
        << "by intOut are:" << endl;  
   *intOut = 1;  
   *intOut = 10;  
   *intOut = 100;  
}  
```  
  
 **The integers written to output stream**  
**by intOut are:**  
**1**  
**10**  
**100**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)