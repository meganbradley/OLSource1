---
title: "multimap::begin"
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
  - "std.multimap.begin"
  - "multimap::begin"
  - "begin"
  - "std::multimap::begin"
  - "multimap.begin"
  - "map/std::multimap::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: fb15df1a-076e-44e4-8a29-0e9cb9e512d5
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::begin
Returns an iterator addressing the first element in the multimap.  
  
## Syntax  
  
```  
  
      const_iterator begin( ) const;   
iterator begin( );  
```  
  
## Return Value  
 A bidirectional iterator addressing the first element in the multimap or the location succeeding an empty multimap.  
  
## Remark  
 If the return value of **begin** is assigned to a `const_iterator`, the elements in the multimap object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the multimap object can be modified.  
  
## Example  
  
```  
// multimap_begin.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   multimap <int, int> m1;  
  
   multimap <int, int> :: iterator m1_Iter;  
   multimap <int, int> :: const_iterator m1_cIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 0, 0 ) );  
   m1.insert ( Int_Pair ( 1, 1 ) );  
   m1.insert ( Int_Pair ( 2, 4 ) );  
  
   m1_cIter = m1.begin ( );  
   cout << "The first element of m1 is " << m1_cIter -> first << endl;  
  
   m1_Iter = m1.begin ( );  
   m1.erase ( m1_Iter );  
  
   // The following 2 lines would err as the iterator is const  
   // m1_cIter = m1.begin ( );  
   // m1.erase ( m1_cIter );  
  
   m1_cIter = m1.begin( );  
   cout << "First element of m1 is now " << m1_cIter -> first << endl;  
}  
```  
  
 **The first element of m1 is 0**  
**First element of m1 is now 1**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)