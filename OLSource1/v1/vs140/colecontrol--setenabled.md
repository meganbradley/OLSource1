---
title: "COleControl::SetEnabled"
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
  - "COleControl::SetEnabled"
  - "COleControl.SetEnabled"
  - "SetEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetEnabled method"
ms.assetid: 32006327-c927-44b0-83cb-95f43e34dbd6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetEnabled
Sets the stock Enabled property value of your control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **TRUE** if the control is to be enabled; otherwise **FALSE**.  
  
## Remarks  
 After setting this property, **OnEnabledChange** is called.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetEnabled](../vs140/colecontrol--getenabled.md)   
 [COleControl::OnEnabledChanged](../vs140/colecontrol--onenabledchanged.md)