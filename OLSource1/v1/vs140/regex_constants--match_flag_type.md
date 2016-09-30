---
title: "regex_constants::match_flag_type"
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
  - "regex_constants::match_flag_type"
  - "match_flag_type"
  - "std.tr1.regex_constants.match_flag_type"
  - "regex_constants.match_flag_type"
  - "std::tr1::regex_constants::match_flag_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "match_flag_type method [TR1]"
ms.assetid: ad8b9ff9-2cba-4292-b8b2-994504373879
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_constants::match_flag_type
Flags for regular expression matching options.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a bitmask type that describes options to be used when matching a text sequence against a regular expression and format flags to be used when replacing text. Options can be combined with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 The match options are:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> -- do not treat the first position in the target sequence as the beginning of a line  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> -- do not treat the past-the-end position in the target sequence as the end of a line  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> -- do not treat the first position in the target sequence as the beginning of a word  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> -- do not treat the past-the-end position in the target sequence as the end of a word  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> -- if more than one match is possible any match is acceptable  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> -- do not treat an empty subsequence as a match  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> -- do not search for matches other than at the beginning of the target sequence  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> -- <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a valid iterator; ignore <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if set  
  
 The format flags are:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> -- use ECMAScript format rules  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> -- use sed format rules  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> -- do not copy text that does not match the regular expression  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> -- do not search for matches after the first one  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_constants](../vs140/regex_constants-class.md)