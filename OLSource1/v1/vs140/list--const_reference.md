---
title: "list::const_reference"
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
  - "std.list.const_reference"
  - "list/std::list::const_reference"
  - "std::list::const_reference"
  - "const_reference"
  - "list::const_reference"
  - "list.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
  - "const_reference typedef"
ms.assetid: 58c6b43b-9070-43f8-92a4-be009f9824cd
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::const_reference
A type that provides a reference to a **const** element stored in a list for reading and performing **const** operations.  
  
## Syntax  
  
```  
  
typedef typename Allocator::const  
_  
reference const  
_  
reference;  
```  
  
## Remarks  
 A type `const_reference` cannot be used to modify the value of an element.  
  
## Example  
  
```  
// list_const_ref.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
  
   const list <int> c2 = c1;  
   const int &i = c2.front( );  
   const int &j = c2.back( );  
   cout << "The first element is " << i << endl;  
   cout << "The second element is " << j << endl;  
  
   // The following line would cause an error because c2 is const  
   // c2.push_back( 30 );  
}  
```  
  
 **The first element is 10**  
**The second element is 20**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)