---
title: "localeconv"
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
  - "localeconv"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "localeconv"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "lconv type"
  - "localeconv function"
  - "locales, getting information on"
ms.assetid: 7ecdb1f2-88f5-4037-a0e7-c754ab003660
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# localeconv
Gets detailed information on locale settings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns a pointer to a filled-in object of type [struct lconv](../vs140/standard-types.md). The values contained in the object can be overwritten by subsequent calls to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and do not directly modify the object. Calls to [setlocale](../vs140/setlocale--_wsetlocale.md) with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> values of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> overwrite the contents of the structure.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function gets detailed information about numeric formatting for the current locale. This information is stored in a structure of type **lconv**. The **lconv** structure, defined in LOCALE.H, contains the following members:  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Decimal-point character for nonmonetary quantities.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Character that separates groups of digits to left of decimal point for nonmonetary quantities.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Size of each group of digits in nonmonetary quantities.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 International currency symbol for current locale. First three characters specify alphabetic international currency symbol as defined in the *ISO 4217 Codes for the Representation of Currency and Funds* standard. Fourth character (immediately preceding null character) separates international currency symbol from monetary quantity.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Local currency symbol for current locale.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Decimal-point character for monetary quantities.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Separator for groups of digits to left of decimal place in monetary quantities.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Size of each group of digits in monetary quantities.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 String denoting sign for nonnegative monetary quantities.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 String denoting sign for negative monetary quantities.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Number of digits to right of decimal point in internationally formatted monetary quantities.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Number of digits to right of decimal point in formatted monetary quantities.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Set to 1 if currency symbol precedes value for nonnegative formatted monetary quantity. Set to 0 if symbol follows value.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Set to 1 if currency symbol is separated by space from value for nonnegative formatted monetary quantity. Set to 0 if there is no space separation.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Set to 1 if currency symbol precedes value for negative formatted monetary quantity. Set to 0 if symbol succeeds value.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Set to 1 if currency symbol is separated by space from value for negative formatted monetary quantity. Set to 0 if there is no space separation.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Position of positive sign in nonnegative formatted monetary quantities.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Position of positive sign in negative formatted monetary quantities.  
  
 Members of the structure that have <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> versions are pointers to strings. Any of these that equals <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>) is either of zero length or not supported in the current locale. Note that <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> are always supported and of nonzero length.  
  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> members of the structure are small nonnegative numbers, not characters. Any of these that equals **CHAR_MAX** is not supported in the current locale.  
  
 The elements of **grouping** and **mon_grouping** are interpreted according to the following rules.  
  
 **CHAR_MAX**  
 Do not perform any further grouping.  
  
 0  
 Use previous element for each of remaining digits.  
  
 *n*  
 Number of digits that make up current group. Next element is examined to determine size of next group of digits before current group.  
  
 The values for **int_curr_symbol** are interpreted according to the following rules:  
  
-   The first three characters specify the alphabetic international currency symbol as defined in the *ISO 4217 Codes for the Representation of Currency and Funds* standard.  
  
-   The fourth character (immediately preceding the null character) separates the international currency symbol from the monetary quantity.  
  
 The values for **p_cs_precedes** and **n_cs_precedes** are interpreted according to the following rules (the **n_cs_precedes** rule is in parentheses):  
  
 0  
 Currency symbol follows value for nonnegative (negative) formatted monetary value.  
  
 1  
 Currency symbol precedes value for nonnegative (negative) formatted monetary value.  
  
 The values for **p_sep_by_space** and **n_sep_by_space** are interpreted according to the following rules (the **n_sep_by_space** rule is in parentheses):  
  
 0  
 Currency symbol is separated from value by space for nonnegative (negative) formatted monetary value.  
  
 1  
 There is no space separation between currency symbol and value for nonnegative (negative) formatted monetary value.  
  
 The values for **p_sign_posn** and **n_sign_posn** are interpreted according to the following rules:  
  
 0  
 Parentheses surround quantity and currency symbol.  
  
 1  
 Sign string precedes quantity and currency symbol.  
  
 2  
 Sign string follows quantity and currency symbol.  
  
 3  
 Sign string immediately precedes currency symbol.  
  
 4  
 Sign string immediately follows currency symbol.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<locale.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## See Also  
 [Locale](../vs140/locale.md)   
 [setlocale](../vs140/setlocale.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)