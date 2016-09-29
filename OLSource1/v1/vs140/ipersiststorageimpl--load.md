---
title: "IPersistStorageImpl::Load"
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
  - "IPersistStorageImpl.Load"
  - "IPersistStorageImpl<T>::Load"
  - "ATL::IPersistStorageImpl::Load"
  - "ATL.IPersistStorageImpl.Load"
  - "IPersistStorageImpl::Load"
  - "IPersistStorageImpl<T>.Load"
  - "ATL::IPersistStorageImpl<T>::Load"
  - "ATL.IPersistStorageImpl<T>.Load"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Load method"
ms.assetid: 34359086-b03e-4607-a3b6-3167e2b41845
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPersistStorageImpl::Load
Loads the object's properties from the specified storage.  
  
## Syntax  
  
```  
  
      STDMETHOD(Load)(  
   IStorage* pStorage   
);  
```  
  
## Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface. **Load** uses a stream named "Contents" to retrieve the object's data. The [Save](../vs140/ipersiststorageimpl--save.md) method originally creates this stream.  
  
 See [IPersistStorage:Load](http://msdn.microsoft.com/library/windows/desktop/ms680557) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IPersistStorageImpl Class](../vs140/ipersiststorageimpl-class.md)   
 [IStorage](http://msdn.microsoft.com/library/windows/desktop/aa380015)