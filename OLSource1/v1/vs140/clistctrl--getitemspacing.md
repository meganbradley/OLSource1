---
title: "CListCtrl::GetItemSpacing"
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
  - "CListCtrl::GetItemSpacing"
  - "CListCtrl.GetItemSpacing"
  - "GetItemSpacing method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemSpacing method"
ms.assetid: 5bd9e509-f188-4c0b-9e1f-6b1e6183a2c7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetItemSpacing
Calculates the spacing between items in the current list-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|View for which to retrieve the item spacing. Specify <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for small icon view, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for icon view.|  
|[out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Contains the horizontal spacing between items.|  
|[out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Contains the vertical spacing between items.|  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method sends the [LVM_GETITEMSPACING](http://msdn.microsoft.com/library/windows/desktop/bb761051) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in Windows NT 3.51 and later.  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_GETITEMSPACING](http://msdn.microsoft.com/library/windows/desktop/bb761051)