---
title: "upper_bound"
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
  - _Tree.upper_bound
  - algorithm/std::upper_bound
  - xtree/std::_Tree::upper_bound
  - std._Hash.upper_bound
  - std::_Tree::upper_bound
  - upper_bound
  - _Tree::upper_bound
  - _Hash.upper_bound
  - _Hash::upper_bound
  - std::upper_bound
  - std._Tree.upper_bound
  - std::_Hash::upper_bound
  - std.upper_bound
  - xhash/std::_Hash::upper_bound
dev_langs: 
  - C++
helpviewer_keywords: 
  - upper_bound method
  - upper_bound
  - upper_bound function
ms.assetid: dc465786-0704-42b4-af2a-3fabc917c928
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# upper_bound
Finds the position of the first element in an ordered range that has a value that is greater than a specified value, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
template<class ForwardIterator, class Type>  
   ForwardIterator upper_bound(  
      ForwardIterator first,   
      ForwardIterator last,  
      const Type& value  
   );  
template<class ForwardIterator, class Type, class Predicate>  
   ForwardIterator upper_bound(  
      ForwardIterator first,   
      ForwardIterator last,  
      const Type& value,  
      Predicate comp  
   );  
```  
  
#### Parameters  
 `first`  
 The position of the first element in the range to be searched.  
  
 `last`  
 The position one past the final element in the range to be searched.  
  
 `value`  
 The value in the ordered range that needs to be exceeded by the value of the element addressed by the iterator returned.  
  
 `comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A forward iterator to the position of the first element that has a value greater than a specified value.  
  
## Remarks  
 The sorted source range referenced must be valid; all iterators must be dereferenceable and within the sequence the last position must be reachable from the first by incrementation.  
  
 A sorted range is a precondition of the use of `upper_bound` and where the ordering criterion is the same as specified by the binary predicate.  
  
 The range is not modified by `upper_bound`.  
  
 The value types of the forward iterators need be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to (`last - first`).  
  
## Example  
  
```cpp  
// alg_upper_bound.cpp  
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
  
    // Demonstrate upper_bound  
  
    vector<int>::iterator Result;  
  
    // upper_bound of 3 in v1 with default binary predicate less<int>()  
    Result = upper_bound(v1.begin(), v1.end(), 3);  
    cout << "The upper_bound in v1 for the element with a value of 3 is: "  
        << *Result << "." << endl;  
  
    // upper_bound of 3 in v2 with the binary predicate greater<int>( )  
    Result = upper_bound(v2.begin(), v2.end(), 3, greater<int>());  
    cout << "The upper_bound in v2 for the element with a value of 3 is: "  
        << *Result << "." << endl;  
  
    // upper_bound of 3 in v3 with the binary predicate  mod_lesser  
    Result = upper_bound(v3.begin(), v3.end(), 3,  mod_lesser);  
    cout << "The upper_bound in v3 for the element with a value of 3 is: "  
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
The upper_bound in v1 for the element with a value of 3 is: 4.  
The upper_bound in v2 for the element with a value of 3 is: 2.  
The upper_bound in v3 for the element with a value of 3 is: 4.  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [lower_bound](../vs140/lower_bound.md)   
 [equal_range](../vs140/equal_range.md)   
 [binary_search](../vs140/binary_search.md)   
 [Predicate Version of upper_bound](../vs140/predicate-version-of-upper_bound.md)   
 [upper_bound](../vs140/upper_bound--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)