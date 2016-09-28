---
title: "multiset::value_comp"
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
  - "multiset.value_comp"
  - "set/std::multiset::value_comp"
  - "std::multiset::value_comp"
  - "multiset::value_comp"
  - "std.multiset.value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 557acba6-567f-43a3-b8ba-ff6706f6a05c
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::value_comp
Retrieves a copy of the comparison object used to order element values in a multiset.  
  
## Syntax  
  
```  
  
value_compare value_comp( ) const;  
  
```  
  
## Return Value  
 Returns the function object that a multiset uses to order its elements, which is the template parameter `Compare`.  
  
 For more information on `Compare`, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
## Remarks  
 The stored object defines the member function:  
  
 **bool operator**(**const Key&** `_xVal`, **const Key&** `_yVal`);  
  
 which returns true if `_xVal` precedes and is not equal to `_yVal` in the sort order.  
  
 Note that both [key_compare](../vs140/multiset--key_compare.md) and [value_compare](../vs140/multiset--value_compare.md) are synonyms for the template parameter `Compare`. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
## Example  
  
```  
// multiset_value_comp.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   multiset <int, less<int> > ms1;  
   multiset <int, less<int> >::value_compare vc1 = ms1.value_comp( );  
   bool result1 = vc1( 2, 3 );  
   if( result1 == true )     
   {  
      cout << "vc1( 2,3 ) returns value of true, "  
           << "where vc1 is the function object of ms1."  
           << endl;  
   }  
   else     
   {  
      cout << "vc1( 2,3 ) returns value of false, "  
           << "where vc1 is the function object of ms1."  
           << endl;  
   }  
  
   set <int, greater<int> > ms2;  
   set<int, greater<int> >::value_compare vc2 = ms2.value_comp( );  
   bool result2 = vc2( 2, 3 );  
   if( result2 == true )     
   {  
      cout << "vc2( 2,3 ) returns value of true, "  
           << "where vc2 is the function object of ms2."  
           << endl;  
   }  
   else     
   {  
      cout << "vc2( 2,3 ) returns value of false, "  
           << "where vc2 is the function object of ms2."  
           << endl;  
   }  
}  
```  
  
 **vc1( 2,3 ) returns value of true, where vc1 is the function object of ms1.**  
**vc2( 2,3 ) returns value of false, where vc2 is the function object of ms2.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)