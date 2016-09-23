---
title: "list::crbegin"
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
  - list/std::list::crbegin
  - std.list.crbegin
  - std::list::crbegin
  - list::crbegin
  - list.crbegin
  - crbegin
dev_langs: 
  - C++
helpviewer_keywords: 
  - crbegin method
ms.assetid: aa7957d8-1030-46bf-8075-190ba79cb830
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# list::crbegin
Returns a const iterator addressing the first element in a reversed list.  
  
## Syntax  
  
```  
  
const  
_  
reverse  
_  
iterator rbegin( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [list](../vs140/list-class.md) (or addressing what had been the last element in the unreversed `list`).  
  
## Remarks  
 `crbegin` is used with a reversed list just as [begin](../vs140/list--begin.md) is used with a `list`.  
  
 With the return value of `crbegin`, the list object cannot be modified. [list::rbegin](../vs140/list--rbegin.md) can be used to iterate through a list backwards.  
  
## Example  
  
```  
// list_crbegin.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
   list <int>::const_reverse_iterator c1_crIter;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
   c1_crIter = c1.crbegin( );  
   cout << "The last element in the list is " << *c1_crIter << "." << endl;  
}  
```  
  
 **The last element in the list is 30.**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)