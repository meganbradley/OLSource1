---
title: "CToolBarCtrl::MoveButton"
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
  - "MoveButton"
  - "CToolBarCtrl::MoveButton"
  - "CToolBarCtrl.MoveButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveButton method"
ms.assetid: a273f9de-37da-4cd3-bc34-83d1b64d0819
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::MoveButton
Moves a button from one index to another.  
  
## Syntax  
  
```  
  
      BOOL MoveButton(  
   UINT nOldPos,  
   UINT nNewPos   
);  
```  
  
#### Parameters  
 *nOldPos*  
 The zero-based index of the button to be moved.  
  
 *nNewPos*  
 The zero-based index of the button's destination.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_MOVEBUTTON](http://msdn.microsoft.com/library/windows/desktop/bb787387), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)