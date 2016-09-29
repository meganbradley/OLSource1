---
title: "ref Function"
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
  - "functional/std::tr1::ref"
  - "std::tr1::ref"
  - "std.tr1.ref"
  - "ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ref function [TR1]"
ms.assetid: 71b722a3-7e81-4773-8122-b59e6bb4da65
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ref Function
Constructs a `reference_wrapper` from an argument.  
  
## Syntax  
  
```  
template<class Ty>  
    reference_wrapper<Ty> ref(Ty& arg);  
template<class Ty>  
    reference_wrapper<Ty> ref(reference_wrapper<Ty>& arg);  
```  
  
## Return Value  
 A reference to `arg`; specifically, `reference_wrapper<Ty>(arg)`.  
  
## Example  
 The following example defines two functions: one bound to a string variable, the other bound to a reference of the string variable computed by a call to `ref`. When the value of the variable changes, the first function continues to use the old value and the second function uses the new value.  
  
```  
#include <algorithm>  
#include <functional>  
#include <iostream>  
#include <iterator>  
#include <ostream>  
#include <string>  
#include <vector>  
using namespace std;  
using namespace std;  
using namespace std::placeholders;  
  
bool shorter_than(const string& l, const string& r) {  
    return l.size() < r.size();  
}  
  
int main() {  
    vector<string> v_original;  
    v_original.push_back("tiger");  
    v_original.push_back("cat");  
    v_original.push_back("lion");  
    v_original.push_back("cougar");  
  
    copy(v_original.begin(), v_original.end(), ostream_iterator<string>(cout, " "));  
    cout << endl;  
  
    string s("meow");  
  
    function<bool (const string&)> f = bind(shorter_than, _1, s);  
    function<bool (const string&)> f_ref = bind(shorter_than, _1, ref(s));  
  
    vector<string> v;  
  
    // Remove elements that are shorter than s ("meow")  
  
    v = v_original;  
    v.erase(remove_if(v.begin(), v.end(), f), v.end());  
  
    copy(v.begin(), v.end(), ostream_iterator<string>(cout, " "));  
    cout << endl;  
  
    // Now change the value of s.  
    // f_ref, which is bound to ref(s), will use the  
    // new value, while f is still bound to the old value.  
  
    s = "kitty";  
  
    // Remove elements that are shorter than "meow" (f is bound to old value of s)  
  
    v = v_original;  
    v.erase(remove_if(v.begin(), v.end(), f), v.end());  
  
    copy(v.begin(), v.end(), ostream_iterator<string>(cout, " "));  
    cout << endl;  
  
    // Remove elements that are shorter than "kitty" (f_ref is bound to ref(s))  
  
    v = v_original;  
    v.erase(remove_if(v.begin(), v.end(), f_ref), v.end());  
  
    copy(v.begin(), v.end(), ostream_iterator<string>(cout, " "));  
    cout << endl;  
}  
```  
  
 **tiger cat lion cougar**  
**tiger lion cougar**  
**tiger lion cougar**  
**tiger cougar**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [cref](../vs140/cref-function.md)   
 [reference_wrapper](../vs140/reference_wrapper-class.md)