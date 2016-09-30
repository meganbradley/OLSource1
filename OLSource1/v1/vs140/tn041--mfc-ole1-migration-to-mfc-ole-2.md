---
title: "TN041: MFC-OLE1 Migration to MFC-OLE 2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "TN041: MFC/OLE1 Migration to MFC/OLE 2"
f1_keywords: 
  - "vc.mfc.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE1 [C++]"
  - "migrating OLE1 to OLE2"
  - "migration [C++], OLE1 to OLE2"
  - "OLE2 [C++]"
  - "porting OLE1 to OLE2"
  - "converting OLE1 to OLE2"
  - "upgrading Visual C++ applications, OLE1 to OLE2"
  - "TN041"
ms.assetid: 67f55552-4b04-4ddf-af0b-4d9eaf5da957
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN041: MFC-OLE1 Migration to MFC-OLE 2
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
## General Issues Relating to Migration  
 One of the design goals for the OLE 2 classes in MFC 2.5 (and higher) was to retain much of the same architecture put in place in MFC 2.0 for OLE 1.0 support. As a result, many of the same OLE classes in MFC 2.0 still exist in this version of MFC (<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>). In addition, many of the APIs in these classes are exactly the same. However, OLE 2 is drastically different from OLE 1.0 so you can expect that some of the details have changed. If you are familiar with MFC 2.0's OLE1 support, you'll feel at home with MFC's 2.0 support.  
  
 If you are taking an existing MFC/OLE1 application and adding OLE 2 functionality to it, you should read this note first. This note covers some general issues you may encounter while porting your OLE1 functionality to MFC/OLE 2 and then discusses the problems uncovered while porting two applications included in MFC 2.0: the MFC OLE samples [OCLIENT](../vs140/visual-c---samples.md) and [HIERSVR](../vs140/visual-c---samples.md).  
  
## MFC Document/View Architecture Is Important  
 If your application does not use MFC's Document/View architecture and you want to add OLE 2 support to your application, now is the time to move to Document/View. Many of the benefits of MFC's OLE 2 classes are only realized once your application is using the built-in architecture and components of MFC.  
  
 Implementing a server or container without using the MFC architecture is possible, but not recommended.  
  
## Use MFC Implementation Instead of Your Own  
 MFC "canned implementation" classes such as <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> have built-in special case code for OLE 2 support. So, if you can use these classes in your application you'll benefit from the effort put into them to make them OLE aware. Again, it is possible to "roll-your-own" classes here for these purposes, but it is not suggested. If you need to implement similar functionality, the MFC source code is an excellent reference for dealing with some of the finer points of OLE (especially when it comes to in-place activation).  
  
## Examine the MFC Sample Code  
 There are a number of MFC samples that include OLE functionality. Each of these applications implements OLE from a different angle:  
  
-   [HIERSVR](../vs140/visual-c---samples.md) Meant mostly for use as a server application. It was included in MFC 2.0 as an MFC/OLE1 application and has been ported to MFC/OLE 2 and then extended such that it implements many OLE features available in OLE 2.  
  
-   [OCLIENT](../vs140/visual-c---samples.md) This is a stand-alone container application, meant to demonstrate many of the OLE features from a container standpoint. It too was ported from MFC 2.0, and then extended to support many of the more advanced OLE features, such as custom clipboard formats and links to embedded items.  
  
-   [DRAWCLI](../vs140/visual-c---samples.md) This application implements OLE container support much like OCLIENT does, except that it does so within the framework of an existing object-oriented drawing program. It shows you how you might implement OLE container support and integrate it into your existing application.  
  
-   [SUPERPAD](../vs140/visual-c---samples.md) This application, as well as being a fine stand-alone application, is also an OLE server. The server support it implements is quite minimalist. Of particular interest is how it uses OLE clipboard services to copy data to the clipboard, but uses the functionality built into the Windows "edit" control to implement clipboard paste functionality. This shows an interesting mix of traditional Windows API usage as well as integration with the new OLE APIs.  
  
 For more information on the sample applications, see the "MFC Sample Help".  
  
## Case Study: OCLIENT from MFC 2.0  
 As discussed above, [OCLIENT](../vs140/visual-c---samples.md) was included in MFC 2.0 and implemented OLE with MFC/OLE1. The steps by which this application was initially converted to use the MFC/OLE 2 classes are described below. A number of features were added after the initial port was completed to better illustrate the MFC/OLE classes. These features will not be covered here; refer to the sample itself for more information on those advanced features.  
  
