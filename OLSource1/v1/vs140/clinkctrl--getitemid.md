---
title: "CLinkCtrl::GetItemID"
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
  - "CLinkCtrl::GetItemID"
  - "GetItemID"
  - "CLinkCtrl.GetItemID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemID method"
ms.assetid: df597f09-62ef-4189-bbe0-2ada8c486bd3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::GetItemID
Retrieves the ID of a link control item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of a link control item.  
  
 *strID*  
 A [CStringT](../vs140/cstringt-class.md) object containing the ID of the specified item.  
  
 *szID*  
 A null-terminated string containing the ID of the specified item.  
  
 *cchID*  
 The size in characters of the *szID* buffer.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
> [!NOTE]
>  This function also returns **FALSE** if the buffer of *szID or strID* is smaller than **MAX_LINKID_TEXT**.  
  
## Remarks  
 Retrieves the ID of a specific link control item. For more information, see the Win32 message [LM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb760720) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CLinkCtrl::SetItemID](../vs140/clinkctrl--setitemid.md)   
 [CLinkCtrl::GetItem](../vs140/clinkctrl--getitem.md)