---
title: "IOleObjectImpl::InitFromData"
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
  - "IOleObjectImpl<T>::InitFromData"
  - "ATL.IOleObjectImpl<T>.InitFromData"
  - "IOleObjectImpl.InitFromData"
  - "IOleObjectImpl::InitFromData"
  - "ATL::IOleObjectImpl::InitFromData"
  - "InitFromData"
  - "ATL.IOleObjectImpl.InitFromData"
  - "ATL::IOleObjectImpl<T>::InitFromData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitFromData method"
ms.assetid: 216dcb78-9d50-4863-86b2-545ab97b4d5e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::InitFromData
Initializes the control from selected data.  
  
## Syntax  
  
```  
  
      STDMETHOD(InitFromData)(  
   IDataObject* /* pDataObject */,  
   BOOL /* fCreation */,  
   DWORD /* dwReserved */  
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IOleObject::InitFromData](http://msdn.microsoft.com/library/windows/desktop/ms688510) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)