---
title: "CReBarCtrl::GetDropTarget"
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
  - "GetDropTarget"
  - "CReBarCtrl.GetDropTarget"
  - "CReBarCtrl::GetDropTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, attributes"
  - "GetDropTarget method"
ms.assetid: bfea8bae-554c-444b-858c-b84b4c939fc3
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetDropTarget
Implements the behavior of the Win32 message [RB_GETDROPTARGET](http://msdn.microsoft.com/library/windows/desktop/bb774463), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
IDropTarget* GetDropTarget( ) const;  
  
```  
  
## Return Value  
 A pointer to an [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)