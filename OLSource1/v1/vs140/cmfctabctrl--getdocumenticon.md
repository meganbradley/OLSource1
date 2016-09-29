---
title: "CMFCTabCtrl::GetDocumentIcon"
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
  - "CMFCTabCtrl::GetDocumentIcon"
  - "CMFCTabCtrl.GetDocumentIcon"
  - "GetDocumentIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocumentIcon method"
  - "CMFCTabCtrl::GetDocumentIcon"
ms.assetid: e6cf1977-55bf-4d37-a2fc-0c9ff731abe4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::GetDocumentIcon
Retrieves the image that is associated with a tab in a pop-up menu of tabbed windows.  
  
## Syntax  
  
```  
static HICON __stdcall GetDocumentIcon(  
   UINT nCmdID  
);  
```  
  
#### Parameters  
 [in] `nCmdID`  
 The command ID of a tab in a pop-up menu of tabbed windows.  
  
## Return Value  
 The handle of a bitmap image.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTabCtrl::EnableTabDocumentsMenu](../vs140/cmfctabctrl--enabletabdocumentsmenu.md)