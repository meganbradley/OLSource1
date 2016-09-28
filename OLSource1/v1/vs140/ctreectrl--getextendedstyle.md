---
title: "CTreeCtrl::GetExtendedStyle"
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
  - "GetExtendedStyle method"
  - "CTreeCtrl.GetExtendedStyle"
  - "CTreeCtrl::GetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtendedStyle method"
ms.assetid: ca8c6b95-1125-49d6-b0cb-02696328c3c3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetExtendedStyle
Retrieves the extended styles that the current tree-view control is using.  
  
## Syntax  
  
```  
DWORD GetExtendedStyle() const;  
```  
  
## Return Value  
 A value that contains a bitwise combination (OR) of the current tree-view control's extended styles. For more information, see [Tree-View Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb759981).  
  
## Remarks  
 This method sends the [TVM_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb773580) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TVM_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb773580)   
 [CTreeCtrl::SetExtendedStyle](../vs140/ctreectrl--setextendedstyle.md)   
 [Tree-View Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb759981)