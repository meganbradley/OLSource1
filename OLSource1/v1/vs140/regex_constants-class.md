---
title: "regex_constants Class"
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
  - "std::tr1::regex_constants"
  - "std.tr1.regex_constants"
  - "regex_constants"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_constants class [TR1]"
ms.assetid: 4a69c0ba-c46d-46e4-bd29-6f4efb805f26
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# regex_constants Class
Namespace for regular expression flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The namespace <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> encapsulates several flag types and their associated flag values.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
##  \<a name="regex_constants__error_type">\</a>  regex_constants::error_type  
 Flags for reporting regular expression syntax errors.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is an enumerated type that describes an object that can hold error flags. The distinct flag values are:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> -- the expression contained an invalid count in a { } expression  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> -- a repeat expression (one of '*', '?', '+', '{' in most contexts) was not preceded by an expression  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> -- the expression contained an unmatched '{' or '}'  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> -- the expression contained an unmatched '[' or ']'  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> -- the expression contained an invalid collating element name  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> -- an attempted match failed because it was too complex  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> -- the expression contained an invalid character class name  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> -- the expression contained an invalid escape sequence  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> -- the expression contained an unmatched '(' or ')'  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> -- the expression contained an invalid character range specifier  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> -- parsing a regular expression failed because there were not enough resources available  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> -- an attempted match failed because there was not enough memory available  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> -- the expression contained an invalid back reference  
  
##  \<a name="regex_constants__match_flag_type">\</a>  regex_constants::match_flag_type  
 Flags for regular expression matching options.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The type is a bitmask type that describes options to be used when matching a text sequence against a regular expression and format flags to be used when replacing text. Options can be combined with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The match options are:  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> -- do not treat the first position in the target sequence as the beginning of a line  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> -- do not treat the past-the-end position in the target sequence as the end of a line  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> -- do not treat the first position in the target sequence as the beginning of a word  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> -- do not treat the past-the-end position in the target sequence as the end of a word  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> -- if more than one match is possible any match is acceptable  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> -- do not treat an empty subsequence as a match  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> -- do not search for matches other than at the beginning of the target sequence  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> -- <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a valid iterator; ignore <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if set  
  
 The format flags are:  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> -- use ECMAScript format rules  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> -- use sed format rules  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> -- do not copy text that does not match the regular expression  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> -- do not search for matches after the first one  
  
##  \<a name="regex_constants__syntax_option_type">\</a>  regex_constants::syntax_option_type  
 Flags for selecting syntax options.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a bitmask type that describes language specifiers and syntax modifiers to be used when compiling a regular expression. Options can be combined with <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. No more than one language specifier should be used at a time.  
  
 The language specifiers are:  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> -- compile as BRE  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> -- compile as ERE  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> -- compile as ECMAScript  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> -- compile as awk  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> -- compile as grep  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> -- compile as egrep  
  
 The syntax modifiers are:  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> -- make matches case-insensitive  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> -- the implementaton need not keep track of the contents of capture groups  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> -- the implementation should emphasize speed of matching rather than speed of regular expression compilation  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> -- make matches locale-sensitive  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_constants](../vs140/regex_constants-class.md)