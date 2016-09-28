---
title: "is_permutation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 3384e786-e210-4648-b2bc-3896b5e14f1f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_permutation
Returns true if both ranges contain the same elements, whether or not the elements are in the same order. Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
## Syntax  
  
```cpp  
template<class FwdIt1, class FwdIt2>  
    bool is_permutation(FwdIt First1, FwdIt Last1,  
        FwdIt First2);   
template<class FwdIt1, class FwdIt2, class Pr>  
    bool is_permutation(FwdIt First1, FwdIt Last1,  
        FwdIt First2, Pr Pred);  
// C++14  
template<class FwdIt1, class FwdIt2>  
    bool is_permutation(FwdIt First1, FwdIt Last1,  
        FwdIt First2, FwdIt Last2);   
template<class FwdIt1, class FwdIt2, class Pr>  
    bool is_permutation(FwdIt First1, FwdIt Last1,  
        FwdIt First2, FwdIt Last2, Pr Pred);  
```  
  
#### Parameters  
 `First1`  
 A forward iterator that refers to the first element of the range.  
  
 `Last1`  
 A forward iterator that refers one past the last element of the range.  
  
 `First2`  
 A forward iterator that refers to the first element of a second range, used for comparison.  
  
 `Last2`  
 A forward iterator that refers to one past the last element of a second range, used for comparison.  
  
 `Pred`  
 A predicate that tests for equivalence and returns a `bool`.  
  
## Return Value  
 `true` when the ranges can be rearranged so as to be identical according to the comparator predicate; otherwise, `false`.  
  
## Remarks  
 `is_permutation` has quadratic complexity in the worst case.  
  
 The first template function assumes that there are as many elements in the range beginning at `First2` as there are in the range designated by [`First1`, `Last1`). If there are more elements in the second range, they are ignored; if there are less, undefined behavior will occur. The third template function (C++14 and later) does not make this assumption.  Both return `true` only if, for each element X in the range designated by [`First1`, `Last1`) there are as many elements Y in the same range for which X == Y as there are in the range beginning at `First2` or [`First2, Last2).` Here, `operator==` must perform a pairwise comparison between its operands.  
  
 The second and fourth template functions behave the same, except that they replace `operator==(X, Y)` with `Pred(X, Y)`. To behave correctly, the predicate must be symmetric, reflexive and transitive.  
  
## Example  
 The following example shows how to use `is_permutation`:  
  
```  
  
#include <vector>  
#include <iostream>  
#include <algorithm>  
#include <string>  
  
using namespace std;  
  
int main()  
{  
    vector<int> vec_1{ 2, 3, 0, 1, 4, 5 };  
    vector<int> vec_2{ 5, 4, 0, 3, 1, 2 };  
  
    vector<int> vec_3{ 4, 9, 13, 3, 6, 5 };  
    vector<int> vec_4{ 7, 4, 11, 9, 2, 1 };  
  
    cout << "(1) Compare using built-in == operator: ";  
    cout << boolalpha << is_permutation(vec_1.begin(), vec_1.end(),  
        vec_2.begin(), vec_2.end()) << endl; // true  
  
    cout << "(2) Compare after modifying vec_2: ";  
    vec_2[0] = 6;  
    cout << is_permutation(vec_1.begin(), vec_1.end(),  
        vec_2.begin(), vec_2.end()) << endl; // false  
  
    // Define equivalence as "both are odd or both are even"  
    cout << "(3) vec_3 is a permutation of vec_4: ";  
    cout << is_permutation(vec_3.begin(), vec_3.end(),  
        vec_4.begin(), vec_4.end(),  
        [](int lhs, int rhs) { return lhs % 2 == rhs % 2; }) << endl; // true  
  
    // Initialize a vector using the 's' string literal to specify a std::string  
    vector<string> animals_1{ "dog"s, "cat"s, "bird"s, "monkey"s };  
    vector<string> animals_2{ "donkey"s, "bird"s, "meerkat"s, "cat"s };  
  
    // Define equivalence as "first letters are equal":  
    bool is_perm = is_permutation(animals_1.begin(), animals_1.end(), animals_2.begin(), animals_2.end(),  
        [](const string& lhs, const string& rhs)  
    {  
        return lhs[0] == rhs[0]; //std::string guaranteed to have at least a null terminator  
    });  
  
    cout << "animals_2 is a permutation of animals_1: " << is_perm << endl; // true  
  
    cout << "Press a letter" << endl;  
    char c;  
    cin >> c;  
  
    return 0;  
}  
  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [<algorithm\>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)