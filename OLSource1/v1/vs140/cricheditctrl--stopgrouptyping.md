---
title: "CRichEditCtrl::StopGroupTyping"
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
  - "CRichEditCtrl.StopGroupTyping"
  - "CRichEditCtrl::StopGroupTyping"
  - "StopGroupTyping"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StopGroupTyping method"
ms.assetid: dc4b1c1e-97f2-4dc3-9ff9-17e676adf54f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::StopGroupTyping
Stops the control from collecting additional typing actions into the current undo action.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The control stores the next typing action, if any, into a new action in the undo queue.  
  
 For more information, see [EM_STOPGROUPTYPING](http://msdn.microsoft.com/library/windows/desktop/bb774300) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)