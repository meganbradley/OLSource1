---
title: "find_if"
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
  - "std::find_if"
  - "algorithm/std::find_if"
  - "std.find_if"
  - "find_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_if function"
  - "find_if"
ms.assetid: aa8ff698-e47e-4ff8-8c88-cbda4b102a4a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# find_if
Locates the position of the first occurrence of an element in a range that satisfies a specified condition.  
  
## Syntax  
  
```  
template<class InputIterator, class Predicate>  
InputIterator find_if(InputIterator first, InputIterator last,   
      Predicate pred);  
```  
  
#### Parameters  
 `first`  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 `last`  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 `pred`  
 User-defined predicate function object or [lambda expression](../vs140/lambda-expressions-in-c--.md) that defines the condition to be satisfied by the element being searched for. A predicate takes single argument and returns `true` (satisfied) or `false` (not satisfied). The signature of `pred` must effectively be `bool pred(const T& arg);`, where `T` is a type to which `InputIterator` can be implicitly converted when dereferenced. The `const` keyword is shown only to illustrate that the function object or lambda should not modify the argument.  
  
## Return Value  
 An input iterator that refers to the first element in the range that satisfies the condition specified by the predicate (the predicate results in `true`). If no element is found to satisfy the predicate, returns `last`.  
  
## Remarks  
 This template function is a generalization of the algorithm [find](../vs140/find--stl-.md), replacing the predicate "equals a specific value" with any predicate. For the logical opposite (find the first element that does not satisfy the predicate), see [find_if_not](../vs140/find_if_not.md).  
  
## Example  
  
```cpp  
// cl.exe /W4 /nologo /EHsc /MTd  
#include <vector>  
#include <algorithm>  
#include <iostream>  
#include <string>  
  
using namespace std;  
  
template <typename S> void print(const S& s) {  
    for (const auto& p : s) {  
        cout << "(" << p << ") ";  
    }  
    cout << endl;  
}  
  
// Test std::find()  
template <class InputIterator, class T>  
void find_print_result(InputIterator first, InputIterator last, const T& value) {  
  
    // call <algorithm> std::find()  
    auto p = find(first, last, value);  
  
    cout << "value " << value;  
    if (p == last) {  
        cout << " not found." << endl;  
    } else {  
        cout << " found." << endl;  
    }  
}  
  
// Test std::find_if()  
template <class InputIterator, class Predicate>  
void find_if_print_result(InputIterator first, InputIterator last,  
    Predicate Pred, const string& Str) {  
  
    // call <algorithm> std::find_if()  
    auto p = find_if(first, last, Pred);  
  
    if (p == last) {  
        cout << Str << " not found." << endl;  
    } else {  
        cout << "first " << Str << " found: " << *p << endl;  
    }  
}  
  
// Function to use as the UnaryPredicate argument to find_if() in this example  
bool is_odd_int(int i) {  
    return ((i % 2) != 0);  
}  
  
int main()  
{  
    // Test using a plain old array.  
    const int x[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  
    cout << "array x[] contents: ";  
    print(x);  
    // Using non-member std::begin()/std::end() to get input iterators for the plain old array.  
    cout << "Test std::find() with array..." << endl;  
    find_print_result(begin(x), end(x), 10);  
    find_print_result(begin(x), end(x), 42);  
    cout << "Test std::find_if() with array..." << endl;  
    find_if_print_result(begin(x), end(x), is_odd_int, "odd integer"); // function name  
    find_if_print_result(begin(x), end(x), // lambda  
        [](int i){ return ((i % 2) == 0); }, "even integer");  
  
    // Test using a vector.  
    vector<int> v;  
    for (int i = 0; i < 10; ++i) {  
        v.push_back((i + 1) * 10);  
    }  
    cout << endl << "vector v contents: ";  
    print(v);  
    cout << "Test std::find() with vector..." << endl;  
    find_print_result(v.begin(), v.end(), 20);  
    find_print_result(v.begin(), v.end(), 12);  
    cout << "Test std::find_if() with vector..." << endl;  
    find_if_print_result(v.begin(), v.end(), is_odd_int, "odd integer");  
    find_if_print_result(v.begin(), v.end(), // lambda  
        [](int i){ return ((i % 2) == 0); }, "even integer");  
}  
  
```  
  
## Output  
 **array x[] contents: (1) (2) (3) (4) (5) (6) (7) (8) (9) (10)Test std::find() with array...value 10 found.value 42 not found.Test std::find_if() with array...first odd integer found: 1first even integer found: 2vector v contents: (10) (20) (30) (40) (50) (60) (70) (80) (90) (100)Test std::find() with vector...value 20 found.value 12 not found.Test std::find_if() with vector...odd integer not found.first even integer found: 10**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [adjacent_find](../vs140/adjacent_find.md)   
 [find](../vs140/find--stl-.md)   
 [find_if_not](../vs140/find_if_not.md)   
 [find_end](../vs140/find_end.md)   
 [mismatch](../vs140/mismatch.md)   
 [search](../vs140/search.md)