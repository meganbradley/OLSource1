---
title: "&lt;locale&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b06c1ceb-33a7-48d3-8d4b-2714bbb27f14
caps.latest.revision: 15
---
# &lt;locale&gt; functions
||||  
|-|-|-|  
|[has_facet](#has_facet)|[isalnum](#isalnum)|[isalpha](#isalpha)|  
|[iscntrl](#iscntrl)|[isdigit](#isdigit)|[isgraph](#isgraph)|  
|[islower](#islower)|[isprint](#isprint)|[ispunct](#ispunct)|  
|[isspace](#isspace)|[isupper](#isupper)|[isxdigit](#isxdigit)|  
|[tolower](#tolower)|[toupper](#toupper)|[use_facet](#use_facet)|  
  
##  \<a name="has_facet">\</a>  has_facet  
 Tests if a particular facet is stored in a specified locale.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The locale to be tested for the presence of a facet.  
  
### Return Value  
 **true** if the locale has the facet tested for; **false** if it does not.  
  
### Remarks  
 The template function is useful for checking whether nonmandatory facets are listed in a locale before <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is called to avoid the exception that would be thrown if it were not present.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **1**    
##  \<a name="isalnum">\</a>  isalnum  
 Tests whether an element in a locale is an alphabetic or a numeric character.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The alphanumeric element to be tested.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The locale containing the alphanumeric element to be tested.  
  
### Return Value  
 **true** if the element tested is alphanumeric; **false** if it is not.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The character 'L' in the locale is alphanumeric.**  
**The character '@' in the locale is  not alphanumeric.**  
**The character '3' in the locale is alphanumeric.**    
##  \<a name="isalpha">\</a>  isalpha  
 Tests whether an element in a locale is an alphabetic character.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The locale containing the alphabetic element to be tested.  
  
### Return Value  
 **true** if the element tested is alphabetic; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **alpha**, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="iscntrl">\</a>  iscntrl  
 Tests whether an element in a locale is a control character.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is a control character; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **cntrl**, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="isdigit">\</a>  isdigit  
 Tests whether an element in a locale is a numeric character.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is a numeric character; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **digit**, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="isgraph">\</a>  isgraph  
 Tests whether an element in a locale is an alphanumeric or punctuation character.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is an alphanumeric or a punctuation character; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **graph**, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="islower">\</a>  islower  
 Tests whether an element in a locale is lower case.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is a lowercase character; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **lower**, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="isprint">\</a>  isprint  
 Tests whether an element in a locale is a printable character.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is a printable; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **print**, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="ispunct">\</a>  ispunct  
 Tests whether an element in a locale is a punctuation character.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is a punctuation character; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>[ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **punct**, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="isspace">\</a>  isspace  
 Tests whether an element in a locale is a whitespace character.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is a whitespace character; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **space**, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="isupper">\</a>  isupper  
 Tests whether an element in a locale is in upper case.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is an uppercase character; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **upper**, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="isxdigit">\</a>  isxdigit  
 Tests whether an element in a locale is a character used to represent a hexadecimal number.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
### Return Value  
 **true** if the element tested is a character used to represent a hexadecimal number; **false** if it is not.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\<  **CharType**> >( <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>). [is](../vs140/ctype-class.md#ctype__is)( **ctype**\< **CharType**>:: **xdigit**, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>).  
  
 Hexadecimal digits use base 16 to represent numbers, using the numbers 0 through 9 plus case-insensitive letters A through F to represent the decimal numbers 0 through 15.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="tolower">\</a>  tolower  
 Converts a character to lower case.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The character to be converted to lower case.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The locale containing the character to be converted.  
  
### Return Value  
 The character converted to lower case.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>). [tolower](../vs140/ctype-class.md#ctype__tolower)( <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
##  \<a name="toupper">\</a>  toupper  
 Converts a character to upper case.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The character to be converted to upper case.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The locale containing the character to be converted.  
  
### Return Value  
 The character converted to upper case.  
  
### Remarks  
 The template function returns [use_facet](../vs140/-locale--functions.md#use_facet)< [ctype](../vs140/ctype-class.md)\< **CharType**> >( <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>). [toupper](../vs140/ctype-class.md#ctype__toupper)( <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
##  \<a name="use_facet">\</a>  use_facet  
 Returns a reference to a facet of a specified type stored in a locale.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The const locale containing the type of facet being referenced.  
  
### Return Value  
 A reference to the facet of class <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> contained within the argument locale.  
  
### Remarks  
 The reference to the facet returned by the template function remains valid as long as any copy of the containing locale exists. If no such facet object of class <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is listed in the argument locale, the function throws a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> exception.  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  **The character 'a' in locale loc1 is alphabetic.**  
**The character '!' in locale loc2 is not alphabetic.**    
## See Also  
 [&lt;locale&gt;](../vs140/-locale-.md)