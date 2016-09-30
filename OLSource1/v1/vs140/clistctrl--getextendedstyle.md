---
title: "CListCtrl::GetExtendedStyle"
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
  - "CListCtrl.GetExtendedStyle"
  - "CListCtrl::GetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtendedStyle method"
ms.assetid: 4fe64033-098f-46e9-873b-7738332bbc1d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetExtendedStyle
Retrieves the current extended styles of a list view control.  
  
## Syntax  
  
```  
  
DWORD GetExtendedStyle( );  
  
```  
  
## Return Value  
 A combination of the extended styles currently in use by the list view control. For a descriptive list of these extended styles, see the [Extended List View Styles](http://msdn.microsoft.com/library/windows/desktop/bb774732) topic in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_GetExtendedListViewStyle](http://msdn.microsoft.com/library/windows/desktop/bb761264), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CListCtrl::SetExtendedStyle](../vs140/clistctrl--setextendedstyle.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetExtendedStyle](../vs140/clistctrl--setextendedstyle.md)