---
title: "COleDropTarget::Revoke"
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
  - "Revoke"
  - "COleDropTarget.Revoke"
  - "COleDropTarget::Revoke"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Revoke method"
  - "COleDropTarget class, operations"
ms.assetid: 64616663-6fdc-4126-8c3f-aca75f649802
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget::Revoke
Call this function before destroying any window that has been registered as a drop target through a call to [Register](../vs140/coledroptarget--register.md) to remove it from the list of drop targets.  
  
## Syntax  
  
```  
  
virtual void Revoke( );  
```  
  
## Remarks  
 This function is called automatically from the [OnDestroy](../vs140/cwnd--ondestroy.md) handler for the window that was registered, so it is usually not necessary to call this function explicitly.  
  
 For more information, see [RevokeDragDrop](http://msdn.microsoft.com/library/windows/desktop/ms692643) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropTarget Class](../vs140/coledroptarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)