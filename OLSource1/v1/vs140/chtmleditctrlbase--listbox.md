---
title: "CHtmlEditCtrlBase::ListBox"
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
  - "CHtmlEditCtrlBase.ListBox"
  - "CHtmlEditCtrlBase<T>.ListBox"
  - "CHtmlEditCtrlBase::ListBox"
  - "CHtmlEditCtrlBase<T>::ListBox"
  - "ListBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ListBox method"
ms.assetid: a05ea324-16d3-499c-a556-b77e5ed447f5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::ListBox
Overwrites a list box selection control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT ListBox(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the list box control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_LISTBOX command ID](https://msdn.microsoft.com/en-us/library/aa769985.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)