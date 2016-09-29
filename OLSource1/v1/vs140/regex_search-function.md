---
title: "regex_search Function"
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
  - "regex_search"
  - "std::tr1::regex_search"
  - "std.tr1.regex_search"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_search function [TR1]"
ms.assetid: 5359b8cf-e2a0-43f1-88b3-9487fed11a9a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# regex_search Function
Searches for a regular expression match.  
  
## Syntax  
  
```  
template<class BidIt, class Alloc, class Elem, class RXtraits, class Alloc2>  
    bool regex_search(BidIt first, Bidit last,  
        match_results<BidIt, Alloc>& match,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
template<class BidIt, class Elem, class RXtraits, class Alloc2>  
    bool regex_search(BidIt first, Bidit last,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
template<class Elem, class Alloc, class RXtraits, class Alloc2>  
    bool regex_search(const Elem* ptr,  
        match_results<const Elem*, Alloc>& match,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
template<class Elem, class RXtraits, class Alloc2>  
    bool regex_search(const Elem* ptr,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
template<class IOtraits, class IOalloc, class Alloc, class Elem, class RXtraits, class Alloc2>  
    bool regex_search(const basic_string<Elem, IOtraits, IOalloc>& str,  
        match_results<typename basic_string<Elem, IOtraits, IOalloc>::const_iterator, Alloc>& match,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
template<class IOtraits, class IOalloc, class Elem, class RXtraits, class Alloc2>  
    bool regex_search(const basic_string<Elem, IOtraits, IOalloc>& str,  
        const basic_regex<Elem, RXtraits, Alloc2>& re,  
        match_flag_type flags = match_default);  
```  
  
#### Parameters  
 `BidIt`  
 The iterator type for submatches.  
  
 `Alloc`  
 The match results allocator class.  
  
 `Elem`  
 The type of elements to match.  
  
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
 The match results.  
  
 `ptr`  
 Pointer to beginning of sequence to match.  
  
 `re`  
 The regular expression to match.  
  
 `str`  
 String to match.  
  
## Remarks  
 Each template function returns true only if a search for its regular expression argument `re` in its operand sequence succeeds. The functions that take a `match_results` object set its members to reflect whether the search succeeded and if so what the various capture groups in the regular expression captured.  
  
## Example  
  
```  
// std_tr1__regex__regex_search.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    const char *first = "abcd";   
    const char *last = first + strlen(first);   
    std::cmatch mr;   
    std::regex rx("abc");   
    std::regex_constants::match_flag_type fl =   
        std::regex_constants::match_default;   
  
    std::cout << "search(f, f+1, \"abc\") == " << std::boolalpha   
        << regex_search(first, first + 1, rx, fl) << std::endl;   
  
    std::cout << "search(f, l, \"abc\") == " << std::boolalpha   
        << regex_search(first, last, mr, rx) << std::endl;   
    std::cout << "  matched: \"" << mr.str() << "\"" << std::endl;   
  
    std::cout << "search(\"a\", \"abc\") == " << std::boolalpha   
        << regex_search("a", rx) << std::endl;   
  
    std::cout << "search(\"xabcd\", \"abc\") == " << std::boolalpha   
        << regex_search("xabcd", mr, rx) << std::endl;   
    std::cout << "  matched: \"" << mr.str() << "\"" << std::endl;   
  
    std::cout << "search(string, \"abc\") == " << std::boolalpha   
        << regex_search(std::string("a"), rx) << std::endl;   
  
    std::string str("abcabc");   
    std::match_results<std::string::const_iterator> mr2;   
    std::cout << "search(string, \"abc\") == " << std::boolalpha   
        << regex_search(str, mr2, rx) << std::endl;   
    std::cout << "  matched: \"" << mr2.str() << "\"" << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **search(f, f+1, "abc") == false**  
**search(f, l, "abc") == true**  
 **matched: "abc"**  
**search("a", "abc") == false**  
**search("xabcd", "abc") == true**  
 **matched: "abc"**  
**search(string, "abc") == false**  
**search(string, "abc") == true**  
 **matched: "abc"**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_match](../vs140/regex_match-function.md)   
 [regex_replace](../vs140/regex_replace-function.md)