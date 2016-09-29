---
title: "CWnd::accLocation"
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
  - "accLocation"
  - "CWnd.accLocation"
  - "CWnd::accLocation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accLocation method"
ms.assetid: 9ac4f232-3d3c-443d-9fff-fc1db00231bf
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::accLocation
Called by the framework to retrieve the specified object's current screen location.  
  
## Syntax  
  
```  
  
      virtual HRESULT accLocation(  
   long *pxLeft,  
   long *pyTop,  
   long *pcxWidth,  
   long *pcyHeight,  
   VARIANT varChild  
);  
```  
  
#### Parameters  
 *pxLeft*  
 Receives x-coordinate of the object's upper-left corner (in screen units).  
  
 *pyTop*  
 Receives y-coordinate of the object's upper-left corner (in screen units).  
  
 *pcxWidth*  
 Receives width of the object (in screen units).  
  
 *pcyHeight*  
 Receives height of the object (in screen units).  
  
 `varChild`  
 Specifies whether the location to be retrieved is that of the object or one of the object's child elements. This parameter can be either CHILDID_SELF (to obtain information about the object) or a child ID (to obtain information about the object's child element).  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::accLocation** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 Override this function in your `CWnd`-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see **IAccessible::accLocation** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::accHitTest](../vs140/cwnd--acchittest.md)