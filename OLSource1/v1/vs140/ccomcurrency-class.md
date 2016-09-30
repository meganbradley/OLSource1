---
title: "CComCurrency Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CComCurrency"
  - "ATL.CComCurrency"
  - "ATL::CComCurrency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComCurrency class"
ms.assetid: a1c3d10a-bba6-40cc-8bcf-aed9023c8a9e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency Class
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> has methods and operators for creating and managing a CURRENCY object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComCurrency::CComCurrency](../vs140/ccomcurrency--ccomcurrency.md)|The constructor for a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCurrency::GetCurrencyPtr](../vs140/ccomcurrency--getcurrencyptr.md)|Returns the address of an <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> data member.|  
|[CComCurrency::GetFraction](../vs140/ccomcurrency--getfraction.md)|Call this method to return the fractional component of a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.|  
|[CComCurrency::GetInteger](../vs140/ccomcurrency--getinteger.md)|Call this method to return the integer component of a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
|[CComCurrency::Round](../vs140/ccomcurrency--round.md)|Call this method to round a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object to the nearest integer value.|  
|[CComCurrency::SetFraction](../vs140/ccomcurrency--setfraction.md)|Call this method to set the fractional component of a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.|  
|[CComCurrency::SetInteger](../vs140/ccomcurrency--setinteger.md)|Call this method to set the integer component of a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComCurrency::operator -](../vs140/ccomcurrency--operator--2.md)|This operator is used to perform subtraction on a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.|  
|[CComCurrency::operator !=](../vs140/ccomcurrency--operator-!=.md)|Compares two <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> objects for inequality.|  
|[CComCurrency::operator *](../vs140/ccomcurrency--operator--.md)|This operator is used to perform multiplication on a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.|  
|[CComCurrency::operator *=](../vs140/ccomcurrency--operator--=.md)|This operator is used to perform multiplication on a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object and assign it the result.|  
|[CComCurrency::operator /](../vs140/ccomcurrency--operator--1.md)|This operator is used to perform division on a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
|[CComCurrency::operator /=](../vs140/ccomcurrency--operator--=2.md)|This operator is used to perform division on a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object and assign it the result.|  
|[CComCurrency::operator +](../vs140/ccomcurrency--operator--.md)|This operator is used to perform addition on a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
|[CComCurrency::operator +=](../vs140/ccomcurrency--operator--=.md)|This operator is used to perform addition on a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object and assign the result to the current object.|  
|[CComCurrency::operator <](../vs140/ccomcurrency--operator--.md)|This operator compares two <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects to determine the lesser.|  
|[CComCurrency::operator <=](../vs140/ccomcurrency--operator--=.md)|This operator compares two <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> objects to determine equality or the lesser.|  
|[CComCurrency::operator =](../vs140/ccomcurrency--operator-=.md)|This operator assigns the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object to a new value.|  
|[CComCurrency::operator -=](../vs140/ccomcurrency--operator--=1.md)|This operator is used to perform subtraction on a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object and assign it the result.|  
|[CComCurrency::operator ==](../vs140/ccomcurrency--operator-==.md)|This operator compares two <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> objects for equality.|  
|[CComCurrency::operator >](../vs140/ccomcurrency--operator--.md)|This operator compares two <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> objects to determine the larger.|  
|[CComCurrency::operator >=](../vs140/ccomcurrency--operator--=.md)|This operator compares two <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> objects to determine equality or the larger.|  
|[CComCurrency::operator CURRENCY &](../vs140/ccomcurrency--operator-currency.md)|Casts a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComCurrency::m_currency](../vs140/ccomcurrency--m_currency.md)|The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> variable created by your class instance.|  
  
