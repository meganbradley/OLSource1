---
title: "CMDIFrameWndEx::GetMDITabGroups"
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
  - "CMDIFrameWndEx.GetMDITabGroups"
  - "CMDIFrameWndEx::GetMDITabGroups"
  - "GetMDITabGroups"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMDITabGroups method"
ms.assetid: 6ace4a34-fc05-4337-8e9b-a4389806d171
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::GetMDITabGroups
Returns a list of MDI tabbed windows.  
  
## Syntax  
  
```  
const CObList& GetMDITabGroups() const;  
```  
  
## Return Value  
 A reference to a [CObList Class](../vs140/coblist-class.md) object that contains a list of tabbed windows. Do not store or modify the list.  
  
## Remarks  
 Use this method to access the list of tabbed windows. It can be helpful if you want to change or query some parameters of individual tabbed windows.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)