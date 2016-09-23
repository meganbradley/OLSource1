---
title: "set::begin"
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
  - std::_Tree::begin
  - std::set::begin
  - std.set.begin
  - set::begin
  - set/std::set::begin
  - xtree/std::_Tree::begin
  - set.begin
  - _Tree::begin
dev_langs: 
  - C++
helpviewer_keywords: 
  - begin method, set class
ms.assetid: 3bbbbe38-4918-41eb-b97f-02e3c6507154
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set::begin
Returns an iterator that addresses the first element in the set.  
  
## Syntax  
  
```  
  
      const_iterator begin( ) const;   
iterator begin( );  
```  
  
## Return Value  
 A bidirectional iterator addressing the first element in the set or the location succeeding an empty set.  
  
## Remarks  
 If the return value of **begin** is assigned to a `const_iterator`, the elements in the set object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the set object can be modified.  
  
## Example  
  
```  
// set_begin.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1;  
   set <int>::iterator s1_Iter;  
   set <int>::const_iterator s1_cIter;  
  
   s1.insert( 1 );  
   s1.insert( 2 );  
   s1.insert( 3 );  
  
   s1_Iter = s1.begin( );  
   cout << "The first element of s1 is " << *s1_Iter << endl;  
  
   s1_Iter = s1.begin( );  
   s1.erase( s1_Iter );  
  
   // The following 2 lines would err because the iterator is const  
   // s1_cIter = s1.begin( );  
   // s1.erase( s1_cIter );  
  
   s1_cIter = s1.begin( );  
   cout << "The first element of s1 is now " << *s1_cIter << endl;  
}  
```  
  
 **The first element of s1 is 1**  
**The first element of s1 is now 2**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::swap, set::begin, and set::end](../vs140/set--swap--set--begin--and-set--end.md)   
 [Standard Template Library](../vs140/standard-template-library.md)