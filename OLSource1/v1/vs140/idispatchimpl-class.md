---
title: "IDispatchImpl Class"
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
  - "IDispatchImpl"
  - "ATL.IDispatchImpl"
  - "ATL::IDispatchImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dual interfaces, classes"
  - "IDispatchImpl class"
  - "IDispatch class support in ATL"
ms.assetid: 8108eb36-1228-4127-a203-3ab5ba488892
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispatchImpl Class
Provides a default implementation for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> part of a dual interface.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A dual interface.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to the IID of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to the LIBID of the type library that contains information about the interface. By default, the server-level type library is passed.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The major version of the type library. By default, the value is 1.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The minor version of the type library. By default, the value is 0.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The class used to manage the type information for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. By default, the value is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[IDispatchImpl::IDispatchImpl](../vs140/idispatchimpl--idispatchimpl.md)|The constructor. Calls <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> on the protected member variable that manages the type information for the dual interface. The destructor calls <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IDispatchImpl::GetIDsOfNames](../vs140/idispatchimpl--getidsofnames.md)|Maps a set of names to a corresponding set of dispatch identifiers.|  
|[IDispatchImpl::GetTypeInfo](../vs140/idispatchimpl--gettypeinfo.md)|Retrieves the type information for the dual interface.|  
|[IDispatchImpl::GetTypeInfoCount](../vs140/idispatchimpl--gettypeinfocount.md)|Determines whether there is type information available for the dual interface.|  
|[IDispatchImpl::Invoke](../vs140/idispatchimpl--invoke.md)|Provides access to the methods and properties exposed by the dual interface.|  
  
## Remarks  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> provides a default implementation for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> part of any dual interface on an object. A dual interface derives from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and uses only Automation-compatible types. Like a dispinterface, a dual interface supports early binding and late binding; however, a dual interface also supports vtable binding.  
  
 The following example shows a typical implementation of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATL_COM#47](../vs140/codesnippet/CPP/idispatchimpl-class_1.h)]  
  
 By default, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class looks up the type information for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> in the registry. To implement an unregistered interface, you can use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class without accessing the registry by using a predefined version number. If you create an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object that has 0xFFFF as the value for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and 0xFFFF as the value for <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class retrieves the type library from the .dll file instead of the registry.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> contains a static member of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> that manages the type information for the dual interface. If you have multiple objects that implement the same dual interface, only one instance of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is used.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="idispatchimpl__getidsofnames">\</a>  IDispatchImpl::GetIDsOfNames  
 Maps a set of names to a corresponding set of dispatch identifiers.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::GetIDsOfNames](assetId:///6f6cf233-3481-436e-8d6a-51f93bf91619) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispatchimpl__gettypeinfo">\</a>  IDispatchImpl::GetTypeInfo  
 Retrieves the type information for the dual interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::GetTypeInfo](assetId:///cc1ec9aa-6c40-4e70-819c-a7c6dd6b8c99) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispatchimpl__gettypeinfocount">\</a>  IDispatchImpl::GetTypeInfoCount  
 Determines whether there is type information available for the dual interface.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 See <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="idispatchimpl__idispatchimpl">\</a>  IDispatchImpl::IDispatchImpl  
 The constructor. Calls <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> on the protected member variable that manages the type information for the dual interface. The destructor calls **Release**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="idispatchimpl__invoke">\</a>  IDispatchImpl::Invoke  
 Provides access to the methods and properties exposed by the dual interface.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 See [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)