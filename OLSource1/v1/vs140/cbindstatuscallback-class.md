---
title: "CBindStatusCallback Class"
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
  - "CBindStatusCallback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "asynchronous data transfer [C++]"
  - "data transfer [C++]"
  - "data transfer [C++], asynchronous"
  - "CBindStatusCallback class"
ms.assetid: 0f5da276-6031-4418-b2a9-a4750ef29e77
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback Class
This class implements the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interface.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Your class containing the function that will be called as the data is received.  
  
 *nBindFlags*  
 Specifies the bind flags that are returned by [GetBindInfo](../vs140/cbindstatuscallback--getbindinfo.md). The default implementation sets the binding to be asynchronous, retrieves the newest version of the data/object, and does not store retrieved data in the disk cache.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CBindStatusCallback::CBindStatusCallback](../vs140/cbindstatuscallback--cbindstatuscallback.md)|The constructor.|  
|[CBindStatusCallback::~CBindStatusCallback](../vs140/cbindstatuscallback--~cbindstatuscallback.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CBindStatusCallback::Download](../vs140/cbindstatuscallback--download.md)|Static method that starts the download process, creates a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object, and calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[CBindStatusCallback::GetBindInfo](../vs140/cbindstatuscallback--getbindinfo.md)|Called by the asynchronous moniker to request information on the type of bind to be created.|  
|[CBindStatusCallback::GetPriority](../vs140/cbindstatuscallback--getpriority.md)|Called by the asynchronous moniker to get the priority of the bind operation. The ATL implementation returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[CBindStatusCallback::OnDataAvailable](../vs140/cbindstatuscallback--ondataavailable.md)|Called to provide data to your application as it becomes available. Reads the data, then calls the function passed to it to use the data.|  
|[CBindStatusCallback::OnLowResource](../vs140/cbindstatuscallback--onlowresource.md)|Called when resources are low. The ATL implementation returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[CBindStatusCallback::OnObjectAvailable](../vs140/cbindstatuscallback--onobjectavailable.md)|Called by the asynchronous moniker to pass an object interface pointer to your application. The ATL implementation returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
|[CBindStatusCallback::OnProgress](../vs140/cbindstatuscallback--onprogress.md)|Called to indicate the progress of a data downloading process. The ATL implementation returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|[CBindStatusCallback::OnStartBinding](../vs140/cbindstatuscallback--onstartbinding.md)|Called when binding is started.|  
|[CBindStatusCallback::OnStopBinding](../vs140/cbindstatuscallback--onstopbinding.md)|Called when the asynchronous data transfer is stopped.|  
|[CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md)|Initializes the bytes available and bytes read to zero, creates a push-type stream object from a URL, and calls <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> every time data is available.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CBindStatusCallback::m_dwAvailableToRead](../vs140/cbindstatuscallback--m_dwavailabletoread.md)|Number of bytes available to read.|  
|[CBindStatusCallback::m_dwTotalRead](../vs140/cbindstatuscallback--m_dwtotalread.md)|Total number of bytes read.|  
|[CBindStatusCallback::m_pFunc](../vs140/cbindstatuscallback--m_pfunc.md)|Pointer to the function called when data is available.|  
|[CBindStatusCallback::m_pT](../vs140/cbindstatuscallback--m_pt.md)|Pointer to the object requesting the asynchronous data transfer.|  
|[CBindStatusCallback::m_spBindCtx](../vs140/cbindstatuscallback--m_spbindctx.md)|Pointer to the [IBindCtx](http://msdn.microsoft.com/library/windows/desktop/ms693755) interface for the current bind operation.|  
|[CBindStatusCallback::m_spBinding](../vs140/cbindstatuscallback--m_spbinding.md)|Pointer to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> interface for the current bind operation.|  
|[CBindStatusCallback::m_spMoniker](../vs140/cbindstatuscallback--m_spmoniker.md)|Pointer to the [IMoniker](http://msdn.microsoft.com/library/windows/desktop/ms679705) interface for the URL to use.|  
|[CBindStatusCallback::m_spStream](../vs140/cbindstatuscallback--m_spstream.md)|Pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface for the data transfer.|  
  
## Remarks  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class implements the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> interface. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> must be implemented by your application so it can receive notifications from an asynchronous data transfer. The asynchronous moniker provided by the system uses <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> methods to send and receive information about the asynchronous data transfer to and from your object.  
  
 Typically, the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object is associated with a specific bind operation. For example, in the [ASYNC](../vs140/visual-c---samples.md) sample, when you set the URL property, it creates a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object in the call to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>:  
  
 [!code[NVC_ATL_Windowing#86](../vs140/codesnippet/CPP/cbindstatuscallback-class_1.h)]  
  
 The asynchronous moniker uses the callback function <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to call your application when it has data. The asynchronous moniker is provided by the system.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="cbindstatuscallback__cbindstatuscallback">\</a>  CBindStatusCallback::CBindStatusCallback  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Creates an object to receive notifications concerning the asynchronous data transfer. Typically, one object is created for each bind operation.  
  
 The constructor also initializes [m_pT](../vs140/cbindstatuscallback--m_pt.md) and [m_pFunc](../vs140/cbindstatuscallback--m_pfunc.md) to **NULL**.  
  
##  \<a name="cbindstatuscallback___dtorcbindstatuscallback">\</a>  CBindStatusCallback::~CBindStatusCallback  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources.  
  
##  \<a name="cbindstatuscallback__download">\</a>  CBindStatusCallback::Download  
 Creates a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object and calls <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to start downloading data asynchronously from the specified URL.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *pT*  
 [in] A pointer to the object requesting the asynchronous data transfer. The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object is templatized on this object's class.  
  
 *pFunc*  
 [in] A pointer to the function that receives the data that is read. The function is a member of your object's class of type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. See [StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md) for syntax and an example.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 [in] The URL to obtain data from. Can be any valid URL or file name. Cannot be **NULL**. For example:  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 [in] The **IUnknown** of the container. **NULL** by default.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 [in] A flag indicating whether the URL is relative or absolute. **FALSE** by default, meaning the URL is absolute.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> values.  
  
### Remarks  
 Every time data is available it is sent to the object through <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> reads the data and calls the function pointed to by *pFunc* (for example, to store the data or print it to the screen).  
  
##  \<a name="cbindstatuscallback__getbindinfo">\</a>  CBindStatusCallback::GetBindInfo  
 Called to tell the moniker how to bind.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *pgrfBSCF*  
 [out] A pointer to **BINDF** enumeration values indicating how the bind operation should occur. By default, set with the following enumeration values:  
  
 **BINDF_ASYNCHRONOUS** Asynchronous download.  
  
 **BINDF_ASYNCSTORAGE** <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> returns **E_PENDING** when data is not yet available rather than blocking until data is available.  
  
 **BINDF_GETNEWESTVERSION** The bind operation should retrieve the newest version of the data.  
  
 **BINDF_NOWRITECACHE** The bind operation should not store retrieved data in the disk cache.  
  
 *pbindinfo*  
 [in, out] A pointer to the **BINDINFO** structure giving more information about how the object wants binding to occur.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> values.  
  
### Remarks  
 The default implementation sets the binding to be asynchronous and to use the data-push model. In the data-push model, the moniker drives the asynchronous bind operation and continuously notifies the client whenever new data is available.  
  
##  \<a name="cbindstatuscallback__getpriority">\</a>  CBindStatusCallback::GetPriority  
 Called by the asynchronous moniker to get the priority of the bind operation.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *pnPriority*  
 [out] Address of the **LONG** variable that, on success, receives the priority.  
  
### Return Value  
 Returns **E_NOTIMPL**.  
  
##  \<a name="cbindstatuscallback__m_dwavailabletoread">\</a>  CBindStatusCallback::m_dwAvailableToRead  
 Can be used to store the number of bytes available to be read.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Initialized to zero in <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__m_dwtotalread">\</a>  CBindStatusCallback::m_dwTotalRead  
 The cumulative total of bytes read in the asynchronous data transfer.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Incremented every time <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is called by the number of bytes actually read. Initialized to zero in <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__m_pfunc">\</a>  CBindStatusCallback::m_pFunc  
 The function pointed to by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is called by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> after it reads the available data (for example, to store the data or print it to the screen).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 The function pointed to by <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is a member of your object's class and has the following syntax:  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
##  \<a name="cbindstatuscallback__m_pt">\</a>  CBindStatusCallback::m_pT  
 A pointer to the object requesting the asynchronous data transfer.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object is templatized on this object's class.  
  
##  \<a name="cbindstatuscallback__m_spbindctx">\</a>  CBindStatusCallback::m_spBindCtx  
 A pointer to an [IBindCtx](http://msdn.microsoft.com/library/windows/desktop/ms693755) interface that provides access to the bind context (an object that stores information about a particular moniker binding operation).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Initialized in <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__m_spbinding">\</a>  CBindStatusCallback::m_spBinding  
 A pointer to the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> interface of the current bind operation.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Initialized in <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and released in <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__m_spmoniker">\</a>  CBindStatusCallback::m_spMoniker  
 A pointer to the [IMoniker](http://msdn.microsoft.com/library/windows/desktop/ms679705) interface for the URL to use.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 Initialized in <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__m_spstream">\</a>  CBindStatusCallback::m_spStream  
 A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface of the current bind operation.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 Initialized in <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> from the **STGMEDIUM** structure when the **BCSF** flag is **BCSF_FIRSTDATANOTIFICATION** and released when the **BCSF** flag is **BCSF_LASTDATANOTIFICATION**.  
  
##  \<a name="cbindstatuscallback__ondataavailable">\</a>  CBindStatusCallback::OnDataAvailable  
 The system-supplied asynchronous moniker calls <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> to provide data to the object as it becomes available.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 *grfBSCF*  
 [in] A **BSCF** enumeration value. One or more of the following:                                 **BSCF_FIRSTDATANOTIFICATION**,                                 **BSCF_INTERMEDIARYDATANOTIFICATION**, or **BSCF_LASTDATANOTIFICATION**.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 [in] The cumulative amount (in bytes) of data available since the beginning of the binding. Can be zero, indicating that the amount of data is not relevant or that no specific amount became available.  
  
 *pformatetc*  
 [in] Pointer to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682242) structure that contains the format of the available data. If there is no format, can be **CF_NULL**.  
  
 *pstgmed*  
 [in] Pointer to the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms695269) structure that holds the actual data now available.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> values.  
  
### Remarks  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> reads the data, then calls a method of your object's class (for example, to store the data or print it to the screen). See [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md) for details.  
  
##  \<a name="cbindstatuscallback__onlowresource">\</a>  CBindStatusCallback::OnLowResource  
 Called when resources are low.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Reserved.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__onobjectavailable">\</a>  CBindStatusCallback::OnObjectAvailable  
 Called by the asynchronous moniker to pass an object interface pointer to your application.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Interface identifier of the requested interface. Unused.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Address of the IUnknown interface. Unused.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__onprogress">\</a>  CBindStatusCallback::OnProgress  
 Called to indicate the progress of a data downloading process.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Unsigned long integer. Unused.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Unsigned long integer Unused.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Unsigned long integer. Unused.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Address of a string value. Unused.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
##  \<a name="cbindstatuscallback__onstartbinding">\</a>  CBindStatusCallback::OnStartBinding  
 Sets the data member [m_spBinding](../vs140/cbindstatuscallback--m_spbinding.md) to the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> pointer in <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 [in] Address of the IBinding interface of the current bind operation. This cannot be NULL. The client should call AddRef on this pointer to keep a reference to the binding object.  
  
##  \<a name="cbindstatuscallback__onstopbinding">\</a>  CBindStatusCallback::OnStopBinding  
 Releases the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> pointer in the data member [m_spBinding](../vs140/cbindstatuscallback--m_spbinding.md).  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Status code returned from the bind operation.  
  
 szStatusText  
 Address of a string value Unused.  
  
### Remarks  
 Called by the system-supplied asynchronous moniker to indicate the end of the bind operation.  
  
##  \<a name="cbindstatuscallback__startasyncdownload">\</a>  CBindStatusCallback::StartAsyncDownload  
 Starts downloading data asynchronously from the specified URL.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *pT*  
 [in] A pointer to the object requesting the asynchronous data transfer. The <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object is templatized on this object's class.  
  
 *pFunc*  
 [in] A pointer to the function that receives the data being read. The function is a member of your object's class of type <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>. See **Remarks** for syntax and an example.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 [in] The URL to obtain data from. Can be any valid URL or file name. Cannot be **NULL**. For example:  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 [in] The **IUnknown** of the container. **NULL** by default.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 [in] A flag indicating whether the URL is relative or absolute. **FALSE** by default, meaning the URL is absolute.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> values.  
  
### Remarks  
 Every time data is available it is sent to the object through <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> reads the data and calls the function pointed to by *pFunc* (for example, to store the data or print it to the screen).  
  
 The function pointed to by *pFunc* is a member of your object's class and has the following syntax:  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  
 In the following example (taken from the [ASYNC](../vs140/visual-c---samples.md) sample), the function <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> writes the received data into a text box.  
  
### Example  
 [!code[NVC_ATL_Windowing#87](../vs140/codesnippet/CPP/cbindstatuscallback-class_2.h)]  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)