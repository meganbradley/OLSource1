---
title: "CDocTemplate Class"
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
  - "CDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document templates"
  - "templates, document"
  - "CDocTemplate class"
ms.assetid: 14b41a1f-bf9d-4eac-b6a8-4c54ffcc77f6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate Class
An abstract base class that defines the basic functionality for document templates.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDocTemplate::CDocTemplate](#cdoctemplate__cdoctemplate)|Constructs a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocTemplate::AddDocument](#cdoctemplate__adddocument)|Adds a document to a template.|  
|[CDocTemplate::CloseAllDocuments](#cdoctemplate__closealldocuments)|Closes all documents associated with this template.|  
|[CDocTemplate::CreateNewDocument](#cdoctemplate__createnewdocument)|Creates a new document.|  
|[CDocTemplate::CreateNewFrame](#cdoctemplate__createnewframe)|Creates a new frame window containing a document and view.|  
|[CDocTemplate::CreateOleFrame](#cdoctemplate__createoleframe)|Creates an OLE-enabled frame window.|  
|[CDocTemplate::CreatePreviewFrame](#cdoctemplate__createpreviewframe)|Creates a child frame used for Rich Preview.|  
|[CDocTemplate::GetDocString](#cdoctemplate__getdocstring)|Retrieves a string associated with the document type.|  
|[CDocTemplate::GetFirstDocPosition](#cdoctemplate__getfirstdocposition)|Retrieves the position of the first document associated with this template.|  
|[CDocTemplate::GetNextDoc](#cdoctemplate__getnextdoc)|Retrieves a document and the position of the next one.|  
|[CDocTemplate::InitialUpdateFrame](#cdoctemplate__initialupdateframe)|Initializes the frame window, and optionally makes it visible.|  
|[CDocTemplate::LoadTemplate](#cdoctemplate__loadtemplate)|Loads the resources for a given <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or derived class.|  
|[CDocTemplate::MatchDocType](#cdoctemplate__matchdoctype)|Determines the degree of confidence in the match between a document type and this template.|  
|[CDocTemplate::OpenDocumentFile](#cdoctemplate__opendocumentfile)|Opens a file specified by a pathname.|  
|[CDocTemplate::RemoveDocument](#cdoctemplate__removedocument)|Removes a document from a template.|  
|[CDocTemplate::SaveAllModified](#cdoctemplate__saveallmodified)|Saves all documents associated with this template which have been modified.|  
|[CDocTemplate::SetContainerInfo](#cdoctemplate__setcontainerinfo)|Determines the resources for OLE containers when editing an in-place OLE item.|  
|[CDocTemplate::SetDefaultTitle](#cdoctemplate__setdefaulttitle)|Displays the default title in the document window's title bar.|  
|[CDocTemplate::SetPreviewInfo](#cdoctemplate__setpreviewinfo)|Setups out of process preview handler.|  
|[CDocTemplate::SetServerInfo](#cdoctemplate__setserverinfo)|Determines the resources and classes when the server document is embedded or edited in-place.|  
  
## Remarks  
 You usually create one or more document templates in the implementation of your application's <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function. A document template defines the relationships among three types of classes:  
  
-   A document class, which you derive from **CDocument**.  
  
-   A view class, which displays data from the document class listed above. You can derive this class from <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. (You can also use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> directly.)  
  
-   A frame window class, which contains the view. For a single document interface (SDI) application, you derive this class from <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. For a multiple document interface (MDI) application, you derive this class from <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. If you don't need to customize the behavior of the frame window, you can use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> directly without deriving your own class.  
  
 Your application has one document template for each type of document that it supports. For example, if your application supports both spreadsheets and text documents, the application has two document template objects. Each document template is responsible for creating and managing all the documents of its type.  
  
 The document template stores pointers to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> objects for the document, view, and frame window classes. These <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> objects are specified when constructing a document template.  
  
 The document template contains the ID of the resources used with the document type (such as menu, icon, or accelerator table resources). The document template also has strings containing additional information about its document type. These include the name of the document type (for example, "Worksheet") and the file extension (for example, ".xls"). Optionally, it can contain other strings used by the application's user interface, the Windows File Manager, and Object Linking and Embedding (OLE) support.  
  
 If your application is an OLE container and/or server, the document template also defines the ID of the menu used during in-place activation. If your application is an OLE server, the document template defines the ID of the toolbar and menu used during in-place activation. You specify these additional OLE resources by calling <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 Because <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is an abstract class, you cannot use the class directly. A typical application uses one of the two <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>-derived classes provided by the Microsoft Foundation Class Library: <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, which implements SDI, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, which implements MDI. See those classes for more information on using document templates.  
  
 If your application requires a user-interface paradigm that is fundamentally different from SDI or MDI, you can derive your own class from <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, see [Document Templates and the Document/View Creation Process](../vs140/document-templates-and-the-document-view-creation-process.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cdoctemplate__adddocument">\</a>  CDocTemplate::AddDocument  
 Use this function to add a document to a template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to the document to be added.  
  
### Remarks  
 The derived classes [CMultiDocTemplate](../vs140/cmultidoctemplate-class.md) and [CSingleDocTemplate](../vs140/csingledoctemplate-class.md) override this function. If you derive your own document-template class from <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, your derived class must override this function.  
  
##  \<a name="cdoctemplate__cdoctemplate">\</a>  CDocTemplate::CDocTemplate  
 Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies the ID of the resources used with the document type. This may include menu, icon, accelerator table, and string resources.  
  
 The string resource consists of up to seven substrings separated by the '\n' character (the '\n' character is needed as a place holder if a substring is not included; however, trailing '\n' characters are not necessary); these substrings describe the document type. For information on the substrings, see [GetDocString](#cdoctemplate__getdocstring). This string resource is found in the application's resource file. For example:  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
 Note that the string begins with a '\n' character; this is because the first substring is not used for MDI applications and so is not included. You can edit this string using the string editor; the entire string appears as a single entry in the String Editor, not as seven separate entries.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object of the document class. This class is a **CDocument**-derived class you define to represent your documents.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object of the frame window class. This class can be a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>-derived class, or it can be <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> itself if you want default behavior for your main frame window.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object of the view class. This class is a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>-derived class you define to display your documents.  
  
### Remarks  
 Use this member function to construct a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object. Dynamically allocate a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object and pass it to [CWinApp::AddDocTemplate](../vs140/cwinapp-class.md#cwinapp__adddoctemplate) from the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> member function of your application class.  
  
##  \<a name="cdoctemplate__closealldocuments">\</a>  CDocTemplate::CloseAllDocuments  
 Call this member function to close all open documents.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Specifies whether or not the session is being ended. It is **TRUE** if the session is being ended; otherwise **FALSE**.  
  
### Remarks  
 This member function is typically used as part of the File Exit command. The default implementation of this function calls the [CDocument::DeleteContents](../vs140/cdocument-class.md#cdocument__deletecontents) member function to delete the document's data and then closes the frame windows for all the views attached to the document.  
  
 Override this function if you want to require the user to perform special cleanup processing before the document is closed. For example, if the document represents a record in a database, you may want to override this function to close the database.  
  
##  \<a name="cdoctemplate__createnewdocument">\</a>  CDocTemplate::CreateNewDocument  
 Call this member function to create a new document of the type associated with this document template.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the newly created document, or **NULL** if an error occurs.  
  
##  \<a name="cdoctemplate__createnewframe">\</a>  CDocTemplate::CreateNewFrame  
 Creates a new frame window containing a document and view.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The document to which the new frame window should refer. Can be **NULL**.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The frame window on which the new frame window is to be based. Can be **NULL**.  
  
### Return Value  
 A pointer to the newly created frame window, or **NULL** if an error occurs.  
  
### Remarks  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> uses the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> objects passed to the constructor to create a new frame window with a view and document attached. If the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> parameter is **NULL**, the framework outputs a TRACE message.  
  
 The <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> parameter is used to implement the Window New command. It provides a frame window on which to model the new frame window. The new frame window is usually created invisible. Call this function to create frame windows outside the standard framework implementation of File New and File Open.  
  
##  \<a name="cdoctemplate__createoleframe">\</a>  CDocTemplate::CreateOleFrame  
 Creates an OLE frame window.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A pointer to the frame's parent window.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A pointer to the document to which the new OLE frame window should refer.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Determines whether a view is created along with the frame.  
  
### Return Value  
 A pointer to a frame window if successful; otherwise **NULL**.  
  
### Remarks  
 If <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is zero, an empty frame is created.  
  
##  \<a name="cdoctemplate__getdocstring">\</a>  CDocTemplate::GetDocString  
 Retrieves a string associated with the document type.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object that will contain the string when the function returns.  
  
 *index*  
 An index of the substring being retrieved from the string that describes the document type. This parameter can have one of the following values:  
  
-   **CDocTemplate::windowTitle** Name that appears in the application window's title bar (for example, "Microsoft Excel"). Present only in the document template for SDI applications.  
  
-   **CDocTemplate::docName** Root for the default document name (for example, "Sheet"). This root, plus a number, is used for the default name of a new document of this type whenever the user chooses the New command from the File menu (for example, "Sheet1" or "Sheet2"). If not specified, "Untitled" is used as the default.  
  
-   **CDocTemplate::fileNewName** Name of this document type. If the application supports more than one type of document, this string is displayed in the File New dialog box (for example, "Worksheet"). If not specified, the document type is inaccessible using the File New command.  
  
-   **CDocTemplate::filterName** Description of the document type and a wildcard filter matching documents of this type. This string is displayed in the List Files Of Type drop-down list in the File Open dialog box (for example, "Worksheets (*.xls)"). If not specified, the document type is inaccessible using the File Open command.  
  
-   **CDocTemplate::filterExt** Extension for documents of this type (for example, ".xls"). If not specified, the document type is inaccessible using the File Open command.  
  
-   **CDocTemplate::regFileTypeId** Identifier for the document type to be stored in the registration database maintained by Windows. This string is for internal use only (for example, "ExcelWorksheet"). If not specified, the document type cannot be registered with the Windows File Manager.  
  
-   **CDocTemplate::regFileTypeName** Name of the document type to be stored in the registration database. This string may be displayed in dialog boxes of applications that access the registration database (for example, "Microsoft Excel Worksheet").  
  
### Return Value  
 Nonzero if the specified substring was found; otherwise 0.  
  
### Remarks  
 Call this function to retrieve a specific substring describing the document type. The string containing these substrings is stored in the document template and is derived from a string in the resource file for the application. The framework calls this function to get the strings it needs for the application's user interface. If you have specified a filename extension for your application's documents, the framework also calls this function when adding an entry to the Windows registration database; this allows documents to be opened from the Windows File Manager.  
  
 Call this function only if you are deriving your own class from <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
##  \<a name="cdoctemplate__getfirstdocposition">\</a>  CDocTemplate::GetFirstDocPosition  
 Retrieves the position of the first document associated with this template.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that can be used to iterate through the list of documents associated with this document template; or **NULL** if the list is empty.  
  
### Remarks  
 Use this function to get the position of the first document in the list of documents associated with this template. Use the **POSITION** value as an argument to [CDocTemplate::GetNextDoc](#cdoctemplate__getnextdoc) to iterate through the list of documents associated with the template.  
  
 [CSingleDocTemplate](../vs140/csingledoctemplate-class.md) and [CMultiDocTemplate](../vs140/cmultidoctemplate-class.md) both override this pure virtual function. Any class you derive from <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> must also override this function.  
  
##  \<a name="cdoctemplate__getnextdoc">\</a>  CDocTemplate::GetNextDoc  
 Retrieves the list element identified by <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> to the **POSITION** value of the next entry in the list.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the next document in the list of documents associated with this template.  
  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous call to [GetFirstDocPosition](#cdoctemplate__getfirstdocposition) or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the retrieved element is the last in the list, then the new value of <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is set to **NULL**.  
  
 You can use <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to [GetFirstDocPosition](#cdoctemplate__getfirstdocposition).  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
##  \<a name="cdoctemplate__initialupdateframe">\</a>  CDocTemplate::InitialUpdateFrame  
 Initializes the frame window, and optionally makes it visible.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The frame window that needs the initial update.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The document to which the frame is associated. Can be **NULL**.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Indicates whether the frame should become visible and active.  
  
### Remarks  
 Call **IntitialUpdateFrame** after creating a new frame with <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. Calling this function causes the views in that frame window to receive their <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> calls. Also, if there was not previously an active view, the primary view of the frame window is made active; the primary view is a view with a child ID of **AFX_IDW_PANE_FIRST**. Finally, the frame window is made visible if <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is non-zero. If <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is zero, the current focus and visible state of the frame window will remain unchanged.  
  
 It is not necessary to call this function when using the framework's implementation of File New and File Open.  
  
##  \<a name="cdoctemplate__loadtemplate">\</a>  CDocTemplate::LoadTemplate  
 Loads the resources for a given <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> or derived class.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 This member function is called by the framework to load the resources for a given <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> or derived class. Normally it is called during construction, except when the template is being constructed globally. In that case, the call to <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is delayed until [CWinApp::AddDocTemplate](../vs140/cwinapp-class.md#cwinapp__adddoctemplate) is called.  
  
##  \<a name="cdoctemplate__matchdoctype">\</a>  CDocTemplate::MatchDocType  
 Determines the degree of confidence in the match between a document type and this template.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Pathname of the file whose type is to be determined.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Pointer to a document that is assigned the matching document, if the file specified by <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is already open.  
  
### Return Value  
 A value from the **Confidence** enumeration, which is defined as follows:  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
### Remarks  
 Use this function to determine the type of document template to use for opening a file. If your application supports multiple file types, for example, you can use this function to determine which of the available document templates is appropriate for a given file by calling <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> for each template in turn, and choosing a template according to the confidence value returned.  
  
 If the file specified by <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> is already open, this function returns **CDocTemplate::yesAlreadyOpen** and copies the file's **CDocument** object into the object at <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
 If the file is not open but the extension in <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> matches the extension specified by **CDocTemplate::filterExt**, this function returns **CDocTemplate::yesAttemptNative** and sets <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> to **NULL**. For more information on **CDocTemplate::filterExt**, see [CDocTemplate::GetDocString](#cdoctemplate__getdocstring).  
  
 If neither case is true, the function returns **CDocTemplate::yesAttemptForeign**.  
  
 The default implementation does not return **CDocTemplate::maybeAttemptForeign** or **CDocTemplate::maybeAttemptNative**. Override this function to implement type-matching logic appropriate to your application, perhaps using these two values from the **Confidence** enumeration.  
  
##  \<a name="cdoctemplate__opendocumentfile">\</a>  CDocTemplate::OpenDocumentFile  
 Opens a file specified by a path.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Pointer to the path of the file that contains the document to be opened.  
  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> indicates the document is one of the most recent files; <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> indicates the document is not one of the most recent files.  
  
### Return Value  
 A pointer to the document whose file is named by <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> if unsuccessful.  
  
### Remarks  
 Opens the file whose path is specified by <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, a new file that contains a document of the type associated with this template is created.  
  
##  \<a name="cdoctemplate__removedocument">\</a>  CDocTemplate::RemoveDocument  
 Removes the document pointed to by <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> from the list of documents associated with this template.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Pointer to the document to be removed.  
  
### Remarks  
 The derived classes <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> override this function. If you derive your own document-template class from <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, your derived class must override this function.  
  
##  \<a name="cdoctemplate__saveallmodified">\</a>  CDocTemplate::SaveAllModified  
 Saves all documents that have been modified.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Non-zero if successful; otherwise 0.  
  
##  \<a name="cdoctemplate__setcontainerinfo">\</a>  CDocTemplate::SetContainerInfo  
 Determines the resources for OLE containers when editing an in-place OLE item.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The ID of the resources used when an embedded object is activated.  
  
### Remarks  
 Call this function to set the resources to be used when an OLE object is in-place activated. These resources may include menus and accelerator tables. This function is usually called in the [CWinApp::InitInstance](../vs140/cwinapp-class.md#cwinapp__initinstance) function of your application.  
  
 The menu associated with <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> contains separators that allow the menu of the activated in-place item to merge with the menu of the container application. For more information about merging server and container menus, see the article [Menus and Resources (OLE)](../vs140/menus-and-resources--ole-.md).  
  
##  \<a name="cdoctemplate__setdefaulttitle">\</a>  CDocTemplate::SetDefaultTitle  
 Call this function to load the document's default title and display it in the document's title bar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *pDocument*  
 Pointer to the document whose title is to be set.  
  
### Remarks  
 For information on the default title, see the description of **CDocTemplate::docName** in [CDocTemplate::GetDocString](#cdoctemplate__getdocstring).  
  
##  \<a name="cdoctemplate__setserverinfo">\</a>  CDocTemplate::SetServerInfo  
 Determines the resources and classes when the server document is embedded or edited in-place.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 *nIDOleEmbedding*  
 The ID of the resources used when an embedded object is opened in a separate window.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The ID of the resources used when an embedded object is activated in-place.  
  
 *pOleFrameClass*  
 Pointer to a [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure containing class information for the frame window object created when in-place activation occurs.  
  
 *pOleViewClass*  
 Pointer to a <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> structure containing class information for the view object created when in-place activation occurs.  
  
### Remarks  
 Call this member function to identify resources that will be used by the server application when the user requests activation of an embedded object. These resources consist of menus and accelerator tables. This function is usually called in the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> of your application.  
  
 The menu associated with <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> contains separators that allow the server menu to merge with the menu of the container. For more information about merging server and container menus, see the article [Menus and Resources (OLE)](../vs140/menus-and-resources--ole-.md).  
  
##  \<a name="cdoctemplate__createpreviewframe">\</a>  CDocTemplate::CreatePreviewFrame  
 Creates a child frame used for Rich Preview.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A pointer to a parent window (usually provided by the Shell).  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 A pointer to a document object, whose content will be previewed.  
  
### Return Value  
 A valid pointer to a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object, or <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> if the creation fails.  
  
### Remarks  
  
##  \<a name="cdoctemplate__setpreviewinfo">\</a>  CDocTemplate::SetPreviewInfo  
 Sets up the out of process preview handler.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Specifies a resource ID of the preview frame.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Specifies a pointer to a runtime class information structure of the preview frame.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Specifies a pointer to a runtime class information structure of the preview view.  
  
### Remarks  
  
## See Also  
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSingleDocTemplate](../vs140/csingledoctemplate-class.md)   
 [CMultiDocTemplate](../vs140/cmultidoctemplate-class.md)   
 [CDocument](../vs140/cdocument-class.md)   
 [CView](../vs140/cview-class.md)   
 [CScrollView](../vs140/cscrollview-class.md)   
 [CEditView](../vs140/ceditview-class.md)   
 [CFormView](../vs140/cformview-class.md)   
 [CFrameWnd](../vs140/cframewnd-class.md)   
 [CMDIChildWnd](../vs140/cmdichildwnd-class.md)