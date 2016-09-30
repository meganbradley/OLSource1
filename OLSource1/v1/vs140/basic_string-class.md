---
title: "basic_string Class"
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
  - "std.basic_string"
  - "std::basic_string"
  - "basic_string"
  - "xstring/std::basic_string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_string class"
ms.assetid: a9c3e0a2-39bf-4c8a-b093-9abe30839591
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string Class
The sequences controlled by an object of template class <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> are the Standard C++ string class and are usually referred to as strings, but they should not be confused with the null-terminated C-style strings used throughout the Standard C++ Library. The Standard C++ string is a container that enables the use of strings as normal types, such as comparison and concatenation operations, iterators, STL algorithms, and copying and assigning with class allocator managed memory. If you need to convert a Standard C++ string to a null-terminated C-style string, use the [basic_string::c_str](#basic_string__c_str) member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The data type of a single character to be stored in the string. The Standard C++ Library provides specializations of this template class, with the type definitions [string](../vs140/-string--typedefs.md#string) for elements of type <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, [wstring](../vs140/-string--typedefs.md#wstring), for <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, [u16string](../vs140/-string--typedefs.md#u16string) for <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, and [u32string](../vs140/-string--typedefs.md#u32string) for <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Various important properties of the **CharType** elements in a basic_string specialization are described by the class **Traits**. The default value is <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>>.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the string's allocation and deallocation of memory. The default value is **allocator**< <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>>.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_string](#basic_string__basic_string)|Constructs a string that is empty or initialized by specific characters or that is a copy of all or part of some other string object or C-string.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#basic_string__allocator_type)|A type that represents the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> class for a string object.|  
|[const_iterator](#basic_string__const_iterator)|A type that provides a random-access iterator that can access and read a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> element in the string.|  
|[const_pointer](#basic_string__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> element in a string.|  
|[const_reference](#basic_string__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> element stored in a string for reading and performing <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#basic_string__const_reverse_iterator)|A type that provides a random-access iterator that can read any <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> element in the string.|  
|[difference_type](#basic_string__difference_type)|A type that provides the difference between two iterators that refer to elements within the same string.|  
|[iterator](#basic_string__iterator)|A type that provides a random-access iterator that can read or modify any element in a string.|  
|[npos](#basic_string__npos)|An unsigned integral value initialized to –1 that indicates either "not found" or "all remaining characters" when a search function fails.|  
|[pointer](#basic_string__pointer)|A type that provides a pointer to a character element in a string or character array.|  
|[reference](#basic_string__reference)|A type that provides a reference to an element stored in a string.|  
|[reverse_iterator](#basic_string__reverse_iterator)|A type that provides a random-access iterator that can read or modify an element in a reversed string.|  
|[size_type](#basic_string__size_type)|An unsigned integral type for the number of elements in a string.|  
|[traits_type](#basic_string__traits_type)|A type for the character traits of the elements stored in a string.|  
|[value_type](#basic_string__value_type)|A type that represents the type of characters stored in a string.|  
  
### Member Functions  
  
|||  
|-|-|  
|[append](#basic_string__append)|Adds characters to the end of a string.|  
|[assign](#basic_string__assign)|Assigns new character values to the contents of a string.|  
|[at](#basic_string__at)|Returns a reference to the element at a specified location in the string.|  
|[back](#basic_string__back)||  
|[begin](#basic_string__begin)|Returns an iterator addressing the first element in the string.|  
|[c_str](#basic_string__c_str)|Converts the contents of a string as a C-style, null-terminated, string.|  
|[capacity](#basic_string__capacity)|Returns the largest number of elements that could be stored in a string without increasing the memory allocation of the string.|  
|[cbegin](#basic_string__cbegin)|Returns a const iterator addressing the first element in the string.|  
|[cend](#basic_string__cend)|Returns a const iterator that addresses the location succeeding the last element in a string.|  
|[clear](#basic_string__clear)|Erases all elements of a string.|  
|[compare](#basic_string__compare)|Compares a string with a specified string to determine if the two strings are equal or if one is lexicographically less than the other.|  
|[copy](#basic_string__copy)|Copies at most a specified number of characters from an indexed position in a source string to a target character array. Deprecated. Use [basic_string::_Copy_s](#basic_string___copy_s) instead.|  
|[crbegin](#basic_string__crbegin)|Returns a const iterator that addresses the first element in a reversed string.|  
|[crend](#basic_string__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed string.|  
|[_Copy_s](#basic_string___copy_s)|Copies at most a specified number of characters from an indexed position in a source string to a target character array.|  
|[data](#basic_string__data)|Converts the contents of a string into an array of characters.|  
|[empty](#basic_string__empty)|Tests whether the string contains characters.|  
|[end](#basic_string__end)|Returns an iterator that addresses the location succeeding the last element in a string.|  
|[erase](#basic_string__erase)|Removes an element or a range of elements in a string from a specified position.|  
|[find](#basic_string__find)|Searches a string in a forward direction for the first occurrence of a substring that matches a specified sequence of characters.|  
|[find_first_not_of](#basic_string__find_first_not_of)|Searches through a string for the first character that is not any element of a specified string.|  
|[find_first_of](#basic_string__find_first_of)|Searches through a string for the first character that matches any element of a specified string.|  
|[find_last_not_of](#basic_string__find_last_not_of)|Searches through a string for the last character that is not any element of a specified string.|  
|[find_last_of](#basic_string__find_last_of)|Searches through a string for the last character that is an element of a specified string.|  
|[front](#basic_string__front)|Returns a reference to the first element in a string.|  
|[get_allocator](#basic_string__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object used to construct the string.|  
|[insert](#basic_string__insert)|Inserts an element or a number of elements or a range of elements into the string at a specified position.|  
|[length](#basic_string__length)|Returns the current number of elements in a string.|  
|[max_size](#basic_string__max_size)|Returns the maximum number of characters a string could contain.|  
|[pop_back](#basic_string__pop_back)|Erases the last element of the string.|  
|[push_back](#basic_string__push_back)|Adds an element to the end of the string.|  
|[rbegin](#basic_string__rbegin)|Returns an iterator to the first element in a reversed string.|  
|[rend](#basic_string__rend)|Returns an iterator that points just beyond the last element in a reversed string.|  
|[replace](#basic_string__replace)|Replaces elements in a string at a specified position with specified characters or characters copied from other ranges or strings or C-strings.|  
|[reserve](#basic_string__reserve)|Sets the capacity of the string to a number at least as great as a specified number.|  
|[resize](#basic_string__resize)|Specifies a new size for a string, appending or erasing elements as required.|  
|[rfind](#basic_string__rfind)|Searches a string in a backward direction for the first occurrence of a substring that matches a specified sequence of characters.|  
|[shrink_to_fit](#basic_string__shrink_to_fit)|Discards the excess capacity of the string.|  
|[size](#basic_string__size)|Returns the current number of elements in a string.|  
|[substr](#basic_string__substr)|Copies a substring of at most some number of characters from a string beginning from a specified position.|  
|[swap](#basic_string__swap)|Exchange the contents of two strings.|  
  
### Operators  
  
|||  
|-|-|  
|[operator+=](#basic_string__operator_add_eq)|Appends characters to a string.|  
|[operator=](#basic_string__operator_eq)|Assigns new character values to the contents of a string.|  
|[operator&#91;&#93;](#basic_string__operator_at)|Provides a reference to the character with a specified index in a string.|  
  
## Remarks  
 If a function is asked to generate a sequence longer than [max_size](#basic_string__max_size) elements, the function reports a length error by throwing an object of type [length_error](../vs140/length_error-class.md).  
  
 References, pointers, and iterators that designate elements of the controlled sequence can become invalid after any call to a function that alters the controlled sequence, or after the first call to a non- **const** member function.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
##  \<a name="basic_string__allocator_type">\</a>  basic_string::allocator_type  
 A type that represents the allocator class for a string object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Allocator**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="basic_string__append">\</a>  basic_string::append  
 Adds characters to the end of a string.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The C-string to be appended.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The string whose characters are to be appended.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The index of the part of the source string supplying the characters to be appended.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The number of characters to be appended, at most, from the source string.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The character value to be appended.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be appended.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the range to be appended.  
  
### Return Value  
 A reference to the string object that is being appended with the characters passed by the member function.  
  
### Remarks  
 Characters may be appended to a string using the [operator+=](#basic_string__operator_add_eq) or the member functions **append** or [push_back](#basic_string__push_back). <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> appends single-argument values while the multiple-argument **append** member function allows a specific part of a string to be specified for adding.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello**   
**The C-string cstr1a is: Out There**   
**Appending the C-string cstr1a to string str1 gives: Hello Out There .**  
**The string str1b is: Hello**   
**The C-string cstr1b is: Out There**   
**Appending the 1st part of the C-string cstr1b to string str1 gives: Hello Out.**  
**The string str2c is: Wide World**   
**The appended string str1 is: Hello World.**  
**The  string str2d is: Wide**   
**The appended string str1d is: Hello Wide .**  
**The doubly appended strig str1 is: Hello Wide World .**  
**The string str1 appended with exclamations is: Hello !!!!**  
**The string str2f is: Wide World**   
**The appended string str1 is: Hello World.**    
##  \<a name="basic_string__assign">\</a>  basic_string::assign  
 Assigns new character values to the contents of a string.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A pointer to the characters of the C-string to be assigned to the target string.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The number of characters to be appended, at most, from the source string.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The source string whose characters are to be assigned to the target string.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The character value to be assigned.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the first character in the range of the source string to be assigned to the target range.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the one beyond the last character in the range of the source string to be assigned to the target range.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The position at which new characters will start to be assigned.  
  
### Return Value  
 A reference to the string object that is being assigned new characters by the member function.  
  
### Remarks  
 The strings can be assigned new character values. The new value can be either a string and C-string or a single character. The [operator=](#basic_string__operator_eq) may be used if the new value can be described by a single parameter; otherwise the member function **assign**, which has multiple parameters, can be used to specify which part of the string is to be assigned to a target string.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **The C-string cstr1a is: Out There.**  
**Assigning the C-string cstr1a to string str1 gives: Out There.**  
**The C-string cstr1b is: Out There**  
**Assigning the 1st part of the C-string cstr1b to string str1 gives: Out.**  
**The string str2c is: Wide World**   
**The newly assigned string str1 is: World.**  
**The original string str1 is: Hello.**  
**The string str2d is: Wide**  
**The string str1 newly assigned with string str2d is: Wide.**  
**The string str3d is: World.**  
**The string str1 reassigned with string str3d is: World.**  
**The string str1 assigned with eclamations is: !!!!**  
**The string str2f is: Wide World**   
**The string str1 assigned a range of string str2f is: World.**    
##  \<a name="basic_string__at">\</a>  basic_string::at  
 Provides a reference to the character with a specified index in a string.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The index of the position of the element to be referenced.  
  
### Return Value  
 A reference to the character of the string at the position specified by the parameter index.  
  
### Remarks  
 The first element of the string has an index of zero and the following elements are indexed consecutively by the positive integers, so that a string of length                         *n* has an                         *n*th element indexed by the number                         *n –* 1.  
  
 The member [operator&#91;&#93;](#basic_string__operator_at) is faster than the member function **at** for providing read and write access to the elements of a string.  
  
 The member <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> does not check whether the index passed as a parameter is valid but the member function **at** does and so should be used if the validity is not certain. An invalid index, which is an index less that zero or greater than or equal to the size of the string, passed to the member function **at** throws an [out_of_range Class](../vs140/out_of_range-class.md) exception. An invalid index passed to the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> results in undefined behavior, but the index equal to the length of the string is a valid index for const strings and the operator returns the null-character when passed this index.  
  
 The reference returned may be invalidated by string reallocations or modifications for the non- **const** strings.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="basic_string__back">\</a>  basic_string::back  
 Returns a reference to the last element in the string.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the last element of the string, which must be non-empty.  
  
### Remarks  
  
##  \<a name="basic_string__basic_string">\</a>  basic_string::basic_string  
 Constructs a string that is empty, initialized by specific characters, or is a copy of all or part of another string object or C style (null-terminated) string.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The C-string whose characters are to be used to initialize the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> being constructed. This value cannot be a null pointer.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The storage allocator class for the string object being constructed.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The number of characters to be initialized.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The string to initialize the string being constructed.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The index of a character in a string that is the first to be used to initialize character values for the string being constructed.  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The character value to be copied into the string being constructed.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the first element in the source range to be inserted.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the source range to be inserted.  
  
### Return Value  
 A reference to the string object that is being constructed by the constructors.  
  
### Remarks  
 All constructors store an [basic_string::allocator_type](#basic_string__allocator_type) and initialize the controlled sequence. The allocator object is the argument <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, if present. For the copy constructor, it is <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>[get_allocator](#basic_string__get_allocator)<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>. Otherwise, it is <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>.  
  
 The controlled sequence is initialized to a copy of the operand sequence specified by the remaining operands. A constructor without an operand sequence specifies an empty initial controlled sequence. If <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> is an integer type in a template constructor, the operand sequence _F <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> behaves the same as <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="basic_string__begin">\</a>  basic_string::begin  
 Returns an iterator addressing the first element in the string.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A random-access iterator that addresses the first element of the sequence or just beyond the end of an empty sequence.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="basic_string__c_str">\</a>  basic_string::c_str  
 Converts the contents of a string as a C-style, null-terminated string.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the C-style version of the invoking string.  The pointer value is not valid after calling a non-const function, including the destructor, in the basic_string class on the object.  
  
### Remarks  
 Objects of type string belonging to the C++ template class basic_string\<char> are not necessarily null terminated. The null character ' \0 ' is used as a special character in a C-string to mark the end of the string but has no special meaning in an object of type string and may be a part of the string just like any other character. There is an automatic conversion from const **char\*** into strings, but the string class does not provide for automatic conversions from C-style strings to objects of type **basic_string\<char>**.  
  
 The returned C-style string should not be modified, as this could invalidate the pointer to the string, or deleted, as the string has a limited lifetime and is owned by the class string.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The original string object str1 is: Hello world**  
**The length of the string object str1 = 11**  
**The modified string object ptr1 is: Hello world**  
**The length of character array str1 = 11**  
**The C-style string c_str1 is: Hello world**  
**The length of C-style string str1 = 11**    
##  \<a name="basic_string__capacity">\</a>  basic_string::capacity  
 Returns the largest number of elements that could be stored in a string without increasing the memory allocation of the string.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The size of storage currently allocated in memory to hold the string.  
  
### Remarks  
 The member function returns the storage currently allocated to hold the controlled sequence, a value at least as large as [size](#basic_string__size).  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="basic_string__cbegin">\</a>  basic_string::cbegin  
 Returns a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> random-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="basic_string__cend">\</a>  basic_string::cend  
 Returns a <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> random-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="basic_string__clear">\</a>  basic_string::clear  
 Erases all elements of a string.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 The string on which the member function is called will be empty.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello world**  
**The modified string str1 is:**   
**Nothing printed above because the string str1 is empty.**    
##  \<a name="basic_string__compare">\</a>  basic_string::compare  
 Performs a case sensitive comparison with a specified string to determine if the two strings are equal or if one is lexicographically less than the other.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The string that is to be compared to the operand string.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 The index of the operand string at which the comparison begins.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The maximum number of characters from the operand string to be compared.  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The maximum number of characters from the parameter string to be compared.  
  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The index of the parameter string at which the comparison begins.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The maximum number of characters from the parameter string to be compared.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 The C-string to be compared to the operand string.  
  
### Return Value  
 A negative value if the operand string is less than the parameter string; zero if the two strings are equal; or a positive value if the operand string is greater than the parameter string.  
  
### Remarks  
 The **compare** member functions compare either all or part of the parameter and operand strings depending on which in used.  
  
 The comparison performed is case sensitive.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  **The operand string is: CAB**  
**The parameter string is: CAB**  
**The operand string is equal to the parameter string.**  
**The operand string is: AACAB**  
**The parameter string is: CAB**  
**The last three characters of the operand string**  
 **are equal to the parameter string.**  
**The first three characters of the operand string**  
 **are less than the parameter string.**  
**The operand string is: AACAB**  
**The parameter string is: DCABD**  
**The three characters from position 2 of the operand string are equal to**  
 **the 3 characters parameter string from position 1.**  
**The operand string is: ABC**  
**The parameter C-string is: DEF**  
**The operand string is less than the parameter C-string.**  
**The operand string is: AACAB**  
**The parameter string is: CAB**  
**The last three characters of the operand string**  
 **are equal to the parameter C-string.**  
**The operand string is: AACAB**  
**The parameter C-string is: ACAB**  
**The 3 characters from position 2 of the operand string are equal to**  
 **the first 3 characters of the parameter C-string.**    
##  \<a name="basic_string__const_iterator">\</a>  basic_string::const_iterator  
 A type that provides a random-access iterator that can access and read a **const** element in the string.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> cannot be used to modify the value of a character and is used to iterate through a string in a forward direction.  
  
### Example  
  See the example for [begin](#basic_string__begin) for an example of how to declare and use <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_string__const_pointer">\</a>  basic_string::const_pointer  
 A type that provides a pointer to a **const** element in a string.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for **allocator_type::const_pointer**.  
  
 For type **string**, it is equivalent to <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>*.  
  
 Pointers that are declared const must be initialized when they are declared. Const pointers always point to the same memory location and may point to constant or nonconstant data.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **The string pstr1a is: In Here.**  
**The C-string cstr1c is: Out There.**    
##  \<a name="basic_string__const_reference">\</a>  basic_string::const_reference  
 A type that provides a reference to a **const** element stored in a string for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 The type is a synonym for **allocator_type::const_reference**. For string **type**, it is equivalent to const **char&**.  
  
### Example  
  See the example for [at](#basic_string__at) for an example of how to declare and use <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_string__const_reverse_iterator">\</a>  basic_string::const_reverse_iterator  
 A type that provides a random-access iterator that can read any **const** element in the string.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> cannot modify the value of a character and is used to iterate through a string in reverse.  
  
### Example  
  See the example for [rbegin](#basic_string__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_string__copy">\</a>  basic_string::copy  
 Copies at most a specified number of characters from an indexed position in a source string to a target character array.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [basic_string::_Copy_s](#basic_string___copy_s) instead.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The target character array to which the elements are to be copied.  
  
 _ <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The number of characters to be copied, at most, from the source string.  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 The beginning position in the source string from which copies are to be made.  
  
### Return Value  
 The number of characters actually copied.  
  
### Remarks  
 A null character is not appended to the end of the copy.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello World**  
**The number of copied characters in array1 is: 11**  
**The copied characters array1 is: Hello World**  
**The number of copied characters in array2 is: 5**  
**The copied characters array2 is: World**    
##  \<a name="basic_string__crbegin">\</a>  basic_string::crbegin  
 Returns a const iterator that addresses the first element in a reversed string.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 A reverse iterator that points just beyond the end of the string. The position designates the beginning of the reverse string.  
  
##  \<a name="basic_string__crend">\</a>  basic_string::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed string.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse iterator that addresses the location succeeding the last element in a reversed string (the location that had preceded the first element in the unreversed string).  
  
### Remarks  
  
##  \<a name="basic_string___copy_s">\</a>  basic_string::_Copy_s  
 Copies at most a specified number of characters from an indexed position in a source string to a target character array.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 The target character array to which the elements are to be copied.  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>.  
  
 _ <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The number of characters to be copied, at most, from the source string.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The beginning position in the source string from which copies are to be made.  
  
### Return Value  
 The number of characters actually copied.  
  
### Remarks  
 A null character is not appended to the end of the copy.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello World**  
**The number of copied characters in array1 is: 11**  
**The copied characters array1 is: Hello World**  
**The number of copied characters in array2 is: 5**  
**The copied characters array2 is: World**    
##  \<a name="basic_string__data">\</a>  basic_string::data  
 Converts the contents of a string into an array of characters.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the first element of the array containing the contents of the string, or, for an empty array, a non-null pointer that cannot be dereferenced.  
  
### Remarks  
 Objects of type string belonging to the C++ template class basic_string \<char> are not necessarily null terminated. The return type for **data** is not a valid C-string, because no null character gets appended. The null character ' \0 ' is used as a special character in a C-string to mark the end of the string, but has no special meaning in an object of type string and may be a part of the string object just like any other character.  
  
 There is an automatic conversion from const **char\*** into strings, but the string class does not provide for automatic conversions from C-style strings to objects of type **basic_string \<char>**.  
  
 The returned string should not be modified, because this could invalidate the pointer to the string, or deleted, because the string has a limited lifetime and is owned by the class string.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  **The original string object str1 is: Hello world**  
**The length of the string object str1 = 11**  
**The modified string object ptr1 is: Hello world**  
**The length of character array str1 = 11**  
**The C-style string c_str1 is: Hello world**  
**The length of C-style string str1 = 11**    
##  \<a name="basic_string__difference_type">\</a>  basic_string::difference_type  
 A type that provides the difference between two iterators that refer to elements within the same string.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence.  
  
 For type **string**, it is equivalent to **ptrdiff_t**.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  **The original string str1 is: quintillion**  
**The first character i is at position: 2.**  
**The last character i is at position: 8.**  
**The difference is: 6.**    
##  \<a name="basic_string__empty">\</a>  basic_string::empty  
 Tests whether the string contains characters or not.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the string object contains no characters; **false** if it has at least one character.  
  
### Remarks  
 The member function is equivalent to [size](#basic_string__size) == 0.  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
##  \<a name="basic_string__end">\</a>  basic_string::end  
 Returns an iterator that addresses the location succeeding the last element in a string.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 Returns a random-access iterator that addresses the location succeeding the last element in a string.  
  
### Remarks  
 **end** is often used to test whether an iterator has reached the end of its string. The value returned by **end** should not be dereferenced.  
  
 If the return value of **end** is assigned to a <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>, the string object cannot be modified. If the return value of **end** is assigned to an **iterator**, the string object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  **The last character-letter of the string str1 is: t**  
**The full orginal string str1 is: No way out.**  
**The string is now: No way out.**  
**The last character-letter of the modified str1 is now: T**  
**The modified string str1 is now: No way ouT.**  
**The string str2 is empty.**    
##  \<a name="basic_string__erase">\</a>  basic_string::erase  
 Removes an element or a range of elements in a string from a specified position.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 An iterator addressing the position of the first element in the range to be erased.  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 An iterator addressing the position one past the last element in the range to be erased.  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 An iterator addressing the position of the element in the string to be erased.  
  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 The index of the first character in the string to be removed.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 The number of elements that will be removed if there are as many in the range of the string beginning with                                 *_Pos*.  
  
### Return Value  
 For the first two member functions, an iterator addressing the first character after the last character removed by the member function. For the third member function, a reference to the string object from which the elements have been erased.  
  
### Remarks  
 The third member function returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  **The original string object str1 is: Hello world.**  
**The first element after those removed is: d.**  
**The modified string object str1 is: Held.**  
**The original string object str2 is: Hello World.**  
**The first element after those removed is: W.**  
**The modified string object str2 is: HelloWorld.**  
**The original string object str3 is: Hello computer.**  
**The modified string object str3m is: Hello .**    
##  \<a name="basic_string__find">\</a>  basic_string::find  
 Searches a string in a forward direction for the first occurrence of a substring that matches a specified sequence of characters.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 Index of the position at which the search is to begin.  
  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 The C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 The string for which the member function is to search.  
  
### Return Value  
 The index of the first character of the substring searched for when successful; otherwise <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello Everyone**  
**The index of the 1st 'e' found after the 3rd position in str1 is: 8**  
**The Character 'x' was not found in str1.**  
**The original string str2 is: Let me make this perfectly clear.**  
**The index of the 1st element of 'perfect' after**  
 **the 5th position in str2 is: 17**  
**The substring 'imperfect' was not found in str2 .**  
**The original string str3 is: This is a sample string for this program**  
**The index of the 1st element of sample in str3 is: 10**  
**The index of the next occurrence of 'for' is in str3 begins at: 24**  
**The original string str4 is: clearly this perfectly unclear.**  
**The index of the 1st element of 'clear' after**  
 **the 5th position in str4 is: 25**  
**The index of the 1st element of 'clear' in str4 is: 0**    
##  \<a name="basic_string__find_first_not_of">\</a>  basic_string::find_first_not_of  
 Searches through a string for the first character that is not an element of a specified string.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 Index of the position at which the search is to begin.  
  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 The C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The string for which the member function is to search.  
  
### Return Value  
 The index of the first character of the substring searched for when successful; otherwise <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  **The original string str1 is: xddd-1234-abcd**  
**The index of the 1st 'd' found after the 3rd position in str1 is: 4**  
**The index of the 'non x' found in str1 is: 1**  
**The original string str2 is: BBB-1111**  
**Elements of the substring 'B1' were not**  
 **found in str2 after the 6th position.**  
**The index of the 1st element of 'B2' after**  
 **the 0th position in str2 is: 3**  
**The original string str3 is: 444-555-GGG**  
**The index of the 1st occurrence of an element in str3**  
 **other than one of the characters in '45G' is: 3**  
**The index of the second occurrence of an element of '45G' in str3**  
 **after the 0th position is: 7**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the 1st non occurrence of an element of 'ba3' in str4 after**  
 **the 5th position is: 5**  
**The index of the 1st non occurrence of an element of '12' in str4 after**  
 **the 0th position is: 2**    
##  \<a name="basic_string__find_first_of">\</a>  basic_string::find_first_of  
 Searches through a string for the first character that matches any element of a specified string.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 Index of the position at which the search is to begin.  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 The C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 The string for which the member function is to search.  
  
### Return Value  
 The index of the first character of the substring searched for when successful; otherwise <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  **The original string str1 is: abcd-1234-abcd-1234**  
**The index of the 1st 'd' found after the 5th position in str1 is: 13**  
**The character 'x' was not found in str1.**  
**The original string str2 is: ABCD-1234-ABCD-1234**  
**The index of the 1st occurrence of an element of 'B1' in str2 after**  
 **the 6th position is: 11**  
**The index of the 1st element of 'D2' after**  
 **the 0th position in str2 is: 3**  
**The original string str3 is: 123-abc-123-abc-456-EFG-456-EFG**  
**The index of the 1st occurrence of an element of '5G' in str3 after**  
 **the 0th position is: 17**  
**The index of the second occurrence of an element of '5G' in str3**  
 **after the 0th position is: 22**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the 1st occurrence of an element of 'ba3' in str4 after**  
 **the 5th position is: 9**  
**The index of the 1st occurrence of an element of 'a2' in str4 after**  
 **the 0th position is: 1**    
##  \<a name="basic_string__find_last_not_of">\</a>  basic_string::find_last_not_of  
 Searches through a string for the last character that is not any element of a specified string.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 Index of the position at which the search is to finish.  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 The C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 The string for which the member function is to search.  
  
### Return Value  
 The index of the first character of the substring searched for when successful; otherwise <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  **The original string str1 is: dddd-1dd4-abdd**  
**The index of the last non 'd'**  
 **found before the 7th position in str1 is: 5**  
**The index of the non 'd' found in str1 is: 11**  
**The original string str2 is: BBB-1111**  
**The index of the last occurrence of a element**  
 **not of 'B1' in str2 before the 6th position is: 3**  
**The elements of the substring 'B-1' were not found in str2 .**  
**The original string str3 is: 444-555-GGG**  
**The index of the last occurrence of an element in str3**  
 **other than one of the characters in '45G' is: 7**  
**The index of the penultimate occurrence of an element**  
 **not in '45G' in str3 is: 3**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the last occurrence of an element not**  
 **in 'b-a' in str4 before the 5th position is: 1**  
**The index of the last occurrence of an element not in '12'**  
 **in str4 before the end position is: 10**    
##  \<a name="basic_string__find_last_of">\</a>  basic_string::find_last_of  
 Searches through a string for the last character that matches any element of a specified string.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 Index of the position at which the search is to finish.  
  
 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 The C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 The string for which the member function is to search.  
  
### Return Value  
 The index of the last character of the substring searched for when successful; otherwise <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  **The original string str1 is: abcd-1234-abcd-1234**  
**The index of the last 'd' found before the 14th position in str1 is: 13**  
**The character 'x' was not found in str1.**  
**The original string str2 is: ABCD-1234-ABCD-1234**  
**The index of the last occurrence of an element of 'B1' in str2 before**  
 **the 12th position is: 11**  
**The index of the last element of 'D2' after**  
 **the 0th position in str2 is: 16**  
**The original string str3 is: 456-EFG-456-EFG**  
**The index of the last occurrence of an element of '5E' in str3 before**  
 **the 8th position is: 4**  
**The original string str4 is: 12-ab-12-ab**  
**The index of the last occurrence of an element of 'ba3' in str4 before**  
 **the 8th position is: 4**  
**The index of the last occurrence of an element of 'a2' in str4 before**  
 **the 0th position is: 9**    
##  \<a name="basic_string__front">\</a>  basic_string::front  
 Returns a reference to the first element in a string.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the first element of the string, which must be non-empty.  
  
### Remarks  
  
##  \<a name="basic_string__get_allocator">\</a>  basic_string::get_allocator  
 Returns a copy of the allocator object used to construct the string.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the string.  
  
### Remarks  
 The member function returns the stored allocator object.  
  
 Allocators for the string class specify how the class manages storage. The default allocators supplied with container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
##  \<a name="basic_string__insert">\</a>  basic_string::insert  
 Inserts an element or a number of elements or a range of elements into the string at a specified position.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 *_P0*  
 The index of the position behind the point of insertion the new characters.  
  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
 The C-string to be wholly or partly inserted into the string.  
  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 The number of characters to be inserted.  
  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 The string to be wholly or partly inserted into the target string.  
  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 The index of the part of the source string supplying the characters to be appended.  
  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 The character value of the elements to be inserted.  
  
 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 An iterator addressing the position behind which a character is to be inserted.  
  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the first element in the source range to be inserted.  
  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the source range to be inserted.  
  
### Return Value  
 Either a reference to the string object that is being assigned new characters by the member function or, in the case of individual character insertions, an iterator addressing the position of the character inserted, or none, depending on the particular member function.  
  
### Example  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  **The string with a C-string inserted at position 0 is: away.**  
**The string with a C-string inserted at the end is: GoodBye.**  
**The string with a string inserted at position 0 is: GoodBye.**  
**The string with part of a string inserted at position 4 is: Good Baby.**  
**The string with characters inserted is: The number is: 333.**  
**The string with a character inserted is: ABCDeFG**  
**The string with a character inserted from a range is: ABCDefgHIJ**  
**The string with a character inserted from a range is: ABCDeeeHIJ**    
##  \<a name="basic_string__iterator">\</a>  basic_string::iterator  
 A type that provides a random-access iterator that can access and read a **const** element in the string.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 A type **iterator** can be used to modify the value of a character and is used to iterate through a string in a forward direction.  
  
### Example  
  See the example for [begin](#basic_string__begin) for an example of how to declare and use **iterator**.  
  
##  \<a name="basic_string__length">\</a>  basic_string::length  
 Returns the current number of elements in a string.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Remarks  
 The member function is the same as [size](#basic_string__size).  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
##  \<a name="basic_string__max_size">\</a>  basic_string::max_size  
 Returns the maximum number of characters a string could contain.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of characters a string could contain.  
  
### Remarks  
 A exception of type [length_error Class](../vs140/length_error-class.md) is thrown when an operation produces a string with a length greater than the maximum size.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
##  \<a name="basic_string__npos">\</a>  basic_string::npos  
 An unsigned integral value initialized to –1 that indicates either "not found" or "all remaining characters" when a search function fails.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Remarks  
 When the return value is to be checked for the <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> value, it might not work unless the return value is of type [size_type](#basic_string__size_type) and not either <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [find](#basic_string__find) for an example of how to declare and use <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_string__operator_add_eq">\</a>  basic_string::operator+=  
 Appends characters to a string.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 The character to be appended.  
  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 The characters of the C-string to be appended.  
  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 The characters of the string to be appended.  
  
### Return Value  
 A reference to the string object that is being appended with the characters passed by the member function.  
  
### Remarks  
 Characters may be appended to a string using the <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> or the member functions [append](#basic_string__append) or [push_back](#basic_string__push_back). The <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> appends single-argument values while the multiple argument append member function allows a specific part of a string to be specified for adding.  
  
### Example  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello**  
**The string str1 appended with an exclamation is: Hello!**  
**The C-string cstr1b is: Out There**  
**Appending the C-string cstr1b to string str1 gives: Hello Out There.**  
**The string str2d is: Wide**   
**The appended string str1d is: Hello Wide .**  
**The doubly appended strig str1 is: Hello Wide World.**    
##  \<a name="basic_string__operator_eq">\</a>  basic_string::operator=  
 Assigns new character values to the contents of a string.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 The character value to be assigned.  
  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 A pointer to the characters of the C-string to be assigned to the target string.  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 The source string whose characters are to be assigned to the target string.  
  
### Return Value  
 A reference to the string object that is being assigned new characters by the member function.  
  
### Remarks  
 The strings may be assigned new character values. The new value may be either a string and C-string or a single character. The <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> may be used if the new value can be described by a single parameter, otherwise the member function [assign](#basic_string__assign), which has multiple parameters, may be used to specify which part of the string is to be assigned to a target string.  
  
### Example  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  **The string str1 assigned with the zero character is: 0**  
**The C-string cstr1b is: Out There.**  
**Assigning the C-string cstr1a to string str1 gives: Out There.**  
**The original string str1 is: Hello.**  
**The string str2c is: Wide.**  
**The string str1 newly assigned with string str2c is: Wide.**  
**The string str3c is: World.**  
**The string str1 reassigned with string str3c is: World.**    
##  \<a name="basic_string__operator_at">\</a>  basic_string::operator[]  
 Provides a reference to the character with a specified index in a string.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 The index of the position of the element to be referenced.  
  
### Return Value  
 A reference to the character of the string at the position specified by the parameter index.  
  
### Remarks  
 The first element of the string has an index of zero, and the following elements are indexed consecutively by the positive integers, so that a string of length                         *n* has an                         *n*th element indexed by the number                         *n* - 1.  
  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> is faster than the member function [at](#basic_string__at) for providing read and write access to the elements of a string.  
  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> does not check whether the index passed as a parameter is valid, but the member function **at** does and so should be used in the validity is not certain. An invalid index (an index less that zero or greater than or equal to the size of the string) passed to the member function **at** throws an [out_of_range Class](../vs140/out_of_range-class.md) exception. An invalid index passed to <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> results in undefined behavior, but the index equal to the length of the string is a valid index for const strings and the operator returns the null character when passed this index.  
  
 The reference returned may be invalidated by string reallocations or modifications for the non- **const** strings.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the string.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
##  \<a name="basic_string__pointer">\</a>  basic_string::pointer  
 A type that provides a pointer to a character element in a string or character array.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for **allocator_type::pointer**.  
  
 For type **string**, it is equivalent to **char\***.  
  
### Example  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  **The string pstr1a is: In Here.**  
**The C-string cstr1b is: Out There.**    
##  \<a name="basic_string__pop_back">\</a>  basic_string::pop_back  
 Erases the last element of the string.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Remarks  
 This member function effectively calls <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> to erase the last element of the sequence, which must be non-empty.  
  
##  \<a name="basic_string__push_back">\</a>  basic_string::push_back  
 Adds an element to the end of the string.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 The character to be added to the end of the string.  
  
### Remarks  
 The member function effectively calls [insert](#basic_string__insert)( [end](#basic_string__end), _                        *Ch* ).  
  
### Example  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  **The original string str1 is: abc**  
**The last character-letter of the modified str1 is now: c**  
**The modified string str1 is: abc**    
##  \<a name="basic_string__rbegin">\</a>  basic_string::rbegin  
 Returns an iterator to the first element in a reversed string.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Return Value  
 Returns a random-access iterator to the first element in a reversed string, addressing what would be the last element in the corresponding unreversed string.  
  
### Remarks  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> is used with a reversed string just as [begin](#basic_string__begin) is used with a string.  
  
 If the return value of <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>, the string object cannot be modified. If the return value of <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>, the string object can be modified.  
  
 <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> can be used to initialize an iteration through a string backwards.  
  
### Example  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  **The first character-letter of the reversed string str1 is: a**  
**The full reversed string str1 is:**  
 **ablE was I ere I saw elbA**  
**The first character-letter of the modified str1 is now: A**  
**The full modified reversed string str1 is now:**  
 **AblE was I ere I saw elbA**  
**The string str2 is empty.**    
##  \<a name="basic_string__reference">\</a>  basic_string::reference  
 A type that provides a reference to an element stored in a string.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Remarks  
 A type **reference** can be used to modify the value of an element.  
  
 The type is a synonym for **allocator_type::reference**.  
  
 For type **string**, it is equivalent to **chr&**.  
  
### Example  
  See the example for [at](#basic_string__at) for an example of how to declare and use **reference**.  
  
##  \<a name="basic_string__rend">\</a>  basic_string::rend  
 Returns an iterator that addresses the location succeeding the last element in a reversed string.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Return Value  
 A reverse random-access iterator that addresses the location succeeding the last element in a reversed string.  
  
### Remarks  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> is used with a reversed string just as [end](#basic_string__end) is used with a string.  
  
 If the return value of <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>, the string object cannot be modified. If the return value of <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>, the string object can be modified.  
  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> can be used to test whether a reverse iterator has reached the end of its string.  
  
 The value returned by <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  **The last character-letter of the reversed string str1 is: A**  
**The full reversed string str1 is:**  
 **ablE was I ere I saw elbA**  
**The last character-letter of the modified str1 is now: o**  
**The full modified reversed string str1 is now:**  
 **ablE was I ere I saw elbo**  
**The string str2 is empty.**    
##  \<a name="basic_string__replace">\</a>  basic_string::replace  
 Replaces elements in a string at a specified position with specified characters or characters copied from other ranges or strings or C-strings.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
 The string that is to be a source of characters for the operand string.  
  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 The index of the operand string at which the replacement begins.  
  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 The maximum number of characters to be replaced in the operand string.  
  
 *_Pos2*  
 The index of the parameter string at which the copying begins.  
  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The maximum number of characters to be used from the parameter C-string.  
  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 The C-string that is to be a source of characters for the operand string.  
  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 The character to be copied into the operand string.  
  
 *_First0*  
 An iterator addressing the first character to be removed in the operand string.  
  
 *_Last0*  
 An iterator addressing the last character to be removed in the operand string.  
  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 An iterator, const_pointer, or const_iterator addressing the first character to be copied in the parameter string.  
  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 An iterator, const_pointer, or const_iterator addressing the last character to be copied in the parameter string.  
  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 The number of times <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> is copied into the operand string.  
  
### Return Value  
 The operand string with the replacement made.  
  
### Example  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  **The operand string s1o is: AAAAAAAA**  
**The parameter string s1p is: BBB**  
**The parameter C-string cs1p is: CCC**  
**The result of s1o.replace ( 1 , 3 , s1p )**  
 **is the string: ABBBAAAA.**  
**The result of s1o.replace ( 5 , 3 , cs1p )**  
 **is the string: ABBBACCC.**  
**The operand string s2o is: AAAAAAAA**  
**The parameter string s1p is: BBB**  
**The parameter C-string cs2p is: CCC**  
**The result of s2o.replace (1, 3, s2p, 1, 2)**  
 **is the string: ABBAAAA.**  
**The result of s2o.replace (4 ,3 ,cs2p)**  
 **is the string: ABBAC.**  
**The operand string s3o is: AAAAAAAA**  
**The parameter character c1p is: C**  
**The result of s3o.replace(1, 3, 4, ch3p)**  
 **is the string: ACCCCAAAA.**  
**The operand string s4o is: AAAAAAAA**  
**The parameter string s4p is: BBB**  
**The parameter C-string cs4p is: CCC**  
**The result of s1o.replace (IterF0, IterL0, s4p)**  
 **is the string: BBBAAAAA.**  
**The result of s4o.replace (IterF0, IterL0, cs4p)**  
 **is the string: CCCAAAAA.**  
**The operand string s5o is: AAAAAAAF**  
**The parameter C-string cs5p is: CCCBB**  
**The result of s5o.replace (IterF1, IterL1, cs4p ,4)**  
 **is the string: CCCBAAAF.**  
**The operand string s6o is: AAAAAAAG**  
**The parameter character ch6p is: q**  
**The result of s6o.replace (IterF1, IterL1, 4, ch6p)**  
 **is the string: qqqqAAAAG.**  
**The operand string s7o is: OOOOOOO**  
**The parameter string s7p is: PPPP**  
**The result of s7o.replace (IterF3 ,IterL3 ,IterF4 ,IterL4)**  
 **is the string: OPPOOOO.**    
##  \<a name="basic_string__reserve">\</a>  basic_string::reserve  
 Sets the capacity of the string to a number at least as great as a specified number.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 The number of characters for which memory is being reserved.  
  
### Remarks  
 Having sufficient capacity is important because reallocations is a time-consuming process and invalidates all references, pointers, and iterators that refer to characters in a string.  
  
 The concept of capacity for objects of type strings is the same as for objects of type vector. Unlike vector, the member function **reserve** may be called to shrink the capacity of an object. The request is nonbinding and may or may not happen. As the default value for the parameter is zero, a call of **reserve** is a non-binding request to shrink the capacity of the string to fit the number of characters currently in the string. The capacity is never reduced below the current number of characters.  
  
 Calling <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> is the only possible way to shrink the capacity of a string. However, as noted above, this request is nonbinding and may not happen.  
  
### Example  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello world**  
**The current size of original string str1 is: 11.**  
**The capacity of original string str1 is: 15.**  
**The string str1with augmented capacity is: Hello world**  
**The current size of string str1 is: 11.**  
**The new capacity of string str1 is: 47.**  
**The string str1 with downsized capacity is: Hello world**  
**The current size of string str1 is: 11.**  
**The reduced capacity of string str1 is: 47.**    
##  \<a name="basic_string__resize">\</a>  basic_string::resize  
 Specifies a new size for a string, appending or erasing elements as required.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 The new size of the string.  
  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 The value that appended characters are initialized with if additional elements are required.  
  
### Remarks  
 If the resulting size exceeds the maximum number of characters, the form throws <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello world**  
**The current size of original string str1 is: 11.**  
**The capacity of original string str1 is: 15.**  
**The resized string str1 is: Hello world!!**  
**The current size of resized string str1 is: 13.**  
**The capacity of resized string str1 is: 15.**  
**The resized string str1 is: Hello world!!**   
**The current size of modified string str1 is: 33.**  
**The capacity of modified string str1 is: 47.**  
**The downsized string str1 is: Hello**  
**The current size of downsized string str1 is: 5.**  
**The capacity of downsized string str1 is: 47.**    
##  \<a name="basic_string__reverse_iterator">\</a>  basic_string::reverse_iterator  
 A type that provides a reference to an element stored in a string.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> can be used to modify the value of a character and is used to iterate through a string in reverse.  
  
### Example  
  See the example for [rbegin](#basic_string__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_string__rfind">\</a>  basic_string::rfind  
 Searches a string in a backward direction for the first occurrence of a substring that matches a specified sequence of characters.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 The character value for which the member function is to search.  
  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 Index of the position at which the search is to begin.  
  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 The C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 The number of characters, counting forward from the first character, in the C-string for which the member function is to search.  
  
 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 The string for which the member function is to search.  
  
### Return Value  
 The index of the last occurrence, when searched backwards, of the first character of the substring when successful; otherwise <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  **The original string str1 is: Hello Everyone**  
**The index of the 1st 'e' found before the 9th position in str1 is: 8**  
**The character 'x' was not found in str1.**  
**The original string str2 is: Let me make this perfectly clear.**  
**The index of the 1st element of 'perfect' before**  
 **the 30th position in str2 is: 17**  
**The substring 'imperfect' was not found in str2 .**  
**The original string str3 is: It is a nice day. I am happy.**  
**The index of the 1st element of 'nice' in str3 is: 8**  
**The index of the next occurrance of 'am' in str3 begins at: 20**  
**The original string str4 is: This perfectly unclear.**  
**The substring 'clear' was not found in str4 before the 15th position.**  
**The index of the 1st element of 'clear' in str4 is: 17**    
##  \<a name="basic_string__shrink_to_fit">\</a>  basic_string::shrink_to_fit  
 Discards the excess capacity of the string.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Remarks  
 This member function eliminates any unneeded storage in the container.  
  
##  \<a name="basic_string__size">\</a>  basic_string::size  
 Returns the current number of elements in a string.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Return Value  
 The length of the string.  
  
### Example  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
##  \<a name="basic_string__size_type">\</a>  basic_string::size_type  
 An unsigned integer type that can represent the number of elements and indices in a string.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Remarks  
 It is equivalent to **allocator_type::size_type**.  
  
 For type **string**, it is equivalent to **size_t**.  
  
### Example  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  **The current size of string str1 is: 11.**  
**The capacity of string str1 is: 15.**    
##  \<a name="basic_string__substr">\</a>  basic_string::substr  
 Copies a substring of at most some number of characters from a string beginning from a specified position.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
 An index locating the element at the position from which the copy of the string is made, with a default value of 0.  
  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 The number of characters that are to be copied if they are present.  
  
### Return Value  
 A substring object that is a copy of elements of the string operand beginning at the position specified by the first argument.  
  
### Example  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  **The original string str1 is:**   
 **Heterological paradoxes are persistent.**  
**The substring str1 copied is: logical**  
**The default substring str3 is:**   
 **Heterological paradoxes are persistent.**  
 **which is the entire original string.**    
##  \<a name="basic_string__swap">\</a>  basic_string::swap  
 Exchange the contents of two strings.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 The source string whose elements are to be exchanged with those in the destination string.  
  
### Remarks  
 If the strings being swapped have the same allocator object, the <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> member function:  
  
-   Occurs in constant time.  
  
-   Throws no exceptions.  
  
-   Invalidates no references, pointers, or iterators that designate elements in the two strings.  
  
 Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
### Example  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  **Before swapping string s1 and s2:**  
 **The basic_string s1 = Tweedledee.**  
 **The basic_string s2 = Tweedledum.**  
**After swapping string s1 and s2:**  
 **The basic_string s1 = Tweedledum.**  
 **The basic_string s2 = Tweedledee.**    
##  \<a name="basic_string__traits_type">\</a>  basic_string::traits_type  
 A type for the character traits of the elements stored in a string.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the second template parameter **Traits**.  
  
 For type **string**, it is equivalent to **char_traits\<char>**.  
  
### Example  
  See the example for [copy](../vs140/char_traits-struct.md#char_traits__copy) for an example of how to declare and use <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_string__value_type">\</a>  basic_string::value_type  
 A type that represents the type of characters stored in a string.  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Remarks  
 It is equivalent to **traits_type::char_type** and is equivalent to <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> for objects of type **string**.  
  
### Example  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  **The character ch1 is: G.**  
**The character ch2 is: H.**    
## See Also  
 [\<string>](../vs140/-string-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)