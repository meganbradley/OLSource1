---
title: "CHtmlEditCtrlBase::InsInputButton"
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
  - "CHtmlEditCtrlBase<T>.InsInputButton"
  - "CHtmlEditCtrlBase<T>::InsInputButton"
  - "CHtmlEditCtrlBase::InsInputButton"
  - "InsInputButton"
  - "CHtmlEditCtrlBase.InsInputButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsInputButton method"
ms.assetid: 8fea049c-5d79-48a6-a183-1d38dc5f18f7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::InsInputButton
Overwrites a button control on the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID for the button control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSINPUTBUTTON command ID](https://msdn.microsoft.com/en-us/library/aa769971.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)