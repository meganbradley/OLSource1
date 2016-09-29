---
title: "CComSafeDeleteCriticalSection Class"
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
  - "CComSafeDeleteCriticalSection"
  - "ATL::CComSafeDeleteCriticalSection"
  - "ATL.CComSafeDeleteCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComSafeDeleteCriticalSection class"
ms.assetid: 4d2932c4-ba8f-48ec-8664-1db8bed01314
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeDeleteCriticalSection Class
This class provides methods for obtaining and releasing ownership of a critical section object.  
  
## Syntax  
  
```  
  
class CComSafeDeleteCriticalSection : public CComCriticalSection  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComSafeDeleteCriticalSection::CComSafeDeleteCriticalSection](../Topic/CComSafeDeleteCriticalSection::CComSafeDeleteCriticalSection.md)|The constructor.|  
|[CComSafeDeleteCriticalSection::~CComSafeDeleteCriticalSection](../Topic/CComSafeDeleteCriticalSection::~CComSafeDeleteCriticalSection.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComSafeDeleteCriticalSection::Init](../Topic/CComSafeDeleteCriticalSection::Init.md)|Creates and initializes a critical section object.|  
|[CComSafeDeleteCriticalSection::Lock](../Topic/CComSafeDeleteCriticalSection::Lock.md)|Obtains ownership of the critical section object.|  
|[CComSafeDeleteCriticalSection::Term](../Topic/CComSafeDeleteCriticalSection::Term.md)|Releases system resources used by the critical section object.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_bInitialized](../Topic/CComSafeDeleteCriticalSection::m_bInitialized.md)|Flags whether the internal **CRITICAL_SECTION** object has been initialized.|  
  
## Remarks  
 `CComSafeDeleteCriticalSection` derives from the class [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md). However, `CComSafeDeleteCriticalSection` provides additional safety mechanisms over [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md).  
  
 When an instance of `CComSafeDeleteCriticalSection` goes out of scope or is explicitly deleted from memory, the underlying critical section object will automatically be cleaned up if it is still valid. In addition, the [CComSafeDeleteCriticalSection::Term](../Topic/CComSafeDeleteCriticalSection::Term.md) method will exit gracefully if the underlying critical section object has not yet been allocated or has already been released from memory.  
  
 See [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md) for more information on critical section helper classes.  
  
## Inheritance Hierarchy  
 [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md)  
  
 `CComSafeDeleteCriticalSection`  
  
## Requirements  
 **Header:** atlcore.h  
  
##  <a name="ccomsafedeletecriticalsection__ccomsafedeletecriticalsection"></a>  CComSafeDeleteCriticalSection::CComSafeDeleteCriticalSection  
 The constructor.  
  
```  
  
CComSafeDeleteCriticalSection();  
  
```  
  
### Remarks  
 Sets the [m_bInitialized](../Topic/CComSafeDeleteCriticalSection::m_bInitialized.md) data member to **false**.  
  
##  <a name="ccomsafedeletecriticalsection___dtorccomsafedeletecriticalsection"></a>  CComSafeDeleteCriticalSection::~CComSafeDeleteCriticalSection  
 The destructor.  
  
```  
  
~CComSafeDeleteCriticalSection() throw();  
  
```  
  
### Remarks  
 Releases the internal **CRITICAL_SECTION** object from memory if the [m_bInitialized](../Topic/CComSafeDeleteCriticalSection::m_bInitialized.md) data member is set to **true**.  
  
##  <a name="ccomsafedeletecriticalsection__init"></a>  CComSafeDeleteCriticalSection::Init  
 Calls the base class implementation of [Init](../Topic/CComCriticalSection::Init.md) and sets [m_bInitialized](../Topic/CComSafeDeleteCriticalSection::m_bInitialized.md) to **true** if successful.  
  
```  
  
HRESULT Init() throw();  
  
```  
  
### Return Value  
 Returns the result of [CComCriticalSection::Init](../Topic/CComCriticalSection::Init.md).  
  
##  <a name="ccomsafedeletecriticalsection__lock"></a>  CComSafeDeleteCriticalSection::Lock  
 Calls the base class implementation of [Lock](../Topic/CComCriticalSection::Lock.md).  
  
```  
  
HRESULT Lock();  
  
```  
  
### Return Value  
 Returns the result of [CComCriticalSection::Lock](../Topic/CComCriticalSection::Lock.md).  
  
### Remarks  
 This method assumes the [m_bInitialized](../Topic/CComSafeDeleteCriticalSection::m_bInitialized.md) data member is set to **true** upon entry. An assertion is generated in Debug builds if this condidtion is not met.  
  
 For more information on the behavior of the function, refer to [CComCriticalSection::Lock](../Topic/CComCriticalSection::Lock.md).  
  
##  <a name="ccomsafedeletecriticalsection__m_binitialized"></a>  CComSafeDeleteCriticalSection::m_bInitialized  
 Flags whether the internal **CRITICAL_SECTION** object has been initialized.  
  
```  
  
bool m_bInitialized;  
  
```  
  
### Remarks  
 The **m_bInitialized** data member is used to track validity of the underlying **CRITICAL_SECTION** object associated with the [CComSafeDeleteCriticalSection](../VS_csharp/ccomsafedeletecriticalsection-class.md) class. The underlying **CRITICAL_SECTION** object will not be attempted to be released from memory if this flag is not set to **true**.  
  
##  <a name="ccomsafedeletecriticalsection__term"></a>  CComSafeDeleteCriticalSection::Term  
 Calls the base class implementation of [CComCriticalSection::Term](../Topic/CComCriticalSection::Term.md) if the internal **CRITICAL_SECTION** object is valid.  
  
```  
  
HRESULT Term() throw();  
  
```  
  
### Return Value  
 Returns the result of [CComCriticalSection::Term](../Topic/CComCriticalSection::Term.md), or **S_OK** if [m_bInitialized](../Topic/CComSafeDeleteCriticalSection::m_bInitialized.md) was set to **false** upon entry.  
  
### Remarks  
 It is safe to call this method even if the internal **CRITICAL_SECTION** object is not valid. The destructor of this class calls this method if the [m_bInitialized](../Topic/CComSafeDeleteCriticalSection::m_bInitialized.md) data member is set to **true**.  
  
## See Also  
 [CComCriticalSection Class](../VS_csharp/ccomcriticalsection-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)