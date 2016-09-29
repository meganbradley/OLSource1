---
title: "CComCriticalSection Class"
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
  - "ATL.CComCriticalSection"
  - "CComCriticalSection"
  - "ATL::CComCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComCriticalSection class"
ms.assetid: 44e1edd2-90be-4bfe-9739-58e8b419e7d1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCriticalSection Class
This class provides methods for obtaining and releasing ownership of a critical section object.  
  
## Syntax  
  
```  
  
class CComCriticalSection  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComCriticalSection::CComCriticalSection](../Topic/CComCriticalSection::CComCriticalSection.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCriticalSection::Init](../Topic/CComCriticalSection::Init.md)|Creates and initializes a critical section object.|  
|[CComCriticalSection::Lock](../Topic/CComCriticalSection::Lock.md)|Obtains ownership of the critical section object.|  
|[CComCriticalSection::Term](../Topic/CComCriticalSection::Term.md)|Releases system resources used by the critical section object.|  
|[CComCriticalSection::Unlock](../Topic/CComCriticalSection::Unlock.md)|Releases ownership of the critical section object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComCriticalSection::m_sec](../Topic/CComCriticalSection::m_sec.md)|A **CRITICAL_SECTION** object.|  
  
## Remarks  
 `CComCriticalSection` is similar to class [CComAutoCriticalSection](../VS_csharp/ccomautocriticalsection-class.md), except that you must explicitly initialize and release the critical section.  
  
 Typically, you use `CComCriticalSection` through the `typedef` name [CriticalSection](../Topic/CComMultiThreadModel::CriticalSection.md). This name references `CComCriticalSection` when [CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md) is being used.  
  
 See [CComCritSecLock Class](../VS_csharp/ccomcritseclock-class.md) for a safer way to use this class than calling `Lock` and `Unlock` directly.  
  
## Requirements  
 **Header:** atlcore.h  
  
##  <a name="ccomcriticalsection__ccomcriticalsection"></a>  CComCriticalSection::CComCriticalSection  
 The constructor.  
  
```  
  
CComCriticalSection( ) throw( );  
```  
  
### Remarks  
 Sets the [m_sec](../Topic/CComCriticalSection::m_sec.md) data member to NULL **.**  
  
##  <a name="ccomcriticalsection__init"></a>  CComCriticalSection::Init  
 Calls the Win32 function [InitializeCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms683472), which initializes the critical section object contained in the [m_sec](../Topic/CComCriticalSection::m_sec.md) data member.  
  
```  
  
HRESULT Init( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK` on success,                         **E_OUTOFMEMORY** or **E_FAIL** on failure.  
  
##  <a name="ccomcriticalsection__lock"></a>  CComCriticalSection::Lock  
 Calls the Win32 function [EnterCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682608), which waits until the thread can take ownership of the critical section object contained in the [m_sec](../Topic/CComCriticalSection::m_sec.md) data member.  
  
```  
  
HRESULT Lock( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK` on success,                         **E_OUTOFMEMORY** or **E_FAIL** on failure.  
  
### Remarks  
 The critical section object must first be initialized with a call to the [Init](../Topic/CComCriticalSection::Init.md) method. When the protected code has finished executing, the thread must call [Unlock](../Topic/CComCriticalSection::Unlock.md) to release ownership of the critical section.  
  
##  <a name="ccomcriticalsection__m_sec"></a>  CComCriticalSection::m_sec  
 Contains a critical section object that is used by all `CComCriticalSection` methods.  
  
```  
  
CRITICAL_SECTION m_sec;  
  
```  
  
##  <a name="ccomcriticalsection__term"></a>  CComCriticalSection::Term  
 Calls the Win32 function [DeleteCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682552), which releases all resources used by the critical section object contained in the [m_sec](../Topic/CComCriticalSection::m_sec.md) data member.  
  
```  
  
HRESULT Term( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK`.  
  
### Remarks  
 Once `Term` has been called, the critical section can no longer be used for synchronization.  
  
##  <a name="ccomcriticalsection__unlock"></a>  CComCriticalSection::Unlock  
 Calls the Win32 function [LeaveCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms684169), which releases ownership of the critical section object contained in the [m_sec](../Topic/CComCriticalSection::m_sec.md) data member.  
  
```  
  
HRESULT Unlock( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK`.  
  
### Remarks  
 To first obtain ownership, the thread must call the [Lock](../Topic/CComCriticalSection::Lock.md) method. Each call to `Lock` requires a corresponding call to `Unlock` to release ownership of the critical section.  
  
## See Also  
 [CComFakeCriticalSection Class](../VS_csharp/ccomfakecriticalsection-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [CComCritSecLock Class](../VS_csharp/ccomcritseclock-class.md)