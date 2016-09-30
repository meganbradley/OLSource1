---
title: "CToolBarCtrl::GetButtonInfo"
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
  - "CToolBarCtrl.GetButtonInfo"
  - "GetButtonInfo"
  - "CToolBarCtrl::GetButtonInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButtonInfo method"
  - "CToolBarCtrl class, retrieving button information"
ms.assetid: 54180057-2bf0-47cc-b0d4-983cf2ad8d0a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetButtonInfo
Retrieves the information for a button in a toolbar.  
  
## Syntax  
  
```  
  
      int GetButtonInfo(  
   int nID,  
   TBBUTTONINFO* ptbbi   
) const;  
```  
  
#### Parameters  
 `nID`  
 The button identifier.  
  
 `ptbbi`  
 A pointer to a [TBBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb760478) structure that receives the button information.  
  
## Return Value  
 The zero-based index of the button, if successful; otherwise -1.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb787321), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetButtonInfo](../vs140/ctoolbarctrl--setbuttoninfo.md)