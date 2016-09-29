---
title: "CLinkCtrl::SetItemID"
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
  - "CLinkCtrl.SetItemID"
  - "CLinkCtrl::SetItemID"
  - "SetItemID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemID method"
ms.assetid: e1747f43-985d-4636-a019-c59364c51c3f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::SetItemID
Retrieves the ID of a link control item.  
  
## Syntax  
  
```  
  
      BOOL SetItemID(  
   int iLink,  
   LPCWSTR szID   
);  
```  
  
#### Parameters  
 `iLink`  
 The index of a link control item.  
  
 *szID*  
 A null-terminated string containing the ID of the specified item.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 Sets the ID of a specific link control item. For more information, see the Win32 message [LM_SETITEM](http://msdn.microsoft.com/library/windows/desktop/bb760724) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CLinkCtrl::GetItemID](../vs140/clinkctrl--getitemid.md)   
 [CLinkCtrl::GetItem](../vs140/clinkctrl--getitem.md)