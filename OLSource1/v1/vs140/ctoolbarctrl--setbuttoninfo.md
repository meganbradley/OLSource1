---
title: "CToolBarCtrl::SetButtonInfo"
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
  - "CToolBarCtrl.SetButtonInfo"
  - "CToolBarCtrl::SetButtonInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonInfo method"
ms.assetid: 94ba6ee7-a1b8-499c-bb9a-24ebb4de4fb7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetButtonInfo
Sets the information for an existing button in a toolbar.  
  
## Syntax  
  
```  
  
      BOOL SetButtonInfo(  
   int nID,  
   TBBUTTONINFO* ptbbi   
);  
```  
  
#### Parameters  
 `nID`  
 The button identifier.  
  
 `ptbbi`  
 A pointer to a [TBBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb760478) structure that receives the button information.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The member function implements the behavior of the Win32 message [TB_SETBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb787413), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetButtonInfo](../vs140/ctoolbarctrl--getbuttoninfo.md)