---
title: "CLinkCtrl::GetItemUrl"
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
  - "CLinkCtrl::GetItemUrl"
  - "GetItemUrl"
  - "CLinkCtrl.GetItemUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemURL method"
ms.assetid: a1dc236e-afc3-4dd3-a47e-42ad4a680318
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::GetItemUrl
Retrieves the URL represented by the link control item.  
  
## Syntax  
  
```  
  
      BOOL GetItemUrl(  
   int iLink,  
   CString& strUrl   
) const;  
BOOL GetItemUrl(  
   int iLink,  
   LPWSTR szUrl,  
   UINT cchUrl   
) const;  
```  
  
#### Parameters  
 `iLink`  
 The index of a link control item.  
  
 `strUrl`  
 A [CStringT](../vs140/cstringt-class.md) object containing the URL represented by the specified item  
  
 `szUrl`  
 A null-terminated string containing the URL represented by the specified item  
  
 *cchUrl*  
 The size in characters of the *szURL* buffer.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
> [!NOTE]
>  This function also returns **FALSE** if the buffer of *szUrl or strUrl* is smaller than **MAX_LINKID_TEXT**.  
  
## Remarks  
 Retrieves the URL represented by the specified link control item. For more information, see the Win32 message [LM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb760720) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CLinkCtrl::SetItemUrl](../vs140/clinkctrl--setitemurl.md)   
 [CLinkCtrl::GetItem](../vs140/clinkctrl--getitem.md)