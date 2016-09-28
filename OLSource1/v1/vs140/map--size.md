---
title: "map::size"
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
  - "map::size"
  - "map.size"
  - "size"
  - "std.map.size"
  - "map/std::map::size"
  - "std::map::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 8f719c93-cd0e-4d51-a75f-7afa3c8555ee
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::size
Returns the number of elements in the map.  
  
## Syntax  
  
```  
  
size_type size( ) const;  
  
```  
  
## Return Value  
 The current length of the map.  
  
## Example  
 The following example demonstrates the use of the map::size member function.  
  
```  
// map_size.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    map<int, int> m1, m2;  
    map<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    m1.insert(Int_Pair(1, 1));  
    i = m1.size();  
    cout << "The map length is " << i << "." << endl;  
  
    m1.insert(Int_Pair(2, 4));  
    i = m1.size();  
    cout << "The map length is now " << i << "." << endl;  
}  
```  
  
 **The map length is 1.**  
**The map length is now 2.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [map::max_size, map::clear, map::erase, and map::size](../vs140/map--max_size--map--clear--map--erase--and-map--size.md)   
 [Standard Template Library](../vs140/standard-template-library.md)