---
title: "char_traits Struct"
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
  - "std::char_traits"
  - "std.char_traits"
  - "iosfwd/std::char_traits"
  - "char_traits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "char_traits struct"
  - "char_traits class"
ms.assetid: 568e59f0-4521-4207-9223-9dcf6a16d620
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits Struct
The char_traits struct describes attributes associated with a character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The element data type.  
  
## Remarks  
 The template struct describes various character traits for type **CharType**. The template class [basic_string](../vs140/basic_string-class.md) as well as several iostream template classes, including [basic_ios](../vs140/basic_ios-class.md), use this information to manipulate elements of type **CharType**. Such an element type must not require explicit construction or destruction. It must supply a default constructor, a copy constructor, and an assignment operator, with the expected semantics. A bitwise copy must have the same effect as an assignment. None of the member functions of struct char_traits can throw exceptions.  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#char_traits__char_type)|A type of character.|  
|[int_type](#char_traits__int_type)|An integer type that can represent a character of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or an end-of-file (EOF) character.|  
|[off_type](#char_traits__off_type)|An integer type that can represent offsets between positions in a stream.|  
|[pos_type](#char_traits__pos_type)|An integer type that can represent positions in a stream.|  
|[state_type](#char_traits__state_type)|A type that represents the conversion state in for multibyte characters in a stream.|  
  
### Member Functions  
  
|||  
|-|-|  
|[assign](#char_traits__assign)|Assigns one character value to another.|  
|[compare](#char_traits__compare)|Compares up to a specified number of characters in two strings.|  
|[copy](#char_traits__copy)|Copies a specified number of characters from one string to another. Deprecated. Use [char_traits::_Copy_s](#char_traits___copy_s) instead.|  
|[_Copy_s](#char_traits___copy_s)|Copies a specified number of characters from one string to another.|  
|[eof](#char_traits__eof)|Returns the end-of-file (EOF) character.|  
|[eq](#char_traits__eq)|Tests whether two <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> characters are equal.|  
|[eq_int_type](#char_traits__eq_int_type)|Tests whether two characters represented as <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>s are equal.|  
|[find](#char_traits__find)|Searches for the first occurrence of a specified character in a range of characters.|  
|[length](#char_traits__length)|Returns the length of a string.|  
|[lt](#char_traits__lt)|Tests whether one character is less than another.|  
|[move](#char_traits__move)|Copies a specified number of characters in a sequence to another, possible overlapping, sequence. Deprecated. Use [char_traits::_Move_s](#char_traits___move_s) instead.|  
|[_Move_s](#char_traits___move_s)|Copies a specified number of characters in a sequence to another, possible overlapping, sequence.|  
|[not_eof](#char_traits__not_eof)|Tests whether a character is the end-of-file (EOF) character.|  
|[to_char_type](#char_traits__to_char_type)|Converts an <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> character to the corresponding <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> character and returns the result.|  
|[to_int_type](#char_traits__to_int_type)|Converts a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> character to the corresponding <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> character and returns the result.|  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
##  \<a name="char_traits__assign">\</a>  char_traits::assign  
 Assigns one character value to another or to a range of elements in a string.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 **_** *CharFrom*  
 The character whose value is to be assigned.  
  
 *_CharTo*  
 The element that is to be assigned the character value.  
  
 *_StrTo*  
 The string or character array whose initial elements are to be assigned character values.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The number of elements that are going to be assigned values.  
  
### Return Value  
 The second member function returns a pointer to the string whose first <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> elements have been assigned values of                         *_CharFrom*.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **The initial characters ( ChTo , ChFrom ) are: ( t , f ).**  
**After assigning, the characters ( ChTo , ChFrom ) are: ( f , f ).**  
**The target string s1 is: abcd-1234-abcd**  
**The result1 = assign ( s1 , 4 , 'f' ) is: ffff-1234-abcd**    
##  \<a name="char_traits__char_type">\</a>  char_traits::char_type  
 A type of character.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
### Example  
  See the example for [copy](#char_traits__copy) for an example of how to declare and use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
##  \<a name="char_traits__compare">\</a>  char_traits::compare  
 Compares up to a specified number of characters in two strings.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *_Str1*  
 The first of two strings to be compared to each other.  
  
 *_Str2*  
 The second of two strings to be compared to each other.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The number of elements in the strings to be compared.  
  
### Return Value  
 A negative value if the first string is less than the second string, 0 if the two strings are equal, or a positive value if the first string is greater than the second string.  
  
### Remarks  
 The comparison between the strings is made element by element, first testing for equality and then, if a pair of elements in the sequence tests not equal, they are tested for less than.  
  
 If two strings compare equal over a range but one is longer than the other, then the shorter of the two is less than the longer one.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="char_traits__copy">\</a>  char_traits::copy  
 Copies a specified number of characters from one string to another.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [char_traits::_Copy_s](#char_traits___copy_s) instead.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The element at the beginning of the string or character array targeted to receive the copied sequence of characters.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The element at the beginning of the source string or character array to be copied.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The number of elements to be copied.  
  
### Return Value  
 The first element copied into the string or character array targeted to receive the copied sequence of characters.  
  
### Remarks  
 The source and destination character sequences must not overlap.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The source string is: abcd-1234-abcd**  
**The destination string is: ABCD-1234**  
**The result1 = copy ( s1 , s2 , 4 ) is: ABCD-1234-abcd**    
##  \<a name="char_traits___copy_s">\</a>  char_traits::_Copy_s  
 Copies a specified number of characters from one string to another.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The string or character array targeted to receive the copied sequence of characters.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, then this size is in bytes. If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, then this size is in words.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The source string or character array to be copied.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The number of elements to be copied.  
  
### Return Value  
 The string or character array targeted to receive the copied sequence of characters.  
  
### Remarks  
 The source and destination character sequences must not overlap.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The source string is: abcd-1234-abcd**  
**The destination string is: ABCD-1234**  
**The result1 = _Copy_s(s1, char_traits\<char>::length(s1), s2, 4) is: ABCD-1234-abcd**    
##  \<a name="char_traits__eof">\</a>  char_traits::eof  
 Returns the end-of-file (EOF) character.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The EOF character.  
  
### Remarks  
 A value that represents end of file (such as <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>).  
  
 The C++ standard states that this value must not correspond to a valid <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> value. The Visual C++ compiler enforces this constraint for type <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, but not for type <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. The example below demonstrates this.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **char_type ch1 is 'x' and corresponds to int_type 120.**  
**The eof marker for char_traits\<char> is: -1**  
**The eof marker for char_traits\<wchar_t> is: 65535**    
##  \<a name="char_traits__eq">\</a>  char_traits::eq  
 Tests whether two <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> characters are equal.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The first of two characters to be tested for equality.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The second of two characters to be tested for equality.  
  
### Return Value  
 **true** if the first character is equal to the second character; otherwise **false**.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The character ch1 is not equal to the character ch2.**  
**The character ch1 is equal to the character ch3.**    
##  \<a name="char_traits__eq_int_type">\</a>  char_traits::eq_int_type  
 Tests whether two characters represented as <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>s are equal or not.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The first of the two characters to be tested for equality as  **int_type**s.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The second of the two characters to be tested for equality as <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>s.  
  
### Return Value  
 **true** if the first character is equal to the second character; otherwise **false**.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The char_types and corresponding int_types are:**  
 **ch1 = x corresponding to int1 = 120.**  
 **ch2 = y corresponding to int1 = 121.**  
 **ch3 = x corresponding to int1 = 120.**  
**The int_type representation of character ch1**  
 **is not equal to the int_type representation of ch2.**  
**The int_type representation of character ch1**  
 **is equal to the int_type representation of ch3.**    
##  \<a name="char_traits__find">\</a>  char_traits::find  
 Searches for the first occurrence of a specified character in a range of characters.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The first character in the string to be searched.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The number of positions, counting from the first, in the range to be searched.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The character to be searched for in the range.  
  
### Return Value  
 A pointer to the first occurrence of the specified character in the range if a match is found; otherwise, a null pointer.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **The string to be searched is: f2d-1234-abcd**  
**The character searched for in s1 is: d**  
**The string beginning with the first occurrence**  
 **of the character 'd' is: d-1234-abcd**  
**The result2 of the search is NULL.**    
##  \<a name="char_traits__int_type">\</a>  char_traits::int_type  
 An integer type that can represent a character of type <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> or an end-of-file (EOF) character.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 It must be possible to type cast a value of type **CharType** to <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> then back to **CharType** without altering the original value.  
  
### Example  
  See the example for [eq_int_type](#char_traits__eq_int_type) for an example of how to declare and use <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
##  \<a name="char_traits__length">\</a>  char_traits::length  
 Returns the length of a string.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The C-string whose length is to be measured.  
  
### Return Value  
 The number of elements in the sequence being measured, not including the null terminator.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The C-string str1 is: Hello**  
**The length of C-string str1 is: 5.**    
##  \<a name="char_traits__lt">\</a>  char_traits::lt  
 Tests whether one character is less than another.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The first of two characters to be tested for less than.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The second of two characters to be tested for less than.  
  
### Return Value  
 **true** if the first character is less than the second character; otherwise **false**.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The character ch1 is less than the character ch2.**  
**The character ch3 is not less than the character ch2.**    
##  \<a name="char_traits__move">\</a>  char_traits::move  
 Copies a specified number of characters in a sequence to another, possibly overlapping sequence.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [char_traits::_Move_s](#char_traits___move_s) instead.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The element at the beginning of the string or character array targeted to receive the copied sequence of characters.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The element at the beginning of the source string or character array to be copied.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The number of elements to be copied from the source string.  
  
### Return Value  
 The first element <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> copied into the string or character array targeted to receive the copied sequence of characters.  
  
### Remarks  
 The source and destination may overlap.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **The source string sFrom1 is: abcd-1234-abcd**  
**The destination stringsTo1 is: ABCD-1234**  
**The result1 = move ( sTo1 , sFrom1 , 4 ) is: abcd-1234**  
**The source/destination string sToFrom2 is: abcd-1234-ABCD**  
**The result2 = move ( sToFrom2 , findc , 8 ) is: cd-1234-4-ABCD**    
##  \<a name="char_traits___move_s">\</a>  char_traits::_Move_s  
 Copies a specified number of characters in a sequence to another, possibly overlapping sequence.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The element at the beginning of the string or character array targeted to receive the copied sequence of characters.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, then this is in bytes. If <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, then this is in words.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The element at the beginning of the source string or character array to be copied.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The number of elements to be copied from the source string.  
  
### Return Value  
 The first element <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> copied into the string or character array targeted to receive the copied sequence of characters.  
  
### Remarks  
 The source and destination may overlap.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **The source string sFrom1 is: abcd-1234-abcd**  
**The destination stringsTo1 is: ABCD-1234**  
**The result1 = _Move_s(sTo1, char_traits\<char>::length(sTo1), sFrom1, 4) is: abcd-1234**  
**The source/destination string sToFrom2 is: abcd-1234-ABCD**  
**The result2 = _Move_s(sToFrom2, char_traits\<char>::length(sToFrom2), findc, 8) is: cd-1234-4-ABCD**    
##  \<a name="char_traits__not_eof">\</a>  char_traits::not_eof  
 Tests whether a character is not the end-of-file (EOF) character or is the EOF.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The character represented as an <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to be tested for whether it is the EOF character or not.  
  
### Return Value  
 The <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> representation of the character tested, if the  **int_type** of the character is not equal to that of the EOF character.  
  
 If the character <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> value is equal to the EOF <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> value, then **false**.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **The char_type ch1 is x corresponding to int_type: 120.**  
**The eofReturn is: -1**  
**The eofTest1 returns: 120, which is the character: x.**  
**The eofTest2 indicates int2 is an EOF character.**    
##  \<a name="char_traits__off_type">\</a>  char_traits::off_type  
 An integer type that can represent offsets between positions in a stream.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 The type is a signed integer that describes an object that can store a byte offset involved in various stream positioning operations. It is typically a synonym for [streamoff](../vs140/-ios--typedefs.md#streamoff), but it has essentially the same properties as that type.  
  
##  \<a name="char_traits__pos_type">\</a>  char_traits::pos_type  
 An integer type that can represent positions in a stream.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can store all the information needed to restore an arbitrary file-position indicator within a stream. It is typically a synonym for [streampos](../vs140/-ios--typedefs.md#streampos), but in any case it has essentially the same properties as that type.  
  
##  \<a name="char_traits__state_type">\</a>  char_traits::state_type  
 A type that represents the conversion state for multibyte characters in a stream.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can represent a conversion state. It is typically a synonym for <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, but in any case it has essentially the same properties as that type.  
  
##  \<a name="char_traits__to_char_type">\</a>  char_traits::to_char_type  
 Converts an <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> character to the corresponding <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> character and returns the result.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> character to be represented as a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
### Return Value  
 The <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> character corresponding to the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> character.  
  
 A value of <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> that cannot be represented as such yields an unspecified result.  
  
### Remarks  
 The conversion operations [to_int_type](#char_traits__to_int_type) and <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> are inverse to each other, so that:  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> (                         *x* ) ) ==                         *x*  
  
 for any <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> *x* and  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> (                         *x* ) ) ==                         *x*  
  
 for any <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> *x*.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  **The char_types and corresponding int_types are:**  
 **ch1 = a corresponding to int1 = 97.**  
 **ch2 = b corresponding to int1 = 98.**  
 **ch3 = a corresponding to int1 = 97.**  
**The recovered char_types and corresponding int_types are:**  
 **recovered ch1 = a from int1 = 97.**  
 **recovered ch2 = b from int2 = 98.**  
**The recovered char_type of ch1 is equal to the original ch1.**  
**The recovered char_type of ch2 is equal to the original ch2.**    
##  \<a name="char_traits__to_int_type">\</a>  char_traits::to_int_type  
 Converts a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> character to the corresponding <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> character and returns the result.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> character to be represented as an <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
### Return Value  
 The <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> character corresponding to the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> character.  
  
### Remarks  
 The conversion operations <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> and [to_char_type](#char_traits__to_char_type) are inverse to each other, so that:  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> (                         *x* ) ) ==                         *x*  
  
 for any <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> *x*, and  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> (                         *x* ) ) ==                         *x*  
  
 for any <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> *x*.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  **The char_types and corresponding int_types are:**  
 **ch1 = a corresponding to int1 = 97.**  
 **ch2 = b corresponding to int1 = 98.**  
 **ch3 = a corresponding to int1 = 97.**  
**The recovered char_types and corresponding int_types are:**  
 **recovered ch1 = a from int1 = 97.**  
 **recovered ch2 = b from int2 = 98.**  
**The recovered char_type of ch1 is equal to the original ch1.**  
**The recovered char_type of ch2 is equal to the original ch2.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)