---
title: "COleDataObject Class"
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
  - "IDataObject"
  - "COleDataObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drag and drop [C++], MFC support"
  - "Clipboard [C++], OLE support"
  - "uniform data transfer"
  - "OLE [C++], uniform data transfer"
  - "Clipboard [C++], MFC support"
  - "OLE Clipboard [C++], support"
  - "IDataObject interface, MFC encapsulation"
  - "data transfer [C++]"
  - "data transfer [C++], OLE"
  - "OLE data transfer [C++]"
  - "COleDataObject class"
  - "uniform data transfer, OLE"
ms.assetid: d1cc84be-2e1c-4bb3-a8a0-565eb08aaa34
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject Class
Used in data transfers for retrieving data in various formats from the Clipboard, through drag and drop, or from an embedded OLE item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDataObject::COleDataObject](#coledataobject__coledataobject)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDataObject::Attach](#coledataobject__attach)|Attaches the specified OLE data object to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|[COleDataObject::AttachClipboard](#coledataobject__attachclipboard)|Attaches the data object that is on the Clipboard.|  
|[COleDataObject::BeginEnumFormats](#coledataobject__beginenumformats)|Prepares for one or more subsequent <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> calls.|  
|[COleDataObject::Detach](#coledataobject__detach)|Detaches the associated <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[COleDataObject::GetData](#coledataobject__getdata)|Copies data from the attached OLE data object in a specified format.|  
|[COleDataObject::GetFileData](#coledataobject__getfiledata)|Copies data from the attached OLE data object into a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pointer in the specified format.|  
|[COleDataObject::GetGlobalData](#coledataobject__getglobaldata)|Copies data from the attached OLE data object into an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in the specified format.|  
|[COleDataObject::GetNextFormat](#coledataobject__getnextformat)|Returns the next data format available.|  
|[COleDataObject::IsDataAvailable](#coledataobject__isdataavailable)|Checks whether data is available in a specified format.|  
|[COleDataObject::Release](#coledataobject__release)|Detaches and releases the associated <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> does not have a base class.  
  
 These kinds of data transfers include a source and a destination. The data source is implemented as an object of the [COleDataSource](../vs140/coledatasource-class.md) class. Whenever a destination application has data dropped in it or is asked to perform a paste operation from the Clipboard, an object of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class must be created.  
  
 This class enables you to determine whether the data exists in a specified format. You can also enumerate the available data formats or check whether a given format is available and then retrieve the data in the preferred format. Object retrieval can be accomplished in several different ways, including the use of a [CFile](../vs140/cfile-class.md), an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or an **STGMEDIUM** structure.  
  
 For more information, see the                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about using data objects in your application, see the article [Data Objects and Data Sources (OLE)](../vs140/data-objects-and-data-sources--ole-.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxole.h  
  
##  \<a name="coledataobject__attach">\</a>  COleDataObject::Attach  
 Call this function to associate the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object with an OLE data object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *lpDataObject*  
 Points to an OLE data object.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 **TRUE** if the OLE data object should be released when the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object is destroyed; otherwise **FALSE**.  
  
### Remarks  
 For more information, see                         [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledataobject__attachclipboard">\</a>  COleDataObject::AttachClipboard  
 Call this function to attach the data object that is currently on the Clipboard to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
  
> [!NOTE]
>  Calling this function locks the Clipboard until this data object is released. The data object is released in the destructor for the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For more information, see                             [OpenClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649048) and                             [CloseClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649035) in the Win32 documention.  
  
##  \<a name="coledataobject__beginenumformats">\</a>  COleDataObject::BeginEnumFormats  
 Call this function to prepare for subsequent calls to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> for retrieving a list of data formats from the item.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 After a call to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the position of the first format supported by this data object is stored. Successive calls to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> will enumerate the list of available formats in the data object.  
  
 To check on the availability of data in a given format, use [COleDataObject::IsDataAvailable](#coledataobject__isdataavailable).  
  
 For more information, see                         [IDataObject::EnumFormatEtc](http://msdn.microsoft.com/library/windows/desktop/ms683979) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledataobject__coledataobject">\</a>  COleDataObject::COleDataObject  
 Constructs a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 A call to [COleDataObject::Attach](#coledataobject__attach) or [COleDataObject::AttachClipboard](#coledataobject__attachclipboard) must be made before calling other <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> functions.  
  
> [!NOTE]
>  Since one of the parameters to the drag-and-drop handlers is a pointer to a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, there is no need to call this constructor to support drag and drop.  
  
##  \<a name="coledataobject__detach">\</a>  COleDataObject::Detach  
 Call this function to detach the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object from its associated OLE data object without releasing the data object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the OLE data object that was detached.  
  
### Remarks  
  
##  \<a name="coledataobject__getdata">\</a>  COleDataObject::GetData  
 Call this function to retrieve data from the item in the specified format.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The format in which data is to be returned. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Points to a                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive data.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which data is to be returned. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 For more information, see                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431),                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812), and                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledataobject__getfiledata">\</a>  COleDataObject::GetFileData  
 Call this function to create a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>-derived object and to retrieve data in the specified format into a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> pointer.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The format in which data is to be returned. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which data is to be returned. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
### Return Value  
 Pointer to the new <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>-derived object containing the data if successful; otherwise **NULL**.  
  
### Remarks  
 Depending on the medium the data is stored in, the actual type pointed to by the return value may be <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object accessed by the return value of this function is owned by the caller. It is the responsibility of the caller to **delete** the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object, thereby closing the file.  
  
 For more information, see                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledataobject__getglobaldata">\</a>  COleDataObject::GetGlobalData  
 Call this function to allocate a global memory block and to retrieve data in the specified format into an <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The format in which data is to be returned. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format in which data is to be returned. Provide a value for this parameter if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
### Return Value  
 The handle of the global memory block containing the data if successful; otherwise **NULL**.  
  
### Remarks  
 For more information, see                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledataobject__getnextformat">\</a>  COleDataObject::GetNextFormat  
 Call this function repeatedly to obtain all the formats available for retrieving data from the item.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure that receives the format information when the function call returns.  
  
### Return Value  
 Nonzero if another format is available; otherwise 0.  
  
### Remarks  
 After a call to [COleDataObject::BeginEnumFormats](#coledataobject__beginenumformats), the position of the first format supported by this data object is stored. Successive calls to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> will enumerate the list of available formats in the data object. Use these functions to list the available formats.  
  
 To check for the availability of a given format, call [COleDataObject::IsDataAvailable](#coledataobject__isdataavailable).  
  
 For more information, see                         [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledataobject__isdataavailable">\</a>  COleDataObject::IsDataAvailable  
 Call this function to determine if a particular format is available for retrieving data from the OLE item.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The Clipboard data format to be used in the structure pointed to by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. This parameter can be one of the predefined Clipboard formats or the value returned by the native Windows                                 [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) function.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Points to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure describing the format desired. Provide a value for this parameter only if you want to specify additional format information beyond the Clipboard format specified by <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. If it is **NULL**, the default values are used for the other fields in the **FORMATETC** structure.  
  
### Return Value  
 Nonzero if data is available in the specified format; otherwise 0.  
  
### Remarks  
 This function is useful before calling <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 For more information, see                         [IDataObject::QueryGetData](http://msdn.microsoft.com/library/windows/desktop/ms680637) and                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see                         [RegisterClipboardFormat](http://msdn.microsoft.com/library/windows/desktop/ms649049) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [CRichEditView::QueryAcceptData](../vs140/cricheditview-class.md#cricheditview__queryacceptdata).  
  
##  \<a name="coledataobject__release">\</a>  COleDataObject::Release  
 Call this function to release ownership of the                 [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) object that was previously associated with the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> was associated with the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> by calling **Attach** or <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> explicitly or by the framework. If the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> parameter of **Attach** is **FALSE**, the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object will not be released. In this case, the caller is responsible for releasing the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> by calling                         [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317).  
  
## See Also  
 [MFC Sample HIERSVR](../vs140/visual-c---samples.md)   
 [MFC Sample OCLIENT](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource](../vs140/coledatasource-class.md)   
 [COleClientItem](../vs140/coleclientitem-class.md)   
 [COleServerItem](../vs140/coleserveritem-class.md)   
 [COleDataSource::DoDragDrop](../vs140/coledatasource-class.md#coledatasource__dodragdrop)   
 [CView::OnDrop](../vs140/cview-class.md#cview__ondrop)