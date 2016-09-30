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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComCriticalSection::CComCriticalSection](../vs140/ccomcriticalsection--ccomcriticalsection.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCriticalSection::Init](../vs140/ccomcriticalsection--init.md)|Creates and initializes a critical section object.|  
|[CComCriticalSection::Lock](../vs140/ccomcriticalsection--lock.md)|Obtains ownership of the critical section object.|  
|[CComCriticalSection::Term](../vs140/ccomcriticalsection--term.md)|Releases system resources used by the critical section object.|  
|[CComCriticalSection::Unlock](../vs140/ccomcriticalsection--unlock.md)|Releases ownership of the critical section object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComCriticalSection::m_sec](../vs140/ccomcriticalsection--m_sec.md)|A **CRITICAL_SECTION** object.|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is similar to class [CComAutoCriticalSection](../vs140/ccomautocriticalsection-class.md), except that you must explicitly initialize and release the critical section.  
  
 Typically, you use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> through the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> name [CriticalSection](../vs140/ccommultithreadmodel--criticalsection.md). This name references <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) is being used.  
  
 See [CComCritSecLock Class](../vs140/ccomcritseclock-class.md) for a safer way to use this class than calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directly.  
  
## Requirements  
 **Header:** atlcore.h  
  
##  \<a name="ccomcriticalsection__ccomcriticalsection">\</a>  CComCriticalSection::CComCriticalSection  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Sets the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member to NULL **.**  
  
##  \<a name="ccomcriticalsection__init">\</a>  CComCriticalSection::Init  
 Calls the Win32 function [InitializeCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms683472), which initializes the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on success,                         **E_OUTOFMEMORY** or **E_FAIL** on failure.  
  
##  \<a name="ccomcriticalsection__lock">\</a>  CComCriticalSection::Lock  
 Calls the Win32 function [EnterCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682608), which waits until the thread can take ownership of the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> on success,                         **E_OUTOFMEMORY** or **E_FAIL** on failure.  
  
### Remarks  
 The critical section object must first be initialized with a call to the [Init](../vs140/ccomcriticalsection--init.md) method. When the protected code has finished executing, the thread must call [Unlock](../vs140/ccomcriticalsection--unlock.md) to release ownership of the critical section.  
  
##  \<a name="ccomcriticalsection__m_sec">\</a>  CComCriticalSection::m_sec  
 Contains a critical section object that is used by all <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> methods.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="ccomcriticalsection__term">\</a>  CComCriticalSection::Term  
 Calls the Win32 function [DeleteCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682552), which releases all resources used by the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Remarks  
 Once <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> has been called, the critical section can no longer be used for synchronization.  
  
##  \<a name="ccomcriticalsection__unlock">\</a>  CComCriticalSection::Unlock  
 Calls the Win32 function [LeaveCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms684169), which releases ownership of the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
### Remarks  
 To first obtain ownership, the thread must call the [Lock](../vs140/ccomcriticalsection--lock.md) method. Each call to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> requires a corresponding call to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to release ownership of the critical section.  
  
## See Also  
 [CComFakeCriticalSection Class](../vs140/ccomfakecriticalsection-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComCritSecLock Class](../vs140/ccomcritseclock-class.md)