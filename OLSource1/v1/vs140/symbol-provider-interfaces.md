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
The following are the Symbol Handling Interfaces for the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)].  
  
## Discussion  
 These interfaces are used to evaluate variables in a call stack during break mode. They are implemented only for common language runtime symbol providers (SP).  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugAddress](../vs140/idebugaddress.md)|SP|Represents the address of an item.|  
|[IDebugAddress2](../vs140/idebugaddress2.md)|SP|Represents the address of an item, providing access to the process ID.|  
|[IDebugArrayField](../vs140/idebugarrayfield.md)|SP|Represents an array symbol or array type.|  
|[IDebugClassField](../vs140/idebugclassfield.md)|SP|Represents a class symbol or class type.|  
|[IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code.|  
|[IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code and extends the **IDebugComPlusSymbolProvider**.|  
|[IDebugContainerField](../vs140/idebugcontainerfield.md)|SP|Represents a symbol or type that is a container for other symbols or types.|  
|[IDebugCustomAttribute](../vs140/idebugcustomattribute.md)|SP|Represents a custom attribute that can be attached to a symbol.|  
|[IDebugCustomAttributeQuery](../vs140/idebugcustomattributequery.md)|SP|Represents a query for custom attributes on a method or type.|  
|[IDebugCustomAttributeQuery2](../vs140/idebugcustomattributequery2.md)|SP|Provides access to custom attributes on a symbol.|  
|[IDebugDynamicField](../vs140/idebugdynamicfield.md)|SP|The base interface for any type that can be determined at runtime.|  
|[IDebugDynamicFieldCOMPlus](../vs140/idebugdynamicfieldcomplus.md)|SP|Represents a dynamic field for an [IDebugBinder](../vs140/idebugbinder.md) object.|  
|[IDebugEnumField](../vs140/idebugenumfield.md)|SP|Represents an enumeration type.|  
|[IDebugExtendedField](../vs140/idebugextendedfield.md)|Sp|Extends the types of available fields to support managed code generics.|  
|[IDebugField](../vs140/idebugfield.md)|SP|The base class for all fields; represents a description of a symbol or type.|  
|[IDebugGenericFieldDefinition](../vs140/idebuggenericfielddefinition.md)|SP|Represents the definition of a field for a managed code generic type.|  
|[IDebugGenericFieldInstance](../vs140/idebuggenericfieldinstance.md)|SP|Represents an instance of a field for a managed code generic type.|  
|[IDebugGenericParamField](../vs140/idebuggenericparamfield.md)|SP|Represents a parameter for a managed code generic type.|  
|[IDebugMethodField](../vs140/idebugmethodfield.md)|SP|Represents a method.|  
|[IDebugModOpt](../vs140/idebugmodopt.md)|SP|Represents a debug optional modifier.|  
|[IDebugPointerField](../vs140/idebugpointerfield.md)|SP|Represents a pointer.|  
|[IDebugPrimitiveTypeField](../vs140/idebugprimitivetypefield.md)|SP|Represents a primitive type enumeration value from an [IDebugField](../vs140/idebugfield.md) interface.|  
|[IDebugPropertyField](../vs140/idebugpropertyfield.md)|SP|Represents a property of a managed code class that can be get or set.|  
|[IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)|SP|Represents a symbol provider that provides symbols and types.|  
|[IDebugSymbolProviderDirect](../vs140/idebugsymbolproviderdirect.md)|SP|Represents a symbol provider with direct access to metadata and core symbol interfaces.|  
|[IDebugTypeFieldBuilder](../vs140/idebugtypefieldbuilder.md)|SP|Represents the ability to create a field that represents a type.|  
|[IDebugTypeFieldBuilder2](../vs140/idebugtypefieldbuilder2.md)|SP|Extends the **IDebugTypeFieldBuilder** to be able to create array types.|  
|[IEnumDebugAddresses](../vs140/ienumdebugaddresses.md)|SP|Represents a collection of [IDebugAddress](../vs140/idebugaddress.md) objects.|  
|[IEnumDebugCustomAttributes](../vs140/ienumdebugcustomattributes.md)|SP|Represents a collection of [IDebugCustomAttribute](../vs140/idebugcustomattribute.md) objects.|  
|[IEnumDebugFields](../vs140/ienumdebugfields.md)|SP|Represents a collection of [IDebugField](../vs140/idebugfield.md) objects.|  
  
## See Also  
 [API Reference](../vs140/api-reference--visual-studio-debugging-.md)