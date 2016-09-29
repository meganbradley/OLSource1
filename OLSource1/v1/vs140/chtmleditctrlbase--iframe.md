---
title: "CHtmlEditCtrlBase::Iframe"
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
  - "CHtmlEditCtrlBase.Iframe"
  - "CHtmlEditCtrlBase::Iframe"
  - "CHtmlEditCtrlBase<T>.Iframe"
  - "CHtmlEditCtrlBase<T>::Iframe"
  - "Iframe"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Iframe method"
ms.assetid: ebf96d7c-a5fa-470f-baab-c2bc2ed9738e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Iframe
Overwrites an inline frame on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT Iframe(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the inline frame.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_IFRAME command ID](https://msdn.microsoft.com/en-us/library/aa769969.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)