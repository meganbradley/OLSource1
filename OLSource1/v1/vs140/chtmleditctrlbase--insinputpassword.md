---
title: "CHtmlEditCtrlBase::InsInputPassword"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CHtmlEditCtrlBase<T>::InsInputPassword"
  - "InsInputPassword"
  - "CHtmlEditCtrlBase<T>.InsInputPassword"
  - "CHtmlEditCtrlBase.InsInputPassword"
  - "CHtmlEditCtrlBase::InsInputPassword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsInputPassword method"
ms.assetid: 1532dfc4-106c-4b01-81f4-f7f8583a993d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::InsInputPassword
Overwrites a password control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT InsInputPassword(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the password control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSINPUTPASSWORD command ID](https://msdn.microsoft.com/en-us/library/aa769976.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)