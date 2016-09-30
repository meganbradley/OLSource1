---
title: "regex_token_iterator Class"
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
  - "regex_token_iterator"
  - "std.tr1.regex_token_iterator"
  - "std::tr1::regex_token_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_token_iterator class [TR1]"
ms.assetid: a213ba48-8e4e-4b6b-871a-2637acf05f15
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_token_iterator Class
Iterator class for submatches.  
  
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
 The template class describes a constant forward iterator object. Conceptually, it holds a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object that it uses to search for regular expression matches in a character sequence. It extracts objects of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> representing the submatches identified by the index values in the stored vector <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> for each regular expression match.  
  
 An index value of -1 designates the character sequence beginning immediately after the end of the previous regular expression match, or beginning at the start of the character sequence if there was no previous regular expression match, and extending to but not including the first character of the current regular expression match, or to the end of the character sequence if there is no current match. Any other index value <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> designates the contents of the capture group held in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
##  \<a name="regex_token_iterator__difference_type">\</a>  regex_token_iterator::difference_type  
 The type of an iterator difference.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__iterator_category">\</a>  regex_token_iterator::iterator_category  
 The type of the iterator category.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__operator_neq">\</a>  regex_token_iterator::operator!=  
 Compares iterators for inequality.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The iterator to compare to.  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__operator_star">\</a>  regex_token_iterator::operator*  
 Accesses the designated submatch.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object representing the capture group identified by the index value <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__operator_add_add">\</a>  regex_token_iterator::operator++  
 Increments the iterator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 If the stored iterator <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is an end-of-sequence iterator the first operator sets the stored value <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to the value of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> (thus making an end-of-sequence iterator). Otherwise the operator increments the stored value <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>; if the result is equal to the value <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> it sets the stored value <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to zero and increments the stored iterator <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. If incrementing the stored iterator leaves it unequal to an end-of-sequence iterator the operator does nothing further. Otherwise, if the end of the preceding match was at the end of the character sequence the operator sets the stored value of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. Otherwise, the operator repeatedly increments the stored value <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> until <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> (thus ensuring that the next dereference of the iterator will return the tail of the character sequence if one of the index values is -1). In all cases the operator returns the object.  
  
 The second operator makes a copy of the object, increments the object, then returns the copy.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__operator_eq_eq">\</a>  regex_token_iterator::operator==  
 Compares iterators for equality.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 right  
 The iterator to compare to.  
  
### Remarks  
 The member function returns <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__operator-_gt_">\</a>  regex_token_iterator::operator-&gt;  
 Accesses the designated submatch.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns a pointer to a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object representing the capture group identified by the index value <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__pointer">\</a>  regex_token_iterator::pointer  
 The type of a pointer to a match.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is the template parameter.  
  
##  \<a name="regex_token_iterator__reference">\</a>  regex_token_iterator::reference  
 The type of a reference to a submatch.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is the template parameter.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__regex_token_iterator">\</a>  regex_token_iterator::regex_token_iterator  
 Constructs the iterator.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Beginning of sequence to match.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 End of sequence to match.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Regular expression for matches.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Flags for matches.  
  
### Remarks  
 The first constructor constructs an end-of-sequence iterator.  
  
 The second constructor constructs an object whose stored iterator <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is initialized to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, whose stored vector <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> holds exactly one integer, with value <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, and whose stored value <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is zero. Note: the resulting object extracts the submatch identified by the index value <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> for each successful regular expression match.  
  
 The third constructor constructs an object whose stored iterator <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is initialized to <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, whose stored vector <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> holds a copy of the constructor argument <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, and whose stored value <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is zero.  
  
 The fourth constructor constructs an object whose stored iterator <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is initialized to <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, whose stored vector <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> holds the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> values pointed to by the constructor argument <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, and whose stored value <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is zero.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__regex_type">\</a>  regex_token_iterator::regex_type  
 The type of the regular expression to match.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
##  \<a name="regex_token_iterator__value_type">\</a>  regex_token_iterator::value_type  
 The type of a submatch.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> is the template parameter.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**    
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_token_iterator](../vs140/regex_token_iterator-class.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)