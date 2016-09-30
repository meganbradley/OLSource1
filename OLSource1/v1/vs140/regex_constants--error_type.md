---
title: "regex_constants::error_type"
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
  - "std.tr1.regex_constants.error_type"
  - "error_type"
  - "std::tr1::regex_constants::error_type"
  - "regex_constants.error_type"
  - "regex_constants::error_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "error_type method [TR1]"
ms.assetid: c5cd33f3-dafe-4e48-ad82-a0c3643f92ef
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_constants::error_type
Flags for reporting regular expression syntax errors.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is an enumerated type that describes an object that can hold error flags. The distinct flag values are:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> -- the expression contained an invalid count in a { } expression  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> -- a repeat expression (one of '*', '?', '+', '{' in most contexts) was not preceded by an expression  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> -- the expression contained an unmatched '{' or '}'  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> -- the expression contained an unmatched '[' or ']'  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> -- the expression contained an invalid collating element name  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> -- an attempted match failed because it was too complex  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> -- the expression contained an invalid character class name  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> -- the expression contained an invalid escape sequence  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> -- the expression contained an unmatched '(' or ')'  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> -- the expression contained an invalid character range specifier  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> -- parsing a regular expression failed because there were not enough resources available  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> -- an attempted match failed because there was not enough memory available  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> -- the expression contained an invalid back reference  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_constants](../vs140/regex_constants-class.md)