---
title: "COleControl::SetInitialSize"
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
  - "COleControl.SetInitialSize"
  - "COleControl::SetInitialSize"
  - "SetInitialSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetInitialSize method"
ms.assetid: 167fa13f-4ae3-43b7-b7bc-a6b69965cf3f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetInitialSize
Sets the size of an OLE control when first displayed in a container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The initial width of the OLE control in pixels.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The initial height of the OLE control in pixels.  
  
## Remarks  
 Call this function in your constructor to set the initial size of your control. The initial size is measured in device units, or pixels. It is recommended that this call be made in your control's constructor.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)