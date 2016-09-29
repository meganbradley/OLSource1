---
title: "COleControl::OnProperties"
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
  - "COleControl.OnProperties"
  - "OnProperties"
  - "COleControl::OnProperties"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnProperties method"
ms.assetid: 4b4d4151-2433-4642-8583-64fead777f66
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnProperties
Called by the framework when the control's properties verb has been invoked by the container.  
  
## Syntax  
  
```  
  
      virtual BOOL OnProperties(  
   LPMSG lpMsg,  
   HWND hWndParent,  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `lpMsg`  
 A pointer to the Windows message that invoked the verb.  
  
 `hWndParent`  
 A handle to the parent window of the control.  
  
 `lpRect`  
 A pointer to the rectangle used by the control in the container.  
  
## Return Value  
 Nonzero if the call is successful; otherwise 0.  
  
## Remarks  
 The default implementation displays a modal property dialog box.  
  
 You can also use this function to cause the display of your control's property pages. Make a call to the `OnProperties` function, passing the handle of your control's parent in the `hWndParent` parameter. In this case, the values of the `lpMsg` and `lpRect` parameters are ignored.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)