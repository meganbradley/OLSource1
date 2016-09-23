---
title: "hash_multiset::begin"
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
  - hash_multiset::begin
  - std.hash_multiset.begin
  - hash_multiset.begin
  - hash_set/stdext::hash_multiset::begin
  - std::hash_multiset::begin
dev_langs: 
  - C++
helpviewer_keywords: 
  - begin method, with specific classes
ms.assetid: c67d20c5-19f0-49ac-ba28-317a52d6f7d5
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multiset::begin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator that addresses the first element in the hash_multiset.  
  
## Syntax  
  
```  
  
      const_iterator begin( ) const;   
iterator begin( );  
```  
  
## Return Value  
 A bidirectional iterator addressing the first element in the hash_multiset or the location succeeding an empty hash_multiset.  
  
## Remarks  
 If the return value of **begin** is assigned to a `const_iterator`, the elements in the hash_multiset object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the hash_multiset object can be modified.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_begin.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1;  
   hash_multiset <int>::iterator hms1_Iter;  
   hash_multiset <int>::const_iterator hms1_cIter;  
  
   hms1.insert( 1 );  
   hms1.insert( 2 );  
   hms1.insert( 3 );  
  
   hms1_Iter = hms1.begin( );  
   cout << "The first element of hms1 is " << *hms1_Iter << endl;  
  
   hms1_Iter = hms1.begin( );  
   hms1.erase( hms1_Iter );  
  
   // The following 2 lines would err because the iterator is const  
   // hms1_cIter = hms1.begin( );  
   // hms1.erase( hms1_cIter );  
  
   hms1_cIter = hms1.begin( );  
   cout << "The first element of hms1 is now " << *hms1_cIter << endl;  
}  
```  
  
 **The first element of hms1 is 1**  
**The first element of hms1 is now 2**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)