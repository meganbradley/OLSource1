---
title: "CComObjectRootEx Class"
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
  - "ATL.CComObjectRootEx"
  - "ATL::CComObjectRootEx<ThreadModel>"
  - "CComObjectRootEx"
  - "ATL::CComObjectRootEx"
  - "ATL.CComObjectRootEx<ThreadModel>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference counting"
ms.assetid: 894a3d7c-2daf-4fd0-8fa4-e6a05bcfb631
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx Class
This class provides methods to handle object reference count management for both nonaggregated and aggregated objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The class whose methods implement the desired threading model. You can explicitly choose the threading model by setting <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md), [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md), or [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md). You can accept the server's default thread model by setting <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md) or [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md).  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CComObjectRootEx](../vs140/ccomobjectrootex--ccomobjectrootex.md)|Constructor.|  
|[InternalAddRef](../vs140/ccomobjectrootex--internaladdref.md)|Increments the reference count for a nonaggregated object.|  
|[InternalRelease](../vs140/ccomobjectrootex--internalrelease.md)|Decrements the reference count for a nonaggregated object.|  
|[Lock](../vs140/ccomobjectrootex--lock.md)|If the thread model is multithreaded, obtains ownership of a critical section object.|  
|[Unlock](../vs140/ccomobjectrootex--unlock.md)|If the thread model is multithreaded, releases ownership of a critical section object.|  
  
### CComObjectRootBase Methods  
  
|||  
|-|-|  
|[FinalConstruct](../vs140/ccomobjectrootex--finalconstruct.md)|Override in your class to perform any initialization required by your object.|  
|[FinalRelease](../vs140/ccomobjectrootex--finalrelease.md)|Override in your class to perform any cleanup required by your object.|  
|[OuterAddRef](../vs140/ccomobjectrootex--outeraddref.md)|Increments the reference count for an aggregated object.|  
|[OuterQueryInterface](../vs140/ccomobjectrootex--outerqueryinterface.md)|Delegates to the outer **IUnknown** of an aggregated object.|  
|[OuterRelease](../vs140/ccomobjectrootex--outerrelease.md)|Decrements the reference count for an aggregated object.|  
  
### Static Functions  
  
|||  
|-|-|  
|[InternalQueryInterface](../vs140/ccomobjectrootex--internalqueryinterface.md)|Delegates to the **IUnknown** of a nonaggregated object.|  
|[ObjectMain](../vs140/ccomobjectrootex--objectmain.md)|Called during module initialization and termination for derived classes listed in the object map.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_dwRef](../vs140/ccomobjectrootex--m_dwref.md)|With <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, part of a union. Used when the object is not aggregated to hold the reference count of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and **Release**.|  
|[m_pOuterUnknown](../vs140/ccomobjectrootex--m_pouterunknown.md)|With <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, part of a union. Used when the object is aggregated to hold a pointer to the outer unknown.|  
  
## Remarks  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> handles object reference count management for both nonaggregated and aggregated objects. It holds the object reference count if your object is not being aggregated, and holds the pointer to the outer unknown if your object is being aggregated. For aggregated objects, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> methods can be used to handle the failure of the inner object to construct, and to protect the outer object from deletion when inner interfaces are released or the inner object is deleted.  
  
 A class that implements a COM server must inherit from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or [CComObjectRoot](../vs140/ccomobjectroot-class.md).  
  
 If your class definition specifies the [DECLARE_POLY_AGGREGATABLE](../vs140/declare_poly_aggregatable.md) macro, ATL creates an instance of **CComPolyObject\<CYourClass>** when **IClassFactory::CreateInstance** is called. During creation, the value of the outer unknown is checked. If it is **NULL**,                 **IUnknown** is implemented for a nonaggregated object. If the outer unknown is not **NULL**,                 **IUnknown** is implemented for an aggregated object.  
  
 If your class does not specify the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> macro, ATL creates an instance of **CAggComObject\<CYourClass>** for aggregated objects or an instance of **CComObject\<CYourClass>** for nonaggregated objects.  
  
 The advantage of using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is that you avoid having both <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in your module to handle the aggregated and nonaggregated cases. A single <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object handles both cases. Therefore, only one copy of the vtable and one copy of the functions exist in your module. If your vtable is large, this can substantially decrease your module size. However, if your vtable is small, using <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> can result in a slightly larger module size because it is not optimized for an aggregated or nonaggregated object, as are <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 If your object is aggregated, [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) is implemented by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. These classes delegate <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and **Release** calls to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to forward to the outer unknown. Typically, you override <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> in your class to create any aggregated objects, and override <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to free any aggregated objects.  
  
 If your object is not aggregated,                 **IUnknown** is implemented by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. In this case, calls to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and **Release** are delegated to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to perform the actual operations.  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomobjectrootex__ccomobjectrootex">\</a>  CComObjectRootEx::CComObjectRootEx  
 The constructor initializes the reference count to 0.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="ccomobjectrootex__finalconstruct">\</a>  CComObjectRootEx::FinalConstruct  
 You can override this method in your derived class to perform any initialization required for your object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Return <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> on success or one of the standard error <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> values.  
  
