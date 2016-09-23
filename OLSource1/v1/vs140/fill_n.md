---
title: "fill_n"
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
  - std::fill_n
  - fill_n
  - xutility/std::fill_n
  - std.fill_n
dev_langs: 
  - C++
helpviewer_keywords: 
  - fill_n
  - fill_n function
ms.assetid: ebcda70f-d82c-4f43-b4c8-c7e7cbbccb69
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# fill_n
Assigns a new value to a specified number of elements in a range beginning with a particular element.  
  
## Syntax  
  
```  
  
   template<class OutputIterator, class Size, class Type>  
OutputIterator fill_n(  
   OutputIterator First,   
   Size Count,   
   const Type& Val  
);   
```  
  
#### Parameters  
 `First`  
 An output iterator addressing the position of the first element in the range to be assigned the value `Val`.  
  
 `Count`  
 A signed or unsigned integer type specifying the number of elements to be assigned the value.  
  
 `Val`  
 The value to be assigned to elements in the range [`First`, *First + Count*).  
  
## Return Value  
 An iterator to the element that follows the last element filled if `Count` > zero, otherwise the first element.  
  
## Remarks  
 The destination range must be valid; all pointers must be dereferenceable, and the last position is reachable from the first by incrementation. The complexity is linear with the size of the range.  
  
 `fill_n` has two related forms:  
  
-   [checked_fill_n](assetId:///2870ee35-44f5-499a-b27b-e127199405cd)  
  
-   [unchecked_fill_n](assetId:///8cb92524-9e3a-4207-b405-6db10e3f35d0)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```cpp  
// alg_fill_n.cpp  
// compile using /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main()   
{  
    using namespace std;  
    vector <int> v;  
  
    for ( auto i = 0 ; i < 9 ; ++i )  
        v.push_back( 0 );  
  
    cout << "  vector v = ( " ;  
    for ( const auto &w : v )  
        cout << w << " ";  
    cout << ")" << endl;  
  
    // Fill the first 3 positions with a value of 1, saving position.  
    auto pos = fill_n( v.begin(), 3, 1 );  
  
    cout << "modified v = ( " ;  
    for ( const auto &w : v )  
        cout << w << " ";  
    cout << ")" << endl;  
  
    // Fill the next 3 positions with a value of 2, using last position.  
    fill_n( pos, 3, 2 );  
  
    cout << "modified v = ( " ;  
    for ( const auto &w : v )  
        cout << w << " ";  
    cout << ")" << endl;  
  
    // Fill the last 3 positions with a value of 3, using relative math.  
    fill_n( v.end()-3, 3, 3 );  
  
    cout << "modified v = ( " ;  
    for ( const auto &w : v )  
        cout << w << " ";  
    cout << ")" << endl;  
}  
  
```  
  
## Output  
  
```  
  vector v = ( 0 0 0 0 0 0 0 0 0 )  
modified v = ( 1 1 1 0 0 0 0 0 0 )  
modified v = ( 1 1 1 2 2 2 0 0 0 )  
modified v = ( 1 1 1 2 2 2 3 3 3 )  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)