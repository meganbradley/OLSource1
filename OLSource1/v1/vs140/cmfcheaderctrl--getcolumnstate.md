---
title: "CMFCHeaderCtrl::GetColumnState"
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
  - "CMFCHeaderCtrl.GetColumnState"
  - "CMFCHeaderCtrl::GetColumnState"
  - "GetColumnState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColumnState method"
ms.assetid: 1369045f-49ce-4e31-a97b-1928189a3058
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCHeaderCtrl::GetColumnState
Indicates whether a column is unsorted, or is sorted in ascending or descending order.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of a column.  
  
## Return Value  
 A value that indicate the sort status of the specified column. The following table lists the possible values:  
  
|Value|Description|  
|-----------|-----------------|  
|-1|Sorted in descending order.|  
|0|Not sorted.|  
|1|Sorted in ascending order.|  
  
## Remarks  
  
## Requirements  
 **Header:** afxheaderctrl.h  
  
## See Also  
 [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)