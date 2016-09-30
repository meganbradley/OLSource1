---
title: "TN038: MFC-OLE IUnknown Implementation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "TN038: MFC/OLE IUnknown Implementation"
f1_keywords: 
  - "vc.mfc.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregation macros [C++]"
  - "COM interfaces, base interface"
  - "IUnknown interface"
  - "END_INTERFACE_MAP macro"
  - "TN038"
  - "BEGIN_INTERFACE_PART macro"
  - "DECLARE_INTERFACE_MAP macro"
  - "BEGIN_INTERFACE_MAP macro"
  - "OLE [C++], implementing IUnknown interface"
  - "METHOD_PROLOGUE macro"
  - "STDMETHOD macro"
  - "END_INTERFACE_PART macro"
  - "INTERFACE_PART macro"
ms.assetid: 19d946ba-beaf-4881-85c6-0b598d7f6f11
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN038: MFC-OLE IUnknown Implementation
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 At the heart of OLE 2 is the "OLE Component Object Model", or COM. COM defines a standard for how cooperating objects communicate to one another. This includes the details of what an "object" looks like, including how methods are dispatched on an object. COM also defines a base class, from which all COM compatible classes are derived. This base class is [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509). Although the [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) interface is referred to as a C++ class, COM is not specific to any one language — it can be implemented in C, PASCAL, or any other language that can support the binary layout of a COM object.  
  
 OLE refers to all classes derived from [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) as "interfaces." This is an important distinction, since an "interface" such as [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) carries with it no implementation. It simply defines the protocol by which objects communicate, not the specifics of what those implementations do. This is reasonable for a system that allows for maximum flexibility. It is MFC's job to implement a default behavior for MFC/C++ programs.  
  
 To understand MFC's implementation of [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) you must first understand what this interface is. A simplified version of [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) is defined below:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  Certain necessary calling convention details, such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are left out for this illustration.  
  
 The [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) and [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) member functions control memory management of the object. COM uses a reference counting scheme to keep track of objects. An object is never referenced directly as you would in C++. Instead, COM objects are always referenced through a pointer. To release the object when the owner is done using it, the object's [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) member is called (as opposed to using operator delete, as would be done for a traditional C++ object). The reference counting mechanism allows for multiple references to a single object to be managed. An implementation of [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) and [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) maintains a reference count on the object — the object is not deleted until its reference count reaches zero.  
  
 [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) and [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) are fairly straightforward from an implementation standpoint. Here is a trivial implementation:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) member function is a little more interesting. It is not very interesting to have an object whose only member functions are [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) and [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) — it would be nice to tell the object to do more things than [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) provides. This is where [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) is useful. It allows you to obtain a different "interface" on the same object. These interfaces are usually derived from [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) and add additional functionality by adding new member functions. COM interfaces never have member variables declared in the interface, and all member functions are declared as pure-virtual. For example,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To get an IPrintInterface if you only have an [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509), call [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) using the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> of the **IPrintInterface**. An <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a 128-bit number that uniquely identifies the interface. There is an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for each interface that either you or OLE define. If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is a pointer to an [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) object, the code to retrieve an IPrintInterface from it might be:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 That seems fairly easy, but how would you implement an object supporting both the IPrintInterface and [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) interface? In this case it is simple since the IPrintInterface is derived directly from [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) — by implementing IPrintInterface, [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) is automatically supported. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The implementations of [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) and [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) would be exactly the same as those implemented above. **CPrintObj::QueryInterface** would look something like this:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 As you can see, if the interface identifier (IID) is recognized, a pointer is returned to your object; otherwise an error occurs. Also note that a successful [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) results in an implied [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379). Of course, you'd also have to implement CEditObj::Print. That is simple because the IPrintInterface was directly derived from the [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) interface. However, if you wanted to support two different interfaces, both derived from [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509), consider the following:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Although there are a number of different ways to implement a class supporting both IEditInterface and IPrintInterface, including using C++ multiple inheritance, this note will concentrate on the use of nested classes to implement this functionality.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The entire implementation is included below:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Notice that most of the [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) implementation is placed into the CEditPrintObj class rather than duplicating the code in CEditPrintObj::CEditObj and CEditPrintObj::CPrintObj. This reduces the amount of code and avoids bugs. The key point here is that from the IUnknown interface it is possible to call [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) to retrieve any interface the object might support, and from each of those interfaces it is possible to do the same. This means that all [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) functions available from each interface must behave exactly the same way. In order for these embedded objects to call the implementation in the "outer object", a back-pointer is used (m_pParent). The m_pParent pointer is initialized during the CEditPrintObj constructor. Then you would implement CEditPrintObj::CPrintObj::PrintObject and CEditPrintObj::CEditObj::EditObject as well. Quite a bit of code was added to add one feature — the ability to edit the object. Fortunately, it is quite uncommon for interfaces to have only a single member function (although it does happen) and in this case, EditObject and PrintObject would usually be combined into a single interface.  
  
 That's a lot of explanation and a lot of code for such a simple scenario. The MFC/OLE classes provide a simpler alternative. The MFC implementation uses a technique similar to the way Windows messages are wrapped with Message Maps. This facility is called *Interface Maps* and is discussed in the next section.  
  
