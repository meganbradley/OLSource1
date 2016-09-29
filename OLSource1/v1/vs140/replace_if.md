---
title: "replace_if"
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
  - "algorithm/std::replace_if"
  - "std.replace_if"
  - "std::replace_if"
  - "replace_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_if function"
  - "replace_if"
ms.assetid: 3d01105a-046d-42aa-9dc9-a6b1c53ec802
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_if
Examines each element in a range and replaces it if it satisfies a specified predicate.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator, class Predicate, class Type>  
void replace_if(  
   ForwardIterator _First,   
   ForwardIterator _Last,  
   Predicate _Pred,   
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_First`  
 A forward iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 `_Last`  
 An iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 `_Pred`  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
 `_Val`  
 The new value being assigned to the elements whose old value satisfies the predicate.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The algorithm `replace_if` is a generalization of the algorithm **replace**, allowing any predicate to be specified, rather than equality to a specified constant value.  
  
 The `operator==` used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (`_Last` – `_First`) comparisons for equality and at most (`_Last` – `_First`) assignments of new values.  
  
## Example  
  
```  
// alg_replace_if.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
bool greater6 ( int value ) {  
   return value >6;  
}  
  
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
  
   random_shuffle ( v1.begin( ), v1.end( ) );  
   cout << "The original vector v1 is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Replace elements satisfying the predicate greater6  
   // with a value of 70  
   replace_if ( v1.begin( ), v1.end( ), greater6 , 70);  
  
   cout << "The vector v1 with a value 70 replacing those\n "  
        << "elements satisfying the greater6 predicate is:\n ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
}  
```  
  
## Sample Output  
  
```  
The original vector v1 is:  
 ( 7 1 9 2 0 7 7 3 4 6 8 5 7 7 ).  
The vector v1 with a value 70 replacing those  
 elements satisfying the greater6 predicate is:  
 ( 70 1 70 2 0 70 70 3 4 6 70 5 70 70 ).  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace_if](../vs140/replace_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)