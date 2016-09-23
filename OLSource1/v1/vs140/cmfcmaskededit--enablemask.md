---
title: "CMFCMaskedEdit::EnableMask"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCMaskedEdit.EnableMask
  - CMFCMaskedEdit::EnableMask
  - EnableMask
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableMask method
ms.assetid: 59e75708-311f-4eea-9105-a41f41864e3a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCMaskedEdit::EnableMask
Initializes the masked edit control.  
  
## Syntax  
  
```  
void EnableMask(  
   LPCTSTR lpszMask,  
   LPCTSTR lpszInputTemplate,  
   TCHAR chMaskInputTemplate=_T('_'),  
   LPCTSTR lpszValid=NULL   
);  
```  
  
#### Parameters  
 [in] `lpszMask`  
 A mask string that specifies the type of character that can appear at each position in the user input. The length of the `lpszInputTemplate` and `lpszMask` parameter strings must be the same. See the Remarks section for more detail about mask characters.  
  
 [in] `lpszInputTemplate`  
 A mask template string that specifies the literal characters that can appear at each position in the user input. Use the underscore character ('_') as a character placeholder. The length of the `lpszInputTemplate` and `lpszMask` parameter strings must be the same.  
  
 [in] `chMaskInputTemplate`  
 A default character that the framework substitutes for each invalid character in the user input. The default value of this parameter is underscore ('_').  
  
 [in] `lpszValid`  
 A string that contains a set of valid characters. `NULL` indicates that all characters are valid. The default value of this parameter is `NULL`.  
  
## Remarks  
 Use this method to create the mask for the masked edit control. Derive a class from the `CMFCMaskedEdit` class and override the [CMFCMaskedEdit::IsMaskedChar](../vs140/cmfcmaskededit--ismaskedchar.md) method to use your own code for custom mask processing.  
  
 The following table list the default mask characters:  
  
|Mask Character|Definition|  
|--------------------|----------------|  
|D|Digit.|  
|d|Digit or space.|  
|+|Plus ('+'), minus ('-'), or space.|  
|C|Alphabetic character.|  
|c|Alphabetic character or space.|  
|A|Alphanumeric character.|  
|a|Alphanumeric character or space.|  
|*|A printable character.|  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
## See Also  
 [CMFCMaskedEdit Class](../vs140/cmfcmaskededit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMaskedEdit::SetValidChars](../vs140/cmfcmaskededit--setvalidchars.md)   
 [CMFCMaskedEdit::SetWindowText](../vs140/cmfcmaskededit--setwindowtext.md)