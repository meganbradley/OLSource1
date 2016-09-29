---
title: "CEdit::HideBalloonTip"
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
  - "CEdit.HideBalloonTip"
  - "CEdit::HideBalloonTip"
  - "HideBalloonTip method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HideBalloonTip method"
ms.assetid: f27741b6-2976-4fa3-a74f-2cf1c7871947
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::HideBalloonTip
Hides any balloon tip associated with the current edit control.  
  
## Syntax  
  
```  
BOOL HideBalloonTip();  
```  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This function sends the [EM_HIDEBALLOONTIP](http://msdn.microsoft.com/library/windows/desktop/bb761604) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This control is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::ShowBalloonTip](../vs140/cedit--showballoontip.md)   
 [EM_HIDEBALLOONTIP](http://msdn.microsoft.com/library/windows/desktop/bb761604)