> [!NOTE]
>  The compiler errors and step-by-step process was created with Visual C++ 2.0. Specific error messages and locations may have changed with Visual C++ 4.0, but the conceptual information remains valid.  
  
## Getting It Up and Running  
 The approach taken to port the OCLIENT sample to MFC/OLE is to start by building it and fixing the obvious compiler errors that will result. If you take the OCLIENT sample from MFC 2.0 and compile it under this version of MFC, you'll find that there are not that many errors to resolve. The errors in the order in which they occurred are described below.  
  
## Compile and Fix Errors  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The first error concerns <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. In MFC/OLE1 it took more parameters than the MFC/OLE version takes. The extra parameters were often not necessary and usually NULL (as in this example). This version of MFC can automatically determine the values for the lpWBounds when the CDC that is being drawn to is a metafile DC. In addition, the pFormatDC parameter is no longer necessary since the framework will build one from the "attribute DC" of the pDC passed in. So to fix this problem, you simply remove the two extra NULL parameters to the Draw call.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The errors above result from the fact that all of the **COleClientItem::CreateXXXX** functions in MFC/OLE1 required that a unique name be passed to represent the item. This was a requirement of the underlying OLE API. This is not necessary in MFC/OLE 2 since OLE 2 does not use DDE as the underlying communications mechanism (the name was used in DDE conversations). To fix this problem, you can remove the **CreateNewName** function as well as all references to it. It is easy to find out what each MFC/OLE function is expecting in this version simply by placing your cursor on the call and pressing F1.  
  
 Another area that is significantly different is OLE 2 clipboard handling. With OLE1, you used the Windows clipboard APIs interact with the clipboard. With OLE 2 this is done with a different mechanism. The MFC/OLE1 APIs assumed that the clipboard was open before copying a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object to the clipboard. This is no longer necessary and will cause all MFC/OLE clipboard operations to fail. While you edit the code to remove dependencies on **CreateNewName**, you should also remove the code that opens and closes the Windows clipboard.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 These errors result from the **CMainView::OnInsertObject** handler. Handling the "Insert New Object" command is another area where things have changed quite a bit. In this case, it is easiest to simply merge the original implementation with that provided by AppWizard for a new OLE Container application. In fact, this is a technique that you can apply to porting other applications. In MFC/OLE1, you displayed the "Insert Object" dialog by calling **AfxOleInsertDialog** function. In this version you construct a **COleInsertObject** dialog object and call <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. In addition, new OLE items are created with a **CLSID** instead of a classname string. The end result should look something like this  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
> [!NOTE]
>  Insert New Object may be different for your application):  
  
 It is also necessary to include \<afxodlgs.h>, which contains the declaration for the **COleInsertObject** dialog class as well as the other standard dialogs provided by MFC.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 These errors are caused by the fact that some OLE1 constants have changed in OLE 2, even though in concept they are the same. In this case **OLEVERB_PRIMARY** has changed to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. In both OLE1 and OLE 2, the primary verb is usually executed by a container when the user double-clicks on an item.  
  
 In addition, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> now takes an extra parameter — a pointer to a view (<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>*). This parameter is only used to implement "Visual Editing" (or in-place activation). For now you set that parameter to NULL, because you are not implementing this feature at this time.  
  
 To make sure that the framework never attempts to in-place activate, you should override <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In MFC/OLE1, **COleClientItem::GetBounds** and **SetBounds** were used to query and manipulate the extent of an item (the **left** and **top** members were always zero). In MFC/OLE 2 this is more directly supported by <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, which deal with a **SIZE** or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> instead.  
  
 The code for your new SetItemRectToServer, and UpdateItemRectFromServer calls look like this:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 In MFC/OLE1 synchronous API calls from a container to a server were *simulated*, because OLE1 was inherently asynchronous in many cases. It was necessary to check for an outstanding asynchronous call in progress before processing commands from the user. MFC/OLE1 provided the **COleClientItem::InWaitForRelease** function for doing so. In MFC/OLE 2 this is not necessary, so you can to remove the override of OnCommand in CMainFrame all together.  
  
 At this point OCLIENT will compile and link.  
  
