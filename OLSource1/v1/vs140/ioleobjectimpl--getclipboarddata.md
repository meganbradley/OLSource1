---
title: "IOleObjectImpl::GetClipboardData"
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
  - "IOleObjectImpl.GetClipboardData"
  - "IOleObjectImpl::GetClipboardData"
  - "GetClipboardData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClipboardData method"
ms.assetid: f6466ff7-c374-4d6d-bc3a-0766f5700430
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::GetClipboardData
Retrieves data from the Clipboard.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetClipboardData)(  
   DWORD /* dwReserved */,  
   IDataObject** /* ppDataObject */  
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IOleObject::GetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms682288) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)