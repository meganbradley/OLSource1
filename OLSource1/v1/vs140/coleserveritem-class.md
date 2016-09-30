---
title: "COleServerItem Class"
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
  - "COleServerItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "servers, OLE"
  - "OLE server applications, managing server documents"
  - "OLE server applications, server interfaces"
  - "OLE server documents"
  - "COleServerItem class"
ms.assetid: 80256df6-3888-4256-944b-787d4b2e6b0d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem Class
Provides the server interface to OLE items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleServerItem::COleServerItem](#coleserveritem__coleserveritem)|Constructs a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleServerItem::AddOtherClipboardData](#coleserveritem__addotherclipboarddata)|Places presentation and conversion formats in a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[COleServerItem::CopyToClipboard](#coleserveritem__copytoclipboard)|Copies the item to the Clipboard.|  
|[COleServerItem::DoDragDrop](#coleserveritem__dodragdrop)|Performs a drag-and-drop operation.|  
|[COleServerItem::GetClipboardData](#coleserveritem__getclipboarddata)|Gets the data source for use in data transfer (drag and drop or Clipboard).|  
|[COleServerItem::GetDocument](#coleserveritem__getdocument)|Returns the server document that contains the item.|  
|[COleServerItem::GetEmbedSourceData](#coleserveritem__getembedsourcedata)|Gets the **CF_EMBEDSOURCE** data for an OLE item.|  
|[COleServerItem::GetItemName](#coleserveritem__getitemname)|Returns the name of the item. Used for linked items only.|  
|[COleServerItem::GetLinkSourceData](#coleserveritem__getlinksourcedata)|Gets the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> data for an OLE item.|  
|[COleServerItem::GetObjectDescriptorData](#coleserveritem__getobjectdescriptordata)|Gets the **CF_OBJECTDESCRIPTOR** data for an OLE item.|  
|[COleServerItem::IsConnected](#coleserveritem__isconnected)|Indicates whether the item is currently attached to an active container.|  
|[COleServerItem::IsLinkedItem](#coleserveritem__islinkeditem)|Indicates whether the item represents a linked OLE item.|  
|[COleServerItem::NotifyChanged](#coleserveritem__notifychanged)|Updates all containers with automatic link update.|  
|[COleServerItem::OnDoVerb](#coleserveritem__ondoverb)|Called to execute a verb.|  
|[COleServerItem::OnDraw](#coleserveritem__ondraw)|Called when the container requests to draw the item; implementation required.|  
|[COleServerItem::OnDrawEx](#coleserveritem__ondrawex)|Called for specialized item drawing.|  
|[COleServerItem::OnGetClipboardData](#coleserveritem__ongetclipboarddata)|Called by the framework to get the data that would be copied to the Clipboard.|  
|[COleServerItem::OnGetExtent](#coleserveritem__ongetextent)|Called by the framework to retrieve the size of the OLE item.|  
|[COleServerItem::OnInitFromData](#coleserveritem__oninitfromdata)|Called by the framework to initialize an OLE item using the contents of the data transfer object specified.|  
|[COleServerItem::OnQueryUpdateItems](#coleserveritem__onqueryupdateitems)|Called to determine whether any linked items require updating.|  
|[COleServerItem::OnRenderData](#coleserveritem__onrenderdata)|Retrieves data as part of delayed rendering.|  
|[COleServerItem::OnRenderFileData](#coleserveritem__onrenderfiledata)|Retrieves data into a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object as part of delayed rendering.|  
|[COleServerItem::OnRenderGlobalData](#coleserveritem__onrenderglobaldata)|Retrieves data into an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> as part of delayed rendering.|  
|[COleServerItem::OnSetColorScheme](#coleserveritem__onsetcolorscheme)|Called to set the item's color scheme.|  
|[COleServerItem::OnSetData](#coleserveritem__onsetdata)|Called to set the item's data.|  
|[COleServerItem::OnSetExtent](#coleserveritem__onsetextent)|Called by the framework to set the size of the OLE item.|  
|[COleServerItem::OnUpdate](#coleserveritem__onupdate)|Called when some portion of the document the item belongs in is changed.|  
|[COleServerItem::OnUpdateItems](#coleserveritem__onupdateitems)|Called to update the presentation cache of all items in the server document.|  
|[COleServerItem::SetItemName](#coleserveritem__setitemname)|Sets the name of the item. Used for linked items only.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleServerItem::GetDataSource](#coleserveritem__getdatasource)|Gets the object used to store conversion formats.|  
|[COleServerItem::OnHide](#coleserveritem__onhide)|Called by the framework to hide the OLE item.|  
|[COleServerItem::OnOpen](#coleserveritem__onopen)|Called by the framework to display the OLE item in its own top-level window.|  
|[COleServerItem::OnShow](#coleserveritem__onshow)|Called when the container requests to show the item.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleServerItem::m_sizeExtent](#coleserveritem__m_sizeextent)|Informs the server about how much of the OLE item is visible.|  
  
## Remarks  
 A linked item can represent some or all of a server document. An embedded item always represents an entire server document.  
  
 The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> class defines several overridable member functions that are called by the OLE system dynamic-link libraries (DLLs), usually in response to requests from the container application. These member functions allow the container application to manipulate the item indirectly in various ways, such as by displaying it, executing its verbs, or retrieving its data in various formats.  
  
 To use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, derive a class from it and implement the [OnDraw](#coleserveritem__ondraw) and [Serialize](../vs140/cobject-class.md#cobject__serialize) member functions. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function provides the metafile representation of an item, allowing it to be displayed when a container application opens a compound document. The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> function of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> provides the native representation of an item, allowing an embedded item to be transferred between the server and container applications. [OnGetExtent](#coleserveritem__ongetextent) provides the natural size of the item to the container, enabling the container to size the item.  
  
 For more information about servers and related topics, see the article [Servers: Implementing a Server](../vs140/servers--implementing-a-server.md) and "Creating a Container/Server Application" in the article [Containers: Advanced Features](../vs140/containers--advanced-features.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CDocItem](../vs140/cdocitem-class.md)  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxole.h  
  
##  \<a name="coleserveritem__addotherclipboarddata">\</a>  COleServerItem::AddOtherClipboardData  
 Call this function to place the presentation and conversion formats for the OLE item in the specified <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object in which the data should be placed.  
  
### Remarks  
 You must have implemented the [OnDraw](#coleserveritem__ondraw) member function to provide the presentation format (a metafile picture) for the item. To support other conversion formats, register them using the [COleDataSource](../vs140/coledatasource-class.md) object returned by [GetDataSource](#coleserveritem__getdatasource) and override the [OnRenderData](#coleserveritem__onrenderdata) member function to provide data in the formats you want to support.  
  
##  \<a name="coleserveritem__coleserveritem">\</a>  COleServerItem::COleServerItem  
 Constructs a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object and adds it to the server document's collection of document items.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Pointer to the document that will contain the new item.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Flag indicating whether the object can be deleted when a link to it is released. Set this to **FALSE** if the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object is an integral part of your document's data which you must delete. Set this to **TRUE** if the object is a secondary structure used to identify a range in your document's data that can be deleted by the framework.  
  
##  \<a name="coleserveritem__copytoclipboard">\</a>  COleServerItem::CopyToClipboard  
 Call this function to copy the OLE item to the Clipboard.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Set this to **TRUE** if link data should be copied to the Clipboard. Set this to **FALSE** if your server application does not support links.  
  
### Remarks  
 The function uses the [OnGetClipboardData](#coleserveritem__ongetclipboarddata) member function to create a [COleDataSource](../vs140/coledatasource-class.md) object containing the OLE item's data in the formats supported. The function then places the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object on the Clipboard by using the [COleDataSource::SetClipboard](../vs140/coledatasource-class.md#coledatasource__setclipboard) function. The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object includes the item's native data and its representation in <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> format, as well as data in any conversion formats you choose to support. You must have implemented [Serialize](../vs140/cobject-class.md#cobject__serialize) and [OnDraw](#coleserveritem__ondraw) for this member function to work.  
  
##  \<a name="coleserveritem__dodragdrop">\</a>  COleServerItem::DoDragDrop  
 Call the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> member function to perform a drag-and-drop operation.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *lpRectItem*  
 The item's rectangle on screen, in pixels, relative to the client area.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The offset from <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> where the mouse position was at the time of the drag.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Set this to **TRUE** if link data should be copied to the Clipboard. Set it to **FALSE** if your application does not support links.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Determines the effects that the drag source will allow in the drag operation (a combination of Copy, Move, and Link).  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Pointer to the rectangle that defines where the drag actually starts. For more information, see the following Remarks section.  
  
### Return Value  
 A value from the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> enumeration. If it is <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, the original data should be removed.  
  
### Remarks  
 The drag-and-drop operation does not start immediately. It waits until the mouse cursor leaves the rectangle specified by <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> or until a specified number of milliseconds have passed. If <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is **NULL**, a default rectangle is used so that the drag starts when the mouse cursor moves one pixel.  
  
 The delay time is specified by a registry key setting. You can change the delay time by calling [CWinApp::WriteProfileString](../vs140/cwinapp-class.md#cwinapp__writeprofilestring) or [CWinApp::WriteProfileInt](../vs140/cwinapp-class.md#cwinapp__writeprofileint). If you do not specify the delay time, a default value of 200 milliseconds is used. Drag delay time is stored as follows:  
  
-   Windows NT   Drag delay time is stored in HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\NT\CurrentVersion\IniFileMapping\win.ini\Windows\DragDelay.  
  
-   Windows 3.x   Drag delay time is stored in the WIN.INI file, under the [Windows} section.  
  
-   Windows 95/98   Drag delay time is stored in a cached version of WIN.INI.  
  
 For more information about how drag delay information is stored in either the registry or the .INI file, see                         [WriteProfileString](http://msdn.microsoft.com/library/windows/desktop/ms725504) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__getclipboarddata">\</a>  COleServerItem::GetClipboardData  
 Call this function to fill the specified [COleDataSource](../vs140/coledatasource-class.md) object with all the data that would be copied to the Clipboard if you called [CopyToClipboard](#coleserveritem__copytoclipboard) (the same data would also be transferred if you called [DoDragDrop](#coleserveritem__dodragdrop)).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object that will receive the OLE item's data in all supported formats.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 **TRUE** if link data should be copied to the Clipboard. **FALSE** if your server application does not support links.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The offset, in pixels, of the mouse cursor from the origin of the object.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The size of the object in pixels.  
  
### Remarks  
 This function calls the [GetEmbedSourceData](#coleserveritem__getembedsourcedata) member function to get the native data for the OLE item and calls the [AddOtherClipboardData](#coleserveritem__addotherclipboarddata) member function to get the presentation format and any supported conversion formats. If <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is **TRUE**, the function also calls [GetLinkSourceData](#coleserveritem__getlinksourcedata) to get the link data for the item.  
  
 Override this function if you want to put formats in a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object before or after those formats supplied by <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
##  \<a name="coleserveritem__getdatasource">\</a>  COleServerItem::GetDataSource  
 Call this function to get the [COleDataSource](../vs140/coledatasource-class.md) object used to store the conversion formats that the server application supports.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object used to store the conversion formats.  
  
### Remarks  
 If you want your server application to offer data in a variety of formats during data transfer operations, register those formats with the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object returned by this function. For example, if you want to supply a **CF_TEXT** representation of the OLE item for Clipboard or drag-and-drop operations, you would register the format with the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object this function returns, and then override the **OnRenderXxxData** member function to provide the data.  
  
##  \<a name="coleserveritem__getdocument">\</a>  COleServerItem::GetDocument  
 Call this function to get a pointer to the document that contains the item.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the document that contains the item; **NULL** if the item is not part of a document.  
  
### Remarks  
 This allows access to the server document that you passed as an argument to the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> constructor.  
  
##  \<a name="coleserveritem__getembedsourcedata">\</a>  COleServerItem::GetEmbedSourceData  
 Call this function to get the **CF_EMBEDSOURCE** data for an OLE item.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Pointer to the                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive the **CF_EMBEDSOURCE** data for the OLE item.  
  
### Remarks  
 This format includes the item's native data. You must have implemented the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> member function for this function to work properly.  
  
 The result can then be added to a data source by using [COleDataSource::CacheData](../vs140/coledatasource-class.md#coledatasource__cachedata). This function is called automatically by [COleServerItem::OnGetClipboardData](#coleserveritem__ongetclipboarddata).  
  
 For more information, see                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__getitemname">\</a>  COleServerItem::GetItemName  
 Call this function to get the name of the item.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The name of the item.  
  
### Remarks  
 You typically call this function only for linked items.  
  
##  \<a name="coleserveritem__getlinksourcedata">\</a>  COleServerItem::GetLinkSourceData  
 Call this function to get the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> data for an OLE item.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Pointer to the                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> data for the OLE item.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This format includes the CLSID describing the type of the OLE item and the information needed to locate the document containing the OLE item.  
  
 The result can then be added to a data source with [COleDataSource::CacheData](../vs140/coledatasource-class.md#coledatasource__cachedata). This function is called automatically by [OnGetClipboardData](#coleserveritem__ongetclipboarddata).  
  
 For more information, see                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__getobjectdescriptordata">\</a>  COleServerItem::GetObjectDescriptorData  
 Call this function to get the **CF_OBJECTDESCRIPTOR** data for an OLE item.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Offset of the mouse click from the upper-left corner of the OLE item. Can be **NULL**.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Size of the OLE item. Can be **NULL**.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Pointer to the                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure that will receive the **CF_OBJECTDESCRIPTOR** data for the OLE item.  
  
### Remarks  
 The information is copied into the **STGMEDIUM** structure pointed to by <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. This format includes the information needed for the Paste Special dialog.  
  
 For more information, see                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__isconnected">\</a>  COleServerItem::IsConnected  
 Call this function to see if the OLE item is connected.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the item is connected; otherwise 0.  
  
### Remarks  
 An OLE item is considered connected if one or more containers have references to the item. An item is connected if its reference count is greater than 0 or if it is an embedded item.  
  
##  \<a name="coleserveritem__islinkeditem">\</a>  COleServerItem::IsLinkedItem  
 Call this function to see if the OLE item is a linked item.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the item is a linked item; otherwise 0.  
  
### Remarks  
 An item is linked if the item is valid and is not returned in the document's list of embedded items. A linked item might or might not be connected to a container.  
  
 It is common to use the same class for both linked and embedded items. <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> allows you to make linked items behave differently than embedded items, although many times the code is common.  
  
##  \<a name="coleserveritem__m_sizeextent">\</a>  COleServerItem::m_sizeExtent  
 This member tells the server how much of the object is visible in the container document.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of [OnSetExtent](#coleserveritem__onsetextent) sets this member.  
  
##  \<a name="coleserveritem__notifychanged">\</a>  COleServerItem::NotifyChanged  
 Call this function after the linked item has been changed.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A value from the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> enumeration that indicates which aspect of the OLE item has changed. This parameter can have any of the following values:  
  
-   <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
### Remarks  
 If a container item is linked to the document with an automatic link, the item is updated to reflect the changes. In container applications written using the Microsoft Foundation Class Library, [COleClientItem::OnChange](../vs140/coleclientitem-class.md#coleclientitem__onchange) is called in response.  
  
##  \<a name="coleserveritem__ondoverb">\</a>  COleServerItem::OnDoVerb  
 Called by the framework to execute the specified verb.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Specifies the verb to execute. It can be any one of the following:  
  
|Value|Meaning|Symbol|  
|-----------|-------------|------------|  
|0|Primary verb|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|  
|1|Secondary verb|(None)|  
|– 1|Display item for editing|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|  
|– 2|Edit item in separate window|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
|– 3|Hide item|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|  
  
 The –1 value is typically an alias for another verb. If open editing is not supported, –2 has the same effect as –1. For additional values, see                                 [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If the container application was written with the Microsoft Foundation Class Library, this function is called when the [COleClientItem::Activate](../vs140/coleclientitem-class.md#coleclientitem__activate) member function of the corresponding <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object is called. The default implementation calls the [OnShow](#coleserveritem__onshow) member function if the primary verb or <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> is specified, [OnOpen](#coleserveritem__onopen) if the secondary verb or <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is specified, and [OnHide](#coleserveritem__onhide) if <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is specified. The default implementation calls <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is not one of the verbs listed above.  
  
 Override this function if your primary verb does not show the item. For example, if the item is a sound recording and its primary verb is Play, you would not have to display the server application to play the item.  
  
 For more information, see                         [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__ondraw">\</a>  COleServerItem::OnDraw  
 Called by the framework to render the OLE item into a metafile.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A pointer to the [CDC](../vs140/cdc-class.md) object on which to draw the item. The display context is automatically connected to the attribute display context so you can call attribute functions, although doing so would make the metafile device-specific.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Size, in **HIMETRIC** units, in which to draw the metafile.  
  
### Return Value  
 Nonzero if the item was successfully drawn; otherwise 0.  
  
### Remarks  
 The metafile representation of the OLE item is used to display the item in the container application. If the container application was written with the Microsoft Foundation Class Library, the metafile is used by the [Draw](../vs140/coleclientitem-class.md#coleclientitem__draw) member function of the corresponding [COleClientItem](../vs140/coleclientitem-class.md) object. There is no default implementation. You must override this function to draw the item into the device context specified.  
  
##  \<a name="coleserveritem__ondrawex">\</a>  COleServerItem::OnDrawEx  
 Called by the framework for all drawing.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A pointer to the [CDC](../vs140/cdc-class.md) object on which to draw the item. The DC is automatically connected to the attribute DC so you can call attribute functions, although doing so would make the metafile device-specific.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A value from the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> enumeration. This parameter can have any of the following values:  
  
-   <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Size of the item in **HIMETRIC** units.  
  
### Return Value  
 Nonzero if the item was successfully drawn; otherwise 0.  
  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>; otherwise it fails.  
  
 Override this function to provide presentation data for aspects other than <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, such as <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
##  \<a name="coleserveritem__ongetclipboarddata">\</a>  COleServerItem::OnGetClipboardData  
 Called by the framework to get a <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object containing all the data that would be placed on the Clipboard by a call to the [CopyToClipboard](#coleserveritem__copytoclipboard) member function.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Set this to **TRUE** if link data should be copied to the Clipboard. Set this to **FALSE** if your server application does not support links.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The offset of the mouse cursor from the origin of the object in pixels.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The size of the object in pixels.  
  
### Return Value  
 A pointer to a [COleDataSource](../vs140/coledatasource-class.md) object containing the Clipboard data.  
  
### Remarks  
 The default implementation of this function calls [GetClipboardData](#coleserveritem__getclipboarddata).  
  
##  \<a name="coleserveritem__ongetextent">\</a>  COleServerItem::OnGetExtent  
 Called by the framework to retrieve the size, in **HIMETRIC** units, of the OLE item.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Specifies the aspect of the OLE item whose bounds are to be retrieved. This parameter can have any of the following values:  
  
-   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object that will receive the size of the OLE item.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If the container application was written with the Microsoft Foundation Class Library, this function is called when the [GetExtent](../vs140/coleclientitem-class.md#coleclientitem__getextent) member function of the corresponding <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object is called. The default implementation does nothing. You must implement it yourself. Override this function if you want to perform special processing when handling a request for the size of the OLE item.  
  
##  \<a name="coleserveritem__onhide">\</a>  COleServerItem::OnHide  
 Called by the framework to hide the OLE item.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The default calls **COleServerDoc::OnShowDocument( FALSE )**. The function also notifies the container that the OLE item has been hidden. Override this function if you want to perform special processing when hiding an OLE item.  
  
##  \<a name="coleserveritem__oninitfromdata">\</a>  COleServerItem::OnInitFromData  
 Called by the framework to initialize an OLE item using the contents of <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Pointer to an OLE data object containing data in various formats for initializing the OLE item.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 **TRUE** if the function is called to initialize an OLE item being newly created by a container application. **FALSE** if the function is called to replace the contents of an already existing OLE item.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> is **TRUE**, this function is called if a container implements Insert New Object based on the current selection. The data selected is used when creating the new OLE item. For example, when selecting a range of cells in a spreadsheet program and then using the Insert New Object to create a chart based on the values in the selected range. The default implementation does nothing. Override this function to choose an acceptable format from those offered by <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> and initialize the OLE item based on the data provided. This is an advanced overridable.  
  
 For more information, see                         [IOleObject::InitFromData](http://msdn.microsoft.com/library/windows/desktop/ms688510) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__onopen">\</a>  COleServerItem::OnOpen  
 Called by the framework to display the OLE item in a separate instance of the server application, rather than in place.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation activates the first frame window displaying the document that contains the OLE item; if the application is a mini-server, the default implementation shows the main window. The function also notifies the container that the OLE item has been opened.  
  
 Override this function if you want to perform special processing when opening an OLE item. This is especially common with linked items where you want to set the selection to the link when it is opened.  
  
 For more information, see                         [IOleClientSite::OnShowWindow](http://msdn.microsoft.com/library/windows/desktop/ms688658) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__onqueryupdateitems">\</a>  COleServerItem::OnQueryUpdateItems  
 Called by the framework to determine whether any linked items in the current server document are out of date.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the document has items needing updates; 0 if all items are up to date.  
  
### Remarks  
 An item is out of date if its source document has been changed but the linked item has not been updated to reflect the changes in the document.  
  
##  \<a name="coleserveritem__onrenderdata">\</a>  COleServerItem::OnRenderData  
 Called by the framework to retrieve data in the specified format.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Points to a                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data is to be returned.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object using the [DelayRenderData](../vs140/coledatasource-class.md#coledatasource__delayrenderdata) or [DelayRenderFileData](../vs140/coledatasource-class.md#coledatasource__delayrenderfiledata) member function for delayed rendering. The default implementation of this function calls [OnRenderFileData](#coleserveritem__onrenderfiledata) or [OnRenderGlobalData](#coleserveritem__onrenderglobaldata), respectively, if the supplied storage medium is either a file or memory. If neither of these formats is supplied, the default implementation returns 0 and does nothing.  
  
 If <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>->                        *tymed* is **TYMED_NULL**, the **STGMEDIUM** should allocated and filled as specified by                         *lpFormatEtc->tymed*. If not **TYMED_NULL**, the **STGMEDIUM** should be filled in place with the data.  
  
 This is an advanced overridable. Override this function to provide your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If your data is small and fixed in size, override <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>. If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
 For more information, see                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431),                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812),                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177), and                         [TYMED](http://msdn.microsoft.com/library/windows/desktop/ms691227) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__onrenderfiledata">\</a>  COleServerItem::OnRenderFileData  
 Called by the framework to retrieve data in the specified format when the storage medium is a file.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object in which the data is to be rendered.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> object using the [DelayRenderData](../vs140/coledatasource-class.md#coledatasource__delayrenderdata) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 This is an advanced overridable. Override this function to provide your data in the requested format and medium. Depending on your data, you might want to override one of the other versions of this function instead. If you want to handle multiple storage mediums, override [OnRenderData](#coleserveritem__onrenderdata). If your data is in a file, or is of variable size, override [OnRenderFileData](#_mfc_coleserveritem.3a3a.onrenderfiledata).  
  
 For more information, see                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) and                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__onrenderglobaldata">\</a>  COleServerItem::OnRenderGlobalData  
 Called by the framework to retrieve data in the specified format when the specified storage medium is global memory.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Points to a handle to global memory in which the data is to be returned. If no memory has been allocated, this parameter can be **NULL**.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object using the [DelayRenderData](../vs140/coledatasource-class.md#coledatasource__delayrenderdata) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 If <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> is **NULL**, then a new <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> should be allocated and returned in <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>. Otherwise, the <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> specified by <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> should be filled with the data. The amount of data placed in the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> must not exceed the current size of the memory block. Also, the block cannot be reallocated to a larger size.  
  
 This is an advanced overridable. Override this function to provide your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If you want to handle multiple storage mediums, override [OnRenderData](#coleserveritem__onrenderdata). If your data is in a file, or is of variable size, override [OnRenderFileData](#coleserveritem__onrenderfiledata).  
  
 For more information, see                         [IDataObject::GetData](http://msdn.microsoft.com/library/windows/desktop/ms678431) and                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__onsetcolorscheme">\</a>  COleServerItem::OnSetColorScheme  
 Called by the framework to specify a color palette to be used when editing the OLE item.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Pointer to a Windows                                 [LOGPALETTE](http://msdn.microsoft.com/library/windows/desktop/dd145040) structure.  
  
### Return Value  
 Nonzero if the color palette is used; otherwise 0.  
  
### Remarks  
 If the container application was written using the Microsoft Foundation Class Library, this function is called when the                         [IOleObject::SetColorScheme](http://msdn.microsoft.com/library/windows/desktop/ms683971) function of the corresponding <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object is called. The default implementation returns **FALSE**. Override this function if you want to use the recommended palette. The server application is not required to use the suggested palette.  
  
 For more information, see                         [IOleObject::SetColorScheme](http://msdn.microsoft.com/library/windows/desktop/ms683971) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__onsetdata">\</a>  COleServerItem::OnSetData  
 Called by the framework to replace the OLE item's data with the specified data.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Pointer to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format of the data.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Pointer to a                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data resides.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Indicates who has ownership of the storage medium after completing the function call. The caller decides who is responsible for releasing the resources allocated on behalf of the storage medium. The caller does this by setting <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> is nonzero, the server item takes ownership, freeing the medium when it has finished using it. When <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> is 0, the caller retains ownership and the server item can use the storage medium only for the duration of the call.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The server item does not take ownership of the data until it has successfully obtained it. That is, it does not take ownership if it returns 0. If the data source takes ownership, it frees the storage medium by calling the                         [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) function.  
  
 The default implementation does nothing. Override this function to replace the OLE item's data with the specified data. This is an advanced overridable.  
  
 For more information, see                         [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812),                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177), and                         [ReleaseStgMedium](http://msdn.microsoft.com/library/windows/desktop/ms693491) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserveritem__onsetextent">\</a>  COleServerItem::OnSetExtent  
 Called by the framework to tell the OLE item how much space is available to it in the container document.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Specifies the aspect of the OLE item whose bounds are being specified. This parameter can have any of the following values:  
  
-   <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 A [CSize](../vs140/csize-class.md) structure specifying the new size of the OLE item.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If the container application was written with the Microsoft Foundation Class Library, this function is called when the [SetExtent](../vs140/coleclientitem-class.md#coleclientitem__setextent) member function of the corresponding <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object is called. The default implementation sets the [m_sizeExtent](#coleserveritem__m_sizeextent) member to the specified size if <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>; otherwise it returns 0. Override this function to perform special processing when you change the size of the item.  
  
##  \<a name="coleserveritem__onshow">\</a>  COleServerItem::OnShow  
 Called by the framework to instruct the server application to display the OLE item in place.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 This function is typically called when the user of the container application creates an item or executes a verb, such as Edit, that requires the item to be shown. The default implementation attempts in-place activation. If this fails, the function calls the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> member function to display the OLE item in a separate window.  
  
 Override this function if you want to perform special processing when an OLE item is shown.  
  
##  \<a name="coleserveritem__onupdate">\</a>  COleServerItem::OnUpdate  
 Called by the framework when an item has been modified.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 Pointer to the item that modified the document. Can be **NULL**.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 Contains information about the modification.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 Pointer to an object storing information about the modification.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 A value from the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> enumeration. This parameter can have any one of the following values:  
  
-   <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
### Remarks  
 The default implementation calls [NotifyChanged](#coleserveritem__notifychanged), regardless of the hint or sender.  
  
##  \<a name="coleserveritem__onupdateitems">\</a>  COleServerItem::OnUpdateItems  
 Called by the framework to update all items in the server document.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation calls [UpdateLink](../vs140/coleclientitem-class.md#coleclientitem__updatelink) for all <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> objects in the document.  
  
##  \<a name="coleserveritem__setitemname">\</a>  COleServerItem::SetItemName  
 Call this function when you create a linked item to set its name.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 Pointer to the new name of the item.  
  
### Remarks  
 The name must be unique within the document. When a server application is called to edit a linked item, the application uses this name to find the item. You do not need to call this function for embedded items.  
  
## See Also  
 [MFC Sample HIERSVR](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cdocitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem](../vs140/coleclientitem-class.md)   
 [COleServerDoc](../vs140/coleserverdoc-class.md)   
 [COleTemplateServer](../vs140/coletemplateserver-class.md)