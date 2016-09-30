---
title: "COleControl::OnClose"
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
  - "COleControl.OnClose"
  - "COleControl::OnClose"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClose method"
ms.assetid: 1cf8a86c-2420-494d-a626-1e18815539cc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnClose
Called by the framework when the container has called the control's **IOleControl::Close** function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Flag that indicates whether the object should be saved before loading. Valid values are:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Remarks  
 By default, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> saves the control object if it has been modified and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is either <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)