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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator type for submatches. For common cases this one of string::const_iterator, wstring::const_iterator, const char* or const wchar_t\*.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The match results allocator class.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of elements to match. For common cases this is string, wstring, char* or wchar_t\*.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The regular expression allocator class.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The string allocator class.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Flags for matches.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The match results. Corresponds to Elem type: [smatch](../vs140/smatch-typedef.md) for string, [wsmatch](../vs140/wsmatch-typedef.md) for wstring, [cmatch](../vs140/cmatch-typedef.md) for char* or [wcmatch](../vs140/wcmatch-typedef.md) for wchar_t\*.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Pointer to beginning of sequence to match. If ptr is char*, then use cmatch and regex. If ptr is wchar_t\* then use wcmatch and wregex.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The regular expression to match. Type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for string and char*, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for wstring and wchar_t\*.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 String to match. Corresponds to the type of Elem.  
  
## Remarks  
 Each template function returns true only if the entire operand sequence <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> exactly matches the regular expression argument <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Use [regex_search](../vs140/regex_search-function.md) to match a substring within a target sequence and regex_iterator to find multiple matches. The functions that take a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object set its members to reflect whether the match succeeded and if so what the various capture groups in the regular expression captured.  
  
 The functions that take a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object set its members to reflect whether the match succeeded and if so what the various capture groups in the regular expression captured.  
  
 **(1):**  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_replace](../vs140/regex_replace-function.md)   
 [regex_search](../vs140/regex_search-function.md)