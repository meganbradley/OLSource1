---
title: "replace"
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
  - "replace"
  - "algorithm/std::replace"
  - "std::replace"
  - "std::basic_string::replace"
  - "basic_string::replace"
  - "xstring/std::basic_string::replace"
  - "std.basic_string.replace"
  - "std.replace"
  - "basic_string.replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace function"
  - "replace method"
  - "replace"
ms.assetid: 8324dd0c-f3f7-4035-9fbe-654010366149
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace
Examines each element in a range and replaces it if it matches a specified value.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator, class Type>  
void replace(  
   ForwardIterator _First,   
   ForwardIterator _Last,  
   const Type& _OldVal,   
   const Type& _NewVal  
);  
```  
  
#### Parameters  
 `_First`  
 A forward iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 `_Last`  
 A forward iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 `_OldVal`  
 The old value of the elements being replaced.  
  
 `_NewVal`  
 The new value being assigned to the elements with the old value.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The `operator==` used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are (`_Last` – `_First`) comparisons for equality and at most (`_Last` – `_First`) assignments of new values.  
  
## Example  
  
```  
// alg_replace.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
  
   int i;  
   for ( i = 0 ; i <= 9 ; i++ )  
      v1.push_back( i );  
  
   int ii;  
   for ( ii = 0 ; ii <= 3 ; ii++ )  
      v1.push_back( 7 );  
  
   random_shuffle (v1.begin( ), v1.end( ) );  
   cout << "The original vector v1 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Replace elements with a value of 7 with a value of 700  
   replace (v1.begin( ), v1.end( ), 7 , 700);  
  
   cout << "The vector v1 with a value 700 replacing that of 7 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
The original vector v1 is:  
 ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 ).  
The vector v1 with a value 700 replacing that of 7 is:  
 ( 700 1 9 2 0 700 700 3 4 6 8 5 700 700 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace](../vs140/replace--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)