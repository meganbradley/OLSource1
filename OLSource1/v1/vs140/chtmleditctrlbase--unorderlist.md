---
title: "CHtmlEditCtrlBase::UnorderList"
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
  - "UnorderList"
  - "CHtmlEditCtrlBase::UnorderList"
  - "CHtmlEditCtrlBase<T>::UnorderList"
  - "CHtmlEditCtrlBase.UnorderList"
  - "CHtmlEditCtrlBase<T>.UnorderList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnorderList method"
ms.assetid: d2ee16dc-6b54-4351-914d-28a71c95c53c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::UnorderList
Toggles the current selection between an ordered list and a normal format block.  
  
## Syntax  
  
```  
  
      HRESULT UnorderList(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID of the unordered list.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM UNORDERLIST command ID](https://msdn.microsoft.com/en-us/library/aa769987.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::OrderList](../vs140/chtmleditctrlbase--orderlist.md)