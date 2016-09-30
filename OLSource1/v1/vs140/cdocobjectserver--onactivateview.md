---
title: "CDocObjectServer::OnActivateView"
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
  - "CDocObjectServer.OnActivateView"
  - "CDocObjectServer::OnActivateView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivateView method"
ms.assetid: ade4fed1-b20d-49de-bd80-2176d87b159f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServer::OnActivateView
Call this function to display the DocObject view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns an error or warning value. By default, returns **NOERROR** if successful; otherwise, **E_FAIL**.  
  
## Remarks  
 This function creates an in-place frame window, draws scrollbars within the view, sets up the menus the server shares with its container, adds frame controls, sets the active object, then finally shows the in-place frame window and sets the focus.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServer Class](../vs140/cdocobjectserver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServer::OnApplyViewState](../vs140/cdocobjectserver--onapplyviewstate.md)