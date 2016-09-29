---
title: "CComCritSecLock Class"
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
  - "ATL::CComCritSecLock"
  - "ATL.CComCritSecLock<TLock>"
  - "ATL::CComCritSecLock<TLock>"
  - "ATL.CComCritSecLock"
  - "CComCritSecLock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComCritSecLock class"
ms.assetid: 223152a1-86c3-4ef9-89a7-f455fe791b0e
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCritSecLock Class
This class provides methods for locking and unlocking a critical section object.  
  
## Syntax  
  
```  
  
template<  
      class  TLock  
   > class CComCritSecLock  
  
```  
  
#### Parameters  
 *TLock*  
 The object to be locked and unlocked.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComCritSecLock::CComCritSecLock](../vs140/ccomcritseclock--ccomcritseclock.md)|The constructor.|  
|[CComCritSecLock::~CComCritSecLock](../vs140/ccomcritseclock--~ccomcritseclock.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCritSecLock::Lock](../vs140/ccomcritseclock--lock.md)|Call this method to lock the critical section object.|  
|[CComCritSecLock::Unlock](../vs140/ccomcritseclock--unlock.md)|Call this method to unlock the critical section object.|  
  
## Remarks  
 Use this class to lock and unlock objects in a safer way than with the [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md) or [CComAutoCriticalSection Class](../vs140/ccomautocriticalsection-class.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
##  <a name="ccomcritseclock__ccomcritseclock"></a>  CComCritSecLock::CComCritSecLock  
 The constructor.  
  
```  
  
CComCritSecLock(  
      TLock&  cs,  
      bool  bInitialLock  
    = true   
   );  
  
```  
  
### Parameters  
 *cs*  
 The critical section object.  
  
 `bInitialLock`  
 The initial lock state:                                 **true** means locked.  
  
### Remarks  
 Initializes the critical section object.  
  
##  <a name="ccomcritseclock___dtorccomcritseclock"></a>  CComCritSecLock::~CComCritSecLock  
 The destructor.  
  
```  
  
~CComCritSecLock( ) throw( );  
  
```  
  
### Remarks  
 Unlocks the critical section object.  
  
##  <a name="ccomcritseclock__lock"></a>  CComCritSecLock::Lock  
 Call this method to lock the critical section object.  
  
```  
  
HRESULT Lock( ) throw( );  
  
```  
  
### Return Value  
 Returns S_OK if the object has successfully been locked, or an error HRESULT on failure.  
  
### Remarks  
 If the object is already locked, an ASSERT error will occur in debug builds.  
  
##  <a name="ccomcritseclock__unlock"></a>  CComCritSecLock::Unlock  
 Call this method to unlock the critical section object.  
  
```  
  
void Unlock( ) throw( );  
  
```  
  
### Remarks  
 If the object is already unlocked, an ASSERT error will occur in debug builds.  
  
## See Also  
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)   
 [CComAutoCriticalSection Class](../vs140/ccomautocriticalsection-class.md)