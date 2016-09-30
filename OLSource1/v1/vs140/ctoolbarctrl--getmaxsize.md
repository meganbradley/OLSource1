---
title: "CToolBarCtrl::GetMaxSize"
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
  - "CToolBarCtrl.GetMaxSize"
  - "CToolBarCtrl::GetMaxSize"
  - "GetMaxSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size"
  - "CToolBarCtrl class, attributes"
  - "size, checking toolbar"
  - "toolbars [C++], size"
  - "GetMaxSize method"
ms.assetid: 3066a413-606a-4af7-b2b7-95f47bc5057b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetMaxSize
Retrieves the total size of all of the visible buttons and separators in the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that receives the size of the items.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETMAXSIZE](http://msdn.microsoft.com/library/windows/desktop/bb787341), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)