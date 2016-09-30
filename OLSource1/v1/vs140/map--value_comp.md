---
title: "map::value_comp"
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
  - "map::value_comp"
  - "map/std::map::value_comp"
  - "std.map.value_comp"
  - "std::map::value_comp"
  - "map.value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 4ee5088f-4a7f-406e-8d9e-89ec0ccad9f0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::value_comp
The member function returns a function object that determines the order of elements in a map by comparing their key values.  
  
## Syntax  
  
```  
  
value_compare value_comp( ) const;  
  
```  
  
## Return Value  
 Returns the comparison function object that a map uses to order its elements.  
  
## Remarks  
 For a map *m*, if two elements *e*1(*k*1, *d*1) and *e*2(*k*2, `d`2) are objects of type `value_type`, where *k*1 and *k*2 are their keys of type `key_type` and `d`1 and `d`2 are their data of type `mapped_type`, then *m.*`value_comp`(*e*1, *e*2) is equivalent to *m.*`key_comp`*(k*1, *k*2). A stored object defines the member function  
  
 **bool operator**(**value_type&** `_Left`, **value_type&** `_Right`);  
  
 which returns **true** if the key value of `_Left` precedes and is not equal to the key value of `_Right` in the sort order.  
  
## Example  
  
```  
// map_value_comp.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   map <int, int, less<int> > m1;  
   map <int, int, less<int> >::value_compare vc1 = m1.value_comp( );  
   pair< map<int,int>::iterator, bool > pr1, pr2;  
  
   pr1= m1.insert ( map <int, int> :: value_type ( 1, 10 ) );  
   pr2= m1.insert ( map <int, int> :: value_type ( 2, 5 ) );  
  
   if( vc1( *pr1.first, *pr2.first ) == true )     
   {  
      cout << "The element ( 1,10 ) precedes the element ( 2,5 )."  
           << endl;  
   }  
   else     
   {  
      cout << "The element ( 1,10 ) does not precede the element ( 2,5 )."  
           << endl;  
   }  
  
   if(vc1( *pr2.first, *pr1.first ) == true )  
   {  
      cout << "The element ( 2,5 ) precedes the element ( 1,10 )."  
           << endl;  
   }  
   else     
   {  
      cout << "The element ( 2,5 ) does not precede the element ( 1,10 )."  
           << endl;  
   }  
}  
```  
  
 **The element ( 1,10 ) precedes the element ( 2,5 ).**  
**The element ( 2,5 ) does not precede the element ( 1,10 ).**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)