## Remarks  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is a wrapper for the **CURRENCY** data type. **CURRENCY** is implemented as an 8-byte two's-complement integer value scaled by 10,000. This gives a fixed-point number with 15 digits to the left of the decimal point and 4 digits to the right. The **CURRENCY** data type is extremely useful for calculations involving money, or for any fixed-point calculations where accuracy is important.  
  
 The **CComCurrency** wrapper implements arithmetic, assignment, and comparison operations for this fixed-point type. The supported applications have been selected to control the rounding errors that can occur during fixed-point calculations.  
  
 The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object provides access to the numbers on either side of the decimal point in the form of two components: an integer component which stores the value to the left of the decimal point, and a fractional component which stores the value to the right of the decimal point. The fractional component is stored internally as an integer value between -9999 (                **CY_MIN_FRACTION**) and +9999 (                **CY_MAX_FRACTION**). The method [CComCurrency::GetFraction](../vs140/ccomcurrency--getfraction.md) returns a value scaled by a factor of 10000 (                **CY_SCALE**).  
  
 When specifying the integer and fractional components of a **CComCurrency** object, remember that the fractional component is a number in the range 0 to 9999. This is important when dealing with a currency such as the US dollar that expresses amounts using only two significant digits after the decimal point. Even though the last two digits are not displayed, they must be taken into account.  
  
|Value|Possible CComCurrency assignments|  
|-----------|---------------------------------------|  
|$10.50|CComCurrency(10,5000) *or* CComCurrency(10.50)|  
|$10.05|CComCurrency(10,500) *or* CComCurrency(10.05)|  
  
 The values  **CY_MIN_FRACTION**,                 **CY_MAX_FRACTION**, and  **CY_SCALE** are defined in atlcur.h.  
  
## Requirements  
 **Header:** atlcur.h  
  
##  \<a name="ccomcurrency__ccomcurrency">\</a>  CComCurrency::CComCurrency  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A variable of type **CURRENCY**.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>,  *sSrc*,  *ulSrc, usSrc*  
 The initial value given to the member variable <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A character containing the initial value given to the member variable <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>,  *nFraction*  
 The integer and fractional components of the initial monetary value. See the [CComCurrency](../vs140/ccomcurrency-class.md) overview for more information.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> pointer.  
  
 *varSrc*  
 A variable of type **VARIANT**. The locale of the current thread is used to perform the conversion.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A Unicode or ANSI string containing the initial value. The locale of the current thread is used to perform the conversion.  
  
### Remarks  
 The constructor sets the initial value of [CComCurrency::m_currency](../vs140/ccomcurrency--m_currency.md), and accepts a wide range of data types, including integers, strings, floating-point numbers,                         **CURRENCY** variables, and other <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> objects. If no value is provided, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is set to 0.  
  
 In the event of an error, such as an overflow, the constructors lacking an empty exception specification (                        **throw()**) call <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
 When using floating-point or double values to assign a value, note that **CComCurrency(10.50)** is equivalent to **CComCurrency(10,5000)** and not **CComCurrency(10,50)**.  
  
##  \<a name="ccomcurrency__getcurrencyptr">\</a>  CComCurrency::GetCurrencyPtr  
 Returns the address of an <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> data member.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns the address of an <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> data member  
  
##  \<a name="ccomcurrency__getfraction">\</a>  CComCurrency::GetFraction  
 Call this method to return the fractional component of the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns the fractional component of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> data member.  
  
### Remarks  
 The fractional component is a 4-digit integer value between -9999 (                        **CY_MIN_FRACTION**) and +9999 (                        **CY_MAX_FRACTION**). <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> returns this value scaled by 10000 (                        **CY_SCALE**). The values of  **CY_MIN_FRACTION**,                         **CY_MAX_FRACTION**, and  **CY_SCALE** are defined in atlcur.h.  
  
