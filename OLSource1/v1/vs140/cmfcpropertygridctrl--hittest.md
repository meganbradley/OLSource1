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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A point, in client coordinates.  
  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable. When this method returns, the variable indicates the *property area*that contains the specified point. For more information about a property area, see Remarks.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to test only the property area; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to test the *description area*if the specified point is not in the property area. The default value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For more information about the description area, see Remarks.  
  
## Return Value  
 If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the specified point is in a property area, the return value is a pointer to the corresponding property object. In addition, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter is set to the particular area that contains the specified point. Otherwise, the return value is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter is not modified.  
  
 If the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the return value is always <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. However, if the specified point is in the description area, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter is set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Remarks  
 The term *property area* refers to any one of the name, value, or expand box areas of a property grid control item. The *description area* is the zone at the bottom of a property grid control. When you click a property grid control item, the description area displays a description of the corresponding property.  
  
 This method sets the value of the variable that the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter points to. The following table lists the possible values and corresponding areas.  
  
|Value|Area|  
|-----------|----------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Property expand box control.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Property name.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Property value.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Property grid control description area.|  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)