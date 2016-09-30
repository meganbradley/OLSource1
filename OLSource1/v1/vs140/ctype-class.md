---
title: "ctype Class"
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
  - "ctype"
  - "std::ctype"
  - "std.ctype"
  - "CType"
  - "xlocale/std::ctype"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ctype class"
ms.assetid: 3627154c-49d9-47b5-b28f-5bbedee38e3b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype Class
A class that provides a facet that is used to classify characters, convert from upper and lower cases, and convert between the native character set and that set used by the locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The type used within a program to encode characters.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.** Classification criteria are provided a nested bitmask type in the base class ctype_base.  
  
 The Standard C++ Library defines two explicit specializations of this template class:  
  
-   [ctype](../vs140/ctype-char--class.md)< <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>>, an explicit specialization whose differences are described separately.  
  
-   **ctype**< <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>>, which treats elements as wide characters.  
  
 Other specializations of template class **ctype**\< **CharType**>:  
  
-   Convert a value ***ch*** of type **CharType** to a value of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> with the expression ( <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>) **ch**.  
  
-   Convert a value ***byte*** of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to a value of type **CharType** with the expression **CharType** ( **byte**).  
  
 All other operations are performed on <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> values in the same way as for the explicit specialization **ctype**< <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>>.  
  
### Constructors  
  
