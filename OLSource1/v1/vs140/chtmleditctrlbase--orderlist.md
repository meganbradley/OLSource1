---
title: "CHtmlEditCtrlBase::OrderList"
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
  - "CHtmlEditCtrlBase<T>.OrderList"
  - "CHtmlEditCtrlBase<T>::OrderList"
  - "CHtmlEditCtrlBase.OrderList"
  - "CHtmlEditCtrlBase::OrderList"
  - "OrderList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OrderList method"
ms.assetid: 96eca939-6859-49dc-8171-e780c37f6179
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::OrderList
Toggles the current selection between an ordered list and a normal format block.  
  
## Syntax  
  
```  
  
      HRESULT OrderList(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the ordered list.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_ORDERLIST command ID](https://msdn.microsoft.com/en-us/library/aa769982.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::UnorderList](../vs140/chtmleditctrlbase--unorderlist.md)