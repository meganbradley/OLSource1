---
title: "deque::const_reference"
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
  - "const_reference"
  - "deque::const_reference"
  - "deque/std::deque::const_reference"
  - "std.deque.const_reference"
  - "std::deque::const_reference"
  - "deque.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
  - "const_reference typedef"
ms.assetid: 011d16fb-7d29-4d4b-9bae-5a82d4826aa4
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::const_reference
A type that provides a reference to a **const** element stored in a deque for reading and performing **const** operations.  
  
## Syntax  
  
```  
  
typedef typename Allocator::const_reference const_reference;  
```  
  
## Remarks  
 A type `const_reference` cannot be used to modify the value of an element.  
  
## Example  
  
```  
// deque_const_ref.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
  
   const deque <int> c2 = c1;  
   const int &i = c2.front( );  
   const int &j = c2.back( );  
   cout << "The first element is " << i << endl;  
   cout << "The second element is " << j << endl;  
  
   // The following line would cause an error as c2 is const  
   // c2.push_back( 30 );  
}  
```  
  
 **The first element is 10**  
**The second element is 20**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)