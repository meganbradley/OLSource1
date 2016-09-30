---
title: "COleControl::OnSetClientSite"
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
  - "COleControl.OnSetClientSite"
  - "OnSetClientSite"
  - "COleControl::OnSetClientSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetClientSite method"
ms.assetid: f7634662-4750-48a5-a52b-02708a68a683
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnSetClientSite
Called by the framework when the container has called the control's **IOleControl::SetClientSite** function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 By default, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> checks whether data path properties are loaded and, if they are, calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 Override this function to do any special processing of this notification. In particular, overrides of this function should call the base class.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)