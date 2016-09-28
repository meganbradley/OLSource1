---
title: "CMFCPropertyGridProperty::GetExpandedSubItems"
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
  - "CMFCPropertyGridProperty.GetExpandedSubItems"
  - "CMFCPropertyGridProperty::GetExpandedSubItems"
  - "GetExpandedSubItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExpandedSubItems method"
ms.assetid: 0ee01e76-1eac-4fbe-9245-2b5bf5654ed4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::GetExpandedSubItems
Retrieves the number of expanded sub-items.  
  
## Syntax  
  
```  
int GetExpandedSubItems(  
   BOOL bIncludeHidden=TRUE   
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `bIncludeHidden`|`TRUE` to include the hidden sub-items in the count; otherwise, `FALSE`. The default value is `TRUE`.|  
  
## Return Value  
 The number of expanded sub-items.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)