---
title: "CStringT Class"
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
  - "CString"
  - "CStringT"
  - "ATL::CStringT"
  - "ATL.CStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strings [C++], in ATL"
  - "shared classes, CStringT"
  - "CStringT class"
ms.assetid: 7cacc59c-425f-40f1-8f5b-6db921318ec9
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT Class
This class represents a             <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The character type of the string class. Can be one of the following:  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> (for ANSI character strings).  
  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> (for Unicode character strings).  
  
-   **TCHAR** (for both ANSI and Unicode character strings).  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Determines if the string class needs C Run-Time (CRT) Library support and where string resources are located. Can be one of the following:  
  
-   **StrTraitATL< wchar_t** &#124;                                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> &#124;                                 **TCHAR, ChTraitsCRT< wchar_t** &#124;                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> &#124;                                 **TCHAR > >**  
  
     The class requires CRT support and searches for resource strings in the module specified by                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> (a member of the application's module class).  
  
-   **StrTraitATL< wchar_t** &#124;                                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> &#124;                                 **TCHAR, ChTraitsOS< wchar_t** &#124;                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> &#124;                                 **TCHAR > >**  
  
     The class does not require CRT support and searches for resource strings in the module specified by                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> (a member of the application's module class).  
  
-   **StrTraitMFC< wchar_t** &#124;                                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> &#124;                                 **TCHAR, ChTraitsCRT< wchar_t** &#124;                                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> &#124;                                 **TCHAR > >**  
  
     The class requires CRT support and searches for resource strings using the standard MFC search algorithm.  
  
-   **StrTraitMFC< wchar_t** &#124;                                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> &#124;                                 **TCHAR, ChTraitsOS< wchar_t** &#124;                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> &#124;                                 **TCHAR > >**  
  
     The class does not require CRT support and searches for resource strings using the standard MFC search algorithm.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CStringT::CStringT](#cstringt__cstringt)|Constructs a                                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object in various ways.|  
|[CStringT::~CStringT](#cstringt___dtorcstringt)|Destroys a                                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStringT::AllocSysString](#cstringt__allocsysstring)|Allocates a                                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> from                                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> data.|  
|[CStringT::AnsiToOem](#cstringt__ansitooem)|Makes an in-place conversion from the ANSI character set to the OEM character set.|  
|[CStringT::AppendFormat](#cstringt__appendformat)|Appends formatted data to an existing                                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.|  
|[CStringT::Collate](#cstringt__collate)|Compares two strings (case sensitive, uses locale-specific information).|  
|[CStringT::CollateNoCase](#cstringt__collatenocase)|Compares two strings (case insensitive, uses locale-specific information).|  
|[CStringT::Compare](#cstringt__compare)|Compares two strings (case sensitive).|  
|[CStringT::CompareNoCase](#cstringt__comparenocase)|Compares two strings (case insensitive).|  
|[CStringT::Delete](#cstringt__delete)|Deletes a character or characters from a string.|  
|[CStringT::Find](#cstringt__find)|Finds a character or substring inside a larger string.|  
|[CStringT::FindOneOf](#cstringt__findoneof)|Finds the first matching character from a set.|  
|[CStringT::Format](#cstringt__format)|Formats the string as                                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> does.|  
|[CStringT::FormatMessage](#cstringt__formatmessage)|Formats a message string.|  
|[CStringT::FormatMessageV](#cstringt__formatmessagev)|Formats a message string using a variable argument list.|  
|[CStringT::FormatV](#cstringt__formatv)|Formats the string using a variable list of arguments.|  
|[CStringT::GetEnvironmentVariable](#cstringt__getenvironmentvariable)|Sets the string to the value of the specified environment variable.|  
|[CStringT::Insert](#cstringt__insert)|Inserts a single character or a substring at the given index within the string.|  
|[CStringT::Left](#cstringt__left)|Extracts the left part of a string.|  
|[CStringT::LoadString](#cstringt__loadstring)|Loads an existing                                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object from a Windows resource.|  
|[CStringT::MakeLower](#cstringt__makelower)|Converts all the characters in this string to lowercase characters.|  
|[CStringT::MakeReverse](#cstringt__makereverse)|Reverses the string.|  
|[CStringT::MakeUpper](#cstringt__makeupper)|Converts all the characters in this string to uppercase characters.|  
|[CStringT::Mid](#cstringt__mid)|Extracts the middle part of a string.|  
|[CStringT::OemToAnsi](#cstringt__oemtoansi)|Makes an in-place conversion from the OEM character set to the ANSI character set.|  
|[CStringT::Remove](#cstringt__remove)|Removes indicated characters from a string.|  
|[CStringT::Replace](#cstringt__replace)|Replaces indicated characters with other characters.|  
|[CStringT::ReverseFind](#cstringt__reversefind)|Finds a character inside a larger string; starts from the end.|  
|[CStringT::Right](#cstringt__right)|Extracts the right part of a string.|  
|[CStringT::SetSysString](#cstringt__setsysstring)|Sets an existing                                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object with data from a                                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object.|  
|[CStringT::SpanExcluding](#cstringt__spanexcluding)|Extracts characters from the string, starting with the first character, that are not in the set of characters identified by                                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.|  
|[CStringT::SpanIncluding](#cstringt__spanincluding)|Extracts a substring that contains only the characters in a set.|  
|[CStringT::Tokenize](#cstringt__tokenize)|Extracts specified tokens in a target string.|  
|[CStringT::Trim](#cstringt__trim)|Trims all leading and trailing whitespace characters from the string.|  
|[CStringT::TrimLeft](#cstringt__trimleft)|Trims leading whitespace characters from the string.|  
|[CStringT::TrimRight](#cstringt__trimright)|Trims trailing whitespace characters from the string.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](#cstringt__operator__eq)|Assigns a new value to a                                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.|  
|[operator +](#cstringt__operator__add)|Concatenates two strings or a character and a string.|  
|[operator +=](#cstringt__operator__add_eq)|Concatenates a new string to the end of an existing string.|  
|[operator ==](#cstringt__operator__eq_eq)|Determines if two strings are logically equal.|  
|[operator !=](#cstringt__operator__neq)|Determines if two strings are logically not equal.|  
|[operator \<](#cstringt__operator__lt_)|Determines if the string on the left side of the operator is less than to the string on the right side.|  
|[operator >](#cstringt__operator__gt_)|Determines if the string on the left side of the operator is greater than to the string on the right side.|  
|[operator \<=](#cstringt__operator__lt__eq)|Determines if the string on the left side of the operator is less than or equal to the string on the right side.|  
|[operator >=](#cstringt__operator__gt__eq)|Determines if the string on the left side of the operator is greater than or equal to the string on the right side.|  
  
## Remarks  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> inherits from                 [CSimpleStringT Class](../vs140/csimplestringt-class.md). Advanced features, such as character manipulation, ordering, and searching, are implemented by                 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> objects are capable of throwing exceptions. This occurs when a                     <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object runs out of memory for any reason.  
  
 A                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object consists of a variable-length sequence of characters.                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> provides functions and operators using syntax similar to that of Basic. Concatenation and comparison operators, together with simplified memory management, make                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> objects easier to use than ordinary character arrays.  
  
> [!NOTE]
>  Although it is possible to create                     <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> instances that contain embedded null characters, we recommend against it. Calling methods and operators on                     <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> objects that contain embedded null characters can produce unintended results.  
  
 By using different combinations of the                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> parameters,                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> objects can come in the following types, which are have been predefined by the ATL libraries.  
  
 If using in an ATL application:  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, and                 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> are exported from the MFC DLL (MFC90.DLL), never from user DLLs. This is done to prevent                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> from being multiply defined.  
  
> [!NOTE]
>  If you encountered linker errors when exporting a                     <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>-derived class from an MFC extension DLL in Visual C++ .NET 2002 and have applied the workaround as described in the Knowledge Base article, "Linking Errors When You Import CString-Derived Classes" (Q309801), you should remove the workaround code, because this has been fixed in Visual C++ .NET 2003. You can find Knowledge Base articles on the MSDN Library CD-ROM or at                     [http://support.microsoft.com/support](http://support.microsoft.com/support).  
  
 The following string types are available within MFC-based applications:  
  
|CStringT type|Declaration|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|An ANSI character type string with CRT support.|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|A Unicode character type string with CRT support.|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|Both ANSI and Unicode character types with CRT support.|  
  
 The following string types are available in projects where                 **ATL_CSTRING_NO_CRT** is defined:  
  
|CStringT type|Declaration|  
|-------------------|-----------------|  
|**CAtlStringA**|An ANSI character type string without CRT support.|  
|**CAtlStringW**|A Unicode character type string without CRT support.|  
|**CAtlString**|Both ANSI and Unicode character types without CRT support.|  
  
 The following string types are available in projects where                 **ATL_CSTRING_NO_CRT** is not defined:  
  
|CStringT type|Declaration|  
|-------------------|-----------------|  
|**CAtlStringA**|An ANSI character type string with CRT support.|  
|**CAtlStringW**|A Unicode character type string with CRT support.|  
|**CAtlString**|Both ANSI and Unicode character types with CRT support.|  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> objects also have the following characteristics:  
  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> objects can grow as a result of concatenation operations.  
  
-   <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> objects follow "value semantics." Think of a                         <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object as an actual string, not as a pointer to a string.  
  
-   You can freely substitute                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> objects for                         <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> function arguments.  
  
-   Custom memory management for string buffers. For more information, see                         [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## CStringT Predefined Types  
 Because                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> uses a template argument to define the character type (either                 [wchar_t](../vs140/standard-types.md) or                 [char](../vs140/standard-types.md)) supported, method parameter types can be complicated at times. To simplify this issue, a set of predefined types is defined and used throughout the                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> class. The following table lists the various types:  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|A single character (either                                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>) with the same character type as the                                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object.|  
|**YCHAR**|A single character (either                                 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>) with the opposite character type as the                                 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|A pointer to a character string (either                                 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>) with the same character type as the                                 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.|  
|**PYSTR**|A pointer to a character string (either                                 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>) with the opposite character type as the                                 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|A pointer to a                                 **const** character string (either                                 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>) with the same character type as the                                 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object.|  
|**PCYSTR**|A pointer to a                                 **const** character string (either                                 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>) with the opposite character type as the                                 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object.|  
  
> [!NOTE]
>  Code that previously used undocumented methods of                     <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> (such as                     **AssignCopy**) must be replaced with code that uses the following documented methods of                     <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> (such as                     <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> or                     <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>). These methods are inherited from                     <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
## Inheritance Hierarchy  
 [CSimpleStringT](../vs140/csimplestringt-class.md)  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  
## Requirements  
  
|Header|Use for|  
|------------|-------------|  
|cstringt.h|MFC-only string objects|  
|atlstr.h|Non-MFC string objects|  
  
##  \<a name="cstringt__allocsysstring">\</a>  CStringT::AllocSysString  
 Allocates an Automation-compatible string of the type                 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> and copies the contents of the                 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object into it, including the terminating null character.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The newly allocated string.  
  
### Remarks  
 In MFC programs, a                         [CMemoryException](../vs140/cmemoryexception-class.md) is thrown if insufficient memory exists. In ATL programs, a                         [CAtlException](../vs140/catlexception-class.md) is thrown. This function is normally used to return strings for Automation.  
  
 Commonly, if this string is passed to a COM function as an [in] parameter, then this requires the caller to free the string. This can be done by using                         [SysFreeString](assetId:///8f230ee3-5f6e-4cb9-a910-9c90b754dcd3), as described in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see                         [Strings: Allocating and Releasing Memory for a BSTR](../vs140/allocating-and-releasing-memory-for-a-bstr.md).  
  
 For more information about OLE allocation functions in Windows, see                         [SysAllocString](assetId:///9e0437a2-9b4a-4576-88b0-5cb9d08ca29b) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following example demonstrates the use of                                 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATLMFC_Utilities#105](../vs140/codesnippet/CPP/cstringt-class_1.cpp)]  
  
##  \<a name="cstringt__ansitooem">\</a>  CStringT::AnsiToOem  
 Converts all the characters in this                 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object from the ANSI character set to the OEM character set.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The function is not available if                         <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> is defined.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#106](../vs140/codesnippet/CPP/cstringt-class_2.cpp)]  
  
##  \<a name="cstringt__appendformat">\</a>  CStringT::AppendFormat  
 Appends formatted data to an existing                 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 A format-control string.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The string resource identifier that contains the format-control string.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 Optional arguments.  
  
### Remarks  
 This function formats and appends a series of characters and values in the                         <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>. Each optional argument (if any) is converted and appended according to the corresponding format specification in                         <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> or from the string resource identified by                         <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#107](../vs140/codesnippet/CPP/cstringt-class_3.cpp)]  
  
##  \<a name="cstringt__collate">\</a>  CStringT::Collate  
 Compares two strings using the generic-text function                 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 The other string used for comparison.  
  
### Return Value  
 Zero if the strings are identical, < 0 if this                         <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object is less than                         <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>, or > 0 if this                         <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object is greater than                         <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
### Remarks  
 The generic-text function                         <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, which is defined in TCHAR.H, maps to either                         <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, or                         <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>, depending on the character set that is defined at compile time. Each function performs a case-sensitive comparison of the strings according to the code page currently in use. For more information, see                         [strcoll, wcscoll, _mbscoll](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md).  
  
##  \<a name="cstringt__collatenocase">\</a>  CStringT::CollateNoCase  
 Compares two strings using the generic-text function                 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The other string used for comparison.  
  
### Return Value  
 Zero if the strings are identical (ignoring case), < 0 if this                         <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object is less than                         <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> (ignoring case), or > 0 if this                         <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> object is greater than                         <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> (ignoring case).  
  
### Remarks  
 The generic-text function                         <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, which is defined in TCHAR.H, maps to either                         <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, or                         <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, depending on the character set that is defined at compile time. Each function performs a case-insensitive comparison of the strings, according to the code page currently in use. For more information, see                         [strcoll, wcscoll, _mbscoll](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#109](../vs140/codesnippet/CPP/cstringt-class_4.cpp)]  
  
##  \<a name="cstringt__compare">\</a>  CStringT::Compare  
 Compares two strings (case sensitive).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The other string used for comparison.  
  
### Return Value  
 Zero if the strings are identical, < 0 if this                         <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object is less than                         <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, or > 0 if this                         <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> object is greater than                         <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Remarks  
 The generic-text function                         <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>, which is defined in TCHAR.H, maps to either                         <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, or                         <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, depending on the character set that is defined at compile time. Each function performs a case-sensitive comparison of the strings and is not affected by locale. For more information, see                         [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md).  
  
 If the string contains embedded nulls, for purposes of comparison the string is considered to be truncated at the first embedded null character.  
  
### Example  
 The following example demonstrates the use of                                 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATLMFC_Utilities#110](../vs140/codesnippet/CPP/cstringt-class_5.cpp)]  
  
##  \<a name="cstringt__comparenocase">\</a>  CStringT::CompareNoCase  
 Compares two strings (case insensitive).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 The other string used for comparison.  
  
### Return Value  
 Zero if the strings are identical (ignoring case), <0 if this                         <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object is less than                         <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> (ignoring case), or >0 if this                         <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> object is greater than                         <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> (ignoring case).  
  
### Remarks  
 The generic-text function                         <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>, which is defined in TCHAR.H, maps to either                         <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>, depending on the character set that is defined at compile time. Each function performs a case-insensitive comparison of the strings. The comparison depends on the                         <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> aspect of the locale but not                         <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>. For more information, see                         [_stricmp, _wcsicmp, _mbsicmp](../vs140/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#111](../vs140/codesnippet/CPP/cstringt-class_6.cpp)]  
  
##  \<a name="cstringt__cstringt">\</a>  CStringT::CStringT  
 Constructs a                 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 A pointer to an array of characters of length                                 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, not null-terminated.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 A count of the number of characters in                                 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 A single character.  
  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this                                 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 A pointer to the memory manager for the                                 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> object. For more information on                                 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> and memory management for                                 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, see                                 [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> object to be copied into this                                 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> object. For more information on                                 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> and                                 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>, see the Remarks section.  
  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 A variant object to be copied into this                                 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The character type of the string class. Can be one of the following:  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> (for ANSI character strings).  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> (for Unicode character strings).  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> (for both ANSI and Unicode character strings).  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 Boolean that specifies whether the project is an MFC DLL (TRUE) or not (FALSE).  
  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 Must be                                 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>, and the project must be compiled with /clr.  
  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 A handle for a                                 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Because the constructors copy the input data into new allocated storage, you should be aware that memory exceptions may result. Note that some of these constructors act as conversion functions. This allows you to substitute, for example, an                         <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> where a                         <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> object is expected.  
  
-   <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>(                                 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> ): Constructs a Unicode                                 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> from an ANSI string. You can also use this constructor to load a string resource as shown in the example below.  
  
-   <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> ): Constructs a                                 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> from a Unicode string.  
  
-   <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>(                                 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> ): Allows you to construct a                                 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> from a pointer to                                 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Define the                             **_CSTRING_DISABLE_NARROW_WIDE_CONVERSION** macro to turn off implicit string conversion between                             [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] and                             [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] strings. The macro excludes from compilation constructors that support conversion.  
  
 Note that the                         <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> parameter can be either a                         <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> object. For                         <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>, use one of its default instantiations (                        <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>, or                         <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>); for                         <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>, use a                         <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> pointer.                         <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> declares an instance of the                         [CSimpleStringT Class](../vs140/csimplestringt-class.md), which is a smaller string class with less built-in functionality than the                         <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> class.  
  
 The overload operator                         <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> constructs a                         <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> object from a                         <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> declaration.  
  
> [!NOTE]
>  Although it is possible to create                             <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> instances that contain embedded null characters, we recommend against it. Calling methods and operators on                             <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> objects that contain embedded null characters can produce unintended results.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#112](../vs140/codesnippet/CPP/cstringt-class_7.cpp)]  
  
##  \<a name="cstringt___dtorcstringt">\</a>  CStringT::~CStringT  
 Destroys the                 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 Destroys the                         <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> object.  
  
##  \<a name="cstringt__delete">\</a>  CStringT::Delete  
 Deletes a character or characters from a string starting with the character at the given index.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 The zero-based index of the first character in the                                 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> object to delete.  
  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 The number of characters to be removed.  
  
### Return Value  
 The length of the changed string.  
  
### Remarks  
 If                         <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> is longer than the string, the rest of the string will be removed.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#113](../vs140/codesnippet/CPP/cstringt-class_8.cpp)]  
  
 **Before: Soccer is best, but hockey is quicker!**  
**After: Soccer best, but hockey is quicker!**   
##  \<a name="cstringt__find">\</a>  CStringT::Find  
 Searches this string for the first match of a character or substring.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 A substring to search for.  
  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 The index of the character in the string to begin the search with, or 0 to start from the beginning.  
  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 A single character to search for.  
  
### Return Value  
 The zero-based index of the first character in this                         <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> object that matches the requested substring or characters; -1 if the substring or character is not found.  
  
### Remarks  
 The function is overloaded to accept both single characters (similar to the run-time function                         <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>) and strings (similar to                         <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#114](../vs140/codesnippet/CPP/cstringt-class_9.cpp)]  
  
##  \<a name="cstringt__findoneof">\</a>  CStringT::FindOneOf  
 Searches this string for the first character that matches any character contained in                 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 String containing characters for matching.  
  
### Return Value  
 The zero-based index of the first character in this string that is also in                         <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>; –1 if there is no match.  
  
### Remarks  
 Finds the first occurrence of any of the characters in                         <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#115](../vs140/codesnippet/CPP/cstringt-class_10.cpp)]  
  
##  \<a name="cstringt__format">\</a>  CStringT::Format  
 Writes formatted data to a                 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> in the same way that                 [sprintf_s](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md) formats data into a C-style character array.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 The string resource identifier that contains the format-control string.  
  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 A format-control string.  
  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 Optional arguments.  
  
### Remarks  
 This function formats and stores a series of characters and values in the                         <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>. Each optional argument (if any) is converted and output according to the corresponding format specification in                         <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> or from the string resource identified by                         <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>.  
  
 The call will fail if the string object itself is offered as a parameter to                         <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>. For example, the following code will cause unpredictable results:  
  
 [!code[NVC_ATLMFC_Utilities#116](../vs140/codesnippet/CPP/cstringt-class_11.cpp)]  
  
 For more information, see                         [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#117](../vs140/codesnippet/CPP/cstringt-class_12.cpp)]  
  
##  \<a name="cstringt__formatmessage">\</a>  CStringT::FormatMessage  
 Formats a message string.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 The string resource identifier that contains the unformatted message text.  
  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 Points to the format-control string. It will be scanned for inserts and formatted accordingly. The format string is similar to run-time function                                 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>-style format strings, except it allows for the parameters to be inserted in an arbitrary order.  
  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 Optional arguments.  
  
### Remarks  
 The function requires a message definition as input. The message definition is determined by                         <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> or from the string resource identified by                         <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>. The function copies the formatted message text to the                         <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> object, processing any embedded insert sequences if requested.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> attempts to allocate system memory for the newly formatted string. If this attempt fails, a memory exception is automatically thrown.  
  
 Each insert must have a corresponding parameter following the                         <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> parameter. Within the message text, several escape sequences are supported for dynamically formatting the message. For more information, see the Windows                         [FormatMessage](http://msdn.microsoft.com/library/windows/desktop/ms679351) function in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#118](../vs140/codesnippet/CPP/cstringt-class_13.cpp)]  
  
##  \<a name="cstringt__formatmessagev">\</a>  CStringT::FormatMessageV  
 Formats a message string using a variable argument list.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 Points to the format-control string. It will be scanned for inserts and formatted accordingly. The format string is similar to run-time function                                 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>-style format strings, except it allows for the parameters to be inserted in an arbitrary order.  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 Pointer to a list of arguments.  
  
### Remarks  
 The function requires a message definition as input, determined by                         <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>. The function copies the formatted message text and a variable list of arguments to the                         <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> object, processing any embedded insert sequences if requested.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> calls                             [FormatMessage](#cstringt__formatmessage), which attempts to allocate system memory for the newly formatted string. If this attempt fails, a memory exception is automatically thrown.  
  
 For more information, see the Windows                         [FormatMessage](http://msdn.microsoft.com/library/windows/desktop/ms679351) function in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cstringt__formatv">\</a>  CStringT::FormatV  
 Formats a message string using a variable argument list.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 Points to the format-control string. It will be scanned for inserts and formatted accordingly. The format string is similar to run-time function                                 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>-style format strings, except it allows for the parameters to be inserted in an arbitrary order.  
  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 Pointer to a list of arguments.  
  
### Remarks  
 Writes a formatted string and a variable list of arguments to a                         <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> string in the same way that                         <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> formats data into a C-style character array.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#119](../vs140/codesnippet/CPP/cstringt-class_14.cpp)]  
  
 [!code[NVC_ATLMFC_Utilities#120](../vs140/codesnippet/CPP/cstringt-class_15.cpp)]  
  
##  \<a name="cstringt__getenvironmentvariable">\</a>  CStringT::GetEnvironmentVariable  
 Sets the string to the value of the specified environment variable.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the environment variable.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Retrieves the value of the specified variable from the environment block of the calling process. The value is in the form of a null-terminated string of characters.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#121](../vs140/codesnippet/CPP/cstringt-class_16.cpp)]  
  
##  \<a name="cstringt__insert">\</a>  CStringT::Insert  
 Inserts a single character or a substring at the given index within the string.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>  
 The index of the character before which the insertion will take place.  
  
 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 A pointer to the substring to be inserted.  
  
 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
 The character to be inserted.  
  
### Return Value  
 The length of the changed string.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> parameter identifies the first character that will be moved to make room for the character or substring. If                         <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> is zero, the insertion will occur before the entire string. If                         <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> is higher than the length of the string, the function will concatenate the present string and the new material provided by either                         <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#122](../vs140/codesnippet/CPP/cstringt-class_17.cpp)]  
  
##  \<a name="cstringt__left">\</a>  CStringT::Left  
 Extracts the leftmost                 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> characters from this                 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> object and returns a copy of the extracted substring.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 The number of characters to extract from this                                 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> object that contains a copy of the specified range of characters. The returned                         <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> object may be empty.  
  
### Remarks  
 If                         <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> exceeds the string length, then the entire string is extracted.                         <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> is similar to the Basic                         <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> function.  
  
 For multi-byte character sets (MBCS),                         <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> treats each 8-bit sequence as a character, so that                         <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> returns the number of multi-byte characters multiplied by two.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#123](../vs140/codesnippet/CPP/cstringt-class_18.cpp)]  
  
##  \<a name="cstringt__loadstring">\</a>  CStringT::LoadString  
 Reads a Windows string resource, identified by                 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>, into an existing                 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 A handle to the instance of the module.  
  
 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 A Windows string resource ID.  
  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 The language of the string resource.  
  
### Return Value  
 Nonzero if resource load was successful; otherwise 0.  
  
### Remarks  
 Loads the string resource (                        <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>) from the specified module (                        <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>) using the specified language (                        <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#124](../vs140/codesnippet/CPP/cstringt-class_19.cpp)]  
  
##  \<a name="cstringt__makelower">\</a>  CStringT::MakeLower  
 Converts the                 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> object to a lowercase string.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The resulting lowercase string.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#125](../vs140/codesnippet/CPP/cstringt-class_20.cpp)]  
  
##  \<a name="cstringt__makereverse">\</a>  CStringT::MakeReverse  
 Reverses the order of the characters in the                 <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The resulting reversed string.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#126](../vs140/codesnippet/CPP/cstringt-class_21.cpp)]  
  
##  \<a name="cstringt__makeupper">\</a>  CStringT::MakeUpper  
 Converts the                 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> object to an uppercase string.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The resulting uppercase string.  
  
### Remarks  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#127](../vs140/codesnippet/CPP/cstringt-class_22.cpp)]  
  
##  \<a name="cstringt__mid">\</a>  CStringT::Mid  
 Extracts a substring of length                 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> characters from this                 <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> object, starting at position                 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> (zero-based).  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>  
 The zero-based index of the first character in this                                 <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> object that is to be included in the extracted substring.  
  
 <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 The number of characters to extract from this                                 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> object. If this parameter is not supplied, then the remainder of the string is extracted.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> object that contains a copy of the specified range of characters. Note that the returned                         <CodeContentPlaceHolder>322\</CodeContentPlaceHolder> object may be empty.  
  
### Remarks  
 The function returns a copy of the extracted substring.                         <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> is similar to the Basic Mid function (except that indexes in Basic are one-based).  
  
 For multibyte character sets (MBCS),                         <CodeContentPlaceHolder>324\</CodeContentPlaceHolder> refers to each 8-bit character; that is, a lead and trail byte in one multibyte character are counted as two characters.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#128](../vs140/codesnippet/CPP/cstringt-class_23.cpp)]  
  
##  \<a name="cstringt__oemtoansi">\</a>  CStringT::OemToAnsi  
 Converts all the characters in this                 <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> object from the OEM character set to the ANSI character set.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 This function is not available if                         <CodeContentPlaceHolder>326\</CodeContentPlaceHolder> is defined.  
  
### Example  
 See the example for                                 [CStringT::AnsiToOem](#cstringt__ansitooem).  
  
##  \<a name="cstringt__operator__add">\</a>  CStringT::operator +  
 Concatenates two strings or a character and a string.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>  
 An ANSI or Unicode character to concatenate with a string.  
  
 <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>  
 An ANSI or Unicode character to concatenate with a string.  
  
 <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> to concatenate with a string or character.  
  
 <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> to concatenate with a string or character.  
  
 <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string to concatenate with a string or character.  
  
 <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>  
 A pointer to a string to concatenate with a string or character.  
  
### Remarks  
 There are seven overload forms of the                         <CodeContentPlaceHolder>335\</CodeContentPlaceHolder> function. The first version concatenates two existing                         <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> objects. The next two concatenate a                         <CodeContentPlaceHolder>337\</CodeContentPlaceHolder> object and a null-terminated string. The next two concatenate a                         <CodeContentPlaceHolder>338\</CodeContentPlaceHolder> object and an ANSI character. The last two concatenate a                         <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> object and a Unicode character.  
  
> [!NOTE]
>  Although it is possible to create                             <CodeContentPlaceHolder>340\</CodeContentPlaceHolder> instances that contain embedded null characters, we recommend against it. Calling methods and operators on                             <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> objects that contain embedded null characters can produce unintended results.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#140](../vs140/codesnippet/CPP/cstringt-class_24.cpp)]  
  
##  \<a name="cstringt__operator__add_eq">\</a>  CStringT::operator +=  
 Concatenates characters to the end of the string.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 str  
 A reference to a                                 <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
 A boolean specifying whether the project is an MFC DLL or not.  
  
 <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
 The string base type.  
  
 <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
 A variant object to concatenate to this string.  
  
 <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>  
 An ANSI or Unicode character to concatenate with a string.  
  
 <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
 A pointer to the original string being concatenated.  
  
 <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> to concatenate to this string.  
  
### Remarks  
 The operator accepts another                         <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> object, a character pointer, or a single character. You should be aware that memory exceptions can occur whenever you use this concatenation operator because new storage can be allocated for characters added to this                         <CodeContentPlaceHolder>351\</CodeContentPlaceHolder> object.  
  
 For information on                         <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>, see the Remarks section of                         [CStringT::CStringT](#cstringt__cstringt).  
  
> [!NOTE]
>  Although it is possible to create                             <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> instances that contain embedded null characters, we recommend against it. Calling methods and operators on                             <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> objects that contain embedded null characters can produce unintended results.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#141](../vs140/codesnippet/CPP/cstringt-class_25.cpp)]  
  
##  \<a name="cstringt__operator__eq_eq">\</a>  CStringT::operator ==  
 Determines whether two strings are logically equal.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>355\</CodeContentPlaceHolder>  
 An ANSI or Unicode character for comparison.  
  
 <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>  
 An ANSI or Unicode character for comparison.  
  
 <CodeContentPlaceHolder>357\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>358\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>359\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>360\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
 <CodeContentPlaceHolder>362\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
### Remarks  
 Tests whether a string or character on the left side is equal to a string or character on the right side, and returns TRUE or FALSE accordingly.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#142](../vs140/codesnippet/CPP/cstringt-class_26.cpp)]  
  
##  \<a name="cstringt__operator__neq">\</a>  CStringT::operator !=  
 Determines whether two strings are logically not equal.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
 An ANSI or Unicode character to concatenate with a string.  
  
 <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 An ANSI or Unicode character to concatenate with a string.  
  
 <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>366\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>368\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
 <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
### Remarks  
 Tests if a string or character on the left side is not equal to a string or character on the right side.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#143](../vs140/codesnippet/CPP/cstringt-class_27.cpp)]  
  
##  \<a name="cstringt__operator__lt_">\</a>  CStringT::operator &lt;  
 Determines whether the string on the left side of the operator is less than the string on the right side.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>372\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>374\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
 <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
### Remarks  
 A lexicographical comparison between strings, character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, and so the strings are equal.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#144](../vs140/codesnippet/CPP/cstringt-class_28.cpp)]  
  
##  \<a name="cstringt__operator__gt_">\</a>  CStringT::operator &gt;  
 Determines whether the string on the left side of the operator is greater than the string on the right side.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>378\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>379\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>380\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>381\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
 <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
### Remarks  
 A lexicographical comparison between strings, character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, so the strings are equal.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#145](../vs140/codesnippet/CPP/cstringt-class_29.cpp)]  
  
##  \<a name="cstringt__operator__lt__eq">\</a>  CStringT::operator &lt;=  
 Determines whether the string on the left side of the operator is less than or equal to the string on the right side.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>383\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>384\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>385\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>386\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
 <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string for comparison.  
  
### Remarks  
 A lexicographical comparison between strings, character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, so the strings are equal.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#146](../vs140/codesnippet/CPP/cstringt-class_30.cpp)]  
  
##  \<a name="cstringt__operator__gt__eq">\</a>  CStringT::operator &gt;=  
 Determines whether the string on the left side of the operator is greater than or equal to the string on the right side.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>390\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>391\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> for comparison.  
  
 <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>  
 A pointer to a string for comparison.  
  
 <CodeContentPlaceHolder>394\</CodeContentPlaceHolder>  
 A pointer to a string for comparison.  
  
### Remarks  
 A lexicographical comparison between strings, character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, so the strings are equal.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#147](../vs140/codesnippet/CPP/cstringt-class_31.cpp)]  
  
##  \<a name="cstringt__remove">\</a>  CStringT::Remove  
 Removes all instances of the specified character from the string.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>395\</CodeContentPlaceHolder>  
 The character to be removed from a string.  
  
### Return Value  
 The count of characters removed from the string. Zero if the string is not changed.  
  
### Remarks  
 Comparisons for the character are case sensitive.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#129](../vs140/codesnippet/CPP/cstringt-class_32.cpp)]  
  
##  \<a name="cstringt__replace">\</a>  CStringT::Replace  
 There are two versions of                 <CodeContentPlaceHolder>396\</CodeContentPlaceHolder>.The first version replaces one or more copies of a substring by using another substring. Both substrings are null-terminated. The second version replaces one or more copies of a character by using another character. Both versions operate on the character data stored in                 <CodeContentPlaceHolder>397\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>398\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string to be replaced by                                 <CodeContentPlaceHolder>399\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>400\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that replaces                                 <CodeContentPlaceHolder>401\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>402\</CodeContentPlaceHolder>  
 The character to be replaced by                                 <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>404\</CodeContentPlaceHolder>  
 The character replacing                                 <CodeContentPlaceHolder>405\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns the number of replaced instances of the character or substring, or zero if the string is not changed.  
  
### Remarks  
 <CodeContentPlaceHolder>406\</CodeContentPlaceHolder> can change the string length because                         <CodeContentPlaceHolder>407\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>408\</CodeContentPlaceHolder> do not have to be the same length, and several copies of the old substring can be changed to the new one. The function performs a case-sensitive match.  
  
 Examples of                         <CodeContentPlaceHolder>409\</CodeContentPlaceHolder> instances are                         <CodeContentPlaceHolder>410\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>411\</CodeContentPlaceHolder>, and                         <CodeContentPlaceHolder>412\</CodeContentPlaceHolder>.  
  
 For                         <CodeContentPlaceHolder>413\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>414\</CodeContentPlaceHolder> works with ANSI or multibyte (MBCS) characters. For                         <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>416\</CodeContentPlaceHolder> works with wide characters.  
  
 For                         <CodeContentPlaceHolder>417\</CodeContentPlaceHolder>, the character data type is selected at compile time, based on whether the constants in the following table are defined.  
  
|Defined Constant|Character Data Type|  
|----------------------|-------------------------|  
|<CodeContentPlaceHolder>418\</CodeContentPlaceHolder>|Wide characters|  
|<CodeContentPlaceHolder>419\</CodeContentPlaceHolder>|Multi-byte characters|  
|Neither|Single-byte characters|  
|Both|Undefined|  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#200](../vs140/codesnippet/CPP/cstringt-class_33.cpp)]  
  
##  \<a name="cstringt__reversefind">\</a>  CStringT::ReverseFind  
 Searches this                 <CodeContentPlaceHolder>420\</CodeContentPlaceHolder> object for the last match of a character.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>421\</CodeContentPlaceHolder>  
 The character to search for.  
  
### Return Value  
 The zero-based index of the last character in this                         <CodeContentPlaceHolder>422\</CodeContentPlaceHolder> object that matches the requested character, or –1 if the character is not found.  
  
### Remarks  
 The function is similar to the run-time function                         <CodeContentPlaceHolder>423\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#130](../vs140/codesnippet/CPP/cstringt-class_34.cpp)]  
  
##  \<a name="cstringt__right">\</a>  CStringT::Right  
 Extracts the last (that is, rightmost)                 <CodeContentPlaceHolder>424\</CodeContentPlaceHolder> characters from this                 <CodeContentPlaceHolder>425\</CodeContentPlaceHolder> object and returns a copy of the extracted substring.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>426\</CodeContentPlaceHolder>  
 The number of characters to extract from this                                 <CodeContentPlaceHolder>427\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>428\</CodeContentPlaceHolder> object that contains a copy of the specified range of characters. Note that the returned                         <CodeContentPlaceHolder>429\</CodeContentPlaceHolder> object can be empty.  
  
### Remarks  
 If                         <CodeContentPlaceHolder>430\</CodeContentPlaceHolder> exceeds the string length, then the entire string is extracted.                         <CodeContentPlaceHolder>431\</CodeContentPlaceHolder> is similar to the Basic                         <CodeContentPlaceHolder>432\</CodeContentPlaceHolder> function (except that indexes in Basic are zero-based).  
  
 For multibyte character sets (MBCS),                         <CodeContentPlaceHolder>433\</CodeContentPlaceHolder> refers to each 8-bit character; that is, a lead and trail byte in one multibyte character are counted as two characters.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#131](../vs140/codesnippet/CPP/cstringt-class_35.cpp)]  
  
##  \<a name="cstringt__setsysstring">\</a>  CStringT::SetSysString  
 Reallocates the                 <CodeContentPlaceHolder>434\</CodeContentPlaceHolder> pointed to by                 <CodeContentPlaceHolder>435\</CodeContentPlaceHolder> and copies the contents of the                 <CodeContentPlaceHolder>436\</CodeContentPlaceHolder> object into it, including the                 <CodeContentPlaceHolder>437\</CodeContentPlaceHolder> character.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>438\</CodeContentPlaceHolder>  
 A pointer to a character string.  
  
### Return Value  
 The new string.  
  
### Remarks  
 Depending on the contents of the                         <CodeContentPlaceHolder>439\</CodeContentPlaceHolder> object, the value of the                         <CodeContentPlaceHolder>440\</CodeContentPlaceHolder> referenced by                         <CodeContentPlaceHolder>441\</CodeContentPlaceHolder> can change. The function throws a                         <CodeContentPlaceHolder>442\</CodeContentPlaceHolder> if insufficient memory exists.  
  
 This function is normally used to change the value of strings passed by reference for Automation.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#132](../vs140/codesnippet/CPP/cstringt-class_36.cpp)]  
  
##  \<a name="cstringt__spanexcluding">\</a>  CStringT::SpanExcluding  
 Extracts characters from the string, starting with the first character, that are not in the set of characters identified by                 <CodeContentPlaceHolder>443\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>444\</CodeContentPlaceHolder>  
 A string interpreted as a set of characters.  
  
### Return Value  
 A substring that contains characters in the string that are not in                         <CodeContentPlaceHolder>445\</CodeContentPlaceHolder>, beginning with the first character in the string and ending with the first character found in the string that is also in                         <CodeContentPlaceHolder>446\</CodeContentPlaceHolder> (that is, starting with the first character in the string and up to but excluding the first character in the string that is found                         <CodeContentPlaceHolder>447\</CodeContentPlaceHolder>). It returns the entire string if no character in                         <CodeContentPlaceHolder>448\</CodeContentPlaceHolder> is found in the string.  
  
### Remarks  
 <CodeContentPlaceHolder>449\</CodeContentPlaceHolder> extracts and returns all characters preceding the first occurrence of a character from                         <CodeContentPlaceHolder>450\</CodeContentPlaceHolder> (in other words, the character from                         <CodeContentPlaceHolder>451\</CodeContentPlaceHolder> and all characters following it in the string, are not returned). If no character from                         <CodeContentPlaceHolder>452\</CodeContentPlaceHolder> is found in the string, then                         <CodeContentPlaceHolder>453\</CodeContentPlaceHolder> returns the entire string.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#133](../vs140/codesnippet/CPP/cstringt-class_37.cpp)]  
  
##  \<a name="cstringt__spanincluding">\</a>  CStringT::SpanIncluding  
 Extracts characters from the string, starting with the first character, that are in the set of characters identified by                 <CodeContentPlaceHolder>454\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>455\</CodeContentPlaceHolder>  
 A string interpreted as a set of characters.  
  
### Return Value  
 A substring that contains characters in the string that are in                         <CodeContentPlaceHolder>456\</CodeContentPlaceHolder>, beginning with the first character in the string and ending when a character is found in the string that is not in                         <CodeContentPlaceHolder>457\</CodeContentPlaceHolder> returns an empty substring if the first character in the string is not in the specified set.  
  
### Remarks  
 If the first character of the string is not in the character set, then                         <CodeContentPlaceHolder>458\</CodeContentPlaceHolder> returns an empty string. Otherwise, it returns a sequence of consecutive characters that are in the set.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#134](../vs140/codesnippet/CPP/cstringt-class_38.cpp)]  
  
##  \<a name="cstringt__tokenize">\</a>  CStringT::Tokenize  
 Finds the next token in a target string  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>459\</CodeContentPlaceHolder>  
 A string containing token delimiters. The order of these delimiters is not important.  
  
 <CodeContentPlaceHolder>460\</CodeContentPlaceHolder>  
 The zero-based index to begin the search.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>461\</CodeContentPlaceHolder> object containing the current token value.  
  
### Remarks  
 The                         <CodeContentPlaceHolder>462\</CodeContentPlaceHolder> function finds the next token in the target string. The set of characters in                         <CodeContentPlaceHolder>463\</CodeContentPlaceHolder> specifies possible delimiters of the token to be found. On each call to                         <CodeContentPlaceHolder>464\</CodeContentPlaceHolder> the function starts at                         <CodeContentPlaceHolder>465\</CodeContentPlaceHolder>, skips leading delimiters, and returns a                         <CodeContentPlaceHolder>466\</CodeContentPlaceHolder> object containing the current token, which is the string of characters up to the next delimiter character. The value of                         <CodeContentPlaceHolder>467\</CodeContentPlaceHolder> is updated to be the position following the ending delimiter character, or -1 if the end of the string was reached. More tokens can be broken out of the remainder of the target string by a series of calls to                         <CodeContentPlaceHolder>468\</CodeContentPlaceHolder>, using                         <CodeContentPlaceHolder>469\</CodeContentPlaceHolder> to keep track of where in the string the next token is to be read. When there are no more tokens the function will return an empty string and                         <CodeContentPlaceHolder>470\</CodeContentPlaceHolder> will be set to -1.  
  
 Unlike the CRT tokenize functions like                         [strtok_s](../vs140/strtok_s--_strtok_s_l--wcstok_s--_wcstok_s_l--_mbstok_s--_mbstok_s_l.md),                         <CodeContentPlaceHolder>471\</CodeContentPlaceHolder> does not modify the target string.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#135](../vs140/codesnippet/CPP/cstringt-class_39.cpp)]  
  
### Remarks  
 The output from this example is as follows:  
  
 <CodeContentPlaceHolder>472\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>473\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>474\</CodeContentPlaceHolder>  
  
##  \<a name="cstringt__trim">\</a>  CStringT::Trim  
 Trims leading and trailing characters from the string.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>475\</CodeContentPlaceHolder>  
 The target character to be trimmed.  
  
 <CodeContentPlaceHolder>476\</CodeContentPlaceHolder>  
 A pointer to a string containing the target characters to be trimmed. All leading and trailing occurrences of characters in                                 <CodeContentPlaceHolder>477\</CodeContentPlaceHolder> will be trimmed from the                                 <CodeContentPlaceHolder>478\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the trimmed string.  
  
### Remarks  
 Removes all leading and trailing occurrences of one of the following:  
  
-   The character specified by                                 <CodeContentPlaceHolder>479\</CodeContentPlaceHolder>  
  
-   All characters found in the string specified by                                 <CodeContentPlaceHolder>480\</CodeContentPlaceHolder>  
  
-   Whitespace.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#136](../vs140/codesnippet/CPP/cstringt-class_40.cpp)]  
  
### Remarks  
 The output from this example is as follows:  
  
 <CodeContentPlaceHolder>481\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>482\</CodeContentPlaceHolder>  
  
##  \<a name="cstringt__trimleft">\</a>  CStringT::TrimLeft  
 Trims leading characters from the string.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>483\</CodeContentPlaceHolder>  
 The target character to be trimmed.  
  
 <CodeContentPlaceHolder>484\</CodeContentPlaceHolder>  
 A pointer to a string containing the target characters to be trimmed. All leading occurrences of characters in                                 <CodeContentPlaceHolder>485\</CodeContentPlaceHolder> will be trimmed from the                                 <CodeContentPlaceHolder>486\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The resulting trimmed string.  
  
### Remarks  
 Removes all leading and trailing occurrences of one of the following:  
  
-   The character specified by                                 <CodeContentPlaceHolder>487\</CodeContentPlaceHolder>  
  
-   All characters found in the string specified by                                 <CodeContentPlaceHolder>488\</CodeContentPlaceHolder>  
  
-   Whitespace.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#137](../vs140/codesnippet/CPP/cstringt-class_41.cpp)]  
  
##  \<a name="cstringt__trimright">\</a>  CStringT::TrimRight  
 Trims trailing characters from the string.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>489\</CodeContentPlaceHolder>  
 The target character to be trimmed.  
  
 <CodeContentPlaceHolder>490\</CodeContentPlaceHolder>  
 A pointer to a string containing the target characters to be trimmed. All trailing occurrences of characters in                                 <CodeContentPlaceHolder>491\</CodeContentPlaceHolder> will be trimmed from the                                 <CodeContentPlaceHolder>492\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the                         <CodeContentPlaceHolder>493\</CodeContentPlaceHolder> object that contains the trimmed string.  
  
### Remarks  
 Removes trailing occurrences of one of the following:  
  
-   The character specified by                                 <CodeContentPlaceHolder>494\</CodeContentPlaceHolder>  
  
-   All characters found in the string specified by                                 <CodeContentPlaceHolder>495\</CodeContentPlaceHolder>  
  
-   Whitespace.  
  
 The                         <CodeContentPlaceHolder>496\</CodeContentPlaceHolder> version accepts one character parameter and removes all copies of that character from the end of                         <CodeContentPlaceHolder>497\</CodeContentPlaceHolder> string data. It starts from the end of the string and works toward the front. It stops when it finds a different character or when                         <CodeContentPlaceHolder>498\</CodeContentPlaceHolder> runs out of character data.  
  
 The                         <CodeContentPlaceHolder>499\</CodeContentPlaceHolder> version accepts a null-terminated string that contains all the different characters to search for. It removes all copies of those characters in the                         <CodeContentPlaceHolder>500\</CodeContentPlaceHolder> object. It starts at the end of the string and works toward the front. It stops when it finds a character that is not in the target string, or when                         <CodeContentPlaceHolder>501\</CodeContentPlaceHolder> runs out of character data. It does not try to match the whole target string to a substring at the end of                         <CodeContentPlaceHolder>502\</CodeContentPlaceHolder>.  
  
 The                         <CodeContentPlaceHolder>503\</CodeContentPlaceHolder> version requires no parameters. It trims any trailing whitespace characters from the end of the                         <CodeContentPlaceHolder>504\</CodeContentPlaceHolder> string. Whitespace characters can be line breaks, spaces, or tabs.  
  
-  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#138](../vs140/codesnippet/CPP/cstringt-class_42.cpp)]  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)   
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)