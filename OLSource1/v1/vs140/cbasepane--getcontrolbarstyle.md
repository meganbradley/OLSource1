---
title: "CBasePane::GetControlBarStyle"
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
  - "GetControlBarStyle"
  - "CBasePane.GetControlBarStyle"
  - "CBasePane::GetControlBarStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetControlBarStyle method"
ms.assetid: b8b4c8d3-0f76-4427-ace7-5e7f1b3c5bef
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetControlBarStyle
Returns the control bar style.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A bitwise-OR combination of AFX_CBRS_ flags.  
  
## Remarks  
 The return value is a combination of the following possible values.  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Makes the control bar float.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Enables auto-hide mode.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Enables resizing of the control bar. When this flag is set, the control bar can be placed in a dockable pane.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Enables hiding of the control bar.|  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::SetControlBarStyle](../vs140/cbasepane--setcontrolbarstyle.md)