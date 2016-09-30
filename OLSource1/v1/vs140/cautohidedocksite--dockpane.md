---
title: "CAutoHideDockSite::DockPane"
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
  - "CAutoHideDockSite.DockPane"
  - "DockPane"
  - "CAutoHideDockSite::DockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPane method"
ms.assetid: 407baa65-3475-445f-ac6a-b46f3105ede5
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite::DockPane
Docks a pane to this [CAutoHideDockSite](../vs140/cautohidedocksite-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The pane that the framework docks.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Docking options for the pane.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A rectangle that specifies the boundaries for the docked pane.|  
  
## Remarks  
 The default implementation does not use the parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which is provided for future use.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the framework puts the pane in the default location on the dock site. If the dock site is horizontal, the default location is at the far left of the dock site. Otherwise, the default location is at the top of the dock site.  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
## See Also  
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)