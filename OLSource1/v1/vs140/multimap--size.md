---
title: "multimap::size"
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
  - std.multimap.size
  - multimap::size
  - multimap.size
  - size
  - std::multimap::size
  - map/std::multimap::size
dev_langs: 
  - C++
helpviewer_keywords: 
  - size method
ms.assetid: 94167c92-ab52-406c-b39f-4d3309766985
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multimap::size
Returns the number of elements in the multimap.  
  
## Syntax  
  
```  
  
size_type size( ) const;  
  
```  
  
## Return Value  
 The current length of the multimap.  
  
## Example  
 The following example demonstrates the use of the multimap::size member function.  
  
```  
// multimap_size.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    multimap<int, int> m1, m2;  
    multimap<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    m1.insert(Int_Pair(1, 1));  
    i = m1.size();  
    cout << "The multimap length is " << i << "." << endl;  
  
    m1.insert(Int_Pair(2, 4));  
    i = m1.size();  
    cout << "The multimap length is now " << i << "." << endl;  
}  
```  
  
 **The multimap length is 1.**  
**The multimap length is now 2.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)