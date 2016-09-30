---
title: "basic_regex Class"
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
  - "std::tr1::basic_regex"
  - "basic_regex"
  - "std.tr1.basic_regex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_regex class [TR1]"
ms.assetid: 8a18c6b4-f22a-4cfd-bc16-b4267867ebc3
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_regex Class
Wraps a regular expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The type of elements to match.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
## Remarks  
 The template class describes an object that holds a regular expression. Objects of this template class can be passed to the template functions [regex_match](../vs140/-regex--functions.md#regex_match_function), [regex_search](../vs140/-regex--functions.md#regex_search_function), and [regex_replace](../vs140/-regex--functions.md#regex_replace_function), along with suitable text string arguments, to search for text that matches the regular expression. There are two specializations of this template class, with the type definitions [regex](../vs140/-regex--typedefs.md#regex_typedef) for elements of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and [wregex](../vs140/-regex--typedefs.md#wregex_typedef) for elements of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The template argument <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> describes various important properties of the syntax of the regular expressions that the template class supports. A class that specifies these regular expression traits must have the same external interface as an object of template class [regex_traits](../vs140/regex_traits-class.md).  
  
 Some functions take an operand sequence that defines a regular expression. You can specify such an operand sequence several ways:  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> -- a null-terminated sequence (such as a C string, for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) beginning at <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> (which must not be a null pointer), where the terminating element is the value <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and is not part of the operand sequence  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> -- a sequence of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> elements beginning at <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (which must not be a null pointer)  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> -- the sequence specified by the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> -- a sequence of elements delimited by the iterators <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, in the range <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> -- the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 These member functions also take an argument <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> that specifies various options for the interpretation of the regular expression in addition to those described by the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> type.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
##  \<a name="basic_regex__assign">\</a>  basic_regex::assign  
 Assigns a value to the regular expressoin object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Traits class for a string source.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Allocator class for a string source.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Input iterator type for a range source.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Regex source to copy.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Pointer to beginning of sequence to copy.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Syntax option flags to add while copying.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Length of sequence to copy.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 String to copy.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Beginning of sequence to copy.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 End of sequence to copy.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The initializer_list to copy.  
  
### Remarks  
 The member functions each replace the regular expression held by <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> with the regular expression described by the operand sequence, then return <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **match("abc", "") == falsematch("abc", "abcd") == falsematch("abc", "abc") == truematch("abc", "abc") == truematch(string("abcd"), "abc") == falsematch(string("abc"), "abc") == true"abc" mark_count == 0"(abc)" mark_count == 1getloc == imbued == truematch("abc") == true**    
##  \<a name="basic_regex__basic_regex">\</a>  basic_regex::basic_regex  
 Construct the regular expression object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Traits class for a string source.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Allocator class for a string source.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Input iterator type for a range source.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Regex source to copy.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Pointer to beginning of sequence to copy.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Syntax option flags to add while copying.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Length of sequence to copy.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 String to copy.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Beginning of sequence to copy.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 End of sequence to copy.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The initializer_list to copy.  
  
### Remarks  
 All constructors store a default-constructed object of type <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 The first constructor constructs an empty <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object. The other constructors construct a <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object that holds the regular expression described by the operand sequence.  
  
 An empty <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object does not match any character sequence when passed to [regex_match](../vs140/-regex--functions.md#regex_match_function), [regex_search](../vs140/-regex--functions.md#regex_search_function), or [regex_replace](../vs140/-regex--functions.md#regex_replace_function).  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **match("abc", "") == falsematch("abc", "abcd") == falsematch("abc", "abc") == truematch("abc", "abc") == truematch(string("abcd"), "abc") == falsematch(string("abc"), "abc") == true"abc" mark_count == 0"(abc)" mark_count == 1getloc == imbued == truematch("abc", "abc") == true**    
##  \<a name="basic_regex__flag_type">\</a>  basic_regex::flag_type  
 The type of syntax option flags.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for [regex_constants::syntax_option_type](../vs140/regex_constants-class.md#regex_constants__syntax_option_type).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__flags">\</a>  basic_regex::flags  
 Returns syntax option flags.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the value of the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> argument passed to the most recent call to one of the [assign](#basic_regex__assign) member functions or, if no such call has been made, the value passed to the constructor.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__getloc">\</a>  basic_regex::getloc  
 Returns the stored locale object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>[getloc](../vs140/regex_traits-class.md#regex_traits__getloc)<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__imbue">\</a>  basic_regex::imbue  
 Alters the stored locale object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The locale object to store.  
  
### Remarks  
 The member function empties <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>[imbue](../vs140/regex_traits-class.md#regex_traits__imbue)<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__locale_type">\</a>  basic_regex::locale_type  
 The type of the stored locale object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for [regex_traits::locale_type](../vs140/regex_traits-class.md#regex_traits__locale_type).  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__mark_count">\</a>  basic_regex::mark_count  
 Returns number of subexpressions matched.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the number of capture groups in the regular expression.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__operator_eq">\</a>  basic_regex::operator=  
 Assigns a value to the regular expression object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Traits class for a string source.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Allocator class for a string source.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Regex source to copy.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 String to copy.  
  
### Remarks  
 The operators each replace the regular expression held by <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> with the regular expression described by the operand sequence, then return <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__swap">\</a>  basic_regex::swap  
 Swaps two regular expression objects.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The regular expression object to swap with.  
  
### Remarks  
 The member function swaps the regular expressions between <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. It does so in constant time and throws no exceptions.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
##  \<a name="basic_regex__value_type">\</a>  basic_regex::value_type  
 The element type.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **match("abc", "") == false**  
**match("abc", "abcd") == false**  
**match("abc", "abc") == true**  
**match("abc", "abc") == true**  
**match(string("abcd"), "abc") == false**  
**match(string("abc"), "abc") == true**  
**"abc" mark_count == 0**  
**"(abc)" mark_count == 1**  
**getloc == imbued == true**    
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_match](../vs140/-regex--functions.md#regex_match_function)   
 [regex_search](../vs140/-regex--functions.md#regex_search_function)   
 [regex_replace](../vs140/-regex--functions.md#regex_replace_function)   
 [regex](../vs140/-regex--typedefs.md#regex_typedef)   
 [wregex](../vs140/-regex--typedefs.md#wregex_typedef)   
 [regex_traits](../vs140/regex_traits-class.md)