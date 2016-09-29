---
title: "CDockablePane::CreateDefaultPaneDivider"
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
  - "CreateDefaultPaneDivider"
  - "CDockablePane::CreateDefaultPaneDivider"
  - "CDockablePane.CreateDefaultPaneDivider"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDefaultPaneDivider method"
ms.assetid: 1eed178a-c637-4af6-92d5-d471dab157c8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CreateDefaultPaneDivider
Creates a default divider for the pane as it is being docked to a frame window.  
  
## Syntax  
  
```  
static CPaneDivider* __stdcall CreateDefaultPaneDivider(  
   DWORD dwAlignment,  
   CWnd* pParent,  
   CRuntimeClass* pSliderRTC = NULL  
);  
```  
  
#### Parameters  
 [in] `dwAlignment`  
 Specifies the side of the main frame to which the pane is being docked. If `dwAlignment` contains the `CBRS_ALIGN_LEFT` or `CBRS_ALIGN_RIGHT` flag, this method creates a vertical (`CPaneDivider::SS_VERT`) divider; otherwise, this method creates a horizontal (`CPaneDivider::SS_HORZ`) divider.  
  
 [in] `pParent`  
 Pointer to the parent frame.  
  
 [in] `pSliderRTC`  
 Not used.  
  
## Return Value  
 This method returns a pointer to the newly-created divider, or `NULL` if divider creation fails.  
  
## Remarks  
 `dwAlignment` can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|`CBRS_ALIGN_TOP`|The pane is being docked to the top of the client area of a frame window.|  
|`CBRS_ALIGN_BOTTOM`|The pane is being docked to the bottom of the client area of a frame window.|  
|`CBRS_ALIGN_LEFT`|The pane is being docked to the left side of the client area of a frame window.|  
|`CBRS_ALIGN_RIGHT`|The pane is being docked to the right side of the client area of a frame window.|  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)