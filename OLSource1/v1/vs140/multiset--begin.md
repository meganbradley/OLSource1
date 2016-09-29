---
title: "multiset::begin"
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
  - "std::multiset::begin"
  - "std.multiset.begin"
  - "set/std::multiset::begin"
  - "multiset::begin"
  - "multiset.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: 05df8a1e-1f2e-4659-afa3-1ec655527bea
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::begin
Returns an iterator addressing the first element in the multiset.  
  
## Syntax  
  
```  
  
      const_iterator begin( ) const;   
iterator begin( );  
```  
  
## Return Value  
 A bidirectional iterator addressing the first element in the multiset or the location succeeding an empty multiset.  
  
## Remark  
 If the return value of **begin** is assigned to a `const_iterator`, the elements in the multiset object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the multiset object can be modified.  
  
## Example  
  
```  
// multiset_begin.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   multiset <int> ms1;  
   multiset <int>::iterator ms1_Iter;  
   multiset <int>::const_iterator ms1_cIter;  
  
   ms1.insert( 1 );  
   ms1.insert( 2 );  
   ms1.insert( 3 );  
  
   ms1_Iter = ms1.begin( );  
   cout << "The first element of ms1 is " << *ms1_Iter << endl;  
  
   ms1_Iter = ms1.begin( );  
   ms1.erase( ms1_Iter );  
  
   // The following 2 lines would err as the iterator is const  
   // ms1_cIter = ms1.begin( );  
   // ms1.erase( ms1_cIter );  
  
   ms1_cIter = ms1.begin( );  
   cout << "The first element of ms1 is now " << *ms1_cIter << endl;  
}  
```  
  
 **The first element of ms1 is 1**  
**The first element of ms1 is now 2**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)