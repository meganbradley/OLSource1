---
title: "CWnd::get_accChildCount"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - get_accChildCount
  - CWnd::get_accChildCount
  - CWnd.get_accChildCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_accChildCount method
ms.assetid: 9b337309-5080-4521-98ca-b247b8bc84aa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::get_accChildCount
Called by the framework to retrieve the number of children belonging to this object.  
  
## Syntax  
  
```  
  
      virtual HRESULT get_accChildCount(  
   long *pcountChildren  
);  
```  
  
#### Parameters  
 *pcountChildren*  
 Receives the number of children.  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in [IAccessible::get_accChildCount](http://msdn.microsoft.com/library/windows/desktop/dd318476) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your `CWnd`-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles). Call the base class version and then add the nonwindowed child elements.  
  
 For more information, see [IAccessible::get_accChildCount](http://msdn.microsoft.com/library/windows/desktop/dd318476) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accChild](../vs140/cwnd--get_accchild.md)