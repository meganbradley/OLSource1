---
title: "CMyProviderSource (MyProviderDS.H)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - ""myproviderds.h""
  - "cmyprovidersource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE DB providers, wizard-generated files"
  - "CMyProviderSource class in MyProviderDS.H"
ms.assetid: c143d48e-59c8-4f67-9141-3aab51859b92
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMyProviderSource (MyProviderDS.H)
The provider classes use multiple inheritance. The following code shows the inheritance chain for the data source object:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 All the COM components derive from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provides all the implementation for the **IUnknown** interface. It can handle any threading model. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> handles any error support required. If you want to send richer error information to the client, you can use some of the error APIs in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The data source object also inherits from several 'Impl' classes. Each class provides the implementation for an interface. The data source object implements the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, **IDBInitialize**, and **IDBCreateSession** interfaces. Each interface is required by OLE DB to implement the data source object. You can choose to support or not support particular functionality by inheriting or not inheriting from one of these 'Impl' classes. If you want to support the **IDBDataSourceAdmin** interface, you inherit from the **IDBDataSourceAdminImpl** class to get the functionality required.  
  
## COM Map  
 Whenever the client calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for an interface on the data source, it goes through the following COM map:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The COM_INTERFACE_ENTRY macros are from ATL and tell the implementation of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to return the appropriate interfaces.  
  
## Property Map  
 The property map specifies all the properties designated by the provider:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Properties in OLE DB are grouped. The data source object has two groups of properties: one for the **DBPROPSET_DATASOURCEINFO** set and one for the **DBPROPSET_DBINIT** set. The **DBPROPSET_DATASOURCEINFO** set corresponds to properties about the provider and its data source. The **DBPROPSET_DBINIT** set corresponds to properties used at initialization. The OLE DB Provider Templates handle these sets with the PROPERTY_SET macros. The macros create a block that contains an array of properties. Whenever the client calls the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface, the provider uses the property map.  
  
 You do not need to implement every property in the specification. However, you must support the required properties; see the level 0 conformance specification for more information. If you do not want to support a property, you can remove it from the map. If you want to support a property, add it into the map by using a PROPERTY_INFO_ENTRY macro. The macro corresponds to the **UPROPINFO** structure as shown in the following code:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Each element in the structure represents information to handle the property. It contains a **DBPROPID** to determine the GUID and ID for the property. It also contains entries to determine the type and value of the property.  
  
 If you want to change the default value of a property (note that a consumer can change the value of a writable property at any time), you can use either the PROPERTY_INFO_ENTRY_VALUE or PROPERTY_INFO_ENTRY_EX macro. These macros allow you to specify a value for a corresponding property. The PROPERTY_INFO_ENTRY_VALUE macro is a shorthand notation that allows you to change the value. The PROPERTY_INFO_ENTRY_VALUE macro calls the PROPERTY_INFO_ENTRY_EX macro. This macro allows you to add or change all of the attributes in the **UPROPINFO** structure.  
  
 If you want to define your own property set, you can add one by making an additional BEGIN_PROPSET_MAP/END_PROPSET_MAP combination. You need to define a GUID for the property set and then define your own properties. If you have provider-specific properties, add them to a new property set instead of using an existing one. This avoids problems in later versions of OLE DB.  
  
## User-Defined Property Sets  
 Visual C++ .NET supports user-defined property sets. You no longer have to override **GetProperties** or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Instead, the templates detect any user-defined property set and add it to the appropriate object.  
  
 If you have a user-defined property set that needs to be available at initialization time (that is, before the consumer calls **IDBInitialize::Initialize**), you can specify this by using the **UPROPSET_USERINIT** flag in conjunction with the BEGIN_PROPERTY_SET_EX macro. The property set must be in the data source object for this to work (as the OLE DB specification requires). For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Provider Wizard-Generated Files](../vs140/provider-wizard-generated-files.md)