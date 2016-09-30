---
title: "num_get Class"
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
  - "num_get"
  - "std::num_get"
  - "std.num_get"
  - "xlocnum/std::num_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "num_get class"
ms.assetid: 9933735d-3918-4b17-abad-5fca2adc62d7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# num_get Class
A template class that describes an object that can serve as a locale facet to control conversions of sequences of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to numeric values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The type used within a program to encode characters in a locale.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type of iterator from which the numeric get functions read their input.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.**  
  
### Constructors  
  
|||  
|-|-|  
|[num_get](#num_get__num_get)|The constructor for objects of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that are used to extract numerical values from sequences.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#num_get__char_type)|A type that is used to describe a character used by a locale.|  
|[iter_type](#num_get__iter_type)|A type that describes an input iterator.|  
  
### Member Functions  
  
|||  
|-|-|  
|[do_get](#num_get__do_get)|A virtual function that is called to extracts a numerical or Boolean value from a character sequence.|  
|[get](#num_get__get)|Extracts a numerical or Boolean value from a character sequence.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="num_get__char_type">\</a>  num_get::char_type  
 A type that is used to describe a character used by a locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="num_get__do_get">\</a>  num_get::do_get  
 A virtual function that is called to extracts a numerical or Boolean value from a character sequence.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The beginning of the range of characters from which to read the number.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The end of the range of characters from which to read the number.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The [ios_base](../vs140/ios_base-class.md) whose flags are used by the conversion.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The state to which failbit (see [ios_base::iostate](../vs140/ios_base-class.md#ios_base__iostate)) is added upon failure.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The value that was read.  
  
### Return Value  
 The iterator after the value has been read.  
  
### Remarks  
 The first virtual protected member function,  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 matches sequential elements beginning at <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> in the sequence <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> until it has recognized a complete, nonempty integer input field. If successful, it converts this field to its equivalent value as type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and stores the result in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond the numeric input field. Otherwise, the function stores nothing in <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond any prefix of a valid integer input field. In either case, if the return value equals <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 The integer input field is converted by the same rules used by the scan functions for matching and converting a series of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> elements from a file. (Each such <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> element is assumed to map to an equivalent element of type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> by a simple, one-to-one, mapping.) The equivalent scan conversion specification is determined as follows:  
  
 If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>[flags](../vs140/ios_base-class.md#ios_base__flags)<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>[oct](../vs140/-ios--functions.md#oct), the conversion specification is <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>[hex](../vs140/-ios--functions.md#hex), the conversion specification is <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, the conversion specification is <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 Otherwise, the conversion specification is <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 The format of an integer input field is further determined by the [locale facet](../vs140/locale-class.md#facet_class)<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returned by the call [use_facet](../vs140/-locale--functions.md#use_facet) <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>[numpunct](../vs140/numpunct-class.md)<CodeContentPlaceHolder>52\</CodeContentPlaceHolder> [getloc](../vs140/ios_base-class.md#ios_base__getloc)<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. Specifically:  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> [grouping](../vs140/numpunct-class.md#numpunct__grouping) <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> determines how digits are grouped to the left of any decimal point  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> [thousands_sep](../vs140/numpunct-class.md#numpunct__thousands_sep) <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> determines the sequence that separates groups of digits to the left of any decimal point.  
  
 If no instances of <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> occur in the numeric input field, no grouping constraint is imposed. Otherwise, any grouping constraints imposed by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> are enforced and separators are removed before the scan conversion occurs.  
  
 The fourth virtual protected member function:  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it replaces a conversion specification of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. If successful it converts the numeric input field to a value of type <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 The fifth virtual protected member function:  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it replaces a conversion specification of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. If successful it converts the numeric input field to a value of type <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
 The sixth virtual protected member function:  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it replaces a conversion specification of <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. If successful it converts the numeric input field to a value of type <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
 The seventh virtual protected member function:  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty floating-point input field. <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>[decimal_point](../vs140/numpunct-class.md#numpunct__decimal_point)<CodeContentPlaceHolder>101\</CodeContentPlaceHolder> determines the sequence that separates the integer digits from the fraction digits. The equivalent scan conversion specifier is <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
 The eighth virtual protected member function:  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty floating-point input field. <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>[decimal_point](../vs140/numpunct-class.md#numpunct__decimal_point)<CodeContentPlaceHolder>111\</CodeContentPlaceHolder> determines the sequence that separates the integer digits from the fraction digits. The equivalent scan conversion specifier is <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
 The ninth virtual protected member function:  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
 behaves the same as the eighth, except that the equivalent scan conversion specifier is <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
 The ninth virtual protected member function:  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
  
 behaves the same the first, except that the equivalent scan conversion specifier is <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
 The last (eleventh) virtual protected member function:  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty Boolean input field. If successful it converts the Boolean input field to a value of type <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
 A Boolean input field takes one of two forms. If <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>[boolalpha](../vs140/-ios--functions.md#boolalpha) is false, it is the same as an integer input field, except that the converted value must be either 0 (for false) or 1 (for true). Otherwise, the sequence must match either <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>[falsename](../vs140/numpunct-class.md#numpunct__falsename)<CodeContentPlaceHolder>140\</CodeContentPlaceHolder> (for false), or <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>[truename](../vs140/numpunct-class.md#numpunct__truename)<CodeContentPlaceHolder>142\</CodeContentPlaceHolder> (for true).  
  
### Example  
  See the example for [get](#num_get__get), where the virtual member function is called by <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
##  \<a name="num_get__get">\</a>  num_get::get  
 Extracts a numerical or Boolean value from a character sequence.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The beginning of the range of characters from which to read the number.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The end of the range of characters from which to read the number.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The [ios_base](../vs140/ios_base-class.md) whose flags are used by the conversion.  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The state to which failbit (see [ios_base::iostate](../vs140/ios_base-class.md#ios_base__iostate)) is added upon failure.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The value that was read.  
  
### Return Value  
 The iterator after the value has been read.  
  
### Remarks  
 All member functions return [do_get](#num_get__do_get)( <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>).  
  
 The first virtual protected member function tries to match sequential elements beginning at first in the sequence [ <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty integer input field. If successful, it converts this field to its equivalent value as type **long** and stores the result in <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond the numeric input field. Otherwise, the function stores nothing in <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> in _                        *State*. It returns an iterator designating the first element beyond any prefix of a valid integer input field. In either case, if the return value equals **last**, the function sets <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 The integer input field is converted by the same rules used by the scan functions for matching and converting a series of <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> elements from a file. Each such <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> element is assumed to map to an equivalent element of type **CharType** by a simple, one-to-one mapping. The equivalent scan conversion specification is determined as follows:  
  
-   If **iosbase**. [flags](../vs140/ios_base-class.md#ios_base__flags) & <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>[oct](../vs140/-ios--functions.md#oct), the conversion specification is **lo**.  
  
-   If **iosbase.flags** & **ios_base::basefield** == <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>[hex](../vs140/-ios--functions.md#hex), the conversion specification is **lx**.  
  
-   If **iosbase.flags** & **ios_base::basefield** == 0, the conversion specification is <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
-   Otherwise, the conversion specification is **ld**.  
  
 The format of an integer input field is further determined by the [locale facet](../vs140/locale-class.md#facet_class)**fac** returned by the call [use_facet](../vs140/-locale--functions.md#use_facet) < [numpunct](../vs140/numpunct-class.md)\< **Elem**>( **iosbase**. [getloc](../vs140/ios_base-class.md#ios_base__getloc)). Specifically:  
  
-   **fac**. [grouping](../vs140/numpunct-class.md#numpunct__grouping) determines how digits are grouped to the left of any decimal point.  
  
-   **fac**. [thousands_sep](../vs140/numpunct-class.md#numpunct__thousands_sep) determines the sequence that separates groups of digits to the left of any decimal point.  
  
 If no instances of **fac**. <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> occur in the numeric input field, no grouping constraint is imposed. Otherwise, any grouping constraints imposed by **fac**. **grouping** is enforced and separators are removed before the scan conversion occurs.  
  
 The second virtual protected member function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 behaves the same as the first, except that it replaces a conversion specification of **ld** with **lu**. If successful, it converts the numeric input field to a value of type <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
 The third virtual protected member function:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 behaves the same as the first, except that it tries to match a complete, nonempty floating-point input field. **fac**. [decimal_point](../vs140/numpunct-class.md#numpunct__decimal_point) determines the sequence that separates the integer digits from the fraction digits. The equivalent scan conversion specifier is **lf**.  
  
 The fourth virtual protected member function:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 behaves the same the third, except that the equivalent scan conversion specifier is **Lf**.  
  
 The fifth virtual protected member function:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 behaves the same the first, except that the equivalent scan conversion specifier is **p**.  
  
 The sixth virtual protected member function:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 behaves the same as the first, except that it tries to match a complete, nonempty boolean input field. If successful it converts the Boolean input field to a value of type <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
 A boolean input field takes one of two forms. If **iosbase**. **flags** & <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>[boolalpha](../vs140/-ios--functions.md#boolalpha) is **false**, it is the same as an integer input field, except that the converted value must be either 0 (for **false**) or 1 (for **true**). Otherwise, the sequence must match either **fac**. [falsename](../vs140/numpunct-class.md#numpunct__falsename) (for **false**), or **fac**. [truename](../vs140/numpunct-class.md#numpunct__truename) (for **true**).  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="num_get__iter_type">\</a>  num_get::iter_type  
 A type that describes an input iterator.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **InputIterator**.  
  
##  \<a name="num_get__num_get">\</a>  num_get::num_get  
 The constructor for objects of type <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> that are used to extract numerical values from sequences.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>).  
  
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [facet Class](../vs140/locale-class.md#facet_class)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)