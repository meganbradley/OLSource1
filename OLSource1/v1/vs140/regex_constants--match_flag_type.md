---
title: "regex_constants::match_flag_type"
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
  - regex_constants::match_flag_type
  - match_flag_type
  - std.tr1.regex_constants.match_flag_type
  - regex_constants.match_flag_type
  - std::tr1::regex_constants::match_flag_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - match_flag_type method [TR1]
ms.assetid: ad8b9ff9-2cba-4292-b8b2-994504373879
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# regex_constants::match_flag_type
Flags for regular expression matching options.  
  
## Syntax  
  
```  
typedef T2 match_flag_type;  
static const match_flag_type match_any, match_default, match_not_bol,  
  match_not_bow, match_continuous, match_not_eol, match_not_eow,  
  match_not_null, match_partial, match_prev_avail;  
```  
  
## Remarks  
 The type is a bitmask type that describes options to be used when matching a text sequence against a regular expression and format flags to be used when replacing text. Options can be combined with `|`.  
  
 The match options are:  
  
 `match_default`  
  
 `match_not_bol` -- do not treat the first position in the target sequence as the beginning of a line  
  
 `match_not_eol` -- do not treat the past-the-end position in the target sequence as the end of a line  
  
 `match_not_bow` -- do not treat the first position in the target sequence as the beginning of a word  
  
 `match_not_eow` -- do not treat the past-the-end position in the target sequence as the end of a word  
  
 `match_any` -- if more than one match is possible any match is acceptable  
  
 `match_not_null` -- do not treat an empty subsequence as a match  
  
 `match_continuous` -- do not search for matches other than at the beginning of the target sequence  
  
 `match_prev_avail` -- `--first` is a valid iterator; ignore `match_not_bol` and `match_not_bow` if set  
  
 The format flags are:  
  
 `format_default` -- use ECMAScript format rules  
  
 `format_sed` -- use sed format rules  
  
 `format_no_copy` -- do not copy text that does not match the regular expression  
  
 `format_first_only` -- do not search for matches after the first one  
  
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_constants](../vs140/regex_constants-class.md)