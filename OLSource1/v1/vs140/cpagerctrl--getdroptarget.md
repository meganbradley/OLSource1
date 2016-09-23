---
title: "CPagerCtrl::GetDropTarget"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CPagerCtrl::GetDropTarget
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDropTarget method
ms.assetid: 1ee01946-edd6-4c3c-98c9-8687f52d5357
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPagerCtrl::GetDropTarget
Retrieves the [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface for the current pager control.  
  
## Syntax  
  
```  
IDropTarget* GetDropTarget() const;  
```  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Return Value  
 A pointer to the `IDropTarget` interface for the current pager control.  
  
## Remarks  
 `IDropTarget` is one of the interfaces you implement to support drag-and-drop operations in your application.  
  
 This method sends the [PGM_GETDROPTARGET](http://msdn.microsoft.com/library/windows/desktop/bb760872) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The caller of this method is responsible for calling the `Release` member of the [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface when the interface is no longer needed.  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_GETDROPTARGET](http://msdn.microsoft.com/library/windows/desktop/bb760872)   
 [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679)