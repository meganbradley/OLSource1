---
title: "CWnd::accHitTest"
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
  - "CWnd::accHitTest"
  - "accHitTest"
  - "CWnd.accHitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accHitTest method"
ms.assetid: a4f54b11-2717-4592-93e8-138d8cd802b5
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::accHitTest
Called by the framework to retrieve the child element or child object at a given point on the screen.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 X-coordinate of the point to be hit tested (in screen units).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Y-coordinate of the point to be hit tested (in screen units).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Receives information identifying the object at the point specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. See *pvarID* in [IAccessible::accHitTest](http://msdn.microsoft.com/library/windows/desktop/dd318471) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::accHitTest** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see [IAccessible::accHitTest](http://msdn.microsoft.com/library/windows/desktop/dd318471) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::accLocation](../vs140/cwnd--acclocation.md)