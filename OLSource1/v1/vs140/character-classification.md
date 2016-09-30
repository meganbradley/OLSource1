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
  
 The test conditions are affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the `_l` suffix use the current locale for this locale-dependent behavior; the versions with the `_l` suffix are identical except that they use the locale parameter passed in instead.  
  
 Generally these routines execute faster than tests you might write and should be favored over. For example, the following code executes slower than a call to `isalpha(c)`:  
  
```  
if ((c >= 'A') && (c <= 'Z')) || ((c >= 'a') && (c <= 'z'))  
    return TRUE;  
```  
  
### Character-Classification Routines  
  
|Routine|Character test condition|.NET Framework equivalent|  
|-------------|------------------------------|-------------------------------|  
|[isalnum, iswalnum, _isalnum_l, _iswalnum_l](../vs140/isalnum--iswalnum--_isalnum_l--_iswalnum_l.md), [_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha\_, _ismbcdigit, _ismbcdigit_l](../vs140/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Alphanumeric|[System::Char::IsLetterOrDigit](https://msdn.microsoft.com/en-us/library/system.char.isletterordigit.aspx).|  
|[_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha\_, _ismbcdigit, _ismbcdigit_l](../vs140/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Alphanumeric|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[isalpha, iswalpha, _isalpha_l, _iswalpha_l](../vs140/isalpha--iswalpha--_isalpha_l--_iswalpha_l.md), [_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha](../vs140/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Alphabetic|[System::Char::IsLetter](https://msdn.microsoft.com/en-us/library/system.char.isletter.aspx)|  
|[__isascii, iswascii](../vs140/isascii--__isascii--iswascii.md)|ASCII|[System::Char::IsLetter](https://msdn.microsoft.com/en-us/library/system.char.isletter.aspx)|  
|[isblank, iswblank, _isblank_l, _iswblank_l](../vs140/isblank--iswblank--_isblank_l--_iswblank_l.md), [_ismbcsblank, _ismbcsblank_l](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|Blank (space or horizontal tab)|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[iscntrl, iswcntrl, _iscntrl_l, _iswcntrl_l](../vs140/iscntrl--iswcntrl--_iscntrl_l--_iswcntrl_l.md)|Control|[System::Char::IsControl](https://msdn.microsoft.com/en-us/library/system.char.iscontrol.aspx)|  
|[iscsym, iswcsym, iscsymf, iswcsymf, _iscsym_l, _iswcsym_l, _iscsymf_l, _iswcsymf_l](../vs140/944dfb99-f2b8-498c-9f55-dbcf370d0a2c.md)|Letter, underscore, or digit|[System::Char::IsControl](https://msdn.microsoft.com/en-us/library/system.char.iscontrol.aspx)|  
|[iscsym, iswcsym, iscsymf, iswcsymf, _iscsym_l, _iswcsym_l, _iscsymf_l, _iswcsymf_l](../vs140/944dfb99-f2b8-498c-9f55-dbcf370d0a2c.md)|Letter or underscore|[System::Char::IsControl](https://msdn.microsoft.com/en-us/library/system.char.iscontrol.aspx)|  
|[isdigit, iswdigit, _isdigit_l, _iswdigit_l](../vs140/isdigit--iswdigit--_isdigit_l--_iswdigit_l.md), [_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha\_, _ismbcdigit, _ismbcdigit_l](../vs140/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|Decimal digit|[System::Char::IsDigit](https://msdn.microsoft.com/en-us/library/system.char.isdigit.aspx)|  
|[isgraph, iswgraph, _isgraph_l, _iswgraph_l](../vs140/isgraph--iswgraph--_isgraph_l--_iswgraph_l.md), [_ismbcgraph, _ismbcgraph_l, _ismbcprint, _ismbcprint_l, _ismbcpunct, _ismbcpunct_l, _ismbcspace, _ismbcspace_l](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|Printable other than space|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[islower, iswlower, _islower_l, _iswlower_l](../vs140/islower--iswlower--_islower_l--_iswlower_l.md), [_ismbclower, _ismbclower_l](../vs140/_ismbclower--_ismbclower_l--_ismbcupper--_ismbcupper_l.md)|Lowercase|[System::Char::IsLower](https://msdn.microsoft.com/en-us/library/system.char.islower.aspx)|  
|[_ismbchira, _ismbchira_l](../vs140/_ismbchira--_ismbchira_l--_ismbckata--_ismbckata_l.md)|Hiragana|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbckata, _ismbckata_l](../vs140/_ismbchira--_ismbchira_l--_ismbckata--_ismbckata_l.md)|Katakana|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbclegal, _ismbclegal_l, _ismbcsymbol, _ismbcsymbol_l](../vs140/_ismbclegal--_ismbclegal_l--_ismbcsymbol--_ismbcsymbol_l.md)|Legal multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbcl0, _ismbcl0_l](../vs140/_ismbcl0--_ismbcl0_l--_ismbcl1--_ismbcl1_l--_ismbcl2--_ismbcl2_l.md)|Japan-level 0 multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbcl1, _ismbcl1_l](../vs140/_ismbcl0--_ismbcl0_l--_ismbcl1--_ismbcl1_l--_ismbcl2--_ismbcl2_l.md)|Japan-level 1 multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbcl2, _ismbcl2_l](../vs140/_ismbcl0--_ismbcl0_l--_ismbcl1--_ismbcl1_l--_ismbcl2--_ismbcl2_l.md)|Japan-level 2 multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_ismbclegal, _ismbclegal_l, _ismbcsymbol, _ismbcsymbol_l](../vs140/_ismbclegal--_ismbclegal_l--_ismbcsymbol--_ismbcsymbol_l.md)|Non-alphanumeric multibyte character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[isprint, iswprint, _isprint_l, _iswprint_l](../vs140/isprint--iswprint--_isprint_l--_iswprint_l.md), [_ismbcgraph, _ismbcgraph_l, _ismbcprint, _ismbcprint_l](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|Printable|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[ispunct, iswpunct, _ispunct_l, _iswpunct_l](../vs140/ispunct--iswpunct--_ispunct_l--_iswpunct_l.md), [_ismbcpunct, _ismbcpunct_l](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|Punctuation|[System::Char::IsPunctuation](https://msdn.microsoft.com/en-us/library/system.char.ispunctuation.aspx)|  
|[isspace, iswspace, _isspace_l, _iswspace_l](../vs140/isspace--iswspace--_isspace_l--_iswspace_l.md), [_ismbcspace, _ismbcspace_l](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|White-space|[System::Char::IsWhiteSpace](https://msdn.microsoft.com/en-us/library/system.char.iswhitespace.aspx)|  
|[Isupper, iswupper](../vs140/isupper--_isupper_l--iswupper--_iswupper_l.md), [_ismbcupper, _ismbcupper_l](../vs140/_ismbclower--_ismbclower_l--_ismbcupper--_ismbcupper_l.md)|Uppercase|[System::Char::IsUpper](https://msdn.microsoft.com/en-us/library/system.char.isupper.aspx)|  
|[_isctype, iswctype, _isctype_l, _iswctype_l](../vs140/_isctype--iswctype--_isctype_l--_iswctype_l.md)|Property specified by `desc` argument|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[isxdigit, iswxdigit, _isxdigit_l, _iswxdigit_l](../vs140/isxdigit--iswxdigit--_isxdigit_l--_iswxdigit_l.md)|Hexadecimal digit|[System::Char::IsNumber](https://msdn.microsoft.com/en-us/library/system.char.isnumber.aspx)|  
|[_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)|Return length of valid multibyte character; result depends on `LC_CTYPE` category setting of current locale|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)