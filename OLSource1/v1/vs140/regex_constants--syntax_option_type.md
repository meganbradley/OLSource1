---
title: "regex_constants::syntax_option_type"
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
  - "regex_constants::syntax_option_type"
  - "std::tr1::regex_constants::syntax_option_type"
  - "std.tr1.regex_constants.syntax_option_type"
  - "syntax_option_type"
  - "regex_constants.syntax_option_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "syntax_option_type method [TR1]"
ms.assetid: 78e823d0-715e-40cb-b2a5-96ebd4c48492
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_constants::syntax_option_type
Flags for selecting syntax options.  
  
## Syntax  
  
```  
typedef T1 syntax_option_type;  
static const syntax_option_type awk, basic, collate, ECMAScript,  
  egrep, extended, grep, icase, nosubs, optimize;  
```  
  
## Remarks  
 The type is a bitmask type that describes language specifiers and syntax modifiers to be used when compiling a regular expression. Options can be combined with `|`. No more than one language specifier should be used at a time.  
  
 The language specifiers are:  
  
 `basic` -- compile as BRE  
  
 `extended` -- compile as ERE  
  
 `ECMAScript` -- compile as ECMAScript  
  
 `awk` -- compile as awk  
  
 `grep` -- compile as grep  
  
 `egrep` -- compile as egrep  
  
 The syntax modifiers are:  
  
 `icase` -- make matches case-insensitive  
  
 `nosubs` -- the implementaton need not keep track of the contents of capture groups  
  
 `optimize` -- the implementation should emphasize speed of matching rather than speed of regular expression compilation  
  
 `collate` -- make matches locale-sensitive  
  
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_constants](../vs140/regex_constants-class.md)