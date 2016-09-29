---
title: "COM Map Global Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM interfaces, COM map global functions"
ms.assetid: b9612d30-eb23-46ef-8093-d56f237d3cf1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM Map Global Functions
These functions provide support for COM Map             **IUnknown** implementations.  
  
|||  
|-|-|  
|[AtlInternalQueryInterface](../VS_csharp/atlinternalqueryinterface.md)|Delegates to the                             **IUnknown** of a nonaggregated object.|  
|[InlineIsEqualIUnknown](../VS_csharp/inlineisequaliunknown.md)|Generates efficient code for comparing interfaces against                             **IUnknown**.|  
  
##  <a name="atlinternalqueryinterface"></a>  AtlInternalQueryInterface  
 Retrieves a pointer to the requested interface.  
  
```  
  
HRESULT  
AtlInternalQueryInterface(  
   void*  
pThis  
,  
   const _ATL_INTMAP_ENTRY*  
pEntries  
,  
   REFIID  
iid  
,  
   void**  
ppvObject  
);  
  
```  
  
### Parameters  
 `pThis`  
 [in] A pointer to the object that contains the COM map of interfaces exposed to                                 `QueryInterface`.  
  
 `pEntries`  
 [in] An array of                                 **_ATL_INTMAP_ENTRY** structures that access a map of available interfaces.  
  
 `iid`  
 [in] The GUID of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer specified in                                 `iid`, or                                 **NULL** if the interface is not found.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 `AtlInternalQueryInterface` only handles interfaces in the COM map table. If your object is aggregated,                         `AtlInternalQueryInterface` does not delegate to the outer unknown. You can enter interfaces into the COM map table with the macro                         [COM_INTERFACE_ENTRY](../VS_csharp/com_interface_entry-macros.md) or one of its variants.  
  
### Example  
 [!code[NVC_ATL_Windowing#94](../VS_csharp/codesnippet/CPP/com-map-global-functions_1.cpp)]  
  
##  <a name="inlineisequaliunknown"></a>  InlineIsEqualIUnknown  
 Call this function, for the special case of testing for                 **IUnknown**.  
  
```  
  
BOOL InlineIsEqualUnknown(  
   REFGUID   
rguid1  
);  
  
```  
  
### Parameters  
 *rguid1*  
 [in] The GUID to compare to                                 **IID_IUnknown**.  
  
## See Also  
 [ATL Functions](../VS_csharp/atl-functions.md)   
 [COM Map Macros](../VS_csharp/com-map-macros.md)