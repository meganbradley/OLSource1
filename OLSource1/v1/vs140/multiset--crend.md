---
title: "multiset::crend"
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
  - "multiset.crend"
  - "std::multiset::crend"
  - "std.multiset.crend"
  - "set/std::multiset::crend"
  - "multiset::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: 3f8454e7-1f37-4afe-a624-81c491ee27dc
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# multiset::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed multiset.  
  
## Syntax  
  
```  
  
const_reverse_iterator crend( ) const;  
  
```  
  
## Return Value  
 A  const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multiset (the location that had preceded the first element in the unreversed multiset).  
  
## Remarks  
 `crend` is used with a reversed multiset just as [end](../vs140/multiset--end.md) is used with a multiset.  
  
 With the return value of `crend`, the multiset object cannot be modified.  
  
 `crend` can be used to test to whether a reverse iterator has reached the end of its multiset.  
  
 The value returned by `crend` should not be dereferenced.  
  
## Example  
  
```  
// multiset_crend.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main() {  
   using namespace std;     
   multiset <int> ms1;  
   multiset <int>::const_reverse_iterator ms1_crIter;  
  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
   ms1.insert( 30 );  
  
   ms1_crIter = ms1.crend( ) ;  
   ms1_crIter--;  
   cout << "The last element in the reversed multiset is "  
        << *ms1_crIter << "." << endl;  
}  
```  
  
## Output  
  
```  
The last element in the reversed multiset is 10.  
```  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)