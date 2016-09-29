---
title: "CComAutoCriticalSection Class"
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
  - "ATL.CComAutoCriticalSection"
  - "ATL::CComAutoCriticalSection"
  - "CComAutoCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComAutoCriticalSection class"
ms.assetid: 491a9d90-3398-4f90-88f5-fd2172a46b30
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoCriticalSection Class
`CComAutoCriticalSection` provides methods for obtaining and releasing ownership of a critical section object.  
  
## Syntax  
  
```  
  
class CComAutoCriticalSection : public CComCriticalSection  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComAutoCriticalSection::CComAutoCriticalSection](../Topic/CComAutoCriticalSection::CComAutoCriticalSection.md)|The constructor.|  
|[CComAutoCriticalSection::~CComAutoCriticalSection](../Topic/CComAutoCriticalSection::~CComAutoCriticalSection.md)|The destructor.|  
  
## Remarks  
 `CComAutoCriticalSection` is similar to class [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md), except `CComAutoCriticalSection` automatically initializes the critical section object in the constructor.  
  
 Typically, you use `CComAutoCriticalSection` through the `typedef` name [AutoCriticalSection](../Topic/CComMultiThreadModel::AutoCriticalSection.md). This name references `CComAutoCriticalSection` when [CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md) is being used.  
  
 The `Init` and `Term` methods from [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md) are not available when using this class.  
  
## Inheritance Hierarchy  
 [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md)  
  
 `CComAutoCriticalSection`  
  
## Requirements  
 **Header:** atlcore.h  
  
##  <a name="ccomautocriticalsection__ccomautocriticalsection"></a>  CComAutoCriticalSection::CComAutoCriticalSection  
 The constructor.  
  
```  
  
CComAutoCriticalSection( );  
  
```  
  
### Remarks  
 Calls the Win32 function [InitializeCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms683472), which initializes the critical section object.  
  
##  <a name="ccomautocriticalsection___dtorccomautocriticalsection"></a>  CComAutoCriticalSection::~CComAutoCriticalSection  
 The destructor.  
  
```  
  
~CComAutoCriticalSection( ) throw( );  
  
```  
  
### Remarks  
 The destructor calls [DeleteCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682552), which releases all system resources used by the critical section object.  
  
## See Also  
 [CComFakeCriticalSection Class](../VS_csharp/ccomfakecriticalsection-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [CComCriticalSection Class](../VS_csharp/ccomcriticalsection-class.md)