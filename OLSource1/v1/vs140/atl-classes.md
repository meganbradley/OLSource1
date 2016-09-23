---
title: "ATL Classes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: index-page 
dev_langs: 
  - C++
helpviewer_keywords: 
  - classes [C++], ATL
  - ATL, classes
ms.assetid: 7da42e2d-ac84-4506-92bd-502a86d68bdc
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ATL Classes
The Active Template Library (ATL) includes the following classes. To find a particular class by category, see the [ATL Class Overview](../vs140/atl-class-overview.md).  
  
|Class|Description|Header file|  
|-----------|-----------------|-----------------|  
|[CA2AEX](../vs140/ca2aex-class.md)|This class is used by the string conversion macros `CA2TEX` and `CT2AEX`, and the typedef **CA2A**.|atlconv.h|  
|[CA2CAEX](../vs140/ca2caex-class.md)|This class is used by string conversion macros `CA2CTEX` and `CT2CAEX`, and the typedef **CA2CA**.|atlconv.h|  
|[CA2WEX](../vs140/ca2wex-class.md)|This class is used by the string conversion macros `CA2TEX`, `CA2CTEX`, `CT2WEX`, and `CT2CWEX`, and the typedef **CA2W**.|atlconv.h|  
|[CAccessToken](../vs140/caccesstoken-class.md)|This class is a wrapper for an access token.|atlsecurity.h|  
|[CAcl](../vs140/cacl-class.md)|This class is a wrapper for an **ACL** (access-control list) structure.|atlsecurity.h|  
|[CAdapt](../vs140/cadapt-class.md)|This template is used to wrap classes that redefine the address-of operator to return something other than the address of the object.|atlcomcli.h|  
|[CAtlArray](../vs140/catlarray-class.md)|This class implements an array object.|atlcoll.h|  
|[CAtlAutoThreadModule](../vs140/catlautothreadmodule-class.md)|This class implements a thread-pooled, apartment-model COM server.|atlbase.h|  
|[CAtlAutoThreadModuleT](../vs140/catlautothreadmodulet-class.md)|This class provides methods for implementing a thread-pooled, apartment-model COM server.|atlbase.h|  
|[CAtlBaseModule](../vs140/catlbasemodule-class.md)|This class is instantiated in every ATL project.|atlcore.h|  
|[CAtlComModule](../vs140/catlcommodule-class.md)|This class implements a COM server module.|atlbase.h|  
|[CAtlDebugInterfacesModule](../vs140/catldebuginterfacesmodule-class.md)|This class provides support for debugging interfaces.|atlbase.h|  
|[CAtlDllModuleT](../vs140/catldllmodulet-class.md)|This class represents the module for a DLL.|atlbase.h|  
|[CAtlException](../vs140/catlexception-class.md)|This class defines an ATL exception.|atlexcept.h|  
|[CAtlExeModuleT](../vs140/catlexemodulet-class.md)|This class represents the module for an application.|atlbase.h|  
|[CAtlFile](../vs140/catlfile-class.md)|This class provides a thin wrapper around the Windows file-handling API.|atlfile.h|  
|[CAtlFileMapping](../vs140/catlfilemapping-class.md)|This class represents a memory-mapped file, adding a cast operator to the methods of [CAtlFileMappingBase](../vs140/catlfilemappingbase-class.md).|atlfile.h|  
|[CAtlFileMappingBase](../vs140/catlfilemappingbase-class.md)|This class represents a memory-mapped file.|atlfile.h|  
|[CAtlList](../vs140/catllist-class.md)|This class provides methods for creating and managing a list object.|atlcoll.h|  
|[CAtlMap](../vs140/catlmap-class.md)|This class provides methods for creating and managing a map object.|atlcoll.h|  
|[CAtlModule](../vs140/catlmodule-class.md)|This class provides methods used by several ATL module classes.|atlbase.h|  
|[CAtlModuleT](../vs140/catlmodulet-class.md)|This class implements an ATL module.|atlbase.h|  
|[CAtlPreviewCtrlImpl](../vs140/catlpreviewctrlimpl-class.md)|This class is an ATL implementation of a window that is placed on a host window provided by the Shell for Rich Preview.|atlpreviewctrlimpl.h|  
|[CAtlServiceModuleT](../vs140/catlservicemodulet-class.md)|This class implements a service.|atlbase.h|  
|[CAtlTemporaryFile](../vs140/catltemporaryfile-class.md)|This class provides methods for the creation and use of a temporary file.|atlfile.h|  
|[CAtlTransactionManager](../vs140/catltransactionmanager-class.md)|This class provides a wrapper to Kernel Transaction Manager (KTM) functions.|atltransactionmanager.h|  
|[CAtlWinModule](../vs140/catlwinmodule-class.md)|This class provides support for ATL windowing components.|atlbase.h|  
|[CAutoPtr](../vs140/cautoptr-class.md)|This class represents a smart pointer object.|atlbase.h|  
|[CAutoPtrArray](../vs140/cautoptrarray-class.md)|This class provides methods useful when constructing an array of smart pointers.|atlbase.h|  
|[CAutoPtrElementTraits](../vs140/cautoptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of smart pointers.|atlcoll.h|  
|[CAutoPtrList](../vs140/cautoptrlist-class.md)|This class provides methods useful when constructing a list of smart pointers.|atlcoll.h|  
|[CAutoVectorPtr](../vs140/cautovectorptr-class.md)|This class represents a smart pointer object using vector new and delete operators.|atlbase.h|  
|[CAutoVectorPtrElementTraits](../vs140/cautovectorptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of smart pointers using vector new and delete operators.|atlcoll.h|  
|[CAxDialogImpl](../vs140/caxdialogimpl-class.md)|This class implements a dialog box (modal or modeless) that hosts ActiveX controls.|atlwin.h|  
|[CAxWindow](../vs140/caxwindow-class.md)|This class provides methods for manipulating a window hosting an ActiveX control.|atlwin.h|  
|[CAxWindow2T](../vs140/caxwindow2t-class.md)|This class provides methods for manipulating a window that hosts an ActiveX control and also has support for hosting licensed ActiveX controls.|atlwin.h|  
|[CBindStatusCallback](../vs140/cbindstatuscallback-class.md)|This class implements the `IBindStatusCallback` interface.|atlctl.h|  
|[CComAggObject](../vs140/ccomaggobject-class.md)|This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for an aggregated object.|atlcom.h|  
|[CComAllocator](../vs140/ccomallocator-class.md)|This class provides methods for managing memory using COM memory routines.|atlbase.h|  
|[CComApartment](../vs140/ccomapartment-class.md)|This class provides support for managing an apartment in a thread-pooled EXE module.|atlbase.h|  
|[CComAutoCriticalSection](../vs140/ccomautocriticalsection-class.md)|This class provides methods for obtaining and releasing ownership of a critical section object.|atlcore.h|  
|[CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md)|As of ATL 7.0, `CComAutoThreadModule` is obsolete: see [ATL Modules](../vs140/atl-module-classes.md) for more details.|atlbase.h|  
|[CComBSTR](../vs140/ccombstr-class.md)|This class is a wrapper for `BSTR`s.|atlbase.h|  
|[CComCachedTearOffObject](../vs140/ccomcachedtearoffobject-class.md)|This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for a tear-off interface.|atlcom.h|  
|[CComClassFactory](../vs140/ccomclassfactory-class.md)|This class implements the [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364) interface.|atlcom.h|  
|[CComClassFactory2](../vs140/ccomclassfactory2-class.md)|This class implements the [IClassFactory2](http://msdn.microsoft.com/library/windows/desktop/ms692720) interface.|atlcom.h|  
|[CComClassFactoryAutoThread](../vs140/ccomclassfactoryautothread-class.md)|This class implements the [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364) interface and allows objects to be created in multiple apartments.|atlcom.h|  
|[CComClassFactorySingleton](../vs140/ccomclassfactorysingleton-class.md)|This class derives from [CComClassFactory](../vs140/ccomclassfactory-class.md) and uses [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) to construct a single object.|atlcom.h|  
|[CComCoClass](../vs140/ccomcoclass-class.md)|This class provides methods for creating instances of a class and obtaining its properties.|atlcom.h|  
|[CComCompositeControl](../vs140/ccomcompositecontrol-class.md)|This class provides the methods required to implement a composite control.|atlctl.h|  
|[CComContainedObject](../vs140/ccomcontainedobject-class.md)|This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) by delegating to the owner object's **IUnknown**.|atlcom.h|  
|[CComControl](../vs140/ccomcontrol-class.md)|This class provides methods for creating and managing ATL controls.|atlctl.h|  
|[CComControlBase](../vs140/ccomcontrolbase-class.md)|This class provides methods for creating and managing ATL controls.|atlctl.h|  
|[CComCriticalSection](../vs140/ccomcriticalsection-class.md)|This class provides methods for obtaining and releasing ownership of a critical section object.|atlcore.h|  
|[CComCritSecLock](../vs140/ccomcritseclock-class.md)|This class provides methods for locking and unlocking a critical section object.|atlbase.h|  
|[CComCurrency](../vs140/ccomcurrency-class.md)|This class has methods and operators for creating and managing a `CURRENCY` object.|atlcur.h|  
|[CComDynamicUnkArray](../vs140/ccomdynamicunkarray-class.md)|This class stores an array of **IUnknown** pointers.|atlcom.h|  
|[CComEnum](../vs140/ccomenum-class.md)|This class defines a COM enumerator object based on an array.|atlcom.h|  
|[CComEnumImpl](../vs140/ccomenumimpl-class.md)|This class provides the implementation for a COM enumerator interface where the items being enumerated are stored in an array.|atlcom.h|  
|[CComEnumOnSTL](../vs140/ccomenumonstl-class.md)|This class defines a COM enumerator object based on an STL collection.|atlcom.h|  
|[CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md)|This class provides the same methods as [CComCriticalSection](../vs140/ccomcriticalsection-class.md) but does not provide a critical section.|atlcore.h|  
|[CComGITPtr](../vs140/ccomgitptr-class.md)|This class provides methods for dealing with interface pointers and the global interface table (GIT).|atlbase.h|  
|[CComHeap](../vs140/ccomheap-class.md)|This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the COM memory allocation functions.|ATLComMem.h|  
|[CComHeapPtr](../vs140/ccomheapptr-class.md)|A smart pointer class for managing heap pointers.|atlbase.h|  
|[CComModule](../vs140/ccommodule-class.md)|As of ATL 7.0, `CComModule` is obsolete: see [ATL Modules](../vs140/atl-module-classes.md) for more details.|atlbase.h|  
|[CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md)|This class provides thread-safe methods for incrementing and decrementing the value of a variable.|atlbase.h|  
|[CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md)|This class provides thread-safe methods for incrementing and decrementing the value of a variable, without critical section locking or unlocking functionality.|atlbase.h|  
|[CComObject](../vs140/ccomobject-class.md)|This class implements **IUnknown** for a nonaggregated object.|atlcom.h|  
|[CComObjectGlobal](../vs140/ccomobjectglobal-class.md)|This class manages a reference count on the module containing your `Base` object.|atlcom.h|  
|[CComObjectNoLock](../vs140/ccomobjectnolock-class.md)|This class implements **IUnknown** for a nonaggregated object, but does not increment the module lock count in the constructor.|atlcom.h|  
|[CComObjectRoot](../vs140/ccomobjectroot-class.md)|This typedef of [CComObjectRootEx](../vs140/ccomobjectrootex-class.md) is templatized on the default threading model of the server.|atlcom.h|  
|[CComObjectRootEx](../vs140/ccomobjectrootex-class.md)|This class provides methods to handle object reference count management for both nonaggregated and aggregated objects.|atlcom.h|  
|[CComObjectStack](../vs140/ccomobjectstack-class.md)|This class creates a temporary COM object and provides it with a skeletal implementation of **IUnknown**.|atlcom.h|  
|[CComPolyObject](../vs140/ccompolyobject-class.md)|This class implements **IUnknown** for an aggregated or nonaggregated object.|atlcom.h|  
|[CComPtr](../vs140/ccomptr-class.md)|A smart pointer class for managing COM interface pointers.|atlcomcli.h|  
|[CComPtrBase](../vs140/ccomptrbase-class.md)|This class provides a basis for smart pointer classes using COM-based memory routines.|atlcomcli.h|  
|[CComQIPtr](../vs140/ccomqiptr-class.md)|A smart pointer class for managing COM interface pointers.|atlcomcli.h|  
|[CComQIPtrElementTraits](../vs140/ccomqiptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of COM interface pointers.|atlcoll.h|  
|[CComSafeArray](../vs140/ccomsafearray-class.md)|This class is a wrapper for the `SAFEARRAY Data Type` structure.|atlsafe.h|  
|[CComSafeArrayBound](../vs140/ccomsafearraybound-class.md)|This class is a wrapper for a `SAFEARRAYBOUND` structure.|atlsafe.h|  
|[CComSimpleThreadAllocator](../vs140/ccomsimplethreadallocator-class.md)|This class manages thread selection for the class [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md).|atlbase.h|  
|[CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md)|This class provides methods for incrementing and decrementing the value of a variable.|atlbase.h|  
|[CComTearOffObject](../vs140/ccomtearoffobject-class.md)|This class implements a tear-off interface.|atlcom.h|  
|[CComUnkArray](../vs140/ccomunkarray-class.md)|This class stores **IUnknown** pointers and is designed to be used as a parameter to the [IConnectionPointImpl](../vs140/iconnectionpointimpl-class.md) template class.|atlcom.h|  
|[CComVariant](../vs140/ccomvariant-class.md)|This class wraps the VARIANT type, providing a member indicating the type of data stored.|atlcomcli.h|  
|[CContainedWindowT](../vs140/ccontainedwindowt-class.md)|This class implements a window contained within another object.|atlwin.h|  
|[CCRTAllocator](../vs140/ccrtallocator-class.md)|This class provides methods for managing memory using CRT memory routines.|atlcore.h|  
|[CCRTHeap](../vs140/ccrtheap-class.md)|This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the CRT heap functions.|atlmem.h|  
|[CDacl](../vs140/cdacl-class.md)|This class is a wrapper for a DACL (discretionary access-control list) structure.|atlsecurity.h|  
|[CDebugReportHook Class](../vs140/cdebugreporthook-class.md)|Use this class to send debug reports to a named pipe.|atlutil.h|  
|[CDefaultCharTraits](../vs140/cdefaultchartraits-class.md)|This class provides two static functions for converting characters between uppercase and lowercase.|atlcoll.h|  
|[CDefaultCompareTraits](../vs140/cdefaultcomparetraits-class.md)|This class provides default element comparison functions.|atlcoll.h|  
|[CDefaultElementTraits](../vs140/cdefaultelementtraits-class.md)|This class provides default methods and functions for a collection class.|atlcoll.h|  
|[CDefaultHashTraits](../vs140/cdefaulthashtraits-class.md)|This class provides a static function for calculating hash values.|atlcoll.h|  
|[CDialogImpl](../vs140/cdialogimpl-class.md)|This class provides methods for creating a modal or modeless dialog box.|atlwin.h|  
|[CDynamicChain](../vs140/cdynamicchain-class.md)|This class provides methods supporting the dynamic chaining of message maps.|atlwin.h|  
|[CElementTraits](../vs140/celementtraits-class.md)|This class is used by collection classes to provide methods and functions for moving, copying, comparison, and hashing operations.|atlcoll.h|  
|[CElementTraitsBase](../vs140/celementtraitsbase-class.md)|This class provides default copy and move methods for a collection class.|atlcoll.h|  
|[CFirePropNotifyEvent](../vs140/cfirepropnotifyevent-class.md)|This class provides methods for notifying the container's sink regarding control property changes.|atlctl.h|  
|[CGlobalHeap](../vs140/cglobalheap-class.md)|This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the Win32 global heap functions.|atlmem.h|  
|[CHandle](../vs140/chandle-class.md)|This class provides methods for creating and using a handle object.|atlbase.h|  
|[CHeapPtr](../vs140/cheapptr-class.md)|A smart pointer class for managing heap pointers.|atlcore.h|  
|[CHeapPtrBase](../vs140/cheapptrbase-class.md)|This class forms the basis for several smart heap pointer classes.|atlcore.h|  
|[CHeapPtrElementTraits Class](../vs140/cheapptrelementtraits-class.md)|This class provides methods, static functions, and typedefs useful when creating collections of heap pointers.|atlcoll.h|  
|[CHeapPtrList](../vs140/cheapptrlist-class.md)|This class provides methods useful when constructing a list of heap pointers.|atlcoll.h|  
|[CImage](../vs140/cimage-class.md)|Provides enhanced bitmap support, including the ability to load and save images in JPEG, GIF, BMP, and Portable Network Graphics (PNG) formats.|atlimage.h|  
|[CInterfaceArray](../vs140/cinterfacearray-class.md)|This class provides methods useful when constructing an array of COM interface pointers.|atlcoll.h|  
|[CInterfaceList](../vs140/cinterfacelist-class.md)|This class provides methods useful when constructing a list of COM interface pointers.|atlcoll.h|  
|[CLocalHeap](../vs140/clocalheap-class.md)|This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the Win32 local heap functions.|atlmem.h|  
|[CMessageMap](../vs140/cmessagemap-class.md)|This class allows an object's message maps to be accessed by another object.|atlwin.h|  
|[CNonStatelessWorker Class](../vs140/cnonstatelessworker-class.md)|Receives requests from a thread pool and passes them on to a worker object that is created and destroyed on each request.|atlutil.h|  
|[CNoWorkerThread Class](../vs140/cnoworkerthread-class.md)|Use this class as the argument for the `MonitorClass` template parameter cache classes if you want to disable dynamic cache maintenance.|atlutil.h|  
|[CPathT](../vs140/cpatht-class.md)|This class represents a path.|atlpath.h|  
|[CPrimitiveElementTraits](../vs140/cprimitiveelementtraits-class.md)|This class provides default methods and functions for a collection class composed of primitive data types.|atlcoll.h|  
|[CPrivateObjectSecurityDesc](../vs140/cprivateobjectsecuritydesc-class.md)|This class represents a private object security descriptor object.|atlsecurity.h|  
|[CRBMap](../vs140/crbmap-class.md)|This class represents a mapping structure, using a Red-Black binary tree.|atlcoll.h|  
|[CRBMultiMap](../vs140/crbmultimap-class.md)|This class represents a mapping structure that allows each key to be associated with more than one value, using a Red-Black binary tree.|atlcoll.h|  
|[CRBTree](../vs140/crbtree-class.md)|This class provides methods for creating and utilizing a Red-Black tree.|atlcoll.h|  
|[CRegKey](../vs140/cregkey-class.md)|This class provides methods for manipulating entries in the system registry.|atlbase.h|  
|[CRTThreadTraits](../vs140/crtthreadtraits-class.md)|This class provides the creation function for a CRT thread. Use this class if the thread will use CRT functions.|atlbase.h|  
|[CSacl](../vs140/csacl-class.md)|This class is a wrapper for a SACL (system access-control list) structure.|atlsecurity.h|  
|[CSecurityAttributes](../vs140/csecurityattributes-class.md)|This class is a thin wrapper for the **SECURITY_ATTRIBUTES** structure.|atlsecurity.h|  
|[CSecurityDesc](../vs140/csecuritydesc-class.md)|This class is a wrapper for the **SECURITY_DESCRIPTOR** structure.|atlsecurity.h|  
|[CSid](../vs140/csid-class.md)|This class is a wrapper for a `SID` (security identifier) structure.|atlsecurity.h|  
|[CSimpleArray](../vs140/csimplearray-class.md)|This class provides methods for managing a simple array.|atlsimpcoll.h|  
|[CSimpleArrayEqualHelper](../vs140/csimplearrayequalhelper-class.md)|This class is a helper for the [CSimpleArray](../vs140/csimplearray-class.md) class.|atlsimpcoll.h|  
|[CSimpleArrayEqualHelperFalse](../vs140/csimplearrayequalhelperfalse-class.md)|This class is a helper for the [CSimpleArray](../vs140/csimplearray-class.md) class.|atlsimpcoll.h|  
|[CSimpleDialog](../vs140/csimpledialog-class.md)|This class implements a basic modal dialog box.|atlwin.h|  
|[CSimpleMap](../vs140/csimplemap-class.md)|This class provides support for a simple mapping array.|atlsimpcoll.h|  
|[CSimpleMapEqualHelper](../vs140/csimplemapequalhelper-class.md)|This class is a helper for the [CSimpleMap](../vs140/csimplemap-class.md) class.|atlsimpcoll.h|  
|[CSimpleMapEqualHelperFalse](../vs140/csimplemapequalhelperfalse-class.md)|This class is a helper for the [CSimpleMap](../vs140/csimplemap-class.md) class.|atlsimpcoll.h|  
|[CSnapInItemImpl](../vs140/csnapinitemimpl-class.md)|This class provides methods for implementing a snap-in node object.|atlsnap.h|  
|[CSnapInPropertyPageImpl](../vs140/csnapinpropertypageimpl-class.md)|This class provides methods for implementing a snap-in property page object.|atlsnap.h|  
|[CStockPropImpl](../vs140/cstockpropimpl-class.md)|This class provides methods for supporting stock property values.|atlctl.h|  
|[CStringElementTraits](../vs140/cstringelementtraits-class.md)|This class provides static functions used by collection classes storing `CString` objects.|cstringt.h|  
|[CStringElementTraitsI](../vs140/cstringelementtraitsi-class.md)|This class provides static functions related to strings stored in collection class objects. It is similar to [CStringElementTraits](../vs140/cstringelementtraits-class.md), but performs case-insensitive comparisons.|atlcoll.h|  
|[CStringRefElementTraits](../vs140/cstringrefelementtraits-class.md)|This class provides static functions related to strings stored in collection class objects. The string objects are dealt with as references.|atlcoll.h|  
|[CThreadPool Class](../vs140/cthreadpool-class.md)|This class provides a pool of worker threads that process a queue of work items.|atlutil.h|  
|[CTokenGroups](../vs140/ctokengroups-class.md)|This class is a wrapper for the **TOKEN_GROUPS** structure.|atlsecurity.h|  
|[CTokenPrivileges](../vs140/ctokenprivileges-class.md)|This class is a wrapper for the **TOKEN_PRIVILEGES** structure.|atlsecurity.h|  
|[CUrl](../vs140/curl-class.md)|This class represents a URL. It allows you to manipulate each element of the URL independently of the others whether parsing an existing URL string or building a string from scratch.|atlutil.h|  
|[CW2AEX](../vs140/cw2aex-class.md)|This class is used by the string conversion macros `CT2AEX`, `CW2TEX`, `CW2CTEX`, and `CT2CAEX`, and the typedef **CW2A**.|atlconv.h|  
|[CW2CWEX](../vs140/cw2cwex-class.md)|This class is used by the string conversion macros `CW2CTEX` and `CT2CWEX`, and the typedef **CW2CW**.|atlconv.h|  
|[CW2WEX](../vs140/cw2wex-class.md)|This class is used by the string conversion macros `CW2TEX` and `CT2WEX`, and the typedef `CW2W`.|atlconv.h|  
|[CWin32Heap](../vs140/cwin32heap-class.md)|This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the Win32 heap allocation functions.|atlmem.h|  
|[CWindow](../vs140/cwindow-class.md)|This class provides methods for manipulating a window.|atlwin.h|  
|[CWindowImpl](../vs140/cwindowimpl-class.md)|This class provides methods for creating or subclassing a window.|atlwin.h|  
|[CWinTraits](../vs140/cwintraits-class.md)|This class provides a method for standardizing the styles used when creating a window object.|atlwin.h|  
|[CWinTraitsOR](../vs140/cwintraitsor-class.md)|This class provides a method for standardizing the styles used when creating a window object.|atlwin.h|  
|[CWndClassInfo](../vs140/cwndclassinfo-class.md)|This class provides methods for registering information for a window class.|atlwin.h|  
|[CWorkerThread Class](../vs140/cworkerthread-class.md)|This class creates a worker thread or uses an existing one, waits on one or more kernel object handles, and executes a specified client function when one of the handles is signaled.|atlutil.h|  
|[IAtlAutoThreadModule](../vs140/iatlautothreadmodule-class.md)|This class represents an interface to a `CreateInstance` method.|atlbase.h|  
|[IAtlMemMgr](../vs140/iatlmemmgr-class.md)|This class represents the interface to a memory manager.|atlmem.h|  
|[IAxWinAmbientDispatch](../vs140/iaxwinambientdispatch-interface.md)|This interface provides methods for specifying characteristics of the hosted control or container.|atlbase.h, ATLIFace.h|  
|[IAxWinAmbientDispatchEx](../vs140/iaxwinambientdispatchex-interface.md)|This interface implements supplemental ambient properties for a hosted control.|atlbase.h, ATLIFace.h|  
|[IAxWinHostWindow](../vs140/iaxwinhostwindow-interface.md)|This interface provides methods for manipulating a control and its host object.|atlbase.h, ATLIFace.h|  
|[IAxWinHostWindowLic](../vs140/iaxwinhostwindowlic-interface.md)|This interface provides methods for manipulating a licensed control and its host object.|atlbase.h, ATLIFace.h|  
|[ICollectionOnSTLImpl](../vs140/icollectiononstlimpl-class.md)|This class provides methods used by a collection class.|atlcom.h|  
|[IConnectionPointContainerImpl](../vs140/iconnectionpointcontainerimpl-class.md)|This class implements a connection point container to manage a collection of [IConnectionPointImpl](../vs140/iconnectionpointimpl-class.md) objects.|atlcom.h|  
|[IConnectionPointImpl](../vs140/iconnectionpointimpl-class.md)|This class implements a connection point.|atlcom.h|  
|[IDataObjectImpl](../vs140/idataobjectimpl-class.md)|This class provides methods for supporting Uniform Data Transfer and managing connections.|atlctl.h|  
|[IDispatchImpl](../vs140/idispatchimpl-class.md)|This class provides a default implementation for the `IDispatch` portion of a dual interface.|atlcom.h|  
|[IDispEventImpl](../vs140/idispeventimpl-class.md)|This class provides implementations of the `IDispatch` methods.|atlcom.h|  
|[IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md)|This class provides implementations of the `IDispatch` methods, without getting type information from a type library.|atlcom.h|  
|[IDocHostUIHandlerDispatch](../vs140/idochostuihandlerdispatch-interface.md)|An interface to the Microsoft HTML parsing and rendering engine.|atlbase.h, ATLIFace.h|  
|[IEnumOnSTLImpl](../vs140/ienumonstlimpl-class.md)|This class defines an enumerator interface based on an STL collection.|atlcom.h|  
|[IObjectSafetyImpl](../vs140/iobjectsafetyimpl-class.md)|This class provides a default implementation of the `IObjectSafety` interface to allow a client to retrieve and set an object's safety levels.|atlctl.h|  
|[IObjectWithSiteImpl](../vs140/iobjectwithsiteimpl-class.md)|This class provides methods allowing an object to communicate with its site.|atlcom.h|  
|[IOleControlImpl](../vs140/iolecontrolimpl-class.md)|This class provides a default implementation of the **IOleControl** interface and implements **IUnknown**.|atlctl.h|  
|[IOleInPlaceActiveObjectImpl](../vs140/ioleinplaceactiveobjectimpl-class.md)|This class provides methods for assisting communication between an in-place control and its container.|atlctl.h|  
|[IOleInPlaceObjectWindowlessImpl](../vs140/ioleinplaceobjectwindowlessimpl-class.md)|This class implements **IUnknown** and provides methods that enable a windowless control to receive window messages and to participate in drag-and-drop operations.|atlctl.h|  
|[IOleObjectImpl](../vs140/ioleobjectimpl-class.md)|This class implements **IUnknown** and is the principal interface through which a container communicates with a control.|atlctl.h|  
|[IPerPropertyBrowsingImpl](../vs140/iperpropertybrowsingimpl-class.md)|This class implements **IUnknown** and allows a client to access the information in an object's property pages.|atlctl.h|  
|[IPersistPropertyBagImpl](../vs140/ipersistpropertybagimpl-class.md)|This class implements **IUnknown** and allows an object to save its properties to a client-supplied property bag.|atlcom.h|  
|[IPersistStorageImpl](../vs140/ipersiststorageimpl-class.md)|This class implements the [IPersistStorage](http://msdn.microsoft.com/library/windows/desktop/ms679731) interface.|atlcom.h|  
|[IPersistStreamInitImpl](../vs140/ipersiststreaminitimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface.|atlcom.h|  
|[IPointerInactiveImpl](../vs140/ipointerinactiveimpl-class.md)|This class implements **IUnknown** and the [IPointerInactive](http://msdn.microsoft.com/library/windows/desktop/ms693712) interface methods.|atlctl.h|  
|[IPropertyNotifySinkCP](../vs140/ipropertynotifysinkcp-class.md)|This class exposes the [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interface as an outgoing interface on a connectable object.|atlctl.h|  
|[IPropertyPage2Impl](../vs140/ipropertypage2impl-class.md)|This class implements **IUnknown** and inherits the default implementation of [IPropertyPageImpl](../vs140/ipropertypageimpl-class.md).|atlctl.h|  
|[IPropertyPageImpl](../vs140/ipropertypageimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [IPropertyPage](http://msdn.microsoft.com/library/windows/desktop/ms691246) interface.|atlctl.h|  
|[IProvideClassInfo2Impl](../vs140/iprovideclassinfo2impl-class.md)|This class provides a default implementation of the [IProvideClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms687303) and [IProvideClassInfo2](http://msdn.microsoft.com/library/windows/desktop/ms693764) methods.|atlcom.h|  
|[IQuickActivateImpl](../vs140/iquickactivateimpl-class.md)|This class combines containers' control initialization into a single call.|atlctl.h|  
|[IRunnableObjectImpl](../vs140/irunnableobjectimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [IRunnableObject](http://msdn.microsoft.com/library/windows/desktop/ms692783) interface.|atlctl.h|  
|[IServiceProviderImpl](../vs140/iserviceproviderimpl-class.md)|This class provides a default implementation of the `IServiceProvider` interface.|atlcom.h|  
|[ISpecifyPropertyPagesImpl](../vs140/ispecifypropertypagesimpl-class.md)|This class implements **IUnknown** and provides a default implementation of the [ISpecifyPropertyPages](http://msdn.microsoft.com/library/windows/desktop/ms695217) interface.|atlcom.h|  
|[ISupportErrorInfoImpl](../vs140/isupporterrorinfoimpl-class.md)|This class provides a default implementation of the `ISupportErrorInfo Interface` interface and can be used when only a single interface generates errors on an object.|atlcom.h|  
|[IThreadPoolConfig Interface](../vs140/ithreadpoolconfig-interface.md)|This interface provides methods for configuring a thread pool.|atlutil.h|  
|[IViewObjectExImpl](../vs140/iviewobjecteximpl-class.md)|This class implements **IUnknown** and provides default implementations of the [IViewObject](http://msdn.microsoft.com/library/windows/desktop/ms680763), [IViewObject2](http://msdn.microsoft.com/library/windows/desktop/ms691318), and [IViewObjectEx](http://msdn.microsoft.com/library/windows/desktop/ms682375) interfaces.|atlctl.h|  
|[IWorkerThreadClient Interface](../vs140/iworkerthreadclient-interface.md)|`IWorkerThreadClient` is the interface implemented by clients of the [CWorkerThread](../vs140/cworkerthread-class.md) class.|atlutil.h|  
|[_U_MENUorID](../vs140/_u_menuorid-class.md)|This class provides wrappers for **CreateWindow** and **CreateWindowEx**.|atlwin.h|  
|[_U_RECT](../vs140/_u_rect-class.md)|This argument adapter class allows either `RECT` pointers or references to be passed to a function that is implemented in terms of pointers.|atlwin.h|  
|[_U_STRINGorID](../vs140/_u_stringorid-class.md)|This argument adapter class allows either resource names (`LPCTSTR`s) or resource IDs (**UINT**s) to be passed to a function without requiring the caller to convert the ID to a string using the **MAKEINTRESOURCE** macro.|atlwin.h|  
|[Win32ThreadTraits](../vs140/win32threadtraits-class.md)|This class provides the creation function for a Windows thread. Use this class if the thread will not use CRT functions.|atlbase.h|  
  
## See Also  
 [ATL COM Desktop Components](../vs140/atl-com-desktop-components.md)   
 [Functions](../vs140/atl-functions.md)   
 [Global Variables](../vs140/atl-global-variables.md)   
 [Structures](../vs140/atl-structures.md)   
 [Typedefs](../vs140/atl-typedefs.md)   
 [Class Overview](../vs140/atl-class-overview.md)