### Remarks  
 By default, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> simply returns <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 There are advantages to performing initialization in <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> rather than the constructor of your class:  
  
-   You cannot return a status code from a constructor, but you can return an <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> by means of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>'s return value. When objects of your class are being created using the standard class factory provided by ATL, this return value is propagated back to the COM client allowing you to provide them with detailed error information.  
  
-   You cannot call virtual functions through the virtual function mechanism from the constructor of a class. Calling a virtual function from the constructor of a class results in a statically resolved call to the function as it is defined at that point in the inheritance hierarchy. Calls to pure virtual functions result in linker errors.  
  
     Your class is not the most derived class in the inheritance hierarchy — it relies on a derived class supplied by ATL to provide some of its functionality. There is a good chance that your initialization will need to use the features provided by that class (this is certainly true when objects of your class need to aggregate other objects), but the constructor in your class has no way to access those features. The construction code for your class is executed before the most derived class is fully constructed.  
  
     However, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is called immediately after the most derived class is fully constructed allowing you to call virtual functions and use the reference-counting implementation provided by ATL.  
  
### Example  
 Typically, override this method in the class derived from <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to create any aggregated objects. For example:  
  
 [!code[NVC_ATL_COM#40](../vs140/codesnippet/CPP/ccomobjectrootex-class_1.h)]  
  
 If the construction fails, you can return an error. You can also use the macro [DECLARE_PROTECT_FINAL_CONSTRUCT](../vs140/declare_protect_final_construct.md) to protect your outer object from being deleted if, during creation, the internal aggregated object increments the reference count then decrements the count to 0.  
  
 Here is a typical way to create an aggregate:  
  
-   Add an **IUnknown** pointer to your class object and initialize it to **NULL** in the constructor.  
  
-   Override <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to create the aggregate.  
  
-   Use the **IUnknown** pointer you defined as the parameter to the [COM_INTERFACE_ENTRY_AGGREGATE](../vs140/com_interface_entry_aggregate.md) macro.  
  
-   Override <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to release the **IUnknown** pointer.  
  
##  \<a name="ccomobjectrootex__finalrelease">\</a>  CComObjectRootEx::FinalRelease  
 You can override this method in your derived class to perform any cleanup required for your object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 By default, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> does nothing.  
  
 Performing cleanup in <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is preferable to adding code to the destructor of your class since the object is still fully constructed at the point at which <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> is called. This enables you to safely access the methods provided by the most derived class. This is particularly important for freeing any aggregated objects before deletion.  
  
##  \<a name="ccomobjectrootex__internaladdref">\</a>  CComObjectRootEx::InternalAddRef  
 Increments the reference count of a nonaggregated object by 1.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics and testing.  
  
### Remarks  
 If the thread model is multithreaded,                         **InterlockedIncrement** is used to prevent more than one thread from changing the reference count at the same time.  
  
##  \<a name="ccomobjectrootex__internalqueryinterface">\</a>  CComObjectRootEx::InternalQueryInterface  
 Retrieves a pointer to the requested interface.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 [in] A pointer to the object that contains the COM map of interfaces exposed to <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 [in] A pointer to the **_ATL_INTMAP_ENTRY** structure that accesses a map of available interfaces.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 [in] The GUID of the interface being requested.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer specified in <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, or **NULL** if the interface is not found.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> values.  
  
### Remarks  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> only handles interfaces in the COM map table. If your object is aggregated, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> does not delegate to the outer unknown. You can enter interfaces into the COM map table with the macro [COM_INTERFACE_ENTRY](../vs140/com_interface_entry-macros.md) or one of its variants.  
  
##  \<a name="ccomobjectrootex__internalrelease">\</a>  CComObjectRootEx::InternalRelease  
 Decrements the reference count of a nonaggregated object by 1.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 In both non-debug and debug builds, this function returns a value which may be useful for diagnostics or testing. The exact value returned depends on many factors such as the operating system used, and may, or may not, be the reference count.  
  
### Remarks  
 If the thread model is multithreaded,                         **InterlockedDecrement** is used to prevent more than one thread from changing the reference count at the same time.  
  
##  \<a name="ccomobjectrootex__lock">\</a>  CComObjectRootEx::Lock  
 If the thread model is multithreaded, this method calls the Win32 API function [EnterCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682608), which waits until the thread can take ownership of the critical section object obtained through a private data member.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 When the protected code finishes executing, the thread must call <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> to release ownership of the critical section.  
  
 If the thread model is single-threaded, this method does nothing.  
  
##  \<a name="ccomobjectrootex__m_dwref">\</a>  CComObjectRootEx::m_dwRef  
 Part of a union that accesses four bytes of memory.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 With <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, part of a union:  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  
 If the object is not aggregated, the reference count accessed by <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and **Release** is stored in <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. If the object is aggregated, the pointer to the outer unknown is stored in [m_pOuterUnknown](../vs140/ccomobjectrootex--m_pouterunknown.md).  
  
##  \<a name="ccomobjectrootex__m_pouterunknown">\</a>  CComObjectRootEx::m_pOuterUnknown  
 Part of a union that accesses four bytes of memory.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 With <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, part of a union:  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
 If the object is aggregated, the pointer to the outer unknown is stored in <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. If the object is not aggregated, the reference count accessed by <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and **Release** is stored in [m_dwRef](../vs140/ccomobjectrootex--m_dwref.md).  
  
##  \<a name="ccomobjectrootex__objectmain">\</a>  CComObjectRootEx::ObjectMain  
 For each class listed in the [object map](assetId:///b57619cc-534f-4b8f-bfd4-0c12f937202f), this function is called once when the module is initialized, and again when it is terminated.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 [out] The value is **true** if the class is being initialized; otherwise **false**.  
  
### Remarks  
 The value of the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> parameter indicates whether the module is being initialized or terminated. The default implementation of <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> does nothing, but you can override this function in your class to initialize or clean up resources that you want to allocate for the class. Note that <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is called before any instances of the class are requested.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is called from the entry point of the DLL, so the type of operation that the entry-point function can perform is restricted. For more information on these restrictions, see [Run-Time Library Behavior](../vs140/run-time-library-behavior.md) and [DllMain](http://msdn.microsoft.com/library/windows/desktop/ms682583).  
  
### Example  
 [!code[NVC_ATL_COM#41](../vs140/codesnippet/CPP/ccomobjectrootex-class_2.h)]  
  
##  \<a name="ccomobjectrootex__outeraddref">\</a>  CComObjectRootEx::OuterAddRef  
 Increments the reference count of the outer unknown of an aggregation.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics and testing.  
  
##  \<a name="ccomobjectrootex__outerqueryinterface">\</a>  CComObjectRootEx::OuterQueryInterface  
 Retrieves an indirect pointer to the requested interface.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 [in] The GUID of the interface being requested.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer specified in <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, or **NULL** if the aggregation does not support the interface.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> values.  
  
##  \<a name="ccomobjectrootex__outerrelease">\</a>  CComObjectRootEx::OuterRelease  
 Decrements the reference count of the outer unknown of an aggregation.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 In non-debug builds, always returns 0. In debug builds, returns a value that may be useful for diagnostics or testing.  
  
##  \<a name="ccomobjectrootex__unlock">\</a>  CComObjectRootEx::Unlock  
 If the thread model is multithreaded, this method calls the Win32 API function [LeaveCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms684169), which releases ownership of the critical section object obtained through a private data member.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 To obtain ownership, the thread must call <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. Each call to <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> requires a corresponding call to <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to release ownership of the critical section.  
  
 If the thread model is single-threaded, this method does nothing.  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComObject Class](../vs140/ccomobject-class.md)   
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)