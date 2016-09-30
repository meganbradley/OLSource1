---
title: "codecvt Class"
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
  - "codecvt"
  - "std::codecvt"
  - "std.codecvt"
  - "xlocale/std::codecvt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "codecvt class"
ms.assetid: 37d3efa1-2b7f-42b6-b04f-7a972c8c2c86
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt Class
A template class that describes an object that can serve as a locale facet. It is able to control conversions between a sequence of values used to encode characters within the program and a sequence of values used to encode characters outside the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The type used within a program to encode characters.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A type used to encode characters outside a program.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A type that can be used to represent intermediate states of a conversion between internal and external types of character representations.  
  
## Remarks  
 The template class describes an object that can serve as a [locale facet](../vs140/locale-class.md#facet_class), to control conversions between a sequence of values of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and a sequence of values of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The class <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> characterizes the transformation -- and an object of class <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> stores any necessary state information during a conversion.  
  
 The internal encoding uses a representation with a fixed number of bytes per character, usually either type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 As with any locale facet, the static object <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 The template versions of [do_in](#codecvt__do_in) and [do_out](#codecvt__do_out) always return <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 The Standard C++ Library defines several explicit specializations:  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
 converts between <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> sequences.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
 converts between <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> sequences encoded as UTF-16 and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> sequences encoded as UTF-8.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 converts between <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> sequences encoded as UTF-32 (UCS-4) and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> sequences encoded as UTF-8.  
  
### Constructors  
  
|||  
|-|-|  
|[codecvt](#codecvt__codecvt)|The constructor for objects of class <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> that serves as a locale facet to handle conversions.|  
  
### Typedefs  
  
|||  
|-|-|  
|[extern_type](#codecvt__extern_type)|A character type that is used for external representations.|  
|[intern_type](#codecvt__intern_type)|A character type that is used for internal representations.|  
|[state_type](#codecvt__state_type)|A character type that is used to represent intermediate states during conversions between internal and external representations.|  
  
### Member Functions  
  
|||  
|-|-|  
|[always_noconv](#codecvt__always_noconv)|Tests whether no conversions need be done.|  
|[do_always_noconv](#codecvt__do_always_noconv)|A virtual function called to test whether no conversions need be done.|  
|[do_encoding](#codecvt__do_encoding)|A virtual function that tests if the encoding of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> stream is state dependent, whether the ratio between the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>s used and the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>s produced is constant, and, if so, determines the value of that ratio.|  
|[do_in](#codecvt__do_in)|A virtual function called to convert a sequence of internal <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>s to a sequence of external <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>s.|  
|[do_length](#codecvt__do_length)|A virtual function that determines how many <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>s from a given sequence of external <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>s produce not more than a given number of internal <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>s and returns that number of <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>s.|  
|[do_max_length](#codecvt__do_max_length)|A virtual function that returns the maximum number of external Bytes necessary to produce one internal <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.|  
|[do_out](#codecvt__do_out)|A virtual function called to convert a sequence of internal <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>s to a sequence of external Bytes.|  
|[do_unshift](#codecvt__do_unshift)|A virtual function called to provide the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>s needed in a state-dependent conversion to complete the last character in a sequence of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>s.|  
|[encoding](#codecvt__encoding)|Tests if the encoding of the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> stream is state dependent, whether the ratio between the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>s used and the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>s produced is constant, and, if so, determines the value of that ratio.|  
|[in](#codecvt__in)|Converts an external representation of a sequence of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>s to an internal representation of a sequence of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>s.|  
|[length](#codecvt__length)|Determines how many <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>s from a given sequence of external <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>s produce not more than a given number of internal <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>s and returns that number of <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>s.|  
|[max_length](#codecvt__max_length)|Returns the maximum number of external <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>s necessary to produce one internal <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.|  
|[out](#codecvt__out)|Converts a sequence of internal <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>s to a sequence of external <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>s.|  
|[unshift](#codecvt__unshift)|Provides the external <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>s needed in a state-dependent conversion to complete the last character in the sequence of <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>s.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="codecvt__always_noconv">\</a>  codecvt::always_noconv  
 Tests whether no conversions need be done.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A Boolean value that is **true** if no conversions need be done; **false** is at least one needs to be done.  
  
### Remarks  
 The member function returns [do_always_noconv](#codecvt__do_always_noconv).  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **No conversion is needed.**  
**At least one conversion is required.**    
##  \<a name="codecvt__codecvt">\</a>  codecvt::codecvt  
 The constructor for objects of class codecvt that serves as a locale facet to handle conversions.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 The constructor initializes its <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>)                        *.*  
  
##  \<a name="codecvt__do_always_noconv">\</a>  codecvt::do_always_noconv  
 A virtual function called to test whether no conversions need be done.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The protected virtual member function returns **true** only if every call to [do_in](#codecvt__do_in) or [do_out](#codecvt__do_out) returns **noconv**.  
  
 The template version always returns **true**.  
  
### Example  
  See the example for [always_noconv](#codecvt__always_noconv), which calls <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
##  \<a name="codecvt__do_encoding">\</a>  codecvt::do_encoding  
 A virtual function that tests if the encoding of the **Byte** stream is state dependent, whether the ratio between the **Byte**s used and the **CharType**s produced is constant and, if so, determines the value of that ratio.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The protected virtual member function returns:  
  
-   –1, if the encoding of sequences of type <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is state dependent.  
  
-   0, if the encoding involves sequences of varying lengths.  
  
-   *N*, if the encoding involves only sequences of length                                 *N*  
  
### Example  
  See the example for [encoding](#codecvt__encoding), which calls <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
##  \<a name="codecvt__do_in">\</a>  codecvt::do_in  
 A virtual function called to convert a sequence of external **Byte**s to a sequence of internal **CharType**s.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Pointer to the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Pointer to the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Pointer beyond the end of the converted sequence, to the first unconverted character.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Pointer to the **CharType** that comes after the last converted **CharType**, to the first unaltered character in the destination sequence.  
  
### Return Value  
 A return that indicates the success, partial success, or failure of the operation. The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough, for the conversion to succeed.  
  
### Remarks  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value as needed to reflect the current state of a successful conversion. Its stored value is otherwise unspecified.  
  
### Example  
  See the example for [in](#codecvt__in), which calls <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
##  \<a name="codecvt__do_length">\</a>  codecvt::do_length  
 A virtual function that determines how many **Byte**s from a given sequence of external **Byte**s produce not more than a given number of internal **CharType**s and returns that number of **Byte**s.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Pointer to the beginning of the external sequence.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Pointer to the end of the external sequence.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The maximum number of **Byte**s that can be returned by the member function.  
  
### Return Value  
 An integer that represents a count of the maximum number of conversions, not greater than <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, defined by the external source sequence at [ <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>).  
  
### Remarks  
 The protected virtual member function effectively calls <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>) for <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> (a copy of state), some buffer <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, and pointers <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
 It then returns <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> – **buf**. Thus, it counts the maximum number of conversions, not greater than <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, defined by the source sequence at [ <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>).  
  
 The template version always returns the lesser of <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [length](#codecvt__length), which calls  **do_length**.  
  
##  \<a name="codecvt__do_max_length">\</a>  codecvt::do_max_length  
 A virtual function that returns the maximum number of external **Byte**s necessary to produce one internal **CharType**.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of **Byte**s necessary to produce one **CharType**.  
  
### Remarks  
 The protected virtual member function returns the largest permissible value that can be returned by [do_length](#codecvt__do_length)( <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, 1) for arbitrary valid values of <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [max_length](#codecvt__max_length), which calls <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
##  \<a name="codecvt__do_out">\</a>  codecvt::do_out  
 A virtual function called to convert a sequence of internal **CharType**s to a sequence of external **Byte**s.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Pointer to the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Pointer to the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **CharType**, after the last **CharType** converted.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **Byte**, after the last **Byte** converted.  
  
### Return Value  
 The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough for the conversion to succeed.  
  
### Remarks  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value as needed to reflect the current state of a successful conversion. Its stored value is otherwise unspecified.  
  
### Example  
  See the example for [out](#codecvt__out), which calls <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
##  \<a name="codecvt__do_unshift">\</a>  codecvt::do_unshift  
 A virtual function called to provide the **Byte**s needed in a state-dependent conversion to complete the last character in a sequence of **Byte**s.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Pointer to the first position in the destination range.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Pointer to the last position in the destination range.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Pointer to the first unaltered element in the destination sequence.  
  
### Return Value  
 The function returns:  
  
-   **codecvt_base::error** if _                                *State* represents an invalid state  
  
-   <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> if the function performs no conversion  
  
-   **codecvt_base::ok** if the conversion succeeds  
  
-   **codecvt_base::partial** if the destination is not large enough for the conversion to succeed  
  
### Remarks  
 The protected virtual member function tries to convert the source element **CharType**(0) to a destination sequence that it stores within [ <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>), except for the terminating element **Byte**(0). It always stores in <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> a pointer to the first unaltered element in the destination sequence.  
  
 _                        *State* must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value as needed to reflect the current state of a successful conversion. Typically, converting the source element **CharType**(0) leaves the current state in the initial conversion state.  
  
### Example  
  See the example for [unshift](#codecvt__unshift), which calls <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
##  \<a name="codecvt__encoding">\</a>  codecvt::encoding  
 Tests if the encoding of the **Byte** stream is state dependent, whether the ratio between the **Byte**s used and the **CharType**s produced is constant, and, if so, determines the value of that ratio.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 If the return value is positive then that value is the constant number of **Byte** characters required to produce the **CharType** character.  
  
 The protected virtual member function returns:  
  
-   –1, if the encoding of sequences of type <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> is state dependent.  
  
-   0, if the encoding involves sequences of varying lengths.  
  
-   *N*, if the encoding involves only sequences of length                                 *N.*  
  
### Remarks  
 The member function returns [do_encoding](#codecvt__do_encoding).  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **1**  
**1**  
**1**    
##  \<a name="codecvt__extern_type">\</a>  codecvt::extern_type  
 A character type that is used for external representations.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Byte**.  
  
##  \<a name="codecvt__in">\</a>  codecvt::in  
 Converts an external representation of a sequence of **Byte**s to an internal representation of a sequence of **CharType**s.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Pointer to the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Pointer to the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Pointer beyond the end of the converted sequence to the first unconverted character.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Pointer to the **CharType** that comes after the last converted **Chartype** to the first unaltered character in the destination sequence.  
  
### Return Value  
 A return that indicates the success, partial success or failure of the operation. The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough for the conversion to succeed.  
  
### Remarks  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value, as needed, to reflect the current state of a successful conversion. After a partial conversion, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> must be set so as to allow the conversion to resume when new characters arrive.  
  
 The member function returns [do_in](#codecvt__do_in)( <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, _                        *First1, _Last1, _Next1, First2, _Llast2, _Next2*).  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **It worked! The converted string is:**  
 **[This is the string to be converted!]**    
##  \<a name="codecvt__intern_type">\</a>  codecvt::intern_type  
 A character type that is used for internal representations.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="codecvt__length">\</a>  codecvt::length  
 Determines how many **Byte**s from a given sequence of external **Byte**s produce not more than a given number of internal **CharType**s and returns that number of **Byte**s.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 Pointer to the beginning of the external sequence.  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Pointer to the end of the external sequence.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The maximum number of Bytes that can be returned by the member function.  
  
### Return Value  
 An integer that represents a count of the maximum number of conversions, not greater than <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>, defined by the external source sequence at [ <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>).  
  
### Remarks  
 The member function returns [do_length](#codecvt__do_length)(                        *_State, _First1*, <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The length of the string is: 50.**    
##  \<a name="codecvt__max_length">\</a>  codecvt::max_length  
 Returns the maximum number of external **Byte**s necessary to produce one internal **CharType**.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of **Byte**s necessary to produce one **CharType**.  
  
### Remarks  
 The member function returns [do_max_length](#codecvt__do_max_length).  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **1**    
##  \<a name="codecvt__out">\</a>  codecvt::out  
 Converts a sequence of internal **CharType**s to a sequence of external **Byte**s.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 Pointer to the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 Pointer to the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **CharType** after the last **CharType** converted.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Pointer to the beginning of the converted sequence.  
  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Pointer to the end of the converted sequence.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 Reference to a pointer to the first unconverted **Byte** after the last converted **Byte**.  
  
### Return Value  
 The member function returns [do_out](#codecvt__do_out)( <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>).  
  
### Remarks  
 For more information, see [codecvt::do_out](#codecvt__do_out).  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **It worked: The converted string is:**  
 **[This is the wchar_t string to be converted.]**    
##  \<a name="codecvt__state_type">\</a>  codecvt::state_type  
 A character type that is used to represent intermediate states during conversions between internal and external representations.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **StateType**.  
  
##  \<a name="codecvt__unshift">\</a>  codecvt::unshift  
 Provides the **Byte**s needed in a state-dependent conversion to complete the last character in a sequence of **Byte**s.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The conversion state that is maintained between calls to the member function.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 Pointer to the first position in the destination range.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 Pointer to the last position in the destination range.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 Pointer to the first unaltered element in the destination sequence.  
  
### Return Value  
 The function returns:  
  
-   **codecvt_base::error** if state represents an invalid state.  
  
-   <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the destination is not large enough for the conversion to succeed.  
  
### Remarks  
 The protected virtual member function tries to convert the source element **CharType**(0) to a destination sequence that it stores within [ <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>), except for the terminating element **Byte**(0). It always stores in <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> a pointer to the first unaltered element in the destination sequence.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value, as needed, to reflect the current state of a successful conversion. Typically, converting the source element **CharType**(0) leaves the current state in the initial conversion state.  
  
 The member function returns [do_unshift](#codecvt__do_unshift)( <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> ).  
  
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [Code Pages](../vs140/code-pages.md)   
 [Locale Names, Languages, and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)