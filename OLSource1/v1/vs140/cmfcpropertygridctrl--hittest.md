---
title: "CMFCPropertyGridCtrl::HitTest"
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
  - "HitTest"
  - "CMFCPropertyGridCtrl::HitTest"
  - "CMFCPropertyGridCtrl.HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: 6a1276b0-af38-449b-a03d-f9f3721bb6d1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::HitTest
Retrieves a pointer to the property object that corresponds to a property grid control item if a specified point is in the item. This method also indicates the area in the property grid control that contains the point.  
  
## Syntax  
  
```  
CMFCPropertyGridProperty* HitTest(  
   CPoint pt,  
   CMFCPropertyGridProperty::ClickArea* pnArea=NULL,  
   BOOL bPropsOnly=FALSE   
) const;  
```  
  
#### Parameters  
 [in] `pt`  
 A point, in client coordinates.  
  
 [in, out] `pnArea`  
 A pointer to a `ClickArea` variable. When this method returns, the variable indicates the *property area*that contains the specified point. For more information about a property area, see Remarks.  
  
 [in] `bPropsOnly`  
 `TRUE` to test only the property area; `FALSE` to test the *description area*if the specified point is not in the property area. The default value is `FALSE`. For more information about the description area, see Remarks.  
  
## Return Value  
 If the `bPropsOnly` parameter is `TRUE` and the specified point is in a property area, the return value is a pointer to the corresponding property object. In addition, the `pnArea` parameter is set to the particular area that contains the specified point. Otherwise, the return value is `NULL` and the `pnArea` parameter is not modified.  
  
 If the `bPropsOnly` parameter is `FALSE`, the return value is always `NULL`. However, if the specified point is in the description area, the `pnArea` parameter is set to `CMFCPropertyGridProperty::ClickDescription`.  
  
## Remarks  
 The term *property area* refers to any one of the name, value, or expand box areas of a property grid control item. The *description area* is the zone at the bottom of a property grid control. When you click a property grid control item, the description area displays a description of the corresponding property.  
  
 This method sets the value of the variable that the `pnArea` parameter points to. The following table lists the possible values and corresponding areas.  
  
|Value|Area|  
|-----------|----------|  
|`ClickArea::ClickExpandBox`|Property expand box control.|  
|`ClickArea::ClickName`|Property name.|  
|`ClickArea::ClickValue`|Property value.|  
|`CMFCPropertyGridProperty::ClickDescription`|Property grid control description area.|  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)