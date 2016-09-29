---
title: "CComApartment Class"
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
  - "ATL::CComApartment"
  - "CComApartment"
  - "ATL.CComApartment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "apartments in ATL EXE modules"
  - "CComApartment class"
ms.assetid: dbc177d7-7ee4-45f2-b563-d578a467ca93
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComApartment Class
This class provides support for managing an appartment in a thread-pooled EXE module.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CComApartment  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComApartment::CComApartment](../Topic/CComApartment::CComApartment.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComApartment::Apartment](../Topic/CComApartment::Apartment.md)|Marks the thread's starting address.|  
|[CComApartment::GetLockCount](../Topic/CComApartment::GetLockCount.md)|Returns the thread's current lock count.|  
|[CComApartment::Lock](../Topic/CComApartment::Lock.md)|Increments the thread's lock count.|  
|[CComApartment::Unlock](../Topic/CComApartment::Unlock.md)|Decrements the thread's lock count.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComApartment::m_dwThreadID](../Topic/CComApartment::m_dwThreadID.md)|Contains the thread's identifier.|  
|[CComApartment::m_hThread](../Topic/CComApartment::m_hThread.md)|Contains the thread's handle.|  
|[CComApartment::m_nLockCnt](../Topic/CComApartment::m_nLockCnt.md)|Contains the thread's current lock count.|  
  
## Remarks  
 `CComApartment` is used by [CComAutoThreadModule](../VS_csharp/ccomautothreadmodule-class.md) to manage an apartment in a thread-pooled EXE module. `CComApartment` provides methods for incrementing and decrementing the lock count on a thread.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  <a name="ccomapartment__apartment"></a>  CComApartment::Apartment  
 Marks the thread's starting address.  
  
```  
  
DWORD Apartment( );  
  
```  
  
### Return Value  
 Always 0.  
  
### Remarks  
 Automatically set during [CComAutoThreadModule::Init](../Topic/CComAutoThreadModule::Init.md).  
  
##  <a name="ccomapartment__ccomapartment"></a>  CComApartment::CComApartment  
 The constructor.  
  
```  
  
CComApartment( );  
  
```  
  
### Remarks  
 Initializes the `CComApartment` data members [m_nLockCnt](../Topic/CComApartment::m_nLockCnt.md) and [m_hThread](../Topic/CComApartment::m_hThread.md).  
  
##  <a name="ccomapartment__getlockcount"></a>  CComApartment::GetLockCount  
 Returns the thread's current lock count.  
  
```  
  
LONG GetLockCount( );  
  
```  
  
### Return Value  
 The lock count on the thread.  
  
##  <a name="ccomapartment__lock"></a>  CComApartment::Lock  
 Increments the thread's lock count.  
  
```  
  
LONG Lock( );  
  
```  
  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
### Remarks  
 Called by [CComAutoThreadModule::Lock](../Topic/CComAutoThreadModule::Lock.md).  
  
 The lock count on the thread is used for statistical purposes.  
  
##  <a name="ccomapartment__m_dwthreadid"></a>  CComApartment::m_dwThreadID  
 Contains the thread's identifier.  
  
```  
  
DWORD m_dwThreadID;  
  
```  
  
##  <a name="ccomapartment__m_hthread"></a>  CComApartment::m_hThread  
 Contains the thread's handle.  
  
```  
  
HANDLE m_hThread;  
  
```  
  
##  <a name="ccomapartment__m_nlockcnt"></a>  CComApartment::m_nLockCnt  
 Contains the thread's current lock count.  
  
```  
  
LONG m_nLockCnt;  
  
```  
  
##  <a name="ccomapartment__unlock"></a>  CComApartment::Unlock  
 Decrements the thread's lock count.  
  
```  
  
LONG Unlock( );  
  
```  
  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
### Remarks  
 Called by [CComAutoThreadModule::Unlock](../Topic/CComAutoThreadModule::Lock.md).  
  
 The lock count on the thread is used for statistical purposes.  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)