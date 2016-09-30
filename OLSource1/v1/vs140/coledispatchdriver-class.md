---
title: "COleDispatchDriver Class"
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
  - "COleDispatchDriver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class"
  - "Automation clients, implementing Automation"
  - "OLE dispatch interface"
ms.assetid: 3ed98daf-cdc7-4374-8a0c-cf695a8d3657
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver Class
Implements the client side of OLE automation.  
  
## Syntax  
  
```  
class COleDispatchDriver  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::COleDispatchDriver](#coledispatchdriver__coledispatchdriver)|Constructs a `COleDispatchDriver` object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch)|Attaches an `IDispatch` connection to the `COleDispatchDriver` object.|  
|[COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch)|Creates an `IDispatch` connection and attaches it to the `COleDispatchDriver` object.|  
|[COleDispatchDriver::DetachDispatch](#coledispatchdriver__detachdispatch)|Detaches an `IDispatch` connection, without releasing it.|  
|[COleDispatchDriver::GetProperty](#coledispatchdriver__getproperty)|Gets an automation property.|  
|[COleDispatchDriver::InvokeHelper](#coledispatchdriver__invokehelper)|Helper for calling automation methods.|  
|[COleDispatchDriver::ReleaseDispatch](#coledispatchdriver__releasedispatch)|Releases an `IDispatch` connection.|  
|[COleDispatchDriver::SetProperty](#coledispatchdriver__setproperty)|Sets an automation property.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::operator =](#coledispatchdriver__operator__eq)|Copies the source value into the `COleDispatchDriver` object.|  
|[COleDispatchDriver::operator LPDISPATCH](#coledispatchdriver__operator_lpdispatch)|Accesses the underlying `IDispatch` pointer.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::m_bAutoRelease](#coledispatchdriver__m_bautorelease)|Specifies whether to release the `IDispatch` during `ReleaseDispatch` or object destruction.|  
|[COleDispatchDriver::m_lpDispatch](#coledispatchdriver__m_lpdispatch)|Indicates the pointer to the `IDispatch` interface attached to this `COleDispatchDriver`.|  
  
## Remarks  
 `COleDispatchDriver` does not have a base class.  
  
 OLE dispatch interfaces provide access to an object's methods and properties. Member functions of `COleDispatchDriver` attach, detach, create, and release a dispatch connection of type `IDispatch`. Other member functions use variable argument lists to simplify calling **IDispatch::Invoke**.  
  
 This class can be used directly, but it is generally used only by classes created by the Add Class wizard. When you create new C++ classes by importing a type library, the new classes are derived from `COleDispatchDriver`.  
  
 For more information on using `COleDispatchDriver`, see the following articles:  
  
-   [Automation Clients](../vs140/automation-clients.md)  
  
-   [Automation Servers](../vs140/automation-servers.md)  
  
## Inheritance Hierarchy  
 `COleDispatchDriver`  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="coledispatchdriver__attachdispatch"></a>  COleDispatchDriver::AttachDispatch  
 Call the `AttachDispatch` member function to attach an `IDispatch` pointer to the `COleDispatchDriver` object. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
```  
void AttachDispatch(  
		LPDISPATCH lpDispatch,  
		BOOL bAutoRelease = TRUE  
		);  
```  
  
### Parameters  
 `lpDispatch`  
 Pointer to an OLE `IDispatch` object to be attached to the `COleDispatchDriver` object.  
  
 `bAutoRelease`  
 Specifies whether the dispatch is to be released when this object goes out of scope.  
  
### Remarks  
 This function releases any `IDispatch` pointer that is already attached to the `COleDispatchDriver` object.  
  
### Example  
 [!code[NVC_MFCOleContainer#3](../vs140/codesnippet/CPP/coledispatchdriver-class_1.cpp)]  
  
##  \<a name="coledispatchdriver__coledispatchdriver"></a>  COleDispatchDriver::COleDispatchDriver  
 Constructs a `COleDispatchDriver` object.  
  
```  
 COleDispatchDriver( ); COleDispatchDriver( LPDISPATCH lpDispatch, BOOL bAutoRelease = TRUE   
); COleDispatchDriver( const COleDispatchDriver& dispatchSrc   
);  
```  
  
### Parameters  
 `lpDispatch`  
 Pointer to an OLE `IDispatch` object to be attached to the `COleDispatchDriver` object.  
  
 `bAutoRelease`  
 Specifies whether the dispatch is to be released when this object goes out of scope.  
  
 `dispatchSrc`  
 Reference to an existing `COleDispatchDriver` object.  
  
### Remarks  
 The form `COleDispatchDriver`( `LPDISPATCH``lpDispatch`, **BOOL**`bAutoRelease` = **TRUE**) connects the [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) interface.  
  
 The form `COleDispatchDriver`( **const**`COleDispatchDriver`& `dispatchSrc`) copies an existing `COleDispatchDriver` object and increments the reference count.  
  
 The form `COleDispatchDriver`( ) creates a `COleDispatchDriver` object but does not connect the `IDispatch` interface. Before using `COleDispatchDriver`( ) without arguments, you should connect an `IDispatch` to it using either [COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch) or [COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch). For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch).  
  
##  \<a name="coledispatchdriver__createdispatch"></a>  COleDispatchDriver::CreateDispatch  
 Creates an [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) interface object and attaches it to the `COleDispatchDriver` object.  
  
```  
  
