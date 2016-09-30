---
title: "CMDIFrameWndEx::AddPane"
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
  - "CMDIFrameWndEx.AddPane"
  - "CMDIFrameWndEx::AddPane"
  - "AddPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddPane method"
ms.assetid: 8c40a61e-8745-4100-ab70-c45d5696ca0f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::AddPane
Registers a pane with the docking manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the pane to register.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether to add this pane to the end of the list.  
  
## Return Value  
 Returns a non-zero value if the pane is registered successfully. Returns 0 if the pane is already registered with the docking manager.  
  
## Remarks  
 Each pane must be registered with the [CDockingManager Class](../vs140/cdockingmanager-class.md) before it can take a part in the docking layout. Use this method to notify the docking manager that you want to dock a specific pane. Once that pane is registered, the docking manager aligns it based on its alignment setting and position in the list of panes maintained by the docking manager.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)