## Other Necessary Changes  
 There are few things that are not done that will keep OCLIENT from running, however. It is better to fix these problems now instead of later.  
  
 First, it is necessary to initialize the OLE libraries. This is done by calling **AfxOleInit** from <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 It is also a good idea to check for virtual functions for parameter list changes. One such function is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, overridden in every MFC/OLE container application. By looking at online help, you'll see that an extra 'DWORD dwParam' was added. The new CRectItem::OnChange looks as follows:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 In MFC/OLE1, container applications derived the document class from **COleClientDoc**. In MFC/OLE 2 this class has been removed and replaced by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> (this new organization makes it easier to build container/server applications). There is a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> that maps **COleClientDoc** to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to simplify porting of MFC/OLE1 applications to MFC/OLE 2, such as OCLIENT. One of the features not supplied by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> that was provided by **COleClientDoc** is the standard command message map entries. This is done so that server applications, which also use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> (indirectly), do not carry with them the overhead of these command handlers unless they are a container/server application. You need to add the following entries to the CMainDoc message map:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The implementation of all of these commands is in <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, which is the base class for your document.  
  
 At this point, OCLIENT is a functional OLE container application. It is possible to insert items of any type (OLE1 or OLE 2). Since the necessary code to enable in-place activation is not implemented, items are edited in a separate window much like with OLE1. The next section discusses the necessary changes to enable in-place editing (sometimes called "Visual Editing").  
  
