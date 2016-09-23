---
title: "CHtmlEditCtrlBase::CheckBox"
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
  - CHtmlEditCtrlBase<T>::CheckBox
  - CHtmlEditCtrlBase::CheckBox
  - CHtmlEditCtrlBase<T>.CheckBox
  - CHtmlEditCtrlBase.CheckBox
  - CheckBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - CheckBox method
ms.assetid: 294e3c98-9eb7-4c4c-be7f-b6a70f77d650
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::CheckBox
Overwrites a check box control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT CheckBox(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID of the check box control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_CHECKBOX command ID](https://msdn.microsoft.com/en-us/library/aa769972.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)