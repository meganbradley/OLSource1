---
title: "CMDIFrameWndEx::MDITabNewGroup"
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
  - "CMDIFrameWndEx.MDITabNewGroup"
  - "MDITabNewGroup"
  - "CMDIFrameWndEx::MDITabNewGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MDITabNewGroup method"
ms.assetid: 1529f94b-7a8c-418e-b310-4cc2a04e3dfa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::MDITabNewGroup
Creates a new tabbed group that has a single window.  
  
## Syntax  
  
```  
void MDITabNewGroup(  
   BOOL bVert=TRUE   
);  
```  
  
#### Parameters  
 [in] `bVert`  
 Specifies the new group alignment. If `TRUE`, the new group is aligned vertically. If `FALSE`, the new group is aligned horizontally.  
  
## Remarks  
 Use this function to create a new tabbed window (new tabbed group) and add the first tab to it.  
  
## Example  
 The following example shows how `MDITabNewGroup` is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#12](../vs140/codesnippet/CPP/cmdiframewndex--mditabnewgroup_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)