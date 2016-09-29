---
title: "multimap::value_comp"
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
  - "value_comp"
  - "std.multimap.value_comp"
  - "multimap::value_comp"
  - "multimap.value_comp"
  - "std::multimap::value_comp"
  - "map/std::multimap::value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 66ffcc61-11a2-4367-b8bd-f34342ba74d3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::value_comp
The member function returns a function object that determines the order of elements in a multimap by comparing their key values.  
  
## Syntax  
  
```  
  
value_compare value_comp( ) const;  
  
```  
  
## Return Value  
 Returns the comparison function object that a multimap uses to order its elements.  
  
## Remarks  
 For a multimap *m*, if two elements *e*1(*k*1, *d*1) and *e*2(*k*2, `d`2) are objects of type `value_type`, where *k*1 and *k*2 are their keys of type `key_type` and `d`1 and `d`2 are their data of type `mapped_type`, then *m.*`value_comp`(*e*1, *e*2) is equivalent to *m.*`key_comp`(*k*1, *k*2).  
  
## Example  
  
```  
// multimap_value_comp.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   multimap <int, int, less<int> > m1;  
   multimap <int, int, less<int> >::value_compare vc1 = m1.value_comp( );  
   multimap<int,int>::iterator Iter1, Iter2;  
  
   Iter1= m1.insert ( multimap <int, int> :: value_type ( 1, 10 ) );  
   Iter2= m1.insert ( multimap <int, int> :: value_type ( 2, 5 ) );  
  
   if( vc1( *Iter1, *Iter2 ) == true )     
   {  
      cout << "The element ( 1,10 ) precedes the element ( 2,5 )."  
           << endl;  
   }  
   else     
   {  
      cout << "The element ( 1,10 ) does "  
           << "not precede the element ( 2,5 )."  
           << endl;  
   }  
  
   if( vc1( *Iter2, *Iter1 ) == true )     
   {  
      cout << "The element ( 2,5 ) precedes the element ( 1,10 )."  
           << endl;  
   }  
   else     
   {  
      cout << "The element ( 2,5 ) does "  
           << "not precede the element ( 1,10 )."  
           << endl;  
   }  
}  
```  
  
 **The element ( 1,10 ) precedes the element ( 2,5 ).**  
**The element ( 2,5 ) does not precede the element ( 1,10 ).**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)