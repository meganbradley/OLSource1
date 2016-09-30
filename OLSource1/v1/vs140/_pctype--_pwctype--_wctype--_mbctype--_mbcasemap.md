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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The information in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used internally by functions [isupper, iswupper](../vs140/isupper--_isupper_l--iswupper--_iswupper_l.md), [islower, iswlower](../vs140/islower--iswlower--_islower_l--_iswlower_l.md), [isdigit, iswdigit](../vs140/isdigit--iswdigit--_isdigit_l--_iswdigit_l.md), [isxdigit, iswxdigit](../vs140/isxdigit--iswxdigit--_isxdigit_l--_iswxdigit_l.md), [isspace, iswspace](../vs140/isspace--iswspace--_isspace_l--_iswspace_l.md), [isalnum, iswalnum](../vs140/isalnum--iswalnum--_isalnum_l--_iswalnum_l.md), [ispunct, iswpunct](../vs140/ispunct--iswpunct--_ispunct_l--_iswpunct_l.md), [isgraph, iswgraph](../vs140/isgraph--iswgraph--_isgraph_l--_iswgraph_l.md), and [iscntrl, iswcntrl](../vs140/iscntrl--iswcntrl--_iscntrl_l--_iswcntrl_l.md), as well as the [toupper _toupper, towupper](../vs140/toupper--_toupper--towupper--_toupper_l--_towupper_l.md) and [tolower, _tolower, towlower](../vs140/tolower--_tolower--towlower--_tolower_l--_towlower_l.md) functions. These functions should be used instead of accessing these global variables.  
  
 The information in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is used internally by [_ismbbkalnum](../vs140/_ismbbkalnum--_ismbbkalnum_l.md), [_ismbbkana](../vs140/_ismbbkana--_ismbbkana_l.md), [_ismbbkpunct](../vs140/_ismbbkpunct--_ismbbkpunct_l.md), [_ismbbkprint](../vs140/_ismbbkprint--_ismbbkprint_l.md), [_ismbbalpha](../vs140/_ismbbalpha--_ismbbalpha_l.md), [_ismbbpunct](../vs140/_ismbbpunct--_ismbbpunct_l.md), [_ismbbalnum](../vs140/_ismbbalnum--_ismbbalnum_l.md), [_ismbbprint](../vs140/_ismbbprint--_ismbbprint_l.md), [_ismbbgraph](../vs140/_ismbbgraph--_ismbbgraph_l.md), [_ismbblead](../vs140/_ismbblead--_ismbblead_l.md), [_ismbbtrail](../vs140/_ismbbtrail--_ismbbtrail_l.md), [_ismbslead, _ismbstrail](../vs140/_ismbslead--_ismbstrail--_ismbslead_l--_ismbstrail_l.md), and [_ismbslead, _ismbstrail](../vs140/_ismbslead--_ismbstrail--_ismbslead_l--_ismbstrail_l.md). Use these functions instead of accessing the global variables.  
  
## Requirements  
 Not for public use.  
  
## See Also  
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [__pctype_func](../vs140/__pctype_func.md)