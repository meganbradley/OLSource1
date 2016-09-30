---
title: "CLinkCtrl::HitTest"
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
  - "CLinkCtrl.HitTest"
  - "CLinkCtrl::HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method [MFC]"
ms.assetid: b70c23f0-d41f-45e3-9b4b-baeed979cc7b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::HitTest
Determines if the user clicked the specified link.  
  
## Syntax  
  
```  
  
      BOOL HitTest(  
   PLHITTESTINFO phti  
) const;  
```  
  
#### Parameters  
 *phti*  
 Pointer to a **LHITTESTINFO** structure containing any information about the link the user clicked.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [LM_HITTEST](http://msdn.microsoft.com/library/windows/desktop/bb760722), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)