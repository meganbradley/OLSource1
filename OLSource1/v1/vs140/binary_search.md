---
title: "binary_search"
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
  - "binary_search"
  - "std.binary_search"
  - "std::binary_search"
  - "algorithm/std::binary_search"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary_search function"
  - "binary_search"
ms.assetid: 6dec2260-8aeb-4a66-9fb1-3afcf7a415f6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binary_search
Tests whether there is an element in a sorted range that is equal to a specified value or that is equivalent to it in a sense specified by a binary predicate.  
  
## Syntax  
  
```  
  
      template<class ForwardIterator, class Type>  
   bool binary_search(  
      ForwardIterator first,   
      ForwardIterator last,  
      const Type& value  
   );  
template<class ForwardIterator, class Type, class BinaryPredicate>  
   bool binary_search(  
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
 The value required to be matched by the value of the element or that must satisfy the condition with the element value specified by the binary predicate.  
  
 `comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns `true`when satisfied and `false` when not satisfied.  
  
## Return Value  
 `true` if an element is found in the range that is equal or equivalent to the specified value; otherwise, `false`.  
  
## Remarks  
 The sorted source range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The sorted range must each be arranged as a precondition to the application of the `binary_search` algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The source ranges are not modified by `binary_search`.  
  
 The value types of the forward iterators need to be less-than comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to (`last` – `first`).  
  
## Example  
  
```cpp  
// alg_bin_srch.cpp  
// compile with: /EHsc  
#include <list>  
#include <vector>  
#include <algorithm>  
#include <functional>      // greater<int>( )  
#include <iostream>  
  
// Return whether modulus of elem1 is less than modulus of elem2  
bool mod_lesser( int elem1, int elem2 )  
{  
    if (elem1 < 0)  
        elem1 = - elem1;  
    if (elem2 < 0)  
        elem2 = - elem2;  
    return elem1 < elem2;  
}  
  
int main( )  
{  
    using namespace std;  
  
    list <int> List1;  
  
    List1.push_back( 50 );  
    List1.push_back( 10 );  
    List1.push_back( 30 );  
    List1.push_back( 20 );  
    List1.push_back( 25 );  
    List1.push_back( 5 );  
  
    List1.sort();  
  
    cout << "List1 = ( " ;  
    for ( auto Iter : List1 )  
        cout << Iter << " ";  
    cout << ")" << endl;  
  
    // default binary search for 10  
    if( binary_search(List1.begin(), List1.end(), 10) )  
        cout << "There is an element in list List1 with a value equal to 10."  
        << endl;  
    else  
        cout << "There is no element in list List1 with a value equal to 10."  
        << endl;  
  
    // a binary_search under the binary predicate greater  
    List1.sort(greater<int>());  
    if( binary_search(List1.begin(), List1.end(), 10, greater<int>()) )  
        cout << "There is an element in list List1 with a value greater than 10 "  
        << "under greater than." << endl;  
    else  
        cout << "No element in list List1 with a value greater than 10 "  
        << "under greater than." << endl;  
  
    // a binary_search under the user-defined binary predicate mod_lesser  
    vector<int> v1;  
  
    for( auto i = -2; i <= 4; ++i )  
    {  
        v1.push_back(i);  
    }  
  
    sort(v1.begin(), v1.end(), mod_lesser);  
  
    cout << "Ordered using mod_lesser, vector v1 = ( " ;  
    for( auto Iter : v1 )  
        cout << Iter << " ";  
    cout << ")" << endl;  
  
    if( binary_search(v1.begin(), v1.end(), -3, mod_lesser) )  
        cout << "There is an element with a value equivalent to -3 "  
        << "under mod_lesser." << endl;  
    else  
        cout << "There is not an element with a value equivalent to -3 "  
        << "under mod_lesser." << endl;  
}  
  
```  
  
## Output  
  
```  
List1 = ( 5 10 20 25 30 50 )  
There is an element in list List1 with a value equal to 10.  
There is an element in list List1 with a value greater than 10 under greater than.  
Ordered using mod_lesser, vector v1 = ( 0 -1 1 -2 2 3 4 )  
There is an element with a value equivalent to -3 under mod_lesser.  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [lower_bound](../vs140/lower_bound.md)   
 [upper_bound](../vs140/upper_bound.md)   
 [equal_range](../vs140/equal_range.md)   
 [Standard Template Library](../vs140/standard-template-library.md)