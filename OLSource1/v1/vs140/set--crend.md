---
title: "set::crend"
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
  - "set/std::set::crend"
  - "set.crend"
  - "std.set.crend"
  - "set::crend"
  - "std::set::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: 06bc3fa6-f4d7-42a6-b5b2-ed86173715d2
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# set::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed set.  
  
## Syntax  
  
```  
  
const_reverse_iterator crend( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed set (the location that had preceded the first element in the unreversed set).  
  
## Remarks  
 `crend` is used with a reversed set just as [end](../vs140/set--end.md) is used with a set.  
  
 With the return value of `crend`, the set object cannot be modified. The value returned by `crend` should not be dereferenced.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its set.  
  
## Example  
  
```  
// set_crend.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main() {  
   using namespace std;     
   set <int> s1;  
   set <int>::const_reverse_iterator s1_crIter;  
  
   s1.insert( 10 );  
   s1.insert( 20 );  
   s1.insert( 30 );  
  
   s1_crIter = s1.crend( );  
   s1_crIter--;  
   cout << "The last element in the reversed set is "  
        << *s1_crIter << "." << endl;  
}  
```  
  
## Output  
  
```  
The last element in the reversed set is 10.  
```  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::rbegin and set::rend](../vs140/set--rbegin-and-set--rend.md)   
 [Standard Template Library](../vs140/standard-template-library.md)