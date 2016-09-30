---
title: "CCmdTarget Class"
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
  - "CCmdTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message maps, CCmdTarget base class"
  - "command targets"
  - "CCmdTarget class"
  - "command routing, command targets"
  - "targets, command"
ms.assetid: 8883b132-2057-4ce0-a5f2-88979f8f2b13
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget Class
The base class for the Microsoft Foundation Class Library message-map architecture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCmdTarget::CCmdTarget](#ccmdtarget__ccmdtarget)|Constructs a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CCmdTarget::BeginWaitCursor](#ccmdtarget__beginwaitcursor)|Displays the cursor as an hourglass cursor.|  
|[CCmdTarget::DoOleVerb](#ccmdtarget__dooleverb)|Causes an action specified by an OLE verb to be performed.|  
|[CCmdTarget::EnableAutomation](#ccmdtarget__enableautomation)|Allows OLE automation for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[CCmdTarget::EnableConnections](#ccmdtarget__enableconnections)|Enables event firing over connection points.|  
|[CCmdTarget::EnableTypeLib](#ccmdtarget__enabletypelib)|Enables an object's type library.|  
|[CCmdTarget::EndWaitCursor](#ccmdtarget__endwaitcursor)|Returns to the previous cursor.|  
|[CCmdTarget::EnumOleVerbs](#ccmdtarget__enumoleverbs)|Enumerates an object's OLE verbs.|  
|[CCmdTarget::FromIDispatch](#ccmdtarget__fromidispatch)|Returns a pointer to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object associated with the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> pointer.|  
|[CCmdTarget::GetDispatchIID](#ccmdtarget__getdispatchiid)|Gets the primary dispatch interface ID.|  
|[CCmdTarget::GetIDispatch](#ccmdtarget__getidispatch)|Returns a pointer to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object associated with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[CCmdTarget::GetTypeInfoCount](#ccmdtarget__gettypeinfocount)|Retrieves the number of type information interfaces that an object provides.|  
|[CCmdTarget::GetTypeInfoOfGuid](#ccmdtarget__gettypeinfoofguid)|Retrieves the type description that corresponds to the specified GUID.|  
|[CCmdTarget::GetTypeLib](#ccmdtarget__gettypelib)|Gets a pointer to a type library.|  
|[CCmdTarget::GetTypeLibCache](#ccmdtarget__gettypelibcache)|Gets the type library cache.|  
|[CCmdTarget::IsInvokeAllowed](#ccmdtarget__isinvokeallowed)|Enables automation method invocation.|  
|[CCmdTarget::IsResultExpected](#ccmdtarget__isresultexpected)|Returns nonzero if an automation function should return a value.|  
|[CCmdTarget::OnCmdMsg](#ccmdtarget__oncmdmsg)|Routes and dispatches command messages.|  
|[CCmdTarget::OnFinalRelease](#ccmdtarget__onfinalrelease)|Cleans up after the last OLE reference is released.|  
|[CCmdTarget::RestoreWaitCursor](#ccmdtarget__restorewaitcursor)|Restores the hourglass cursor.|  
  
## Remarks  
 A message map routes commands or messages to the member functions you write to handle them. (A command is a message from a menu item, command button, or accelerator key.)  
  
 Key framework classes derived from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> include [CView](../vs140/cview-class.md), [CWinApp](../vs140/cwinapp-class.md), [CDocument](../vs140/cdocument-class.md), [CWnd](../vs140/cwnd-class.md), and [CFrameWnd](../vs140/cframewnd-class.md). If you intend for a new class to handle messages, derive the class from one of these <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>-derived classes. You will rarely derive a class from <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> directly.  
  
 For an overview of command targets and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> routing, see [Command Targets](../vs140/command-targets.md), [Command Routing](../vs140/command-routing.md), and [Mapping Messages](../vs140/mapping-messages.md).  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> includes member functions that handle the display of an hourglass cursor. Display the hourglass cursor when you expect a command to take a noticeable time interval to execute.  
  
 Dispatch maps, similar to message maps, are used to expose OLE automation <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> functionality. By exposing this interface, other applications (such as Visual Basic) can call into your application.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="ccmdtarget__beginwaitcursor">\</a>  CCmdTarget::BeginWaitCursor  
 Call this function to display the cursor as an hourglass when you expect a command to take a noticeable time interval to execute.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this function to show the user that it is busy, such as when a **CDocument** object loads or saves itself to a file.  
  
 The actions of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> are not always effective outside of a single message handler as other actions, such as <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> handling, could change the cursor.  
  
 Call <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to restore the previous cursor.  
  
### Example  
 [!code[NVC_MFCDocView#43](../vs140/codesnippet/CPP/ccmdtarget-class_1.cpp)]  
  
##  \<a name="ccmdtarget__ccmdtarget">\</a>  CCmdTarget::CCmdTarget  
 Constructs a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="ccmdtarget__dooleverb">\</a>  CCmdTarget::DoOleVerb  
 Causes an action specified by an OLE verb to be performed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Numerical identifier of the verb.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Pointer to the                                 [MSG](http://msdn.microsoft.com/library/windows/desktop/ms644958) structure describing the event (such as a double-click) that invoked the verb.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Handle of the document window containing the object.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Pointer to the                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure containing the coordinates, in pixels, that define an object's bounding rectangle in                                 *hwndParent*.  
  
### Return Value  
 TRUE if successful, otherwise FALSE.  
  
### Remarks  
 This member function is basically an implementation of                         [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508). The possible actions are enumerated by [CCmdTarget::EnumOleVerbs](#ccmdtarget__enumoleverbs).  
  
##  \<a name="ccmdtarget__enableautomation">\</a>  CCmdTarget::EnableAutomation  
 Call this function to enable OLE automation for an object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This function is typically called from the constructor of your object and should only be called if a dispatch map has been declared for the class. For more information on automation see the articles [Automation Clients](../vs140/automation-clients.md) and [Automation Servers](../vs140/automation-servers.md).  
  
##  \<a name="ccmdtarget__enableconnections">\</a>  CCmdTarget::EnableConnections  
 Enables event firing over connection points.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 To enable connection points, call this member function in the constructor of your derived class.  
  
##  \<a name="ccmdtarget__enabletypelib">\</a>  CCmdTarget::EnableTypeLib  
 Enables an object's type library.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Call this member function in the constructor of your <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>-derived object if it provides type information. For more information, see Knowledge Base article Q185720, "HOWTO: Provide Type Information From an MFC Automation Server." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at                         [http://support.microsoft.com](http://support.microsoft.com/).  
  
##  \<a name="ccmdtarget__endwaitcursor">\</a>  CCmdTarget::EndWaitCursor  
 Call this function after you have called the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> member function to return from the hourglass cursor to the previous cursor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The framework also calls this member function after it has called the hourglass cursor.  
  
### Example  
 [!code[NVC_MFCDocView#43](../vs140/codesnippet/CPP/ccmdtarget-class_1.cpp)]  
  
##  \<a name="ccmdtarget__enumoleverbs">\</a>  CCmdTarget::EnumOleVerbs  
 Enumerates an object's OLE verbs.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to a pointer to an                                 [IEnumOLEVERB](http://msdn.microsoft.com/library/windows/desktop/ms695084) interface.  
  
### Return Value  
 TRUE if the object supports at least one OLE verb (in which case \* <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> points to an **IEnumOLEVERB** enumerator interface), otherwise FALSE.  
  
### Remarks  
 This member function is basically an implementation of                         [IOleObject::EnumVerbs](http://msdn.microsoft.com/library/windows/desktop/ms692781).  
  
##  \<a name="ccmdtarget__fromidispatch">\</a>  CCmdTarget::FromIDispatch  
 Call this function to map an <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> pointer, received from automation member functions of a class, into the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object that implements the interfaces of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object associated with <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. This function returns **NULL** if the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object is not recognized as a Microsoft Foundation Class <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The result of this function is the inverse of a call to the member function <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
##  \<a name="ccmdtarget__getdispatchiid">\</a>  CCmdTarget::GetDispatchIID  
 Gets the primary dispatch interface ID.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pIID*  
 A pointer to an interface ID (a                                 [GUID](http://msdn.microsoft.com/library/windows/desktop/aa373931)).  
  
### Return Value  
 TRUE if successful, otherwise FALSE. If successful, \*                        *pIID* is set to the primary dispatch interface ID.  
  
### Remarks  
 Derived classes should override this member function (if not overridden, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> returns FALSE). See [COleControl](../vs140/colecontrol-class.md).  
  
 For more information, see Knowledge Base article Q185720, "HOWTO: Provide Type Information From an MFC Automation Server." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at                         [http://support.microsoft.com](http://support.microsoft.com/).  
  
##  \<a name="ccmdtarget__getidispatch">\</a>  CCmdTarget::GetIDispatch  
 Call this member function to retrieve the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> pointer from an automation method that either returns an <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> pointer or takes an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> pointer by reference.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 *bAddRef*  
 Specifies whether to increment the reference count for the object.  
  
### Return Value  
 The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> pointer associated with the object.  
  
### Remarks  
 For objects that call <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> in their constructors, making them automation enabled, this function returns a pointer to the Foundation Class implementation of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> that is used by clients who communicate via the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> interface. Calling this function automatically adds a reference to the pointer, so it is not necessary to make a call to                         [IUnknown::AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379).  
  
##  \<a name="ccmdtarget__gettypeinfocount">\</a>  CCmdTarget::GetTypeInfoCount  
 Retrieves the number of type information interfaces that an object provides.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The number of type information interfaces.  
  
### Remarks  
 This member function basically implements [IDispatch::GetTypeInfoCount](assetId:///da876d53-cb8a-465c-a43e-c0eb272e2a12).  
  
 Derived classes should override this function to return the number of type information interfaces provided (either 0 or 1). If not overridden, **GetTypeInfoCount** returns 0. To override, use the [IMPLEMENT_OLETYPELIB](../vs140/implement_oletypelib.md) macro, which also implements <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
##  \<a name="ccmdtarget__gettypeinfoofguid">\</a>  CCmdTarget::GetTypeInfoOfGuid  
 Retrieves the type description that corresponds to the specified GUID.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A locale identifier ( <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The                                 [GUID](http://msdn.microsoft.com/library/windows/desktop/aa373931) of the type description.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Pointer to a pointer to the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> interface.  
  
### Return Value  
 An HRESULT indicating the success or failure of the call. If successful, * <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> points to the type information interface.  
  
##  \<a name="ccmdtarget__gettypelib">\</a>  CCmdTarget::GetTypeLib  
 Gets a pointer to a type library.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A locale identifier ( <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A pointer to a pointer to the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> interface.  
  
### Return Value  
 An HRESULT indicating the success or failure of the call. If successful, * <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> points to the type library interface.  
  
### Remarks  
 Derived classes should override this member function (if not overridden, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> returns TYPE_E_CANTLOADLIBRARY). Use the [IMPLEMENT_OLETYPELIB](../vs140/implement_oletypelib.md) macro, which also implements <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
##  \<a name="ccmdtarget__gettypelibcache">\</a>  CCmdTarget::GetTypeLibCache  
 Gets the type library cache.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a **CTypeLibCache** object.  
  
### Remarks  
 Derived classes should override this member function (if not overridden, **GetTypeLibCache** returns NULL). Use the [IMPLEMENT_OLETYPELIB](../vs140/implement_oletypelib.md) macro, which also implements <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
##  \<a name="ccmdtarget__isinvokeallowed">\</a>  CCmdTarget::IsInvokeAllowed  
 This function is called by MFC's implementation of                 **IDispatch::Invoke** to determine if a given automation method (identified by <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>) can be invoked.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A dispatch ID.  
  
### Return Value  
 TRUE if the method can be invoked, otherwise FALSE.  
  
### Remarks  
 If <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> returns TRUE, **Invoke** proceeds to call the method; otherwise, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> will fail, returning E_UNEXPECTED.  
  
 Derived classes can override this function to return appropriate values (if not overridden, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> returns TRUE). See in particular [COleControl::IsInvokeAllowed](../vs140/colecontrol-class.md#colecontrol__isinvokeallowed).  
  
##  \<a name="ccmdtarget__isresultexpected">\</a>  CCmdTarget::IsResultExpected  
 Use <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to ascertain whether a client expects a return value from its call to an automation function.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if an automation function should return a value; otherwise 0.  
  
### Remarks  
 The OLE interface supplies information to MFC about whether the client is using or ignoring the result of a function call, and MFC in turn uses this information to determine the result of a call to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. If production of a return value is time- or resource-intensive, you can increase efficiency by calling this function before computing the return value.  
  
 This function returns 0 only once so that you will get valid return values from other automation functions if you call them from the automation function that the client has called.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> returns a nonzero value if called when an automation function call is not in progress.  
  
##  \<a name="ccmdtarget__oncmdmsg">\</a>  CCmdTarget::OnCmdMsg  
 Called by the framework to route and dispatch command messages and to handle the update of command user-interface objects.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Contains the command ID.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Identifies the command notification code. See **Remarks** for more information about values for <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Used according to the value of <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>. See **Remarks** for more information about <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 If not **NULL**, <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> fills in the **pTarget** and **pmf** members of the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> structure instead of dispatching the command. Typically, this parameter should be **NULL**.  
  
### Return Value  
 Nonzero if the message is handled; otherwise 0.  
  
### Remarks  
 This is the main implementation routine of the framework command architecture.  
  
 At run time, <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> dispatches a command to other objects or handles the command itself by calling the root class <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, which does the actual message-map lookup. For a complete description of the default command routing, see [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md).  
  
 On rare occasions, you may want to override this member function to extend the framework's standard command routing. Refer to [Technical Note 21](../vs140/tn021--command-and-message-routing.md) for advanced details of the command-routing architecture.  
  
 If you override <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, you must supply the appropriate value for <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, the command notification code, and <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, which depends on the value of <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>. The following table lists their corresponding values:  
  
|<CodeContentPlaceHolder>105\</CodeContentPlaceHolder> value|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder> value|  
|-------------------|--------------------|  
|CN_COMMAND|[CCmdUI](../vs140/ccmdui-class.md)*|  
|CN_EVENT|AFX_EVENT*|  
|CN_UPDATE_COMMAND_UI|CCmdUI*|  
|CN_OLECOMMAND|[COleCmdUI](../vs140/colecmdui-class.md)*|  
|CN_OLE_UNREGISTER|NULL|  
  
### Example  
 [!code[NVC_MFCDocView#44](../vs140/codesnippet/CPP/ccmdtarget-class_2.cpp)]  
  
 [!code[NVC_MFCDocView#45](../vs140/codesnippet/CPP/ccmdtarget-class_3.cpp)]  
  
##  \<a name="ccmdtarget__onfinalrelease">\</a>  CCmdTarget::OnFinalRelease  
 Called by the framework when the last OLE reference to or from the object is released.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 Override this function to provide special handling for this situation. The default implementation deletes the object.  
  
##  \<a name="ccmdtarget__restorewaitcursor">\</a>  CCmdTarget::RestoreWaitCursor  
 Call this function to restore the appropriate hourglass cursor after the system cursor has changed (for example, after a message box has opened and then closed while in the middle of a lengthy operation).  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFCDocView#43](../vs140/codesnippet/CPP/ccmdtarget-class_1.cpp)]  
  
## See Also  
 [MFC Sample ACDUAL](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdUI](../vs140/ccmdui-class.md)   
 [CDocument](../vs140/cdocument-class.md)   
 [CDocTemplate](../vs140/cdoctemplate-class.md)   
 [CWinApp](../vs140/cwinapp-class.md)   
 [CWnd](../vs140/cwnd-class.md)   
 [CView](../vs140/cview-class.md)   
 [CFrameWnd](../vs140/cframewnd-class.md)   
 [COleDispatchDriver](../vs140/coledispatchdriver-class.md)