### Example  
 [!code[NVC_ATL_Utilities#50](../vs140/codesnippet/CPP/ccomcurrency-class_1.cpp)]  
  
##  \<a name="ccomcurrency__getinteger">\</a>  CComCurrency::GetInteger  
 Call this method to get the integer component of a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the integer component of the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> data member.  
  
### Example  
 [!code[NVC_ATL_Utilities#51](../vs140/codesnippet/CPP/ccomcurrency-class_2.cpp)]  
  
##  \<a name="ccomcurrency__m_currency">\</a>  CComCurrency::m_currency  
 The **CURRENCY** data member.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This member holds the currency accessed and manipulated by the methods of this class.  
  
##  \<a name="ccomcurrency__operator_-">\</a>  CComCurrency::operator -  
 This operator is used to perform subtraction on a <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object representing the result of the subtraction. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
### Example  
 [!code[NVC_ATL_Utilities#55](../vs140/codesnippet/CPP/ccomcurrency-class_3.cpp)]  
  
##  \<a name="ccomcurrency__operator__neq">\</a>  CComCurrency::operator !=  
 This operator compares two objects for inequality.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object to be compared.  
  
### Return Value  
 Returns  **true** if the item being compared is not equal to the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object; otherwise,                         **false**.  
  
### Example  
 [!code[NVC_ATL_Utilities#56](../vs140/codesnippet/CPP/ccomcurrency-class_4.cpp)]  
  
##  \<a name="ccomcurrency__operator__star">\</a>  CComCurrency::operator *  
 This operator is used to perform multiplication on a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The multiplier.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object used as the multiplier.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object representing the result of the multiplication. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
### Example  
 [!code[NVC_ATL_Utilities#57](../vs140/codesnippet/CPP/ccomcurrency-class_5.cpp)]  
  
##  \<a name="ccomcurrency__operator__star_eq">\</a>  CComCurrency::operator *=  
 This operator is used to perform multiplication on a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object and assign it the result.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The multiplier.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object used as the multiplier.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
### Example  
 [!code[NVC_ATL_Utilities#58](../vs140/codesnippet/CPP/ccomcurrency-class_6.cpp)]  
  
##  \<a name="ccomcurrency__operator__">\</a>  CComCurrency::operator /  
 This operator is used to perform division on a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The divisor.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object representing the result of the division. If the divisor is 0, an assert failure will occur.  
  
### Example  
 [!code[NVC_ATL_Utilities#59](../vs140/codesnippet/CPP/ccomcurrency-class_7.cpp)]  
  
##  \<a name="ccomcurrency__operator___eq">\</a>  CComCurrency::operator /=  
 This operator is used to perform division on a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object and assign it the result.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The divisor.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object. If the divisor is 0, an assert failure will occur.  
  
### Example  
 [!code[NVC_ATL_Utilities#60](../vs140/codesnippet/CPP/ccomcurrency-class_8.cpp)]  
  
##  \<a name="ccomcurrency__operator__add">\</a>  CComCurrency::operator +  
 This operator is used to perform addition on a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object to be added to the original object.  
  
### Return Value  
 Returns a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object representing the result of the addition. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
### Example  
 [!code[NVC_ATL_Utilities#61](../vs140/codesnippet/CPP/ccomcurrency-class_9.cpp)]  
  
##  \<a name="ccomcurrency__operator__add_eq">\</a>  CComCurrency::operator +=  
 This operator is used to perform addition on a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object and assign the result to the current object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
### Example  
 [!code[NVC_ATL_Utilities#62](../vs140/codesnippet/CPP/ccomcurrency-class_10.cpp)]  
  
##  \<a name="ccomcurrency__operator__lt_">\</a>  CComCurrency::operator &lt;  
 This operator compares two <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> objects to determine the lesser.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns **true** if the first object is less than the second,                         **false** otherwise.  
  
### Example  
 [!code[NVC_ATL_Utilities#63](../vs140/codesnippet/CPP/ccomcurrency-class_11.cpp)]  
  
##  \<a name="ccomcurrency__operator__lt__eq">\</a>  CComCurrency::operator &lt;=  
 This operator compares two <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> objects to determine equality or the lesser.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns **true** if the first object is less than or equal to the second,                         **false** otherwise.  
  
### Example  
 [!code[NVC_ATL_Utilities#64](../vs140/codesnippet/CPP/ccomcurrency-class_12.cpp)]  
  
##  \<a name="ccomcurrency__operator__eq">\</a>  CComCurrency::operator =  
 This operator assigns the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object to a new value.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 A **CComCurrency** object.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 A variable of type **CURRENCY**.  
  
 *sSrc*, <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>,  *bSrc*,  *usSrc*, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>,  *cSrc*,  *ulSrc*, <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The numeric value to assign to the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
### Example  
 [!code[NVC_ATL_Utilities#65](../vs140/codesnippet/CPP/ccomcurrency-class_13.cpp)]  
  
##  \<a name="ccomcurrency__operator_-_eq">\</a>  CComCurrency::operator -=  
 This operator is used to perform subtraction on a <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> object and assign it the result.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
### Example  
 [!code[NVC_ATL_Utilities#66](../vs140/codesnippet/CPP/ccomcurrency-class_14.cpp)]  
  
##  \<a name="ccomcurrency__operator__eq_eq">\</a>  CComCurrency::operator ==  
 This operator compares two <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> objects for equality.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object to compare.  
  
### Return Value  
 Returns **true** if the objects are equal (that is, the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> data members, both integer and fractional, in both objects have the same value),                         **false** otherwise.  
  
### Example  
 [!code[NVC_ATL_Utilities#67](../vs140/codesnippet/CPP/ccomcurrency-class_15.cpp)]  
  
##  \<a name="ccomcurrency__operator__gt_">\</a>  CComCurrency::operator &gt;  
 This operator compares two <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> objects to determine the larger.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns **true** if the first object is greater than the second,                         **false** otherwise.  
  
### Example  
 [!code[NVC_ATL_Utilities#68](../vs140/codesnippet/CPP/ccomcurrency-class_16.cpp)]  
  
##  \<a name="ccomcurrency__operator__gt__eq">\</a>  CComCurrency::operator &gt;=  
 This operator compares two <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> objects to determine equality or the larger.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns **true** if the first object is greater than or equal to the second,                         **false** otherwise.  
  
### Example  
 [!code[NVC_ATL_Utilities#69](../vs140/codesnippet/CPP/ccomcurrency-class_17.cpp)]  
  
##  \<a name="ccomcurrency__operator_currency">\</a>  CComCurrency::operator CURRENCY  
 These operators are used to cast a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object to a **CURRENCY** data type.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Returns a reference to a **CURRENCY** object.  
  
### Example  
 [!code[NVC_ATL_Utilities#70](../vs140/codesnippet/CPP/ccomcurrency-class_18.cpp)]  
  
##  \<a name="ccomcurrency__round">\</a>  CComCurrency::Round  
 Call this method to round the currency to a specified number of decimal places.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 *nDecimals*  
 The number of digits to which <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> will be rounded, in the range 0 to 4.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> on failure.  
  
### Example  
 [!code[NVC_ATL_Utilities#52](../vs140/codesnippet/CPP/ccomcurrency-class_19.cpp)]  
  
##  \<a name="ccomcurrency__setfraction">\</a>  CComCurrency::SetFraction  
 Call this method to set the fractional component of a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 *nFraction*  
 The value to be assigned to the fractional component of the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> data member. The sign of the fractional component must the same as the integer component, and the value must be in range -9999 (                                **CY_MIN_FRACTION**) to +9999 (                                **CY_MAX_FRACTION**).  
  
### Return Value  
 Returns <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> on failure.  
  
### Example  
 [!code[NVC_ATL_Utilities#53](../vs140/codesnippet/CPP/ccomcurrency-class_20.cpp)]  
  
##  \<a name="ccomcurrency__setinteger">\</a>  CComCurrency::SetInteger  
 Call this method to set the integer component of a <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The value to be assigned to the integer component of the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> data member. The sign of the integer component must match the sign of the existing fractional component.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> must be in the range **CY_MIN_INTEGER** to **CY_MAX_INTEGER** inclusive. These values are defined in atlcur.h.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> on failure.  
  
### Example  
 [!code[NVC_ATL_Utilities#54](../vs140/codesnippet/CPP/ccomcurrency-class_21.cpp)]  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e)   
 [Class Overview](../vs140/atl-class-overview.md)