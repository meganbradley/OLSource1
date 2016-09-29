---
title: "multimap::clear"
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
  - "multimap.clear"
  - "map/std::multimap::clear"
  - "clear"
  - "multimap::clear"
  - "std::multimap::clear"
  - "std.multimap.clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: b60a7c90-4190-4484-b2d5-4b9c7fed2222
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# multimap::clear
Erases all the elements of a multimap.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Example  
 The following example demonstrates the use of the multimap::clear member function.  
  
```  
// multimap_clear.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap<int, int> m1;  
   multimap<int, int>::size_type i;  
   typedef pair<int, int> Int_Pair;  
  
   m1.insert(Int_Pair(1, 1));  
   m1.insert(Int_Pair(2, 4));  
  
   i = m1.size();  
   cout << "The size of the multimap is initially "  
        << i << "." << endl;  
  
   m1.clear();  
   i = m1.size();  
   cout << "The size of the multimap after clearing is "  
        << i << "." << endl;  
}  
```  
  
 **The size of the multimap is initially 2.**  
**The size of the multimap after clearing is 0.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)