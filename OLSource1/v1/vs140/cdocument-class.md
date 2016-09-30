---
title: "CDocument Class"
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
  - "CDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "documents [C++], serialization"
  - "files [C++], documents"
  - "command handling, documents and"
  - "documents [C++], document classes"
  - "documents [C++], multiple views"
  - "serialization [C++], documents and"
  - "CDocument class"
  - "command routing, documents and"
  - "views [C++], document"
  - "documents [C++], command routing"
ms.assetid: e5a2891d-e1e1-4599-8c7e-afa9b4945446
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument Class
Provides the basic functionality for user-defined document classes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDocument::CDocument](#cdocument__cdocument)|Constructs a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocument::AddView](#cdocument__addview)|Attaches a view to the document.|  
|[CDocument::BeginReadChunks](#cdocument__beginreadchunks)|Initializes chunk reading.|  
|[CDocument::CanCloseFrame](#cdocument__cancloseframe)|Advanced overridable; called before closing a frame window viewing this document.|  
|[CDocument::ClearChunkList](#cdocument__clearchunklist)|Clears the chunk list.|  
|[CDocument::ClearPathName](#cdocument__clearpathname)|Clears the path of the document object.|  
|[CDocument::DeleteContents](#cdocument__deletecontents)|Called to perform cleanup of the document.|  
|[CDocument::FindChunk](#cdocument__findchunk)|Looks for a chunk with specified GUID.|  
|[CDocument::GetAdapter](#cdocument__getadapter)|Returns a pointer to object implementing <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> interface.|  
|[CDocument::GetDocTemplate](#cdocument__getdoctemplate)|Returns a pointer to the document template that describes the type of the document.|  
|[CDocument::GetFile](#cdocument__getfile)|Returns a pointer to the desired <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.|  
|[CDocument::GetFirstViewPosition](#cdocument__getfirstviewposition)|Returns the position of the first in the list of views; used to begin iteration.|  
|[CDocument::GetNextView](#cdocument__getnextview)|Iterates through the list of views associated with the document.|  
|[CDocument::GetPathName](#cdocument__getpathname)|Returns the path of the document's data file.|  
|[CDocument::GetThumbnail](#cdocument__getthumbnail)|Called to create a bitmap to be used by thumbnail provider to display thumbnail.|  
|[CDocument::GetTitle](#cdocument__gettitle)|Returns the document's title.|  
|[CDocument::InitializeSearchContent](#cdocument__initializesearchcontent)|Called to initialize search content for Search Handler.|  
|[CDocument::IsModified](#cdocument__ismodified)|Indicates whether the document has been modified since it was last saved.|  
|[CDocument::IsSearchAndOrganizeHandler](#cdocument__issearchandorganizehandler)|Tells whether this instance of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object was created for Search & Organize handler.|  
|[CDocument::LoadDocumentFromStream](#cdocument__loaddocumentfromstream)|Called to load document data from stream.|  
|[CDocument::OnBeforeRichPreviewFontChanged](#cdocument__onbeforerichpreviewfontchanged)|Called before Rich Preview font is changed.|  
|[CDocument::OnChangedViewList](#cdocument__onchangedviewlist)|Called after a view is added to or removed from the document.|  
|[CDocument::OnCloseDocument](#cdocument__onclosedocument)|Called to close the document.|  
|[CDocument::OnCreatePreviewFrame](#cdocument__oncreatepreviewframe)|Called by the framework when it needs to create a preview frame for Rich Preview.|  
|[CDocument::OnDocumentEvent](#cdocument__ondocumentevent)|Called by the framework in response to a document event.|  
|[CDocument::OnDrawThumbnail](#cdocument__ondrawthumbnail)|Override this method in a derived class to draw content of thumbnail.|  
|[CDocument::OnLoadDocumentFromStream](#cdocument__onloaddocumentfromstream)|Called by the framework when it needs to load the document data from stream.|  
|[CDocument::OnNewDocument](#cdocument__onnewdocument)|Called to create a new document.|  
|[CDocument::OnOpenDocument](#cdocument__onopendocument)|Called to open an existing document.|  
|[CDocument::OnPreviewHandlerQueryFocus](#cdocument__onpreviewhandlerqueryfocus)|Directs the preview handler to return the HWND from calling the GetFocus Function.|  
|[CDocument::OnPreviewHandlerTranslateAccelerator](#cdocument__onpreviewhandlertranslateaccelerator)|Directs the preview handler to handle a keystroke passed up from the message pump of the process in which the preview handler is running.|  
|[CDocument::OnRichPreviewBackColorChanged](#cdocument__onrichpreviewbackcolorchanged)|Called when Rich Preview background color has changed.|  
|[CDocument::OnRichPreviewFontChanged](#cdocument__onrichpreviewfontchanged)|Called when Rich Preview font has changed.|  
|[CDocument::OnRichPreviewSiteChanged](#cdocument__onrichpreviewsitechanged)|Called when Rich Preview site has changed.|  
|[CDocument::OnRichPreviewTextColorChanged](#cdocument__onrichpreviewtextcolorchanged)|Called when Rich Preview text color has changed.|  
|[CDocument::OnSaveDocument](#cdocument__onsavedocument)|Called to save the document to disk.|  
|[CDocument::OnUnloadHandler](#cdocument__onunloadhandler)|Called by the framework when the preview handler is being unloaded.|  
|[CDocument::PreCloseFrame](#cdocument__precloseframe)|Called before the frame window is closed.|  
|[CDocument::ReadNextChunkValue](#cdocument__readnextchunkvalue)|Reads next chunk value.|  
|[CDocument::ReleaseFile](#cdocument__releasefile)|Releases a file to make it available for use by other applications.|  
|[CDocument::RemoveChunk](#cdocument__removechunk)|Removes a chunk with specified GUID.|  
|[CDocument::RemoveView](#cdocument__removeview)|Detaches a view from the document.|  
|[CDocument::ReportSaveLoadException](#cdocument__reportsaveloadexception)|Advanced overridable; called when an open or save operation cannot be completed because of an exception.|  
|[CDocument::SaveModified](#cdocument__savemodified)|Advanced overridable; called to ask the user whether the document should be saved.|  
|[CDocument::SetChunkValue](#cdocument__setchunkvalue)|Sets a chunk value.|  
|[CDocument::SetModifiedFlag](#cdocument__setmodifiedflag)|Sets a flag indicating that you have modified the document since it was last saved.|  
|[CDocument::SetPathName](#cdocument__setpathname)|Sets the path of the data file used by the document.|  
|[CDocument::SetTitle](#cdocument__settitle)|Sets the document's title.|  
|[CDocument::UpdateAllViews](#cdocument__updateallviews)|Notifies all views that document has been modified.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocument::OnFileSendMail](#cdocument__onfilesendmail)|Sends a mail message with the document attached.|  
|[CDocument::OnUpdateFileSendMail](#cdocument__onupdatefilesendmail)|Enables the Send Mail command if mail support is present.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDocument::m_bGetThumbnailMode](#cdocument__m_bgetthumbnailmode)|Specifies that <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object was created by dllhost for thumbnails. Should be checked in <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.|  
|[CDocument::m_bPreviewHandlerMode](#cdocument__m_bpreviewhandlermode)|Specifies that <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object was created by prevhost for <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. Should be checked in <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.|  
|[CDocument::m_bSearchMode](#cdocument__m_bsearchmode)|Specifies that <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object was created by indexer or other search application.|  
|[CDocument::m_clrRichPreviewBackColor](#cdocument__m_clrrichpreviewbackcolor)|Specifies background color of Rich Preview window. This color is set by host.|  
|[CDocument::m_clrRichPreviewTextColor](#cdocument__m_clrrichpreviewtextcolor)|Specifies foreground color of Rich Preview window. This color is set by host.|  
|[CDocument::m_lfRichPreviewFont](#cdocument__m_lfrichpreviewfont)|Specifies text font for Rich Preview window. This font information is set by host.|  
  
## Remarks  
 A document represents the unit of data that the user typically opens with the File Open command and saves with the File Save command.  
  
 **CDocument** supports standard operations such as creating a document, loading it, and saving it. The framework manipulates documents using the interface defined by **CDocument**.  
  
 An application can support more than one type of document; for example, an application might support both spreadsheets and text documents. Each type of document has an associated document template; the document template specifies what resources (for example, menu, icon, or accelerator table) are used for that type of document. Each document contains a pointer to its associated <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object.  
  
 Users interact with a document through the [CView](../vs140/cview-class.md) object(s) associated with it. A view renders an image of the document in a frame window and interprets user input as operations on the document. A document can have multiple views associated with it. When the user opens a window on a document, the framework creates a view and attaches it to the document. The document template specifies what type of view and frame window are used to display each type of document.  
  
 Documents are part of the framework's standard command routing and consequently receive commands from standard user-interface components (such as the File Save menu item). A document receives commands forwarded by the active view. If the document doesn't handle a given command, it forwards the command to the document template that manages it.  
  
 When a document's data is modified, each of its views must reflect those modifications. **CDocument** provides the [UpdateAllViews](#cdocument__updateallviews) member function for you to notify the views of such changes, so the views can repaint themselves as necessary. The framework also prompts the user to save a modified file before closing it.  
  
 To implement documents in a typical application, you must do the following:  
  
-   Derive a class from **CDocument** for each type of document.  
  
-   Add member variables to store each document's data.  
  
-   Implement member functions for reading and modifying the document's data. The document's views are the most important users of these member functions.  
  
-   Override the [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize) member function in your document class to write and read the document's data to and from disk.  
  
 **CDocument** supports sending your document via mail if mail support (MAPI) is present. See the articles [MAPI](../vs140/mapi.md) and [MAPI Support in MFC](../vs140/mapi-support-in-mfc.md).  
  
 For more information on **CDocument**, see [Serialization](../vs140/serialization-in-mfc.md), [Document/View Architecture Topics](../vs140/document-view-architecture.md), and [Document/View Creation](../vs140/document-view-creation.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cdocument__addview">\</a>  CDocument::AddView  
 Call this function to attach a view to the document.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Points to the view being added.  
  
### Remarks  
 This function adds the specified view to the list of views associated with the document; the function also sets the view's document pointer to this document. The framework calls this function when attaching a newly created view object to a document; this occurs in response to a File New, File Open, or New Window command or when a splitter window is split.  
  
 Call this function only if you are manually creating and attaching a view. Typically you will let the framework connect documents and views by defining a [CDocTemplate](../vs140/cdoctemplate-class.md) object to associate a document class, view class, and frame window class.  
  
### Example  
 [!code[NVC_MFCDocViewSDI#12](../vs140/codesnippet/CPP/cdocument-class_1.cpp)]  
  
##  \<a name="cdocument__beginreadchunks">\</a>  CDocument::BeginReadChunks  
 Initializes chunk reading.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__cancloseframe">\</a>  CDocument::CanCloseFrame  
 Called by the framework before a frame window displaying the document is closed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Points to the frame window of a view attached to the document.  
  
### Return Value  
 Nonzero if it is safe to close the frame window; otherwise 0.  
  
### Remarks  
 The default implementation checks if there are other frame windows displaying the document. If the specified frame window is the last one that displays the document, the function prompts the user to save the document if it has been modified. Override this function if you want to perform special processing when a frame window is closed. This is an advanced overridable.  
  
##  \<a name="cdocument__cdocument">\</a>  CDocument::CDocument  
 Constructs a **CDocument** object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The framework handles document creation for you. Override the [OnNewDocument](#cdocument__onnewdocument) member function to perform initialization on a per-document basis; this is particularly important in single document interface (SDI) applications.  
  
##  \<a name="cdocument__clearchunklist">\</a>  CDocument::ClearChunkList  
 Clears the chunk list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__clearpathname">\</a>  CDocument::ClearPathName  
 Clears the path of the document object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Clearing the path from a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object causes the application to prompt the user when the document is next saved. This makes a **Save** command behave like a **Save As** command.  
  
##  \<a name="cdocument__deletecontents">\</a>  CDocument::DeleteContents  
 Called by the framework to delete the document's data without destroying the **CDocument** object itself.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 It is called just before the document is to be destroyed. It is also called to ensure that a document is empty before it is reused. This is particularly important for an SDI application, which uses only one document; the document is reused whenever the user creates or opens another document. Call this function to implement an "Edit Clear All" or similar command that deletes all of the document's data. The default implementation of this function does nothing. Override this function to delete the data in your document.  
  
### Example  
 [!code[NVC_MFCDocView#57](../vs140/codesnippet/CPP/cdocument-class_2.cpp)]  
  
##  \<a name="cdocument__findchunk">\</a>  CDocument::FindChunk  
 Looks for a chunk with a specified GUID.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Specifies the GUID of a chunk to find.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies a PID of a chunk to find.  
  
### Return Value  
 Position in the internal chunk list if successful. Otherwise <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cdocument__getadapter">\</a>  CDocument::GetAdapter  
 Returns a pointer to an object implementing the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an object implementing the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> interface.  
  
### Remarks  
  
##  \<a name="cdocument__getdoctemplate">\</a>  CDocument::GetDocTemplate  
 Call this function to get a pointer to the document template for this document type.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the document template for this document type, or **NULL** if the document is not managed by a document template.  
  
### Example  
 [!code[NVC_MFCDocView#58](../vs140/codesnippet/CPP/cdocument-class_3.cpp)]  
  
##  \<a name="cdocument__getfile">\</a>  CDocument::GetFile  
 Call this member function to get a pointer to a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A string that is the path to the desired file. The path may be relative or absolute.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 A pointer to an existing file-exception object that indicates the completion status of the operation.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Sharing and access mode. Specifies the action to take when opening the file. You can combine options listed in the CFile constructor [CFile::CFile](../vs140/cfile-class.md#cfile__cfile) by using the bitwise OR (&#124;) operator. One access permission and one share option are required; the **modeCreate** and **modeNoInherit** modes are optional.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdocument__getfirstviewposition">\</a>  CDocument::GetFirstViewPosition  
 Call this function to get the position of the first view in the list of views associated with the document.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that can be used for iteration with the [GetNextView](#cdocument__getnextview) member function.  
  
### Example  
 [!code[NVC_MFCDocView#59](../vs140/codesnippet/CPP/cdocument-class_4.cpp)]  
  
##  \<a name="cdocument__getnextview">\</a>  CDocument::GetNextView  
 Call this function to iterate through all of the document's views.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous call to the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> or [GetFirstViewPosition](#cdocument__getfirstviewposition) member functions. This value must not be **NULL**.  
  
### Return Value  
 A pointer to the view identified by <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Remarks  
 The function returns the view identified by <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> and then sets <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to the **POSITION** value of the next view in the list. If the retrieved view is the last in the list, then <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Example  
 [!code[NVC_MFCDocView#59](../vs140/codesnippet/CPP/cdocument-class_4.cpp)]  
  
##  \<a name="cdocument__getpathname">\</a>  CDocument::GetPathName  
 Call this function to get the fully qualified path of the document's disk file.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The document's fully qualified path. This string is empty if the document has not been saved or does not have a disk file associated with it.  
  
##  \<a name="cdocument__getthumbnail">\</a>  CDocument::GetThumbnail  
 Creates a bitmap to be used by the thumbnail provider to display the thumbnail.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Specifies the width and height of the bitmap.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Contains a handle to a bitmap, when the function returns successfully.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Contains a DWORD specifying the alpha channel value, when the function returns successfully.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> if a bitmap for the thumbnail was created successfully; otherwise <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cdocument__gettitle">\</a>  CDocument::GetTitle  
 Call this function to get the document's title, which is usually derived from the document's filename.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The document's title.  
  
##  \<a name="cdocument__initializesearchcontent">\</a>  CDocument::InitializeSearchContent  
 Called to initialize search content for the Search Handler.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 Override this method in a derived class to initialize search content. The content should be a string with parts delimited by ";". For example, "point; rectangle; ole item".  
  
##  \<a name="cdocument__ismodified">\</a>  CDocument::IsModified  
 Call this function to determine whether the document has been modified since it was last saved.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the document has been modified since it was last saved; otherwise 0.  
  
##  \<a name="cdocument__issearchandorganizehandler">\</a>  CDocument::IsSearchAndOrganizeHandler  
 Tells whether this instance of <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> was created for the Search & Organize handler.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if this instance of <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> was created for the Search & Organize handler.  
  
### Remarks  
 Currently this function returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> only for Rich Preview handlers implemented in an out of process server. You can set the appropriate flags (m_bPreviewHandlerMode, m_bSearchMode, m_bGetThumbnailMode) at your application level to make this function return <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
##  \<a name="cdocument__loaddocumentfromstream">\</a>  CDocument::LoadDocumentFromStream  
 Called to load document data from a stream.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A pointer to a stream. This stream is supplied by the Shell.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Access mode to the stream.  
  
### Return Value  
 S_OK if the load operation succeeds, otherwise HRESULT with an error code.  
  
### Remarks  
 You can override this method in a derived class to customize how to load data from the stream.  
  
##  \<a name="cdocument__m_bgetthumbnailmode">\</a>  CDocument::m_bGetThumbnailMode  
 Specifies that the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object was created by dllhost for thumbnails. Should be checked in <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> indicates that the document was created by dllhost for thumbnails.  
  
##  \<a name="cdocument__m_bpreviewhandlermode">\</a>  CDocument::m_bPreviewHandlerMode  
 Specifies that the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object was created by prevhost for Rich Preview. Should be checked in <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> indicates that the document was created by prevhost for Rich Preview.  
  
##  \<a name="cdocument__m_bsearchmode">\</a>  CDocument::m_bSearchMode  
 Specifies that the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object was created by indexer or by another search application.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> indicates that the document was created by indexer or by another search application.  
  
##  \<a name="cdocument__m_clrrichpreviewbackcolor">\</a>  CDocument::m_clrRichPreviewBackColor  
 Specifies the background color of the Rich Preview window. This color is set by host.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__m_clrrichpreviewtextcolor">\</a>  CDocument::m_clrRichPreviewTextColor  
 Specifies the foreground color of the Rich Preview window. This color is set by host.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__m_lfrichpreviewfont">\</a>  CDocument::m_lfRichPreviewFont  
 Specifies the text font for the Rich Preview window. This font information is set by host.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__onbeforerichpreviewfontchanged">\</a>  CDocument::OnBeforeRichPreviewFontChanged  
 Called before the Rich Preview font is changed.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__onchangedviewlist">\</a>  CDocument::OnChangedViewList  
 Called by the framework after a view is added to or removed from the document.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this function checks whether the last view is being removed and, if so, deletes the document. Override this function if you want to perform special processing when the framework adds or removes a view. For example, if you want a document to remain open even when there are no views attached to it, override this function.  
  
##  \<a name="cdocument__onclosedocument">\</a>  CDocument::OnCloseDocument  
 Called by the framework when the document is closed, typically as part of the File Close command.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this function destroys all of the frames used for viewing the document, closes the view, cleans up the document's contents, and then calls the [DeleteContents](#cdocument__deletecontents) member function to delete the document's data.  
  
 Override this function if you want to perform special cleanup processing when the framework closes a document. For example, if the document represents a record in a database, you may want to override this function to close the database. You should call the base class version of this function from your override.  
  
##  \<a name="cdocument__oncreatepreviewframe">\</a>  CDocument::OnCreatePreviewFrame  
 Called by the framework when it needs to create a preview frame for Rich Preview.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> if the frame is created successfully; otherwise <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cdocument__ondocumentevent">\</a>  CDocument::OnDocumentEvent  
 Called by the framework in response to a document event.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 An enumerated data type that describes the type of event.  
  
### Remarks  
 Document events may affect multiple classes. This method is responsible for handling document events that affect classes other than the [CDocument Class](../vs140/cdocument-class.md). Currently, the only class that must respond to document events is the [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md). The <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> class has other overrideable methods responsible for handling the effect on the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
 The following table lists the possible values for <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> and the events that they correspond to.  
  
|Value|Corresponding Event|  
|-----------|-------------------------|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|A new document was created.|  
|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|A new document was opened.|  
|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|The document was saved.|  
|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|The document was closed.|  
  
##  \<a name="cdocument__ondrawthumbnail">\</a>  CDocument::OnDrawThumbnail  
 Override this method in a derived class to draw the thumbnail.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 A reference to a device context.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Specifies a bounding rectangle of the area where the thumbnail should be drawn.  
  
### Remarks  
  
##  \<a name="cdocument__onfilesendmail">\</a>  CDocument::OnFileSendMail  
 Sends a message via the resident mail host (if any) with the document as an attachment.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> calls [OnSaveDocument](#cdocument__onsavedocument) to serialize (save) untitled and modified documents to a temporary file, which is then sent via electronic mail. If the document has not been modified, a temporary file is not needed; the original is sent. <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> loads MAPI32.DLL if it has not already been loaded.  
  
 A special implementation of <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> for [COleDocument](../vs140/coledocument-class.md) handles compound files correctly.  
  
 **CDocument** supports sending your document via mail if mail support (MAPI) is present. See the articles [MAPI Topics](../vs140/mapi.md) and [MAPI Support in MFC](../vs140/mapi-support-in-mfc.md).  
  
##  \<a name="cdocument__onloaddocumentfromstream">\</a>  CDocument::OnLoadDocumentFromStream  
 Called by the framework when it needs to load the document data from a stream.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A pointer to an incoming stream.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Access mode to the stream.  
  
### Return Value  
 S_OK if the load is successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cdocument__onnewdocument">\</a>  CDocument::OnNewDocument  
 Called by the framework as part of the File New command.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the document was successfully initialized; otherwise 0.  
  
### Remarks  
 The default implementation of this function calls the [DeleteContents](#cdocument__deletecontents) member function to ensure that the document is empty and then marks the new document as clean. Override this function to initialize the data structure for a new document. You should call the base class version of this function from your override.  
  
 If the user chooses the File New command in an SDI application, the framework uses this function to reinitialize the existing document, rather than creating a new one. If the user chooses File New in a multiple document interface (MDI) application, the framework creates a new document each time and then calls this function to initialize it. You must place your initialization code in this function instead of in the constructor for the File New command to be effective in SDI applications.  
  
 Note that there are cases where <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> is called twice. This occurs when the document is embedded as an ActiveX Document Server. The function is first called by the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> method (exposed by the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>-derived class) and a second time by the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> method (exposed by the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>-derived class).  
  
### Example  
 The following examples illustrate alternative methods of initializing a document object.  
  
 [!code[NVC_MFCDocView#60](../vs140/codesnippet/CPP/cdocument-class_5.cpp)]  
  
 [!code[NVC_MFCDocView#61](../vs140/codesnippet/CPP/cdocument-class_6.cpp)]  
  
 [!code[NVC_MFCDocView#62](../vs140/codesnippet/CPP/cdocument-class_7.cpp)]  
  
##  \<a name="cdocument__onopendocument">\</a>  CDocument::OnOpenDocument  
 Called by the framework as part of the File Open command.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Points to the path of the document to be opened.  
  
### Return Value  
 Nonzero if the document was successfully loaded; otherwise 0.  
  
### Remarks  
 The default implementation of this function opens the specified file, calls the [DeleteContents](#cdocument__deletecontents) member function to ensure that the document is empty, calls [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize) to read the file's contents, and then marks the document as clean. Override this function if you want to use something other than the archive mechanism or the file mechanism. For example, you might write an application where documents represent records in a database rather than separate files.  
  
 If the user chooses the File Open command in an SDI application, the framework uses this function to reinitialize the existing **CDocument** object, rather than creating a new one. If the user chooses File Open in an MDI application, the framework constructs a new **CDocument** object each time and then calls this function to initialize it. You must place your initialization code in this function instead of in the constructor for the File Open command to be effective in SDI applications.  
  
### Example  
 The following examples illustrate alternative methods of initializing a document object.  
  
 [!code[NVC_MFCDocView#60](../vs140/codesnippet/CPP/cdocument-class_5.cpp)]  
  
 [!code[NVC_MFCDocView#61](../vs140/codesnippet/CPP/cdocument-class_6.cpp)]  
  
 [!code[NVC_MFCDocView#62](../vs140/codesnippet/CPP/cdocument-class_7.cpp)]  
  
 [!code[NVC_MFCDocView#63](../vs140/codesnippet/CPP/cdocument-class_8.cpp)]  
  
##  \<a name="cdocument__onpreviewhandlerqueryfocus">\</a>  CDocument::OnPreviewHandlerQueryFocus  
 Directs the preview handler to return the HWND retrieved from calling the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 [out] When this method returns, contains a pointer to the HWND returned from calling the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> function from the preview handler's foreground thread.  
  
### Return Value  
 Returns S_OK if successful; or an error value otherwise.  
  
### Remarks  
  
##  \<a name="cdocument__onpreviewhandlertranslateaccelerator">\</a>  CDocument::OnPreviewHandlerTranslateAccelerator  
 Directs the preview handler to handle a keystroke passed up from the message pump of the process in which the preview handler is running.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 [in] A pointer to a window message.  
  
### Return Value  
 If the keystroke message can be processed by the preview handler, the handler processes it and returns S_OK. If the preview handler cannot process the keystroke message, it offers it to the host via <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>. If the host processes the message, this method returns S_OK. If the host does not process the message, this method returns S_FALSE.  
  
### Remarks  
  
##  \<a name="cdocument__onrichpreviewbackcolorchanged">\</a>  CDocument::OnRichPreviewBackColorChanged  
 Called when the Rich Preview background color has changed.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__onrichpreviewfontchanged">\</a>  CDocument::OnRichPreviewFontChanged  
 Called when the Rich Preview font has changed.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__onrichpreviewsitechanged">\</a>  CDocument::OnRichPreviewSiteChanged  
 Called when the Rich Preview site has changed.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__onrichpreviewtextcolorchanged">\</a>  CDocument::OnRichPreviewTextColorChanged  
 Called when the Rich Preview text color has changed.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__onsavedocument">\</a>  CDocument::OnSaveDocument  
 Called by the framework as part of the File Save or File Save As command.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Points to the fully qualified path to which the file should be saved.  
  
### Return Value  
 Nonzero if the document was successfully saved; otherwise 0.  
  
### Remarks  
 The default implementation of this function opens the specified file, calls [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize) to write the document's data to the file, and then marks the document as clean. Override this function if you want to perform special processing when the framework saves a document. For example, you might write an application where documents represent records in a database rather than separate files.  
  
##  \<a name="cdocument__onunloadhandler">\</a>  CDocument::OnUnloadHandler  
 Called by the framework when the preview handler is unloaded.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocument__onupdatefilesendmail">\</a>  CDocument::OnUpdateFileSendMail  
 Enables the **ID_FILE_SEND_MAIL** command if mail support (MAPI) is present.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 A pointer to the [CCmdUI](../vs140/ccmdui-class.md) object associated with the **ID_FILE_SEND_MAIL** command.  
  
### Remarks  
 Otherwise the function removes the **ID_FILE_SEND_MAIL** command from the menu, including separators above or below the menu item as appropriate. MAPI is enabled if MAPI32.DLL is present in the path and, in the [Mail] section of the WIN.INI file, MAPI=1. Most applications put this command on the File menu.  
  
 **CDocument** supports sending your document via mail if mail support (MAPI) is present. See the articles [MAPI Topics](../vs140/mapi.md) and [MAPI Support in MFC](../vs140/mapi-support-in-mfc.md).  
  
##  \<a name="cdocument__precloseframe">\</a>  CDocument::PreCloseFrame  
 This member function is called by the framework before the frame window is destroyed.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Pointer to the [CFrameWnd](../vs140/cframewnd-class.md) that holds the associated **CDocument** object.  
  
### Remarks  
 It can be overridden to provide custom cleanup, but be sure to call the base class as well.  
  
 The default of <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> does nothing in **CDocument**. The **CDocument**-derived classes [COleDocument](../vs140/coledocument-class.md) and [CRichEditDoc](../vs140/cricheditdoc-class.md) use this member function.  
  
##  \<a name="cdocument__readnextchunkvalue">\</a>  CDocument::ReadNextChunkValue  
 Reads the next chunk value.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 [out] When the function returns, <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> contains the value that was read.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
  
##  \<a name="cdocument__releasefile">\</a>  CDocument::ReleaseFile  
 This member function is called by the framework to release a file, making it available for use by other applications.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 A pointer to the CFile object to be released.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 Specifies whether the file is to be released by using either <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. **FALSE** if the file is to be released using [CFile::Close](../vs140/cfile-class.md#cfile__close); **TRUE** if the file is to be released using [CFile::Abort](../vs140/cfile-class.md#cfile__abort).  
  
### Remarks  
 If <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> is **TRUE**, <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, and the file is released. <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> will not throw an exception.  
  
 If <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> is **FALSE**, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> and the file is released.  
  
 Override this member function to require an action by the user before the file is released.  
  
##  \<a name="cdocument__removechunk">\</a>  CDocument::RemoveChunk  
 Removes a chunk with the specified GUID.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Specifies the GUID of a chunk to be removed.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Specifies the PID of a chunk to be removed.  
  
### Remarks  
  
##  \<a name="cdocument__removeview">\</a>  CDocument::RemoveView  
 Call this function to detach a view from a document.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Points to the view being removed.  
  
### Remarks  
 This function removes the specified view from the list of views associated with the document; it also sets the view's document pointer to **NULL**. This function is called by the framework when a frame window is closed or a pane of a splitter window is closed.  
  
 Call this function only if you are manually detaching a view. Typically you will let the framework detach documents and views by defining a [CDocTemplate](../vs140/cdoctemplate-class.md) object to associate a document class, view class, and frame window class.  
  
 See the example at [AddView](#cdocument__addview) for a sample implementation.  
  
##  \<a name="cdocument__reportsaveloadexception">\</a>  CDocument::ReportSaveLoadException  
 Called if an exception is thrown (typically a [CFileException](../vs140/cfileexception-class.md) or [CArchiveException](../vs140/carchiveexception-class.md)) while saving or loading the document.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Points to name of document that was being saved or loaded.  
  
 *e*  
 Points to the exception that was thrown. May be **NULL**.  
  
 *bSaving*  
 Flag indicating what operation was in progress; nonzero if the document was being saved, 0 if the document was being loaded.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Identifier of the error message to be displayed if the function does not specify a more specific one.  
  
### Remarks  
 The default implementation examines the exception object and looks for an error message that specifically describes the cause. If a specific message is not found or if                         *e* is **NULL**, the general message specified by the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> parameter is used. The function then displays a message box containing the error message. Override this function if you want to provide additional, customized failure messages. This is an advanced overridable.  
  
##  \<a name="cdocument__savemodified">\</a>  CDocument::SaveModified  
 Called by the framework before a modified document is to be closed.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if it is safe to continue and close the document; 0 if the document should not be closed.  
  
### Remarks  
 The default implementation of this function displays a message box asking the user whether to save the changes to the document, if any have been made. Override this function if your program requires a different prompting procedure. This is an advanced overridable.  
  
##  \<a name="cdocument__setchunkvalue">\</a>  CDocument::SetChunkValue  
 Sets a chunk value.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Specifies a chunk value to set.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
  
##  \<a name="cdocument__setmodifiedflag">\</a>  CDocument::SetModifiedFlag  
 Call this function after you have made any modifications to the document.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Flag indicating whether the document has been modified.  
  
### Remarks  
 By calling this function consistently, you ensure that the framework prompts the user to save changes before closing a document. Typically you should use the default value of **TRUE** for the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> parameter. To mark a document as clean (unmodified), call this function with a value of **FALSE**.  
  
##  \<a name="cdocument__setpathname">\</a>  CDocument::SetPathName  
 Call this function to specify the fully qualified path of the document's disk file.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Points to the string to be used as the path for the document.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Determines whether the filename is added to the most recently used (MRU) file list. If **TRUE,** the filename is added; if **FALSE**, it is not added.  
  
### Remarks  
 Depending on the value of <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> the path is added, or not added, to the MRU list maintained by the application. Note that some documents are not associated with a disk file. Call this function only if you are overriding the default implementation for opening and saving files used by the framework.  
  
##  \<a name="cdocument__settitle">\</a>  CDocument::SetTitle  
 Call this function to specify the document's title (the string displayed in the title bar of a frame window).  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Points to the string to be used as the document's title.  
  
### Remarks  
 Calling this function updates the titles of all frame windows that display the document.  
  
##  \<a name="cdocument__updateallviews">\</a>  CDocument::UpdateAllViews  
 Call this function after the document has been modified.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 Points to the view that modified the document, or **NULL** if all views are to be updated.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 Contains information about the modification.  
  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 Points to an object storing information about the modification.  
  
### Remarks  
 You should call this function after you call the [SetModifiedFlag](#cdocument__setmodifiedflag) member function. This function informs each view attached to the document, except for the view specified by <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, that the document has been modified. You typically call this function from your view class after the user has changed the document through a view.  
  
 This function calls the [CView::OnUpdate](../vs140/cview-class.md#cview__onupdate) member function for each of the document's views except the sending view, passing <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>. Use these parameters to pass information to the views about the modifications made to the document. You can encode information using <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> and/or you can define a [CObject](../vs140/cobject-class.md)-derived class to store information about the modifications and pass an object of that class using <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. Override the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> member function in your [CView](../vs140/cview-class.md)-derived class to optimize the updating of the view's display based on the information passed.  
  
### Example  
 [!code[NVC_MFCDocView#64](../vs140/codesnippet/CPP/cdocument-class_9.cpp)]  
  
## See Also  
 [MFC Sample MDIDOCVW](../vs140/visual-c---samples.md)   
 [MFC Sample SNAPVW](../vs140/visual-c---samples.md)   
 [MFC Sample NPP](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget](../vs140/ccmdtarget-class.md)   
 [CView](../vs140/cview-class.md)   
 [CDocTemplate](../vs140/cdoctemplate-class.md)