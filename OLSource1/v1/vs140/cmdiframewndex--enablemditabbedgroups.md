---
title: "CMDIFrameWndEx::EnableMDITabbedGroups"
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
  - "CMDIFrameWndEx::EnableMDITabbedGroups"
  - "EnableMDITabbedGroups"
  - "CMDIFrameWndEx.EnableMDITabbedGroups"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableMDITabbedGroups method"
ms.assetid: 62c7f189-ce9e-466d-8cf2-d9a7e8006045
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::EnableMDITabbedGroups
Enables or disables the MDI tabbed groups feature for the frame window.  
  
## Syntax  
  
```  
void EnableMDITabbedGroups(  
   BOOL bEnable,  
   const CMDITabInfo& params   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 If `TRUE`, the MDI tabbed groups feature is enabled; if `FALSE`, the MDI tabbed groups feature is disabled.  
  
 [in] `params`  
 Specifies parameters that the framework applies to child windows that are created in the MDI client area.  
  
## Remarks  
 Use this method to enable or disable the MDI tabbed groups feature. This feature enables MDI applications to display child windows as tabbed windows that are aligned vertically or horizontally within the MDI client area. Groups of tabbed windows are separated by splitters. The user can resize tabbed groups by using a splitter.  
  
-   The user can:  
  
-   Drag individual tabs between groups.  
  
-   Drag individual tabs to the edge of the window to create new groups.  
  
-   Move tabs or create new groups by using a shortcut menu.  
  
-   Your application can save the current layout of tabbed windows and the list of currently opened documents.  
  
 If you call this method with `bEnable` set to `FALSE`, `params` is ignored.  
  
 Even if MDI tabbed groups is already enabled, you can call this method again to modify the settings for child windows. Call the method with `bEnable` set to `TRUE` and modify the members of the `CMDITabInfo` object that are specified by the `params` parameter.  
  
 For more information about how to use MDI tabbed groups, see [MDI Tabbed Groups](../vs140/mdi-tabbed-groups.md).  
  
## Example  
 The following example shows how `EnableMDITabbedGroups` is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#8](../vs140/codesnippet/CPP/cmdiframewndex--enablemditabbedgroups_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [MDI Tabbed Groups](../vs140/mdi-tabbed-groups.md)   
 [CMDITabInfo Class](../vs140/cmditabinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)