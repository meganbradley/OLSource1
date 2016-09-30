---
title: "COleControl::OnGetControlInfo"
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
  - "COleControl::OnGetControlInfo"
  - "OnGetControlInfo"
  - "COleControl.OnGetControlInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetControlInfo method"
ms.assetid: c8f337c6-d698-4d6b-8307-2e69f0561f5e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetControlInfo
Called by the framework when the control's container has requested information about the control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [CONTROLINFO](http://msdn.microsoft.com/library/windows/desktop/ms680734) structure to be filled in.  
  
## Remarks  
 This information consists primarily of a description of the control's mnemonic keys. The default implementation fills <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with default information.  
  
 Override this function if your control needs to process mnemonic keys.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)