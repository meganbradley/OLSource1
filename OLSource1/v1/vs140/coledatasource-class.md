---
title: "COleDataSource Class"
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
  - "COleDataSource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drag and drop [C++], MFC support"
  - "Clipboard [C++], OLE support"
  - "uniform data transfer"
  - "OLE [C++], uniform data transfer"
  - "Clipboard [C++], MFC support"
  - "OLE Clipboard [C++], support"
  - "IDataObject, MFC encapsulation"
  - "data transfer [C++], OLE"
  - "COleDataSource class"
  - "OLE data transfer [C++]"
  - "uniform data transfer, OLE"
ms.assetid: 02c8ee7d-8e10-4463-8613-bb2a0305ca69
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource Class
Acts as a cache into which an application places the data that it will offer during data transfer operations, such as Clipboard or drag-and-drop operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDataSource::COleDataSource](#coledatasource__coledatasource)|Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDataSource::CacheData](#coledatasource__cachedata)|Offers data in a specified format using a **STGMEDIUM** structure.|  
|[COleDataSource::CacheGlobalData](#coledatasource__cacheglobaldata)|Offers data in a specified format using an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|[COleDataSource::DelayRenderData](#coledatasource__delayrenderdata)|Offers data in a specified format using delayed rendering.|  
|[COleDataSource::DelayRenderFileData](#coledatasource__delayrenderfiledata)|Offers data in a specified format in a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> pointer.|  
|[COleDataSource::DelaySetData](#coledatasource__delaysetdata)|Called for every format that is supported in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|[COleDataSource::DoDragDrop](#coledatasource__dodragdrop)|Performs drag-and-drop operations with a data source.|  
|[COleDataSource::Empty](#coledatasource__empty)|Empties the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object of data.|  
|[COleDataSource::FlushClipboard](#coledatasource__flushclipboard)|Renders all data to the Clipboard.|  
|[COleDataSource::GetClipboardOwner](#coledatasource__getclipboardowner)|Verifies that the data placed on the Clipboard is still there.|  
|[COleDataSource::OnRenderData](#coledatasource__onrenderdata)|Retrieves data as part of delayed rendering.|  
|[COleDataSource::OnRenderFileData](#coledatasource__onrenderfiledata)|Retrieves data into a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> as part of delayed rendering.|  
|[COleDataSource::OnRenderGlobalData](#coledatasource__onrenderglobaldata)|Retrieves data into an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> as part of delayed rendering.|  
|[COleDataSource::OnSetData](#coledatasource__onsetdata)|Called to replace the data in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
|[COleDataSource::SetClipboard](#coledatasource__setclipboard)|Places a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object on the Clipboard.|  
  
## Remarks  
 You can create OLE data sources directly. Alternately, the [COleClientItem](../vs140/coleclientitem-class.md) and [COleServerItem](../vs140/coleserveritem-class.md) classes create OLE data sources in response to their <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> member functions. See [COleServerItem::CopyToClipboard](../vs140/coleserveritem-class.md#coleserveritem__copytoclipboard) for a brief description. Override the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member function of your client item or server item class to add additional Clipboard formats to the data in the OLE data source created for the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function.  
  
 Whenever you want to prepare data for a transfer, you should create an object of this class and fill it with your data using the most appropriate method for your data. The way it is inserted into a data source is directly affected by whether the data is supplied immediately (immediate rendering) or on demand (delayed rendering). For every Clipboard format in which you are providing data by passing the Clipboard format to be used (and an optional                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure), call [DelayRenderData](#coledatasource__delayrenderdata).  
  
 For more information about data sources and data transfer, see the article [Data Objects and Data Sources (OLE)](../vs140/data-objects-and-data-sources--ole-.md). In addition, the article [Clipboard Topics](../vs140/clipboard.md) describes the OLE Clipboard mechanism.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxole.h  
  
##  \<a name="coledatasource__cachedata">\</a>  COleDataSource::CacheData  
 Call this function to specify a format in which data is offered during data transfer operations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be offered. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Points to a                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure containing the data in the format specified.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be offered. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
### Remarks  
 You must supply the data, because this function provides it by using immediate rendering. The data is cached until needed.  
  
 Supply the data using a                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure. You can also use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> member function if the amount of data you are supplying is small enough to be transferred efficiently using an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 After the call to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> the **ptd** member of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and the contents of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> are owned by the data object, not by the caller.  
  
 To use delayed rendering, call the [DelayRenderData](#coledatasource__delayrenderdata) or [DelayRenderFileData](#coledatasource__delayrenderfiledata) member function. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) and                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledatasource__cacheglobaldata">\</a>  COleDataSource::CacheGlobalData  
 Call this function to specify a format in which data is offered during data transfer operations.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be offered. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 *hGlobal*  
 Handle to the global memory block containing the data in the format specified.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be offered. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
### Remarks  
 This function provides the data using immediate rendering, so you must supply the data when calling the function; the data is cached until needed. Use the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> member function if you are supplying a large amount of data or if you require a structured storage medium.  
  
 To use delayed rendering, call the [DelayRenderData](#coledatasource__delayrenderdata) or [DelayRenderFileData](#coledatasource__delayrenderfiledata) member function. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledatasource__coledatasource">\</a>  COleDataSource::COleDataSource  
 Constructs a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="coledatasource__delayrenderdata">\</a>  COleDataSource::DelayRenderData  
 Call this function to specify a format in which data is offered during data transfer operations.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be offered. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be offered. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
### Remarks  
 This function provides the data using delayed rendering, so the data is not supplied immediately. The [OnRenderData](#coledatasource__onrenderdata) or [OnRenderGlobalData](#coledatasource__onrenderglobaldata) member function is called to request the data.  
  
 Use this function if you are not going to supply your data through a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object. If you are going to supply the data through a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object, call the [DelayRenderFileData](#coledatasource__delayrenderfiledata) member function. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 To use immediate rendering, call the [CacheData](#coledatasource__cachedata) or [CacheGlobalData](#coledatasource__cacheglobaldata) member function.  
  
 For more information, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledatasource__delayrenderfiledata">\</a>  COleDataSource::DelayRenderFileData  
 Call this function to specify a format in which data is offered during data transfer operations.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be offered. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be offered. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
### Remarks  
 This function provides the data using delayed rendering, so the data is not supplied immediately. The [OnRenderFileData](#coledatasource__onrenderfiledata) member function is called to request the data.  
  
 Use this function if you are going to use a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object to supply the data. If you are not going to use a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object, call the [DelayRenderData](#coledatasource__delayrenderdata) member function. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 To use immediate rendering, call the [CacheData](#coledatasource__cachedata) or [CacheGlobalData](#coledatasource__cacheglobaldata) member function.  
  
 For more information, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledatasource__delaysetdata">\</a>  COleDataSource::DelaySetData  
 Call this function to support changing the contents of the data source.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The Clipboard format in which the data is to be placed. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which the data is to be replaced. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. If it is **NULL**, default values are used for the other fields in the **FORMATETC** structure.  
  
### Remarks  
 [OnSetData](#coledatasource__onsetdata) will be called by the framework when this happens. This is only used when the framework returns the data source from [COleServerItem::GetDataSource](../vs140/coleserveritem-class.md#coleserveritem__getdatasource). If <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is not called, your <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> function will never be called. <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> should be called for each Clipboard or **FORMATETC** format you support.  
  
 For more information, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledatasource__dodragdrop">\</a>  COleDataSource::DoDragDrop  
 Call the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> member function to perform a drag-and-drop operation for this data source, typically in an [CWnd::OnLButtonDown](../vs140/cwnd-class.md#cwnd__onlbuttondown) handler.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Drag-and-drop operations that are allowed on this data source. Can be one or more of the following:  
  
-   <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> A copy operation could be performed.  
  
-   <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> A move operation could be performed.  
  
-   <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> A link from the dropped data to the original data could be established.  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> Indicates that a drag scroll operation could occur.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Pointer to the rectangle that defines where the drag actually starts. For more information, see the following Remarks section.  
  
 *pDropSource*  
 Points to a drop source. If **NULL** then a default implementation of [COleDropSource](../vs140/coledropsource-class.md) will be used.  
  
### Return Value  
 Drop effect generated by the drag-and-drop operation; otherwise <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> if the operation never begins because the user released the mouse button before leaving the supplied rectangle.  
  
### Remarks  
 The drag-and-drop operation does not start immediately. It waits until the mouse cursor leaves the rectangle specified by <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or until a specified number of milliseconds have passed. If <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is **NULL**, the size of the rectangle is one pixel.  
  
 The delay time is specified by a registry key setting. You can change the delay time by calling [CWinApp::WriteProfileString](../vs140/cwinapp-class.md#cwinapp__writeprofilestring) or [CWinApp::WriteProfileInt](../vs140/cwinapp-class.md#cwinapp__writeprofileint). If you do not specify the delay time, a default value of 200 milliseconds is used. Drag delay time is stored as follows:  
  
-   Windows NT   Drag delay time is stored in HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\NT\CurrentVersion\IniFileMapping\win.ini\Windows\DragDelay.  
  
-   Windows 3.x   Drag delay time is stored in the WIN.INI file, under the [Windows} section.  
  
-   Windows 95/98   Drag delay time is stored in a cached version of WIN.INI.  
  
 For more information about how drag delay information is stored in either the registry or the .INI file, see                         [WriteProfileString](http://msdn.microsoft.com/library/windows/desktop/ms725504) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see the article [Drag and Drop: Implementing a Drop Source](../vs140/drag-and-drop--implementing-a-drop-source.md).  
  
##  \<a name="coledatasource__empty">\</a>  COleDataSource::Empty  
 Call this function to empty the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object of data.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Both cached and delay render formats are emptied so they can be reused.  
  
 For more information, see                         [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledatasource__flushclipboard">\</a>  COleDataSource::FlushClipboard  
 Renders data that is on the Clipboard, and then lets you paste data from the Clipboard after your application shuts down.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 Use [SetClipboard](#coledatasource__setclipboard) to put data on the Clipboard.  
  
##  \<a name="coledatasource__getclipboardowner">\</a>  COleDataSource::GetClipboardOwner  
 Determines whether the data on the Clipboard has changed since [SetClipboard](#coledatasource__setclipboard) was last called and, if so, identifies the current owner.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The data source currently on the Clipboard, or **NULL** if there is nothing on the Clipboard or if the Clipboard is not owned by the calling application.  
  
##  \<a name="coledatasource__onrenderdata">\</a>  COleDataSource::OnRenderData  
 Called by the framework to retrieve data in the specified format.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Points to a                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data is to be returned.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object using the [DelayRenderData](#coledatasource__delayrenderdata) or [DelayRenderFileData](#coledatasource__delayrenderfiledata) member function for delayed rendering. The default implementation of this function will call [OnRenderFileData](#coledatasource__onrenderfiledata) or [OnRenderGlobalData](#coledatasource__onrenderglobaldata) if the supplied storage medium is either a file or memory, respectively. If neither of these formats are supplied, then the default implementation will return 0 and do nothing. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 If <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>->                        *tymed* is **TYMED_NULL**, the **STGMEDIUM** should be allocated and filled as specified by                         *lpFormatEtc->tymed*. If it is not **TYMED_NULL**, the **STGMEDIUM** should be filled in place with the data.  
  
 This is an advanced overridable. Override this function to supply your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If your data is small and fixed in size, override <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 For more information, see the                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) and                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structures, the                         [TYMED](http://msdn.microsoft.com/library/windows/desktop/ms691227) enumeration type, and                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
##  \<a name="coledatasource__onrenderfiledata">\</a>  COleDataSource::OnRenderFileData  
 Called by the framework to retrieve data in the specified format when the specified storage medium is a file.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Points to a [CFile](../vs140/cfile-class.md) object in which the data is to be rendered.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object using the [DelayRenderData](#coledatasource__delayrenderdata) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 This is an advanced overridable. Override this function to supply your data in the requested format and medium. Depending on your data, you might want to override one of the other versions of this function instead. If you want to handle multiple storage media, override [OnRenderData](#coledatasource__onrenderdata). If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure and                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
##  \<a name="coledatasource__onrenderglobaldata">\</a>  COleDataSource::OnRenderGlobalData  
 Called by the framework to retrieve data in the specified format when the specified storage medium is global memory.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Points to a handle to global memory in which the data is to be returned. If one has not yet been allocated, this parameter can be **NULL**.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object using the [DelayRenderData](#coledatasource__delayrenderdata) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 If <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is **NULL**, then a new <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> should be allocated and returned in <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. Otherwise, the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> specified by <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> should be filled with the data. The amount of data placed in the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> must not exceed the current size of the memory block. Also, the block cannot be reallocated to a larger size.  
  
 This is an advanced overridable. Override this function to supply your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If you want to handle multiple storage media, override [OnRenderData](#coledatasource__onrenderdata). If your data is in a file, or is of variable size, override [OnRenderFileData](#coledatasource__onrenderfiledata). For more information on delayed rendering as handled by MFC, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure and                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
##  \<a name="coledatasource__onsetdata">\</a>  COleDataSource::OnSetData  
 Called by the framework to set or replace the data in the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object in the specified format.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which data is being replaced.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Points to the                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure containing the data that will replace the current contents of the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Indicates who has ownership of the storage medium after completing the function call. The caller decides who is responsible for releasing the resources allocated on behalf of the storage medium. The caller does this by setting <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is nonzero, the data source takes ownership, freeing the medium when it has finished using it. When <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is 0, the caller retains ownership and the data source can use the storage medium only for the duration of the call.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The data source does not take ownership of the data until it has successfully obtained it. That is, it does not take ownership if <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> returns 0. If the data source takes ownership, it frees the storage medium by calling the                         [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) function.  
  
 The default implementation does nothing. Override this function to replace the data in the specified format. This is an advanced overridable.  
  
 For more information, see the                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) and                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structures and the                         [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) and                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) functions in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
##  \<a name="coledatasource__setclipboard">\</a>  COleDataSource::SetClipboard  
 Puts the data contained in the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object on the Clipboard after calling one of the following functions: [CacheData](#coledatasource__cachedata), [CacheGlobalData](#coledatasource__cacheglobaldata), [DelayRenderData](#coledatasource__delayrenderdata), or [DelayRenderFileData](#coledatasource__delayrenderfiledata).  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
## See Also  
 [MFC Sample HIERSVR](../vs140/visual-c---samples.md)   
 [MFC Sample OCLIENT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject](../vs140/coledataobject-class.md)