BOOL CreateDispatch(  
		REFCLSID clsid,  
		COleException* pError = NULL  
		);  
  
BOOL CreateDispatch(  
    LPCTSTR lpszProgID,  
    COleException* pError = NULL   
    );  
```  
  
### Parameters  
 `clsid`  
 Class ID of the `IDispatch` connection object to be created.  
  
 `pError`  
 Pointer to an OLE exception object, which will hold the status code resulting from the creation.  
  
 `lpszProgID`  
 Pointer to the programmatic identifier, such as "Excel.Document.5", of the automation object for which the dispatch object is to be created.  
  
### Return Value  
 Nonzero on success; otherwise 0.  
  
### Example  
 [!code[NVC_MFCOleContainer#4](../vs140/codesnippet/CPP/coledispatchdriver-class_2.cpp)]  
  
##  \<a name="coledispatchdriver__detachdispatch"></a>  COleDispatchDriver::DetachDispatch  
 Detaches the current `IDispatch` connection from this object.  
  
```  
LPDISPATCH DetachDispatch( );  
  
```  
  
### Return Value  
 A pointer to the previously attached OLE `IDispatch` object.  
  
### Remarks  
 The `IDispatch` is not released.  
  
 For more information about the `LPDISPATCH` type, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCOleContainer#5](../vs140/codesnippet/CPP/coledispatchdriver-class_3.cpp)]  
  
##  \<a name="coledispatchdriver__getproperty"></a>  COleDispatchDriver::GetProperty  
 Gets the object property specified by `dwDispID`.  
  
```  
void GetProperty(    DISPID dwDispID ,    VARTYPE vtProp ,    void* pvProp ) const;  
  
```  
  
### Parameters  
 `dwDispID`  
 Identifies the property to be retrieved.  
  
 `vtProp`  
 Specifies the property to be retrieved. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](#coledispatchdriver__invokehelper).  
  
 `pvProp`  
 Address of the variable that will receive the property value. It must match the type specified by `vtProp`.  
  
### Example  
 [!code[NVC_MFCOleContainer#6](../vs140/codesnippet/CPP/coledispatchdriver-class_4.cpp)]  
  
##  \<a name="coledispatchdriver__invokehelper"></a>  COleDispatchDriver::InvokeHelper  
 Calls the object method or property specified by `dwDispID`, in the context specified by `wFlags`.  
  
```  
void AFX_CDECL InvokeHelper(  
		DISPID dwDispID,  
		WORD wFlags,  
		VARTYPE vtRet,  
		void* pvRet,  
		const BYTE* pbParamInfo, ...   
);  
```  
  
### Parameters  
 `dwDispID`  
 Identifies the method or property to be invoked.  
  
 `wFlags`  
 Flags describing the context of the call to **IDispatch::Invoke**. . For a list of possible values, see the `wFlags` parameter in                                  [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `vtRet`  
 Specifies the type of the return value. For possible values, see the Remarks section.  
  
 `pvRet`  
 Address of the variable that will receive the property value or return value. It must match the type specified by `vtRet`.  
  
 `pbParamInfo`  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following `pbParamInfo`.  
  
 *...*  
 Variable list of parameters, of types specified in `pbParamInfo`.  
  
### Remarks  
 The `pbParamInfo` parameter specifies the types of the parameters passed to the method or property. The variable list of arguments is represented by **...** in the syntax declaration.  
  
 Possible values for the `vtRet` argument are taken from the `VARENUM` enumeration. Possible values are as follows:  
  
|Symbol|Return Type|  
|------------|-----------------|  
|`VT_EMPTY`|`void`|  
|`VT_I2`|**short**|  
|`VT_I4`|**long**|  
|`VT_R4`|**float**|  
|`VT_R8`|**double**|  
|`VT_CY`|**CY**|  
|`VT_DATE`|**DATE**|  
|`VT_BSTR`|`BSTR`|  
|**VT_DISPATCH**|`LPDISPATCH`|  
|`VT_ERROR`|`SCODE`|  
|`VT_BOOL`|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|`LPUNKNOWN`|  
  
 The `pbParamInfo` argument is a space-separated list of **VTS_** constants. One or more of these values, separated by spaces (not commas), specifies the function's parameter list. Possible values are listed with the [EVENT_CUSTOM](../vs140/event_custom.md) macro.  
  
 This function converts the parameters to **VARIANTARG** values, then invokes the                         [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) method. If the call to `Invoke` fails, this function will throw an exception. If the `SCODE` (status code) returned by **IDispatch::Invoke** is `DISP_E_EXCEPTION`, this function throws a [COleException](../vs140/coleexception-class.md) object; otherwise it throws a [COleDispatchException](../vs140/coledispatchexception-class.md).  
  
 For more information, see [VARIANTARG](assetId:///e305240e-9e11-4006-98cc-26f4932d2118),                         [Implementing the IDispatch Interface](http://msdn.microsoft.com/library/windows/desktop/ms221037\(v=vs.85\).aspx),                         [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx), and                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch).  
  
##  \<a name="coledispatchdriver__m_bautorelease"></a>  COleDispatchDriver::m_bAutoRelease  
 If **TRUE**, the COM object accessed by [m_lpDispatch](#coledispatchdriver__m_lpdispatch) will be automatically released when [ReleaseDispatch](#coledispatchdriver__releasedispatch) is called or when this `COleDispatchDriver` object is destroyed.  
  
```  
BOOL m_bAutoRelease;  
  
