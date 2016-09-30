---
title: "CHtmlEditCtrlBase::SetDisableEditFocusUI"
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
  - "CHtmlEditCtrlBase<T>.SetDisableEditFocusUI"
  - "CHtmlEditCtrlBase::SetDisableEditFocusUI"
  - "SetDisableEditFocusUI"
  - "CHtmlEditCtrlBase<T>::SetDisableEditFocusUI"
  - "CHtmlEditCtrlBase.SetDisableEditFocusUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDisableEditFocusUI method"
ms.assetid: 27ca7bb6-2c08-404d-bfce-181b241007f6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetDisableEditFocusUI
Disables the hatched border and handles around an element that has edit focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If true, disables the hatched border and handles around a site selectable element when the element has "edit focus" in design mode; that is, when the text or contents of the element can be edited.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_DISABLE_EDITFOCUS_UI command ID](https://msdn.microsoft.com/en-us/library/aa769905.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)