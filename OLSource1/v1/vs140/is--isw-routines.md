---
title: "is, isw Routines"
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
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "isw"
  - "is"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "is routines"
  - "isw routines"
ms.assetid: 1e171a57-2cde-41f6-a75f-a080fa3c12e5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is, isw Routines
|||  
|-|-|  
|[isalnum, iswalnum, _isalnum_l, _iswalnum_l](../vs140/isalnum--iswalnum--_isalnum_l--_iswalnum_l.md)|[isgraph, iswgraph, _isgraph_l, _iswgraph_l](../vs140/isgraph--iswgraph--_isgraph_l--_iswgraph_l.md)|  
|[isalpha, iswalpha, _isalpha_l, _iswalpha_l](../vs140/isalpha--iswalpha--_isalpha_l--_iswalpha_l.md)|[isleadbyte, _isleadbyte_l](../vs140/isleadbyte--_isleadbyte_l.md)|  
|[__isascii, iswascii](../vs140/isascii--__isascii--iswascii.md)|[islower, iswlower, _islower_l, _iswlower_l](../vs140/islower--iswlower--_islower_l--_iswlower_l.md)|  
|[isblank, iswblank, _isblank_l, _iswblank_l](../vs140/isblank--iswblank--_isblank_l--_iswblank_l.md)|[isprint, iswprint, _isprint_l, _iswprint_l](../vs140/isprint--iswprint--_isprint_l--_iswprint_l.md)|  
|[iscntrl, iswcntrl, _iscntrl_l, _iswcntrl_l](../vs140/iscntrl--iswcntrl--_iscntrl_l--_iswcntrl_l.md)|[ispunct, iswpunct, _ispunct_l, _iswpunct_l](../vs140/ispunct--iswpunct--_ispunct_l--_iswpunct_l.md)|  
|[__iscsym, \__iswcsym, \__iscsymf, \__iswcsymf, _iscsym_l, _iswcsym_l, _iscsymf_l, _iswcsymf_l](../vs140/944dfb99-f2b8-498c-9f55-dbcf370d0a2c.md)|[isspace, iswspace, _isspace_l, _iswspace_l](../vs140/isspace--iswspace--_isspace_l--_iswspace_l.md)|  
|[_isctype, iswctype, _isctype_l, _iswctype_l](../vs140/_isctype--iswctype--_isctype_l--_iswctype_l.md)|[isupper, iswupper, _isupper_l](../vs140/isupper--_isupper_l--iswupper--_iswupper_l.md)|  
|[isdigit, iswdigit, _isdigit_l, _iswdigit_l](../vs140/isdigit--iswdigit--_isdigit_l--_iswdigit_l.md)|[isxdigit, iswxdigit, _isxdigit_l, _iswxdigit_l](../vs140/isxdigit--iswxdigit--_isxdigit_l--_iswxdigit_l.md)|  
  
## Remarks  
 These routines test characters for specified conditions.  
  
 The **is** routines produce meaningful results for any integer argument from –1 (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) to **UCHAR_MAX** (0xFF), inclusive. The expected argument type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
> [!CAUTION]
>  For the **is** routines, passing an argument of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> may yield unpredictable results. An SBCS or MBCS single-byte character of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with a value greater than 0x7F is negative. If a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is passed, the compiler may convert the value to a signed <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or a signed **long**. This value may be sign-extended by the compiler, with unexpected results.  
  
 The **isw** routines produce meaningful results for any integer value from – 1 (**WEOF**) to 0xFFFF, inclusive. The **wint_t** data type is defined in WCHAR.H as an **unsigned short**; it can hold any wide character or the wide-character end-of-file (**WEOF**) value.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the **_l** suffix use the current locale for this locale-dependent behavior; the versions with the **_l** suffix are identical except that they use the locale parameter passed in instead.  
  
 In the "C" locale, the test conditions for the **is** routines are as follows:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Alphanumeric (A – Z, a – z, or 0 – 9).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Alphabetic (A – Z or a – z).  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 ASCII character (0x00 – 0x7F).  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Horizontal tab or space character (0x09 or 0x20).  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Control character (0x00 – 0x1F or 0x7F).  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Letter, underscore, or digit.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Letter or underscore.  
  
 **isdigit**  
 Decimal digit (0 – 9).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Printable character except space ( ).  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Lowercase letter (a – z).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Printable character including space (0x20 – 0x7E).  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Punctuation character.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 White-space character (0x09 – 0x0D or 0x20).  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Uppercase letter (A – Z).  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Hexadecimal digit (A – F, a – f, or 0 – 9).  
  
 For the **isw** routines, the result of the test for the specified condition is independent of locale. The test conditions for the **isw** functions are as follows:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Any wide character that is one of an implementation-defined set for which none of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is nonzero. <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> returns nonzero only for wide characters for which <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is nonzero.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Wide-character representation of ASCII character (0x0000 – 0x007F).  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Wide character that corresponds to the standard space character or is one of an implementation-defined set of wide characters for which <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is false. Standard blank characters are space (L' ') and horizontal tab (L'\t').  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Control wide character.  
  
 **__iswcsym**  
 Any wide character for which **isalnum** is true, or the '_' character.  
  
 **__iswcsymf**  
 Any wide character for which <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is true, or the '_' character.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Character has property specified by the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> argument. For each valid value of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, there is an equivalent wide-character classification routine, as shown in the following table:  
  
 **Equivalence of iswctype(**   
 ***c, desc* ) to Other isw Testing Routines**  
  
|Value of *desc* argument|iswctype( *c, desc* ) equivalent|  
|------------------------------|----------------------------------------|  
|**_ALPHA**|**iswalpha(** <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> **)**|  
|**_ALPHA** &#124; **_DIGIT**|**iswalnum(** <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> **)**|  
|**_BLANK**|**iswblank(** <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> **)**|  
|**_CONTROL**|**iswcntrl(** <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> **)**|  
|**_DIGIT**|**iswdigit(** <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> **)**|  
|**_ALPHA** &#124; **_DIGIT** &#124; **_PUNCT**|**iswgraph(** <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> **)**|  
|**_LOWER**|**iswlower(** <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> **)**|  
|**_ALPHA** &#124; **_BLANK** &#124; **_DIGIT** &#124; **_PUNCT**|**iswprint(** <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> **)**|  
|**_PUNCT**|**iswpunct(** <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> **)**|  
|**_BLANK**|**iswblank(** <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> **)**|  
|**_SPACE**|**iswspace(** <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> **)**|  
|**_UPPER**|**iswupper(** <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> **)**|  
|**_HEX**|**iswxdigit(** <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> **)**|  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Wide character corresponding to a decimal-digit character.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Printable wide character except space wide character (L' ').  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Lowercase letter, or one of implementation-defined set of wide characters for which none of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is nonzero. <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> returns nonzero only for wide characters that correspond to lowercase letters.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Printable wide character, including space wide character (L' ').  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Printable wide character that is neither space wide character (L' ') nor wide character for which <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is nonzero.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Wide character that corresponds to standard white-space character or is one of implementation-defined set of wide characters for which <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is false. Standard white-space characters are: space (L' '), formfeed (L'\f'), newline (L'\n'), carriage return (L'\r'), horizontal tab (L'\t'), and vertical tab (L'\v').  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Wide character that is uppercase or is one of an implementation-defined set of wide characters for which none of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is nonzero. <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> returns nonzero only for wide characters that correspond to uppercase characters.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Wide character that corresponds to a hexadecimal-digit character.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [to Functions](../vs140/to-functions.md)