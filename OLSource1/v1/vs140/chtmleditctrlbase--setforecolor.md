---
title: "CHtmlEditCtrlBase::SetForeColor"
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
  - "CHtmlEditCtrlBase<T>::SetForeColor"
  - "CHtmlEditCtrlBase::SetForeColor"
  - "SetForeColor"
  - "CHtmlEditCtrlBase.SetForeColor"
  - "CHtmlEditCtrlBase<T>.SetForeColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetForeColor method"
ms.assetid: 7fc441d3-f7b7-4854-8bc4-882f2f021185
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetForeColor
Sets the foreground (text) color of the current selection.  
  
## Syntax  
  
```  
  
      HRESULT SetForeColor(  
   LPCTSTR szColor   
) const;  
HRESULT SetForeColor(  
   int nColor   
) const;  
```  
  
#### Parameters  
 `szColor`  
 The color.  
  
 `nColor`  
 The color.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM FORECOLOR command ID](https://msdn.microsoft.com/en-us/library/aa769882.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetForeColor](../vs140/chtmleditctrlbase--getforecolor.md)   
 [CHtmlEditCtrlBase::SetBackColor](../vs140/chtmleditctrlbase--setbackcolor.md)