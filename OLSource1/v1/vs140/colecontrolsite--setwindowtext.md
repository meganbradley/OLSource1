---
title: "COleControlSite::SetWindowText"
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
  - "COleControlSite::SetWindowText"
  - "COleControlSite.SetWindowText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowText method"
  - "COleControlSite class, overridables"
ms.assetid: 747b649a-1bad-4aa1-b9f2-ab14806d81c6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::SetWindowText
Sets the text for the control site.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string to be used as the new title or control text.  
  
## Remarks  
 This function first attempts to set the Caption stock property. If the Caption stock property is not supported, the Text property is set instead.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)