## Adding "Visual Editing"  
 One of the most interesting features of OLE is in-place activation (or "Visual Editing"). This feature allows the server application to take over portions of the container's user interface to provided a more seamless editing interface for the user. To implement in-place activation to OCLIENT, some special resources need to be added, as well as some additional code. These resources and the code are normally provided by AppWizard — in fact, much of the code here was borrowed directly from a fresh AppWizard application with "Container" support.  
  
 First of all, it is necessary to add a menu resource to be used when there is an item which is in-place active. You can create this extra menu resource in Visual C++ by copying the IDR_OCLITYPE resource and removing all but the File and Window pop-ups. Two separator bars are inserted between the File and Window pop-ups to indicate the separation of groups (it should look like: File &#124; &#124; Window). For more information on what these separators mean and how the server and container menus are merged see "Menus and Resources: Menu Merging" in *OLE 2 Classes*.  
  
 Once you have these menus created, you need to let the framework know about them. This is done by calling <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> for the document template before you add it to the document template list in your InitInstance. The new code to register the document template looks like this:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The IDR_OLECLITYPE_INPLACE resource is the special in-place resource created in Visual C++.  
  
 To enable in-place activation, there are some things that need to change in both the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> (CMainView) derived class as well as the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> derived class (CRectItem). All of these overrides are provided by AppWizard and most of the implementation will come directly from a default AppWizard application.  
  
 In the first step of this port, in-place activation was disabled entirely by overriding <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. This override should be removed to allow in-place activation. In addition, NULL was passed to all calls to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> (there are two of them) because providing the view was only necessary for in-place activation. To fully implement in-place activation, it is necessary to pass the correct view in the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> call. One of these calls is in **CMainView::OnInsertObject**:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Another is in **CMainView::OnLButtonDblClk**:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 It is necessary to override <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. This tells the server where to put its window relative to the container's window when the item is in-place activated. For OCLIENT, the implementation is trivial:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Most servers also implement what is called "in-place resizing." This allows the server window to be sized and moved while the user is editing the item. The container must participate in this action, since moving or resizing the window usually affects the position and size within the container document itself. The implementation for OCLIENT synchronizes the internal rectangle maintained by m_rect with the new position and size.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 At this point, there is enough code to allow an item to be in-place activated and to deal with sizing and moving the item when it is active, but no code will allow the user to exit the editing session. Although some servers will provide this functionality themselves by handling the escape key, it is suggested that containers provide two ways to deactivate an item: (1) by clicking outside the item, and (2) by pressing the ESCAPE key.  
  
 For the ESCAPE key, add an accelerator with Visual C++ that maps the VK_ESCAPE key to a command, ID_CANCEL_EDIT is added to the resources. The handler for this command follows:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 To handle the case where the user clicks outside the item, you add the following code to the start of **CMainView::SetSelection**:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 When an item is in-place active, it should have the focus. To make sure this is the case you handle OnSetFocus so that focus is always transferred to the active item when your view receives the focus:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 When the view is resized, you need to notify the active item that the clipping rectangle has changed. To do this you provide a handler for <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
## Case Study: HIERSVR from MFC 2.0  
 [HIERSVR](../vs140/visual-c---samples.md) was also included in MFC 2.0 and implemented OLE with MFC/OLE1. This note briefly describes the steps by which this application was initially converted to use the MFC/OLE 2 classes. A number of features were added after the initial port was completed to better illustrate the MFC/OLE 2 classes. These features will not be covered here; refer to the sample itself for more information on those advanced features.  
  
> [!NOTE]
>  The compiler errors and step-by-step process was created with Visual C++ 2.0. Specific error messages and locations may have changed with Visual C++ 4.0, but the conceptual information remains valid.  
  
## Getting It Up and Running  
 The approach taken to port the HIERSVR sample to MFC/OLE is to start by building it and fixing the obvious compiler errors that will result. If you take the HIERSVR sample from MFC 2.0 and compile it under this version of MFC, you'll find that there are not many errors to resolve (although there are more than with the OCLIENT sample). The errors in the order in which they usually occur are described below.  
  
## Compile and Fix Errors  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 This first error points out a much larger problem with the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> function for servers. The initialization required for an OLE server is probably one of the biggest changes you'll have to make to your MFC/OLE1 application to get it running. The best thing to do is look at what AppWizard creates for an OLE server and modify your code as appropriate. Here are some points to keep in mind:  
  
 It is necessary to initialize the OLE libraries by calling **AfxOleInit**  
  
 Call SetServerInfo on the document template object to set server resource handles and runtime class information that you can't set with the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> constructor.  
  
 Don't show the main window of your application if /Embedding is present on the command line.  
  
 You'll need a **GUID** for your document. This is a unique identifier for your document's type (128 bits). AppWizard will create one for you — so if you use the technique described here of copying the new code from a new AppWizard generated server application, you can simply "steal" the GUID from that application. If not, you can use the GUIDGEN.EXE utility in the BIN directory.  
  
 It is necessary to "connect" your <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object to the document template by calling <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
 Update the system registry when your application is run stand-alone. This way, if the user moves the .EXE for your application, running it from its new location will update the Windows system registration database to point to the new location.  
  
 After applying all of these changes based on what AppWizard creates for <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> (and related GUID) for HIERSVR should read as follows:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 You will notice that the code above refers to a new resource ID, IDR_HIERSVRTYPE_SRVR_EMB. This is the menu resource to be used when a document that is embedded in another container is edited. In MFC/OLE1 the menu items specific to editing an embedded item were modified on the fly. Using an entirely different menu structure when editing an embedded item instead of editing a file-based document makes it much easier to provide different user interfaces for these two separate modes. As you'll see later, an entirely separate menu resource is used when editing an embedded object in-place.  
  
 To create this resource, load the resource script into Visual C++ and copy the existing IDR_HIERSVRTYPE menu resource. Rename the new resource to IDR_HIERSVRTYPE_SRVR_EMB (this is the same naming convention that AppWizard uses). Next change "File Save" to "File Update"; give it command ID **ID_FILE_UPDATE**. Also change "File Save As" to "File Save Copy As"; give it command ID **ID_FILE_SAVE_COPY_AS**. The framework provides the implementation of both of these commands.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 There are a number of errors resulting from the override of <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, since it is referring to the **OLESTATUS** type. **OLESTATUS** was the way OLE1 returned errors. This has changed to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> in OLE 2, although MFC usually converts an <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> into a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> containing the error. In this particular case, the override of <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is no longer necessary, so the easiest thing to do is to remove it.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> constructor takes an extra 'BOOL' parameter. This flag determines how memory management is done on the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> objects. By setting it to TRUE, the framework handles the memory management of these objects — deleting them when they are no longer necessary. HIERSVR uses **CServerItem** (derived from <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>) objects as part of its native data, so you'll set this flag to FALSE. This lets HIERSVR determine when each server item is deleted.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 As these errors imply, there are some 'pure-virtual' functions that have not been overridden in CServerItem. Most likely this is caused by the fact that OnDraw's parameter list has changed. To fix this error, change **CServerItem::OnDraw** as follows (as well as the declaration in svritem.h):  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The new parameter is 'rSize'. This allows you to fill in the size of the drawing, if convenient. This size must be in **HIMETRIC**. In this case, it is not convenient to fill this value in, so the framework calls <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> to retrieve the extent. For that to work, you'll have to implement <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 In the CServerItem::CalcNodeSize function the item size is converted to **HIMETRIC** and stored in **m_rectBounds**. The undocumented '**m_rectBounds**' member of <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> does not exist (it has been partially replaced by <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, but in OLE 2 this member has a slightly different usage than **m_rectBounds** did in OLE1). Instead of setting the **HIMETRIC** size into this member variable, you'll return it. This return value is used in <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, implemented previously.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 CServerItem also overrides **COleServerItem::OnGetTextData**. This function is obsolete in MFC/OLE and is replaced by a different mechanism. The MFC 3.0 version of the MFC OLE sample [HIERSVR](../vs140/visual-c---samples.md) implements this functionality by overriding <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. This functionality is not important for this basic port, so you can remove the OnGetTextData override.  
  
 There are many more errors in svritem.cpp that have not been addressed. They are not "real" errors — just errors caused by previous errors.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> no longer supports the 'bIncludeNative' flag. The native data (the data written out by the server item's Serialize function) is always copied, so you remove the first parameter. In addition, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> will throw an exception when an error happens instead of returning FALSE. Change the code for CServerView::OnEditCopy as follows:  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Although there were more errors resulting from the compilation of the MFC 2.0 version of HIERSVR than there were for the same version of OCLIENT, there were actually fewer changes.  
  
 At this point HIERSVR will compile and link and function as an OLE server, but without the in-place editing feature, which will be implemented next.  
  
## Adding "Visual Editing"  
 To add "Visual Editing" (or in-place activation) to this server application, there are only a few things you must take care of:  
  
-   You need a special menu resource to be used when the item is in-place active.  
  
-   This application has a toolbar, so you'll need a toolbar with only a subset of the normal toolbar to match the menu commands available from the server (matches the menu resource mentioned above).  
  
-   You need a new class derived from <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> that provides the in-place user interface (much like CMainFrame, derived from <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, provides the MDI user interface).  
  
-   You need to tell the framework about these special resources and classes.  
  
 The menu resource is easy to create. Run Visual C++, copy the menu resource IDR_HIERSVRTYPE to a menu resource called IDR_HIERSVRTYPE_SRVR_IP. Modify the menu so that only the Edit and Help menu popups are left. Add two separators to the menu in between the Edit and Help menus (it should look like: Edit &#124; &#124; Help). For more information on what these separators mean and how the server and container menus are merged, see "Menus and Resources: Menu Merging" in *OLE 2 Classes*.  
  
 The bitmap for the subset toolbar can be easily created by copying the one from a fresh AppWizard generated application with a "Server" option checked. This bitmap can then be imported into Visual C++. Be sure to give the bitmap an ID of IDR_HIERSVRTYPE_SRVR_IP.  
  
 The class derived from <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> can be copied from an AppWizard generated application with server support as well. Copy both files, IPFRAME.CPP and IPFRAME.H and add them to the project. Make sure that the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> call refers to IDR_HIERSVRTYPE_SRVR_IP, the bitmap created in the previous step.  
  
 Now that all the new resources and classes are created, add the necessary code so that the framework knows about these (and knows that this application now supports in-place editing). This is done by adding some more parameters to the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> call in the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> function:  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 It is now ready to run in-place in any container that also supports in-place activation. But, there is one minor bug still lurking in the code. HIERSVR supports a context menu, displayed when the user presses the right mouse button. This menu works when HIERSVR is fully open, but does not work when editing an embedding in-place. The reason can be pinned down to this single line of code in CServerView::OnRButtonDown:  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Notice the reference to **AfxGetApp()->m_pMainWnd**. When the server is in-place activated, it has a main window and m_pMainWnd is set, but it is usually invisible. Furthermore, this window refers to the *main* window of the application, the MDI frame window that appears when the server is fully open or run stand-alone. It does not refer to the active frame window — which when in-place activated is a frame window derived from <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. To get the correct active window even when in-place editing, this version of MFC adds a new function, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>. Generally, you should use this function instead of **AfxGetApp()->m_pMainWnd**. This code needs to change as follows:  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Now you have an OLE server minimally enabled for functional in-place activation. But there are still many features available with MFC/OLE 2 that were not available in MFC/OLE1. See the HIERSVR sample for more ideas on features you might want to implement. Some of the features that HIERSVR implements are listed below:  
  
-   Zooming, for true WYSISYG behavior with respect to the container.  
  
-   Drag / drop and a custom clipboard format.  
  
-   Scrolling the container window as the selection is changed.  
  
 The HIERSVR sample in MFC 3.0 also uses a slightly different design for its server items. This helps conserve memory and makes your links more flexible. With the 2.0 version of HIERSVR each node in the tree *is-a* <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> carries a bit more overhead than is strictly necessary for each of these nodes, but a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is required for each active link. But for the most part, there are very few active links at any given time. To make this more efficient, the HIERSVR in this version of MFC separates the node from the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. It has both a CServerNode and a **CServerItem** class. The **CServerItem** (derived from <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>) is only created as necessary. Once the container (or containers) stop using that particular link to that particular node, the CServerItem object associated with the CServerNode is deleted. This design is more efficient and more flexible. Its flexibility comes in when dealing with multiple selection links. Neither of these two versions of HIERSVR support multiple selection, but it would be much easier to add (and to support links to such selections) with the MFC 3.0 version of HIERSVR, since the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is separated from the native data.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)