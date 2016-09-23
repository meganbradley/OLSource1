---
title: "deque::clear"
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
  - deque/std::deque::clear
  - clear
  - deque::clear
  - std::deque::clear
  - deque.clear
  - std.deque.clear
  - Clear
dev_langs: 
  - C++
helpviewer_keywords: 
  - clear method
ms.assetid: 65cfa7a3-3c4b-4a84-ad26-46d552783dc1
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::clear
Erases all the elements of a deque.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Example  
  
```  
// deque_clear.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
  
   cout << "The size of the deque is initially " << c1.size( ) << endl;  
   c1.clear( );  
   cout << "The size of the deque after clearing is " << c1.size( ) << endl;  
}  
```  
  
 **The size of the deque is initially 3**  
**The size of the deque after clearing is 0**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::erase and deque::clear](../vs140/deque--erase-and-deque--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)