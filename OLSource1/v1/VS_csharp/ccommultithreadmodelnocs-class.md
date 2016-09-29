---
title: "CComMultiThreadModelNoCS Class"
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
  - "ATL::CComMultiThreadModelNoCS"
  - "CComMultiThreadModelNoCS"
  - "ATL.CComMultiThreadModelNoCS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, multithreading"
  - "CComMultiThreadModelNoCS class"
  - "threading [ATL]"
ms.assetid: 2b3f7a45-fd72-452c-aaf3-ccdaa621c821
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModelNoCS Class
`CComMultiThreadModelNoCS` provides thread-safe methods for incrementing and decrementing the value of a variable, without critical section locking or unlocking functionality.  
  
## Syntax  
  
```  
  
class CComMultiThreadModelNoCS  
  
```  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModelNoCS::AutoCriticalSection](../Topic/CComMultiThreadModelNoCS::AutoCriticalSection.md)|References class [CComFakeCriticalSection](../VS_csharp/ccomfakecriticalsection-class.md).|  
|[CComMultiThreadModelNoCS::CriticalSection](../Topic/CComMultiThreadModelNoCS::CriticalSection.md)|References class `CComFakeCriticalSection`.|  
|[CComMultiThreadModelNoCS::ThreadModelNoCS](../Topic/CComMultiThreadModelNoCS::ThreadModelNoCS.md)|References class `CComMultiThreadModelNoCS`.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModelNoCS::Decrement](../Topic/CComMultiThreadModelNoCS::Decrement.md)|(Static) Decrements the value of the specified variable in a thread-safe manner.|  
|[CComMultiThreadModelNoCS::Increment](../Topic/CComMultiThreadModelNoCS::Increment.md)|(Static) Increments the value of the specified variable in a thread-safe manner.|  
  
## Remarks  
 `CComMultiThreadModelNoCS` is similar to [CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md) in that it provides thread-safe methods for incrementing and decrementing a variable. However, when you reference a critical section class through `CComMultiThreadModelNoCS`, methods such as `Lock` and `Unlock` will do nothing.  
  
 Typically, you use `CComMultiThreadModelNoCS` through the `ThreadModelNoCS``typedef` name. This `typedef` is defined in `CComMultiThreadModelNoCS`, `CComMultiThreadModel`, and [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md).  
  
> [!NOTE]
>  The global `typedef` names [CComObjectThreadModel](../VS_csharp/ccomobjectthreadmodel.md) and [CComGlobalsThreadModel](../VS_csharp/ccomglobalsthreadmodel.md) do not reference `CComMultiThreadModelNoCS`.  
  
 In addition to `ThreadModelNoCS`, `CComMultiThreadModelNoCS` defines `AutoCriticalSection` and `CriticalSection`. These latter two `typedef` names reference [CComFakeCriticalSection](../VS_csharp/ccomfakecriticalsection-class.md), which provides empty methods associated with obtaining and releasing a critical section.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  <a name="ccommultithreadmodelnocs__autocriticalsection"></a>  CComMultiThreadModelNoCS::AutoCriticalSection  
 When using `CComMultiThreadModelNoCS`, the `typedef` name `AutoCriticalSection` references class [CComFakeCriticalSection](../VS_csharp/ccomfakecriticalsection-class.md).  
  
```  
  
typedef CComFakeCriticalSection AutoCriticalSection;  
  
```  
  
### Remarks  
 Because `CComFakeCriticalSection` does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md) also contain definitions for `AutoCriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `AutoCriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
|`CComMultiThreadModel`|`CComAutoCriticalSection`|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
  
 In addition to `AutoCriticalSection`, you can use the `typedef` name [CriticalSection](../Topic/CComMultiThreadModelNoCS::CriticalSection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md).  
  
##  <a name="ccommultithreadmodelnocs__criticalsection"></a>  CComMultiThreadModelNoCS::CriticalSection  
 When using `CComMultiThreadModelNoCS`, the `typedef` name `CriticalSection` references class [CComFakeCriticalSection](../VS_csharp/ccomfakecriticalsection-class.md).  
  
```  
  
typedef CComFakeCriticalSection CriticalSection;  
  
```  
  
### Remarks  
 Because `CComFakeCriticalSection` does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md) also contain definitions for `CriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `CriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
|`CComMultiThreadModel`|`CComCriticalSection`|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
  
 In addition to `CriticalSection`, you can use the `typedef` name `AutoCriticalSection`. You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md).  
  
##  <a name="ccommultithreadmodelnocs__decrement"></a>  CComMultiThreadModelNoCS::Decrement  
 This static function calls the Win32 function [InterlockedDecrement](http://msdn.microsoft.com/library/windows/desktop/ms683580), which decrements the value of the variable pointed to by `p`.  
  
```  
  
static ULONG WINAPI Decrement(  
      LPLONG  p  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 [in] Pointer to the variable to be decremented.  
  
### Return Value  
 If the result of the decrement is 0, then `Decrement` returns 0. If the result of the decrement is nonzero, the return value is also nonzero but may not equal the result of the decrement.  
  
### Remarks  
 **InterlockedDecrement** prevents more than one thread from simultaneously using this variable.  
  
##  <a name="ccommultithreadmodelnocs__increment"></a>  CComMultiThreadModelNoCS::Increment  
 This static function calls the Win32 function [InterlockedIncrement](http://msdn.microsoft.com/library/windows/desktop/ms683614), which increments the value of the variable pointed to by `p`.  
  
```  
  
static ULONG WINAPI Increment(  
      LPLONG  p  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 [in] Pointer to the variable to be incremented.  
  
### Return Value  
 If the result of the increment is 0, then **Increment** returns 0. If the result of the increment is nonzero, the return value is also nonzero but may not equal the result of the increment.  
  
### Remarks  
 **InterlockedIncrement** prevents more than one thread from simultaneously using this variable.  
  
##  <a name="ccommultithreadmodelnocs__threadmodelnocs"></a>  CComMultiThreadModelNoCS::ThreadModelNoCS  
 When using `CComMultiThreadModelNoCS`, the `typedef` name `ThreadModelNoCS` simply references `CComMultiThreadModelNoCS`.  
  
```  
  
typedef CComMultiThreadModelNoCS ThreadModelNoCS;  
  
```  
  
### Remarks  
 [CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md) also contain definitions for `ThreadModelNoCS`. The following table shows the relationship between the threading model class and the class referenced by `ThreadModelNoCS`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModelNoCS`|`CComMultiThreadModelNoCS`|  
|`CComMultiThreadModel`|`CComMultiThreadModelNoCS`|  
|`CComSingleThreadModel`|`CComSingleThreadModel`|  
  
 Note that the definition of `ThreadModelNoCS` in `CComMultiThreadModelNoCS` provides symmetry with `CComMultiThreadModel` and `CComSingleThreadModel`. For example, suppose the sample code in `CComMultiThreadModel::AutoCriticalSection` declared the following `typedef`:  
  
 [!code[NVC_ATL_COM#37](../VS_csharp/codesnippet/CPP/ccommultithreadmodelnocs-class_1.h)]  
  
 Regardless of the class specified for `ThreadModel` (such as `CComMultiThreadModelNoCS`), `_ThreadModel` resolves accordingly.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md).  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)