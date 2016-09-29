---
title: "mismatch"
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
  - "std::mismatch"
  - "std.mismatch"
  - "mismatch"
  - "xutility/std::mismatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mismatch"
  - "mismatch function"
ms.assetid: a9fe78f3-9a86-44dc-9400-0c2ed1083323
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mismatch
Compares two ranges element by element and locates the first position where a difference occurs.  
  
 Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
## Syntax  
  
```  
  
      template<class InputIterator1, class InputIterator2>  
   pair<InputIterator1, InputIterator2> mismatch(  
      InputIterator1 First1,  
      InputIterator1 Last1,  
      InputIterator2 First2  
  );  
template<class InputIterator1, class InputIterator2, class BinaryPredicate>  
   pair<InputIterator1, InputIterator2> mismatch(  
      InputIterator1 First1,  
      InputIterator1 Last1,  
      InputIterator2 First2,  
      BinaryPredicate Comp  
   );  
  
//C++14  
template<class InputIterator1, class InputIterator2>  
   pair<InputIterator1, InputIterator2> mismatch(  
      InputIterator1 First1,  
      InputIterator1 Last1,  
      InputIterator2 First2,  
      InputIterator2 Last2  
  );  
template<class InputIterator1, class InputIterator2, class BinaryPredicate>  
   pair<InputIterator1, InputIterator2> mismatch(  
      InputIterator1 First1,  
      InputIterator1 Last1,  
      InputIterator2 First2,  
      InputIterator2 Last2,  
      BinaryPredicate Comp  
   );  
```  
  
#### Parameters  
 `First1`  
 An input iterator addressing the position of the first element in the first range to be tested.  
  
 `Last1`  
 An input iterator addressing the position one past the last element in the first range to be tested.  
  
 `First2`  
 An input iterator addressing the position of the first element in the second range to be tested.  
  
 `Last2`  
 An input iterator addressing the position of one past the last element in the second range to be tested.  
  
 `Comp`  
 User-defined predicate function object that compares the current elements in each range and determines whether they are equivalent. It returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 A pair of iterators addressing the positions of the mismatch in the two ranges, the first component iterator to the position in the first range and the second component iterator to the position in the second range. If there is no difference between the elements in the ranges compared or if the binary predicate in the second version is satisfied by all element pairs from the two ranges, then the first component iterator points to the position one past the final element in the first range and the second component iterator to position one past the final element tested in the second range.  
  
## Remarks  
 The first template function assumes that there are as many elements in the range beginning at first2 as there are in the range designated by [first1, last1). If there are more in the second range, they are ignored; if there are less then undefined behavior will result.  
  
 The range to be searched must be valid; all iterators must be dereferenceable and the last position is reachable from the first by incrementation.  
  
 The time complexity of the algorithm is linear in the number of elements contained in the shorter range.  
  
 The user-defined predicate is not required to impose an equivalence relation that symmetric, reflexive and transitive between its operands.  
  
## Example  
 The following example demonstrates how to use mismatch. The C++03 overload is shown only in order to demonstrate how it can produce an unexpected result.  
  
```  
  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <iostream>  
#include <string>  
#include <utility>  
  
using namespace std;  
  
// Return whether first element is twice the second  
// Note that this is not a symmetric, reflexive and transitive equivalence.  
// mismatch and equal accept such predicates, but is_permutation does not.  
bool twice(int elem1, int elem2)  
{  
    return elem1 == elem2 * 2;  
}  
  
void PrintResult(const string& msg, const pair<vector<int>::iterator, vector<int>::iterator>& result,  
    const vector<int>& left, const vector<int>& right)  
{  
    // If either iterator stops before reaching the end of its container,  
    // it means a mismatch was detected.  
    if (result.first != left.end() || result.second != right.end())  
    {  
        string leftpos(result.first == left.end() ? "end" : to_string(*result.first));  
        string rightpos(result.second == right.end() ? "end" : to_string(*result.second));  
        cout << msg << "mismatch. Left iterator at " << leftpos  
            << " right iterator at " << rightpos << endl;  
    }  
    else  
    {  
        cout << msg << " match." << endl;  
    }  
}  
  
int main()  
{  
  
    vector<int> vec_1{ 0, 5, 10, 15, 20, 25 };  
    vector<int> vec_2{ 0, 5, 10, 15, 20, 25, 30 };  
  
    // Testing different length vectors for mismatch (C++03)  
    auto match_vecs = mismatch(vec_1.begin(), vec_1.end(), vec_2.begin());  
    bool is_mismatch = match_vecs.first != vec_1.end();  
    cout << "C++03: vec_1 and vec_2 are a mismatch: " << boolalpha << is_mismatch << endl;  
  
    // Using dual-range overloads:  
  
    // Testing different length vectors for mismatch (C++14)  
    match_vecs = mismatch(vec_1.begin(), vec_1.end(), vec_2.begin(), vec_2.end());  
    PrintResult("C++14: vec_1 and vec_2: ", match_vecs, vec_1, vec_2);  
  
    // Identify point of mismatch between vec_1 and modified vec_2.   
    vec_2[3] = 42;  
    match_vecs = mismatch(vec_1.begin(), vec_1.end(), vec_2.begin(), vec_2.end());  
    PrintResult("C++14 vec_1 v. vec_2 modified: ", match_vecs, vec_1, vec_2);  
  
    // Test vec_3 and vec_4 for mismatch under the binary predicate twice (C++14)    
    vector<int> vec_3{ 10, 20, 30, 40, 50, 60 };  
    vector<int> vec_4{ 5, 10, 15, 20, 25, 30 };  
    match_vecs = mismatch(vec_3.begin(), vec_3.end(), vec_4.begin(), vec_4.end(), twice);  
    PrintResult("vec_3 v. vec_4 with pred: ", match_vecs, vec_3, vec_4);  
  
    vec_4[5] = 31;  
    match_vecs = mismatch(vec_3.begin(), vec_3.end(), vec_4.begin(), vec_4.end(), twice);  
    PrintResult("vec_3 v. modified vec_4 with pred: ", match_vecs, vec_3, vec_4);  
  
    // Compare a vector<int> to a list<int>  
    list<int> list_1{ 0, 5, 10, 15, 20, 25 };  
    auto match_vec_list = mismatch(vec_1.begin(), vec_1.end(), list_1.begin(), list_1.end());  
    is_mismatch = match_vec_list.first != vec_1.end() || match_vec_list.second != list_1.end();  
    cout << "vec_1 and list_1 are a mismatch: " << boolalpha << is_mismatch << endl;  
  
    char c;  
    cout << "Press a key" << endl;  
    cin >> c;  
  
}  
  
/*  
Output:  
C++03: vec_1 and vec_2 are a mismatch: false  
C++14: vec_1 and vec_2: mismatch. Left iterator at end right iterator at 30  
C++14 vec_1 v. vec_2 modified: mismatch. Left iterator at 15 right iterator at 42  
C++14 vec_3 v. vec_4 with pred:  match.  
C++14 vec_3 v. modified vec_4 with pred: mismatch. Left iterator at 60 right iterator at 31  
C++14: vec_1 and list_1 are a mismatch: false  
Press a key  
*/  
  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)