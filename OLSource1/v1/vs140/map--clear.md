---
title: "map::clear"
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
  - "map.clear"
  - "map::clear"
  - "clear"
  - "std::map::clear"
  - "map/std::map::clear"
  - "std.map.clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: 9a8b8ab5-6d02-4a82-932d-8d61ac8e6494
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::clear
Erases all the elements of a map.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Example  
 The following example demonstrates the use of the map::clear member function.  
  
```  
// map_clear.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    map<int, int> m1;  
    map<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    m1.insert(Int_Pair(1, 1));  
    m1.insert(Int_Pair(2, 4));  
  
    i = m1.size();  
    cout << "The size of the map is initially "  
         << i << "." << endl;  
  
    m1.clear();  
    i = m1.size();  
    cout << "The size of the map after clearing is "  
         << i << "." << endl;  
}  
```  
  
 **The size of the map is initially 2.**  
**The size of the map after clearing is 0.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [map::max_size, map::clear, map::erase, and map::size](../vs140/map--max_size--map--clear--map--erase--and-map--size.md)   
 [Standard Template Library](../vs140/standard-template-library.md)