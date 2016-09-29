---
title: "IDispEventImpl::GetIDsOfNames"
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
  - "ATL.IDispEventImpl.GetIDsOfNames"
  - "GetIDsOfNames"
  - "IDispEventImpl.GetIDsOfNames"
  - "ATL::IDispEventImpl::GetIDsOfNames"
  - "IDispEventImpl::GetIDsOfNames"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIDsOfNames method"
ms.assetid: ea8e4a9d-ecd5-417f-a882-3b32fa2a5d4f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventImpl::GetIDsOfNames
Maps a single member and an optional set of argument names to a corresponding set of integer DISPIDs, which can be used on subsequent calls to [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d).  
  
## Syntax  
  
```  
  
      STDMETHOD(GetIDsOfNames)(  
   REFIID riid,  
   LPOLESTR* rgszNames,  
   UINT cNames,  
   LCID lcid,  
   DISPID* rgdispid   
);  
```  
  
## Remarks  
 See [IDispatch::GetIDsOfNames](assetId:///6f6cf233-3481-436e-8d6a-51f93bf91619) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IDispEventImpl Class](../vs140/idispeventimpl-class.md)   
 [IDispEventImpl::GetFuncInfoFromId](../vs140/idispeventimpl--getfuncinfofromid.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)