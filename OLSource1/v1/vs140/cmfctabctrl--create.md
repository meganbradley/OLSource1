---
title: "CMFCTabCtrl::Create"
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
  - "Create"
  - "CMFCTabCtrl.Create"
  - "CMFCTabCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 254c5594-c2e6-4da7-8ece-cb412436ee73
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::Create
Creates the tab control and attaches it to the `CMFCTabCtrl` object.  
  
## Syntax  
  
```  
BOOL Create(  
   Style style,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID,  
   Location location=LOCATION_BOTTOM,  
   BOOL bCloseBtn=FALSE   
);  
```  
  
#### Parameters  
 [in] `style`  
 The style of the tab control. For more information, see Remarks.  
  
 [in] `rect`  
 A rectangle that bounds the tab control.  
  
 [in] `pParentWnd`  
 A pointer to a parent window. Must not be `NULL`.  
  
 [in] `nID`  
 The ID of the tab control.  
  
 [in] `location`  
 The location of tabs. The default value is `LOCATION_BOTTOM`. For more information, see Remarks.  
  
 [in] `bCloseBtn`  
 `TRUE` to display a close button on the tab; otherwise, `FALSE`. The default value is `FALSE`.  
  
## Return Value  
 `TRUE` if successful; otherwise, `FALSE`.  
  
## Remarks  
 The following table describes the values you can specify for the `style` parameter.  
  
|Style|Description|  
|-----------|-----------------|  
|STYLE_3D|Creates a tab control with a three-dimensional appearance.|  
|STYLE_FLAT|Creates a tab control with flat tabs.|  
|STYLE_FLAT_SHARED_HORZ_SCROLL|Creates a tab control with flat tabs and a scroll bar that can scroll the tabs if they are clipped by a parent window.|  
|STYLE_3D_ONENOTE|Creates a tab control in the style of Microsoft OneNote.|  
|STYLE_3D_VS2005|Creates a tab control in the style of Microsoft Visual Studio 2005.|  
|STYLE_3D_ROUNDED|Creates a tab control with rounded tabs in the style of Microsoft Visual Studio 2005.|  
|STYLE_3D_ROUNDED_SCROLL|Creates a tab control with rounded tabs and scroll buttons in the style of Microsoft Visual Studio 2005.|  
  
 The following table lists the values you can specify for the `location` parameter.  
  
|Location|Description|  
|--------------|-----------------|  
|LOCATION_BOTTOM|Tabs are located at the bottom of the tab control.|  
|LOCATION_TOP|Tabs are located at the top of the tab control.|  
  
## Example  
 The following example demonstrates how to use the `Create` method in the `CMFCTabCtrl` class. This example is part of the [State Collection sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_StateCollection#1](../vs140/codesnippet/CPP/cmfctabctrl--create_1.h)]  
[!code[NVC_MFC_StateCollection#2](../vs140/codesnippet/CPP/cmfctabctrl--create_2.cpp)]  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)