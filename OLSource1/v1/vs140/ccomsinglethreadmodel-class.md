---
title: "CComSingleThreadModel Class"
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
  - "ATL.CComSingleThreadModel"
  - "CComSingleThreadModel"
  - "ATL::CComSingleThreadModel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "single-threaded applications"
  - "CComSingleThreadModel class"
  - "single-threaded applications, ATL"
ms.assetid: e5dc30c7-405a-4ba4-8ae9-51937243fce8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSingleThreadModel Class
This class provides methods for incrementing and decrementing the value of a variable.  
  
## Syntax  
  
```  
  
class CComSingleThreadModel  
  
```  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CComSingleThreadModel::AutoCriticalSection](../vs140/ccomsinglethreadmodel--autocriticalsection.md)|References class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).|  
|[CComSingleThreadModel::CriticalSection](../vs140/ccomsinglethreadmodel--criticalsection.md)|References class `CComFakeCriticalSection`.|  
|[CComSingleThreadModel::ThreadModelNoCS](../vs140/ccomsinglethreadmodel--threadmodelnocs.md)|References `CComSingleThreadModel`.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComSingleThreadModel::Decrement](../vs140/ccomsinglethreadmodel--decrement.md)|Decrements the value of the specified variable. This implementation is not thread-safe.|  
|[CComSingleThreadModel::Increment](../vs140/ccomsinglethreadmodel--increment.md)|Increments the value of the specified variable. This implementation is not thread-safe.|  
  
## Remarks  
 `CComSingleThreadModel` provides methods for incrementing and decrementing the value of a variable. Unlike [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md), these methods are not thread-safe.  
  
 Typically, you use `CComSingleThreadModel` through one of two `typedef` names, either [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md) or [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md). The class referenced by each `typedef` depends on the threading model used, as shown in the following table:  
  
|typedef|Single threading model|Apartment threading model|Free threading model|  
|-------------|----------------------------|-------------------------------|--------------------------|  
|`CComObjectThreadModel`|S|S|M|  
|`CComGlobalsThreadModel`|S|M|M|  
  
 S= `CComSingleThreadModel`; M= `CComMultiThreadModel`  
  
 `CComSingleThreadModel` itself defines three `typedef` names. `ThreadModelNoCS` references `CComSingleThreadModel`. `AutoCriticalSection` and `CriticalSection` reference class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md), which provides empty methods associated with obtaining and releasing ownership of a critical section.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  <a name="ccomsinglethreadmodel__autocriticalsection"></a>  CComSingleThreadModel::AutoCriticalSection  
 When using `CComSingleThreadModel`, the `typedef` name `AutoCriticalSection` references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
```  
  
typedef CComFakeCriticalSection AutoCriticalSection;  
  
```  
  
### Remarks  
 Because `CComFakeCriticalSection` does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for `AutoCriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `AutoCriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
|`CComMultiThreadModel`|`CComAutoCriticalSection`|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
  
 In addition to `AutoCriticalSection`, you can use the `typedef` name [CriticalSection](../vs140/ccomsinglethreadmodel--criticalsection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
##  <a name="ccomsinglethreadmodel__criticalsection"></a>  CComSingleThreadModel::CriticalSection  
 When using `CComSingleThreadModel`, the `typedef` name `CriticalSection` references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
```  
  
typedef CComFakeCriticalSection CriticalSection;  
  
```  
  
### Remarks  
 Because `CComFakeCriticalSection` does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for `CriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `CriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
|`CComMultiThreadModel`|`CComCriticalSection`|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
  
 In addition to `CriticalSection`, you can use the `typedef` name [AutoCriticalSection](../vs140/ccomsinglethreadmodel--autocriticalsection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
##  <a name="ccomsinglethreadmodel__decrement"></a>  CComSingleThreadModel::Decrement  
 This static function decrements the value of the variable pointed to by `p`.  
  
```  
  
static ULONG WINAPI Decrement(  
      LPLONG  p  
   ) throw();  
  
```  
  
### Parameters  
 `p`  
 [in] Pointer to the variable to be decremented.  
  
### Return Value  
 The result of the decrement.  
  
##  <a name="ccomsinglethreadmodel__increment"></a>  CComSingleThreadModel::Increment  
 This static function decrements the value of the variable pointed to by `p`.  
  
```  
  
static ULONG WINAPI Increment(  
      LPLONG  p  
   ) throw();  
  
```  
  
### Parameters  
 `p`  
 [in] Pointer to the variable to be incremented.  
  
### Return Value  
 The result of the increment.  
  
##  <a name="ccomsinglethreadmodel__threadmodelnocs"></a>  CComSingleThreadModel::ThreadModelNoCS  
 When using `CComSingleThreadModel`, the `typedef` name `ThreadModelNoCS` simply references `CComSingleThreadModel`.  
  
```  
  
typedef CComSingleThreadModel ThreadModelNoCS;  
  
```  
  
### Remarks  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for `ThreadModelNoCS`. The following table shows the relationship between the threading model class and the class referenced by `ThreadModelNoCS`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComSingleThreadModel`|`CComSingleThreadModel`|  
|`CComMultiThreadModel`|`CComMultiThreadModelNoCS`|  
|`CComMultiThreadModelNoCS`|`CComMultiThreadModelNoCS`|  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)