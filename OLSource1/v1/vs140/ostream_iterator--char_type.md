---
title: "ostream_iterator::char_type"
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
  - "iterator/std::ostream_iterator::char_type"
  - "char_type"
  - "std.ostream_iterator.char_type"
  - "ostream_iterator.char_type"
  - "ostream_iterator::char_type"
  - "std::ostream_iterator::char_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "char_type typedef"
ms.assetid: 20675077-0ae1-47ad-a67f-c49b5358d6b4
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator::char_type
A type that provides for the character type of the iterator.  
  
## Syntax  
  
```  
  
typedef CharType char_type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
## Example  
  
```  
// ostream_iterator_char_type.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   typedef ostream_iterator<int>::char_type CHT1;  
   typedef ostream_iterator<int>::traits_type CHTR1;  
  
   // ostream_iterator for stream cout  
   // with new line delimiter:  
    ostream_iterator<int, CHT1, CHTR1> intOut ( cout , "\n" );  
  
   // Standard iterator interface for writing  
   // elements to the output stream:  
   cout << "The integers written to the output stream\n"  
        << "by intOut are:" << endl;  
   *intOut = 10;  
   *intOut = 20;  
   *intOut = 30;  
}  
```  
  
 **The integers written to the output stream**  
**by intOut are:**  
**10**  
**20**  
**30**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)