---
title: "regex_traits Class"
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
  - "regex_traits"
  - "std::tr1::regex_traits"
  - "std.tr1.regex_traits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_traits class [TR1]"
ms.assetid: bc5a5eed-32fc-4eb7-913d-71c42e729e81
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits Class
Describes characteristics of elements for matching.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The element type to describe.  
  
## Remarks  
 The template class describes various regular expression traits for type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The template class [basic_regex](../vs140/basic_regex-class.md) uses this information to manipulate elements of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 Each <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object holds an object of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> which is used by some of its member functions. The default locale is a copy of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. The member function <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> replaces the locale object, and the member function <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> returns a copy of the locale object.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
##  \<a name="regex_traits__char_class_type">\</a>  regex_traits::char_class_type  
 The type of character class designators.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for an unspecified type that designates character classes. Values of this type can be combined using the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> operator to designate character classes that are the union of the classes designated by the operands.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__char_type">\</a>  regex_traits::char_type  
 The type of an element.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for the template argument <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__getloc">\</a>  regex_traits::getloc  
 Returns the stored locale object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__imbue">\</a>  regex_traits::imbue  
 Alters the stored locale object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The locale object to store.  
  
### Remarks  
 The member function copies <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to the stored <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object and returns a copy of the previous value of the stored <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__isctype">\</a>  regex_traits::isctype  
 Tests for class membership.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The element to test.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The classes to test for.  
  
### Remarks  
 The member function returns true only if the character <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is in the character class designated by <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__length">\</a>  regex_traits::length  
 Returns the length of a nul-terminated sequence.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The nul-terminated sequence.  
  
### Remarks  
 The static member function returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__locale_type">\</a>  regex_traits::locale_type  
 The type of the stored locale object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for a type that encapsulates locales. In the specializations <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> it is a synonym for <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__lookup_classname">\</a>  regex_traits::lookup_classname  
 Maps a sequence to a character class.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Beginning of sequence to look up.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 End of sequence to look up.  
  
### Remarks  
 The member function returns a value that designates the character class named by the character sequence pointed to by its arguments. The value does not depend on the case of the characters in the sequence.  
  
 The specialization <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> recognizes the names <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, all without regard to case.  
  
 The specialization <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> recognizes the names <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, all without regard to case.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__lookup_collatename">\</a>  regex_traits::lookup_collatename  
 Maps a sequence to a collating element.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Beginning of sequence to look up.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 End of sequence to look up.  
  
### Remarks  
 The member function returns a string object containing the collating element corresponding to the sequence <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, or an empty string if the sequence is not a valid collating element.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__regex_traits">\</a>  regex_traits::regex_traits  
 Constructs the object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 The constructor constructs an object whose stored <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object is initialized to the default locale.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__size_type">\</a>  regex_traits::size_type  
 The type of a sequence length.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for an unsigned integral type. In the specializations <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> it is a synonym for <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
 The typedef is a synonym for <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__string_type">\</a>  regex_traits::string_type  
 The type of a string of elements.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__transform">\</a>  regex_traits::transform  
 Converts to equivalent ordered sequence.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Beginning of sequence to transform.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 End of sequence to transform.  
  
### Remarks  
 The member function returns a string that it generates by using a transformation rule that depends on the stored <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object. For two character sequences designated by the iterator ranges <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> if the character sequence designated by the iterator range <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> sorts before the character sequence designated by the iterator range <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__transform_primary">\</a>  regex_traits::transform_primary  
 Converts to equivalent caseless ordered sequence.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Beginning of sequence to transform.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 End of sequence to transform.  
  
### Remarks  
 The member function returns a string that it generates by using a transformation rule that depends on the stored <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object. For two character sequences designated by the iterator ranges <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> if the character sequence designated by the iterator range <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> sorts before the character sequence designated by the iterator range <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> without regard for case or accents.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__translate">\</a>  regex_traits::translate  
 Converts to equivalent matching element.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The element to convert.  
  
### Remarks  
 The member function returns a character that it generates by using a transformation rule that depends on the stored <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object. For two <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> objects <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> only if <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> should match when one occurs in the regular expression definition and the other occurs at a corresponding position in the target sequence for a locale-sensitive match.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__translate_nocase">\</a>  regex_traits::translate_nocase  
 Converts to equivalent caseless matching element.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The element to convert.  
  
### Remarks  
 The member function returns a character that it generates by using a transformation rule that depends on the stored <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object. For two <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> objects <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> only if <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> should match when one occurs in the regular expression definition and the other occurs at a corresponding position in the target sequence for a case-insensitive match.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
##  \<a name="regex_traits__value">\</a>  regex_traits::value  
 Converts an element to a digit value.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The element to convert.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 The arithmetic base to use.  
  
### Remarks  
 The member function returns the value represented by the character <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> in the base <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, or -1 if <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> is not a valid digit in the base <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>. The function will only be called with a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> argument of 8, 10, or 16.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**    
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_traits](../vs140/regex_traits-class.md)   
 [regex_traits\<char>](../vs140/regex_traits-char--class.md)   
 [regex_traits\<wchar_t>](../vs140/regex_traits-wchar_t--class.md)