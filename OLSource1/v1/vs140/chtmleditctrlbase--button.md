---
title: "CHtmlEditCtrlBase::Button"
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
  - "Button"
  - "CHtmlEditCtrlBase.Button"
  - "CHtmlEditCtrlBase<T>.Button"
  - "CHtmlEditCtrlBase::Button"
  - "CHtmlEditCtrlBase<T>::Button"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Button method"
ms.assetid: 4761e8da-ac51-4cd0-a31c-938354a4a3eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Button
Overwrites a button control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT Button(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID of the button control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_BUTTON command ID](https://msdn.microsoft.com/en-us/library/aa769966.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)