---
title: "CComMultiThreadModel Class"
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
  - "CComMultiThreadModel"
  - "ATL.CComMultiThreadModel"
  - "ATL::CComMultiThreadModel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, multithreading"
  - "CComMultiThreadModel class"
  - "threading [ATL]"
ms.assetid: db8f1662-2f7a-44b3-b341-ffbfb6e422a3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModel Class
`CComMultiThreadModel` provides thread-safe methods for incrementing and decrementing the value of a variable.  
  
## Syntax  
  
```  
  
class CComMultiThreadModel  
  
```  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModel::AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md)|References class [CComAutoCriticalSection](../VS_csharp/ccomautocriticalsection-class.md).|  
|[CComMultiThreadModel::CriticalSection](../Topic/CComMultiThreadModel::CriticalSection.md)|References class [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md).|  
|[CComMultiThreadModel::ThreadModelNoCS](../Topic/CComMultiThreadModel::ThreadModelNoCS.md)|References class [CComMultiThreadModelNoCS](../VS_csharp/ccommultithreadmodelnocs-class.md).|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModel::Decrement](../Topic/CComMultiThreadModel::Decrement.md)|(Static) Decrements the value of the specified variable in a thread-safe manner.|  
|[CComMultiThreadModel::Increment](../Topic/CComMultiThreadModel::Increment.md)|(Static) Increments the value of the specified variable in a thread-safe manner.|  
  
## Remarks  
 Typically, you use `CComMultiThreadModel` through one of two `typedef` names, either [CComObjectThreadModel](../VS_csharp/ccomobjectthreadmodel.md) or [CComGlobalsThreadModel](../VS_csharp/ccomglobalsthreadmodel.md). The class referenced by each `typedef` depends on the threading model used, as shown in the following table:  
  
