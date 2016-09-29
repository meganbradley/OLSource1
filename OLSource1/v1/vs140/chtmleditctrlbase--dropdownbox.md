---
title: "CHtmlEditCtrlBase::DropDownBox"
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
  - "CHtmlEditCtrlBase::DropDownBox"
  - "CHtmlEditCtrlBase<T>::DropDownBox"
  - "DropDownBox"
  - "CHtmlEditCtrlBase<T>.DropDownBox"
  - "CHtmlEditCtrlBase.DropDownBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DropDownBox method"
ms.assetid: e89a98f6-e253-40fd-aff0-c7497ac72aeb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::DropDownBox
Overwrites a drop-down selection control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT DropDownBox(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID of the drop-down selection control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_DROPDOWNBOX command ID](https://msdn.microsoft.com/en-us/library/aa769984.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)