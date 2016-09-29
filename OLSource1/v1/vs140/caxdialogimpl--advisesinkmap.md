---
title: "CAxDialogImpl::AdviseSinkMap"
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
  - "CAxDialogImpl::AdviseSinkMap"
  - "ATL.CAxDialogImpl.AdviseSinkMap"
  - "CAxDialogImpl.AdviseSinkMap"
  - "AdviseSinkMap"
  - "ATL::CAxDialogImpl::AdviseSinkMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AdviseSinkMap method"
ms.assetid: 661a575c-cf65-493a-8970-58e439b7b149
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxDialogImpl::AdviseSinkMap
Call this method to advise or unadvise all entries in the object's sink map event map.  
  
## Syntax  
  
```  
  
      HRESULT AdviseSinkMap(  
   bool bAdvise   
);  
```  
  
#### Parameters  
 `bAdvise`  
 Set to true if all sink entries are to be advised; false if all sink entries are to be unadvised.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxDialogImpl Class](../vs140/caxdialogimpl-class.md)