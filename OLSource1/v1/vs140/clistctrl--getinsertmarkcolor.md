---
title: "CListCtrl::GetInsertMarkColor"
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
  - "CListCtrl.GetInsertMarkColor"
  - "GetInsertMarkColor"
  - "CListCtrl::GetInsertMarkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInsertMarkColor method"
ms.assetid: 23f3ec30-a4c7-4f01-a9f3-08ae562dc2ea
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetInsertMarkColor
Retrieves the current color of the insertion mark.  
  
## Syntax  
  
```  
  
COLORREF GetInsertMarkColor( ) const;  
  
```  
  
## Return Value  
 Returns a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) structure that contains the color of the insertion point.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_GETINSERTMARKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb774947) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)