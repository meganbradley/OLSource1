---
title: "multimap::max_size"
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
  - multimap.max_size
  - max_size
  - map/std::multimap::max_size
  - std.multimap.max_size
  - std::multimap::max_size
  - multimap::max_size
dev_langs: 
  - C++
helpviewer_keywords: 
  - max_size method
ms.assetid: 11de883a-96fe-4b52-8a47-0bdc751baf6d
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multimap::max_size
Returns the maximum length of the multimap.  
  
## Syntax  
  
```  
  
size_type max_size( ) const;  
  
```  
  
## Return Value  
 The maximum possible length of the multimap.  
  
## Example  
  
```  
// multimap_max_size.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1;  
   multimap <int, int> :: size_type i;  
  
   i = m1.max_size( );  
   cout << "The maximum possible length "  
        << "of the multimap is " << i << "." << endl;  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The maximum possible length of the multimap is 536870911.  
```  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)