---
title: "CHtmlEditCtrlBase::TextBox"
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
  - TextBox
  - CHtmlEditCtrlBase<T>::TextBox
  - CHtmlEditCtrlBase.TextBox
  - CHtmlEditCtrlBase<T>.TextBox
  - CHtmlEditCtrlBase::TextBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - TextBox method
ms.assetid: 59ec3b14-6ada-4277-a125-4b3206f4c19a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::TextBox
Overwrites a text control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT TextBox(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID of the text control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM TEXTBOX command ID](https://msdn.microsoft.com/en-us/library/aa769980.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)