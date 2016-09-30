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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComApartment::CComApartment](../vs140/ccomapartment--ccomapartment.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComApartment::Apartment](../vs140/ccomapartment--apartment.md)|Marks the thread's starting address.|  
|[CComApartment::GetLockCount](../vs140/ccomapartment--getlockcount.md)|Returns the thread's current lock count.|  
|[CComApartment::Lock](../vs140/ccomapartment--lock.md)|Increments the thread's lock count.|  
|[CComApartment::Unlock](../vs140/ccomapartment--unlock.md)|Decrements the thread's lock count.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComApartment::m_dwThreadID](../vs140/ccomapartment--m_dwthreadid.md)|Contains the thread's identifier.|  
|[CComApartment::m_hThread](../vs140/ccomapartment--m_hthread.md)|Contains the thread's handle.|  
|[CComApartment::m_nLockCnt](../vs140/ccomapartment--m_nlockcnt.md)|Contains the thread's current lock count.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used by [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md) to manage an apartment in a thread-pooled EXE module. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> provides methods for incrementing and decrementing the lock count on a thread.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccomapartment__apartment">\</a>  CComApartment::Apartment  
 Marks the thread's starting address.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Always 0.  
  
### Remarks  
 Automatically set during [CComAutoThreadModule::Init](../vs140/ccomautothreadmodule--init.md).  
  
##  \<a name="ccomapartment__ccomapartment">\</a>  CComApartment::CComApartment  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> data members [m_nLockCnt](../vs140/ccomapartment--m_nlockcnt.md) and [m_hThread](../vs140/ccomapartment--m_hthread.md).  
  
##  \<a name="ccomapartment__getlockcount">\</a>  CComApartment::GetLockCount  
 Returns the thread's current lock count.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The lock count on the thread.  
  
##  \<a name="ccomapartment__lock">\</a>  CComApartment::Lock  
 Increments the thread's lock count.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
### Remarks  
 Called by [CComAutoThreadModule::Lock](../vs140/ccomautothreadmodule--lock.md).  
  
 The lock count on the thread is used for statistical purposes.  
  
##  \<a name="ccomapartment__m_dwthreadid">\</a>  CComApartment::m_dwThreadID  
 Contains the thread's identifier.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="ccomapartment__m_hthread">\</a>  CComApartment::m_hThread  
 Contains the thread's handle.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="ccomapartment__m_nlockcnt">\</a>  CComApartment::m_nLockCnt  
 Contains the thread's current lock count.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="ccomapartment__unlock">\</a>  CComApartment::Unlock  
 Decrements the thread's lock count.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
### Remarks  
 Called by [CComAutoThreadModule::Unlock](../vs140/ccomautothreadmodule--lock.md).  
  
 The lock count on the thread is used for statistical purposes.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)