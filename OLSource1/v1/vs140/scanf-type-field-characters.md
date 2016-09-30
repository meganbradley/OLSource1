---
title: "scanf Type Field Characters"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "scanf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "scanf function, type field characters"
ms.assetid: 5d546a84-715b-44ca-b1c5-bbe997f9ff62
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scanf Type Field Characters
The following information applies to any of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> family of functions, including the secure versions, such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> character is the only required format field; it appears after any optional format fields. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> character determines whether the associated argument is interpreted as a character, string, or number.  
  
### Type Characters for scanf functions  
  
|Character|Type of input expected|Type of argument|Size argument in secure version?|  
|---------------|----------------------------|----------------------|--------------------------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Character. When used with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions, specifies single-byte character; when used with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions, specifies wide character. White-space characters that are ordinarily skipped are read when <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is specified. To read next non–white-space single-byte character, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; to read next non–white-space wide character, use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|Pointer to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when used with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> functions, pointer to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> when used with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functions.|Required. Size does not include space for a null terminator.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Opposite size character. When used with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions, specifies wide character; when used with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> functions, specifies single-byte character. White-space characters that are ordinarily skipped are read when <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is specified. To read next non–white-space single-byte character, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>; to read next non–white-space wide character, use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|Pointer to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> when used with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> functions, pointer to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> when used with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> functions.|Required. Size argument does not include space for a null terminator.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Decimal integer.|Pointer to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|No.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|An integer. Hexadecimal if the input string begins with "0x" or "0X", octal if the string begins with "0", otherwise decimal.|Pointer to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|No.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Octal integer.|Pointer to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|No.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|A pointer address in hexadecimal digits. The maximum number of digits read depends on the size of a pointer (32 or 64 bits), which depends on the machine architecture. "0x" or "0X" are accepted as prefixes.|Pointer to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|No.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Unsigned decimal integer.|Pointer to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|No.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Hexadecimal integer.|Pointer to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|No.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Floating-point value consisting of optional sign (+ or –), series of one or more decimal digits containing decimal point, and optional exponent ("e" or "E") followed by an optionally signed integer value.|Pointer to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|No.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|No input read from stream or buffer.|Pointer to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, into which is stored number of characters successfully read from stream or buffer up to that point in current call to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> functions or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> functions.|No.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|String, up to first white-space character (space, tab or newline). To read strings not delimited by space characters, use set of square brackets (<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>), as discussed in [scanf Width Specification](../vs140/scanf-width-specification.md).|When used with <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> functions, signifies single-byte character array; when used with <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> functions, signifies wide-character array. In either case, character array must be large enough for input field plus terminating null character, which is automatically appended.|Required. Size includes space for a null terminator.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Opposite-size character string, up to first white-space character (space, tab or newline). To read strings not delimited by space characters, use set of square brackets (<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>), as discussed in [scanf Width Specification](../vs140/scanf-width-specification.md).|When used with <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> functions, signifies wide-character array; when used with <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> functions, signifies single-byte–character array. In either case, character array must be large enough for input field plus terminating null character, which is automatically appended.|Required. Size includes space for a null terminator.|  
  
 The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> specifiers (see [printf Type Field Characters](../vs140/printf-type-field-characters.md)) are not available with <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 The size arguments, if required, should be passed in the parameter list immediately following the argument they apply to. For example, the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 reads a string with a maximum length of 10 into <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, and a string with a maximum length of 8 into <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. The buffer sizes should be at least one more than the width specifications since space must be reserved for the null terminator.  
  
 The format string can handle single-byte or wide character input regardless of whether the single-byte character or wide-character version of the function is used. Thus, to read single-byte or wide characters with <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> functions and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> functions, use format specifiers as follows.  
  
|To read character as|Use this function|With these format specifiers|  
|--------------------------|-----------------------|----------------------------------|  
|single byte|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder> functions|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|  
|single byte|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder> functions|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|  
|wide|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder> functions|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|  
|wide|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder> functions|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|  
  
 To scan strings with <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> functions, and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> functions, use the above table with format type-specifiers <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
## See Also  
 [scanf, _scanf_l, wscanf, _wscanf_l](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)