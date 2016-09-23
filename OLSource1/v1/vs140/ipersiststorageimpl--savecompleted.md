---
title: "IPersistStorageImpl::SaveCompleted"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SaveCompleted
  - IPersistStorageImpl.SaveCompleted
  - IPersistStorageImpl::SaveCompleted
dev_langs: 
  - C++
helpviewer_keywords: 
  - SaveCompleted method
ms.assetid: c264a4f4-16e6-4f6f-90e7-0479d0cc4b98
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IPersistStorageImpl::SaveCompleted
Notifies an object that it can return to Normal mode to write to its storage object.  
  
## Syntax  
  
```  
  
      STDMETHOD(SaveCompleted)(  
   IStorage*  
);  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 See [IPersistStorage:SaveCompleted](http://msdn.microsoft.com/library/windows/desktop/ms679713) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IPersistStorageImpl Class](../vs140/ipersiststorageimpl-class.md)   
 [IPersistStorageImpl::HandsOffStorage](../vs140/ipersiststorageimpl--handsoffstorage.md)   
 [IPersistStorageImpl::Save](../vs140/ipersiststorageimpl--save.md)   
 [IStorage](http://msdn.microsoft.com/library/windows/desktop/aa380015)