---
title: "Symbol Provider Interfaces"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "interfaces, symbol handler"
  - "symbol handler, interfaces"
  - "symbol handler, evaluating variables"
ms.assetid: 4201f10e-c9f7-4b38-bb45-40fe0082d5bf
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Symbol Provider Interfaces
The following are the Symbol Handling Interfaces for the [!INCLUDE[vsipsdk](../VS_csharp/includes/vsipsdk_md.md)].  
  
## Discussion  
 These interfaces are used to evaluate variables in a call stack during break mode. They are implemented only for common language runtime symbol providers (SP).  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugAddress](../VS_csharp/idebugaddress.md)|SP|Represents the address of an item.|  
|[IDebugAddress2](../VS_csharp/idebugaddress2.md)|SP|Represents the address of an item, providing access to the process ID.|  
|[IDebugArrayField](../VS_csharp/idebugarrayfield.md)|SP|Represents an array symbol or array type.|  
|[IDebugClassField](../VS_csharp/idebugclassfield.md)|SP|Represents a class symbol or class type.|  
|[IDebugComPlusSymbolProvider](../VS_csharp/idebugcomplussymbolprovider.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code.|  
|[IDebugComPlusSymbolProvider2](../VS_csharp/idebugcomplussymbolprovider2.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code and extends the **IDebugComPlusSymbolProvider**.|  
|[IDebugContainerField](../VS_csharp/idebugcontainerfield.md)|SP|Represents a symbol or type that is a container for other symbols or types.|  
|[IDebugCustomAttribute](../VS_csharp/idebugcustomattribute.md)|SP|Represents a custom attribute that can be attached to a symbol.|  
|[IDebugCustomAttributeQuery](../VS_csharp/idebugcustomattributequery.md)|SP|Represents a query for custom attributes on a method or type.|  
|[IDebugCustomAttributeQuery2](../VS_csharp/idebugcustomattributequery2.md)|SP|Provides access to custom attributes on a symbol.|  
|[IDebugDynamicField](../VS_csharp/idebugdynamicfield.md)|SP|The base interface for any type that can be determined at runtime.|  
|[IDebugDynamicFieldCOMPlus](../VS_csharp/idebugdynamicfieldcomplus.md)|SP|Represents a dynamic field for an [IDebugBinder](../VS_csharp/idebugbinder.md) object.|  
|[IDebugEnumField](../VS_csharp/idebugenumfield.md)|SP|Represents an enumeration type.|  
|[IDebugExtendedField](../VS_csharp/idebugextendedfield.md)|Sp|Extends the types of available fields to support managed code generics.|  
|[IDebugField](../VS_csharp/idebugfield.md)|SP|The base class for all fields; represents a description of a symbol or type.|  
|[IDebugGenericFieldDefinition](../VS_csharp/idebuggenericfielddefinition.md)|SP|Represents the definition of a field for a managed code generic type.|  
|[IDebugGenericFieldInstance](../VS_csharp/idebuggenericfieldinstance.md)|SP|Represents an instance of a field for a managed code generic type.|  
|[IDebugGenericParamField](../VS_csharp/idebuggenericparamfield.md)|SP|Represents a parameter for a managed code generic type.|  
|[IDebugMethodField](../VS_csharp/idebugmethodfield.md)|SP|Represents a method.|  
|[IDebugModOpt](../VS_csharp/idebugmodopt.md)|SP|Represents a debug optional modifier.|  
|[IDebugPointerField](../VS_csharp/idebugpointerfield.md)|SP|Represents a pointer.|  
|[IDebugPrimitiveTypeField](../VS_csharp/idebugprimitivetypefield.md)|SP|Represents a primitive type enumeration value from an [IDebugField](../VS_csharp/idebugfield.md) interface.|  
|[IDebugPropertyField](../VS_csharp/idebugpropertyfield.md)|SP|Represents a property of a managed code class that can be get or set.|  
|[IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md)|SP|Represents a symbol provider that provides symbols and types.|  
|[IDebugSymbolProviderDirect](../VS_csharp/idebugsymbolproviderdirect.md)|SP|Represents a symbol provider with direct access to metadata and core symbol interfaces.|  
|[IDebugTypeFieldBuilder](../VS_csharp/idebugtypefieldbuilder.md)|SP|Represents the ability to create a field that represents a type.|  
|[IDebugTypeFieldBuilder2](../VS_csharp/idebugtypefieldbuilder2.md)|SP|Extends the **IDebugTypeFieldBuilder** to be able to create array types.|  
|[IEnumDebugAddresses](../VS_csharp/ienumdebugaddresses.md)|SP|Represents a collection of [IDebugAddress](../VS_csharp/idebugaddress.md) objects.|  
|[IEnumDebugCustomAttributes](../VS_csharp/ienumdebugcustomattributes.md)|SP|Represents a collection of [IDebugCustomAttribute](../VS_csharp/idebugcustomattribute.md) objects.|  
|[IEnumDebugFields](../VS_csharp/ienumdebugfields.md)|SP|Represents a collection of [IDebugField](../VS_csharp/idebugfield.md) objects.|  
  
## See Also  
 [API Reference](../VS_csharp/api-reference--visual-studio-debugging-.md)