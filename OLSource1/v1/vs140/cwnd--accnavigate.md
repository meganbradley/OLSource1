---
title: "CWnd::accNavigate"
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
  - "CWnd.accNavigate"
  - "accNavigate"
  - "CWnd::accNavigate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accNavigate method"
ms.assetid: 74377c9f-82f8-4df8-b6e5-cdd3c726d6e8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::accNavigate
Called by the framework to traverse to another user interface element within a container and if possible, retrieve the object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the direction to navigate. See <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in [IAccessible::accNavigate](http://msdn.microsoft.com/library/windows/desktop/dd318473) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the starting object. See <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in **IAccessible::accNavigate** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *pvarEndUpAt*  
 Receives information about the destination user interface object. See *pvarEnd* in **IAccessible::accNavigate** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::accNavigate** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see [IAccessible::accNavigate](http://msdn.microsoft.com/library/windows/desktop/dd318473) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::accSelect](../vs140/cwnd--accselect.md)