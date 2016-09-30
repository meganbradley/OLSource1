---
title: "sub_match Class"
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
  - "sub_match"
  - "std::tr1::sub_match"
  - "std.tr1.sub_match"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sub_match class [TR1]"
ms.assetid: 804e2b9e-d16a-4c4c-ac60-024e0b2dd0e8
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# sub_match Class
Describes a submatch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The iterator type for submatches.  
  
## Remarks  
 The template class describes an object that designates a sequence of characters that matched a capture group in a call to [regex_match](../vs140/-regex--functions.md#regex_match_function) or to [regex_search](../vs140/-regex--functions.md#regex_search_function). Objects of type [match_results](../vs140/match_results-class.md) hold an array of these objects, one for each capture group in the regular expression that was used in the search.  
  
 If the capture group was not matched the object's data member <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> holds false, and the two iterators <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (inherited from the base <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) are equal. If the capture group was matched, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> holds true, the iterator <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> points to the first character in the target sequence that matched the capture group, and the iterator <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> points one position past the last character in the target sequence that matched the capture group. Note that for a zero-length match the member <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> holds true, the two iterators will be equal, and both will point to the position of the match.  
  
 A zero-length match can occur when a capture group consists solely of an assertion, or of a repetition that allows zero repeats. For example:  
  
 "^" matches the target sequence "a"; the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object corresponding to capture group 0 holds iterators that both point to the first character in the sequence.  
  
 "b(a*)b" matches the target sequence "bb"; the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object corresponding to capture group 1 holds iterators that both point to the second character in the sequence.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
##  \<a name="sub_match__compare">\</a>  sub_match::compare  
 Compare submatch against a sequence.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The submatch to compare to.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The string to compare to.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The nul-terminated sequence to compare to.  
  
### Remarks  
 The first member function compares the matched sequence <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to the matched sequence <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. The second member function compares the matched sequence <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to the character sequence <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The third member function compares the matched sequence <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to the character sequence <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 Each function returns:  
  
 a negative value if the first differing value in the matched sequence compares less than the corresponding element in the operand sequence (as determined by <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>), or if the two have a common prefix but the target sequence is longer  
  
 zero if the two compare equal element by element and have the same length  
  
 a positive value otherwise  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
##  \<a name="sub_match__difference_type">\</a>  sub_match::difference_type  
 The type of an iterator difference.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
##  \<a name="sub_match__iterator">\</a>  sub_match::iterator  
 The type of an iterator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for the template type argument <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
##  \<a name="sub_match__length">\</a>  sub_match::length  
 Returns the length of a submatch.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the matched sequence, or zero if there was no matched sequence.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
##  \<a name="sub_match__matched">\</a>  sub_match::matched  
 Indicates if match succeeded.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The member holds <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> only if the capture group associated with <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> was part of the regular expression match.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
##  \<a name="sub_match__operator_basic_string_lt_value_type_gt_">\</a>  sub_match::operator basic_string&lt;value_type&gt;  
 Casts submatch to a string.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
##  \<a name="sub_match__str">\</a>  sub_match::str  
 Converts submatch to a string.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
##  \<a name="sub_match__value_type">\</a>  sub_match::value_type  
 The type of an element.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**    
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [sub_match](../vs140/sub_match-class.md)   
 [regex_match](../vs140/-regex--functions.md#regex_match_function)   
 [regex_search](../vs140/-regex--functions.md#regex_search_function)