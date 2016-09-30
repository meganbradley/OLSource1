---
title: "COleControl::InitializeIIDs"
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
  - "COleControl::InitializeIIDs"
  - "InitializeIIDs"
  - "COleControl.InitializeIIDs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitializeIIDs method"
ms.assetid: 04143089-1193-4120-bde0-2aa10452b7cc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::InitializeIIDs
Informs the base class of the IIDs the control will use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *piidPrimary*  
 Pointer to the interface ID of the control's primary dispatch interface.  
  
 *piidEvents*  
 Pointer to the interface ID of the control's event interface.  
  
## Remarks  
 Call this function in the control's constructor to inform the base class of the interface IDs your control will be using.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)