---
title: "&lt;regex&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 91a8314b-6f7c-4e33-b7d6-d8583dd75585
caps.latest.revision: 13
---
# &lt;regex&gt; functions
||||  
|-|-|-|  
|[regex_match Function](#regex_match_function)|[regex_replace Function](#regex_replace_function)|[regex_search Function](#regex_search_function)|  
|[swap Function](#swap_function)|  
  
##  \<a name="regex_match_function">\</a>  regex_match Function  
 Tests whether a regular expression matches the entire target string.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The iterator type for submatches. For common cases this one of string::const_iterator, wstring::const_iterator, const char* or const wchar_t\*.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The match results allocator class.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The type of elements to match. For common cases this is string, wstring, char* or wchar_t\*.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The regular expression allocator class.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The string allocator class.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Flags for matches.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The match results. Corresponds to Elem type: [smatch](../vs140/-regex--typedefs.md#smatch_typedef) for string, [wsmatch](../vs140/-regex--typedefs.md#wsmatch_typedef) for wstring, [cmatch](../vs140/-regex--typedefs.md#cmatch_typedef) for char* or [wcmatch](../vs140/-regex--typedefs.md#wcmatch_typedef) for wchar_t\*.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Pointer to beginning of sequence to match. If ptr is char*, then use cmatch and regex. If ptr is wchar_t\* then use wcmatch and wregex.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The regular expression to match. Type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> for string and char*, or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> for wstring and wchar_t\*.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 String to match. Corresponds to the type of Elem.  
  
### Remarks  
 Each template function returns true only if the entire operand sequence <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> exactly matches the regular expression argument <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Use [regex_search](../vs140/-regex--functions.md#regex_search_function) to match a substring within a target sequence and regex_iterator to find multiple matches. The functions that take a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object set its members to reflect whether the match succeeded and if so what the various capture groups in the regular expression captured.  
  
 The functions that take a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object set its members to reflect whether the match succeeded and if so what the various capture groups in the regular expression captured.  
  
 **(1):**  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="regex_replace_function">\</a>  regex_replace Function  
 Replaces matched regular expressions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The iterator type for replacements.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The iterator type for submatches.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The regular expression allocator class.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The type of elements to match.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Flags for matches.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The format for replacements.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The output iterator.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The regular expression to match.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 String to match.  
  
### Remarks  
 The first function constructs a [regex_iterator](../vs140/regex_iterator-class.md) object <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and uses it to split its input range <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> into a series of subsequences <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> match detected by the iterator. If no matches are found, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is the entire input range and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is zero. If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> only the first match is used, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is all of the input text that follows the match, and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is 1. For each <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> it copies the text in the range <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to the iterator <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. It then calls <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object returned by the iterator object <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> for the subsequence <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. Finally, if <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> it copies the text in the range <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to the iterator <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. The function returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 The second function constructs a local variable <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> and calls <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. It returns <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **replacement == AxAyAz**  
**replacement == Axayaz**  
**replacement == AdAeAf**  
**replacement == Adaeaf**    
##  \<a name="regex_search_function">\</a>  regex_search Function  
 Searches for a regular expression match.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The iterator type for submatches.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The match results allocator class.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The type of elements to match.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The regular expression allocator class.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The string traits class.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The string allocator class.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Flags for matches.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The match results.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Pointer to beginning of sequence to match.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The regular expression to match.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 String to match.  
  
### Remarks  
 Each template function returns true only if a search for its regular expression argument <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> in its operand sequence succeeds. The functions that take a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object set its members to reflect whether the search succeeded and if so what the various capture groups in the regular expression captured.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **search(f, f+1, "abc") == false**  
**search(f, l, "abc") == true**  
 **matched: "abc"**  
**search("a", "abc") == false**  
**search("xabcd", "abc") == true**  
 **matched: "abc"**  
**search(string, "abc") == false**  
**search(string, "abc") == true**  
 **matched: "abc"**    
##  \<a name="swap_function">\</a>  swap Function  
 Swaps two basic_regex or match_results objects.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The type of elements to match.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Traits class for elements.  
  
### Remarks  
 The template functions swap the contents of their respective arguments in constant time and do not throw exceptions.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **matched == true**  
**length == 3**  
**string == aaa**    
## See Also  
 [&lt;regex&gt;](../vs140/-regex-.md)