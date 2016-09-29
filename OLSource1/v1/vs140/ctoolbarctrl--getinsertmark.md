---
title: "CToolBarCtrl::GetInsertMark"
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
  - "CToolBarCtrl.GetInsertMark"
  - "GetInsertMark"
  - "CToolBarCtrl::GetInsertMark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolBarCtrl class, attributes"
  - "GetInsertMark method"
ms.assetid: 14fa5ff2-1459-47a2-9544-657051350fe3
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetInsertMark
Retrieves the current insertion mark for the toolbar.  
  
## Syntax  
  
```  
  
      void GetInsertMark(  
   TBINSERTMARK* ptbim   
) const;  
```  
  
#### Parameters  
 `ptbim`  
 A pointer to a [TBINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb760480) structure that receives the insertion mark.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb787338), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetInsertMark](../vs140/ctoolbarctrl--setinsertmark.md)