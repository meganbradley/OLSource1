---
title: "CHtmlEditCtrlBase::RadioButton"
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
  - "CHtmlEditCtrlBase.RadioButton"
  - "CHtmlEditCtrlBase::RadioButton"
  - "CHtmlEditCtrlBase<T>.RadioButton"
  - "RadioButton"
  - "CHtmlEditCtrlBase<T>::RadioButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RadioButton method"
ms.assetid: d1de54b7-729e-4ffe-93f2-17941db85df7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::RadioButton
Overwrites a radio control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT RadioButton(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID of the radio button.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_RADIOBUTTON command ID](https://msdn.microsoft.com/en-us/library/aa769977.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)