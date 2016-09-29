---
title: "CMDIFrameWndEx::TabbedDocumentToControlBar"
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
  - "TabbedDocumentToControlBar"
  - "CMDIFrameWndEx::TabbedDocumentToControlBar"
  - "CMDIFrameWndEx.TabbedDocumentToControlBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TabbedDocumentToControlBar method"
ms.assetid: e894af24-9c74-4543-a1a9-6f2c67ec2ce7
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::TabbedDocumentToControlBar
Converts the specified tabbed document to a docking pane.  
  
## Syntax  
  
```  
virtual BOOL TabbedDocumentToControlBar(  
   CMDIChildWndEx* pMDIChildWnd   
);  
```  
  
#### Parameters  
 `pMDIChildWnd`  
 A pointer to MDI child window that contains a docking pane.  
  
## Return Value  
 `TRUE` if the method was successful, `FALSE` on failure.  
  
## Remarks  
 Use this method to convert a tabbed document to a docking pane. The tabbed document must have been created by using [CMDIFrameWndEx::ControlBarToTabbedDocument](../vs140/cmdiframewndex--controlbartotabbeddocument.md).  
  
## Example  
 The following example shows how `TabbedDocumentToControlBar` is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#19](../vs140/codesnippet/CPP/cmdiframewndex--tabbeddocumenttocontrolbar_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)