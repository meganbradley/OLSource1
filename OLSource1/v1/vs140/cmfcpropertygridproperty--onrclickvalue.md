---
title: "CMFCPropertyGridProperty::OnRClickValue"
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
  - "CMFCPropertyGridProperty.OnRClickValue"
  - "CMFCPropertyGridProperty::OnRClickValue"
  - "OnRClickValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRClickValue method"
ms.assetid: 400f07b4-6ef3-42d9-bd83-acddf730f46d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::OnRClickValue
Called by the framework when the user clicks the right mouse button in the property value area.  
  
## Syntax  
  
```  
virtual void OnRClickValue(  
   CPoint C,  
   BOOL B   
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `C`|A point, in client coordinates.|  
|[in] `B`|A Boolean.|  
  
## Remarks  
 By default, this method does nothing and the `B` parameter has no predefined purpose.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)