---
title: "CDialogImpl Class"
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
  - "CDialogImpl"
  - "ATL.CDialogImpl"
  - "ATL::CDialogImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog boxes, ATL"
  - "CDialogImpl class"
ms.assetid: d430bc7b-8a28-4ad3-9507-277bdd2c2c2e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogImpl Class
This class provides methods for creating a modal or modeless dialog box.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template <  
   class  T,  
   class  TBase  
   = CWindow >  
   class ATL_NO_VTABLE CDialogImpl :  
   public CDialogImplBaseT<  TBase>  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `CDialogImpl`.  
  
 *TBase*  
 The base class of your new class. The default base class is [CWindow](../vs140/cwindow-class.md).  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Create](../vs140/cdialogimpl--create.md)|Creates a modeless dialog box.|  
|[DestroyWindow](../vs140/cdialogimpl--destroywindow.md)|Destroys a modeless dialog box.|  
|[DoModal](../vs140/cdialogimpl--domodal.md)|Creates a modal dialog box.|  
|[EndDialog](../vs140/cdialogimpl--enddialog.md)|Destroys a modal dialog box.|  
  
### CDialogImplBaseT Methods  
  
|||  
|-|-|  
|[GetDialogProc](../vs140/cdialogimpl--getdialogproc.md)|Returns the current dialog box procedure.|  
|[MapDialogRect](../vs140/cdialogimpl--mapdialogrect.md)|Maps the dialog-box units of the specified rectangle to screen units (pixels).|  
|[OnFinalMessage](../vs140/cdialogimpl--onfinalmessage.md)|Called after receiving the last message, typically `WM_NCDESTROY`.|  
  
### Static Functions  
  
|||  
|-|-|  
|[DialogProc](../vs140/cdialogimpl--dialogproc.md)|Processes messages sent to the dialog box.|  
|[StartDialogProc](../vs140/cdialogimpl--startdialogproc.md)|Called when the first message is received to process messages sent to the dialog box.|  
  
## Remarks  
 With `CDialogImpl` you can create a modal or modeless dialog box. `CDialogImpl` provides the dialog box procedure, which uses the default message map to direct messages to the appropriate handlers.  
  
 The base class destructor **~CWindowImplRoot** ensures that the window is gone before destroying the object.  
  
 `CDialogImpl` derives from **CDialogImplBaseT**, which in turn derives from **CWindowImplRoot**.  
  
