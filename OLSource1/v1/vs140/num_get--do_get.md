---
title: "num_get::do_get"
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
  - "std.num_get.do_get"
  - "std::num_get::do_get"
  - "xlocnum/std::num_get::do_get"
  - "do_get"
  - "num_get::do_get"
  - "num_get.do_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get method"
ms.assetid: 85a43224-c761-4f2b-ba78-bd7f1d56458a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# num_get::do_get
A virtual function that is called to extracts a numerical or Boolean value from a character sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The beginning of the range of characters from which to read the number.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The end of the range of characters from which to read the number.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The [ios_base](../vs140/ios_base-class.md) whose flags are used by the conversion.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The state to which failbit (see [ios_base::iostate](../vs140/ios_base--iostate.md)) is added upon failure.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value that was read.  
  
## Return Value  
 The iterator after the value has been read.  
  
## Remarks  
 The first virtual protected member function,  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 matches sequential elements beginning at <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in the sequence <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> until it has recognized a complete, nonempty integer input field. If successful, it converts this field to its equivalent value as type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and stores the result in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond the numeric input field. Otherwise, the function stores nothing in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. It returns an iterator designating the first element beyond any prefix of a valid integer input field. In either case, if the return value equals <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the function sets <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The integer input field is converted by the same rules used by the scan functions for matching and converting a series of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> elements from a file. (Each such <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> element is assumed to map to an equivalent element of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> by a simple, one-to-one, mapping.) The equivalent scan conversion specification is determined as follows:  
  
 If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>[flags](../vs140/ios_base--flags.md)<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>[oct](../vs140/oct---ios--.md), the conversion specification is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>[hex](../vs140/hex.md), the conversion specification is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, the conversion specification is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 Otherwise, the conversion specification is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 The format of an integer input field is further determined by the [locale facet](../vs140/facet-class.md)<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> returned by the call [use_facet](../vs140/use_facet.md) <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>[numpunct](../vs140/numpunct-class.md)<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> [getloc](../vs140/ios_base--getloc.md)<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. Specifically:  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> [grouping](../vs140/numpunct--grouping.md) <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> determines how digits are grouped to the left of any decimal point  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> [thousands_sep](../vs140/numpunct--thousands_sep.md) <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> determines the sequence that separates groups of digits to the left of any decimal point.  
  
 If no instances of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> occur in the numeric input field, no grouping constraint is imposed. Otherwise, any grouping constraints imposed by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> are enforced and separators are removed before the scan conversion occurs.  
  
 The fourth virtual protected member function:  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it replaces a conversion specification of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. If successful it converts the numeric input field to a value of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 The fifth virtual protected member function:  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it replaces a conversion specification of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. If successful it converts the numeric input field to a value of type <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 The sixth virtual protected member function:  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it replaces a conversion specification of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. If successful it converts the numeric input field to a value of type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 The seventh virtual protected member function:  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty floating-point input field. <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>[decimal_point](../vs140/numpunct--decimal_point.md)<CodeContentPlaceHolder>86\</CodeContentPlaceHolder> determines the sequence that separates the integer digits from the fraction digits. The equivalent scan conversion specifier is <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
 The eighth virtual protected member function:  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty floating-point input field. <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>[decimal_point](../vs140/numpunct--decimal_point.md)<CodeContentPlaceHolder>96\</CodeContentPlaceHolder> determines the sequence that separates the integer digits from the fraction digits. The equivalent scan conversion specifier is <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
 The ninth virtual protected member function:  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
 behaves the same as the eighth, except that the equivalent scan conversion specifier is <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
 The ninth virtual protected member function:  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  
 behaves the same the first, except that the equivalent scan conversion specifier is <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
 The last (eleventh) virtual protected member function:  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
 behaves the same as the first, except that it endeavors to match a complete, nonempty Boolean input field. If successful it converts the Boolean input field to a value of type <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> and stores that value in <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
 A Boolean input field takes one of two forms. If <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>[boolalpha](../vs140/boolalpha.md) is false, it is the same as an integer input field, except that the converted value must be either 0 (for false) or 1 (for true). Otherwise, the sequence must match either <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>[falsename](../vs140/numpunct--falsename.md)<CodeContentPlaceHolder>125\</CodeContentPlaceHolder> (for false), or <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>[truename](../vs140/numpunct--truename.md)<CodeContentPlaceHolder>127\</CodeContentPlaceHolder> (for true).  
  
## Example  
 See the example for [get](../vs140/num_get--get.md), where the virtual member function is called by <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [num_get Class](../vs140/num_get-class.md)