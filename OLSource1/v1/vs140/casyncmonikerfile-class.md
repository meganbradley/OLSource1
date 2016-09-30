---
title: "CAsyncMonikerFile Class"
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
  - "CAsyncMonikerFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX controls [C++], asynchronous"
  - "OLE controls [C++], asynchronous"
  - "monikers [C++], MFC"
  - "asynchronous controls [C++]"
  - "CAsyncMonikerFile class"
  - "IMoniker interface, binding"
ms.assetid: 17378b66-a49a-4b67-88e3-7756ad26a2fc
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncMonikerFile Class
Provides functionality for the use of asynchronous monikers in ActiveX controls (formerly OLE controls).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncMonikerFile::CAsyncMonikerFile](#casyncmonikerfile__casyncmonikerfile)|Constructs a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncMonikerFile::Close](#casyncmonikerfile__close)|Closes and releases all resources.|  
|[CAsyncMonikerFile::GetBinding](#casyncmonikerfile__getbinding)|Retrieves a pointer to the asynchronous transfer binding.|  
|[CAsyncMonikerFile::GetFormatEtc](#casyncmonikerfile__getformatetc)|Retrieves the format of the data in the stream.|  
|[CAsyncMonikerFile::Open](#casyncmonikerfile__open)|Opens a file asynchronously.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncMonikerFile::CreateBindStatusCallback](#casyncmonikerfile__createbindstatuscallback)|Creates a COM object that implements <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
|[CAsyncMonikerFile::GetBindInfo](#casyncmonikerfile__getbindinfo)|Called by the OLE system library to request information on the type of bind to be created.|  
|[CAsyncMonikerFile::GetPriority](#casyncmonikerfile__getpriority)|Called by the OLE system library to get the priority of the binding.|  
|[CAsyncMonikerFile::OnDataAvailable](#casyncmonikerfile__ondataavailable)|Called to provide data as it becomes available to the client during asynchronous bind operations.|  
|[CAsyncMonikerFile::OnLowResource](#casyncmonikerfile__onlowresource)|Called when resources are low.|  
|[CAsyncMonikerFile::OnProgress](#casyncmonikerfile__onprogress)|Called to indicate progress on the data downloading process.|  
|[CAsyncMonikerFile::OnStartBinding](#casyncmonikerfile__onstartbinding)|Called when binding is starting up.|  
|[CAsyncMonikerFile::OnStopBinding](#casyncmonikerfile__onstopbinding)|Called when asynchronous transfer is stopped.|  
  
## Remarks  
 Derived from [CMonikerFile](../vs140/cmonikerfile-class.md), which in turn is derived from [COleStreamFile](../vs140/colestreamfile-class.md), <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> uses the                 [IMoniker](http://msdn.microsoft.com/library/windows/desktop/ms679705) interface to access any data stream asynchronously, including loading files asynchronously from a URL. The files can be datapath properties of ActiveX controls.  
  
 Asynchronous monikers are used primarily in Internet-enabled applications and ActiveX controls to provide a responsive user-interface during file transfers. A prime example of this is the use of [CDataPathProperty](../vs140/cdatapathproperty-class.md) to provide asynchronous properties for ActiveX controls. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object will repeatedly get a callback to indicate availability of new data during a lengthy property exchange process.  
  
 For more information about how to use asynchronous monikers and ActiveX controls in Internet applications, see the following articles:  
  
-   [Internet First Steps: Asynchronous Monikers](../vs140/asynchronous-monikers-on-the-internet.md)  
  
-   [Internet First Steps: ActiveX Controls](../vs140/activex-controls-on-the-internet.md)  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 [COleStreamFile](../vs140/colestreamfile-class.md)  
  
 [CMonikerFile](../vs140/cmonikerfile-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxole.h  
  
##  \<a name="casyncmonikerfile__casyncmonikerfile">\</a>  CAsyncMonikerFile::CAsyncMonikerFile  
 Constructs a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 It does not create the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> interface. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is used only if you provide it in the **Open** member function.  
  
 For a description of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="casyncmonikerfile__close">\</a>  CAsyncMonikerFile::Close  
 Call this function to close and release all resources.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Can be called on unopened or already closed files.  
  
##  \<a name="casyncmonikerfile__createbindstatuscallback">\</a>  CAsyncMonikerFile::CreateBindStatusCallback  
 Creates a COM object that implements <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the controlling unknown (the outer **IUnknown**) or **NULL** if aggregation is not being used.  
  
### Return Value  
 If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is not **NULL**, the function returns a pointer to the inner **IUnknown** on a new COM object supporting <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is **NULL**, the function returns a pointer to an **IUnknown** on a new COM object supporting <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> requires a COM object that implements <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. MFC implements such an object, and it is aggregatable. You can override <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to return your own COM object. Your COM object can aggregate MFC's implementation by calling <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> with the controlling unknown of your COM object. COM objects implemented using the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> COM support can retrieve the controlling unknown using **CCmdTarget::GetControllingUnknown**.  
  
 Alternately, your COM object can delegate to MFC's implementation by calling **CreateBindStatusCallback( NULL )**.  
  
 [CAsyncMonikerFile::Open](#casyncmonikerfile__open) calls <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 For more information about asynchronous monikers and asynchronous binding, see the                         [IBindStatusCallback](http://msdn.microsoft.com/library/ie/ms775060) interface and                         [How Asynchronous Binding and Storage Work](http://msdn.microsoft.com/library/windows/desktop/aa379152). For a discussion of aggregation, see                         [Aggregation](http://msdn.microsoft.com/library/windows/desktop/ms686558). All three topics are in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="casyncmonikerfile__getbindinfo">\</a>  CAsyncMonikerFile::GetBindInfo  
 Called from the client of an asynchronous moniker to tell the asynchronous moniker how it wants to bind.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Retrieves the settings for **IBindStatusCallBack**. For a description of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 The default implementation sets the binding to be asynchronous, to use a storage medium (a stream), and to use the data-push model. Override this function if you want to change the behavior of the binding.  
  
 One reason for doing this would be to bind using the data-pull model instead of the data-push model. In a data-pull model, the client drives the bind operation, and the moniker only provides data to the client when it is read. In a data-push model, the moniker drives the asynchronous bind operation and continuously notifies the client whenever new data is available.  
  
##  \<a name="casyncmonikerfile__getbinding">\</a>  CAsyncMonikerFile::GetBinding  
 Call this function to retrieve a pointer to the asynchronous transfer binding.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> interface provided when asynchronous transfer begins. Returns **NULL** if for any reason the transfer cannot be made asynchronously.  
  
### Remarks  
 This allows you to control the data transfer process through the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> interface, for example, with **IBinding::Abort**, **IBinding::Pause**, and **IBinding::Resume**.  
  
 For a description of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="casyncmonikerfile__getformatetc">\</a>  CAsyncMonikerFile::GetFormatEtc  
 Call this function to retrieve the format of the data in the stream.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the Windows structure                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) for the currently opened stream. Returns **NULL** if the moniker has not been bound, if it is not asynchronous, or if the asynchronous operation has not begun.  
  
##  \<a name="casyncmonikerfile__getpriority">\</a>  CAsyncMonikerFile::GetPriority  
 Called from the client of an asynchronous moniker as the binding process starts to receive the priority given to the thread for the binding operation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The priority at which the asynchronous transfer will take place. One of the standard thread priority flags: **THREAD_PRIORITY_ABOVE_NORMAL**, **THREAD_PRIORITY_BELOW_NORMAL**, **THREAD_PRIORITY_HIGHEST**, **THREAD_PRIORITY_IDLE**, **THREAD_PRIORITY_LOWEST**, **THREAD_PRIORITY_NORMAL**, and **THREAD_PRIORITY_TIME_CRITICAL**. See the Windows function                         [SetThreadPriority](http://msdn.microsoft.com/library/windows/desktop/ms686277) for a description of these values.  
  
### Remarks  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> should not be called directly. **THREAD_PRIORITY_NORMAL** is returned by the default implementation.  
  
##  \<a name="casyncmonikerfile__ondataavailable">\</a>  CAsyncMonikerFile::OnDataAvailable  
 An asynchronous moniker calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to provide data to the client as it becomes available, during asynchronous bind operations.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The cumulative amount (in bytes) of data available since the beginning of the binding. Can be zero, indicating that the amount of data is not relevant to the operation, or that no specific amount became available.  
  
 *bscfFlag*  
 A **BSCF** enumeration value. Can be one or more of the following values:  
  
-   **BSCF_FIRSTDATANOTIFICATION** Identifies the first call to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> for a given bind operation.  
  
-   **BSCF_INTERMEDIATEDATANOTIFICATION** Identifies an intermediary call to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> for a bind operation.  
  
-   **BSCF_LASTDATANOTIFICATION** Identifies the last call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> for a bind operation.  
  
### Remarks  
 The default implementation of this function does nothing. See the following example for a sample implementation.  
  
### Example  
 [!code[NVC_MFCWinInet#5](../vs140/codesnippet/CPP/casyncmonikerfile-class_1.cpp)]  
  
##  \<a name="casyncmonikerfile__onlowresource">\</a>  CAsyncMonikerFile::OnLowResource  
 Called by the moniker when resources are low.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
##  \<a name="casyncmonikerfile__onprogress">\</a>  CAsyncMonikerFile::OnProgress  
 Called by the moniker repeatedly to indicate the current progress of this bind operation, typically at reasonable intervals during a lengthy operation.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Indicates the current progress of the bind operation relative to the expected maximum indicated in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Indicates the expected maximum value of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> for the duration of calls to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> for this operation.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Provides additional information regarding the progress of the bind operation. Valid values are taken from the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> enumeration. See Remarks for possible values.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Information about the current progress, depending on the value of <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. See Remarks for possible values.  
  
### Remarks  
 Possible values for <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> (and the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> for each value) are:  
  
 **BINDSTATUS_FINDINGRESOURCE**  
 The bind operation is finding the resource that holds the object or storage being bound to. The <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> provides the display name of the resource being searched for (for example, "www.microsoft.com").  
  
 **BINDSTATUS_CONNECTING**  
 The bind operation is connecting to the resource that holds the object or storage being bound to. The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> provides the display name of the resource being connected to (for example, an IP address).  
  
 **BINDSTATUS_SENDINGREQUEST**  
 The bind operation is requesting the object or storage being bound to. The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> provides the display name of the object (for example, a file name).  
  
 **BINDSTATUS_REDIRECTING**  
 The bind operation has been redirected to a different data location. The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> provides the display name of the new data location.  
  
 **BINDSTATUS_USINGCACHEDCOPY**  
 The bind operation is retrieving the requested object or storage from a cached copy. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is **NULL**.  
  
 **BINDSTATUS_BEGINDOWNLOADDATA**  
 The bind operation has begun receiving the object or storage being bound to. The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> provides the display name of the data location.  
  
 **BINDSTATUS_DOWNLOADINGDATA**  
 The bind operation continues to receive the object or storage being bound to. The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> provides the display name of the data location.  
  
 **BINDSTATUS_ENDDOWNLOADDATA**  
 The bind operation has finished receiving the object or storage being bound to. The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> provides the display name of the data location.  
  
 **BINDSTATUS_CLASSIDAVAILABLE**  
 An instance of the object being bound to is just about to be created. The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> provides the CLSID of the new object in string format, allowing the client an opportunity to cancel the bind operation, if desired.  
  
##  \<a name="casyncmonikerfile__onstartbinding">\</a>  CAsyncMonikerFile::OnStartBinding  
 Override this function in your derived classes to perform actions when binding is starting up.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 This function is called back by the moniker. The default implementation does nothing.  
  
##  \<a name="casyncmonikerfile__onstopbinding">\</a>  CAsyncMonikerFile::OnStopBinding  
 Called by the moniker at the end of the bind operation.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> that is the error or warning value.  
  
 *szErrort*  
 A character string describing the error.  
  
### Remarks  
 Override this function to perform actions when the transfer is stopped. By default, the function releases <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
 For a description of the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="casyncmonikerfile__open">\</a>  CAsyncMonikerFile::Open  
 Call this member function to open a file asynchronously.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A pointer to file to be opened asynchronously. The file can be any valid URL or filename.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 A pointer to the file exceptions. In the event of an error, it will be set to the cause.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A pointer to the asynchronous moniker interface <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, a precise moniker that is the combination of the document's own moniker, which you can retrieve with **IOleClientSite::GetMoniker(** *OLEWHICHMK_CONTAINER* **)**, and a moniker created from the path name. The control can use this moniker to bind, but this is not the moniker the control should save.  
  
 *pBindHost*  
 A pointer to the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> interface that will be used to create the moniker from a potentially relative pathname. If the bind host is invalid or does not provide a moniker, the call defaults to **Open(** <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>**,**<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>**)**. For a description of the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> interface. If the service provider is invalid or fails to provide the service for <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, the call defaults to **Open(** <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>**,**<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>**)**.  
  
 *pUnknown*  
 A pointer to the **IUnknown** interface. If <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is found, the function queries for <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. If the service provider is invalid or fails to provide the service for <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, the call defaults to **Open(** <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>**,**<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>**)**.  
  
### Return Value  
 Nonzero if the file is opened successfully; otherwise 0.  
  
### Remarks  
 This call initiates the binding process.  
  
 You can use a URL or a filename for the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> parameter. For example:  
  
 [!code[NVC_MFCWinInet#6](../vs140/codesnippet/CPP/casyncmonikerfile-class_2.cpp)]  
  
 – or –  
  
 [!code[NVC_MFCWinInet#7](../vs140/codesnippet/CPP/casyncmonikerfile-class_3.cpp)]  
  
## See Also  
 [Base Class](../vs140/cmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonikerFile](../vs140/cmonikerfile-class.md)   
 [CDataPathProperty](../vs140/cdatapathproperty-class.md)   
 [Asynchronous Versus Synchronous Monikers](http://msdn.microsoft.com/library/windows/desktop/ms687193)