---
title: "CToolBarCtrl::GetDropTarget"
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
  - "CToolBarCtrl.GetDropTarget"
  - "CToolBarCtrl::GetDropTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDropTarget method"
  - "drop target, retrieving"
ms.assetid: 1d9d89f2-e717-4509-8e04-fdc2d513afbd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetDropTarget
Retrieves the [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface for a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface pointer. If an error occurs, a **NULL** pointer is placed in this address.  
  
## Return Value  
 Returns an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value indicating success or failure of the operation.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787343), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)