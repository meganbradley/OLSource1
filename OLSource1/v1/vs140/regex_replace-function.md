---
title: "regex_replace Function"
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
  - "std::tr1::regex_replace"
  - "regex_replace"
  - "std.tr1.regex_replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_replace function [TR1]"
ms.assetid: 4f85716c-3fe4-4cda-be3f-0a9448ae0e4e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# regex_replace Function
Replaces matched regular expressions.  
  
## Syntax  
  
```  
template<class OutIt, class BidIt, class RXtraits, class Alloc, class Elem>  
    OutIt regex_replace(OutIt out,  
        BidIt first, BidIt last,  
        const basic_regex<Elem, RXtraits, Alloc>& re,  
        const basic_string<Elem>& fmt,  
        match_flag_type flags = match_default);  
template<class RXtraits, class Alloc, class Elem>  
    basic_string<Elem> regex_replace(const basic_string<Elem>& str,  
        const basic_regex<Elem, RXtraits, Alloc>& re,  
        const basic_string<Elem>& fmt,  
        match_flag_type flags = match_default);  
```  
  
#### Parameters  
 `OutIt`  
 The iterator type for replacements.  
  
 `BidIt`  
 The iterator type for submatches.  
  
 `RXtraits`  
 Traits class for elements.  
  
 `Alloc`  
 The regular expression allocator class.  
  
 `Elem`  
 The type of elements to match.  
  
 `flags`  
 Flags for matches.  
  
 `first`  
 Beginning of sequence to match.  
  
 `fmt`  
 The format for replacements.  
  
 `last`  
 End of sequence to match.  
  
 `out`  
 The output iterator.  
  
 `re`  
 The regular expression to match.  
  
 `str`  
 String to match.  
  
## Remarks  
 The first function constructs a [regex_iterator](../vs140/regex_iterator-class.md) object `iter(first, last, re, flags)` and uses it to split its input range `[first, last)` into a series of subsequences `T0M0T1M1...TN-1MN-1TN`, where `Mn` is the `nth` match detected by the iterator. If no matches are found, `T0` is the entire input range and `N` is zero. If `(flags & format_first_only) != 0` only the first match is used, `T1` is all of the input text that follows the match, and `N` is 1. For each `i` in the range `[0, N)`, if `(flags & format_no_copy) == 0` it copies the text in the range `Ti` to the iterator `out`. It then calls `m.format(out, fmt, flags)`, where `m` is the `match_results` object returned by the iterator object `iter` for the subsequence `Mi`. Finally, if `(flags & format_no_copy) == 0` it copies the text in the range `TN` to the iterator `out`. The function returns `out`.  
  
 The second function constructs a local variable `result` of type `basic_string<charT>` and calls `regex_replace(back_inserter(result), str.begin(), str.end(), re, fmt, flags)`. It returns `result`.  
  
## Example  
  
```  
// std_tr1__regex__regex_replace.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    char buf[20];   
    const char *first = "axayaz";   
    const char *last = first + strlen(first);   
    std::regex rx("a");   
    std::string fmt("A");   
    std::regex_constants::match_flag_type fonly =   
        std::regex_constants::format_first_only;   
  
    *std::regex_replace(&buf[0], first, last, rx, fmt) = '\0';   
    std::cout << "replacement == " << &buf[0] << std::endl;   
  
    *std::regex_replace(&buf[0], first, last, rx, fmt, fonly) = '\0';   
    std::cout << "replacement == " << &buf[0] << std::endl;   
  
    std::string str("adaeaf");   
    std::cout << "replacement == "   
        << std::regex_replace(str, rx, fmt) << std::endl;   
  
    std::cout << "replacement == "   
        << std::regex_replace(str, rx, fmt, fonly) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **replacement == AxAyAz**  
**replacement == Axayaz**  
**replacement == AdAeAf**  
**replacement == Adaeaf**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_match](../vs140/regex_match-function.md)   
 [regex_search](../vs140/regex_search-function.md)