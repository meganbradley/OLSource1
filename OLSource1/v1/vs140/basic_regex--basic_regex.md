---
title: "basic_regex::basic_regex"
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
  - std.tr1.basic_regex.basic_regex
  - std::tr1::basic_regex::basic_regex
  - basic_regex::basic_regex
  - basic_regex.basic_regex
dev_langs: 
  - C++
helpviewer_keywords: 
  - basic_regex constructor [TR1]
ms.assetid: 2771018f-c603-426e-b98d-fa8f3ec71375
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_regex::basic_regex
Construct the regular expression object.  
  
## Syntax  
  
```  
basic_regex();  
explicit basic_regex(  
    const Elem* ptr,  
    flag_type flags  
);  
explicit basic_regex(  
    const Elem* ptr,   
    size_type len,  
    flag_type flags  
);  
basic_regex(  
    const basic_regex& right  
);  
basic_regex(  
    initializer_list<Type> IList,  
    flag_type flags   
);  
template<class STtraits, class STalloc>  
    explicit basic_regex(  
        const basic_string<Elem, STtraits, STalloc>& str,  
        flag_type flags   
    );  
template<class InIt>  
    explicit basic_regex(  
        InIt first,   
        InIt last,  
        flag_type flags   
    );  
  
```  
  
#### Parameters  
 `STtraits`  
 Traits class for a string source.  
  
 `STalloc`  
 Allocator class for a string source.  
  
 `InIt`  
 Input iterator type for a range source.  
  
 `right`  
 Regex source to copy.  
  
 `ptr`  
 Pointer to beginning of sequence to copy.  
  
 `flags`  
 Syntax option flags to add while copying.  
  
 `len/TD>`  
 Length of sequence to copy.  
  
 `str`  
 String to copy.  
  
 `first`  
 Beginning of sequence to copy.  
  
 `last`  
 End of sequence to copy.  
  
 `IList`  
 The initializer_list to copy.  
  
## Remarks  
 All constructors store a default-constructed object of type `RXtraits`.  
  
 The first constructor constructs an empty `basic_regex` object. The other constructors construct a `basic_regex` object that holds the regular expression described by the operand sequence.  
  
 An empty `basic_regex` object does not match any character sequence when passed to [regex_match](../vs140/regex_match-function.md), [regex_search](../vs140/regex_search-function.md), or [regex_replace](../vs140/regex_replace-function.md).  
  
## Example  
  
```  
// std_tr1__regex__basic_regex_construct.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
using namespace std;  
  
int main()  
{  
    regex::value_type elem = 'x';  
    regex::flag_type flag = regex::grep;  
  
    elem = elem;  // to quiet "unused" warnings   
    flag = flag;  
  
    // constructors   
    regex rx0;  
    cout << "match(\"abc\", \"\") == " << boolalpha  
        << regex_match("abc", rx0) << endl;  
  
    regex rx1("abcd", regex::ECMAScript);  
    cout << "match(\"abc\", \"abcd\") == " << boolalpha  
        << regex_match("abc", rx1) << endl;  
  
    regex rx2("abcd", 3);  
    cout << "match(\"abc\", \"abc\") == " << boolalpha  
        << regex_match("abc", rx2) << endl;  
  
    regex rx3(rx2);  
    cout << "match(\"abc\", \"abc\") == " << boolalpha  
        << regex_match("abc", rx3) << endl;  
  
    string str("abcd");  
    regex rx4(str);  
    cout << "match(string(\"abcd\"), \"abc\") == " << boolalpha  
        << regex_match("abc", rx4) << endl;  
  
    regex rx5(str.begin(), str.end() - 1);  
    cout << "match(string(\"abc\"), \"abc\") == " << boolalpha  
        << regex_match("abc", rx5) << endl;  
    cout << endl;  
  
    // assignments   
    rx0 = "abc";  
    rx0 = rx1;  
    rx0 = str;  
  
    rx0.assign("abcd", regex::ECMAScript);  
    rx0.assign("abcd", 3);  
    rx0.assign(rx1);  
    rx0.assign(str);  
    rx0.assign(str.begin(), str.end() - 1);  
  
    rx0.swap(rx1);  
  
    // mark_count   
    cout << "\"abc\" mark_count == "  
        << regex("abc").mark_count() << endl;  
    cout << "\"(abc)\" mark_count == "  
        << regex("(abc)").mark_count() << endl;  
  
    // locales   
    regex::locale_type loc = rx0.imbue(locale());  
    cout << "getloc == imbued == " << boolalpha  
        << (loc == rx0.getloc()) << endl;  
  
    // initializer_list  
    regex rx6{ { 'a', 'b', 'c' } };  
    cout << "match(\"abc\", \"abc\") == " << boolalpha  
        << regex_match("abc", rx6);  
    cout << endl;  
}  
  
```  
  
 **match("abc", "") == falsematch("abc", "abcd") == falsematch("abc", "abc") == truematch("abc", "abc") == truematch(string("abcd"), "abc") == falsematch(string("abc"), "abc") == true"abc" mark_count == 0"(abc)" mark_count == 1getloc == imbued == truematch("abc", "abc") == true**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [basic_regex](../vs140/basic_regex-class.md)