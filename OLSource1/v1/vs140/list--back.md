---
title: "list::back"
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
  - "std::list::back"
  - "list/std::list::back"
  - "list::back"
  - "back"
  - "std.list.back"
  - "list.back"
  - "Back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back method, list class"
  - "back method"
ms.assetid: e4033055-0557-4048-814f-b49407573d6a
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::back
Returns a reference to the last element of a list.  
  
## Syntax  
  
```  
  
      reference back( );   
const_reference back( ) const;  
```  
  
## Return Value  
 The last element of the list. If the list is empty, the return value is undefined.  
  
## Remarks  
 If the return value of **back** is assigned to a `const_reference`, the list object cannot be modified. If the return value of **back** is assigned to a **reference**, the list object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty list.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
```  
// list_back.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 11 );  
  
   int& i = c1.back( );  
   const int& ii = c1.front( );  
  
   cout << "The last integer of c1 is " << i << endl;  
   i--;  
   cout << "The next-to-last integer of c1 is " << ii << endl;  
}  
```  
  
 **The last integer of c1 is 11**  
**The next-to-last integer of c1 is 10**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)