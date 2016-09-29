---
title: "CWnd::get_accChild"
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
  - "CWnd::get_accChild"
  - "get_accChild"
  - "CWnd.get_accChild"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_accChild method"
ms.assetid: 755e198b-100a-4498-bfc3-93e22c83d90a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::get_accChild
Called by the framework to retrieve the address of an `IDispatch` interface for the specified child.  
  
## Syntax  
  
```  
  
      virtual HRESULT get_accChild(  
   VARIANT varChild,  
   IDispatch **ppdispChild  
);  
```  
  
#### Parameters  
 `varChild`  
 Identifies the child whose `IDispatch` interface is to be retrieved.  
  
 *ppdispChild*  
 Receives the address of the child object's `IDispatch` interface.  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in [IAccessible::get_accChild](http://msdn.microsoft.com/library/windows/desktop/dd318475) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your `CWnd`-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see[IAccessible::get_accChild](http://msdn.microsoft.com/library/windows/desktop/dd318475) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accChildCount](../vs140/cwnd--get_accchildcount.md)   
 [CWnd::get_accParent](../vs140/cwnd--get_accparent.md)