---
title: "CPane::m_bHandleMinSize"
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
  - "m_bHandleMinSize"
  - "CPane.m_bHandleMinSize"
  - "CPane::m_bHandleMinSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bHandleMinSize"
  - "CPane class, data members"
ms.assetid: bde2091b-79b8-4b89-990f-b6a8bd63e484
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::m_bHandleMinSize
Enables consistent handling of minimum pane sizes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If one or more docking panes in your application override <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, or if your application calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you may want to set this static member to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in order to enable the framework to consistently handle how panes are sized.  
  
 If this value is set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, all panes whose size should be reduced below their minimum size are clipped, not stretched. Because the framework uses window regions for pane sizing purposes, do not change the size of the window region for docking panes if this value is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)