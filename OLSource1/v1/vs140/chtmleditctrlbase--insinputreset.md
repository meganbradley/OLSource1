---
title: "CHtmlEditCtrlBase::InsInputReset"
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
  - "CHtmlEditCtrlBase<T>.InsInputReset"
  - "CHtmlEditCtrlBase<T>::InsInputReset"
  - "InsInputReset"
  - "CHtmlEditCtrlBase::InsInputReset"
  - "CHtmlEditCtrlBase.InsInputReset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsInputReset method"
ms.assetid: 3d8c4c30-4d53-477b-8b92-ae7a331cf0b1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::InsInputReset
Overwrites a reset control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT InsInputReset(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the reset control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSINPUTRESET command ID](https://msdn.microsoft.com/en-us/library/aa769978.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)