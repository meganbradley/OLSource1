---
title: "CMFCPropertyGridProperty::HitTest"
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
  - "CMFCPropertyGridProperty.HitTest"
  - "CMFCPropertyGridProperty::HitTest"
  - "HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: 16e7ee52-b24d-4a48-89a4-253071bae902
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::HitTest
Points to the property object that corresponds to the property list item that corresponds to a point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The point to test, in client coordinates. This parameter is typically the current mouse pointer location.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The point to test, in client coordinates.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 When this method returns, indicates the area that contains the specified point. For more information, see Remarks. The default value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to test any area in the property control; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to test only the description area. The default value is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 A pointer to a property object or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 By default, this method tests property sub-items if the specified point is not found within any of the property items.  
  
 The following table lists the values that can be returned to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.  
  
|Area|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The expand box control, which is designated by a plus sign (+).|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The property name.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The property value.|  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)