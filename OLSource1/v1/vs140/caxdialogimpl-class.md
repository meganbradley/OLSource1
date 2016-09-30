---
title: "CAxDialogImpl Class"
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
  - "ATL::CAxDialogImpl"
  - "ATL.CAxDialogImpl"
  - "CAxDialogImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAxDialogImpl class"
  - "ATL, dialog boxes"
ms.assetid: 817df483-3fa8-44e7-8487-72ba0881cd27
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxDialogImpl Class
This class implements a dialog box (modal or modeless) that hosts ActiveX controls.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 *TBase*  
 The base window class for **CDialogImplBaseT**.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAxDialogImpl::AdviseSinkMap](../vs140/caxdialogimpl--advisesinkmap.md)|Call this method to advise or unadvise all entries in the object's sink map event map.|  
|[CAxDialogImpl::Create](../vs140/caxdialogimpl--create.md)|Call this method to create a modeless dialog box.|  
|[CAxDialogImpl::DestroyWindow](../vs140/caxdialogimpl--destroywindow.md)|Call this method to destroy a modeless dialog box.|  
|[CAxDialogImpl::DoModal](../vs140/caxdialogimpl--domodal.md)|Call this method to create a modal dialog box.|  
|[CAxDialogImpl::EndDialog](../vs140/caxdialogimpl--enddialog.md)|Call this method to destroy a modal dialog box.|  
|[CAxDialogImpl::GetDialogProc](../vs140/caxdialogimpl--getdialogproc.md)|Call this method to get a pointer to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> callback function.|  
|[CAxDialogImpl::GetIDD](../vs140/caxdialogimpl--getidd.md)|Call this method to get the dialog template resource ID|  
|[CAxDialogImpl::IsDialogMessage](../vs140/caxdialogimpl--isdialogmessage.md)|Call this method to determine whether a message is intended for this dialog box and, if it is, process the message.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAxDialogImpl::m_bModal](../vs140/caxdialogimpl--m_bmodal.md)|A variable that exists only in debug builds and is set to true if the dialog box is modal.|  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> allows you to create a modal or modeless dialog box. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> provides the dialog box procedure, which uses the default message map to direct messages to the appropriate handlers.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> derives from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which in turn derives from *TBase* (by default, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Your class must define an IDD member that specifies the dialog template resource ID. For example, adding an ATL Dialog object using the **Add Class** dialog box automatically adds the following line to your class:  
  
 [!code[NVC_ATL_Windowing#41](../vs140/codesnippet/CPP/caxdialogimpl-class_1.h)]  
  
 where <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is the **Short name** entered in the ATL Dialog Wizard.  
  
 See [Implementing a Dialog Box](../vs140/implementing-a-dialog-box.md) for more information.  
  
 Note that an ActiveX control on a modal dialog box created with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> will not support accelerator keys. To support accelerator keys on a dialog box created with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, create a modeless dialog box and, using your own message loop, use [CAxDialogImpl::IsDialogMessage](../vs140/caxdialogimpl--isdialogmessage.md) after getting a message from the queue to handle an accelerator key.  
  
 For more information on <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, see [ATL Control Containment FAQ](../vs140/atl-control-containment-faq.md).  
  
## Inheritance Hierarchy  
 [CMessageMap](../vs140/cmessagemap-class.md)  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="caxdialogimpl__advisesinkmap">\</a>  CAxDialogImpl::AdviseSinkMap  
 Call this method to advise or unadvise all entries in the object's sink map event map.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Set to true if all sink entries are to be advised; false if all sink entries are to be unadvised.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="caxdialogimpl__create">\</a>  CAxDialogImpl::Create  
 Call this method to create a modeless dialog box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [in] The handle to the owner window.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 [in] Specifies the value to pass to the dialog box in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter of the **WM_INITDIALOG** message.  
  
 **RECT&**  
 This parameter is not used. This parameter is passed in by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Return Value  
 The handle to the newly created dialog box.  
  
### Remarks  
 This dialog box is automatically attached to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object. To create a modal dialog box, call [DoModal](../vs140/caxdialogimpl--domodal.md).  
  
 The second override is provided only so dialog boxes can be used with [CComControl](../vs140/ccomcontrol-class.md).  
  
##  \<a name="caxdialogimpl__destroywindow">\</a>  CAxDialogImpl::DestroyWindow  
 Call this method to destroy a modeless dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if the window is successfully destroyed; otherwise FALSE.  
  
### Remarks  
 Do not call <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to destroy a modal dialog box. Call [EndDialog](../vs140/caxdialogimpl--enddialog.md) instead.  
  
##  \<a name="caxdialogimpl__domodal">\</a>  CAxDialogImpl::DoModal  
 Call this method to create a modal dialog box.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 [in] The handle to the owner window. The default value is the return value of the [GetActiveWindow](http://msdn.microsoft.com/library/windows/desktop/ms646292) Win32 function.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 [in] Specifies the value to pass to the dialog box in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter of the **WM_INITDIALOG** message.  
  
### Return Value  
 If successful, the value of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> parameter specified in the call to [EndDialog](../vs140/caxdialogimpl--enddialog.md); otherwise, -1.  
  
### Remarks  
 This dialog box is automatically attached to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
 To create a modeless dialog box, call [Create](../vs140/caxdialogimpl--create.md).  
  
##  \<a name="caxdialogimpl__enddialog">\</a>  CAxDialogImpl::EndDialog  
 Call this method to destroy a modal dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 [in] The value to be returned by [DoModal](../vs140/caxdialogimpl--domodal.md).  
  
### Return Value  
 TRUE if the dialog box is destroyed; otherwise, FALSE.  
  
### Remarks  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> must be called through the dialog box procedure. After the dialog box is destroyed, Windows uses the value of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> as the return value for <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, which created the dialog box.  
  
> [!NOTE]
>  Do not call <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to destroy a modeless dialog box. Call [DestroyWindow](../vs140/caxdialogimpl--destroywindow.md) instead.  
  
##  \<a name="caxdialogimpl__getdialogproc">\</a>  CAxDialogImpl::GetDialogProc  
 Call this method to get a pointer to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> callback function.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> callback function.  
  
### Remarks  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> function is an application-defined callback function.  
  
##  \<a name="caxdialogimpl__getidd">\</a>  CAxDialogImpl::GetIDD  
 Call this method to get the dialog template resource ID.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns the dialog template resource ID.  
  
##  \<a name="caxdialogimpl__isdialogmessage">\</a>  CAxDialogImpl::IsDialogMessage  
 Call this method to determine whether a message is intended for this dialog box and, if it is, process the message.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Pointer to a [MSG](http://msdn.microsoft.com/library/windows/desktop/ms644958) structure that contains the message to be checked.  
  
### Return Value  
 Returns TRUE if the message has been processed, FALSE otherwise.  
  
### Remarks  
 This method is intended to be called from within a message loop.  
  
##  \<a name="caxdialogimpl__m_bmodal">\</a>  CAxDialogImpl::m_bModal  
 A variable that exists only in debug builds and is set to true if the dialog box is modal.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [CDialogImpl Class](../vs140/cdialogimpl-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)