---
title: "CComBSTR Class"
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
  - "ATL::CComBSTR"
  - "CComBSTR"
  - "ATL.CComBSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BSTRs, wrapper"
  - "CComBSTR class"
  - "CComBSTR"
ms.assetid: 8fea1879-a05e-47a5-a803-8dec60eaa534
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR Class
This class is a wrapper for <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComBSTR::CComBSTR](../vs140/ccombstr--ccombstr.md)|The constructor.|  
|[CComBSTR::~CComBSTR](../vs140/ccombstr--~ccombstr.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComBSTR::Append](../vs140/ccombstr--append.md)|Appends a string to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
|[CComBSTR::AppendBSTR](../vs140/ccombstr--appendbstr.md)|Appends a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|[CComBSTR::AppendBytes](../vs140/ccombstr--appendbytes.md)|Appends a specified number of bytes to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
|[CComBSTR::ArrayToBSTR](../vs140/ccombstr--arraytobstr.md)|Creates a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> from the first character of each element in the safearray and attaches it to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
|[CComBSTR::AssignBSTR](../vs140/ccombstr--assignbstr.md)|Assigns a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.|  
|[CComBSTR::Attach](../vs140/ccombstr--attach.md)|Attaches a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.|  
|[CComBSTR::BSTRToArray](../vs140/ccombstr--bstrtoarray.md)|Creates a zero-based one-dimensional safearray, where each element of the array is a character from the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.|  
|[CComBSTR::ByteLength](../vs140/ccombstr--bytelength.md)|Returns the length of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> in bytes.|  
|[CComBSTR::Copy](../vs140/ccombstr--copy.md)|Returns a copy of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
|[CComBSTR::CopyTo](../vs140/ccombstr--copyto.md)|Returns a copy of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> via an **[out]** parameter|  
|[CComBSTR::Detach](../vs140/ccombstr--detach.md)|Detaches <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> from the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[CComBSTR::Empty](../vs140/ccombstr--empty.md)|Frees <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.|  
|[CComBSTR::Length](../vs140/ccombstr--length.md)|Returns the length of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.|  
|[CComBSTR::LoadString](../vs140/ccombstr--loadstring.md)|Loads a string resource.|  
|[CComBSTR::ReadFromStream](../vs140/ccombstr--readfromstream.md)|Loads a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object from a stream.|  
|[CComBSTR::ToLower](../vs140/ccombstr--tolower.md)|Converts the string to lowercase.|  
|[CComBSTR::ToUpper](../vs140/ccombstr--toupper.md)|Converts the string to uppercase.|  
|[CComBSTR::WriteToStream](../vs140/ccombstr--writetostream.md)|Saves <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to a stream.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComBSTR::operator BSTR](../vs140/ccombstr--operator-bstr.md)|Casts a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object to a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.|  
|[CComBSTR::operator !](../vs140/ccombstr--operator-!.md)|Returns <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, depending on whether <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>is <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.|  
|[CComBSTR::operator !=](../vs140/ccombstr--operator-!=.md)|Compares a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> with a string.|  
|[CComBSTR::operator &](../vs140/ccombstr--operator--.md)|Returns the address of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.|  
|[CComBSTR::operator +=](../vs140/ccombstr--operator--=.md)|Appends a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to the object.|  
|[CComBSTR::operator <](../vs140/ccombstr--operator--.md)|Compares a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> with a string.|  
|[CComBSTR::operator =](../vs140/ccombstr--operator-=.md)|Assigns a value to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.|  
|[CComBSTR::operator ==](../vs140/ccombstr--operator-==.md)|Compares a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> with a string.|  
|[CComBSTR::operator >](../vs140/ccombstr--operator--.md)|Compares a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> with a string.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComBSTR::m_str](../vs140/ccombstr--m_str.md)|Contains the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> associated with the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> class is a wrapper for <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>s, which are length-prefixed strings. The length is stored as an integer at the memory location preceding the data in the string.  
  
 A [BSTR](assetId:///1b2d7d2c-47af-4389-a6b6-b01b7e915228) is null-terminated after the last counted character but may also contain null characters embedded within the string. The string length is determined by the character count, not the first null character.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class provides a number of members (constructors, assignment operators, and comparison operators) that take either ANSI or Unicode strings as arguments. The ANSI versions of these functions are less efficient than their Unicode counterparts because temporary Unicode strings are often created internally. For efficiency, use the Unicode versions where possible.  
  
> [!NOTE]
>  Because of the improved lookup behavior implemented in Visual Studio .NET, code such as <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, which may have compiled in previous releases, should instead be implemented as <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
 For a list of cautions when using <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, see [Programming with CComBSTR](../vs140/programming-with-ccombstr--atl-.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccombstr__append">\</a>  CComBSTR::Append  
 Appends either <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> member of <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to [m_str](../vs140/ccombstr--m_str.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object to append.  
  
 *ch*  
 [in] A character to append.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 [in] A zero-terminated character string to append. You can pass a Unicode string via the **LPCOLESTR** overload or an ANSI string via the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> version.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 [in] The number of characters from <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> to append.  
  
### Return Value  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> on success, or any standard <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> error value.  
  
### Remarks  
 An ANSI string will be converted to Unicode before being appended.  
  
### Example  
 [!code[NVC_ATL_Utilities#32](../vs140/codesnippet/CPP/ccombstr-class_1.cpp)]  
  
##  \<a name="ccombstr__appendbstr">\</a>  CComBSTR::AppendBSTR  
 Appends the specified <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> to [m_str](../vs140/ccombstr--m_str.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> to append.  
  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> on success, or any standard <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> error value.  
  
### Remarks  
 Do not pass an ordinary wide-character string to this method. The compiler cannot catch the error and run time errors will occur.  
  
### Example  
 [!code[NVC_ATL_Utilities#33](../vs140/codesnippet/CPP/ccombstr-class_2.cpp)]  
  
##  \<a name="ccombstr__appendbytes">\</a>  CComBSTR::AppendBytes  
 Appends the specified number of bytes to [m_str](../vs140/ccombstr--m_str.md) without conversion.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 [in] A pointer to an array of bytes to append.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 [in] The number of bytes to append.  
  
### Return Value  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> on success, or any standard <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> error value.  
  
### Example  
 [!code[NVC_ATL_Utilities#34](../vs140/codesnippet/CPP/ccombstr-class_3.cpp)]  
  
##  \<a name="ccombstr__arraytobstr">\</a>  CComBSTR::ArrayToBSTR  
 Frees any existing string held in the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object, then creates a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> from the first character of each element in the safearray and attaches it to the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 [in] The safearray containing the elements used to create the string.  
  
### Return Value  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> on success, or any standard <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> error value.  
  
##  \<a name="ccombstr__assignbstr">\</a>  CComBSTR::AssignBSTR  
 Assigns a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to [m_str](../vs140/ccombstr--m_str.md).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to assign to the current <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> on success, or any standard <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> error value.  
  
##  \<a name="ccombstr__attach">\</a>  CComBSTR::Attach  
 Attaches a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object by setting the [m_str](../vs140/ccombstr--m_str.md) member to *src*.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *src*  
 [in] The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to attach to the object.  
  
### Remarks  
 Do not pass an ordinary wide-character string to this method. The compiler cannot catch the error and run time errors will occur.  
  
> [!NOTE]
>  This method will assert if <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is non-                            **NULL**.  
  
### Example  
 [!code[NVC_ATL_Utilities#35](../vs140/codesnippet/CPP/ccombstr-class_4.cpp)]  
  
##  \<a name="ccombstr__bstrtoarray">\</a>  CComBSTR::BSTRToArray  
 Creates a zero-based one-dimensional safearray, where each element of the array is a character from the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 [out] The pointer to the safearray used to hold the results of the function.  
  
### Return Value  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> on success, or any standard <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> error value.  
  
##  \<a name="ccombstr__bytelength">\</a>  CComBSTR::ByteLength  
 Returns the number of bytes in <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, excluding the terminating null character.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The length of the [m_str](../vs140/ccombstr--m_str.md) member in bytes.  
  
### Remarks  
 Returns 0 if <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> is **NULL**.  
  
### Example  
 [!code[NVC_ATL_Utilities#36](../vs140/codesnippet/CPP/ccombstr-class_5.cpp)]  
  
##  \<a name="ccombstr__ccombstr">\</a>  CComBSTR::CComBSTR  
 The constructor. The default constructor sets the [m_str](../vs140/ccombstr--m_str.md) member to **NULL**.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 [in] The number of characters to copy from <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> or the initial size in characters for the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 [in] A string to copy. The Unicode version specifies an **LPCOLESTR**; the ANSI version specifies an <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 [in] A string to copy. The Unicode version specifies an **LPCOLESTR**; the ANSI version specifies an <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 *src*  
 [in] A <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 [in] A reference to a **GUID** structure.  
  
### Remarks  
 The copy constructor sets <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> to a copy of the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> member of *src*. The **REFGUID** constructor converts the **GUID** to a string using **StringFromGUID2** and stores the result.  
  
 The other constructors set <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> to a copy of the specified string. If you pass a value for <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>, then only <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> characters will be copied, followed by a terminating null character.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> supports move semantics. You can use the move constructor (the constructor that takes an rvalue reference ( <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>) to create a new object that uses the same underlying data as the old object you pass in as an argument, without the overhead of copying the object.  
  
 The destructor frees the string pointed to by <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATL_Utilities#37](../vs140/codesnippet/CPP/ccombstr-class_6.cpp)]  
  
##  \<a name="ccombstr___dtorccombstr">\</a>  CComBSTR::~CComBSTR  
 The destructor.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees the string pointed to by <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
##  \<a name="ccombstr__copy">\</a>  CComBSTR::Copy  
 Allocates and returns a copy of <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A copy of the [m_str](../vs140/ccombstr--m_str.md) member. If <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> is **NULL**, returns **NULL**.  
  
### Example  
 [!code[NVC_ATL_Utilities#38](../vs140/codesnippet/CPP/ccombstr-class_7.cpp)]  
  
##  \<a name="ccombstr__copyto">\</a>  CComBSTR::CopyTo  
 Allocates and returns a copy of [m_str](../vs140/ccombstr--m_str.md) via the parameter.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 *pbstr*  
 [out] The address of a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> in which to return the string allocated by this method.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 [out] The address of a **VARIANT** in which to return the string allocated by this method.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> value indicating the success or failure of the copy.  
  
### Remarks  
 After calling this method, the **VARIANT** pointed to by <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> will be of type <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATL_Utilities#39](../vs140/codesnippet/CPP/ccombstr-class_8.cpp)]  
  
##  \<a name="ccombstr__detach">\</a>  CComBSTR::Detach  
 Detaches [m_str](../vs140/ccombstr--m_str.md) from the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object and sets <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> to **NULL**.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> associated with the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_ATL_Utilities#40](../vs140/codesnippet/CPP/ccombstr-class_9.cpp)]  
  
##  \<a name="ccombstr__empty">\</a>  CComBSTR::Empty  
 Frees the [m_str](../vs140/ccombstr--m_str.md) member.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_ATL_Utilities#41](../vs140/codesnippet/CPP/ccombstr-class_10.cpp)]  
  
##  \<a name="ccombstr__length">\</a>  CComBSTR::Length  
 Returns the number of characters in <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, excluding the terminating null character.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The length of the [m_str](../vs140/ccombstr--m_str.md) member.  
  
### Example  
 [!code[NVC_ATL_Utilities#42](../vs140/codesnippet/CPP/ccombstr-class_11.cpp)]  
  
##  \<a name="ccombstr__loadstring">\</a>  CComBSTR::LoadString  
 Loads a string resource specified by <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> and stores it in this object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 See [LoadString](http://msdn.microsoft.com/library/windows/desktop/ms647486) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **true** if the string is successfully loaded; otherwise, returns **false**.  
  
### Remarks  
 The first function loads the resource from the module identified by you via the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> parameter. The second function loads the resource from the resource module associated with the [CComModule](../vs140/ccommodule-class.md)-derived object used in this project.  
  
### Example  
 [!code[NVC_ATL_Utilities#43](../vs140/codesnippet/CPP/ccombstr-class_12.cpp)]  
  
##  \<a name="ccombstr__m_str">\</a>  CComBSTR::m_str  
 Contains the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> associated with the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_ATL_Utilities#49](../vs140/codesnippet/CPP/ccombstr-class_13.cpp)]  
  
##  \<a name="ccombstr__operator_bstr">\</a>  CComBSTR::operator BSTR  
 Casts a <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> object to a <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 Allows you to pass <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> objects to functions that have **[in] BSTR** parameters.  
  
### Example  
 See the example for [CComBSTR::m_str](../vs140/ccombstr--m_str.md).  
  
##  \<a name="ccombstr__operator__not">\</a>  CComBSTR::operator !  
 Checks whether <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> string is NULL.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Returns **true** if the [m_str](../vs140/ccombstr--m_str.md) member is **NULL**; otherwise,                         **false**.  
  
### Remarks  
 This operator only checks for a NULL value, not for an empty string.  
  
### Example  
 [!code[NVC_ATL_Utilities#35](../vs140/codesnippet/CPP/ccombstr-class_4.cpp)]  
  
##  \<a name="ccombstr__operator__neq">\</a>  CComBSTR::operator !=  
 Returns the logical opposite of [operator ==](../vs140/ccombstr--operator-==.md).  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 [in] A zero-terminated string.  
  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 [in] Must be **NULL**.  
  
### Return Value  
 Returns **true** if the item being compared is not equal to the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object; otherwise, returns **false**.  
  
### Remarks  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>s are compared textually in the context of the user's default locale. The final comparison operator just compares the contained string against **NULL**.  
  
##  \<a name="ccombstr__operator__amp_">\</a>  CComBSTR::operator &amp;  
 Returns the address of the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> stored in the [m_str](../vs140/ccombstr--m_str.md) member.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> has a special assertion associated with it to help identify memory leaks. The program will assert when the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> member is initialized. This assertion was created to identify situations where a programmer uses the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> to assign a new value to <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> member without freeing the first allocation of <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> equals NULL, the program assumes that m_str wasn't allocated yet. In this case, the program will not assert.  
  
 This assertion is not enabled by default. Define <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> to enable this assertion.  
  
### Example  
 [!code[NVC_ATL_Utilities#46](../vs140/codesnippet/CPP/ccombstr-class_14.cpp)]  
  
 [!code[NVC_ATL_Utilities#47](../vs140/codesnippet/CPP/ccombstr-class_15.cpp)]  
  
##  \<a name="ccombstr__operator__add_eq">\</a>  CComBSTR::operator +=  
 Appends a string to the <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object to append.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 [in] A zero-terminated string to append.  
  
### Remarks  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>s are compared textually in the context of the user's default locale. The **LPCOLESTR** comparison is done using <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> on the raw data in each string. The <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> comparison is carried out in the same way once a temporary Unicode copy of <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> has been created. The final comparison operator just compares the contained string against **NULL**.  
  
### Example  
 [!code[NVC_ATL_Utilities#48](../vs140/codesnippet/CPP/ccombstr-class_16.cpp)]  
  
##  \<a name="ccombstr__operator__lt_">\</a>  CComBSTR::operator &lt;  
 Compares a <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> with a string.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Returns **true** if the item being compared is less than the <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> object; otherwise, returns **false**.  
  
### Remarks  
 The comparison is performed using the user's default locale.  
  
##  \<a name="ccombstr__operator__eq">\</a>  CComBSTR::operator =  
 Sets the [m_str](../vs140/ccombstr--m_str.md) member to a copy of <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> or to a copy of the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> member of *src*.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> parameter specifies either an **LPCOLESTR** for Unicode versions or <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> for ANSI versions.  
  
### Example  
 See the example for [CComBSTR::Copy](../vs140/ccombstr--copy.md).  
  
##  \<a name="ccombstr__operator__eq_eq">\</a>  CComBSTR::operator ==  
 Compares a <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> with a string. <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>s are compared textually in the context of the user's default locale.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 [in] A zero-terminated string.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 [in] Must be **NULL**.  
  
### Return Value  
 Returns **true** if the item being compared is equal to the <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> object; otherwise, returns **false**.  
  
### Remarks  
 The final comparison operator just compares the contained string against **NULL**.  
  
##  \<a name="ccombstr__operator__gt_">\</a>  CComBSTR::operator &gt;  
 Compares a <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> with a string.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Returns **true** if the item being compared is greater than the <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> object; otherwise, returns **false**.  
  
### Remarks  
 The comparison is performed using the user's default locale.  
  
##  \<a name="ccombstr__readfromstream">\</a>  CComBSTR::ReadFromStream  
 Sets the [m_str](../vs140/ccombstr--m_str.md) member to the <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> contained in the specified stream.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 [in] A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface on the stream containing the data.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> value.  
  
### Remarks  
 **ReadToStream** requires the contents of the stream at the current position to be compatible with the data format written out by a call to [WriteToStream](../vs140/ccombstr--writetostream.md).  
  
### Example  
 [!code[NVC_ATL_Utilities#44](../vs140/codesnippet/CPP/ccombstr-class_17.cpp)]  
  
##  \<a name="ccombstr__tolower">\</a>  CComBSTR::ToLower  
 Converts the contained string to lowercase.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> value.  
  
### Remarks  
 See **CharLowerBuff** for more information on how the conversion is performed.  
  
##  \<a name="ccombstr__toupper">\</a>  CComBSTR::ToUpper  
 Converts the contained string to uppercase.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> value.  
  
### Remarks  
 See **CharUpperBuff** for more information on how the conversion is performed.  
  
##  \<a name="ccombstr__writetostream">\</a>  CComBSTR::WriteToStream  
 Saves the [m_str](../vs140/ccombstr--m_str.md) member to a stream.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 [in] A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface on a stream.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> value.  
  
### Remarks  
 You can recreate a BSTR from the contents of the stream using the [ReadFromStream](../vs140/ccombstr--readfromstream.md) function.  
  
### Example  
 [!code[NVC_ATL_Utilities#45](../vs140/codesnippet/CPP/ccombstr-class_18.cpp)]  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md)