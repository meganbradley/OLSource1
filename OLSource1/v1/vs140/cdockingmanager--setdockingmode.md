---
title: "CDockingManager::SetDockingMode"
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
  - "SetDockingMode"
  - "CDockingManager.SetDockingMode"
  - "CDockingManager::SetDockingMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDockingMode method"
ms.assetid: fd3eed54-0235-441d-98a0-fd006723cbe7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::SetDockingMode
Sets the docking mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the new docking mode. For more information, see the Remarks section.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the theme to be used for smart docking markers. It can be  one of the following enumerated values: AFX_SDT_DEFAULT, AFX_SDT_VS2005, AFX_SDT_VS2008.  
  
## Remarks  
 Call this static method to set the docking mode.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can be one of following values:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> - Standard docking mode as implemented in Visual Studio .NET 2003. Panes are dragged without a dragging context.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> - Immediate docking mode as implemented in Microsoft Visio. Panes are dragged with a dragging context, but no markers are displayed.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> - Smart docking mode as implemented in Visual Studio 2005. Panes are dragged with a dragging context and smart markers are displayed that show where the pane can be docked.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)