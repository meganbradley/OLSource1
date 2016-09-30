---
title: "CPane::SetMiniFrameRTC"
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
  - "CPane.SetMiniFrameRTC"
  - "SetMiniFrameRTC"
  - "CPane::SetMiniFrameRTC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMiniFrameRTC method"
ms.assetid: bff1239f-8035-4c61-9dc8-04079fe8f53c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::SetMiniFrameRTC
Sets the runtime class information for the default mini-frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the runtime class information for the mini-frame window.  
  
## Remarks  
 When a pane is floated, it is put on a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) (mini-frame) window. You can provide a custom <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived class that will be used when [CPane::CreateDefaultMiniframe](../vs140/cpane--createdefaultminiframe.md) is called.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)