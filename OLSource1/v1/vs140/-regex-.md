---
title: "&lt;regex&gt;"
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
  - "<regex>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex header [TR1]"
ms.assetid: 5dd4ef74-6063-4dbc-b692-1960bb736f0b
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;regex&gt;
Defines a template class to parse [regular expressions](../vs140/regular-expressions--c---.md), and several template classes and functions to search text for matches to a regular expression object.  
  
## Syntax  
  
```  
#include <regex>  
```  
  
## Remarks  
 To create a regular expression object, use the template class [basic_regex](../vs140/basic_regex-class.md) or one of its specializations, [regex](../vs140/-regex--typedefs.md#regex_typedef) and [wregex](../vs140/-regex--typedefs.md#wregex_typedef), together with the syntax flags of type [syntax_option_type](../vs140/regex_constants-class.md#regex_constants__syntax_option_type).  
  
 To search text for matches to a regular expression object, use the template functions [regex_match](../vs140/-regex--functions.md#regex_match_function) and [regex_search](../vs140/-regex--functions.md#regex_search_function), together with the match flags of type [match_flag_type](../vs140/regex_constants-class.md#regex_constants__match_flag_type). These functions return results by using the template class [match_results](../vs140/match_results-class.md) and its specializations, [cmatch](../vs140/-regex--typedefs.md#cmatch_typedef), [wcmatch](../vs140/-regex--typedefs.md#wcmatch_typedef), [smatch](../vs140/-regex--typedefs.md#smatch_typedef), and [wsmatch](../vs140/-regex--typedefs.md#wsmatch_typedef), together with the template class [sub_match](../vs140/sub_match-class.md) and its specializations, [csub_match](../vs140/-regex--typedefs.md#csub_match_typedef), [wcsub_match](../vs140/-regex--typedefs.md#wcsub_match_typedef), [ssub_match](../vs140/-regex--typedefs.md#ssub_match_typedef), and [wssub_match](../vs140/-regex--typedefs.md#wssub_match_typedef).  
  
 To replace text that matches a regular expression object, use the template function [regex_replace](../vs140/-regex--functions.md#regex_replace_function), together with the match flags of type [match_flag_type](../vs140/regex_constants-class.md#regex_constants__match_flag_type).  
  
 To iterate through multiple matches of a regular expression object, use the template classes [regex_iterator](../vs140/regex_iterator-class.md) and [regex_token_iterator](../vs140/regex_token_iterator-class.md) or one of their specializations, [cregex_iterator](../vs140/-regex--typedefs.md#cregex_iterator_typedef), [sregex_iterator](../vs140/-regex--typedefs.md#sregex_iterator_typedef), [wcregex_iterator](../vs140/-regex--typedefs.md#wcregex_iterator_typedef), [wsregex_iterator](../vs140/-regex--typedefs.md#wsregex_iterator_typedef), [cregex_token_iterator](../vs140/-regex--typedefs.md#cregex_token_iterator_typedef), [sregex_token_iterator](../vs140/-regex--typedefs.md#sregex_token_iterator_typedef), [wcregex_token_iterator](../vs140/-regex--typedefs.md#wcregex_token_iterator_typedef), or [wsregex_token_iterator](../vs140/-regex--typedefs.md#wsregex_token_iterator_typedef), together with the match flags of type [match_flag_type](../vs140/regex_constants-class.md#regex_constants__match_flag_type).  
  
 To modify the details of the grammar of regular expressions, write a class that implements the regular expression traits.  
  
### Classes  
  
|||  
|-|-|  
|[basic_regex](../vs140/basic_regex-class.md)|Wraps a regular expression.|  
|[match_results](../vs140/match_results-class.md)|Holds a sequence of submatches.|  
|[regex_constants](../vs140/regex_constants-class.md)|Holds assorted constants.|  
|[regex_error](../vs140/regex_error-class.md)|Reports a bad regular expression.|  
|[regex_iterator](../vs140/regex_iterator-class.md)|Iterates through match results.|  
|[regex_traits](../vs140/regex_traits-class.md)|Describes characteristics of elements for matching.|  
|[regex_traits<char\>](../vs140/regex_traits-char--class.md)|Describes characteristics of `char` for matching.|  
|[regex_traits<wchar_t>](../vs140/regex_traits-wchar_t--class.md)|Describes characteristics of `wchar_t` for matching.|  
|[regex_token_iterator](../vs140/regex_token_iterator-class.md)|Iterates through submatches.|  
|[sub_match](../vs140/sub_match-class.md)|Describes a submatch.|  
  
### Type Definitions  
  
|||  
|-|-|  
|[cmatch](../vs140/-regex--typedefs.md#cmatch_typedef)|Type definition for `char``match_results`.|  
|[cregex_iterator](../vs140/-regex--typedefs.md#cregex_iterator_typedef)|Type definition for `char``regex_iterator`.|  
|[cregex_token_iterator](../vs140/-regex--typedefs.md#cregex_token_iterator_typedef)|Type definition for `char``regex_token_iterator`.|  
|[csub_match](../vs140/-regex--typedefs.md#csub_match_typedef)|Type definition for `char``sub_match`.|  
|[regex](../vs140/-regex--typedefs.md#regex_typedef)|Type definition for `char``basic_regex`.|  
|[smatch](../vs140/-regex--typedefs.md#smatch_typedef)|Type definition for `string``match_results`.|  
|[sregex_iterator](../vs140/-regex--typedefs.md#sregex_iterator_typedef)|Type definition for `string``regex_iterator`.|  
|[sregex_token_iterator](../vs140/-regex--typedefs.md#sregex_token_iterator_typedef)|Type definition for `string``regex_token_iterator`.|  
|[ssub_match](../vs140/-regex--typedefs.md#ssub_match_typedef)|Type definition for `string``sub_match`.|  
|[wcmatch](../vs140/-regex--typedefs.md#wcmatch_typedef)|Type definition for `wchar_t``match_results`.|  
|[wcregex_iterator](../vs140/-regex--typedefs.md#wcregex_iterator_typedef)|Type definition for `wchar_t``regex_iterator`.|  
|[wcregex_token_iterator](../vs140/-regex--typedefs.md#wcregex_token_iterator_typedef)|Type definition for `wchar_t``regex_token_iterator`.|  
|[wcsub_match](../vs140/-regex--typedefs.md#wcsub_match_typedef)|Type definition for `wchar_t``sub_match`.|  
|[wregex](../vs140/-regex--typedefs.md#wregex_typedef)|Type definition for `wchar_t``basic_regex`.|  
|[wsmatch](../vs140/-regex--typedefs.md#wsmatch_typedef)|Type definition for `wstring``match_results`.|  
|[wsregex_iterator](../vs140/-regex--typedefs.md#wsregex_iterator_typedef)|Type definition for `wstring``regex_iterator`.|  
|[wsregex_token_iterator](../vs140/-regex--typedefs.md#wsregex_token_iterator_typedef)|Type definition for `wstring``regex_token_iterator`.|  
|[wssub_match](../vs140/-regex--typedefs.md#wssub_match_typedef)|Type definition for `wstring``sub_match`.|  
  
### Functions  
  
|||  
|-|-|  
|[regex_match](../vs140/-regex--functions.md#regex_match_function)|Exactly matches a regular expression.|  
|[regex_replace](../vs140/-regex--functions.md#regex_replace_function)|Replaces matched regular expressions.|  
|[regex_search](../vs140/-regex--functions.md#regex_search_function)|Searches for a regular expression match.|  
|[swap](../vs140/-regex--functions.md#swap_function)|Swaps `basic_regex` or `match_results` objects.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](../vs140/-regex--operators.md#operator_eq_eq)|Comparison of various objects, equal.|  
|[operator!=](../vs140/-regex--operators.md#operator_neq)|Comparison of various objects, not equal.|  
|[operator<](../vs140/-regex--operators.md#operator_lt_)|Comparison of various objects, less than.|  
|[operator<=](../vs140/-regex--operators.md#operator_lt__eq)|Comparison of various objects, less than or equal.|  
|[operator>](../vs140/-regex--operators.md#operator_gt_)|Comparison of various objects, greater than.|  
|[operator>=](../vs140/-regex--operators.md#operator_gt__eq)|Comparison of various objects, greater than or equal.|  
|[operator<<](../vs140/-regex--operators.md#operator_lt__lt_)|Inserts a `sub_match` in a stream.|  
  
## See Also  
 [Regular Expressions](../vs140/regular-expressions--c---.md)