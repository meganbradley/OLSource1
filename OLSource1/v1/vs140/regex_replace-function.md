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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator type for replacements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The iterator type for submatches.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The regular expression allocator class.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of elements to match.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Flags for matches.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The format for replacements.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The output iterator.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The regular expression to match.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 String to match.  
  
## Remarks  
 The first function constructs a [regex_iterator](../vs140/regex_iterator-class.md) object <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and uses it to split its input range <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> into a series of subsequences <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> match detected by the iterator. If no matches are found, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is the entire input range and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is zero. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> only the first match is used, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is all of the input text that follows the match, and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is 1. For each <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> it copies the text in the range <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to the iterator <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. It then calls <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object returned by the iterator object <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> for the subsequence <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. Finally, if <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> it copies the text in the range <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to the iterator <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The function returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 The second function constructs a local variable <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. It returns <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
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