> [!NOTE]
>  Your class must define an **IDD** member that specifies the dialog template resource ID. For example, the ATL Project Wizard automatically adds the following line to your class:  
  
 [!code[NVC_ATL_Windowing#41](../vs140/codesnippet/CPP/cdialogimpl-class_1.h)]  
  
 where `MyDlg` is the **Short name** entered in the wizard's **Names** page.  
  
|For more information about|See|  
|--------------------------------|---------|  
|Creating controls|[ATL Tutorial](../vs140/active-template-library--atl--tutorial.md)|  
|Using dialog boxes in ATL|[ATL Window Classes](../vs140/atl-window-classes.md)|  
|ATL Project Wizard|[Creating an ATL Project](../vs140/creating-an-atl-project.md)|  
|Dialog boxes|[Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms632588) and subsequent topics in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]|  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="cdialogimpl__create"></a>  CDialogImpl::Create  
 Creates a modeless dialog box.  
  
```  
  
HWND Create(  
      HWND  hWndParent,  
      LPARAM  dwInitParam  
    = NULL   
   );  
   HWND Create(  
      HWND  hWndParent,  
      RECT&,  
      LPARAM  dwInitParam  
    = NULL   
   );  
  
```  
  
### Parameters  
 `hWndParent`  
 [in] The handle to the owner window.  
  
 **RECT&**  `rect`  
 [in] A [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the dialog's size and position.  
  
 `dwInitParam`  
 [in] Specifies the value to pass to the dialog box in the **lParam** parameter of the **WM_INITDIALOG** message.  
  
### Return Value  
 The handle to the newly created dialog box.  
  
### Remarks  
 This dialog box is automatically attached to the `CDialogImpl` object. To create a modal dialog box, call [DoModal](../vs140/cdialogimpl--domodal.md). The second override above is used only with [CComControl](../vs140/ccomcontrol-class.md).  
  
##  \<a name="cdialogimpl__destroywindow"></a>  CDialogImpl::DestroyWindow  
 Destroys a modeless dialog box.  
  
```  
  
BOOL DestroyWindow( );  
  
```  
  
### Return Value  
 **TRUE** if the dialog box was successfully destroyed; otherwise **FALSE**.  
  
### Remarks  
 Returns **TRUE** if the dialog box was successfully destroyed; otherwise **FALSE**.  
  
##  \<a name="cdialogimpl__dialogproc"></a>  CDialogImpl::DialogProc  
 This static function implements the dialog box procedure.  
  
```  
  
static LRESULT CALLBACK DialogProc(  
      HWND  hWnd,  
      UINT  uMsg,  
      WPARAM  wParam,  
      LPARAM  lParam  
   );  
  
```  
  
### Parameters  
 `hWnd`  
 [in] The handle to the dialog box.  
  
 `uMsg`  
 [in] The message sent to the dialog box.  
  
 `wParam`  
 [in] Additional message-specific information.  
  
 `lParam`  
 [in] Additional message-specific information.  
  
### Return Value  
 **TRUE** if the message is processed; otherwise,                         **FALSE**.  
  
### Remarks  
 `DialogProc` uses the default message map to direct messages to the appropriate handlers.  
  
 You can override `DialogProc` to provide a different mechanism for handling messages.  
  
##  \<a name="cdialogimpl__domodal"></a>  CDialogImpl::DoModal  
 Creates a modal dialog box.  
  
```  
  
INT_PTR DoModal(  
      HWND  hWndParent  
    = ::GetActiveWindow( ),   
      LPARAM  dwInitParam  
    = NULL   
   );  
  
```  
  
### Parameters  
 `hWndParent`  
 [in] The handle to the owner window. The default value is the return value of the [GetActiveWindow](http://msdn.microsoft.com/library/windows/desktop/ms646292) Win32 function.  
  
 `dwInitParam`  
 [in] Specifies the value to pass to the dialog box in the **lParam** parameter of the **WM_INITDIALOG** message.  
  
### Return Value  
 If successful, the value of the `nRetCode` parameter specified in the call to [EndDialog](../vs140/cdialogimpl--enddialog.md). Otherwise, -1.  
  
### Remarks  
 This dialog box is automatically attached to the `CDialogImpl` object.  
  
 To create a modeless dialog box, call [Create](../vs140/cdialogimpl--create.md).  
  
##  \<a name="cdialogimpl__enddialog"></a>  CDialogImpl::EndDialog  
 Destroys a modal dialog box.  
  
```  
  
BOOL EndDialog(  
      int  nRetCode  
   );  
  
```  
  
### Parameters  
 `nRetCode`  
 [in] The value to be returned by [CDialogImpl::DoModal](../vs140/cdialogimpl--domodal.md).  
  
### Return Value  
 **TRUE** if the dialog box is destroyed; otherwise,                         **FALSE**.  
  
### Remarks  
 `EndDialog` must be called through the dialog procedure. After the dialog box is destroyed, Windows uses the value of `nRetCode` as the return value for `DoModal`, which created the dialog box.  
  
> [!NOTE]
>  Do not call `EndDialog` to destroy a modeless dialog box. Call [CWindow::DestroyWindow](../vs140/cwindow--destroywindow.md) instead.  
  
##  \<a name="cdialogimpl__getdialogproc"></a>  CDialogImpl::GetDialogProc  
 Returns `DialogProc`, the current dialog box procedure.  
  
```  
  
virtual WNDPROC GetDialogProc( );  
  
```  
  
### Return Value  
 The current dialog box procedure.  
  
### Remarks  
 Override this method to replace the dialog procedure with your own.  
  
##  \<a name="cdialogimpl__mapdialogrect"></a>  CDialogImpl::MapDialogRect  
 Converts (maps) the dialog-box units of the specified rectangle to screen units (pixels).  
  
```  
  
BOOL MapDialogRect(  
      LPRECT  lpRect  
   );  
  
```  
  
### Parameters  
 `lpRect`  
 Points to a `CRect` object or [RECT](../vs140/rect-structure.md) structure that is to receive the client coordinates of the update that encloses the update region.  
  
### Return Value  
 Nonzero if the update succeeds; 0 if the update fails. To get extended error information, call `GetLastError`.  
  
### Remarks  
 The function replaces the coordinates in the specified `RECT` structure with the converted coordinates, which allows the structure to be used to create a dialog box or position a control within a dialog box.  
  
##  \<a name="cdialogimpl__onfinalmessage"></a>  CDialogImpl::OnFinalMessage  
 Called after receiving the last message (typically `WM_NCDESTROY`).  
  
```  
  
virtual void OnFinalMessage(  
      HWND  hWnd  
   );  
  
```  
  
### Parameters  
 `hWnd`  
 [in] A handle to the window being destroyed.  
  
### Remarks  
 Note that if you want to automatically delete your object upon the window destruction, you can call `delete this;` here.  
  
##  \<a name="cdialogimpl__startdialogproc"></a>  CDialogImpl::StartDialogProc  
 Called only once, when the first message is received, to process messages sent to the dialog box.  
  
```  
  
static LRESULT CALLBACK StartDialogProc(  
      HWND  hWnd,  
      UINT  uMsg,  
      WPARAM  wParam,  
      LPARAM  lParam   
   );  
  
```  
  
### Parameters  
 `hWnd`  
 [in] The handle to the dialog box.  
  
 `uMsg`  
 [in] The message sent to the dialog box.  
  
 `wParam`  
 [in] Additional message-specific information.  
  
 `lParam`  
 [in] Additional message-specific information.  
  
### Return Value  
 The window procedure.  
  
### Remarks  
 After the initial call to `StartDialogProc`, `DialogProc` is set as a dialog procedure, and further calls go there.  
  
## See Also  
 [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)   
 [Class Overview](../vs140/atl-class-overview.md)