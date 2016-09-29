---
title: "lower_bound"
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
  - "algorithm/std::lower_bound"
  - "_Hash.lower_bound"
  - "xhash/std::_Hash::lower_bound"
  - "std._Tree.lower_bound"
  - "xtree/std::_Tree::lower_bound"
  - "std._Hash.lower_bound"
  - "std::lower_bound"
  - "lower_bound"
  - "_Tree::lower_bound"
  - "std::_Hash::lower_bound"
  - "std::_Tree::lower_bound"
  - "_Tree.lower_bound"
  - "std.lower_bound"
  - "_Hash::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
  - "lower_bound"
  - "lower_bound method"
ms.assetid: bf1b020c-f97a-4e2b-85f4-c09f6a0da1c4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lower_bound
Finds the position of the first element in an ordered range that has a value greater than or equivalent to a specified value, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
  
      template<class ForwardIterator, class Type>  
   ForwardIterator lower_bound(  
      ForwardIterator first,   
      ForwardIterator last,  
      const Type& value  
   );  
template<class ForwardIterator, class Type, class BinaryPredicate>  
   ForwardIterator lower_bound(  
      ForwardIterator first,   
      ForwardIterator last,  
      const Type& value,  
      BinaryPredicate comp  
   );  
```  
  
#### Parameters  
 `first`  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 `last`  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 `value`  
 The value whose first position or possible first position is being searched for in the ordered range.  
  
 `comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator at the position of the first element in an ordered range with a value that is greater than or equivalent to a specified value, where the equivalence is specified with a binary predicate.  
  
## Remarks  
 The sorted source range referenced must be valid; all iterators must be dereferenceable and within the sequence the last position must be reachable from the first by incrementation.  
  
 A sorted range is a precondition of using `lower_bound` and where the ordering is the same as specified by with binary predicate.  
  
 The range is not modified by the algorithm `lower_bound`.  
  
 The value types of the forward iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to (`last – first`).  
  
## Example  
  
```cpp  
// alg_lower_bound.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      // greater<int>( )  
#include <iostream>  
  
// Return whether modulus of elem1 is less than modulus of elem2  
bool mod_lesser( int elem1, int elem2 )  
{  
    if ( elem1 < 0 )  
        elem1 = - elem1;  
    if ( elem2 < 0 )  
        elem2 = - elem2;  
    return elem1 < elem2;  
}  
  
int main( )  
{  
    using namespace std;  
  
    vector<int> v1;  
    // Constructing vector v1 with default less-than ordering  
    for ( auto i = -1 ; i <= 4 ; ++i )  
    {  
        v1.push_back(  i );  
    }  
  
    for ( auto ii =-3 ; ii <= 0 ; ++ii )  
    {  
        v1.push_back(  ii  );  
    }  
  
    cout << "Starting vector v1 = ( " ;  
    for (const auto &Iter : v1)  
        cout << Iter << " ";  
    cout << ")." << endl;  
  
    sort(v1.begin(), v1.end());  
    cout << "Original vector v1 with range sorted by the\n "  
        << "binary predicate less than is v1 = ( " ;  
    for (const auto &Iter : v1)  
        cout << Iter << " ";  
    cout << ")." << endl;  
  
    // Constructing vector v2 with range sorted by greater  
    vector<int> v2(v1);  
  
    sort(v2.begin(), v2.end(), greater<int>());  
  
    cout << "Original vector v2 with range sorted by the\n "  
        << "binary predicate greater is v2 = ( " ;  
    for (const auto &Iter : v2)  
        cout << Iter << " ";  
    cout << ")." << endl;  
  
    // Constructing vectors v3 with range sorted by mod_lesser  
    vector<int> v3(v1);  
    sort(v3.begin(), v3.end(), mod_lesser);  
  
    cout << "Original vector v3 with range sorted by the\n "  
        <<  "binary predicate mod_lesser is v3 = ( " ;  
    for (const auto &Iter : v3)  
        cout << Iter << " ";  
    cout << ")." << endl;  
  
    // Demonstrate lower_bound  
  
    vector<int>::iterator Result;  
  
    // lower_bound of 3 in v1 with default binary predicate less<int>()  
    Result = lower_bound(v1.begin(), v1.end(), 3);  
    cout << "The lower_bound in v1 for the element with a value of 3 is: "  
        << *Result << "." << endl;  
  
    // lower_bound of 3 in v2 with the binary predicate greater<int>( )  
    Result = lower_bound(v2.begin(), v2.end(), 3, greater<int>());  
    cout << "The lower_bound in v2 for the element with a value of 3 is: "  
        << *Result << "." << endl;  
  
    // lower_bound of 3 in v3 with the binary predicate  mod_lesser  
    Result = lower_bound(v3.begin(), v3.end(), 3,  mod_lesser);  
    cout << "The lower_bound in v3 for the element with a value of 3 is: "  
        << *Result << "." << endl;  
}  
  
```  
  
## Output  
  
```  
Starting vector v1 = ( -1 0 1 2 3 4 -3 -2 -1 0 ).  
Original vector v1 with range sorted by the  
 binary predicate less than is v1 = ( -3 -2 -1 -1 0 0 1 2 3 4 ).  
Original vector v2 with range sorted by the  
 binary predicate greater is v2 = ( 4 3 2 1 0 0 -1 -1 -2 -3 ).  
Original vector v3 with range sorted by the  
 binary predicate mod_lesser is v3 = ( 0 0 -1 -1 1 -2 2 -3 3 4 ).  
The lower_bound in v1 for the element with a value of 3 is: 3.  
The lower_bound in v2 for the element with a value of 3 is: 3.  
The lower_bound in v3 for the element with a value of 3 is: -3.  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [upper_bound](../vs140/upper_bound.md)   
 [equal_range](../vs140/equal_range.md)   
 [binary_search](../vs140/binary_search.md)   
 [lower_bound](../vs140/lower_bound--stl-samples-.md)   
 [Predicate Version of lower_bound](../vs140/predicate-version-of-lower_bound.md)   
 [Standard Template Library](../vs140/standard-template-library.md)