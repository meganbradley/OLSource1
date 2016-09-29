---
title: "Character Classification"
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
  - "c.types.character"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "character classification routines"
  - "characters, testing"
ms.assetid: 3b6c8f0b-9701-407a-b384-9086698773f5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Character Classification
Each of these routines tests a specified single-byte character, wide character, or multibyte character for satisfaction of a condition. (By definition, the ASCII character set between 0 and 127 are a subset of all multibyte-character sets. For example, Japanese katakana includes ASCII as well as non-ASCII characters.)  
  
 The test conditions are affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale](../VS_csharp/setlocale--_wsetlocale.md) for more information. The versions of these functions without the `_l` suffix use the current locale for this locale-dependent behavior; the versions with the `_l` suffix are identical except that they use the locale parameter passed in instead.  
  
 Generally these routines execute faster than tests you might write and should be favored over. For example, the following code executes slower than a call to `isalpha(c)`:  
  
```  
if ((c >= 'A') && (c <= 'Z')) || ((c >= 'a') && (c <= 'z'))  
    return TRUE;  
```  
  
### Character-Classification Routines  
  
|Routine|Character test condition|.NET Framework equivalent|  
|-------------|------------------------------|-------------------------------|  
|[isalnum, iswalnum, _isalnum_l, _iswalnum_l](../VS_csharp/isalnum--iswalnum--_isalnum_l--_iswalnum_l.md), [_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha\_, _ismbcdigit, _ismbcdigit_l](../VS_csharp/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Alphanumeric|[System::Char::IsLetterOrDigit](https://msdn.microsoft.com/en-us/library/system.char.isletterordigit.aspx).|  
|[_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha\_, _ismbcdigit, _ismbcdigit_l](../VS_csharp/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Alphanumeric|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[isalpha, iswalpha, _isalpha_l, _iswalpha_l](../VS_csharp/isalpha--iswalpha--_isalpha_l--_iswalpha_l.md), [_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha](../VS_csharp/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Alphabetic|[System::Char::IsLetter](https://msdn.microsoft.com/en-us/library/system.char.isletter.aspx)|  
|[__isascii, iswascii](../VS_csharp/isascii--__isascii--iswascii.md)|ASCII|[System::Char::IsLetter](https://msdn.microsoft.com/en-us/library/system.char.isletter.aspx)|  
|[isblank, iswblank, _isblank_l, _iswblank_l](../VS_csharp/isblank--iswblank--_isblank_l--_iswblank_l.md), [_ismbcsblank, _ismbcsblank_l](../VS_csharp/_ismbcgraph--_ismbcgraph_l--_ismbcprint--_ismbcprint_l--_ismbcpunct--_ismbcpunct_l--_ismbcblank--_ismbcblank_l--_ismbcspace--_ismbcspace_l.md)|Blank (space or horizontal tab)|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[iscntrl, iswcntrl, _iscntrl_l, _iswcntrl_l](../VS_csharp/iscntrl--iswcntrl--_iscntrl_l--_iswcntrl_l.md)|Control|[System::Char::IsControl](https://msdn.microsoft.com/en-us/library/system.char.iscontrol.aspx)|  
|[iscsym, iswcsym, iscsymf, iswcsymf, _iscsym_l, _iswcsym_l, _iscsymf_l, _iswcsymf_l](../VS_csharp/iscsym--iscsymf--__iscsym--__iswcsym--__iscsymf--__iswcsymf--_iscsym_l--_iswcsym_l--_iscsymf_l--_iswcsymf_l.md)|Letter, underscore, or digit|[System::Char::IsControl](https://msdn.microsoft.com/en-us/library/system.char.iscontrol.aspx)|  
|[iscsym, iswcsym, iscsymf, iswcsymf, _iscsym_l, _iswcsym_l, _iscsymf_l, _iswcsymf_l](../VS_csharp/iscsym--iscsymf--__iscsym--__iswcsym--__iscsymf--__iswcsymf--_iscsym_l--_iswcsym_l--_iscsymf_l--_iswcsymf_l.md)|Letter or underscore|[System::Char::IsControl](https://msdn.microsoft.com/en-us/library/system.char.iscontrol.aspx)|  
|[isdigit, iswdigit, _isdigit_l, _iswdigit_l](../VS_csharp/isdigit--iswdigit--_isdigit_l--_iswdigit_l.md), [_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha\_, _ismbcdigit, _ismbcdigit_l](../VS_csharp/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Decimal digit|[System::Char::IsDigit](https://msdn.microsoft.com/en-us/library/system.char.isdigit.aspx)|  
|[isgraph, iswgraph, _isgraph_l, _iswgraph_l](../VS_csharp/isgraph--iswgraph--_isgraph_l--_iswgraph_l.md), [_ismbcgraph, _ismbcgraph_l, _ismbcprint, _ismbcprint_l, _ismbcpunct, _ismbcpunct_l, _ismbcspace, _ismbcspace_l](../VS_csharp/_ismbcgraph--_ismbcgraph_l--_ismbcprint--_ismbcprint_l--_ismbcpunct--_ismbcpunct_l--_ismbcblank--_ismbcblank_l--_ismbcspace--_ismbcspace_l.md)|Printable other than space|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[islower, iswlower, _islower_l, _iswlower_l](../VS_csharp/islower--iswlower--_islower_l--_iswlower_l.md), [_ismbclower, _ismbclower_l](../VS_csharp/_ismbclower--_ismbclower_l--_ismbcupper--_ismbcupper_l.md)|Lowercase|[System::Char::IsLower](https://msdn.microsoft.com/en-us/library/system.char.islower.aspx)|  
|[_ismbchira, _ismbchira_l](../VS_csharp/_ismbchira--_ismbchira_l--_ismbckata--_ismbckata_l.md)|Hiragana|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbckata, _ismbckata_l](../VS_csharp/_ismbchira--_ismbchira_l--_ismbckata--_ismbckata_l.md)|Katakana|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbclegal, _ismbclegal_l, _ismbcsymbol, _ismbcsymbol_l](../VS_csharp/_ismbclegal--_ismbclegal_l--_ismbcsymbol--_ismbcsymbol_l.md)|Legal multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbcl0, _ismbcl0_l](../VS_csharp/_ismbcl0--_ismbcl0_l--_ismbcl1--_ismbcl1_l--_ismbcl2--_ismbcl2_l.md)|Japan-level 0 multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbcl1, _ismbcl1_l](../VS_csharp/_ismbcl0--_ismbcl0_l--_ismbcl1--_ismbcl1_l--_ismbcl2--_ismbcl2_l.md)|Japan-level 1 multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbcl2, _ismbcl2_l](../VS_csharp/_ismbcl0--_ismbcl0_l--_ismbcl1--_ismbcl1_l--_ismbcl2--_ismbcl2_l.md)|Japan-level 2 multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbclegal, _ismbclegal_l, _ismbcsymbol, _ismbcsymbol_l](../VS_csharp/_ismbclegal--_ismbclegal_l--_ismbcsymbol--_ismbcsymbol_l.md)|Non-alphanumeric multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[isprint, iswprint, _isprint_l, _iswprint_l](../VS_csharp/isprint--iswprint--_isprint_l--_iswprint_l.md), [_ismbcgraph, _ismbcgraph_l, _ismbcprint, _ismbcprint_l](../VS_csharp/_ismbcgraph--_ismbcgraph_l--_ismbcprint--_ismbcprint_l--_ismbcpunct--_ismbcpunct_l--_ismbcblank--_ismbcblank_l--_ismbcspace--_ismbcspace_l.md)|Printable|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[ispunct, iswpunct, _ispunct_l, _iswpunct_l](../VS_csharp/ispunct--iswpunct--_ispunct_l--_iswpunct_l.md), [_ismbcpunct, _ismbcpunct_l](../VS_csharp/_ismbcgraph--_ismbcgraph_l--_ismbcprint--_ismbcprint_l--_ismbcpunct--_ismbcpunct_l--_ismbcblank--_ismbcblank_l--_ismbcspace--_ismbcspace_l.md)|Punctuation|[System::Char::IsPunctuation](https://msdn.microsoft.com/en-us/library/system.char.ispunctuation.aspx)|  
|[isspace, iswspace, _isspace_l, _iswspace_l](../VS_csharp/isspace--iswspace--_isspace_l--_iswspace_l.md), [_ismbcspace, _ismbcspace_l](../VS_csharp/_ismbcgraph--_ismbcgraph_l--_ismbcprint--_ismbcprint_l--_ismbcpunct--_ismbcpunct_l--_ismbcblank--_ismbcblank_l--_ismbcspace--_ismbcspace_l.md)|White-space|[System::Char::IsWhiteSpace](https://msdn.microsoft.com/en-us/library/system.char.iswhitespace.aspx)|  
|[Isupper, iswupper](../VS_csharp/isupper--_isupper_l--iswupper--_iswupper_l.md), [_ismbcupper, _ismbcupper_l](../VS_csharp/_ismbclower--_ismbclower_l--_ismbcupper--_ismbcupper_l.md)|Uppercase|[System::Char::IsUpper](https://msdn.microsoft.com/en-us/library/system.char.isupper.aspx)|  
|[_isctype, iswctype, _isctype_l, _iswctype_l](../VS_csharp/_isctype--iswctype--_isctype_l--_iswctype_l.md)|Property specified by `desc` argument|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[isxdigit, iswxdigit, _isxdigit_l, _iswxdigit_l](../VS_csharp/isxdigit--iswxdigit--_isxdigit_l--_iswxdigit_l.md)|Hexadecimal digit|[System::Char::IsNumber](https://msdn.microsoft.com/en-us/library/system.char.isnumber.aspx)|  
|[_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../VS_csharp/_mbclen--mblen--_mblen_l.md)|Return length of valid multibyte character; result depends on `LC_CTYPE` category setting of current locale|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
## See Also  
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)