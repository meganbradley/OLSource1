---
title: "CComAutoThreadModule Class"
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
  - "CComAutoThreadModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComAutoThreadModule class"
  - "apartment model modules"
ms.assetid: 13063ea5-a57e-4aac-97d3-227137262811
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoThreadModule Class
As of ATL 7.0, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] The class managing thread selection. The default value is [CComSimpleThreadAllocator](../vs140/ccomsimplethreadallocator-class.md).  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CreateInstance](../vs140/ccomautothreadmodule--createinstance.md)|Selects a thread and then creates an object in the associated apartment.|  
|[GetDefaultThreads](../vs140/ccomautothreadmodule--getdefaultthreads.md)|(Static) Dynamically calculates the number of threads for the module based on the number of processors.|  
|[Init](../vs140/ccomautothreadmodule--init.md)|Creates the module's threads.|  
|[Lock](../vs140/ccomautothreadmodule--lock.md)|Increments the lock count on the module and on the current thread.|  
|[Unlock](../vs140/ccomautothreadmodule--unlock.md)|Decrements the lock count on the module and on the current thread.|  
  
### Data Members  
  
### Data Members  
  
|||  
|-|-|  
|[dwThreadID](../vs140/ccomautothreadmodule--dwthreadid.md)|Contains the identifier of the current thread.|  
|[m_Allocator](../vs140/ccomautothreadmodule--m_allocator.md)|Manages thread selection.|  
|[m_nThreads](../vs140/ccomautothreadmodule--m_nthreads.md)|Contains the number of threads in the module.|  
|[m_pApartments](../vs140/ccomautothreadmodule--m_papartments.md)|Manages the module's apartments.|  
  
## Remarks  
  
> [!NOTE]
>  This class is obsolete, having been replaced by the [CAtlAutoThreadModule](../vs140/catlautothreadmodule-class.md) and [CAtlModule](../vs140/catlmodule-class.md) derived classes. The information that follows is for use with older releases of ATL.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> derives from [CComModule](../vs140/ccommodule-class.md) to implement a thread-pooled, apartment-model COM server for EXEs and Windows services. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> uses [CComApartment](../vs140/ccomapartment-class.md) to manage an apartment for each thread in the module.  
  
 Derive your module from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> when you want to create objects in multiple apartments. You must also include the [DECLARE_CLASSFACTORY_AUTO_THREAD](../vs140/declare_classfactory_auto_thread.md) macro in your object's class definition to specify [CComClassFactoryAutoThread](../vs140/ccomclassfactoryautothread-class.md) as the class factory.  
  
 By default, the ATL COM AppWizard (the ATL Project Wizard in Visual Studio .NET) will derive your module from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. To use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, modify the class definition. For example:  
  
 [!code[NVC_ATL_AxHost#2](../vs140/codesnippet/CPP/ccomautothreadmodule-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [_ATL_MODULE](../vs140/_atl_module.md)  
  
 [CAtlModule](../vs140/catlmodule-class.md)  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 [CAtlModuleT](../vs140/catlmodulet-class.md)  
  
 [CAtlAutoThreadModuleT](../vs140/catlautothreadmodulet-class.md)  
  
 [CComModule](../vs140/ccommodule-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccomautothreadmodule__createinstance">\</a>  CComAutoThreadModule::CreateInstance  
 As of ATL 7.0, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pfnCreateInstance*  
 [in] A pointer to a creator function.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is set to NULL.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Selects a thread and then creates an object in the associated apartment.  
  
##  \<a name="ccomautothreadmodule__dwthreadid">\</a>  CComAutoThreadModule::dwThreadID  
 As of ATL 7.0, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Contains the identifier of the current thread.  
  
##  \<a name="ccomautothreadmodule__getdefaultthreads">\</a>  CComAutoThreadModule::GetDefaultThreads  
 As of ATL 7.0, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The number of threads to be created in the EXE module.  
  
### Remarks  
 This static function dynamically calculates the maximum number of threads for the EXE module, based on the number of processors. By default, this return value is passed to the [Init](../vs140/ccomautothreadmodule--init.md) method to create the threads.  
  
##  \<a name="ccomautothreadmodule__init">\</a>  CComAutoThreadModule::Init  
 As of ATL 7.0, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 [in] A pointer to an array of object map entries.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> passed to **DLLMain** or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 [in] A pointer to the LIBID of the type library associated with the project.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 [in] The number of threads to be created. By default, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is the value returned by [GetDefaultThreads](../vs140/ccomautothreadmodule--getdefaultthreads.md).  
  
### Remarks  
 Initializes data members and creates the number of threads specified by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomautothreadmodule__lock">\</a>  CComAutoThreadModule::Lock  
 As of ATL 7.0, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
### Remarks  
 Performs an atomic increment on the lock count for the module and for the current thread. <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> uses the module lock count to determine whether any clients are accessing the module. The lock count on the current thread is used for statistical purposes.  
  
##  \<a name="ccomautothreadmodule__m_allocator">\</a>  CComAutoThreadModule::m_Allocator  
 As of ATL 7.0, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The object managing thread selection. By default, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class template parameter is [CComSimpleThreadAllocator](../vs140/ccomsimplethreadallocator-class.md).  
  
##  \<a name="ccomautothreadmodule__m_nthreads">\</a>  CComAutoThreadModule::m_nThreads  
 As of ATL 7.0, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Contains the number of threads in the EXE module. When [Init](../vs140/ccomautothreadmodule--init.md) is called, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is set to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter value. Each thread's associated apartment is managed by a [CComApartment](../vs140/ccomapartment-class.md) object.  
  
##  \<a name="ccomautothreadmodule__m_papartments">\</a>  CComAutoThreadModule::m_pApartments  
 As of ATL 7.0, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Points to an array of [CComApartment](../vs140/ccomapartment-class.md) objects, each of which manages an apartment in the module. The number of elements in the array is based on the [m_nThreads](../vs140/ccomautothreadmodule--m_nthreads.md) member.  
  
##  \<a name="ccomautothreadmodule__unlock">\</a>  CComAutoThreadModule::Unlock  
 As of ATL 7.0, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
### Remarks  
 Performs an atomic decrement on the lock count for the module and for the current thread. <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> uses the module lock count to determine whether any clients are accessing the module. The lock count on the current thread is used for statistical purposes.  
  
 When the module lock count reaches zero, the module can be unloaded.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Module Classes](../vs140/atl-module-classes.md)