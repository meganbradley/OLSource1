---
title: "ISpecifyPropertyPagesImpl Class"
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
  - "ISpecifyPropertyPagesImpl"
  - "ATL.ISpecifyPropertyPagesImpl<T>"
  - "ATL::ISpecifyPropertyPagesImpl"
  - "ATL::ISpecifyPropertyPagesImpl<T>"
  - "ATL.ISpecifyPropertyPagesImpl"
  - "ISpecifyPropertyPagesImpl Class"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property pages, CLSIDs associated with"
  - "ISpecifyPropertyPages"
  - "ISpecifyPropertyPagesImpl class"
ms.assetid: 4e4b9795-b656-4d56-9b8c-85941e7731f9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISpecifyPropertyPagesImpl Class
This class implements **IUnknown** and provides a default implementation of the [ISpecifyPropertyPages](http://msdn.microsoft.com/library/windows/desktop/ms695217) interface.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template<  
   class  T>  
   class ATL_NO_VTABLE ISpecifyPropertyPagesImpl :  
   public ISpecifyPropertyPages  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `ISpecifyPropertyPagesImpl`.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ISpecifyPropertyPagesImpl::GetPages](../VS_csharp/ispecifypropertypagesimpl--getpages.md)|Fills a Counted Array of UUID values. Each UUID corresponds to the CLSID for one of the property pages that can be displayed in the object's property sheet.|  
  
## Remarks  
 The [ISpecifyPropertyPages](http://msdn.microsoft.com/library/windows/desktop/ms695217) interface allows a client to obtain a list of CLSIDs for the property pages supported by an object. Class `ISpecifyPropertyPagesImpl` provides a default implementation of this interface and implements **IUnknown** by sending information to the dump device in debug builds.  
  
> [!NOTE]
>  Do not expose the **ISpecifyPropertyPages** interface if your object does not support property pages.  
  
 **Related Articles** [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md), [Creating an ATL Project](../VS_csharp/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 `ISpecifyPropertyPages`  
  
 `ISpecifyPropertyPagesImpl`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ispecifypropertypagesimpl__getpages"></a>  ISpecifyPropertyPagesImpl::GetPages  
 Fills the array in the [CAUUID](http://msdn.microsoft.com/library/windows/desktop/ms680048) structure with the CLSIDs for the property pages that can be displayed in the object's property sheet.  
  
```  
  
STDMETHOD(GetPages)(  
      CAUUID*  pPages  
   );  
  
```  
  
### Remarks  
 ATL uses the object's property map to retrieve each CLSID.  
  
 See [ISpecifyPropertyPages::GetPages](http://msdn.microsoft.com/library/windows/desktop/ms687276) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## See Also  
 [IPropertyPageImpl Class](../VS_csharp/ipropertypageimpl-class.md)   
 [IPerPropertyBrowsingImpl Class](../VS_csharp/iperpropertybrowsingimpl-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)