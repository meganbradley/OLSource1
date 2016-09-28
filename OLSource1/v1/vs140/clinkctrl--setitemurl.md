---
title: "CLinkCtrl::SetItemUrl"
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
  - "CLinkCtrl::SetItemUrl"
  - "SetItemUrl"
  - "CLinkCtrl.SetItemUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemURL method"
ms.assetid: 18279215-e4ea-4da1-b1b2-d83f426320f9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::SetItemUrl
Sets the URL represented by the link control item.  
  
## Syntax  
  
```  
  
      BOOL SetItemUrl(  
   int iLink,  
   LPCWSTR szUrl   
);  
```  
  
#### Parameters  
 `iLink`  
 The index of a link control item.  
  
 `szUrl`  
 A null-terminated string containing the URL represented by the specified item  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 Sets the URL represented by the specified link control item. For more information, see the Win32 message [LM_SETITEM](http://msdn.microsoft.com/library/windows/desktop/bb760724) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)