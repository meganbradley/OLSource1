---
title: "_pctype, _pwctype, _wctype, _mbctype, _mbcasemap"
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
  - "pwctype"
  - "pctype"
  - "mbctype"
  - "mbcasemap"
  - "_mbcasemap"
  - "_mbctype"
  - "_pctype"
  - "_wctype"
  - "_pcwtype"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wctype function"
  - "_pwctype function"
  - "_pctype function"
  - "_mbctype function"
  - "wctype function"
  - "pwctype function"
  - "pctype function"
  - "mbcasemap function"
  - "mbctype function"
  - "_mbcasemap function"
ms.assetid: 7f5e1107-c43b-4b9b-b387-781e6d2373cb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _pctype, _pwctype, _wctype, _mbctype, _mbcasemap
These global variables contain information used by the character classification functions. They are for internal use only.  
  
## Syntax  
  
```  
extern const unsigned short *_pctype;  
extern const wctype_t *_pwctype;  
extern const unsigned short _wctype[];  
extern unsigned char _mbctype[];  
extern unsigned char _mbcasemap[];  
```  
  
## Remarks  
 The information in `_pctype`, `_pwctype`, and `_wctype` is used internally by functions [isupper, iswupper](../VS_csharp/isupper--_isupper_l--iswupper--_iswupper_l.md), [islower, iswlower](../VS_csharp/islower--iswlower--_islower_l--_iswlower_l.md), [isdigit, iswdigit](../VS_csharp/isdigit--iswdigit--_isdigit_l--_iswdigit_l.md), [isxdigit, iswxdigit](../VS_csharp/isxdigit--iswxdigit--_isxdigit_l--_iswxdigit_l.md), [isspace, iswspace](../VS_csharp/isspace--iswspace--_isspace_l--_iswspace_l.md), [isalnum, iswalnum](../VS_csharp/isalnum--iswalnum--_isalnum_l--_iswalnum_l.md), [ispunct, iswpunct](../VS_csharp/ispunct--iswpunct--_ispunct_l--_iswpunct_l.md), [isgraph, iswgraph](../VS_csharp/isgraph--iswgraph--_isgraph_l--_iswgraph_l.md), and [iscntrl, iswcntrl](../VS_csharp/iscntrl--iswcntrl--_iscntrl_l--_iswcntrl_l.md), as well as the [toupper _toupper, towupper](../VS_csharp/toupper--_toupper--towupper--_toupper_l--_towupper_l.md) and [tolower, _tolower, towlower](../VS_csharp/tolower--_tolower--towlower--_tolower_l--_towlower_l.md) functions. These functions should be used instead of accessing these global variables.  
  
 The information in `_mbctype` and `_mbcasemap` is used internally by [_ismbbkalnum](../VS_csharp/_ismbbkalnum--_ismbbkalnum_l.md), [_ismbbkana](../VS_csharp/_ismbbkana--_ismbbkana_l.md), [_ismbbkpunct](../VS_csharp/_ismbbkpunct--_ismbbkpunct_l.md), [_ismbbkprint](../VS_csharp/_ismbbkprint--_ismbbkprint_l.md), [_ismbbalpha](../VS_csharp/_ismbbalpha--_ismbbalpha_l.md), [_ismbbpunct](../VS_csharp/_ismbbpunct--_ismbbpunct_l.md), [_ismbbalnum](../VS_csharp/_ismbbalnum--_ismbbalnum_l.md), [_ismbbprint](../VS_csharp/_ismbbprint--_ismbbprint_l.md), [_ismbbgraph](../VS_csharp/_ismbbgraph--_ismbbgraph_l.md), [_ismbblead](../VS_csharp/_ismbblead--_ismbblead_l.md), [_ismbbtrail](../VS_csharp/_ismbbtrail--_ismbbtrail_l.md), [_ismbslead, _ismbstrail](../VS_csharp/_ismbslead--_ismbstrail--_ismbslead_l--_ismbstrail_l.md), and [_ismbslead, _ismbstrail](../VS_csharp/_ismbslead--_ismbstrail--_ismbslead_l--_ismbstrail_l.md). Use these functions instead of accessing the global variables.  
  
## Requirements  
 Not for public use.  
  
## See Also  
 [is, isw Routines](../VS_csharp/is--isw-routines.md)   
 [__pctype_func](../VS_csharp/__pctype_func.md)