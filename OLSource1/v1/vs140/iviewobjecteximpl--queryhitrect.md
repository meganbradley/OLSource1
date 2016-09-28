---
title: "IViewObjectExImpl::QueryHitRect"
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
  - "IViewObjectExImpl.QueryHitRect"
  - "IViewObjectExImpl::QueryHitRect"
  - "QueryHitRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryHitRect method"
ms.assetid: 1adb8305-3428-4818-a035-fbcc83222d25
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl::QueryHitRect
Checks whether the control's display rectangle overlaps any point in the specified location rectangle and returns a [HITRESULT](http://msdn.microsoft.com/library/windows/desktop/ms682187) value in `pHitResult`.  
  
## Syntax  
  
```  
  
      STDMETHOD(QueryHitRect)(  
   DWORD dwAspect,  
   LPCRECT pRectBounds,  
   LPRECT prcLoc,  
   LONG /* lCloseHit */,  
   DWORD* /* pHitResult */  
);  
```  
  
## Remarks  
 The value can be either **HITRESULT_HIT** or **HITRESULT_OUTSIDE**.  
  
 If `dwAspect` equals [DVASPECT_CONTENT](http://msdn.microsoft.com/library/windows/desktop/ms690318), the method returns `S_OK`. Otherwise, the method returns **E_FAIL**.  
  
 See [IViewObjectEx::QueryHitRect](http://msdn.microsoft.com/library/windows/desktop/ms693797) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../vs140/iviewobjecteximpl-class.md)   
 [IViewObjectExImpl::QueryHitPoint](../vs140/iviewobjecteximpl--queryhitpoint.md)