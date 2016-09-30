---
title: "time_get Class"
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
  - "std.time_get"
  - "xloctime/std::time_get"
  - "time_get"
  - "std::time_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "time_get class"
ms.assetid: 869d5f5b-dbab-4628-8333-bdea7e272023
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get Class
The template class describes an object that can serve as a locale facet to control conversions of sequences of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to time values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The type used within a program to encode characters.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The iterator from which the time values are read.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.**  
  
### Constructors  
  
|||  
|-|-|  
|[time_get](#time_get__time_get)|The constructor for objects of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#time_get__char_type)|A type that is used to describe a character used by a locale.|  
|[iter_type](#time_get__iter_type)|A type that describes an input iterator.|  
  
### Member Functions  
  
|||  
|-|-|  
|[date_order](#time_get__date_order)|Returns the date order used by a facet.|  
|[do_date_order](#time_get__do_date_order)|A protected virtual member function that is called to return the date order used by a facet.|  
|[do_get](#time_get__do_get)|Reads and converts character data to a time value.|  
|[do_get_date](#time_get__do_get_date)|A protected virtual member function that is called to parse a string as the date produced by the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> specifier for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|  
|[do_get_monthname](#time_get__do_get_monthname)|A protected virtual member function that is called to parse a string as the name of the month.|  
|[do_get_time](#time_get__do_get_time)|A protected virtual member function that is called to parse a string as the date produced by the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> specifier for <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
|[do_get_weekday](#time_get__do_get_weekday)|A protected virtual member function that is called to parse a string as the name of the day of the week.|  
|[do_get_year](#time_get__do_get_year)|A protected virtual member function that is called to parses a string as the name of the year.|  
|[get](#time_get__get)|Reads from a source of character data and converts that data to a time that is stored in a time struct.|  
|[get_date](#time_get__get_date)|Parses a string as the date produced by the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> specifier for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|[get_monthname](#time_get__get_monthname)|Parses a string as the name of the month.|  
|[get_time](#time_get__get_time)|Parses a string as the date produced by the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> specifier for <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
|[get_weekday](#time_get__get_weekday)|Parses a string as the name of the day of the week.|  
|[get_year](#time_get__get_year)|Parses a string as the name of the year.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="time_get__char_type">\</a>  time_get::char_type  
 A type that is used to describe a character used by a locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="time_get__date_order">\</a>  time_get::date_order  
 Returns the date order used by a facet.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The date order used by a facet.  
  
### Remarks  
 The member function returns [do_date_order](#time_get__do_date_order).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **C(month, day, year)**  
**German_Germany.1252(day, month, year)**  
**English_United Kingdom.1252(day, month, year)**    
##  \<a name="time_get__do_date_order">\</a>  time_get::do_date_order  
 A protected virtual member function that is called to return the date order used by a facet.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The date order used by a facet.  
  
### Remarks  
 The virtual protected member function returns a value of type **time_base::dateorder**, which describes the order in which date components are matched by [do_get_date](#time_get__do_get_date). In this implementation, the value is **time_base::mdy**, corresponding to dates of the form December 2, 1979.  
  
### Example  
  See the example for [date_order](#time_get__date_order), which calls <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
##  \<a name="time_get__do_get">\</a>  time_get::do_get  
 Reads and converts character data to a time value. Accepts one conversion specifier and modifier.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An Input iterator that indicates the start of the sequence to convert.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 An Input iterator that indicates the end of the sequence.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A stream object.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A field in _Iosbase where appropriate bitmask elements are set to indicate errors.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to the time structure where the time is to be stored.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A conversion specifier character.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 An optional modifier character.  
  
### Return Value  
 Returns an iterator that designates the first unconverted element. A conversion failure sets <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
### Remarks  
 The virtual member function converts and skips one or more input elements in the range <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to determine the values stored in one or more members of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. A conversion failure sets <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. Otherwise, the function returns an iterator designating the first unconverted element.  
  
 The conversion specifiers are:  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> -- behaves the same as [get_weekday](#time_get__get_weekday).  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> -- behaves the same as [get_monthname](#time_get__get_monthname).  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 99] to the value <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and stores <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> -- converts a decimal input field in the range [1, 31] and stores its value in <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 23] and stores its value in <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 11] and stores its value in <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> -- converts a decimal input field in the range [1, 366] and stores its value in <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> -- converts a decimal input field in the range [1, 12] to the value <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and stores <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> in and stores its value in <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 59] and stores its value in <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> -- converts "AM" or "am" to zero and "PM" or "PM" to 12 and adds this value to <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 59] and stores its value in <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 53] and stores its value in <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 6] and stores its value in <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 53] and stores its value in <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 99] to the value <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> and stores <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> -- behaves the same as [get_year](#time_get__get_year).  
  
 Any other conversion specifier sets <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> and returns. In this implementation, any modifier has no effect.  
  
##  \<a name="time_get__do_get_date">\</a>  time_get::do_get_date  
 A protected virtual member function that is called to parse a string as the date produced by the                 *x* specifier for <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 A pointer to where the date information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The virtual protected member function tries to match sequential elements beginning at first in the sequence [ <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty date input field. If successful, it converts this field to its equivalent value as the components **tm::tm_mon**, **tm::tm_day**, and **tm::tm_year**, and stores the results in _                        *Pt*-> **tm_mon**, \_                        *Pt*-> **tm_day** and \_                        *Pt*-> **tm_year**, respectively. It returns an iterator designating the first element beyond the date input field. Otherwise, the function sets <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>**::failbit** in <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond any prefix of a valid date input field. In either case, if the return value equals <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
 The format for the date input field is locale dependent. For the default locale, the date input field has the form MMM DD, YYYY, where:  
  
-   MMM is matched by calling [get_monthname](#time_get__get_monthname), giving the month.  
  
-   DD is a sequence of decimal digits whose corresponding numeric value must be in the range [1, 31], giving the day of the month.  
  
-   YYYY is matched by calling [get_year](#time_get__get_year), giving the year.  
  
 The literal spaces and commas must match corresponding elements in the input sequence.  
  
### Example  
  See the example for [get_date](#time_get__get_date), which calls <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
##  \<a name="time_get__do_get_monthname">\</a>  time_get::do_get_monthname  
 A protected virtual member function that is called to parse a string as the name of the month.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Unused.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 An output parameter that sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 A pointer to where the month information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The virtual protected member function tries to match sequential elements beginning at first in the sequence [ <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty month input field. If successful, it converts this field to its equivalent value as the component **tm::tm_mon**, and stores the result in _                        *Pt*-> **tm_mon**. It returns an iterator designating the first element beyond the month input field. Otherwise, the function sets <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> in \_                        *State*. It returns an iterator designating the first element beyond any prefix of a valid month input field. In either case, if the return value equals <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> in \_                        *State*.  
  
 The month input field is a sequence that matches the longest of a set of locale-specific sequences, such as Jan, January, Feb, February, and so on. The converted value is the number of months since January.  
  
### Example  
  See the example for [get_monthname](#time_get__get_monthname), which calls <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
##  \<a name="time_get__do_get_time">\</a>  time_get::do_get_time  
 A protected virtual member function that is called to parse a string as the date produced by the                 *X* specifier for <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Unused.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 A pointer to where the date information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The virtual protected member function tries to match sequential elements beginning at first in the sequence [ <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty time input field. If successful, it converts this field to its equivalent value as the components **tm::tm_hour**, **tm::tm_min**, and **tm::tm_sec**, and stores the results in _                        *Pt*-> **tm_hour**, \_                        *Pt*-> **tm_min**, and \_                        *Pt*-> **tm_sec**, respectively. It returns an iterator designating the first element beyond the time input field. Otherwise, the function sets <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> in \_                        *State*. It returns an iterator designating the first element beyond any prefix of a valid time input field. In either case, if the return value equals <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> in \_                        *State*.  
  
 In this implementation, the time input field has the form HH:MM:SS, where:  
  
-   HH is a sequence of decimal digits whose corresponding numeric value must be in the range [0, 24), giving the hour of the day.  
  
-   MM is a sequence of decimal digits whose corresponding numeric value must be in the range [0, 60), giving the minutes past the hour.  
  
-   SS is a sequence of decimal digits whose corresponding numeric value must be in the range [0, 60), giving the seconds past the minute.  
  
 The literal colons must match corresponding elements in the input sequence.  
  
### Example  
  See the example for [get_time](#time_get__get_time), which calls <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>.  
  
##  \<a name="time_get__do_get_weekday">\</a>  time_get::do_get_weekday  
 A protected virtual member function that is called to parse a string as the name of the day of the week.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 A pointer to where the weekday information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The virtual protected member function tries to match sequential elements beginning at <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> in the sequence [ <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty weekday input field. If successful, it converts this field to its equivalent value as the component **tm::tm_wday**, and stores the result in _                        *Pt*-> **tm_wday**. It returns an iterator designating the first element beyond the weekday input field. Otherwise, the function sets <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> in \_                        *State*. It returns an iterator designating the first element beyond any prefix of a valid weekday input field. In either case, if the return value equals <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> in \_                        *State*.  
  
 The weekday input field is a sequence that matches the longest of a set of locale-specific sequences, such as Sun, Sunday, Mon, Monday, and so on. The converted value is the number of days since Sunday.  
  
### Example  
  See the example for [get_weekday](#time_get__get_weekday), which calls <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
##  \<a name="time_get__do_get_year">\</a>  time_get::do_get_year  
 A protected virtual member function that is called to parses a string as the name of the year.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 A pointer to where the year information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The virtual protected member function tries to match sequential elements beginning at <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> in the sequence [ <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>) until it has recognized a complete, nonempty year input field. If successful, it converts this field to its equivalent value as the component **tm::tm_year**, and stores the result in _                        *Pt*-> **tm_year**. It returns an iterator designating the first element beyond the year input field. Otherwise, the function sets <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> in \_                        *State*. It returns an iterator designating the first element beyond any prefix of a valid year input field. In either case, if the return value equals <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> in \_                        *State*.  
  
 The year input field is a sequence of decimal digits whose corresponding numeric value must be in the range [1900, 2036). The stored value is this value minus 1900. In this implementation, values in the range [69, 136) represent the range of years [1969, 2036). Values in the range [0, 69) are also permissible, but may represent either the range of years [1900, 1969) or [2000, 2069), depending on the specific translation environment.  
  
### Example  
  See the example for [get_year](#time_get__get_year), which calls <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
##  \<a name="time_get__get">\</a>  time_get::get  
 Reads from a source of character data and converts that data to a time that is stored in a time struct. The first function accepts one conversion specifier and modifier, the second accepts several.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Input iterator that indicates where the sequence to be converted starts.  
  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Input iterator that indicates the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The stream.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 The appropriate bitmask elements are set for the stream state to indicate errors.  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 Pointer to the time structure where the time is to be stored.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 A conversion specifier character.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 An optional modifier character.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 Points to where the format directives start.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 Points to the end of the format directives.  
  
### Return Value  
 Returns an iterator to the first character after the data that was used to assign the time struct *_Pt.  
  
### Remarks  
 The first member function returns <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>.  
  
 The second member function calls <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> under the control of the format delimited by <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>. It treats the format as a sequence of fields, each of which determines the conversion of zero or more input elements delimited by <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>. It returns an iterator designating the first unconverted element. There are three kinds of fields:  
  
 A per cent (%) in the format, followed by an optional modifier <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> in the set [EOQ#], followed by a conversion specifier <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>, replaces <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> with the value returned by <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>. A conversion failure sets <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> and returns.  
  
 A whitespace element in the format skips past zero or more input whitespace elements.  
  
 Any other element in the format must match the next input element, which is skipped. A match failure sets <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> and returns.  
  
##  \<a name="time_get__get_date">\</a>  time_get::get_date  
 Parses a string as the date produced by the                 *x* specifier for <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 A pointer to where the date information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The member function returns [do_get_date](#time_get__do_get_date)( <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>).  
  
 Note that months are counted from 0 to 11.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **time_get(July 4, 2000) =**  
**tm_sec: 0**  
**tm_min: 0**  
**tm_hour: 0**  
**tm_mday: 4**  
**tm_mon: 6**  
**tm_year: 100**  
**tm_wday: 0**  
**tm_yday: 0**  
**tm_isdst: 0**    
##  \<a name="time_get__get_monthname">\</a>  time_get::get_monthname  
 Parses a string as the name of the month.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Unused.  
  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 An output parameter that sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 A pointer to where the month information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The member function returns [do_get_monthname](#time_get__do_get_monthname)( <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **time_get(juillet) =**  
**tm_sec: 0**  
**tm_min: 0**  
**tm_hour: 0**  
**tm_mday: 0**  
**tm_mon: 6**  
**tm_year: 0**  
**tm_wday: 0**  
**tm_yday: 0**  
**tm_isdst: 0**    
##  \<a name="time_get__get_time">\</a>  time_get::get_time  
 Parses a string as the date produced by the                 *X* specifier for <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 Unused.  
  
 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 A pointer to where the date information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The member function returns [do_get_time](#time_get__do_get_time)( <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **time_get::get_time(11:13:20) =**  
**tm_sec: 20**  
**tm_min: 13**  
**tm_hour: 11**    
##  \<a name="time_get__get_weekday">\</a>  time_get::get_weekday  
 Parses a string as the name of the day of the week.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 A pointer to where the weekday information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The member function returns [do_get_weekday](#time_get__do_get_weekday)( <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **time_get::get_time(mercredi) =**  
**tm_wday: 3**    
##  \<a name="time_get__get_year">\</a>  time_get::get_year  
 Parses a string as the name of the year.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 A pointer to where the year information is to be stored.  
  
### Return Value  
 An input iterator addressing the first element beyond the input field.  
  
### Remarks  
 The member function returns [do_get_year](#time_get__do_get_year)( <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **time_get::get_year(1928) =**  
**tm_year: 28**    
##  \<a name="time_get__iter_type">\</a>  time_get::iter_type  
 A type that describes an input iterator.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **InputIterator**.  
  
##  \<a name="time_get__time_get">\</a>  time_get::time_get  
 The constructor for objects of type <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 No direct examples are possible, because the destructor is protected.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>).  
  
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [time_base Class](../vs140/time_base-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)