|||  
|-|-|  
|[ctype](#ctype__ctype)|Constructor for objects of class <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> that serve as locale facets for characters.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#ctype__char_type)|A type that describes a character used by a locale.|  
  
### Member Functions  
  
|||  
|-|-|  
|[do_is](#ctype__do_is)|A virtual function called to test whether a single character has a particular attribute, or classify the attributes of each character in a range and stores them in an array.|  
|[do_narrow](#ctype__do_narrow)|A virtual function called to convert a character of type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> used by a locale to the corresponding character of type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in the native character set.|  
|[do_scan_is](#ctype__do_scan_is)|A virtual function called to locate the first character in a range that matches a specified mask.|  
|[do_scan_not](#ctype__do_scan_not)|A virtual function called to locate the first character in a range that does not match a specified mask.|  
|[do_tolower](#ctype__do_tolower)|A virtual function called to convert a character or a range of characters to their lower case.|  
|[do_toupper](#ctype__do_toupper)|A virtual function called to convert a character or a range of characters to upper case.|  
|[do_widen](#ctype__do_widen)|A virtual function called to converts a character of type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> in the native character set to the corresponding character of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> used by a locale.|  
|[is](#ctype__is)|Tests whether a single character has a particular attribute, or classifies the attributes of each character in a range and stores them in an array.|  
|[narrow](#ctype__narrow)|Converts a character of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> used by a locale to the corresponding character of type char in the native character set.|  
|[scan_is](#ctype__scan_is)|Locates the first character in a range that matches a specified mask.|  
|[scan_not](#ctype__scan_not)|Locates the first character in a range that does not match a specified mask.|  
|[tolower](#ctype__tolower)|Converts a character or a range of characters to lower case.|  
|[toupper](#ctype__toupper)|Converts a character or a range of characters to upper case.|  
|[widen](#ctype__widen)|Converts a character of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in the native character set to the corresponding character of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> used by a locale.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="ctype__char_type">\</a>  ctype::char_type  
 A type that describes a character used by a locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
### Example  
  See the member function [widen](#ctype__widen) for an example that uses <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> as a return value.  
  
##  \<a name="ctype__ctype">\</a>  ctype::ctype  
 Constructor for objects of class ctype that serve as locale facets for characters.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>).  
  
##  \<a name="ctype__do_is">\</a>  ctype::do_is  
 A virtual function called to test whether a single character has a particular attribute, or classify the attributes of each character in a range and stores them in an array.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The mask value for which the character is to be tested.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The character whose attributes are to be tested.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A pointer to the first character in the range whose attributes are to be classified.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range whose attributes are to be classified.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A pointer to the beginning of the array where the mask values characterizing the attributes of each of the characters are to be stored.  
  
### Return Value  
 The first member function returns a Boolean value that is **true** if the character tested has the attribute described by the mask value; **false** if it fails to have the attribute.  
  
 The second member function returns an array containing the mask values characterizing the attributes of each of the characters in the range.  
  
### Remarks  
 The mask values classifying the attributes of the characters are provided by the class [ctype_base](../vs140/ctype_base-class.md), from which ctype derives. The first member function can accept expressions for its first parameter referred to as bitmasks and formed from the combination of mask values by the logical bitwise operators (&#124; , & , ^ , ~).  
  
### Example  
  See the example for [is](#ctype__is), which calls <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
##  \<a name="ctype__do_narrow">\</a>  ctype::do_narrow  
 A virtual function called to convert a character of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> used by a locale to the corresponding character of type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> in the native character set.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The character of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> used by the locale to be converted.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The default value to be assigned by the member function to characters of type <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> that do not have counterpart characters of type <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A const pointer to the first character of type <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
### Return Value  
 The first protected member function returns the native character of type char that corresponds to the parameter character of type <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> if no counterpart is defined.  
  
 The second protected member function returns a pointer to the destination range of native characters converted from characters of type <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
### Remarks  
 The second protected member template function stores in <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>] the value <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> [ <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>], <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>), for <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> in the interval [0, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>).  
  
### Example  
  See the example for [narrow](#ctype__narrow), which calls <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
##  \<a name="ctype__do_scan_is">\</a>  ctype::do_scan_is  
 A virtual function called to locate the first character in a range that matches a specified mask.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The mask value to be matched by a character.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A pointer to the first character in the range to be scanned.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
### Return Value  
 A pointer to the first character in a range that does match a specified mask. If no such value exists, the function returns <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
### Remarks  
 The protected member function returns the smallest pointer <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> in the range [ <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>) for which [do_is](#ctype__do_is)( <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, * <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>) is true.  
  
### Example  
  See the example for [scan_is](#ctype__scan_is), which calls <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
##  \<a name="ctype__do_scan_not">\</a>  ctype::do_scan_not  
 A virtual function called to locate the first character in a range that does not match a specified mask.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The mask value not to be matched by a character.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A pointer to the first character in the range to be scanned.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
### Return Value  
 A pointer to the first character in a range that doesn't match a specified mask. If no such value exists, the function returns <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Remarks  
 The protected member function returns the smallest pointer <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> in the range [ <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>) for which [do_is](#ctype__do_is)( <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, * <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>) is false.  
  
### Example  
  See the example for [scan_not](#ctype__scan_not), which calls <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
##  \<a name="ctype__do_tolower">\</a>  ctype::do_tolower  
 A virtual function called to convert a character or a range of characters to lower case.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The character to be converted to lower case.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
### Return Value  
 The first protected member function returns the lowercase form of the parameter <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. If no lowercase form exists, it returns <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. The second protected member function returns <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Remarks  
 The second protected member template function replaces each element <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> [ <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>], for <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> in the interval [0, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>), with <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> [ <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>]).  
  
### Example  
  See the example for [tolower](#ctype__tolower), which calls <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
##  \<a name="ctype__do_toupper">\</a>  ctype::do_toupper  
 A virtual function called to convert a character or a range of characters to upper case.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The character to be converted to upper case.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 A pointer to character immediately following the last character in the range of characters whose cases are to be converted.  
  
### Return Value  
 The first protected member function returns the uppercase form of the parameter <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>. If no uppercase form exists, it returns <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>. The second protected member function returns <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
### Remarks  
 The second protected member template function replaces each element <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> [ <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>], for <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> in the interval [0, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>), with <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> [ <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>]).  
  
### Example  
  See the example for [toupper](#ctype__toupper), which calls <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
##  \<a name="ctype__do_widen">\</a>  ctype::do_widen  
 A virtual function called to converts a character of type <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> in the native character set to the corresponding character of type <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> used by a locale.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The character of type <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> in the native character set to be converted.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A pointer to the first character of type <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
### Return Value  
 The first protected member function returns the character of type <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> that corresponds to the parameter character of native type <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
 The second protected member function returns a pointer to the destination range of characters of type <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> used by a locale converted from native characters of type <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Remarks  
 The second protected member template function stores in <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>] the value <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>]), for <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> in the interval [0, <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>).  
  
### Example  
  See the example for [widen](#ctype__widen), which calls <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
##  \<a name="ctype__is">\</a>  ctype::is  
 Tests whether a single character has a particular attribute or classifies the attributes of each character in a range and stores them in an array.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The mask value for which the character is to be tested.  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The character whose attributes are to be tested.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 A pointer to the first character in the range whose attributes are to be classified.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range whose attributes are to be classified.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 A pointer to the beginning of the array where the mask values characterizing the attributes of each of the characters are to be stored.  
  
### Return Value  
 The first member function returns <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> if the character tested has the attribute described by the mask value; <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> if it fails to have the attribute.  
  
 The second member function returns a pointer to the last character in the range whose attributes are to be classified.  
  
### Remarks  
 The mask values classifying the attributes of the characters are provided by the class [ctype_base Class](../vs140/ctype_base-class.md), from which ctype derives. The first member function can accept expressions for its first parameter referred to as bitmasks and formed from the combination of mask values by the logical bitwise operators (&#124; , & , ^ , ~).  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="ctype__narrow">\</a>  ctype::narrow  
 Converts characters of type <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> used by a locale to the corresponding characters of type <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> in the native character set.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The character of type <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> used by the locale to be converted.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 The default value to be assigned by the member function to characters of type <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> that do not have counterpart characters of type <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 A const pointer to the first character of type <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
### Return Value  
 The first member function returns the native character of type <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> that corresponds to the parameter character of type <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> if not counterpart is defined.  
  
 The second member function returns a pointer to the destination range of native characters converted from characters of type <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first member function returns [do_narrow](#ctype__do_narrow)( <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>). The second member function returns [do_narrow](#ctype__do_narrow) ( <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>). Only the basic source characters are guaranteed to have a unique inverse image <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> under <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. For these basic source characters, the following invariant holds: <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> ( [widen](#ctype__widen) ( **c** ), 0 ) == **c**.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **Xhello everyone**    
##  \<a name="ctype__scan_is">\</a>  ctype::scan_is  
 Locates the first character in a range that matches a specified mask.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The mask value to be matched by a character.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 A pointer to the first character in the range to be scanned.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
### Return Value  
 A pointer to the first character in a range that does match a specified mask. If no such value exists, the function returns <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
  
### Remarks  
 The member function returns [do_scan_is](#ctype__do_scan_is)( <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The first punctuation is "," at position: 5**    
##  \<a name="ctype__scan_not">\</a>  ctype::scan_not  
 Locates the first character in a range that does not match a specified mask.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 The mask value not to be matched by a character.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 A pointer to the first character in the range to be scanned.  
  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
### Return Value  
 A pointer to the first character in a range that does not match a specified mask. If no such value exists, the function returns <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function returns [do_scan_not](#ctype__do_scan_not)( <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **First nonalpha character is "," at position: 5**    
##  \<a name="ctype__tolower">\</a>  ctype::tolower  
 Converts a character or a range of characters to lower case.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The character to be converted to lower case.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
### Return Value  
 The first member function returns the lowercase form of the parameter <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>. If no lowercase form exists, it returns <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.  
  
 The second member function returns <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first member function returns [do_tolower](#ctype__do_tolower)( <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>). The second member function returns [do_tolower](#ctype__do_tolower)( <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **The lowercase string is: hello, my name is john**    
##  \<a name="ctype__toupper">\</a>  ctype::toupper  
 Converts a character or a range of characters to upper case.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 The character to be converted to uppercase.  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
### Return Value  
 The first member function returns the uppercase form of the parameter <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>. If no uppercase form exists, it returns <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 The second member function returns <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first member function returns [do_toupper](#ctype__do_toupper)( <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>). The second member function returns [do_toupper](#ctype__do_toupper)( <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **The uppercase string is: HELLO, MY NAME IS JOHN**    
##  \<a name="ctype__widen">\</a>  ctype::widen  
 Converts a character of type <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> in the native character set to the corresponding character of type <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> used by a locale.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 The character of type char in the native character set to be converted.  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 A pointer to the first character of type <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
### Return Value  
 The first member function returns the character of type <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> that corresponds to the parameter character of native type <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.  
  
 The second member function returns a pointer to the destination range of characters of type <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> used by a locale converted from native characters of type <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first member function returns [do_widen](#ctype__do_widen)( <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>). The second member function returns [do_widen](#ctype__do_widen)( <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **Hello everyone!**  
**Hello everyone!**    
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)