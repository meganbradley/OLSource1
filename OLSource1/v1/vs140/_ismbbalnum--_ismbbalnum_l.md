---
title: "_ismbbalnum, _ismbbalnum_l"
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
  - "_ismbbalnum"
  - "_ismbbalnum_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbbalnum"
  - "ismbbalnum"
  - "_ismbbalnum_l"
  - "ismbbalnum_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbbalnum_l function"
  - "ismbbalnum function"
  - "ismbbalnum_l function"
  - "_ismbbalnum function"
ms.assetid: 8025de50-a871-49fd-9ae6-f437b47aa987
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbbalnum, _ismbbalnum_l
Determines whether a specified multibyte character is alpha or numeric.  
  
## Syntax  
  
```  
int _ismbbalnum(  
   unsigned int c   
);  
int _ismbbalnum_l(  
   unsigned int c   
);  
```  
  
#### Parameters  
 `c`  
 Integer to be tested.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 `_ismbbalnum` returns a nonzero value if the expression:  
  
```  
isalnum || _ismbbkalnum  
```  
  
 is nonzero for `c`, or 0 if it is not.  
  
 The version of this function with the `_l` suffix is identical except that it uses the locale passed in instead of the current locale for its locale-dependent behavior.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_ismbbalnum`|<mbctype.h>|  
|`_ismbbalnum_l`|<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)