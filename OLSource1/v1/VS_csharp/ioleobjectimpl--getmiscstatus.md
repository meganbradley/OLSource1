---
title: "IOleObjectImpl::GetMiscStatus"
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
  - "GetMiscStatus"
  - "ATL.IOleObjectImpl.GetMiscStatus"
  - "ATL::IOleObjectImpl<T>::GetMiscStatus"
  - "IOleObjectImpl::GetMiscStatus"
  - "IOleObjectImpl<T>::GetMiscStatus"
  - "IOleObjectImpl.GetMiscStatus"
  - "ATL.IOleObjectImpl<T>.GetMiscStatus"
  - "ATL::IOleObjectImpl::GetMiscStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMiscStatus method"
ms.assetid: 4cdaf66b-265c-484e-847b-617560f0fd7a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::GetMiscStatus
Returns a pointer to registered status information for the control by calling **OleRegGetMiscStatus**.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetMiscStatus)(  
   DWORD dwAspect,  
   DWORD* pdwStatus   
);  
```  
  
## Remarks  
 The status information includes behaviors supported by the control and presentation data. You can add status information to your project's .rgs file.  
  
 See [IOleObject::GetMiscStatus](http://msdn.microsoft.com/library/windows/desktop/ms678521) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [OleRegGetMiscStatus](http://msdn.microsoft.com/library/windows/desktop/ms680124)   
 [IOleObjectImpl::EnumVerbs](../VS_csharp/ioleobjectimpl--enumverbs.md)   
 [IOleObjectImpl::GetUserType](../VS_csharp/ioleobjectimpl--getusertype.md)