```  
  
### Remarks  
 By default, `m_bAutoRelease` is set to **TRUE** in the constructor.  
  
 For more information on releasing COM objects, see                         [Implementing Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms693431) and                         [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCOleContainer#9](../vs140/codesnippet/CPP/coledispatchdriver-class_5.cpp)]  
  
##  \<a name="coledispatchdriver__m_lpdispatch"></a>  COleDispatchDriver::m_lpDispatch  
 The pointer to the `IDispatch` interface attached to this `COleDispatchDriver`.  
  
```  
LPDISPATCH m_lpDispatch;  
  
```  
  
### Remarks  
 The `m_lpDispatch` data member is a public variable of type `LPDISPATCH`.  
  
 For more information, see [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch).  
  
##  \<a name="coledispatchdriver__operator__eq"></a>  COleDispatchDriver::operator =  
 Copies the source value into the `COleDispatchDriver` object.  
  
```  
const COleDispatchDriver& operator=(    const COleDispatchDriver&  dispatchSrc );  
  
```  
  
### Parameters  
 `dispatchSrc`  
 A pointer to an existing `COleDispatchDriver` object.  
  
##  \<a name="coledispatchdriver__operator_lpdispatch"></a>  COleDispatchDriver::operator LPDISPATCH  
 Accesses the underlying `IDispatch` pointer of the `COleDispatchDriver` object.  
  
```  
operator LPDISPATCH( );  
  
```  
  
### Example  
 [!code[NVC_MFCOleContainer#8](../vs140/codesnippet/CPP/coledispatchdriver-class_6.cpp)]  
  
##  \<a name="coledispatchdriver__releasedispatch"></a>  COleDispatchDriver::ReleaseDispatch  
 Releases the `IDispatch` connection. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945)  
  
```  
void ReleaseDispatch( );  
  
```  
  
### Remarks  
 If auto release has been set for this connection, this function calls **IDispatch::Release** before releasing the interface.  
  
### Example  
  See the example for [COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch).  
  
##  \<a name="coledispatchdriver__setproperty"></a>  COleDispatchDriver::SetProperty  
 Sets the OLE object property specified by `dwDispID`.  
  
```  
void AFX_CDECL SetProperty(  
      DISPID dwDispID,  
      VARTYPE vtProp, ...   
);  
```  
  
### Parameters  
 `dwDispID`  
 Identifies the property to be set.  
  
 `vtProp`  
 Specifies the type of the property to be set. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](#coledispatchdriver__invokehelper).  
  
 *...*  
 A single parameter of the type specified by `vtProp`.  
  
### Example  
 [!code[NVC_MFCOleContainer#7](../vs140/codesnippet/CPP/coledispatchdriver-class_7.cpp)]  
  
## See Also  
 [MFC Sample CALCDRIV](../vs140/visual-c---samples.md)   
 [MFC Sample ACDUAL](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget](../vs140/ccmdtarget-class.md)