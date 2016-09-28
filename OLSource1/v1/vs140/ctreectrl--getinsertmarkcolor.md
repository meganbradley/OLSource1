---
title: "CTreeCtrl::GetInsertMarkColor"
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
  - "CTreeCtrl.GetInsertMarkColor"
  - "CTreeCtrl::GetInsertMarkColor"
  - "GetInsertMarkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInsertMarkColor method"
ms.assetid: 7a9f51cd-51b7-4923-8600-616b2590f556
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetInsertMarkColor
This member function implements the behavior of the Win32 message [TVM_GETINSERTMARKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb773590), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
COLORREF GetInsertMarkColor( ) const;  
  
```  
  
## Return Value  
 A **COLORREF** value that contains the current insertion mark color.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#13](../vs140/codesnippet/CPP/ctreectrl--getinsertmarkcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetInsertMarkColor](../vs140/ctreectrl--setinsertmarkcolor.md)