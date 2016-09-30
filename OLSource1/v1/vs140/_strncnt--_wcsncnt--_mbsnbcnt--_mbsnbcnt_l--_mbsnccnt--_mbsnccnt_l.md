---
title: "_strncnt, _wcsncnt, _mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_mbsnbcnt_l"
  - "_mbsnccnt"
  - "_wcsncnt"
  - "_strncnt"
  - "_mbsnccnt_l"
  - "_mbsnbcnt"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbsnbcnt"
  - "wcsncnt"
  - "_tcsnbcnt"
  - "_mbsnccnt"
  - "_ftcsnbcnt"
  - "mbsnbcnt"
  - "strncnt"
  - "mbsnbcnt_l"
  - "mbsnccnt_l"
  - "mbsnccnt"
  - "_strncnt"
  - "_wcsncnt"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_strncnt function"
  - "_mbsnbcnt function"
  - "_mbsnbcnt_l function"
  - "_mbsnccnt_l function"
  - "mbsnbcnt_l function"
  - "mbsnbcnt function"
  - "tcsnbcnt function"
  - "mbsnccnt_l function"
  - "strncnt function"
  - "_tcsnbcnt function"
  - "mbsnccnt function"
  - "wcsncnt function"
  - "_mbsnccnt function"
  - "_wcsncnt function"
ms.assetid: 2a022e9e-a307-4acb-a66b-e56e5357f848
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strncnt, _wcsncnt, _mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l
Returns the number of characters or bytes within a specified count.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 String to be examined.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Number of characters or bytes to be examined in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> return the number of bytes found in the first <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> of multibyte characters of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> return the number of characters found in the first <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> of bytes of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If a NULL character is encountered before the examination of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> has completed, they return the number of bytes or characters found before the NULL character. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> consists of fewer than <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> characters or bytes, they return the number of characters or bytes in the string. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is less than zero, they return 0. In previous versions, these functions had a return value of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns the number of characters in the first <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> bytes of the single-byte string <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns the number of characters in the first <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> wide characters of the wide-character string <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> count the number of bytes found in the first <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> of multibyte characters of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> replace <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and should be used in place of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> count the number of characters found in the first <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> of bytes of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> encounter a NULL in the second byte of a double-byte character, the first byte is also considered to be NULL and is not included in the returned count value. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> replace <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and should be used in place of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is a null pointer or is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is 0, these functions invoke the invalid parameter handler as described in [Parameter Validation](../vs140/parameter-validation.md), <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, and the function returns 0.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|Routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|-------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|\<tchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)