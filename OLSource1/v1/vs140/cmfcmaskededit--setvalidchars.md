---
title: "CMFCMaskedEdit::SetValidChars"
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
  - CMFCMaskedEdit::SetValidChars
  - CMFCMaskedEdit.SetValidChars
  - SetValidChars
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetValidChars method
ms.assetid: 1c96bfca-d088-4804-b5cc-7a0ef5f615e5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCMaskedEdit::SetValidChars
Specifies a string of valid characters that the user can enter.  
  
## Syntax  
  
```  
void SetValidChars(  
   LPCTSTR lpszValid=NULL   
);  
```  
  
#### Parameters  
 [in] `lpszValid`  
 A string that contains the set of valid input characters. `NULL` means that all characters are valid. The default value of this parameter is `NULL`.  
  
## Remarks  
 Use this method to define a list of valid characters. If an input character is not in this list, masked edit control will not accept it.  
  
 The following code example accepts only hexadecimal numbers.  
  
 `//Mask: 0xFFFFm_wndMaskEdit.EnableMask( _T(" AAAA"),                // The mask string. _T("0x____"),               // The literal template string. _T('_'));                   // The default character that replaces the backspace character.// Valid string charactersm_wndMaskEdit.SetValidChars(_T("1234567890ABCDEFabcdef"));m_wndMaskEdit.SetWindowText(_T("0x01AF"));`  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
## See Also  
 [CMFCMaskedEdit Class](../vs140/cmfcmaskededit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)