---
title: "CPane::CreateDefaultMiniframe"
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
  - "CPane.CreateDefaultMiniframe"
  - "CPane::CreateDefaultMiniframe"
  - "CreateDefaultMiniframe"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDefaultMiniframe method"
ms.assetid: d8a4c1f9-ef6c-4b0f-898e-8421c2721d90
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::CreateDefaultMiniframe
Creates a mini-frame window for a floating pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the initial size and position, in screen coordinates, of the mini-frame window to create.  
  
## Return Value  
 The newly created mini-frame window.  
  
## Remarks  
 This method is called by the framework to create a mini-frame window when a pane is floated. The mini-frame window can be of type [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) or of type [CMultiPaneFrameWnd](../vs140/cmultipaneframewnd-class.md). A multi mini-frame window is created if the pane has the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> style.  
  
 The runtime class information for the mini-frame window is stored in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member. You can use a derived class to set this member if you decide to create customized mini-frame windows.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)