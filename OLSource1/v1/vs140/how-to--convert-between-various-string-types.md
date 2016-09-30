---
title: "How to: Convert Between Various String Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "converting string types"
  - "string conversion [C++]"
  - "strings [C++], converting"
ms.assetid: e7e4f741-3c82-45f0-b8c0-1e1e343b0e77
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert Between Various String Types
This topic demonstrates how to convert various Visual C++ string types into other strings. The strings types that are covered include <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, [_bstr_t](../vs140/_bstr_t-class.md), [CComBSTR](../vs140/ccombstr-class.md), [CString](../vs140/using-cstring.md), [basic_string](../vs140/basic_string-class.md), and \<xref:System.String*?displayProperty=fullName>. In all cases, a copy of the string is made when converted to the new type. Any changes made to the new string will not affect the original string, and vice versa.  
  
## Converting from char *  
  
## Example  
  
### Description  
 This example demonstrates how to convert from a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to the other string types listed above. A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> string (also known as a C style string) uses a null character to indicate the end of the string. C style strings usually require one byte per character, but can also use two bytes. In the examples below, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> strings are sometimes referred to as multibyte character strings because of the string data that results from converting from Unicode strings. Single byte and multibyte character (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) functions can operate on <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> strings.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Converting from wchar_t *  
  
## Example  
  
### Description  
 This example demonstrates how to convert from a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to the other string types listed above. Several string types, including <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, implement wide character formats. To convert a string between a multibyte and a wide character format, you can use a single function call like <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or a constructor invocation for a class like <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Converting from _bstr_t  
  
## Example  
  
### Description  
 This example demonstrates how to convert from a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to the other string types listed above. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object is a way to encapsulate wide character <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> strings. A BSTR string has a length value and does not use a null character to terminate the string, but the string type you convert to may require a terminating null.  
  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Converting from CComBSTR  
  
## Example  
  
### Description  
 This example demonstrates how to convert from a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to the other string types listed above. Like _bstr_t, a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object is a way to encapsulate wide character BSTR strings. A BSTR string has a length value and does not use a null character to terminate the string, but the string type you convert to may require a terminating null.  
  
### Code  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Converting from CString  
  
## Example  
  
### Description  
 This example demonstrates how to convert from a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to the other string types listed above. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is based on the TCHAR data type, which in turn depends on whether the symbol <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is defined. If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is not defined, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is defined to be char and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> contains a multibyte character string; if <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is defined, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is defined to be <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> contains a wide character string.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is the multibyte string always version of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is the wide character string only version. Neither <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to determine how they should compile. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> are used in this example to clarify minor differences in buffer size allocation and output handling.  
  
### Code  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## Converting from basic_string  
  
## Example  
  
### Description  
 This example demonstrates how to convert from a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to the other string types listed above.  
  
### Code  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## Converting from System::String  
  
## Example  
  
### Description  
 This example demonstrates how to convert from a wide character (Unicode) \<xref:String*?displayProperty=fullName> to the other string types listed above.  
  
### Code  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
## See Also  
 [Visual C++ Guided Tour](assetId:///499cb66f-7df1-45d6-8b6b-33d94fd1f17c)   
 [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md)   
 [CString Operations Relating to C-Style Strings](../vs140/cstring-operations-relating-to-c-style-strings.md)   
 [How to: Convert Standard String to System::String](../vs140/how-to--convert-standard-string-to-system--string.md)   
 [How to: Convert System::String to Standard String](../vs140/how-to--convert-system--string-to-standard-string.md)   
 [How to: Convert System::String to wchar_t* or char\*](../vs140/how-to--convert-system--string-to-wchar_t--or-char-.md)   
 [Programming with CComBSTR](../vs140/programming-with-ccombstr--atl-.md)   
 [mbstowcs_s, _mbstowcs_s_l](../vs140/mbstowcs_s--_mbstowcs_s_l.md)   
 [wcstombs_s, _wcstombs_s_l](../vs140/wcstombs_s--_wcstombs_s_l.md)   
 [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md)   
 [strcat_s, wcscat_s, _mbscat_s](../vs140/strcat_s--wcscat_s--_mbscat_s.md)   
 [pin_ptr](../vs140/pin_ptr--c---cli-.md)