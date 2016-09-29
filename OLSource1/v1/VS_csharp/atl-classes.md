---
title: "ATL Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "index-page "
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "classes [C++], ATL"
  - "ATL, classes"
ms.assetid: 7da42e2d-ac84-4506-92bd-502a86d68bdc
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Classes
The Active Template Library (ATL) includes the following classes. To find a particular class by category, see the [ATL Class Overview](../VS_csharp/atl-class-overview.md).  
  
|Class|Description|Header file|  
|-----------|-----------------|-----------------|  
|[CA2AEX](../VS_csharp/ca2aex-class.md)|This class is used by the string conversion macros `CA2TEX` and `CT2AEX`, and the typedef **CA2A**.|atlconv.h|  
|[CA2CAEX](../VS_csharp/ca2caex-class.md)|This class is used by string conversion macros `CA2CTEX` and `CT2CAEX`, and the typedef **CA2CA**.|atlconv.h|  
|[CA2WEX](../VS_csharp/ca2wex-class.md)|This class is used by the string conversion macros `CA2TEX`, `CA2CTEX`, `CT2WEX`, and `CT2CWEX`, and the typedef **CA2W**.|atlconv.h|  
|[CAccessToken](../VS_csharp/caccesstoken-class.md)|This class is a wrapper for an access token.|atlsecurity.h|  
|[CAcl](../VS_csharp/cacl-class.md)|This class is a wrapper for an **ACL** (access-control list) structure.|atlsecurity.h|  
|[CAdapt](../VS_csharp/cadapt-class.md)|This template is used to wrap classes that redefine the address-of operator to return something other than the address of the object.|atlcomcli.h|  
|[CAtlArray](../VS_csharp/catlarray-class.md)|This class implements an array object.|atlcoll.h|  
|[CAtlAutoThreadModule](../VS_csharp/catlautothreadmodule-class.md)|This class implements a thread-pooled, apartment-model COM server.|atlbase.h|  
|[CAtlAutoThreadModuleT](../VS_csharp/catlautothreadmodulet-class.md)|This class provides methods for implementing a thread-pooled, apartment-model COM server.|atlbase.h|  
|[CAtlBaseModule](../VS_csharp/catlbasemodule-class.md)|This class is instantiated in every ATL project.|atlcore.h|  
|[CAtlComModule](../VS_csharp/catlcommodule-class.md)|This class implements a COM server module.|atlbase.h|  
|[CAtlDebugInterfacesModule](../VS_csharp/catldebuginterfacesmodule-class.md)|This class provides support for debugging interfaces.|atlbase.h|  
|[CAtlDllModuleT](../VS_csharp/catldllmodulet-class.md)|This class represents the module for a DLL.|atlbase.h|  
|[CAtlException](../VS_csharp/catlexception-class.md)|This class defines an ATL exception.|atlexcept.h|  
|[CAtlExeModuleT](../VS_csharp/catlexemodulet-class.md)|This class represents the module for an application.|atlbase.h|  
|[CAtlFile](../VS_csharp/catlfile-class.md)|This class provides a thin wrapper around the Windows file-handling API.|atlfile.h|  
|[CAtlFileMapping](../VS_csharp/catlfilemapping-class.md)|This class represents a memory-mapped file, adding a cast operator to the methods of [CAtlFileMappingBase](../VS_csharp/catlfilemappingbase-class.md).|atlfile.h|  
|[CAtlFileMappingBase](../VS_csharp/catlfilemappingbase-class.md)|This class represents a memory-mapped file.|atlfile.h|  
|[CAtlList](../VS_csharp/catllist-class.md)|This class provides methods for creating and managing a list object.|atlcoll.h|  
|[CAtlMap](../VS_csharp/catlmap-class.md)|This class provides methods for creating and managing a map object.|atlcoll.h|  
|[CAtlModule](../VS_csharp/catlmodule-class.md)|This class provides methods used by several ATL module classes.|atlbase.h|  
|[CAtlModuleT](../VS_csharp/catlmodulet-class.md)|This class implements an ATL module.|atlbase.h|  
|[CAtlPreviewCtrlImpl](../VS_csharp/catlpreviewctrlimpl-class.md)|This class is an ATL implementation of a window that is placed on a host window provided by the Shell for Rich Preview.|atlpreviewctrlimpl.h|  
|[CAtlServiceModuleT](../VS_csharp/catlservicemodulet-class.md)|This class implements a service.|atlbase.h|  
|[CAtlTemporaryFile](../VS_csharp/catltemporaryfile-class.md)|This class provides methods for the creation and use of a temporary file.|atlfile.h|  
|[CAtlTransactionManager](../VS_csharp/catltransactionmanager-class.md)|This class provides a wrapper to Kernel Transaction Manager (KTM) functions.|atltransactionmanager.h|  
|[CAtlWinModule](../VS_csharp/catlwinmodule-class.md)|This class provides support for ATL windowing components.|atlbase.h|  
|[CAutoPtr](../VS_csharp/cautoptr-class.md)|This class represents a smart pointer object.|atlbase.h|  
|[CAutoPtrArray](../VS_csharp/cautoptrarray-class.md)|This class provides methods useful when constructing an array of smart pointers.|atlbase.h|  
|[CAutoPtrElementTraits](../VS_csharp/cautoptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of smart pointers.|atlcoll.h|  
|[CAutoPtrList](../VS_csharp/cautoptrlist-class.md)|This class provides methods useful when constructing a list of smart pointers.|atlcoll.h|  
|[CAutoVectorPtr](../VS_csharp/cautovectorptr-class.md)|This class represents a smart pointer object using vector new and delete operators.|atlbase.h|  
|[CAutoVectorPtrElementTraits](../VS_csharp/cautovectorptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of smart pointers using vector new and delete operators.|atlcoll.h|  
|[CAxDialogImpl](../VS_csharp/caxdialogimpl-class.md)|This class implements a dialog box (modal or modeless) that hosts ActiveX controls.|atlwin.h|  
|[CAxWindow](../VS_csharp/caxwindow-class.md)|This class provides methods for manipulating a window hosting an ActiveX control.|atlwin.h|  
|[CAxWindow2T](../VS_csharp/caxwindow2t-class.md)|This class provides methods for manipulating a window that hosts an ActiveX control and also has support for hosting licensed ActiveX controls.|atlwin.h|  
|[CBindStatusCallback](../VS_csharp/cbindstatuscallback-class.md)|This class implements the `IBindStatusCallback` interface.|atlctl.h|  
|[CComAggObject](../VS_csharp/ccomaggobject-class.md)|This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for an aggregated object.|atlcom.h|  
|[CComAllocator](../VS_csharp/ccomallocator-class.md)|This class provides methods for managing memory using COM memory routines.|atlbase.h|  
|[CComApartment](../VS_csharp/ccomapartment-class.md)|This class provides support for managing an apartment in a thread-pooled EXE module.|atlbase.h|  
|[CComAutoCriticalSection](../VS_csharp/ccomautocriticalsection-class.md)|This class provides methods for obtaining and releasing ownership of a critical section object.|atlcore.h|  
|[CComAutoThreadModule](../VS_csharp/ccomautothreadmodule-class.md)|As of ATL 7.0, `CComAutoThreadModule` is obsolete: see [ATL Modules](../VS_csharp/atl-module-classes.md) for more details.|atlbase.h|  
|[CComBSTR](../VS_csharp/ccombstr-class.md)|This class is a wrapper for `BSTR`s.|atlbase.h|  
|[CComCachedTearOffObject](../VS_csharp/ccomcachedtearoffobject-class.md)|This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for a tear-off interface.|atlcom.h|  
|[CComClassFactory](../VS_csharp/ccomclassfactory-class.md)|This class implements the [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364) interface.|atlcom.h|  
|[CComClassFactory2](../VS_csharp/ccomclassfactory2-class.md)|This class implements the [IClassFactory2](http://msdn.microsoft.com/library/windows/desktop/ms692720) interface.|atlcom.h|  
|[CComClassFactoryAutoThread](../VS_csharp/ccomclassfactoryautothread-class.md)|This class implements the [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364) interface and allows objects to be created in multiple apartments.|atlcom.h|  
|[CComClassFactorySingleton](../VS_csharp/ccomclassfactorysingleton-class.md)|This class derives from [CComClassFactory](../VS_csharp/ccomclassfactory-class.md) and uses [CComObjectGlobal](../VS_csharp/ccomobjectglobal-class.md) to construct a single object.|atlcom.h|  
|[CComCoClass](../VS_csharp/ccomcoclass-class.md)|This class provides methods for creating instances of a class and obtaining its properties.|atlcom.h|  
|[CComCompositeControl](../VS_csharp/ccomcompositecontrol-class.md)|This class provides the methods required to implement a composite control.|atlctl.h|  
|[CComContainedObject](../VS_csharp/ccomcontainedobject-class.md)|This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) by delegating to the owner object's **IUnknown**.|atlcom.h|  
|[CComControl](../VS_csharp/ccomcontrol-class.md)|This class provides methods for creating and managing ATL controls.|atlctl.h|  
|[CComControlBase](../VS_csharp/ccomcontrolbase-class.md)|This class provides methods for creating and managing ATL controls.|atlctl.h|  
|[CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md)|This class provides methods for obtaining and releasing ownership of a critical section object.|atlcore.h|  
|[CComCritSecLock](../VS_csharp/ccomcritseclock-class.md)|This class provides methods for locking and unlocking a critical section object.|atlbase.h|  
|[CComCurrency](../VS_csharp/ccomcurrency-class.md)|This class has methods and operators for creating and managing a `CURRENCY` object.|atlcur.h|  
|[CComDynamicUnkArray](../VS_csharp/ccomdynamicunkarray-class.md)|This class stores an array of **IUnknown** pointers.|atlcom.h|  
|[CComEnum](../VS_csharp/ccomenum-class.md)|This class defines a COM enumerator object based on an array.|atlcom.h|  
|[CComEnumImpl](../VS_csharp/ccomenumimpl-class.md)|This class provides the implementation for a COM enumerator interface where the items being enumerated are stored in an array.|atlcom.h|  
|[CComEnumOnSTL](../VS_csharp/ccomenumonstl-class.md)|This class defines a COM enumerator object based on an STL collection.|atlcom.h|  
|[CComFakeCriticalSection](../VS_csharp/ccomfakecriticalsection-class.md)|This class provides the same methods as [CComCriticalSection](../VS_csharp/ccomcriticalsection-class.md) but does not provide a critical section.|atlcore.h|  
|[CComGITPtr](../VS_csharp/ccomgitptr-class.md)|This class provides methods for dealing with interface pointers and the global interface table (GIT).|atlbase.h|  
|[CComHeap](../VS_csharp/ccomheap-class.md)|This class implements [IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md) using the COM memory allocation functions.|ATLComMem.h|  
|[CComHeapPtr](../VS_csharp/ccomheapptr-class.md)|A smart pointer class for managing heap pointers.|atlbase.h|  
|[CComModule](../VS_csharp/ccommodule-class.md)|As of ATL 7.0, `CComModule` is obsolete: see [ATL Modules](../VS_csharp/atl-module-classes.md) for more details.|atlbase.h|  
|[CComMultiThreadModel](../VS_csharp/ccommultithreadmodel-class.md)|This class provides thread-safe methods for incrementing and decrementing the value of a variable.|atlbase.h|  
|[CComMultiThreadModelNoCS](../VS_csharp/ccommultithreadmodelnocs-class.md)|This class provides thread-safe methods for incrementing and decrementing the value of a variable, without critical section locking or unlocking functionality.|atlbase.h|  
|[CComObject](../VS_csharp/ccomobject-class.md)|This class implements **IUnknown** for a nonaggregated object.|atlcom.h|  
|[CComObjectGlobal](../VS_csharp/ccomobjectglobal-class.md)|This class manages a reference count on the module containing your `Base` object.|atlcom.h|  
|[CComObjectNoLock](../VS_csharp/ccomobjectnolock-class.md)|This class implements **IUnknown** for a nonaggregated object, but does not increment the module lock count in the constructor.|atlcom.h|  
|[CComObjectRoot](../VS_csharp/ccomobjectroot-class.md)|This typedef of [CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md) is templatized on the default threading model of the server.|atlcom.h|  
|[CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md)|This class provides methods to handle object reference count management for both nonaggregated and aggregated objects.|atlcom.h|  
|[CComObjectStack](../VS_csharp/ccomobjectstack-class.md)|This class creates a temporary COM object and provides it with a skeletal implementation of **IUnknown**.|atlcom.h|  
|[CComPolyObject](../VS_csharp/ccompolyobject-class.md)|This class implements **IUnknown** for an aggregated or nonaggregated object.|atlcom.h|  
|[CComPtr](../VS_csharp/ccomptr-class.md)|A smart pointer class for managing COM interface pointers.|atlcomcli.h|  
|[CComPtrBase](../VS_csharp/ccomptrbase-class.md)|This class provides a basis for smart pointer classes using COM-based memory routines.|atlcomcli.h|  
|[CComQIPtr](../VS_csharp/ccomqiptr-class.md)|A smart pointer class for managing COM interface pointers.|atlcomcli.h|  
|[CComQIPtrElementTraits](../VS_csharp/ccomqiptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of COM interface pointers.|atlcoll.h|  
|[CComSafeArray](../VS_csharp/ccomsafearray-class.md)|This class is a wrapper for the `SAFEARRAY Data Type` structure.|atlsafe.h|  
|[CComSafeArrayBound](../VS_csharp/ccomsafearraybound-class.md)|This class is a wrapper for a `SAFEARRAYBOUND` structure.|atlsafe.h|  
|[CComSimpleThreadAllocator](../VS_csharp/ccomsimplethreadallocator-class.md)|This class manages thread selection for the class [CComAutoThreadModule](../VS_csharp/ccomautothreadmodule-class.md).|atlbase.h|  
|[CComSingleThreadModel](../VS_csharp/ccomsinglethreadmodel-class.md)|This class provides methods for incrementing and decrementing the value of a variable.|atlbase.h|  
|[CComTearOffObject](../VS_csharp/ccomtearoffobject-class.md)|This class implements a tear-off interface.|atlcom.h|  
|[CComUnkArray](../VS_csharp/ccomunkarray-class.md)|This class stores **IUnknown** pointers and is designed to be used as a parameter to the [IConnectionPointImpl](../VS_csharp/iconnectionpointimpl-class.md) template class.|atlcom.h|  
|[CComVariant](../VS_csharp/ccomvariant-class.md)|This class wraps the VARIANT type, providing a member indicating the type of data stored.|atlcomcli.h|  
|[CContainedWindowT](../VS_csharp/ccontainedwindowt-class.md)|This class implements a window contained within another object.|atlwin.h|  
|[CCRTAllocator](../VS_csharp/ccrtallocator-class.md)|This class provides methods for managing memory using CRT memory routines.|atlcore.h|  
|[CCRTHeap](../VS_csharp/ccrtheap-class.md)|This class implements [IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md) using the CRT heap functions.|atlmem.h|  
|[CDacl](../VS_csharp/cdacl-class.md)|This class is a wrapper for a DACL (discretionary access-control list) structure.|atlsecurity.h|  
|[CDebugReportHook Class](../VS_csharp/cdebugreporthook-class.md)|Use this class to send debug reports to a named pipe.|atlutil.h|  
|[CDefaultCharTraits](../VS_csharp/cdefaultchartraits-class.md)|This class provides two static functions for converting characters between uppercase and lowercase.|atlcoll.h|  
|[CDefaultCompareTraits](../VS_csharp/cdefaultcomparetraits-class.md)|This class provides default element comparison functions.|atlcoll.h|  
|[CDefaultElementTraits](../VS_csharp/cdefaultelementtraits-class.md)|This class provides default methods and functions for a collection class.|atlcoll.h|  
|[CDefaultHashTraits](../VS_csharp/cdefaulthashtraits-class.md)|This class provides a static function for calculating hash values.|atlcoll.h|  
|[CDialogImpl](../VS_csharp/cdialogimpl-class.md)|This class provides methods for creating a modal or modeless dialog box.|atlwin.h|  
|[CDynamicChain](../VS_csharp/cdynamicchain-class.md)|This class provides methods supporting the dynamic chaining of message maps.|atlwin.h|  
|[CElementTraits](../VS_csharp/celementtraits-class.md)|This class is used by collection classes to provide methods and functions for moving, copying, comparison, and hashing operations.|atlcoll.h|  
|[CElementTraitsBase](../VS_csharp/celementtraitsbase-class.md)|This class provides default copy and move methods for a collection class.|atlcoll.h|  
|[CFirePropNotifyEvent](../VS_csharp/cfirepropnotifyevent-class.md)|This class provides methods for notifying the container's sink regarding control property changes.|atlctl.h|  
|[CGlobalHeap](../VS_csharp/cglobalheap-class.md)|This class implements [IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md) using the Win32 global heap functions.|atlmem.h|  
|[CHandle](../VS_csharp/chandle-class.md)|This class provides methods for creating and using a handle object.|atlbase.h|  
|[CHeapPtr](../VS_csharp/cheapptr-class.md)|A smart pointer class for managing heap pointers.|atlcore.h|  
|[CHeapPtrBase](../VS_csharp/cheapptrbase-class.md)|This class forms the basis for several smart heap pointer classes.|atlcore.h|  
|[CHeapPtrElementTraits Class](../VS_csharp/cheapptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of heap pointers.|atlcoll.h|  
|[CHeapPtrList](../VS_csharp/cheapptrlist-class.md)|This class provides methods useful when constructing a list of heap pointers.|atlcoll.h|  
|[CImage](../VS_csharp/cimage-class.md)|Provides enhanced bitmap support, including the ability to load and save images in JPEG, GIF, BMP, and Portable Network Graphics (PNG) formats.|atlimage.h|  
|[CInterfaceArray](../VS_csharp/cinterfacearray-class.md)|This class provides methods useful when constructing an array of COM interface pointers.|atlcoll.h|  
|[CInterfaceList](../VS_csharp/cinterfacelist-class.md)|This class provides methods useful when constructing a list of COM interface pointers.|atlcoll.h|  
|[CLocalHeap](../VS_csharp/clocalheap-class.md)|This class implements [IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md) using the Win32 local heap functions.|atlmem.h|  
|[CMessageMap](../VS_csharp/cmessagemap-class.md)|This class allows an object's message maps to be accessed by another object.|atlwin.h|  
|[CNonStatelessWorker Class](../VS_csharp/cnonstatelessworker-class.md)|Receives requests from a thread pool and passes them on to a worker object that is created and destroyed on each request.|atlutil.h|  
|[CNoWorkerThread Class](../VS_csharp/cnoworkerthread-class.md)|Use this class as the argument for the `MonitorClass` template parameter cache classes if you want to disable dynamic cache maintenance.|atlutil.h|  
|[CPathT](../VS_csharp/cpatht-class.md)|This class represents a path.|atlpath.h|  
|[CPrimitiveElementTraits](../VS_csharp/cprimitiveelementtraits-class.md)|This class provides default methods and functions for a collection class composed of primitive data types.|atlcoll.h|  
|[CPrivateObjectSecurityDesc](../VS_csharp/cprivateobjectsecuritydesc-class.md)|This class represents a private object security descriptor object.|atlsecurity.h|  
|[CRBMap](../VS_csharp/crbmap-class.md)|This class represents a mapping structure, using a Red-Black binary tree.|atlcoll.h|  
|[CRBMultiMap](../VS_csharp/crbmultimap-class.md)|This class represents a mapping structure that allows each key to be associated with more than one value, using a Red-Black binary tree.|atlcoll.h|  
|[CRBTree](../VS_csharp/crbtree-class.md)|This class provides methods for creating and utilizing a Red-Black tree.|atlcoll.h|  
|[CRegKey](../VS_csharp/cregkey-class.md)|This class provides methods for manipulating entries in the system registry.|atlbase.h|  
|[CRTThreadTraits](../VS_csharp/crtthreadtraits-class.md)|This class provides the creation function for a CRT thread. Use this class if the thread will use CRT functions.|atlbase.h|  
|[CSacl](../VS_csharp/csacl-class.md)|This class is a wrapper for a SACL (system access-control list) structure.|atlsecurity.h|  
|[CSecurityAttributes](../VS_csharp/csecurityattributes-class.md)|This class is a thin wrapper for the **SECURITY_ATTRIBUTES** structure.|atlsecurity.h|  
|[CSecurityDesc](../VS_csharp/csecuritydesc-class.md)|This class is a wrapper for the **SECURITY_DESCRIPTOR** structure.|atlsecurity.h|  
|[CSid](../VS_csharp/csid-class.md)|This class is a wrapper for a `SID` (security identifier) structure.|atlsecurity.h|  
|[CSimpleArray](../VS_csharp/csimplearray-class.md)|This class provides methods for managing a simple array.|atlsimpcoll.h|  
|[CSimpleArrayEqualHelper](../VS_csharp/csimplearrayequalhelper-class.md)|This class is a helper for the [CSimpleArray](../VS_csharp/csimplearray-class.md) class.|atlsimpcoll.h|  
|[CSimpleArrayEqualHelperFalse](../VS_csharp/csimplearrayequalhelperfalse-class.md)|This class is a helper for the [CSimpleArray](../VS_csharp/csimplearray-class.md) class.|atlsimpcoll.h|  
|[CSimpleDialog](../VS_csharp/csimpledialog-class.md)|This class implements a basic modal dialog box.|atlwin.h|  
|[CSimpleMap](../VS_csharp/csimplemap-class.md)|This class provides support for a simple mapping array.|atlsimpcoll.h|  
|[CSimpleMapEqualHelper](../VS_csharp/csimplemapequalhelper-class.md)|This class is a helper for the [CSimpleMap](../VS_csharp/csimplemap-class.md) class.|atlsimpcoll.h|  
|[CSimpleMapEqualHelperFalse](../VS_csharp/csimplemapequalhelperfalse-class.md)|This class is a helper for the [CSimpleMap](../VS_csharp/csimplemap-class.md) class.|atlsimpcoll.h|  
|[CSnapInItemImpl](../VS_csharp/csnapinitemimpl-class.md)|This class provides methods for implementing a snap-in node object.|atlsnap.h|  
|[CSnapInPropertyPageImpl](../VS_csharp/csnapinpropertypageimpl-class.md)|This class provides methods for implementing a snap-in property page object.|atlsnap.h|  
|[CStockPropImpl](../VS_csharp/cstockpropimpl-class.md)|This class provides methods for supporting stock property values.|atlctl.h|  
|[CStringElementTraits](../VS_csharp/cstringelementtraits-class.md)|This class provides static functions used by collection classes storing `CString` objects.|cstringt.h|  
|[CStringElementTraitsI](../VS_csharp/cstringelementtraitsi-class.md)|This class provides static functions related to strings stored in collection class objects. It is similar to [CStringElementTraits](../VS_csharp/cstringelementtraits-class.md), but performs case-insensitive comparisons.|atlcoll.h|  
|[CStringRefElementTraits](../VS_csharp/cstringrefelementtraits-class.md)|This class provides static functions related to strings stored in collection class objects. The string objects are dealt with as references.|atlcoll.h|  
|[CThreadPool Class](../VS_csharp/cthreadpool-class.md)|This class provides a pool of worker threads that process a queue of work items.|atlutil.h|  
|[CTokenGroups](../VS_csharp/ctokengroups-class.md)|This class is a wrapper for the **TOKEN_GROUPS** structure.|atlsecurity.h|  
|[CTokenPrivileges](../VS_csharp/ctokenprivileges-class.md)|This class is a wrapper for the **TOKEN_PRIVILEGES** structure.|atlsecurity.h|  
|[CUrl](../VS_csharp/curl-class.md)|This class represents a URL. It allows you to manipulate each element of the URL independently of the others whether parsing an existing URL string or building a string from scratch.|atlutil.h|  
|[CW2AEX](../VS_csharp/cw2aex-class.md)|This class is used by the string conversion macros `CT2AEX`, `CW2TEX`, `CW2CTEX`, and `CT2CAEX`, and the typedef **CW2A**.|atlconv.h|  
|[CW2CWEX](../VS_csharp/cw2cwex-class.md)|This class is used by the string conversion macros `CW2CTEX` and `CT2CWEX`, and the typedef **CW2CW**.|atlconv.h|  
|[CW2WEX](../VS_csharp/cw2wex-class.md)|This class is used by the string conversion macros `CW2TEX` and `CT2WEX`, and the typedef `CW2W`.|atlconv.h|  
|[CWin32Heap](../VS_csharp/cwin32heap-class.md)|This class implements [IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md) using the Win32 heap allocation functions.|atlmem.h|  
|[CWindow](../VS_csharp/cwindow-class.md)|This class provides methods for manipulating a window.|atlwin.h|  
|[CWindowImpl](../VS_csharp/cwindowimpl-class.md)|This class provides methods for creating or subclassing a window.|atlwin.h|  
|[CWinTraits](../VS_csharp/cwintraits-class.md)|This class provides a method for standardizing the styles used when creating a window object.|atlwin.h|  
|[CWinTraitsOR](../VS_csharp/cwintraitsor-class.md)|This class provides a method for standardizing the styles used when creating a window object.|atlwin.h|  
|[CWndClassInfo](../VS_csharp/cwndclassinfo-class.md)|This class provides methods for registering information for a window class.|atlwin.h|  
|[CWorkerThread Class](../VS_csharp/cworkerthread-class.md)|This class creates a worker thread or uses an existing one, waits on one or more kernel object handles, and executes a specified client function when one of the handles is signaled.|atlutil.h|  
|[IAtlAutoThreadModule](../VS_csharp/iatlautothreadmodule-class.md)|This class represents an interface to a `CreateInstance` method.|atlbase.h|  
|[IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md)|This class represents the interface to a memory manager.|atlmem.h|  
|[IAxWinAmbientDispatch](../VS_csharp/iaxwinambientdispatch-interface.md)|This interface provides methods for specifying characteristics of the hosted control or container.|atlbase.h, ATLIFace.h|  
|[IAxWinAmbientDispatchEx](../VS_csharp/iaxwinambientdispatchex-interface.md)|This interface implements supplemental ambient properties for a hosted control.|atlbase.h, ATLIFace.h|  
|[IAxWinHostWindow](../VS_csharp/iaxwinhostwindow-interface.md)|This interface provides methods for manipulating a control and its host object.|atlbase.h, ATLIFace.h|  
|[IAxWinHostWindowLic](../VS_csharp/iaxwinhostwindowlic-interface.md)|This interface provides methods for manipulating a licensed control and its host object.|atlbase.h, ATLIFace.h|  
|[ICollectionOnSTLImpl](../VS_csharp/icollectiononstlimpl-class.md)|This class provides methods used by a collection class.|atlcom.h|  
|[IConnectionPointContainerImpl](../VS_csharp/iconnectionpointcontainerimpl-class.md)|This class implements a connection point container to manage a collection of [IConnectionPointImpl](../VS_csharp/iconnectionpointimpl-class.md) objects.|atlcom.h|  
|[IConnectionPointImpl](../VS_csharp/iconnectionpointimpl-class.md)|This class implements a connection point.|atlcom.h|  
|[IDataObjectImpl](../VS_csharp/idataobjectimpl-class.md)|This class provides methods for supporting Uniform Data Transfer and managing connections.|atlctl.h|  
|[IDispatchImpl](../VS_csharp/idispatchimpl-class.md)|This class provides a default implementation for the `IDispatch` portion of a dual interface.|atlcom.h|  
|[IDispEventImpl](../VS_csharp/idispeventimpl-class.md)|This class provides implementations of the `IDispatch` methods.|atlcom.h|  
|[IDispEventSimpleImpl](../VS_csharp/idispeventsimpleimpl-class.md)|This class provides implementations of the `IDispatch` methods, without getting type information from a type library.|atlcom.h|  
|[IDocHostUIHandlerDispatch](../VS_csharp/idochostuihandlerdispatch-interface.md)|An interface to the Microsoft HTML parsing and rendering engine.|atlbase.h, ATLIFace.h|  
|[IEnumOnSTLImpl](../VS_csharp/ienumonstlimpl-class.md)|This class defines an enumerator interface based on an STL collection.|atlcom.h|  
|[IObjectSafetyImpl](../VS_csharp/iobjectsafetyimpl-class.md)|This class provides a default implementation of the `IObjectSafety` interface to allow a client to retrieve and set an object's safety levels.|atlctl.h|  
|[IObjectWithSiteImpl](../VS_csharp/iobjectwithsiteimpl-class.md)|This class provides methods allowing an object to communicate with its site.|atlcom.h|  
|[IOleControlImpl](../VS_csharp/iolecontrolimpl-class.md)|This class provides a default implementation of the **IOleControl** interface and implements **IUnknown**.|atlctl.h|  
|[IOleInPlaceActiveObjectImpl](../VS_csharp/ioleinplaceactiveobjectimpl-class.md)|This class provides methods for assisting communication between an in-place control and its container.|atlctl.h|  
|[IOleInPlaceObjectWindowlessImpl](../VS_csharp/ioleinplaceobjectwindowlessimpl-class.md)|This class implements **IUnknown** and provides methods that enable a windowless control to receive window messages and to participate in drag-and-drop operations.|atlctl.h|  
|[IOleObjectImpl](../VS_csharp/ioleobjectimpl-class.md)|This class implements **IUnknown** and is the principal interface through which a container communicates with a control.|atlctl.h|  
|[IPerPropertyBrowsingImpl](../VS_csharp/iperpropertybrowsingimpl-class.md)|This class implements **IUnknown** and allows a client to access the information in an object's property pages.|atlctl.h|  
|[IPersistPropertyBagImpl](../VS_csharp/ipersistpropertybagimpl-class.md)|This class implements **IUnknown** and allows an object to save its properties to a client-supplied property bag.|atlcom.h|  
|[IPersistStorageImpl](../VS_csharp/ipersiststorageimpl-class.md)|This class implements the [IPersistStorage](http://msdn.microsoft.com/library/windows/desktop/ms679731) interface.|atlcom.h|  
|[IPersistStreamInitImpl](../VS_csharp/ipersiststreaminitimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface.|atlcom.h|  
|[IPointerInactiveImpl](../VS_csharp/ipointerinactiveimpl-class.md)|This class implements **IUnknown** and the [IPointerInactive](http://msdn.microsoft.com/library/windows/desktop/ms693712) interface methods.|atlctl.h|  
|[IPropertyNotifySinkCP](../VS_csharp/ipropertynotifysinkcp-class.md)|This class exposes the [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interface as an outgoing interface on a connectable object.|atlctl.h|  
|[IPropertyPage2Impl](../VS_csharp/ipropertypage2impl-class.md)|This class implements **IUnknown** and inherits the default implementation of [IPropertyPageImpl](../VS_csharp/ipropertypageimpl-class.md).|atlctl.h|  
|[IPropertyPageImpl](../VS_csharp/ipropertypageimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [IPropertyPage](http://msdn.microsoft.com/library/windows/desktop/ms691246) interface.|atlctl.h|  
|[IProvideClassInfo2Impl](../VS_csharp/iprovideclassinfo2impl-class.md)|This class provides a default implementation of the [IProvideClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms687303) and [IProvideClassInfo2](http://msdn.microsoft.com/library/windows/desktop/ms693764) methods.|atlcom.h|  
|[IQuickActivateImpl](../VS_csharp/iquickactivateimpl-class.md)|This class combines containers' control initialization into a single call.|atlctl.h|  
|[IRunnableObjectImpl](../VS_csharp/irunnableobjectimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [IRunnableObject](http://msdn.microsoft.com/library/windows/desktop/ms692783) interface.|atlctl.h|  
|[IServiceProviderImpl](../VS_csharp/iserviceproviderimpl-class.md)|This class provides a default implementation of the `IServiceProvider` interface.|atlcom.h|  
|[ISpecifyPropertyPagesImpl](../VS_csharp/ispecifypropertypagesimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [ISpecifyPropertyPages](http://msdn.microsoft.com/library/windows/desktop/ms695217) interface.|atlcom.h|  
|[ISupportErrorInfoImpl](../VS_csharp/isupporterrorinfoimpl-class.md)|This class provides a default implementation of the `ISupportErrorInfo Interface` interface and can be used when only a single interface generates errors on an object.|atlcom.h|  
|[IThreadPoolConfig Interface](../VS_csharp/ithreadpoolconfig-interface.md)|This interface provides methods for configuring a thread pool.|atlutil.h|  
|[IViewObjectExImpl](../VS_csharp/iviewobjecteximpl-class.md)|This class implements **IUnknown** and provides default implementations of the [IViewObject](http://msdn.microsoft.com/library/windows/desktop/ms680763), [IViewObject2](http://msdn.microsoft.com/library/windows/desktop/ms691318), and [IViewObjectEx](http://msdn.microsoft.com/library/windows/desktop/ms682375) interfaces.|atlctl.h|  
|[IWorkerThreadClient Interface](../VS_csharp/iworkerthreadclient-interface.md)|`IWorkerThreadClient` is the interface implemented by clients of the [CWorkerThread](../VS_csharp/cworkerthread-class.md) class.|atlutil.h|  
|[_U_MENUorID](../VS_csharp/_u_menuorid-class.md)|This class provides wrappers for **CreateWindow** and **CreateWindowEx**.|atlwin.h|  
|[_U_RECT](../VS_csharp/_u_rect-class.md)|This argument adapter class allows either `RECT` pointers or references to be passed to a function that is implemented in terms of pointers.|atlwin.h|  
|[_U_STRINGorID](../VS_csharp/_u_stringorid-class.md)|This argument adapter class allows either resource names (`LPCTSTR`s) or resource IDs (**UINT**s) to be passed to a function without requiring the caller to convert the ID to a string using the **MAKEINTRESOURCE** macro.|atlwin.h|  
|[Win32ThreadTraits](../VS_csharp/win32threadtraits-class.md)|This class provides the creation function for a Windows thread. Use this class if the thread will not use CRT functions.|atlbase.h|  
  
## See Also  
 [ATL COM Desktop Components](../VS_csharp/atl-com-desktop-components.md)   
 [Functions](../VS_csharp/atl-functions.md)   
 [Global Variables](../VS_csharp/atl-global-variables.md)   
 [Structures](../VS_csharp/atl-structures.md)   
 [Typedefs](../VS_csharp/atl-typedefs.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)