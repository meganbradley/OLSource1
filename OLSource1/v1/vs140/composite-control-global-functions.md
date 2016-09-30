---
title: "Composite Control Global Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "composite controls, global functions"
ms.assetid: 536884cd-e863-4c7a-ab0a-604dc60a0bbe
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Composite Control Global Functions
These functions provide support for creating dialog boxes, and for creating, hosting and licensing ActiveX controls.  
  
> [!IMPORTANT]
>  The functions listed in the following table cannot be used in applications that execute in the                 [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
|||  
|-|-|  
|[AtlAxDialogBox](../vs140/atlaxdialogbox.md)|Creates a modal dialog box from a dialog template provided by the user. The resulting dialog box can contain ActiveX controls.|  
|[AtlAxCreateDialog](../vs140/atlaxcreatedialog.md)|Creates a modeless dialog box from a dialog template provided by the user. The resulting dialog box can contain ActiveX controls.|  
|[AtlAxCreateControl](../vs140/atlaxcreatecontrol.md)|Creates an ActiveX control, initializes it, and hosts it in the specified window.|  
|[AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md)|Creates an ActiveX control, initializes it, hosts it in the specified window, and retrieves an interface pointer (or pointers) from the control.|  
|[AtlAxCreateControlLic](../vs140/atlaxcreatecontrollic.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window.|  
|[AtlAxCreateControlLicEx](../vs140/atlaxcreatecontrollicex.md)|Creates a licensed ActiveX control, initializes it, hosts it in the specified window, and retrieves an interface pointer (or pointers) from the control.|  
|[AtlAxAttachControl](../vs140/atlaxattachcontrol.md)|Attaches a previously created control to the specified window.|  
|[AtlAxGetHost](../vs140/atlaxgethost.md)|Used to obtain a direct interface pointer to the container for a specified window (if any), given its handle.|  
|[AtlAxGetControl](../vs140/atlaxgetcontrol.md)|Used to obtain a direct interface pointer to the control contained inside a specified window (if any), given its handle.|  
|[AtlSetChildSite](../vs140/atlsetchildsite.md)|Initializes the                             **IUnknown** of the child site.|  
|[AtlAxWinInit](../vs140/atlaxwininit.md)|Initializes the hosting code for AxWin objects.|  
|[AtlAxWinTerm](../vs140/atlaxwinterm.md)|Uninitializes the hosting code for AxWin objects.|  
|[AtlGetObjectSourceInterface](../vs140/atlgetobjectsourceinterface.md)|Returns information about the default source interface of an object.|  
  
##  \<a name="atlaxdialogbox">\</a>  AtlAxDialogBox  
 Creates a modal dialog box from a dialog template provided by the user.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] Identifies an instance of the module whose executable file contains the dialog box template.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [in] Identifies the dialog box template. This parameter is either the pointer to a null-terminated character string that specifies the name of the dialog box template or an integer value that specifies the resource identifier of the dialog box template. If the parameter specifies a resource identifier, its high-order word must be zero and its low-order word must contain the identifier. You can use the                                 [MAKEINTRESOURCE](http://msdn.microsoft.com/library/windows/desktop/ms648029) macro to create this value.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [in] Identifies the window that owns the dialog box.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 [in] Points to the dialog box procedure. For more information about the dialog box procedure, see                                 [DialogProc](http://msdn.microsoft.com/library/windows/desktop/ms645469).  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 [in] Specifies the value to pass to the dialog box in the                                 **lParam** parameter of the                                 **WM_INITDIALOG** message.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 To use                         **AtlAxDialogBox** with a dialog template that contains an ActiveX control, specify a valid                         **CLSID**,                         **APPID** or URL string as the                         *text* field of the                         **CONTROL** section of the dialog resource, along with "AtlAxWin80" as the                         *class name* field under the same section. The following demonstrates what a valid                         **CONTROL** section might look like:  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 For more information on editing resource scripts, see                         [Opening a Resource Script File in Text Format](../vs140/how-to--open-a-resource-script-file-in-text-format.md). For more information on control resource-definition statements, see                         [Common Control Parameters](http://msdn.microsoft.com/library/windows/desktop/aa380902) under                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*: SDK Tools*.  
  
 For more information on dialog boxes in general, refer to                         [DialogBox](http://msdn.microsoft.com/library/windows/desktop/ms645452) and                         [CreateDialogParam](http://msdn.microsoft.com/library/windows/desktop/ms645445) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="atlaxcreatedialog">\</a>  AtlAxCreateDialog  
 Creates a modeless dialog box from a dialog template provided by the user.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [in] Identifies an instance of the module whose executable file contains the dialog box template.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 [in] Identifies the dialog box template. This parameter is either the pointer to a null-terminated character string that specifies the name of the dialog box template or an integer value that specifies the resource identifier of the dialog box template. If the parameter specifies a resource identifier, its high-order word must be zero and its low-order word must contain the identifier. You can use the                                 [MAKEINTRESOURCE](http://msdn.microsoft.com/library/windows/desktop/ms648029) macro to create this value.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 [in] Identifies the window that owns the dialog box.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 [in] Points to the dialog box procedure. For more information about the dialog box procedure, see                                 [DialogProc](http://msdn.microsoft.com/library/windows/desktop/ms645469).  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 [in] Specifies the value to pass to the dialog box in the                                 **lParam** parameter of the                                 **WM_INITDIALOG** message.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 The resulting dialog box can contain ActiveX controls.  
  
 See                         [CreateDialog](http://msdn.microsoft.com/library/windows/desktop/ms645434) and                         [CreateDialogParam](http://msdn.microsoft.com/library/windows/desktop/ms645445) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="atlaxcreatecontrol">\</a>  AtlAxCreateControl  
 Creates an ActiveX control, initializes it, and hosts it in the specified window.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A pointer to a string to be passed to the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:\<HTML>\<BODY>This is a line of text\</BODY>\</HTML>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 [in] Handle to the window that the control will be attached to.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 [in] A pointer to a stream that is used to initialize the properties of the control. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the                                 **IUnknown** of the container. Can be                                 **NULL**.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 This global function gives you the same result as calling                         [AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md)(                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>**, NULL, NULL, NULL, NULL** );.  
  
 To create a licensed ActiveX control, see                         [AtlAxCreateControlLic](../vs140/atlaxcreatecontrollic.md).  
  
##  \<a name="atlaxcreatecontrolex">\</a>  AtlAxCreateControlEx  
 Creates an ActiveX control, initializes it, and hosts it in the specified window. An interface pointer and event sink for the new control can also be created.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to a string to be passed to the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:\<HTML>\<BODY>This is a line of text\</BODY>\</HTML>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 [in] Handle to the window that the control will be attached to.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 [in] A pointer to a stream that is used to initialize the properties of the control. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the                                 **IUnknown** of the container. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the                                 **IUnknown** of the created control. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The interface identifier of an outgoing interface on the contained object.  
  
 *punkSink*  
 A pointer to the                                 **IUnknown** interface of the sink object to be connected to the connection point specified by                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> on the contained object after the contained object has been successfully created.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is similar to                         [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md) but also allows you to receive an interface pointer to the newly created control and set up an event sink to receive events fired by the control.  
  
 To create a licensed ActiveX control, see                         [AtlAxCreateControlLicEx](../vs140/atlaxcreatecontrollicex.md).  
  
##  \<a name="atlaxcreatecontrollic">\</a>  AtlAxCreateControlLic  
 Creates a licensed ActiveX control, initializes it, and hosts it in the specified window.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A pointer to a string to be passed to the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:\<HTML>\<BODY>This is a line of text\</BODY>\</HTML>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Handle to the window that the control will be attached to.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to a stream that is used to initialize the properties of the control. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The address of a pointer that will receive the                                 **IUnknown** of the container. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The BSTR containing the license for the control.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Example  
 See                                 [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample of how to use                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
##  \<a name="atlaxcreatecontrollicex">\</a>  AtlAxCreateControlLicEx  
 Creates a licensed ActiveX control, initializes it, and hosts it in the specified window. An interface pointer and event sink for the new control can also be created.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to a string to be passed to the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:\<HTML>\<BODY>This is a line of text\</BODY>\</HTML>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Handle to the window that the control will be attached to.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A pointer to a stream that is used to initialize the properties of the control. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The address of a pointer that will receive the                                 **IUnknown** of the container. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the                                 **IUnknown** of the created control. Can be                                 **NULL**.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The interface identifier of an outgoing interface on the contained object.  
  
 *punkSink*  
 A pointer to the                                 **IUnknown** interface of the sink object to be connected to the connection point specified by                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> on the contained object after the contained object has been successfully created.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The BSTR containing the license for the control.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is similar to                         [AtlAxCreateControlLic](../vs140/atlaxcreatecontrollic.md) but also allows you to receive an interface pointer to the newly created control and set up an event sink to receive events fired by the control.  
  
### Example  
 See                                 [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample of how to use                                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
##  \<a name="atlaxattachcontrol">\</a>  AtlAxAttachControl  
 Attaches a previously created control to the specified window.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 [in] A pointer to the                                 **IUnknown** of the control.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 [in] Handle to the window that will host the control.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 [out] A pointer to a pointer to the                                 **IUnknown** of the container object.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 Use                         [AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md) and                         [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md) to simultaneously create and attach a control.  
  
> [!NOTE]
>  The control object being attached must be correctly initialized before calling                             <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
##  \<a name="atlaxgethost">\</a>  AtlAxGetHost  
 Obtains a direct interface pointer to the container for a specified window (if any), given its handle.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 [in] A handle to the window that is hosting the control.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 [out] The                                 **IUnknown** of the container of the control.  
  
### Return Value  
 One of the standard HRESULT values.  
  
##  \<a name="atlaxgetcontrol">\</a>  AtlAxGetControl  
 Obtains a direct interface pointer to the control contained inside a specified window given its handle.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 [in] A handle to the window that is hosting the control.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 [out] The                                 **IUnknown** of the control being hosted.  
  
### Return Value  
 One of the standard HRESULT values.  
  
##  \<a name="atlsetchildsite">\</a>  AtlSetChildSite  
 Call this function to set the site of the child object to the                 **IUnknown** of the parent object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *punkChild*  
 [in] A pointer to the                                 **IUnknown** interface of the child.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 [in] A pointer to the                                 **IUnknown** interface of the parent.  
  
### Return Value  
 A standard HRESULT value.  
  
##  \<a name="atlaxwininit">\</a>  AtlAxWinInit  
 This function initializes ATL's control hosting code by registering the                 **"AtlAxWin80"** and                 **"AtlAxWinLic80"** window classes plus a couple of custom window messages.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the initialization of the control hosting code was successful; otherwise                         **FALSE**.  
  
### Remarks  
 This function must be called before using the                         [ATL control hosting API](../vs140/what-is-the-atl-control-hosting-api-.md). Following a call to this function, the                         **"AtlAxWin"** window class can be used in calls to                         [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) or                         [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680), as described in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more details on when to call this function, see                         [When Do I Need To Call AtlAxWinInit?](../vs140/when-do-i-need-to-call-atlaxwininit-.md)  
  
##  \<a name="atlaxwinterm">\</a>  AtlAxWinTerm  
 This function uninitializes ATL's control hosting code by unregistering the                 **"AtlAxWin80"** and                 **"AtlAxWinLic80"** window classes.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Always returns                         **TRUE**.  
  
### Remarks  
 This function simply calls                         [UnregisterClass](http://msdn.microsoft.com/library/windows/desktop/ms644899) as described in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Call this function to clean up after all existing host windows have been destroyed if you called                         [AtlAxWinInit](../vs140/atlaxwininit.md) and you no longer need to create host windows. If you don't call this function, the window class will be unregistered automatically when the process terminates.  
  
##  \<a name="atlgetobjectsourceinterface">\</a>  AtlGetObjectSourceInterface  
 Call this function to retrieve information about the default source interface of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 [in] A pointer to the object for which information is to be returned.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 [out] A pointer to the LIBID of the type library containing the definition of the source interface.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 [out] A pointer to the interface ID of the object's default source interface.  
  
 *pdwMajor*  
 [out] A pointer to the major version number of the type library containing the definition of the source interface.  
  
 *pdwMinor*  
 [out] A pointer to the minor version number of the type library containing the definition of the source interface.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> can provide you with the interface ID of the default source interface, along with the LIBID and major and minor version numbers of the type library describing that interface.  
  
> [!NOTE]
>  For this function to successfully retrieve the requested information, the object represented by                             <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> must implement                             <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> (and return type information through                             **IDispatch::GetTypeInfo**) plus it must also implement either                             <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or                             <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. The type information for the source interface must be in the same type library as the type information for                             <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Example  
 The example below shows how you might define an event sink class,                                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, that reduces the number of template arguments that you can pass to                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to the bare essentials.                                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and                                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> use                                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> to initialize the                                 [IDispEventImpl](../vs140/idispeventimpl-class.md) members before calling                                 [DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md) or                                 [DispEventUnadvise](../vs140/idispeventsimpleimpl--dispeventunadvise.md).  
  
 [!code[NVC_ATL_Windowing#93](../vs140/codesnippet/CPP/composite-control-global-functions_1.h)]  
  
## See Also  
 [ATL Functions](../vs140/atl-functions.md)   
 [Composite Control Macros](../vs140/composite-control-macros.md)