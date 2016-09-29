---
title: "regex_match Function"
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
  - "std.tr1.regex_match"
  - "std::tr1::regex_match"
  - "regex_match"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_match function [TR1]"
ms.assetid: bf286056-bdaf-4dec-b285-a4d28935f57a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# regex_match Function
Tests whether a regular expression matches the entire target string.  
  
## Syntax  
  
```  
  
// (1)   
template<class BidIt, class Alloc, class Elem, class RXtraits, class Alloc2>  
    bool regex_match(BidIt first, Bidit last,  
        match_results<BidIt, Alloc>& match,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,   
        match_flag_type flags = match_default);  
  
// (2)   
template<class BidIt, class Elem, class RXtraits, class Alloc2>  
    bool regex_match(BidIt first, Bidit last,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
  
// (3)  
template<class Elem, class Alloc, class RXtraits, class Alloc2>  
    bool regex_match(const Elem *ptr,  
        match_results<const Elem*, Alloc>& match,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
  
// (4)   
template<class Elem, class RXtraits, class Alloc2>  
    bool regex_match(const Elem *ptr,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
  
// (5)  
template<class IOtraits, class IOalloc, class Alloc, class Elem, class RXtraits, class Alloc2>  
    bool regex_match(const basic_string<Elem, IOtraits, IOalloc>& str,  
        match_results<typename basic_string<Elem, IOtraits, IOalloc>::const_iterator, Alloc>& match,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
  
// (6)  
template<class IOtraits, class IOalloc, class Elem, class RXtraits, class Alloc2>  
    bool regex_match(const basic_string<Elem, IOtraits, IOalloc>& str,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
```  
  
#### Parameters  
 `BidIt`  
 The iterator type for submatches. For common cases this one of string::const_iterator, wstring::const_iterator, const char* or const wchar_t\*.  
  
 `Alloc`  
 The match results allocator class.  
  
 `Elem`  
 The type of elements to match. For common cases this is string, wstring, char* or wchar_t\*.  
  
 `RXtraits`  
 Traits class for elements.  
  
 `Alloc2`  
 The regular expression allocator class.  
  
 `IOtraits`  
 The string traits class.  
  
 `IOalloc`  
 The string allocator class.  
  
 `flags`  
 Flags for matches.  
  
 `first`  
 Beginning of sequence to match.  
  
 `last`  
 End of sequence to match.  
  
 `match`  
 The match results. Corresponds to Elem type: [smatch](../vs140/smatch-typedef.md) for string, [wsmatch](../vs140/wsmatch-typedef.md) for wstring, [cmatch](../vs140/cmatch-typedef.md) for char* or [wcmatch](../vs140/wcmatch-typedef.md) for wchar_t\*.  
  
 `ptr`  
 Pointer to beginning of sequence to match. If ptr is char*, then use cmatch and regex. If ptr is wchar_t\* then use wcmatch and wregex.  
  
 `re`  
 The regular expression to match. Type `regex` for string and char*, or `wregex` for wstring and wchar_t\*.  
  
 `str`  
 String to match. Corresponds to the type of Elem.  
  
## Remarks  
 Each template function returns true only if the entire operand sequence `str` exactly matches the regular expression argument `re`. Use [regex_search](../vs140/regex_search-function.md) to match a substring within a target sequence and regex_iterator to find multiple matches. The functions that take a `match_results` object set its members to reflect whether the match succeeded and if so what the various capture groups in the regular expression captured.  
  
 The functions that take a `match_results` object set its members to reflect whether the match succeeded and if so what the various capture groups in the regular expression captured.  
  
 **(1):**  
  
## Example  
  
```  
// RegexTestBed.cpp : Defines the entry point for the console application.  
//  
  
#include "stdafx.h"  
#include <regex>   
#include <iostream>   
  
using namespace std;  
  
int _tmain(int argc, _TCHAR* argv[])  
{  
  
    // (1) with char*  
    // Note how const char* requires cmatch and regex  
    const char *first = "abc";  
    const char *last = first + strlen(first);  
    cmatch narrowMatch;  
    regex rx("a(b?)c");  
  
    bool found = regex_match(first, last, narrowMatch, rx);  
  
    // (1) with std::wstring  
    // Note how wstring requires wsmatch and wregex.  
    // Note use of const iterators cbegin() and cend().  
    wstring target(L"Hello");  
    wsmatch wideMatch;  
    wregex wrx(L"He(l+)o");  
  
    if (regex_match(target.cbegin(), target.cend(), wideMatch, wrx))  
        wcout << L"The matching text is:" << wideMatch.str() << endl;   
  
    // (2) with std::string  
    string target2("Drizzle");  
    regex rx2(R"(D\w+e)"); // no double backslashes with raw string literal  
    found = regex_match(target2.cbegin(), target2.cend(), rx2);  
  
    // (3) with wchar_t*  
    const wchar_t* target3 = L"2014-04-02";  
    wcmatch wideMatch2;  
  
    // LR"(...)" is a  raw wide-string literal. Open and close parens  
    // are delimiters, not string elements.  
    wregex wrx2(LR"(\d{4}(-|/)\d{2}(-|/)\d{2})");   
    if (regex_match(target3, wideMatch2, wrx2))  
    {  
        wcout << L"Matching text: " << wideMatch2.str() << endl;  
    }  
  
     return 0;  
}  
  
```  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_replace](../vs140/regex_replace-function.md)   
 [regex_search](../vs140/regex_search-function.md)