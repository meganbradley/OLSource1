---
title: "CHeaderCtrl::SetHotDivider"
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
  - "CHeaderCtrl.SetHotDivider"
  - "CHeaderCtrl::SetHotDivider"
  - "SetHotDivider"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHotDivider method"
ms.assetid: 0b4a29bb-def2-4570-a834-b2e5f49664ea
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::SetHotDivider
Changes the divider between header items to indicate a manual drag and drop of a header item.  
  
## Syntax  
  
```  
  
      int SetHotDivider(  
   CPoint pt   
);  
int SetHotDivider(  
   int nIndex   
);  
```  
  
#### Parameters  
 `pt`  
 The position of the pointer. The header control highlights the appropriate divider based on the pointer's position.  
  
 `nIndex`  
 The index of the highlighted divider.  
  
## Return Value  
 The index of the highlighted divider.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [HDM_SETHOTDIVIDER](http://msdn.microsoft.com/library/windows/desktop/bb775363), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It is provided to support header item drag and drop.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#16](../vs140/codesnippet/CPP/cheaderctrl--sethotdivider_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)