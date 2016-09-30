---
title: "CMDIFrameWndEx::AreMDITabs"
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
  - "AreMDITabs"
  - "CMDIFrameWndEx::AreMDITabs"
  - "CMDIFrameWndEx.AreMDITabs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AreMDITabs method"
ms.assetid: cffa3b14-e766-41a9-83d5-dd383a09938f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::AreMDITabs
Determines whether the MDI tabs feature or the MDI tabbed groups feature is enabled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an integer variable that indicates which features are enabled:  
  
-   0: All features are disabled.  
  
-   1: MDI tabs is enabled.  
  
-   2: MDI tabbed groups is enabled.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if MDI tabs or MDI tabbed groups is enabled.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if none of the above features is enabled.  
  
## Remarks  
 Use this function to determine whether MDI tabs or MDI tabbed groups is enabled for the frame window. Use [CMDIFrameWndEx::EnableMDITabs](../vs140/cmdiframewndex--enablemditabs.md) to enable or disable the MDI tabs feature.  
  
 Use [CMDIFrameWndEx::EnableMDITabbedGroups](../vs140/cmdiframewndex--enablemditabbedgroups.md) to enable or disable the MDI tabbed groups feature.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)