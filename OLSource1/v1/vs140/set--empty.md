---
title: "set::empty"
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
  - std::set::empty
  - set/std::set::empty
  - std.set.empty
  - empty
  - set.empty
  - set::empty
dev_langs: 
  - C++
helpviewer_keywords: 
  - empty method
ms.assetid: 29a1df7f-8f6e-46cb-9bb9-66057284564a
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set::empty
Tests if a set is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the set is empty; **false** if the set is nonempty.  
  
## Example  
  
```  
// set_empty.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1, s2;  
   s1.insert ( 1 );  
  
   if ( s1.empty( ) )  
      cout << "The set s1 is empty." << endl;  
   else  
      cout << "The set s1 is not empty." << endl;  
  
   if ( s2.empty( ) )  
      cout << "The set s2 is empty." << endl;  
   else  
      cout << "The set s2 is not empty." << endl;  
}  
```  
  
 **The set s1 is not empty.**  
**The set s2 is empty.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::empty and set::clear](../vs140/set--empty-and-set--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)