|typedef|Single threading|Apartment threading|Free threading|  
|-------------|----------------------|-------------------------|--------------------|  
|`CComObjectThreadModel`|S|S|M|  
|`CComGlobalsThreadModel`|S|M|M|  
  
 S= `CComSingleThreadModel`; M= `CComMultiThreadModel`  
  
 `CComMultiThreadModel` itself defines three `typedef` names. `AutoCriticalSection` and `CriticalSection` reference classes that provide methods for obtaining and releasing ownership of a critical section. `ThreadModelNoCS` references class [CComMultiThreadModelNoCS](../VS_csharp/ccommultithreadmodelnocs-class.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
##  <a name="ccommultithreadmodel__autocriticalsection"></a>  CComMultiThreadModel::AutoCriticalSection  
 When using `CComMultiThreadModel`, the `typedef` name `AutoCriticalSection` references class [CComAutoCriticalSection](../VS_csharp/ccomautocriticalsection-class.md), which provides methods for obtaining and releasing ownership of a critical section object.  
  
```  
  
typedef CComAutoCriticalSection AutoCriticalSection;  
  
```  
  
### Remarks  
 [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md) and [CComMultiThreadModelNoCS](../VS_csharp/ccommultithreadmodelnocs-class.md) also contain definitions for `AutoCriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `AutoCriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModel`|`CComCriticalSection`|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
  
 In addition to `AutoCriticalSection`, you can use the `typedef` name [CriticalSection](../Topic/CComMultiThreadModel::CriticalSection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 The following code is modeled after [CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md), and demonstrates `AutoCriticalSection` being used in a threading environment.  
  
 [!code[NVC_ATL_COM#36](../VS_csharp/codesnippet/CPP/ccommultithreadmodel-class_1.h)]  
  
 The following tables show the results of the `InternalAddRef` and `Lock` methods, depending on the **ThreadModel** template parameter and the threading model used by the application:  
  
### ThreadModel = CComObjectThreadModel  
  
|Method|Single or Apartment Threading|Free Threading|  
|------------|-----------------------------------|--------------------|  
|`InternalAddRef`|The increment is not thread-safe.|The increment is thread-safe.|  
|`Lock`|Does nothing; there is no critical section to lock.|The critical section is locked.|  
  
### ThreadModel = CComObjectThreadModel::ThreadModelNoCS  
  
|Method|Single or Apartment Threading|Free Threading|  
|------------|-----------------------------------|--------------------|  
|`InternalAddRef`|The increment is not thread-safe.|The increment is thread-safe.|  
|`Lock`|Does nothing; there is no critical section to lock.|Does nothing; there is no critical section to lock.|  
  
##  <a name="ccommultithreadmodel__criticalsection"></a>  CComMultiThreadModel::CriticalSection  
 When using `CComMultiThreadModel`, the `typedef` name `CriticalSection` references class [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md), which provides methods for obtaining and releasing ownership of a critical section object.  
  
```  
  
typedef CComCriticalSection CriticalSection;  
  
```  
  
### Remarks  
 [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md) and [CComMultiThreadModelNoCS](../VS_csharp/ccommultithreadmodelnocs-class.md) also contain definitions for `CriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `CriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModel`|`CComCriticalSection`|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
  
 In addition to `CriticalSection`, you can use the `typedef` name [AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md).  
  
##  <a name="ccommultithreadmodel__decrement"></a>  CComMultiThreadModel::Decrement  
 This static function calls the Win32 function [InterlockedDecrement](http://msdn.microsoft.com/library/windows/desktop/ms683580), which decrements the value of the variable pointed to by `p`.  
  
```  
  
static ULONG WINAPI Decrement(  
      LPLONG  p  
   ) throw ( );  
  
```  
  
### Parameters  
 `p`  
 [in] Pointer to the variable to be decremented.  
  
### Return Value  
 If the result of the decrement is 0, then `Decrement` returns 0. If the result of the decrement is nonzero, the return value is also nonzero but may not equal the result of the decrement.  
  
### Remarks  
 **InterlockedDecrement** prevents more than one thread from simultaneously using this variable.  
  
##  <a name="ccommultithreadmodel__increment"></a>  CComMultiThreadModel::Increment  
 This static function calls the Win32 function [InterlockedIncrement](http://msdn.microsoft.com/library/windows/desktop/ms683614), which increments the value of the variable pointed to by `p`.  
  
```  
  
static ULONG WINAPI Increment(  
      LPLONG  p  
   ) throw ( );  
  
```  
  
### Parameters  
 `p`  
 [in] Pointer to the variable to be incremented.  
  
### Return Value  
 If the result of the increment is 0, then **Increment** returns 0. If the result of the increment is nonzero, the return value is also nonzero but may not equal the result of the increment.  
  
### Remarks  
 **InterlockedIncrement** prevents more than one thread from simultaneously using this variable.  
  
##  <a name="ccommultithreadmodel__threadmodelnocs"></a>  CComMultiThreadModel::ThreadModelNoCS  
 When using `CComMultiThreadModel`, the `typedef` name `ThreadModelNoCS` references class [CComMultiThreadModelNoCS](../VS_csharp/ccommultithreadmodelnocs-class.md).  
  
```  
  
typedef CComMultiThreadModelNoCS ThreadModelNoCS;  
  
```  
  
### Remarks  
 `CComMultiThreadModelNoCS` provides thread-safe methods for incrementing and decrementing a variable; however, it does not provide a critical section.  
  
 [CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md) and `CComMultiThreadModelNoCS` also contain definitions for `ThreadModelNoCS`. The following table shows the relationship between the threading model class and the class referenced by `ThreadModelNoCS`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModel`|`CComMultiThreadModelNoCS`|  
|`CComSingleThreadModel`|`CComSingleThreadModel`|  
|`CComMultiThreadModelNoCS`|`CComMultiThreadModelNoCS`|  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md).  
  
## See Also  
 [CComSingleThreadModel Class](../VS_csharp/ccomsinglethreadmodel-class.md)   
 [CComAutoCriticalSection Class](../VS_csharp/ccomautocriticalsection-class.md)   
 [CComCriticalSection Class](../VS_csharp/ccomcriticalsection-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)