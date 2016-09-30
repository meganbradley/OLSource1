---
title: "COleControl::OnClick"
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
  - "COleControl.OnClick"
  - "OnClick"
  - "COleControl::OnClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClick method"
ms.assetid: 90233892-4283-4d30-b59f-afcf5e821701
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnClick
Called by the framework when a mouse button has been clicked or the DoClick stock method has been invoked.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *iButton*  
 Index of a mouse button. Can have one of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was clicked.  
  
-   **MIDDLE_BUTTON** The middle mouse button was clicked.  
  
-   **RIGHT_BUTTON** The right mouse button was clicked.  
  
## Remarks  
 The default implementation calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 Override this member function to modify or extend the default handling.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoClick](../vs140/colecontrol--doclick.md)   
 [COleControl::FireClick](../vs140/colecontrol--fireclick.md)