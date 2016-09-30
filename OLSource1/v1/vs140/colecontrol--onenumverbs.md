---
title: "COleControl::OnEnumVerbs"
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
  - "COleControl::OnEnumVerbs"
  - "COleControl.OnEnumVerbs"
  - "OnEnumVerbs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEnumVerbs method"
ms.assetid: d2c5abbc-2ab3-4fd4-8643-11e917a5f685
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnEnumVerbs
Called by the framework when the container calls the **IOleObject::EnumVerbs** member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the **IEnumOLEVERB** object that enumerates the control's verbs.  
  
## Return Value  
 Nonzero if verbs are available; otherwise 0.  
  
## Remarks  
 The default implementation enumerates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> entries in the message map.  
  
 Override this function to change the default way of enumerating verbs.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ON_OLEVERB](../vs140/on_oleverb.md)   
 [ON_STDOLEVERB](../vs140/on_stdoleverb.md)