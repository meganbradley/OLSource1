---
title: "basic_regex::assign"
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
  - "std::tr1::basic_regex::assign"
  - "basic_regex.assign"
  - "std.tr1.basic_regex.assign"
  - "basic_regex::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method [TR1]"
ms.assetid: d20a067a-aaec-4a3b-827d-88ecdd4d531b
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_regex::assign
Assigns a value to the regular expressoin object.  
  
## Syntax  
  
```  
basic_regex& assign(  
    const basic_regex& right  
);  
basic_regex& assign(  
    const Elem* ptr,  
    flag_type flags = ECMAScript  
);  
basic_regex& assign(  
    const Elem* ptr,   
    size_type len,  
    flag_type flags = ECMAScript  
);  
basic_regex& assign(  
    initializer_list<_Elem> IList,  
    flag_type flags = regex_constants::ECMAScript  
);  
template<class STtraits, class STalloc>  
    basic_regex& assign(  
        const basic_string<Elem, STtraits, STalloc>& str,  
        flag_type flags = ECMAScript  
    );  
template<class InIt>  
    basic_regex& assign(  
        InIt first,         InIt last,  
        flag_type flags = ECMAScript  
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
 The member functions each replace the regular expression held by `*this` with the regular expression described by the operand sequence, then return `*this`.  
  
## Example  
  
```  
// std_tr1__regex__basic_regex_assign.cpp   
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
    regex rx6({ 'a', 'b', 'c' }, regex::ECMAScript);  
    cout << "match(\"abc\") == " << boolalpha  
        << regex_match("abc", rx6);  
    cout << endl;   
}  
  
```  
  
 **match("abc", "") == falsematch("abc", "abcd") == falsematch("abc", "abc") == truematch("abc", "abc") == truematch(string("abcd"), "abc") == falsematch(string("abc"), "abc") == true"abc" mark_count == 0"(abc)" mark_count == 1getloc == imbued == truematch("abc") == true**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [basic_regex](../vs140/basic_regex-class.md)   
 [basic_regex::operator_as](../vs140/basic_regex--operator=.md)