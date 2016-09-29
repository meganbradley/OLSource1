---
title: "IDispatchImpl::GetIDsOfNames"
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
  - "GetIDsOfNames"
  - "IDispatchImpl.GetIDsOfNames"
  - "ATL::IDispatchImpl::GetIDsOfNames"
  - "IDispatchImpl::GetIDsOfNames"
  - "ATL.IDispatchImpl.GetIDsOfNames"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIDsOfNames method"
ms.assetid: 91db563a-23ac-4588-b7f4-4c15f6a885c0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispatchImpl::GetIDsOfNames
Maps a set of names to a corresponding set of dispatch identifiers.  
  
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
 [IDispatchImpl Class](../vs140/idispatchimpl-class.md)