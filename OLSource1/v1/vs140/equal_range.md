---
title: "equal_range"
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
  - "std::_Tree::equal_range"
  - "_Tree.equal_range"
  - "xhash/std::_Hash::equal_range"
  - "std._Hash.equal_range"
  - "algorithm/std::equal_range"
  - "equal_range"
  - "std::_Hash::equal_range"
  - "_Hash::equal_range"
  - "std._Tree.equal_range"
  - "xtree/std::_Tree::equal_range"
  - "std.equal_range"
  - "_Tree::equal_range"
  - "std::equal_range"
  - "_Hash.equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range"
  - "equal_range method"
  - "equal_range function"
ms.assetid: f508fa87-41c6-4799-90dc-4ebf17d2126a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# equal_range
Given an ordered range, finds the subrange in which all elements are equivalent to a given value.  
  
## Syntax  
  
```  
template<class ForwardIterator, class Type>  
   pair<ForwardIterator, ForwardIterator> equal_range(  
      ForwardIterator first,  
      ForwardIterator last,   
      const Type& val  
   );  
template<class ForwardIterator, class Type, class Predicate>  
   pair<ForwardIterator, ForwardIterator> equal_range(  
      ForwardIterator first,  
      ForwardIterator last,   
      const Type& val,   
      Predicate comp  
   );  
```  
  
#### Parameters  
 `first`  
 A forward iterator addressing the position of the first element in the range to be searched.  
  
 `last`  
 A forward iterator addressing the position one past the final element in the range to be searched.  
  
 `val`  
 The value being searched for in the ordered range.  
  
 `comp`  
 User-defined predicate function object that defines the sense in which one element is less than another.  
  
## Return Value  
 A pair of forward iterators that specify a subrange, contained within the range searched, in which all of the elements are equivalent to `val` in the sense defined by the binary predicate used (either `comp` or the default, less-than).  
  
 If no elements in the range are equivalent to `val`, the returned pair of forward iterators are equal and specify the point where `val` could be inserted without disturbing the order of the range.  
  
## Remarks  
 The first iterator of the pair returned by the algorithm is [lower_bound](../vs140/lower_bound.md), and the second iterator is [upper_bound](../vs140/upper_bound.md).  
  
 The range must be sorted according to the predicate provided to `equal_range`. For example, if you are going to use the greater-than predicate, the range must be sorted in descending order.  
  
 Elements in the possibly empty subrange defined by the pair of iterators returned by `equal_range` will be equivalent to `val` in the sense defined by the predicate used.  
  
 The complexity of the algorithm is logarithmic for random-access iterators and linear otherwise, with the number of steps proportional to (`last` – `first`).  
  
## Example  
  
```cpp  
// alg_equal_range.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      // greater<int>()  
#include <iostream>  
#include <string>  
using namespace std;  
  
template<class T> void dump_vector( const vector<T>& v, pair< typename vector<T>::iterator, typename vector<T>::iterator > range )  
{  
    // prints vector v with range delimited by [ and ]  
  
    for( typename vector<T>::const_iterator i = v.begin(); i != v.end(); ++i )  
    {  
        if( i == range.first )  
        {  
            cout << "[ ";  
        }  
        if( i == range.second )  
        {  
            cout << "] ";  
        }  
  
        cout << *i << " ";  
    }  
    cout << endl;  
}  
  
template<class T> void equal_range_demo( const vector<T>& original_vector, T val )  
{  
    vector<T> v(original_vector);  
  
    sort( v.begin(), v.end() );  
    cout << "Vector sorted by the default binary predicate <:" << endl << '\t';  
    for( vector<T>::const_iterator i = v.begin(); i != v.end(); ++i )  
    {  
        cout << *i << " ";  
    }  
    cout << endl << endl;  
  
    pair< vector<T>::iterator, vector<T>::iterator > result  
        = equal_range( v.begin(), v.end(), val );  
  
    cout << "Result of equal_range with val = " << val << ":" << endl << '\t';  
    dump_vector( v, result );  
    cout << endl;  
}  
  
template<class T, class F> void equal_range_demo( const vector<T>& original_vector, T val, F pred, string predname )  
{  
    vector<T> v(original_vector);  
  
    sort( v.begin(), v.end(), pred );  
    cout << "Vector sorted by the binary predicate " << predname << ":" << endl << '\t';  
    for( typename vector<T>::const_iterator i = v.begin(); i != v.end(); ++i )  
    {  
        cout << *i << " ";  
    }  
    cout << endl << endl;  
  
    pair< typename vector<T>::iterator, typename vector<T>::iterator > result  
        = equal_range( v.begin(), v.end(), val, pred );  
  
    cout << "Result of equal_range with val = " << val << ":" << endl << '\t';  
    dump_vector( v, result );  
    cout << endl;  
}  
  
// Return whether absolute value of elem1 is less than absolute value of elem2  
bool abs_lesser( int elem1, int elem2 )  
{  
    return abs(elem1) < abs(elem2);  
}  
  
// Return whether string l is shorter than string r  
bool shorter_than(const string& l, const string& r)  
{  
    return l.size() < r.size();  
}  
  
int main()  
{  
    vector<int> v1;  
  
    // Constructing vector v1 with default less than ordering  
    for( int i = -1; i <= 4; ++i )  
    {  
        v1.push_back(i);  
    }  
  
    for( int i =-3; i <= 0; ++i )  
    {  
        v1.push_back( i );  
    }  
  
    equal_range_demo( v1, 3 );  
    equal_range_demo( v1, 3, greater<int>(), "greater" );  
    equal_range_demo( v1, 3, abs_lesser, "abs_lesser" );  
  
    vector<string> v2;  
  
    v2.push_back("cute");  
    v2.push_back("fluffy");  
    v2.push_back("kittens");  
    v2.push_back("fun");  
    v2.push_back("meowmeowmeow");  
    v2.push_back("blah");  
  
    equal_range_demo<string>( v2, "fred" );  
    equal_range_demo<string>( v2, "fred", shorter_than, "shorter_than" );  
}  
  
```  
  
## Output  
  
```  
Vector sorted by the default binary predicate <:  
        -3 -2 -1 -1 0 0 1 2 3 4  
  
Result of equal_range with val = 3:  
        -3 -2 -1 -1 0 0 1 2 [ 3 ] 4  
  
Vector sorted by the binary predicate greater:  
        4 3 2 1 0 0 -1 -1 -2 -3  
  
Result of equal_range with val = 3:  
        4 [ 3 ] 2 1 0 0 -1 -1 -2 -3  
  
Vector sorted by the binary predicate abs_lesser:  
        0 0 -1 1 -1 2 -2 3 -3 4  
  
Result of equal_range with val = 3:  
        0 0 -1 1 -1 2 -2 [ 3 -3 ] 4  
  
Vector sorted by the default binary predicate <:  
        blah cute fluffy fun kittens meowmeowmeow  
  
Result of equal_range with val = fred:  
        blah cute fluffy [ ] fun kittens meowmeowmeow  
  
Vector sorted by the binary predicate shorter_than:  
        fun cute blah fluffy kittens meowmeowmeow  
  
Result of equal_range with val = fred:  
        fun [ cute blah ] fluffy kittens meowmeowmeow  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [binary_search](../vs140/binary_search.md)   
 [lower_bound](../vs140/lower_bound.md)   
 [upper_bound](../vs140/upper_bound.md)   
 [Standard Template Library](../vs140/standard-template-library.md)