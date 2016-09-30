---
title: "COleServerDoc Class"
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
  - "COleServerDoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "servers, OLE"
  - "OLE server applications, managing server documents"
  - "container/server applications"
  - "OLE server documents"
  - "COleServerDoc class"
  - "server documents, OLE"
  - "OLE containers, server documents"
ms.assetid: a9cdd96a-e0ac-43bb-9203-2c29237e965c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc Class
The base class for OLE server documents.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleServerDoc::COleServerDoc](#coleserverdoc__coleserverdoc)|Constructs a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleServerDoc::ActivateDocObject](#coleserverdoc__activatedocobject)|Activates the associated DocObject document.|  
|[COleServerDoc::ActivateInPlace](#coleserverdoc__activateinplace)|Activates the document for in-place editing.|  
|[COleServerDoc::DeactivateAndUndo](#coleserverdoc__deactivateandundo)|Deactivates the server's user interface.|  
|[COleServerDoc::DiscardUndoState](#coleserverdoc__discardundostate)|Discards undo-state information.|  
|[COleServerDoc::GetClientSite](#coleserverdoc__getclientsite)|Retrieves a pointer to the underlying <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> interface.|  
|[COleServerDoc::GetEmbeddedItem](#coleserverdoc__getembeddeditem)|Returns a pointer to an item representing the entire document.|  
|[COleServerDoc::GetItemClipRect](#coleserverdoc__getitemcliprect)|Returns the current clipping rectangle for in-place editing.|  
|[COleServerDoc::GetItemPosition](#coleserverdoc__getitemposition)|Returns the current position rectangle, relative to the container application's client area, for in-place editing.|  
|[COleServerDoc::GetZoomFactor](#coleserverdoc__getzoomfactor)|Returns the zoom factor in pixels.|  
|[COleServerDoc::IsDocObject](#coleserverdoc__isdocobject)|Determines if the document is a DocObject.|  
|[COleServerDoc::IsEmbedded](#coleserverdoc__isembedded)|Indicates whether the document is embedded in a container document or running stand-alone.|  
|[COleServerDoc::IsInPlaceActive](#coleserverdoc__isinplaceactive)|Returns <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if the item is currently activated in place.|  
|[COleServerDoc::NotifyChanged](#coleserverdoc__notifychanged)|Notifies containers that the user has changed the document.|  
|[COleServerDoc::NotifyClosed](#coleserverdoc__notifyclosed)|Notifies containers that the user has closed the document.|  
|[COleServerDoc::NotifyRename](#coleserverdoc__notifyrename)|Notifies containers that the user has renamed the document.|  
|[COleServerDoc::NotifySaved](#coleserverdoc__notifysaved)|Notifies containers that the user has saved the document.|  
|[COleServerDoc::OnDeactivate](#coleserverdoc__ondeactivate)|Called by the framework when the user deactivates an item that was activated in place.|  
|[COleServerDoc::OnDeactivateUI](#coleserverdoc__ondeactivateui)|Called by the framework to destroy controls and other user-interface elements created for in-place activation.|  
|[COleServerDoc::OnDocWindowActivate](#coleserverdoc__ondocwindowactivate)|Called by the framework when the container's document frame window is activated or deactivated.|  
|[COleServerDoc::OnResizeBorder](#coleserverdoc__onresizeborder)|Called by the framework when the container application's frame window or document window is resized.|  
|[COleServerDoc::OnShowControlBars](#coleserverdoc__onshowcontrolbars)|Called by the framework to show or hide control bars for in-place editing.|  
|[COleServerDoc::OnUpdateDocument](#coleserverdoc__onupdatedocument)|Called by the framework when a server document that is an embedded item is saved, updating the container's copy of the item.|  
|[COleServerDoc::RequestPositionChange](#coleserverdoc__requestpositionchange)|Changes the position of the in-place editing frame.|  
|[COleServerDoc::SaveEmbedding](#coleserverdoc__saveembedding)|Tells the container application to save the document.|  
|[COleServerDoc::ScrollContainerBy](#coleserverdoc__scrollcontainerby)|Scrolls the container document.|  
|[COleServerDoc::UpdateAllItems](#coleserverdoc__updateallitems)|Notifies containers that the user has changed the document.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleServerDoc::CreateInPlaceFrame](#coleserverdoc__createinplaceframe)|Called by the framework to create a frame window for in-place editing.|  
|[COleServerDoc::DestroyInPlaceFrame](#coleserverdoc__destroyinplaceframe)|Called by the framework to destroy a frame window for in-place editing.|  
|[COleServerDoc::GetDocObjectServer](#coleserverdoc__getdocobjectserver)|Override this function to create a new <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object and indicate that this document is a DocObject container.|  
|[COleServerDoc::OnClose](#coleserverdoc__onclose)|Called by the framework when a container requests to close the document.|  
|[COleServerDoc::OnExecOleCmd](#coleserverdoc__onexecolecmd)|Executes a specified command or displays help for the command.|  
|[COleServerDoc::OnFrameWindowActivate](#coleserverdoc__onframewindowactivate)|Called by the framework when the container's frame window is activated or deactivated.|  
|[COleServerDoc::OnGetEmbeddedItem](#coleserverdoc__ongetembeddeditem)|Called to get a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> that represents the entire document; used to get an embedded item. Implementation required.|  
|[COleServerDoc::OnReactivateAndUndo](#coleserverdoc__onreactivateandundo)|Called by the framework to undo changes made during in-place editing.|  
|[COleServerDoc::OnSetHostNames](#coleserverdoc__onsethostnames)|Called by the framework when a container sets the window title for an embedded object.|  
|[COleServerDoc::OnSetItemRects](#coleserverdoc__onsetitemrects)|Called by the framework to position the in-place editing frame window within the container application's window.|  
|[COleServerDoc::OnShowDocument](#coleserverdoc__onshowdocument)|Called by the framework to show or hide the document.|  
  
## Remarks  
 A server document can contain [COleServerItem](../vs140/coleserveritem-class.md) objects, which represent the server interface to embedded or linked items. When a server application is launched by a container to edit an embedded item, the item is loaded as its own server document; the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object contains just one <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object, consisting of the entire document. When a server application is launched by a container to edit a linked item, an existing document is loaded from disk; a portion of the document's contents is highlighted to indicate the linked item.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> objects can also contain items of the [COleClientItem](../vs140/coleclientitem-class.md) class. This allows you to create container-server applications. The framework provides functions to properly store the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> items while servicing the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> objects.  
  
 If your server application does not support links, a server document will always contain only one server item, which represents the entire embedded object as a document. If your server application does support links, it must create a server item each time a selection is copied to the Clipboard.  
  
 To use <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, derive a class from it and implement the [OnGetEmbeddedItem](#coleserverdoc__ongetembeddeditem) member function, which allows your server to support embedded items. Derive a class from <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to implement the items in your documents, and return objects of that class from <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 To support linked items, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> provides the [OnGetLinkedItem](../vs140/colelinkingdoc-class.md#colelinkingdoc__ongetlinkeditem) member function. You can use the default implementation or override it if you have your own way of managing document items.  
  
 You need one <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>-derived class for each type of server document your application supports. For example, if your server application supports worksheets and charts, you need two <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>-derived classes.  
  
 For more information on servers, see the article [Servers: Implementing a Server](../vs140/servers--implementing-a-server.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CDocument](../vs140/cdocument-class.md)  
  
 [COleDocument](../vs140/coledocument-class.md)  
  
 [COleLinkingDoc](../vs140/colelinkingdoc-class.md)  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxole.h  
  
##  \<a name="coleserverdoc__activatedocobject">\</a>  COleServerDoc::ActivateDocObject  
 Activates the associated DocObject document.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 By default, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> does not support Active documents (also referred to as DocObjects). To enable this support, see [GetDocObjectServer](#coleserverdoc__getdocobjectserver) and class [CDocObjectServer](../vs140/cdocobjectserver-class.md).  
  
##  \<a name="coleserverdoc__activateinplace">\</a>  COleServerDoc::ActivateInPlace  
 Activates the item for in-place editing.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0, which indicates that the item is fully open.  
  
### Remarks  
 This function performs all operations necessary for in-place activation. It creates an in-place frame window, activates it and sizes it to the item, sets up shared menus and other controls, scrolls the item into view, and sets the focus to the in-place frame window.  
  
 This function is called by the default implementation of [COleServerItem::OnShow](../vs140/coleserveritem-class.md#coleserveritem__onshow). Call this function if your application supports another verb for in-place activation (such as Play).  
  
##  \<a name="coleserverdoc__coleserverdoc">\</a>  COleServerDoc::COleServerDoc  
 Constructs a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object without connecting with the OLE system DLLs.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 You must call [COleLinkingDoc::Register](../vs140/colelinkingdoc-class.md#colelinkingdoc__register) to open communications with OLE. If you are using [COleTemplateServer](../vs140/coletemplateserver-class.md) in your application, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is called for you by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>'s implementation of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
##  \<a name="coleserverdoc__createinplaceframe">\</a>  COleServerDoc::CreateInPlaceFrame  
 The framework calls this function to create a frame window for in-place editing.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Pointer to the container application's parent window.  
  
### Return Value  
 A pointer to the in-place frame window, or **NULL** if unsuccessful.  
  
### Remarks  
 The default implementation uses information specified in the document template to create the frame. The view used is the first view created for the document. This view is temporarily detached from the original frame and attached to the newly created frame.  
  
 This is an advanced overridable.  
  
##  \<a name="coleserverdoc__deactivateandundo">\</a>  COleServerDoc::DeactivateAndUndo  
 Call this function if your application supports Undo and the user chooses Undo after activating an item but before editing it.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero on success; otherwise 0.  
  
### Remarks  
 If the container application is written using the Microsoft Foundation Class Library, calling this function causes [COleClientItem::OnDeactivateAndUndo](../vs140/coleclientitem-class.md#coleclientitem__ondeactivateandundo) to be called, which deactivates the server's user interface.  
  
##  \<a name="coleserverdoc__destroyinplaceframe">\</a>  COleServerDoc::DestroyInPlaceFrame  
 The framework calls this function to destroy an in-place frame window and return the server application's document window to its state before in-place activation.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Pointer to the in-place frame window to be destroyed.  
  
### Remarks  
 This is an advanced overridable.  
  
##  \<a name="coleserverdoc__discardundostate">\</a>  COleServerDoc::DiscardUndoState  
 If the user performs an editing operation that cannot be undone, call this function to force the container application to discard its undo-state information.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero on success; otherwise 0.  
  
### Remarks  
 This function is provided so that servers that support Undo can free resources that would otherwise be consumed by undo-state information that cannot be used.  
  
##  \<a name="coleserverdoc__getclientsite">\</a>  COleServerDoc::GetClientSite  
 Retrieves a pointer to the underlying <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Retrieves a pointer to the underlying                         [IOleClientSite](http://msdn.microsoft.com/library/windows/desktop/ms693706) interface.  
  
##  \<a name="coleserverdoc__getdocobjectserver">\</a>  COleServerDoc::GetDocObjectServer  
 Override this function to create a new <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> item and return a pointer to it.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> interface that will connect this document to the server.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>; **NULL** if the operation failed.  
  
### Remarks  
 When a DocObject server is activated, the return of a non- **NULL** pointer shows that the client can support DocObjects. The default implementation returns **NULL**.  
  
 A typical implementation for a document that supports DocObjects will simply allocate a new <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object and return it to the caller. For example:  
  
 [!code[NVC_MFCOleServer#3](../vs140/codesnippet/CPP/coleserverdoc-class_1.cpp)]  
  
##  \<a name="coleserverdoc__getembeddeditem">\</a>  COleServerDoc::GetEmbeddedItem  
 Call this function to get a pointer to an item representing the entire document.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an item representing the entire document; **NULL** if the operation failed.  
  
### Remarks  
 It calls [COleServerDoc::OnGetEmbeddedItem](#coleserverdoc__ongetembeddeditem), a virtual function with no default implementation.  
  
##  \<a name="coleserverdoc__getitemcliprect">\</a>  COleServerDoc::GetItemClipRect  
 Call the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> member function to get the clipping-rectangle coordinates of the item that is being edited in place.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object to receive the clipping-rectangle coordinates of the item.  
  
### Remarks  
 Coordinates are in pixels relative to the container application window's client area.  
  
 Drawing should not occur outside the clipping rectangle. Usually, drawing is automatically restricted. Use this function to determine whether the user has scrolled outside the visible portion of the document; if so, scroll the container document as needed by means of a call to [ScrollContainerBy](#coleserverdoc__scrollcontainerby).  
  
##  \<a name="coleserverdoc__getitemposition">\</a>  COleServerDoc::GetItemPosition  
 Call the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> member function to get the coordinates of the item being edited in place.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object to receive the coordinates of the item.  
  
### Remarks  
 Coordinates are in pixels relative to the container application window's client area.  
  
 The item's position can be compared with the current clipping rectangle to determine the extent to which the item is visible (or not visible) on the screen.  
  
##  \<a name="coleserverdoc__getzoomfactor">\</a>  COleServerDoc::GetZoomFactor  
 The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> member function determines the "zoom factor" of an item that has been activated for in-place editing.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 *lpSizeNum*  
 Pointer to an object of class <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> that will hold the zoom factor's numerator. Can be **NULL**.  
  
 *lpSizeDenom*  
 Pointer to an object of class <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> that will hold the zoom factor's denominator. Can be **NULL**.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Pointer to an object of class <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> that describes the item's new position. If this argument is **NULL**, the function uses the item's current position.  
  
### Return Value  
 Nonzero if the item is activated for in-place editing and its zoom factor is other than 100% (1:1); otherwise 0.  
  
### Remarks  
 The zoom factor, in pixels, is the proportion of the item's size to its current extent. If the container application has not set the item's extent, its natural extent (as determined by [COleServerItem::OnGetExtent](../vs140/coleserveritem-class.md#coleserveritem__ongetextent)) is used.  
  
 The function sets its first two arguments to the numerator and denominator of the item's "zoom factor." If the item is not being edited in place, the function sets these arguments to a default value of 100% (or 1:1) and returns zero. For further information, see Technical Note 40, [MFC/OLE In-Place Resizing and Zooming](../vs140/tn040--mfc-ole-in-place-resizing-and-zooming.md).  
  
##  \<a name="coleserverdoc__isdocobject">\</a>  COleServerDoc::IsDocObject  
 Determines if the document is a DocObject.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if the document is a DocObject; otherwise **FALSE**.  
  
##  \<a name="coleserverdoc__isembedded">\</a>  COleServerDoc::IsEmbedded  
 Call the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> member function to determine whether the document represents an object embedded in a container.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object is a document that represents an object embedded in a container; otherwise 0.  
  
### Remarks  
 A document loaded from a file is not embedded although it may be manipulated by a container application as a link. A document that is embedded in a container document is considered to be embedded.  
  
##  \<a name="coleserverdoc__isinplaceactive">\</a>  COleServerDoc::IsInPlaceActive  
 Call the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> member function to determine whether the item is currently in the in-place active state.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object is active in place; otherwise 0.  
  
##  \<a name="coleserverdoc__notifychanged">\</a>  COleServerDoc::NotifyChanged  
 Call this function to notify all linked items connected to the document that the document has changed.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 Typically, you call this function after the user changes some global attribute such as the dimensions of the server document. If an OLE item is linked to the document with an automatic link, the item is updated to reflect the changes. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem-class.md#coleclientitem__onchange) member function of <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is called.  
  
> [!NOTE]
>  This function is included for compatibility with OLE 1. New applications should use [UpdateAllItems](#coleserverdoc__updateallitems).  
  
##  \<a name="coleserverdoc__notifyclosed">\</a>  COleServerDoc::NotifyClosed  
 Call this function to notify the container(s) that the document has been closed.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 When the user chooses the Close command from the File menu, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is called by <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>'s implementation of the [OnCloseDocument](../vs140/cdocument-class.md#cdocument__onclosedocument) member function. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem-class.md#coleclientitem__onchange) member function of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is called.  
  
##  \<a name="coleserverdoc__notifyrename">\</a>  COleServerDoc::NotifyRename  
 Call this function after the user renames the server document.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Pointer to a string specifying the new name of the server document; this is typically a fully qualified path.  
  
### Remarks  
 When the user chooses the Save As command from the File menu, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is called by <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>'s implementation of the [OnSaveDocument](../vs140/cdocument-class.md#cdocument__onsavedocument) member function. This function notifies the OLE system DLLs, which in turn notify the containers. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem-class.md#coleclientitem__onchange) member function of <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is called.  
  
##  \<a name="coleserverdoc__notifysaved">\</a>  COleServerDoc::NotifySaved  
 Call this function after the user saves the server document.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 When the user chooses the Save command from the File menu, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is called for you by <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>'s implementation of [OnSaveDocument](../vs140/cdocument-class.md#cdocument__onsavedocument). This function notifies the OLE system DLLs, which in turn notify the containers. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem-class.md#coleclientitem__onchange) member function of <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is called.  
  
##  \<a name="coleserverdoc__onclose">\</a>  COleServerDoc::OnClose  
 Called by the framework when a container requests that the server document be closed.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A value from the enumeration <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. This parameter can have one of the following values:  
  
-   <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> The file is saved if it has been modified.  
  
-   <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> The file is closed without being saved.  
  
-   <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> If the file has been modified, the user is prompted about saving it.  
  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
 For more information and additional values, see                         [OLECLOSE](http://msdn.microsoft.com/library/windows/desktop/ms680623) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleserverdoc__ondeactivate">\</a>  COleServerDoc::OnDeactivate  
 Called by the framework when the user deactivates an embedded or linked item that is currently in-place active.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 This function restores the container application's user interface to its original state and destroys any menus and other controls that were created for in-place activation.  
  
 The undo state information should be unconditionally released at this point.  
  
 For more information, see the article [Activation](../vs140/activation--c---.md)..  
  
##  \<a name="coleserverdoc__ondeactivateui">\</a>  COleServerDoc::OnDeactivateUI  
 Called when the user deactivates an item that was activated in place.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Specifies whether the editing changes can be undone.  
  
### Remarks  
 This function restores the container application's user interface to its original state, hiding any menus and other controls that were created for in-place activation.  
  
 The framework always sets <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> to **FALSE**. If the server supports undo and there is an operation that can be undone, call the base-class implementation with <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> set to **TRUE**.  
  
##  \<a name="coleserverdoc__ondocwindowactivate">\</a>  COleServerDoc::OnDocWindowActivate  
 The framework calls this function to activate or deactivate a document window for in-place editing.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Specifies whether the document window is to be activated or deactivated.  
  
### Remarks  
 The default implementation removes or adds the frame-level user interface elements as appropriate. Override this function if you want to perform additional actions when the document containing your item is activated or deactivated.  
  
 For more information, see the article [Activation](../vs140/activation--c---.md)..  
  
##  \<a name="coleserverdoc__onexecolecmd">\</a>  COleServerDoc::OnExecOleCmd  
 The framework calls this function to execute a specified command or display help for the command.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A pointer to a GUID that identifies a set of commands. Can be **NULL** to indicate the default command group.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The command to execute. Must be in the group identified by <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
 *nCmdExecOut*  
 The way the object should execute the command, one or more of the following values from the **OLECMDEXECOPT** enumeration:  
  
 **OLECMDEXECOPT_DODEFAULT**  
  
 **OLECMDEXECOPT_PROMPTUSER**  
  
 **OLECMDEXECOPT_DONTPROMPTUSER**  
  
 **OLECMDEXECOPT_SHOWHELP**  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Pointer to a **VARIANTARG** containing input arguments for the command. Can be **NULL**.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Pointer to a **VARIANTARG** to receive the output return values from the command. Can be **NULL**.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> if successful; otherwise, one of the following error codes:  
  
|Value|Description|  
|-----------|-----------------|  
|**E_UNEXPECTED**|Unexpected error occurred|  
|**E_FAIL**|Error occurred|  
|**E_NOTIMPL**|Indicates MFC itself should attempt to translate and dispatch the command|  
|**OLECMDERR_E_UNKNOWNGROUP**|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder> is non- **NULL** but does not specify a recognized command group|  
|**OLECMDERR_E_NOTSUPPORTED**|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder> is not recognized as a valid command in the group <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|  
|**OLECMDERR_DISABLED**|The command identified by <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> is disabled and cannot be executed|  
|**OLECMDERR_NOHELP**|Caller asked for help on the command identified by <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> but no help is available|  
|**OLECMDERR_CANCELED**|User canceled the execution|  
  
### Remarks  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> can be used to enable, update, and set other properties of DocObject user interface commands. After the commands are initialized, you can execute them with <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 The framework calls the function before attempting to translate and dispatch an OLE document command. You don't need to override this function to handle standard OLE document commands, but you must supply an override to this function if you want to handle your own custom commands or handle commands that accept parameters or return results.  
  
 Most of the commands do not take arguments or return values. For a majority of commands the caller can pass **NULL**s for <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>. For commands that expect input values, the caller can declare and initialize a **VARIANTARG** variable and pass a pointer to the variable in <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. For commands that require a single value, the argument can be stored directly in the **VARIANTARG** and passed to the function. Multiple arguments must be packaged within the **VARIANTARG** using one of the supported types (such as <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> and **SAFEARRAY** ).  
  
 Similarly, if a command returns arguments the caller is expected to declare a **VARIANTARG**, initialize it to <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, and pass its address in <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>. If a command returns a single value, the object can store that value directly in <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>. Multiple output values must be packaged in some way appropriate for the **VARIANTARG**.  
  
 The base-class implementation of this function will walk the **OLE_COMMAND_MAP** structures associated with the command target and try to dispatch the command to an appropriate handler. The base-class implementation works only with commands that do not accept arguments or return values. If you need to handle commands that do accept arguments or return values, you must override this function and work with the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> parameters yourself.  
  
##  \<a name="coleserverdoc__onframewindowactivate">\</a>  COleServerDoc::OnFrameWindowActivate  
 The framework calls this function when the container application's frame window is activated or deactivated.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Specifies whether the frame window is to be activated or deactivated.  
  
### Remarks  
 The default implementation cancels any help modes the frame window might be in. Override this function if you want to perform special processing when the frame window is activated or deactivated.  
  
 For more information, see the article [Activation](../vs140/activation--c---.md)..  
  
##  \<a name="coleserverdoc__ongetembeddeditem">\</a>  COleServerDoc::OnGetEmbeddedItem  
 Called by the framework when a container application calls the server application to create or edit an embedded item.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an item representing the entire document; **NULL** if the operation failed.  
  
### Remarks  
 There is no default implementation. You must override this function to return an item that represents the entire document. This return value should be an object of a <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>-derived class.  
  
##  \<a name="coleserverdoc__onreactivateandundo">\</a>  COleServerDoc::OnReactivateAndUndo  
 The framework calls this function when the user chooses to undo changes made to an item that has been activated in place, changed, and subsequently deactivated.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The default implementation does nothing except return **FALSE** to indicate failure.  
  
 Override this function if your application supports undo. Usually you would perform the undo operation, then activate the item by calling <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>. If the container application is written with the Microsoft Foundation Class Library, calling <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> causes this function to be called.  
  
##  \<a name="coleserverdoc__onresizeborder">\</a>  COleServerDoc::OnResizeBorder  
 The framework calls this function when the container application's frame windows change size.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object that specifies the coordinates of the border.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Pointer to an object of class **IOleInPlaceUIWindow** that owns the current in-place editing session.  
  
 *bFrame*  
 **TRUE** if <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> points to the container application's top-level frame window, or **FALSE** if <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> points to the container application's document-level frame window.  
  
### Remarks  
 This function resizes and adjusts toolbars and other user-interface elements in accordance with the new window size.  
  
 For more information, see                         [IOleInPlaceUIWindow](http://msdn.microsoft.com/library/windows/desktop/ms680716) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 This is an advanced overridable.  
  
##  \<a name="coleserverdoc__onsethostnames">\</a>  COleServerDoc::OnSetHostNames  
 Called by the framework when the container sets or changes the host names for this document.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Pointer to a string that specifies the name of the container application.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 Pointer to a string that specifies the container's name for the document.  
  
### Remarks  
 The default implementation changes the document title for all views referring to this document.  
  
 Override this function if your application sets the titles through a different mechanism.  
  
##  \<a name="coleserverdoc__onsetitemrects">\</a>  COleServerDoc::OnSetItemRects  
 The framework calls this function to position the in-place editing frame window within the container application's frame window.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object that specifies the in-place frame window's position relative to the container application's client area.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> object that specifies the in-place frame window's clipping rectangle relative to the container application's client area.  
  
### Remarks  
 Override this function to update the view's zoom factor, if necessary.  
  
 This function is usually called in response to a <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> call, although it can be called at any time by the container to request a position change for the in-place item.  
  
##  \<a name="coleserverdoc__onshowcontrolbars">\</a>  COleServerDoc::OnShowControlBars  
 The framework calls this function to show or hide the server application's control bars associated with the frame window identified by <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Pointer to the frame window whose control bars should be hidden or shown.  
  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Determines whether control bars are shown or hidden.  
  
### Remarks  
 The default implementation enumerates all control bars owned by that frame window and hides or shows them.  
  
##  \<a name="coleserverdoc__onshowdocument">\</a>  COleServerDoc::OnShowDocument  
 The framework calls the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> function when the server document must be hidden or shown.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Specifies whether the user interface to the document is to be shown or hidden.  
  
### Remarks  
 If <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> is **TRUE**, the default implementation activates the server application, if necessary, and causes the container application to scroll its window so that the item is visible. If <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> is **FALSE**, the default implementation deactivates the item through a call to <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, then destroys or hides all frame windows that have been created for the document, except the first one. If no visible documents remain, the default implementation hides the server application.  
  
##  \<a name="coleserverdoc__onupdatedocument">\</a>  COleServerDoc::OnUpdateDocument  
 Called by the framework when saving a document that is an embedded item in a compound document.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the document was successfully updated; otherwise 0.  
  
### Remarks  
 The default implementation calls the [COleServerDoc::NotifySaved](#coleserverdoc__notifysaved) and [COleServerDoc::SaveEmbedding](#coleserverdoc__saveembedding) member functions and then marks the document as clean. Override this function if you want to perform special processing when updating an embedded item.  
  
##  \<a name="coleserverdoc__requestpositionchange">\</a>  COleServerDoc::RequestPositionChange  
 Call this member function to have the container application change the item's position.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> object containing the item's new position.  
  
### Remarks  
 This function is usually called (in conjunction with <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>) when the data in an in-place active item has changed. Following this call, the container might or might not perform the change by calling <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>. The resulting position might be different from the one requested.  
  
##  \<a name="coleserverdoc__saveembedding">\</a>  COleServerDoc::SaveEmbedding  
 Call this function to tell the container application to save the embedded object.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 This function is called automatically from <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>. Note that this function causes the item to be updated on disk, so it is usually called only as a result of a specific user action.  
  
##  \<a name="coleserverdoc__scrollcontainerby">\</a>  COleServerDoc::ScrollContainerBy  
 Call the <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> member function to scroll the container document by the amount, in pixels, indicated by <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Indicates how far the container document is to scroll.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Positive values indicate scrolling down and to the right; negative values indicate scrolling up and to the left.  
  
##  \<a name="coleserverdoc__updateallitems">\</a>  COleServerDoc::UpdateAllItems  
 Call this function to notify all linked items connected to the document that the document has changed.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 Pointer to the item that modified the document, or **NULL** if all items are to be updated.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 Contains information about the modification.  
  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 Pointer to an object storing information about the modification.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 Determines how the item is to be drawn. This is a value from the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> enumeration. This parameter can have one of the following values:  
  
-   <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> Item is represented by an icon.  
  
-   <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> Item is represented as if it were printed using the Print command from the File menu.  
  
### Remarks  
 You typically call this function after the user changes the server document. If an OLE item is linked to the document with an automatic link, the item is updated to reflect the changes. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem-class.md#coleclientitem__onchange) member function of <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> is called.  
  
 This function calls the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> member function for each of the document's items except the sending item, passing <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>. Use these parameters to pass information to the items about the modifications made to the document. You can encode information using <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> or you can define a <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>-derived class to store information about the modifications and pass an object of that class using <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>. Override the <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> member function in your <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>-derived class to optimize the updating of each item depending on whether its presentation has changed.  
  
## See Also  
 [MFC Sample HIERSVR](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/colelinkingdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument](../vs140/coledocument-class.md)   
 [COleLinkingDoc](../vs140/colelinkingdoc-class.md)   
 [COleTemplateServer](../vs140/coletemplateserver-class.md)