## MFC Interface Maps  
 MFC/OLE includes an implementation of "Interface Maps" similar to MFC's "Message Maps" and "Dispatch Maps" in concept and execution. The core features of MFC's Interface Maps are as follows:  
  
-   A standard implementation of [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509), built into the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class.  
  
-   Maintenance of the reference count, modified by [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) and [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317)  
  
-   Data driven implementation of [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521)  
  
 In addition, interface maps support the following advanced features:  
  
-   Support for creating aggregatable COM objects  
  
-   Support for using aggregate objects in the implementation of a COM object  
  
-   The implementation is hookable and extensible  
  
 For more information on aggregation, see the [Aggregation](http://msdn.microsoft.com/library/windows/desktop/ms686558\(v=vs.85\).aspx) topic.  
  
 MFC's interface map support is rooted in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> "*has-a*" reference count as well as all the member functions associated with the [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) implementation (the reference count for example is in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>). To create a class that supports OLE COM, you derive a class from <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and use various macros as well as member functions of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to implement the desired interfaces. MFC's implementation uses nested classes to define each interface implementation much like the example above. This is made easier with a standard implementation of IUnknown as well as a number of macros that eliminate some of the repetitive code.  
  
## Interface Map Basics  
  
#### To implement a class using MFC's interface maps  
  
1.  Derive a class either directly or indirectly from <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
2.  Use the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function in the derived class definition.  
  
3.  For each interface you wish to support, use the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> macros in the class definition.  
  
4.  In the implementation file, use the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> macros to define the class's interface map.  
  
5.  For each IID supported, use the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> macro between the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> macros to map that IID to a specific "part" of your class.  
  
6.  Implement each of the nested classes that represent the interfaces you support.  
  
7.  Use the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> macro to access the parent, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>-derived object.  
  
8.  [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379), [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317), and [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) can delegate to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> implementation of these functions (<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>).  
  
 The CPrintEditObj example above could be implemented as follows:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The above declaration creates a class derived from <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> macro tells the framework that this class will have a custom interface map. In addition, the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> macros define nested classes, in this case with names CEditObj and CPrintObj (the X is used only to differentiate the nested classes from global classes which start with "C" and interface classes which start with "I"). Two nested members of these classes are created: m_CEditObj, and m_CPrintObj, respectively. The macros automatically declare the [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379), [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317), and [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) functions; therefore you only declare the functions specific to this interface: EditObject and PrintObject (the OLE macro <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is used so that <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and virtual keywords are provided as appropriate for the target platform).  
  
 To implement the interface map for this class:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 This connects the IID_IPrintInterface IID with m_CPrintObj and IID_IEditInterface with m_CEditObj respectively. The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> implementation of [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) (<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>) uses this map to return pointers to m_CPrintObj and m_CEditObj when requested. It is not necessary to include an entry for <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>; the framework will use the first interface in the map (in this case, m_CPrintObj) when <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is requested.  
  
 Even though the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> macro automatically declared the [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379), [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) and [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) functions for you, you still need to implement them:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The implementation for CEditPrintObj::CPrintObj, would be similar to the above definitions for CEditPrintObj::CEditObj. Although it would be possible to create a macro that could be used to automatically generate these functions (but earlier in MFC/OLE development this was the case), it becomes difficult to set break points when a macro generates more than one line of code. For this reason, this code is expanded manually.  
  
 By using the framework implementation of message maps, there are a number of things that were not necessary to do:  
  
-   Implement QueryInterface  
  
-   Implement AddRef and Release  
  
-   Declare either of these built-in methods on both of your interfaces  
  
 In addition, the framework uses message maps internally. This allows you to derive from a framework class, say <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, that already supports certain interfaces and provides either replacements or additions to the interfaces provided by the framework. You can do this because the framework fully supports inheriting an interface map from a base class. That is the reason why <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> takes as its second parameter the name of the base class.  
  
> [!NOTE]
>  It is generally not possible to reuse the implementation of MFC's built-in implementations of the OLE interfaces just by inheriting the embedded specialization of that interface from the MFC version. This is not possible because the use of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> macro to get access to the containing <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>-derived object implies a *fixed offset* of the embedded object from the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>-derived object. This means, for example, you cannot derive an embedded XMyAdviseSink from MFC's implementation in <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, because XAdviseSink relies on being at a specific offset from the top of the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  You can, however, delegate to the MFC implementation for all of the functions that you want MFC's default behavior. This is done in the MFC implementation of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> (XOleInPlaceFrame) in the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> class (it delegates to m_xOleInPlaceUIWindow for many functions). This design was chosen to reduce the runtime size of objects which implement many interfaces; it eliminates the need for a back-pointer (such as the way m_pParent was used in the previous section).  
  
### Aggregation and Interface Maps  
 In addition to supporting stand-alone COM objects, MFC also supports aggregation. Aggregation itself is too complex a topic to discuss here; refer to the [Aggregation](http://msdn.microsoft.com/library/windows/desktop/ms686558\(v=vs.85\).aspx) topic for more information on aggregation. This note will simply describe the support for aggregation built into the framework and interface maps.  
  
 There are two ways to use aggregation: (1) using a COM object that supports aggregation, and (2) implementing an object that can be aggregated by another. These capabilities can be referred to as "using an aggregate object" and "making an object aggregatable". MFC supports both.  
  
### Using an Aggregate Object  
 To use an aggregate object, there needs to be some way to tie the aggregate into the QueryInterface mechanism. In other words, the aggregate object must behave as though it is a native part of your object. So how does this tie into MFC's interface map mechanism? In addition to the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> macro, where a nested object is mapped to an IID, you can also declare an aggregate object as part of your <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> derived class. To do so, the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> macro is used. This allows you to specify a member variable (which must be a pointer to an [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) or derived class), which is to be integrated into the interface map mechanism. If the pointer is not NULL when <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is called, the framework will automatically call the aggregate object's [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) member function, if the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> requested is not one of the native <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>s supported by the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object itself.  
  
##### To use the INTERFACE_AGGREGATE macro  
  
1.  Declare a member variable (an <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>) which will contain a pointer to the aggregate object.  
  
2.  Include an <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> macro in your interface map, which refers to the member variable by name.  
  
3.  At some point (usually during <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>), initialize the member variable to something other than NULL.  
  
 For example:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The m_lpAggrInner variable is initialized in the constructor to NULL. The framework ignores a NULL member variable in the default implementation of [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521). <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is a good place to actually create your aggregate objects. You'll have to call it explicitly if you are creating the object outside of the MFC implementation of <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. The reason for creating aggregates in <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> as well as the usage of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> will become apparent when creating aggregatable objects is discussed.  
  
 This technique will give your object all of the interfaces that the aggregate object supports plus its native interfaces. If you only want a subset of the interfaces that the aggregate supports, you can override <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>. This allows you very low-level hookability, similar to [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521). Usually, you want all the interfaces that the aggregate supports.  
  
### Making an Object Implementation Aggregatable  
 For an object to be aggregatable, the implementation of [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379), [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317), and [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) must delegate to a "controlling unknown." In other words, for it to be part of the object, it must delegate [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379), [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317), and [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) to a different object, also derived from [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509). This "controlling unknown" is provided to the object when it is created, that is, it is provided to the implementation of <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. Implementing this carries a small amount of overhead, and in some cases is not desirable, so MFC makes this optional. To enable an object to be aggregatable, you call <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> from the object's constructor.  
  
 If the object also uses aggregates, you must also be sure to pass the correct "controlling unknown" to the aggregate objects. Usually this [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) pointer is passed to the object when the aggregate is created. For example, the pUnkOuter parameter is the "controlling unknown" for objects created with <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. The correct "controlling unknown" pointer can be retrieved by calling <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. The value returned from that function, however, is not valid during the constructor. For this reason, it is suggested that you create your aggregates only in an override of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, where the return value from <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is reliable, even if created from the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> implementation.  
  
 It is also important that the object manipulate the correct reference count when adding or releasing artificial reference counts. To ensure this is the case, always call <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. It is rare to call <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> on a class that supports aggregation.  
  
### Reference Material  
 Advanced usage of OLE, such as defining your own interfaces or overriding the framework's implementation of the OLE interfaces requires the use of the underlying interface map mechanism.  
  
 This section discusses each macro and the APIs which is used to implement these advanced features.  
  
### CCmdTarget::EnableAggregation — Function Description  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## Remarks  
 Call this function in the constructor of the derived class if you wish to support OLE aggregation for objects of this type. This prepares a special IUnknown implementation that is required for aggregatable objects.  
  
### CCmdTarget::ExternalQueryInterface — Function Description  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## Remarks  
  
#### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A far pointer to an IID (the first argument to QueryInterface)  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A pointer to an IUnknown* (second argument to QueryInterface)  
  
## Remarks  
 Call this function in your implementation of IUnknown for each interface your class implements. This function provides the standard data-driven implementation of QueryInterface based on your object's interface map. It is necessary to cast the return value to an HRESULT. If the object is aggregated, this function will call the "controlling IUnknown" instead of using the local interface map.  
  
### CCmdTarget::ExternalAddRef — Function Description  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
## Remarks  
 Call this function in your implementation of IUnknown::AddRef for each interface your class implements. The return value is the new reference count on the CCmdTarget object. If the object is aggregated, this function will call the "controlling IUnknown" instead of manipulating the local reference count.  
  
### CCmdTarget::ExternalRelease — Function Description  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## Remarks  
 Call this function in your implementation of IUnknown::Release for each interface your class implements. The return value indicates the new reference count on the object. If the object is aggregated, this function will call the "controlling IUnknown" instead of manipulating the local reference count.  
  
### DECLARE_INTERFACE_MAP — Macro Description  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
## Remarks  
 Use this macro in any class derived from <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> that will have an interface map. Used in much the same way as <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>. This macro invocation should be placed in the class definition, usually in a header (.H) file. A class with <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> must define the interface map in the implementation file (.CPP) with the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> macros.  
  
### BEGIN_INTERFACE_PART and END_INTERFACE_PART — Macro Descriptions  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
## Remarks  
  
#### Parameters  
 l<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The name of the class that implements the interface  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The name of the interface that this class implements  
  
## Remarks  
 For each interface that your class will implement, you need to have a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> pair. These macros define a local class derived from the OLE interface that you define as well as an embedded member variable of that class. The [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379), [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317), and [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521) members are declared automatically. You must include the declarations for the other member functions that are part of the interface being implemented (those declarations are placed between the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> macros).  
  
 The <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> argument is the OLE interface that you wish to implement, such as <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> (or your own custom interface).  
  
 The <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> argument is the name of the local class that will be defined. An 'X' will automatically be prepended to the name. This naming convention is used to avoid collisions with global classes of the same name. In addition, the name of the embedded member, the same as the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> name except it is prefixed by 'm_x'.  
  
 For example:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 would define a local class called XMyAdviseSink derived from IAdviseSink, and a member of the class in which it is declared called m_xMyAdviseSink.Note:  
  
> [!NOTE]
>  The lines beginning with <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>_ are essentially copied from OLE2.H and modified slightly. Copying them from OLE2.H can reduce errors that are hard to resolve.  
  
### BEGIN_INTERFACE_MAP and END_INTERFACE_MAP — Macro Descriptions  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
## Remarks  
  
#### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The class in which the interface map is to be defined  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The class from which <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> derives from.  
  
## Remarks  
 The <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> macros are used in the implementation file to actually define the interface map. For each interface that is implemented there is one or more <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> macro invocations. For each aggregate that the class uses, there is one <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> macro invocation.  
  
### INTERFACE_PART — Macro Description  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
## Remarks  
  
#### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The name of the class that contains the interface map.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> that is to be mapped to the embedded class.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The name of the local class (less the 'X').  
  
## Remarks  
 This macro is used between the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> macro and the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> macro for each interface your object will support. It allows you to map an IID to a member of the class indicated by <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>. The 'm_x' will be added to the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> automatically. Note that more than one <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> may be associated with a single member. This is very useful when you are implementing only a "most derived" interface and wish to provide all intermediate interfaces as well. A good example of this is the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> interface. Its hierarchy looks like this:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 If an object implements <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, a client may <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> on any of these interfaces: <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, or [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509), besides the "most derived" interface <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> (the one you are actually implementing). To handle this you can use more than one <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> macro to map each and every base interface to the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> interface:  
  
 in the class definition file:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 in the class implementation file:  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The framework takes care of IUnknown because it is always required.  
  
### INTERFACE_PART — Macro Description  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
## Remarks  
  
#### Parameters  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The name of the class that contains the interface map,  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The name of the member variable that is to be aggregated.  
  
## Remarks  
 This macro is used to tell the framework that the class is using an aggregate object. It must appear between the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> macros. An aggregate object is a separate object, derived from [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509). By using an aggregate and the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> macro, you can make all the interfaces that the aggregate supports appear to be directly supported by the object. The <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> argument is simply the name of a member variable of your class which is derived from [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) (either directly or indirectly). All <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> macros must follow the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> macros when placed in an interface map.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)