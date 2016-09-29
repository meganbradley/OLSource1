---
title: "CComClassFactoryAutoThread::LockServer"
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
  - "ATL.CComClassFactoryAutoThread.LockServer"
  - "LockServer"
  - "CComClassFactoryAutoThread::LockServer"
  - "ATL::CComClassFactoryAutoThread::LockServer"
  - "CComClassFactoryAutoThread.LockServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockServer method"
ms.assetid: 7115192a-6e3a-4172-bfc5-7e101c8359de
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactoryAutoThread::LockServer
Increments and decrements the module lock count by calling **_Module::Lock** and **_Module::Unlock**, respectively.  
  
## Syntax  
  
```  
  
      STDMETHODIMP LockServer(  
   BOOL fLock   
);  
```  
  
#### Parameters  
 `fLock`  
 [in] If **TRUE**, the lock count is incremented; otherwise, the lock count is decremented.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 When using `CComClassFactoryAutoThread`, **_Module** typically refers to the global instance of [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md).  
  
 Calling `LockServer` allows a client to hold onto a class factory so that multiple objects can be quickly created.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComClassFactoryAutoThread Class](../vs140/ccomclassfactoryautothread-class.md)   
 [CComAutoThreadModule::Lock](../vs140/ccomautothreadmodule--lock.md)   
 [CComAutoThreadModule::Unlock](../vs140/ccomautothreadmodule--unlock.md)