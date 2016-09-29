---
title: "CHtmlEditCtrlBase::ClearSelection"
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
  - "ClearSelection"
  - "CHtmlEditCtrlBase<T>.ClearSelection"
  - "CHtmlEditCtrlBase.ClearSelection"
  - "CHtmlEditCtrlBase<T>::ClearSelection"
  - "CHtmlEditCtrlBase::ClearSelection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ClearSelection method"
ms.assetid: 04223987-97bd-4bc8-90f6-7d609545c871
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::ClearSelection
Clears the current selection.  
  
## Syntax  
  
```  
  
HRESULT ClearSelection( ) const;  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_CLEARSELECTION command ID](https://msdn.microsoft.com/en-us/library/aa770038.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)