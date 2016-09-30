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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator type for submatches.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The match results allocator class.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of elements to match.  
  
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
 The match results.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Pointer to beginning of sequence to match.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The regular expression to match.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 String to match.  
  
## Remarks  
 Each template function returns true only if a search for its regular expression argument <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in its operand sequence succeeds. The functions that take a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object set its members to reflect whether the search succeeded and if so what the various capture groups in the regular expression captured.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
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