---
title: "regex_iterator Class"
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
  - "std::tr1::regex_iterator"
  - "std.tr1.regex_iterator"
  - "regex_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_iterator class [TR1]"
ms.assetid: 0cfd8fd0-5a95-4f3c-bf8e-6ef028c423d3
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_iterator Class
Iterator class for matches.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The iterator type for submatches.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The type of elements to match.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
## Remarks  
 The template class describes a constant forward iterator object. It extracts objects of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> by repeatedly applying its regular expression object <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to the character sequence defined by the iterator range <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Examples  
 See the following topics for examples on regular expressions:  
  
-   [regex_match Function](../vs140/-regex--functions.md#regex_match_function)  
  
-   [regex_replace Function](../vs140/-regex--functions.md#regex_replace_function)  
  
-   [regex_search Function](../vs140/-regex--functions.md#regex_search_function)  
  
-   [swap Function](../vs140/-regex--functions.md#swap_function)  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
##  \<a name="regex_iterator__difference_type">\</a>  regex_iterator::difference_type  
 The type of an iterator difference.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__iterator_category">\</a>  regex_iterator::iterator_category  
 The type of the iterator category.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__operator_neq">\</a>  regex_iterator::operator!=  
 Compares iterators for inequality.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The iterator to compare to.  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__operator_star">\</a>  regex_iterator::operator*  
 Accesses the designated match.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored value <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__operator_add_add">\</a>  regex_iterator::operator++  
 Increments the iterator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 If the current match has no characters the first operator calls <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>; otherwise it advances the stored value <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to point to the first character after the current match then calls <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. In either case, if the search fails the operator sets the object to an end-of-sequence iterator. The operator returns the object.  
  
 The second operator makes a copy of the object, increments the object, then returns the copy.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__operator_eq">\</a>  regex_iterator::operator=  
 Compares iterators for equality.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The iterator to compare to.  
  
### Remarks  
 The member function returns true if <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> are both end-of-sequence iterators or if neither is an end-of-sequence iterator and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Otherwise it returns false.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__operator-_gt_">\</a>  regex_iterator::operator-&gt;  
 Accesses the designated match.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the address of the stored value <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__pointer">\</a>  regex_iterator::pointer  
 The type of a pointer to a match.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is the template parameter.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__reference">\</a>  regex_iterator::reference  
 The type of a reference to a match.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is the template parameter.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__regex_iterator">\</a>  regex_iterator::regex_iterator  
 Constructs the iterator.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Regular expression for matches.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Flags for matches.  
  
### Remarks  
 The first constructor constructs an end-of-sequence iterator. The second constructor initializes the stored value <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, the stored value <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, the stored value <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, and the stored value <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. It then calls <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. If the search fails, the constructor sets the object to an end-of-sequence iterator.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__regex_type">\</a>  regex_iterator::regex_type  
 The type of the regular expression to match.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
##  \<a name="regex_iterator__value_type">\</a>  regex_iterator::value_type  
 The type of a match.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is the template parameter.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **match == a**  
**match == a**  
**match == a**    
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)