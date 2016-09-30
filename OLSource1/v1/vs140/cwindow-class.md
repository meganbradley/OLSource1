---
title: "CWindow Class"
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
  - "ATL.CWindow"
  - "ATL::CWindow"
  - "CWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWindow class"
ms.assetid: fefa00c8-f053-4bcf-87bc-dc84f5386683
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow Class
This class provides methods for manipulating a window.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CWindow::CWindow](../vs140/cwindow--cwindow.md)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWindow::ArrangeIconicWindows](../vs140/cwindow--arrangeiconicwindows.md)|Arranges all minimized child windows.|  
|[CWindow::Attach](../vs140/cwindow--attach.md)|Attaches a window to the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> object.|  
|[CWindow::BeginPaint](../vs140/cwindow--beginpaint.md)|Prepares the window for painting.|  
|[CWindow::BringWindowToTop](../vs140/cwindow--bringwindowtotop.md)|Brings the window to the top of the Z order.|  
|[CWindow::CenterWindow](../vs140/cwindow--centerwindow.md)|Centers the window against a given window.|  
|[CWindow::ChangeClipboardChain](../vs140/cwindow--changeclipboardchain.md)|Removes the window from the chain of Clipboard viewers.|  
|[CWindow::CheckDlgButton](../vs140/cwindow--checkdlgbutton.md)|Changes the check state of the specified button.|  
|[CWindow::CheckRadioButton](../vs140/cwindow--checkradiobutton.md)|Checks the specified radio button.|  
|[CWindow::ChildWindowFromPoint](../vs140/cwindow--childwindowfrompoint.md)|Retrieves the child window containing the specified point.|  
|[CWindow::ChildWindowFromPointEx](../vs140/cwindow--childwindowfrompointex.md)|Retrieves a particular type of child window containing the specified point.|  
|[CWindow::ClientToScreen](../vs140/cwindow--clienttoscreen.md)|Converts client coordinates to screen coordinates.|  
|[CWindow::Create](../vs140/cwindow--create.md)|Creates a window.|  
|[CWindow::CreateCaret](../vs140/cwindow--createcaret.md)|Creates a new shape for the system caret.|  
|[CWindow::CreateGrayCaret](../vs140/cwindow--creategraycaret.md)|Creates a gray rectangle for the system caret.|  
|[CWindow::CreateSolidCaret](../vs140/cwindow--createsolidcaret.md)|Creates a solid rectangle for the system caret.|  
|[CWindow::DeferWindowPos](../vs140/cwindow--deferwindowpos.md)|Updates the specified multiple-window-position structure for the specified window.|  
|[CWindow::DestroyWindow](../vs140/cwindow--destroywindow.md)|Destroys the window associated with the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object.|  
|[CWindow::Detach](../vs140/cwindow--detach.md)|Detaches the window from the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object.|  
|[CWindow::DlgDirList](../vs140/cwindow--dlgdirlist.md)|Fills a list box with the names of all files matching a specified path or file name.|  
|[CWindow::DlgDirListComboBox](../vs140/cwindow--dlgdirlistcombobox.md)|Fills a combo box with the names of all files matching a specified path or file name.|  
|[CWindow::DlgDirSelect](../vs140/cwindow--dlgdirselect.md)|Retrieves the current selection from a list box.|  
|[CWindow::DlgDirSelectComboBox](../vs140/cwindow--dlgdirselectcombobox.md)|Retrieves the current selection from a combo box.|  
|[CWindow::DragAcceptFiles](../vs140/cwindow--dragacceptfiles.md)|Registers whether the window accepts dragged files.|  
|[CWindow::DrawMenuBar](../vs140/cwindow--drawmenubar.md)|Redraws the window's menu bar.|  
|[CWindow::EnableScrollBar](../vs140/cwindow--enablescrollbar.md)|Enables or disables the scroll bar arrows.|  
|[CWindow::EnableWindow](../vs140/cwindow--enablewindow.md)|Enables or disables input.|  
|[CWindow::EndPaint](../vs140/cwindow--endpaint.md)|Marks the end of painting.|  
|[CWindow::FlashWindow](../vs140/cwindow--flashwindow.md)|Flashes the window once.|  
|[CWindow::GetClientRect](../vs140/cwindow--getclientrect.md)|Retrieves the coordinates of the client area.|  
|[CWindow::GetDC](../vs140/cwindow--getdc.md)|Retrieves a device context for the client area.|  
|[CWindow::GetDCEx](../vs140/cwindow--getdcex.md)|Retrieves a device context for the client area and allows clipping options.|  
|[CWindow::GetDescendantWindow](../vs140/cwindow--getdescendantwindow.md)|Retrieves the specified descendant window.|  
|[CWindow::GetDlgControl](../vs140/cwindow--getdlgcontrol.md)|Retrieves an interface on the specified control.|  
|[CWindow::GetDlgCtrlID](../vs140/cwindow--getdlgctrlid.md)|Retrieves the window's identifier (for child windows only).|  
|[CWindow::GetDlgHost](../vs140/cwindow--getdlghost.md)|Retrieves a pointer to an interface to the ATL Control hosting container.|  
|[CWindow::GetDlgItem](../vs140/cwindow--getdlgitem.md)|Retrieves the specified child window.|  
|[CWindow::GetDlgItemInt](../vs140/cwindow--getdlgitemint.md)|Translates a control's text to an integer.|  
|[CWindow::GetDlgItemText](../vs140/cwindow--getdlgitemtext.md)|Retrieves a control's text.|  
|[CWindow::GetExStyle](../vs140/cwindow--getexstyle.md)|Retrieves the extended window styles.|  
|[CWindow::GetFont](../vs140/cwindow--getfont.md)|Retrieves the window's current font.|  
|[CWindow::GetHotKey](../vs140/cwindow--gethotkey.md)|Determines the hot key associated with the window.|  
|[CWindow::GetIcon](../vs140/cwindow--geticon.md)|Retrieves the window's large or small icon.|  
|[CWindow::GetLastActivePopup](../vs140/cwindow--getlastactivepopup.md)|Retrieves the most recently active pop-up window.|  
|[CWindow::GetMenu](../vs140/cwindow--getmenu.md)|Retrieves the window's menu.|  
|[CWindow::GetNextDlgGroupItem](../vs140/cwindow--getnextdlggroupitem.md)|Retrieves the previous or next control within a group of controls.|  
|[CWindow::GetNextDlgTabItem](../vs140/cwindow--getnextdlgtabitem.md)|Retrieves the previous or next control having the **WS_TABSTOP** style.|  
|[CWindow::GetParent](../vs140/cwindow--getparent.md)|Retrieves the immediate parent window.|  
|[CWindow::GetScrollInfo](../vs140/cwindow--getscrollinfo.md)|Retrieves the parameters of a scroll bar.|  
|[CWindow::GetScrollPos](../vs140/cwindow--getscrollpos.md)|Retrieves the position of the scroll box.|  
|[CWindow::GetScrollRange](../vs140/cwindow--getscrollrange.md)|Retrieves the scroll bar range.|  
|[CWindow::GetStyle](../vs140/cwindow--getstyle.md)|Retrieves the window styles.|  
|[CWindow::GetSystemMenu](../vs140/cwindow--getsystemmenu.md)|Creates a copy of the system menu for modification.|  
|[CWindow::GetTopLevelParent](../vs140/cwindow--gettoplevelparent.md)|Retrieves the top-level parent or owner window.|  
|[CWindow::GetTopLevelWindow](../vs140/cwindow--gettoplevelwindow.md)|Retrieves the top-level owner window.|  
|[CWindow::GetTopWindow](../vs140/cwindow--gettopwindow.md)|Retrieves the top-level child window.|  
|[CWindow::GetUpdateRect](../vs140/cwindow--getupdaterect.md)|Retrieves the coordinates of the smallest rectangle that completely encloses the update region.|  
|[CWindow::GetUpdateRgn](../vs140/cwindow--getupdatergn.md)|Retrieves the update region and copies it into a specified region.|  
|[CWindow::GetWindow](../vs140/cwindow--getwindow.md)|Retrieves the specified window.|  
|[CWindow::GetWindowContextHelpId](../vs140/cwindow--getwindowcontexthelpid.md)|Retrieves the window's help context identifier.|  
|[CWindow::GetWindowDC](../vs140/cwindow--getwindowdc.md)|Retrieves a device context for the entire window.|  
|[CWindow::GetWindowLong](../vs140/cwindow--getwindowlong.md)|Retrieves a 32-bit value at a specified offset into the extra window memory.|  
|[CWindow::GetWindowLongPtr](../vs140/cwindow--getwindowlongptr.md)|Retrieves information about the specified window, including a value at a specified offset into the extra window memory.|  
|[CWindow::GetWindowPlacement](../vs140/cwindow--getwindowplacement.md)|Retrieves the show state and positions.|  
|[CWindow::GetWindowProcessID](../vs140/cwindow--getwindowprocessid.md)|Retrieves the identifier of the process that created the window.|  
|[CWindow::GetWindowRect](../vs140/cwindow--getwindowrect.md)|Retrieves the window's bounding dimensions.|  
|[CWindow::GetWindowRgn](../vs140/cwindow--getwindowrgn.md)|Obtains a copy of the window region of a window.|  
|[CWindow::GetWindowText](../vs140/cwindow--getwindowtext.md)|Retrieves the window's text.|  
|[CWindow::GetWindowTextLength](../vs140/cwindow--getwindowtextlength.md)|Retrieves the length of the window's text.|  
|[CWindow::GetWindowThreadID](../vs140/cwindow--getwindowthreadid.md)|Retrieves the identifier of the thread that created the specified window.|  
|[CWindow::GetWindowWord](../vs140/cwindow--getwindowword.md)|Retrieves a 16-bit value at a specified offset into the extra window memory.|  
|[CWindow::GotoDlgCtrl](../vs140/cwindow--gotodlgctrl.md)|Sets the keyboard focus to a control in the dialog box.|  
|[CWindow::HideCaret](../vs140/cwindow--hidecaret.md)|Hides the system caret.|  
|[CWindow::HiliteMenuItem](../vs140/cwindow--hilitemenuitem.md)|Highlights or removes the highlight from a top-level menu item.|  
|[CWindow::Invalidate](../vs140/cwindow--invalidate.md)|Invalidates the entire client area.|  
|[CWindow::InvalidateRect](../vs140/cwindow--invalidaterect.md)|Invalidates the client area within the specified rectangle.|  
|[CWindow::InvalidateRgn](../vs140/cwindow--invalidatergn.md)|Invalidates the client area within the specified region.|  
|[CWindow::IsChild](../vs140/cwindow--ischild.md)|Determines whether the specified window is a child window.|  
|[CWindow::IsDialogMessage](../vs140/cwindow--isdialogmessage.md)|Determines whether a message is intended for the specified dialog box.|  
|[CWindow::IsDlgButtonChecked](../vs140/cwindow--isdlgbuttonchecked.md)|Determines the check state of the button.|  
|[CWindow::IsIconic](../vs140/cwindow--isiconic.md)|Determines whether the window is minimized.|  
|[CWindow::IsParentDialog](../vs140/cwindow--isparentdialog.md)|Determines if the parent window of a control is a dialog window.|  
|[CWindow::IsWindow](../vs140/cwindow--iswindow.md)|Determines whether the specified window handle identifies an existing window.|  
|[CWindow::IsWindowEnabled](../vs140/cwindow--iswindowenabled.md)|Determines whether the window is enabled for input.|  
|[CWindow::IsWindowUnicode](../vs140/cwindow--iswindowunicode.md)|Determines whether the specified window is a native Unicode window.|  
|[CWindow::IsWindowVisible](../vs140/cwindow--iswindowvisible.md)|Determines the window's visibility state.|  
|[CWindow::IsZoomed](../vs140/cwindow--iszoomed.md)|Determines whether the window is maximized.|  
|[CWindow::KillTimer](../vs140/cwindow--killtimer.md)|Destroys a timer event.|  
|[CWindow::LockWindowUpdate](../vs140/cwindow--lockwindowupdate.md)|Disables or enables drawing in the window.|  
|[CWindow::MapWindowPoints](../vs140/cwindow--mapwindowpoints.md)|Converts a set of points from the window's coordinate space to the coordinate space of another window.|  
|[CWindow::MessageBox](../vs140/cwindow--messagebox.md)|Displays a message box.|  
|[CWindow::ModifyStyle](../vs140/cwindow--modifystyle.md)|Modifies the window styles.|  
|[CWindow::ModifyStyleEx](../vs140/cwindow--modifystyleex.md)|Modifies the extended window styles.|  
|[CWindow::MoveWindow](../vs140/cwindow--movewindow.md)|Changes the window's size and position.|  
|[CWindow::NextDlgCtrl](../vs140/cwindow--nextdlgctrl.md)|Sets the keyboard focus to the next control in the dialog box.|  
|[CWindow::OpenClipboard](../vs140/cwindow--openclipboard.md)|Opens the Clipboard.|  
|[CWindow::PostMessage](../vs140/cwindow--postmessage.md)|Places a message in the message queue associated with the thread that created the window. Returns without waiting for the thread to process the message.|  
|[CWindow::PrevDlgCtrl](../vs140/cwindow--prevdlgctrl.md)|Sets the keyboard focus to the previous control in the dialog box.|  
|[CWindow::Print](../vs140/cwindow--print.md)|Requests that the window be drawn in a specified device context.|  
|[CWindow::PrintClient](../vs140/cwindow--printclient.md)|Requests that the window's client area be drawn in a specified device context.|  
|[CWindow::RedrawWindow](../vs140/cwindow--redrawwindow.md)|Updates a specified rectangle or region in the client area.|  
|[CWindow::ReleaseDC](../vs140/cwindow--releasedc.md)|Releases a device context.|  
|[CWindow::ResizeClient](../vs140/cwindow--resizeclient.md)|Resizes the window.|  
|[CWindow::ScreenToClient](../vs140/cwindow--screentoclient.md)|Converts screen coordinates to client coordinates.|  
|[CWindow::ScrollWindow](../vs140/cwindow--scrollwindow.md)|Scrolls the specified client area.|  
|[CWindow::ScrollWindowEx](../vs140/cwindow--scrollwindowex.md)|Scrolls the specified client area with additional features.|  
|[CWindow::SendDlgItemMessage](../vs140/cwindow--senddlgitemmessage.md)|Sends a message to a control.|  
|[CWindow::SendMessage](../vs140/cwindow--sendmessage.md)|Sends a message to the window and does not return until the window procedure has processed the message.|  
|[CWindow::SendMessageToDescendants](../vs140/cwindow--sendmessagetodescendants.md)|Sends a message to the specified descendant windows.|  
|[CWindow::SendNotifyMessage](../vs140/cwindow--sendnotifymessage.md)|Sends a message to the window. If the window was created by the calling thread, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> does not return until the window procedure has processed the message. Otherwise, it returns immediately.|  
|[CWindow::SetActiveWindow](../vs140/cwindow--setactivewindow.md)|Activates the window.|  
|[CWindow::SetCapture](../vs140/cwindow--setcapture.md)|Sends all subsequent mouse input to the window.|  
|[CWindow::SetClipboardViewer](../vs140/cwindow--setclipboardviewer.md)|Adds the window to the Clipboard viewer chain.|  
|[CWindow::SetDlgCtrlID](../vs140/cwindow--setdlgctrlid.md)|Changes the window's identifier.|  
|[CWindow::SetDlgItemInt](../vs140/cwindow--setdlgitemint.md)|Changes a control's text to the string representation of an integer value.|  
|[CWindow::SetDlgItemText](../vs140/cwindow--setdlgitemtext.md)|Changes a control's text.|  
|[CWindow::SetFocus](../vs140/cwindow--setfocus.md)|Sets the input focus to the window.|  
|[CWindow::SetFont](../vs140/cwindow--setfont.md)|Changes the window's current font.|  
|[CWindow::SetHotKey](../vs140/cwindow--sethotkey.md)|Associates a hot key with the window.|  
|[CWindow::SetIcon](../vs140/cwindow--seticon.md)|Changes the window's large or small icon.|  
|[CWindow::SetMenu](../vs140/cwindow--setmenu.md)|Changes the window's current menu.|  
|[CWindow::SetParent](../vs140/cwindow--setparent.md)|Changes the parent window.|  
|[CWindow::SetRedraw](../vs140/cwindow--setredraw.md)|Sets or clears the redraw flag.|  
|[CWindow::SetScrollInfo](../vs140/cwindow--setscrollinfo.md)|Sets the parameters of a scroll bar.|  
|[CWindow::SetScrollPos](../vs140/cwindow--setscrollpos.md)|Changes the position of the scroll box.|  
|[CWindow::SetScrollRange](../vs140/cwindow--setscrollrange.md)|Changes the scroll bar range.|  
|[CWindow::SetTimer](../vs140/cwindow--settimer.md)|Creates a timer event.|  
|[CWindow::SetWindowContextHelpId](../vs140/cwindow--setwindowcontexthelpid.md)|Sets the window's help context identifier.|  
|[CWindow::SetWindowLong](../vs140/cwindow--setwindowlong.md)|Sets a 32-bit value at a specified offset into the extra window memory.|  
|[CWindow::SetWindowLongPtr](../vs140/cwindow--setwindowlongptr.md)|Changes an attribute of the specified window, and also sets a value at the specified offset in the extra window memory.|  
|[CWindow::SetWindowPlacement](../vs140/cwindow--setwindowplacement.md)|Sets the show state and positions.|  
|[CWindow::SetWindowPos](../vs140/cwindow--setwindowpos.md)|Sets the size, position, and Z order.|  
|[CWindow::SetWindowRgn](../vs140/cwindow--setwindowrgn.md)|Sets the window region of a window.|  
|[CWindow::SetWindowText](../vs140/cwindow--setwindowtext.md)|Changes the window's text.|  
|[CWindow::SetWindowWord](../vs140/cwindow--setwindowword.md)|Sets a 16-bit value at a specified offset into the extra window memory.|  
|[CWindow::ShowCaret](../vs140/cwindow--showcaret.md)|Displays the system caret.|  
|[CWindow::ShowOwnedPopups](../vs140/cwindow--showownedpopups.md)|Shows or hides the pop-up windows owned by the window.|  
|[CWindow::ShowScrollBar](../vs140/cwindow--showscrollbar.md)|Shows or hides a scroll bar.|  
|[CWindow::ShowWindow](../vs140/cwindow--showwindow.md)|Sets the window's show state.|  
|[CWindow::ShowWindowAsync](../vs140/cwindow--showwindowasync.md)|Sets the show state of a window created by a different thread.|  
|[CWindow::UpdateWindow](../vs140/cwindow--updatewindow.md)|Updates the client area.|  
|[CWindow::ValidateRect](../vs140/cwindow--validaterect.md)|Validates the client area within the specified rectangle.|  
|[CWindow::ValidateRgn](../vs140/cwindow--validatergn.md)|Validates the client area within the specified region.|  
|[CWindow::WinHelp](../vs140/cwindow--winhelp.md)|Starts Windows Help.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CWindow::operator HWND](../vs140/cwindow--operator-hwnd.md)|Converts the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> object to an <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.|  
|[CWindow::operator=](../vs140/cwindow--operator-=.md)|Assigns an <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CWindow::m_hWnd](../vs140/cwindow--m_hwnd.md)|The handle to the window associated with the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object.|  
|[CWindow::rcDefault](../vs140/cwindow--rcdefault.md)|Contains default window dimensions.|  
  
## Remarks  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> provides the base functionality for manipulating a window in ATL. Many of the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> methods simply wrap one of the Win32 API functions. For example, compare the prototypes for <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>:  
  
|CWindow method|Win32 function|  
|--------------------|--------------------|  
|**BOOL ShowWindow( int**  <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> **);**|**BOOL ShowWindow( HWND**  <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> **, int**  <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> **);**|  
  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> calls the Win32 function <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> by passing <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> as the first parameter. Every <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> method that directly wraps a Win32 function passes the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> member; therefore, much of the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> documentation will refer you to the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  Not every window-related Win32 function is wrapped by <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, and not every <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> method wraps a Win32 function.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> stores the <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> that identifies a window. An <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> is attached to your object when you:  
  
-   Specify an <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>'s constructor.  
  
-   Call <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
-   Use <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>'s **operator =**.  
  
-   Create or subclass a window using one of the following classes derived from <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>:  
  
     [CWindowImpl](../vs140/cwindowimpl-class.md) Allows you to create a new window or subclass an existing window.  
  
     [CContainedWindow](../vs140/ccontainedwindowt-class.md) Implements a window contained within another object. You can create a new window or subclass an existing window.  
  
     [CDialogImpl](../vs140/cdialogimpl-class.md) Allows you to create a modal or modeless dialog box.  
  
 For more information about windows, see [Windows](http://msdn.microsoft.com/library/windows/desktop/ms632595) and subsequent topics in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about using windows in ATL, see the article [ATL Window Classes](../vs140/atl-window-classes.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="cwindow__arrangeiconicwindows">\</a>  CWindow::ArrangeIconicWindows  
 Arranges all minimized child windows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 See [ArrangeIconicWindows](http://msdn.microsoft.com/library/windows/desktop/ms632671) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__attach">\</a>  CWindow::Attach  
 Attaches the window identified by <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 [in] The handle to a window.  
  
### Example  
 [!code[NVC_ATL_Windowing#1](../vs140/codesnippet/CPP/cwindow-class_1.cpp)]  
  
##  \<a name="cwindow__beginpaint">\</a>  CWindow::BeginPaint  
 Prepares the window for painting.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 See [BeginPaint](http://msdn.microsoft.com/library/windows/desktop/dd183362) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#2](../vs140/codesnippet/CPP/cwindow-class_2.cpp)]  
  
##  \<a name="cwindow__bringwindowtotop">\</a>  CWindow::BringWindowToTop  
 Brings the window to the top of the Z order.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 See [BringWindowToTop](http://msdn.microsoft.com/library/windows/desktop/ms632673) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#3](../vs140/codesnippet/CPP/cwindow-class_3.cpp)]  
  
##  \<a name="cwindow__centerwindow">\</a>  CWindow::CenterWindow  
 Centers the window against a given window.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 [in] The handle to the window against which to center. If this parameter is **NULL** (the default value), the method will set <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> to the window's parent window if it is a child window. Otherwise, it will set <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> to the window's owner window.  
  
### Return Value  
 **TRUE** if the window is successfully centered; otherwise,                         **FALSE**.  
  
### Example  
 [!code[NVC_ATL_Windowing#4](../vs140/codesnippet/CPP/cwindow-class_4.cpp)]  
  
##  \<a name="cwindow__changeclipboardchain">\</a>  CWindow::ChangeClipboardChain  
 Removes the window from the chain of Clipboard viewers.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 See [ChangeClipboardChain](http://msdn.microsoft.com/library/windows/desktop/ms649034) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__checkdlgbutton">\</a>  CWindow::CheckDlgButton  
 Changes the check state of the specified button.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 See [CheckDlgButton](http://msdn.microsoft.com/library/windows/desktop/bb761875) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__checkradiobutton">\</a>  CWindow::CheckRadioButton  
 Checks the specified radio button.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 See [CheckRadioButton](http://msdn.microsoft.com/library/windows/desktop/bb761877) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__childwindowfrompoint">\</a>  CWindow::ChildWindowFromPoint  
 Retrieves the child window containing the specified point.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 See [ChildWindowFromPoint](http://msdn.microsoft.com/library/windows/desktop/ms632676) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__childwindowfrompointex">\</a>  CWindow::ChildWindowFromPointEx  
 Retrieves a particular type of child window containing the specified point.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 See [ChildWindowFromPointEx](http://msdn.microsoft.com/library/windows/desktop/ms632677) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__clienttoscreen">\</a>  CWindow::ClientToScreen  
 Converts client coordinates to screen coordinates.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 See [ClientToScreen](http://msdn.microsoft.com/library/windows/desktop/dd183434) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The second version of this method allows you to convert the coordinates of a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
##  \<a name="cwindow__create">\</a>  CWindow::Create  
 Creates a window.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 [in] A pointer to the window's class.  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 [in] The handle to the parent or owner window.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 [in] A variable of type [_U_RECT](../vs140/_u_rect-class.md) specifying the position of the window. The default value is **NULL**. When this parameter is **NULL**, the value of <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> is used.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 [in] Specifies the name of the window. The default value is **NULL**.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 [in] The style of the window. The default value is 0, meaning no style is specified. For a list of possible values, see [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 [in] The extended window style. The default value is 0, meaning no extended style is specified. For a list of possible values, see [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 [in] A variable of type [_U_MENUorID](../vs140/_u_menuorid-class.md) specifying a handle to a menu or a window identifier. The default value is 0U.  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 A pointer to the window-creation data contained in a [CREATESTRUCT](http://msdn.microsoft.com/library/windows/desktop/ms632603) structure.  
  
### Return Value  
 If successful, the handle to the newly created window, specified by [m_hWnd](../vs140/cwindow--m_hwnd.md). Otherwise,                         **NULL**.  
  
### Remarks  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> is defined as <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
 See [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 **Note** If 0 is used as the value for the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> parameter, it must be specified as 0U (the default value) to avoid a compiler error.  
  
##  \<a name="cwindow__createcaret">\</a>  CWindow::CreateCaret  
 Creates a new shape for the system caret.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 See [CreateCaret](http://msdn.microsoft.com/library/windows/desktop/ms648399) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__creategraycaret">\</a>  CWindow::CreateGrayCaret  
 Creates a gray rectangle for the system caret.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 See [CreateCaret](http://msdn.microsoft.com/library/windows/desktop/ms648399) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Passes (HBITMAP) 1 for the bitmap handle parameter to the Win32 function.  
  
##  \<a name="cwindow__createsolidcaret">\</a>  CWindow::CreateSolidCaret  
 Creates a solid rectangle for the system caret.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 See [CreateCaret](http://msdn.microsoft.com/library/windows/desktop/ms648399) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Passes (HBITMAP) 0 for the bitmap handle parameter to the Win32 function.  
  
##  \<a name="cwindow__cwindow">\</a>  CWindow::CWindow  
 The constructor.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 [in] The handle to a window.  
  
### Remarks  
 Initializes the [m_hWnd](../vs140/cwindow--m_hwnd.md) member to <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>, which by default is **NULL**.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> does not create a window. Classes [CWindowImpl](../vs140/cwindowimpl-class.md), [CContainedWindow](../vs140/ccontainedwindowt-class.md), and [CDialogImpl](../vs140/cdialogimpl-class.md) (all of which derive from <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>) provide a method to create a window or dialog box, which is then assigned to <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>. You can also use the [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) Win32 function.  
  
##  \<a name="cwindow__deferwindowpos">\</a>  CWindow::DeferWindowPos  
 Updates the specified multiple-window-position structure for the specified window.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 See [DeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632681) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__destroywindow">\</a>  CWindow::DestroyWindow  
 Destroys the window associated with the <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> object and sets [m_hWnd](../vs140/cwindow--m_hwnd.md) to **NULL**.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 See [DestroyWindow](http://msdn.microsoft.com/library/windows/desktop/ms632682) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 It does not destroy the <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> object itself.  
  
### Example  
 [!code[NVC_ATL_Windowing#5](../vs140/codesnippet/CPP/cwindow-class_5.cpp)]  
  
##  \<a name="cwindow__detach">\</a>  CWindow::Detach  
 Detaches [m_hWnd](../vs140/cwindow--m_hwnd.md) from the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> object and sets <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> to **NULL**.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> associated with the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_ATL_Windowing#6](../vs140/codesnippet/CPP/cwindow-class_6.cpp)]  
  
##  \<a name="cwindow__dlgdirlist">\</a>  CWindow::DlgDirList  
 Fills a list box with the names of all files matching a specified path or file name.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 See [DlgDirList](http://msdn.microsoft.com/library/windows/desktop/bb761366) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__dlgdirlistcombobox">\</a>  CWindow::DlgDirListComboBox  
 Fills a combo box with the names of all files matching a specified path or file name.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 See [DlgDirListComboBox](http://msdn.microsoft.com/library/windows/desktop/bb775935) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__dlgdirselect">\</a>  CWindow::DlgDirSelect  
 Retrieves the current selection from a list box.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 See [DlgDirSelectEx](http://msdn.microsoft.com/library/windows/desktop/bb761368) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__dlgdirselectcombobox">\</a>  CWindow::DlgDirSelectComboBox  
 Retrieves the current selection from a combo box.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 See [DlgDirSelectComboBoxEx](http://msdn.microsoft.com/library/windows/desktop/bb775937) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__dragacceptfiles">\</a>  CWindow::DragAcceptFiles  
 Registers whether the window accepts dragged files.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 See [DragAcceptFiles](http://msdn.microsoft.com/library/windows/desktop/bb776406) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__drawmenubar">\</a>  CWindow::DrawMenuBar  
 Redraws the window's menu bar.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 See [DrawMenuBar](http://msdn.microsoft.com/library/windows/desktop/ms647633) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__enablescrollbar">\</a>  CWindow::EnableScrollBar  
 Enables or disables the scroll bar arrows.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Remarks  
 See [EnableScrollBar](http://msdn.microsoft.com/library/windows/desktop/bb787579) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__enablewindow">\</a>  CWindow::EnableWindow  
 Enables or disables input.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 See [EnableWindow](http://msdn.microsoft.com/library/windows/desktop/ms646291) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#7](../vs140/codesnippet/CPP/cwindow-class_7.cpp)]  
  
##  \<a name="cwindow__endpaint">\</a>  CWindow::EndPaint  
 Marks the end of painting.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Remarks  
 See [EndPaint](http://msdn.microsoft.com/library/windows/desktop/dd162598) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#2](../vs140/codesnippet/CPP/cwindow-class_2.cpp)]  
  
##  \<a name="cwindow__flashwindow">\</a>  CWindow::FlashWindow  
 Flashes the window once.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 See [FlashWindow](http://msdn.microsoft.com/library/windows/desktop/ms679346) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getclientrect">\</a>  CWindow::GetClientRect  
 Retrieves the coordinates of the client area.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Remarks  
 See [GetClientRect](http://msdn.microsoft.com/library/windows/desktop/ms633503) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#8](../vs140/codesnippet/CPP/cwindow-class_8.cpp)]  
  
##  \<a name="cwindow__getdc">\</a>  CWindow::GetDC  
 Retrieves a device context for the client area.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 See [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#9](../vs140/codesnippet/CPP/cwindow-class_9.cpp)]  
  
##  \<a name="cwindow__getdcex">\</a>  CWindow::GetDCEx  
 Retrieves a device context for the client area and allows clipping options.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 See [GetDCEx](http://msdn.microsoft.com/library/windows/desktop/dd144873) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getdescendantwindow">\</a>  CWindow::GetDescendantWindow  
 Finds the descendant window specified by the given identifier.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 [in] The identifier of the descendant window to be retrieved.  
  
### Return Value  
 The handle to a descendant window.  
  
### Remarks  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> searches the entire tree of child windows, not only the windows that are immediate children.  
  
##  \<a name="cwindow__getdlgcontrol">\</a>  CWindow::GetDlgControl  
 Call this function to get a pointer to an interface of an ActiveX control that is hosted by a composite control or a control-hosting dialog.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 [in] The resource ID of the control being retrieved.  
  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 [in] The ID of the interface you would like to get from the control.  
  
 *ppCtrl*  
 [out] The pointer to the interface.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> on success or any valid error <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>. For example, the function returns **E_FAIL** if the control specified by <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> cannot be found and it returns **E_NOINTERFACE** if the control can be found, but it doesn't support the interface specified by <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>.  
  
### Remarks  
 Using this pointer, you can call methods on the interface.  
  
##  \<a name="cwindow__getdlgctrlid">\</a>  CWindow::GetDlgCtrlID  
 Retrieves the window's identifier (for child windows only).  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
 See [GetDlgCtrlID](http://msdn.microsoft.com/library/windows/desktop/ms645478) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getdlghost">\</a>  CWindow::GetDlgHost  
 Retrieves a pointer to an interface to the ATL Control hosting container.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 [in] The resource ID of the control being retrieved.  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 [in] The ID of the interface you would like to get from the control.  
  
 *ppHost*  
 [out] The pointer to the interface.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> if the window specified by <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> is a Control Container, and the requested interface could be retrieved. Returns **E_FAIL** if the window is not a Control Container, or if the interface requested could not be retrieved. If a window with the specified ID could not be found, then the return value is equal to HRESULT_FROM_WIN32(ERROR_CONTROL_ID_NOT_FOUND).  
  
### Remarks  
 Using this pointer, you can call methods on the interface.  
  
##  \<a name="cwindow__getdlgitem">\</a>  CWindow::GetDlgItem  
 Retrieves the specified child window.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Remarks  
 See [GetDlgItem](http://msdn.microsoft.com/library/windows/desktop/ms645481) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getdlgitemint">\</a>  CWindow::GetDlgItemInt  
 Translates a control's text to an integer.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Remarks  
 See [GetDlgItemInt](http://msdn.microsoft.com/library/windows/desktop/ms645485) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getdlgitemtext">\</a>  CWindow::GetDlgItemText  
 Retrieves a control's text.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 See [GetDlgItemText](http://msdn.microsoft.com/library/windows/desktop/ms645489) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 The second version of this method allows you to copy the control's text to a <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>. This version returns **TRUE** if the text is successfully copied; otherwise,                         **FALSE**.  
  
##  \<a name="cwindow__getexstyle">\</a>  CWindow::GetExStyle  
 Retrieves the extended window styles of the window.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 The window's extended styles.  
  
### Remarks  
 To retrieve the regular window styles, call [GetStyle](../vs140/cwindow--getstyle.md).  
  
### Example  
 [!code[NVC_ATL_Windowing#10](../vs140/codesnippet/CPP/cwindow-class_10.cpp)]  
  
##  \<a name="cwindow__getfont">\</a>  CWindow::GetFont  
 Retrieves the window's current font by sending a [WM_GETFONT](http://msdn.microsoft.com/library/windows/desktop/ms632624) message to the window.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 A font handle.  
  
##  \<a name="cwindow__gethotkey">\</a>  CWindow::GetHotKey  
 Determines the hot key associated with the window by sending a **WM_GETHOTKEY** message.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 The virtual key code and modifiers for the hot key associated with the window. For a list of possible modifiers, see [WM_GETHOTKEY](http://msdn.microsoft.com/library/windows/desktop/ms646278) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For a list of of standard virtual key codes, see Winuser.h.  
  
##  \<a name="cwindow__geticon">\</a>  CWindow::GetIcon  
 Retrieves the handle to the window's large or small icon.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 [in] If **TRUE** (the default value) the method returns the large icon. Otherwise, it returns the small icon.  
  
### Return Value  
 An icon handle.  
  
### Remarks  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> sends a [WM_GETICON](http://msdn.microsoft.com/library/windows/desktop/ms632625) message to the window.  
  
##  \<a name="cwindow__getlastactivepopup">\</a>  CWindow::GetLastActivePopup  
 Retrieves the most recently active pop-up window.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 See [GetLastActivePopup](http://msdn.microsoft.com/library/windows/desktop/ms633507) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getmenu">\</a>  CWindow::GetMenu  
 Retrieves the window's menu.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 See [GetMenu](http://msdn.microsoft.com/library/windows/desktop/ms647640) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getnextdlggroupitem">\</a>  CWindow::GetNextDlgGroupItem  
 Retrieves the previous or next control within a group of controls.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Remarks  
 See [GetNextDlgGroupItem](http://msdn.microsoft.com/library/windows/desktop/ms645492) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getnextdlgtabitem">\</a>  CWindow::GetNextDlgTabItem  
 Retrieves the previous or next control having the **WS_TABSTOP** style.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 See [GetNextDlgTabItem](http://msdn.microsoft.com/library/windows/desktop/ms645495) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getparent">\</a>  CWindow::GetParent  
 Retrieves the immediate parent window.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 See [GetParent](http://msdn.microsoft.com/library/windows/desktop/ms633510) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#11](../vs140/codesnippet/CPP/cwindow-class_11.cpp)]  
  
##  \<a name="cwindow__getscrollinfo">\</a>  CWindow::GetScrollInfo  
 Retrieves the parameters of a scroll bar.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Remarks  
 See [GetScrollInfo](http://msdn.microsoft.com/library/windows/desktop/bb787583) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getscrollpos">\</a>  CWindow::GetScrollPos  
 Retrieves the position of the scroll box.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 See [GetScrollPos](http://msdn.microsoft.com/library/windows/desktop/bb787585) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getscrollrange">\</a>  CWindow::GetScrollRange  
 Retrieves the scroll bar range.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 See [GetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787587) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getstyle">\</a>  CWindow::GetStyle  
 Retrieves the window styles of the window.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 The window's styles.  
  
### Remarks  
 To retrieve the extended window styles, call [GetExStyle](../vs140/cwindow--getexstyle.md).  
  
### Example  
 [!code[NVC_ATL_Windowing#12](../vs140/codesnippet/CPP/cwindow-class_12.cpp)]  
  
##  \<a name="cwindow__getsystemmenu">\</a>  CWindow::GetSystemMenu  
 Creates a copy of the system menu for modification.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
 See [GetSystemMenu](http://msdn.microsoft.com/library/windows/desktop/ms647985) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__gettoplevelparent">\</a>  CWindow::GetTopLevelParent  
 Retrieves the window's top-level parent window.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 The handle to the top-level parent window.  
  
##  \<a name="cwindow__gettoplevelwindow">\</a>  CWindow::GetTopLevelWindow  
 Retrieves the window's top-level parent or owner window.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 The handle to the top-level owner window.  
  
##  \<a name="cwindow__gettopwindow">\</a>  CWindow::GetTopWindow  
 Retrieves the top-level child window.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 See [GetTopWindow](http://msdn.microsoft.com/library/windows/desktop/ms633514) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#13](../vs140/codesnippet/CPP/cwindow-class_13.cpp)]  
  
##  \<a name="cwindow__getupdaterect">\</a>  CWindow::GetUpdateRect  
 Retrieves the coordinates of the smallest rectangle that completely encloses the update region.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Remarks  
 See [GetUpdateRect](http://msdn.microsoft.com/library/windows/desktop/dd144943) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getupdatergn">\</a>  CWindow::GetUpdateRgn  
 Retrieves the update region and copies it into a specified region.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 See [GetUpdateRgn](http://msdn.microsoft.com/library/windows/desktop/dd144944) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getwindow">\</a>  CWindow::GetWindow  
 Retrieves the specified window.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Remarks  
 See <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getwindowcontexthelpid">\</a>  CWindow::GetWindowContextHelpId  
 Retrieves the window's help context identifier.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowContextHelpId](http://msdn.microsoft.com/library/windows/desktop/bb776429) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getwindowdc">\</a>  CWindow::GetWindowDC  
 Retrieves a device context for the entire window.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowDC](http://msdn.microsoft.com/library/windows/desktop/dd144947) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#14](../vs140/codesnippet/CPP/cwindow-class_14.cpp)]  
  
##  \<a name="cwindow__getwindowlong">\</a>  CWindow::GetWindowLong  
 Retrieves a 32-bit value at a specified offset into the extra window memory.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633584) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  To write code that is compatible with both 32-bit and 64-bit versions of Windows, use [CWindow::GetWindowLongPtr](../vs140/cwindow--getwindowlongptr.md).  
  
##  \<a name="cwindow__getwindowlongptr">\</a>  CWindow::GetWindowLongPtr  
 Retrieves information about the specified window, including a value at a specified offset into the extra window memory.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowLongPtr](http://msdn.microsoft.com/library/windows/desktop/ms633585) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If you are retrieving a pointer or a handle, this function supersedes the <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> method.  
  
> [!NOTE]
>  Pointers and handles are 32 bits on 32-bit Windows and 64 bits on 64-bit Windows.  
  
 To write code that is compatible with both 32-bit and 64-bit versions of Windows, use <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>.  
  
##  \<a name="cwindow__getwindowplacement">\</a>  CWindow::GetWindowPlacement  
 Retrieves the show state and positions.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowPlacement](http://msdn.microsoft.com/library/windows/desktop/ms633518) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getwindowprocessid">\</a>  CWindow::GetWindowProcessID  
 Retrieves the identifier of the process that created the window.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowThreadProcessID](http://msdn.microsoft.com/library/windows/desktop/ms633522) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#15](../vs140/codesnippet/CPP/cwindow-class_15.cpp)]  
  
##  \<a name="cwindow__getwindowrect">\</a>  CWindow::GetWindowRect  
 Retrieves the window's bounding dimensions.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowRect](http://msdn.microsoft.com/library/windows/desktop/ms633519) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getwindowrgn">\</a>  CWindow::GetWindowRgn  
 Obtains a copy of the window region of a window.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowRgn](http://msdn.microsoft.com/library/windows/desktop/dd144950) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getwindowtext">\</a>  CWindow::GetWindowText  
 Retrieves the window's text.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 A buffer to which to write the window text.  
  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 The size of the buffer in characters; also the maximum number of characters to write.  
  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> in which to store the window text.  
  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> in which to store the window text.  
  
### Return Value  
 If the text is successfully copied, the return value is **TRUE**; otherwise, the return value is **FALSE**.  
  
### Remarks  
 See [GetWindowText](http://msdn.microsoft.com/library/windows/desktop/ms633520) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The second version of this method allows you to store the text in a <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>; the third version allows you to store the result in a [CString](../vs140/cstringt-class.md), since <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> is the base class of <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
##  \<a name="cwindow__getwindowtextlength">\</a>  CWindow::GetWindowTextLength  
 Retrieves the length of the window's text.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowTextLength](http://msdn.microsoft.com/library/windows/desktop/ms633521) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__getwindowthreadid">\</a>  CWindow::GetWindowThreadID  
 Retrieves the identifier of the thread that created the specified window.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowThreadProcessID](http://msdn.microsoft.com/library/windows/desktop/ms633522) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#16](../vs140/codesnippet/CPP/cwindow-class_16.cpp)]  
  
##  \<a name="cwindow__getwindowword">\</a>  CWindow::GetWindowWord  
 Retrieves a 16-bit value at a specified offset into the extra window memory.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Remarks  
 See [GetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633584) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__gotodlgctrl">\</a>  CWindow::GotoDlgCtrl  
 Sets the keyboard focus to a control in the dialog box.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Remarks  
 See [WM_NEXTDLGCTL](http://msdn.microsoft.com/library/windows/desktop/ms645432) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__hidecaret">\</a>  CWindow::HideCaret  
 Hides the system caret.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Remarks  
 See [HideCaret](http://msdn.microsoft.com/library/windows/desktop/ms648403) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#17](../vs140/codesnippet/CPP/cwindow-class_17.cpp)]  
  
##  \<a name="cwindow__hilitemenuitem">\</a>  CWindow::HiliteMenuItem  
 Highlights or removes the highlight from a top-level menu item.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Remarks  
 See [HiliteMenuItem](http://msdn.microsoft.com/library/windows/desktop/ms647986) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__invalidate">\</a>  CWindow::Invalidate  
 Invalidates the entire client area.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Remarks  
 See [InvalidateRect](http://msdn.microsoft.com/library/windows/desktop/dd145002) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Passes **NULL** for the <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> parameter to the <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> Win32 function.  
  
### Example  
 [!code[NVC_ATL_Windowing#18](../vs140/codesnippet/CPP/cwindow-class_18.cpp)]  
  
##  \<a name="cwindow__invalidaterect">\</a>  CWindow::InvalidateRect  
 Invalidates the client area within the specified rectangle.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Remarks  
 See [InvalidateRect](http://msdn.microsoft.com/library/windows/desktop/dd145002) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__invalidatergn">\</a>  CWindow::InvalidateRgn  
 Invalidates the client area within the specified region.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Remarks  
 See [InvalidateRgn](http://msdn.microsoft.com/library/windows/desktop/dd145003) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 Specifies a <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> return type, while the <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> Win32 function always returns **TRUE**.  
  
##  \<a name="cwindow__ischild">\</a>  CWindow::IsChild  
 Determines whether the specified window is a child window.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Remarks  
 See [IsChild](http://msdn.microsoft.com/library/windows/desktop/ms633524) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__isdialogmessage">\</a>  CWindow::IsDialogMessage  
 Determines whether a message is intended for the specified dialog box.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Remarks  
 See [IsDialogMessage](http://msdn.microsoft.com/library/windows/desktop/ms645498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__isdlgbuttonchecked">\</a>  CWindow::IsDlgButtonChecked  
 Determines the check state of the button.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Remarks  
 See [IsDlgButtonChecked](http://msdn.microsoft.com/library/windows/desktop/bb761879) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__isiconic">\</a>  CWindow::IsIconic  
 Determines whether the window is minimized.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Remarks  
 See [IsIconic](http://msdn.microsoft.com/library/windows/desktop/ms633527) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#19](../vs140/codesnippet/CPP/cwindow-class_19.cpp)]  
  
##  \<a name="cwindow__isparentdialog">\</a>  CWindow::IsParentDialog  
 Determines if the parent window of the control is a dialog window.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the parent window is a dialog, FALSE otherwise.  
  
##  \<a name="cwindow__iswindow">\</a>  CWindow::IsWindow  
 Determines whether the specified window handle identifies an existing window.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Remarks  
 See [IsWindow](http://msdn.microsoft.com/library/windows/desktop/ms633528) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#20](../vs140/codesnippet/CPP/cwindow-class_20.cpp)]  
  
##  \<a name="cwindow__iswindowenabled">\</a>  CWindow::IsWindowEnabled  
 Determines whether the window is enabled for input.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Remarks  
 See [IsWindowEnabled](http://msdn.microsoft.com/library/windows/desktop/ms646303) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#21](../vs140/codesnippet/CPP/cwindow-class_21.cpp)]  
  
##  \<a name="cwindow__iswindowvisible">\</a>  CWindow::IsWindowVisible  
 Determines the window's visibility state.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Remarks  
 See [IsWindowVisible](http://msdn.microsoft.com/library/windows/desktop/ms633530) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#22](../vs140/codesnippet/CPP/cwindow-class_22.cpp)]  
  
##  \<a name="cwindow__iswindowunicode">\</a>  CWindow::IsWindowUnicode  
 Determines whether the specified window is a native Unicode window.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Remarks  
 See [IsWindowUnicode](http://msdn.microsoft.com/library/windows/desktop/ms633529) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#23](../vs140/codesnippet/CPP/cwindow-class_23.cpp)]  
  
##  \<a name="cwindow__iszoomed">\</a>  CWindow::IsZoomed  
 Determines whether the window is maximized.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Remarks  
 See [IsZoomed](http://msdn.microsoft.com/library/windows/desktop/ms633531) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__killtimer">\</a>  CWindow::KillTimer  
 Destroys a timer event created by <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Remarks  
 See [KillTimer](http://msdn.microsoft.com/library/windows/desktop/ms644903) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__lockwindowupdate">\</a>  CWindow::LockWindowUpdate  
 Disables or enables drawing in the window by calling the [LockWindowUpdate](http://msdn.microsoft.com/library/windows/desktop/dd145034) Win32 function.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 [in] If **TRUE** (the default value), the window will be locked. Otherwise, it will be unlocked.  
  
### Return Value  
 **TRUE** if the window is successfully locked; otherwise,                         **FALSE**.  
  
### Remarks  
 If <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> is **TRUE**, this method passes [m_hWnd](../vs140/cwindow--m_hwnd.md) to the Win32 function; otherwise, it passes **NULL**.  
  
##  \<a name="cwindow__m_hwnd">\</a>  CWindow::m_hWnd  
 Contains a handle to the window associated with the <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
##  \<a name="cwindow__mapwindowpoints">\</a>  CWindow::MapWindowPoints  
 Converts a set of points from the window's coordinate space to the coordinate space of another window.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Remarks  
 See [MapWindowPoints](http://msdn.microsoft.com/library/windows/desktop/dd145046) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The second version of this method allows you to convert the coordinates of a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
##  \<a name="cwindow__messagebox">\</a>  CWindow::MessageBox  
 Displays a message box.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Remarks  
 See [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#24](../vs140/codesnippet/CPP/cwindow-class_24.cpp)]  
  
##  \<a name="cwindow__modifystyle">\</a>  CWindow::ModifyStyle  
 Modifies the window styles of the <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 [in] Specifies the window styles to be removed during style modification.  
  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 [in] Specifies the window styles to be added during style modification.  
  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 [in] Window-positioning flags. For a list of possible values, see the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 **TRUE** if the window styles are modified; otherwise,                         **FALSE**.  
  
### Remarks  
 Styles to be added or removed can be combined by using the bitwise OR ( &#124; ) operator. See the [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for information about the available window styles.  
  
 If <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> calls the Win32 function <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>, and redraws the window by combining <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> with the following four flags:  
  
-   <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> Retains the current size.  
  
-   <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> Retains the current position.  
  
-   <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> Retains the current Z order.  
  
-   <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> Does not activate the window.  
  
 To modify a window's extended styles, call [ModifyStyleEx](../vs140/cwindow--modifystyleex.md).  
  
### Example  
 [!code[NVC_ATL_Windowing#25](../vs140/codesnippet/CPP/cwindow-class_25.cpp)]  
  
##  \<a name="cwindow__modifystyleex">\</a>  CWindow::ModifyStyleEx  
 Modifies the extended window styles of the <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 [in] Specifies the extended styles to be removed during style modification.  
  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 [in] Specifies the extended styles to be added during style modification.  
  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 [in] Window-positioning flags. For a list of possible values, see the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 **TRUE** if the extended window styles are modified; otherwise,                         **FALSE**.  
  
### Remarks  
 Styles to be added or removed can be combined by using the bitwise OR ( &#124; ) operator. See the [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for information about the available extended styles.  
  
 If <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> calls the Win32 function <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>, and redraws the window by combining <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> with the following four flags:  
  
-   <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> Retains the current size.  
  
-   <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> Retains the current position.  
  
-   <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> Retains the current Z order.  
  
-   <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> Does not activate the window.  
  
 To modify windows using regular window styles, call [ModifyStyle](../vs140/cwindow--modifystyle.md).  
  
### Example  
 [!code[NVC_ATL_Windowing#26](../vs140/codesnippet/CPP/cwindow-class_26.cpp)]  
  
##  \<a name="cwindow__movewindow">\</a>  CWindow::MoveWindow  
 Changes the window's size and position.  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
### Remarks  
 For a top-level window object, the x and y parameters are relative to the upper-left corner of the screen. For a child window object, they are relative to the upper-left corner of the parent window's client area.  
  
 The second version of this method uses a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure to determine the window's new position, width, and height.  
  
##  \<a name="cwindow__nextdlgctrl">\</a>  CWindow::NextDlgCtrl  
 Sets the keyboard focus to the next control in the dialog box.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Remarks  
 See [WM_NEXTDLGCTL](http://msdn.microsoft.com/library/windows/desktop/ms645432) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__openclipboard">\</a>  CWindow::OpenClipboard  
 Opens the Clipboard.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Remarks  
 See [OpenClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649048) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__operator_hwnd">\</a>  CWindow::operator HWND  
 Converts a <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> object to an <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
##  \<a name="cwindow__operator__eq">\</a>  CWindow::operator =  
 Assigns an <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> object by setting the [m_hWnd](../vs140/cwindow--m_hwnd.md) member to <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
##  \<a name="cwindow__postmessage">\</a>  CWindow::PostMessage  
 Places a message in the message queue associated with the thread that created the window.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Remarks  
 See [PostMessage](http://msdn.microsoft.com/library/windows/desktop/ms644944) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Returns without waiting for the thread to process the message.  
  
### Example  
 [!code[NVC_ATL_Windowing#27](../vs140/codesnippet/CPP/cwindow-class_27.cpp)]  
  
##  \<a name="cwindow__prevdlgctrl">\</a>  CWindow::PrevDlgCtrl  
 Sets the keyboard focus to the previous control in the dialog box.  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Remarks  
 See [WM_NEXTDLGCTL](http://msdn.microsoft.com/library/windows/desktop/ms645432) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__print">\</a>  CWindow::Print  
 Sends a [WM_PRINT](http://msdn.microsoft.com/library/windows/desktop/dd145216) message to the window to request that it draw itself in the specified device context.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 [in] The handle to a device context.  
  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
 [in] Specifies the drawing options. You can combine one or more of the following flags:  
  
-   <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> Draw the window only if it is visible.  
  
-   <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> Draw all visible child windows.  
  
-   <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> Draw the client area of the window.  
  
-   <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> Erase the background before drawing the window.  
  
-   <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> Draw the non-client area of the window.  
  
-   <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> Draw all owned windows.  
  
##  \<a name="cwindow__printclient">\</a>  CWindow::PrintClient  
 Sends a [WM_PRINTCLIENT](http://msdn.microsoft.com/library/windows/desktop/dd145217) message to the window to request that it draw its client area in the specified device context.  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 [in] The handle to a device context.  
  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 [in] Specifies drawing options. You can combine one or more of the following flags:  
  
-   <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> Draw the window only if it is visible.  
  
-   <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> Draw all visible child windows.  
  
-   <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> Draw the client area of the window.  
  
-   <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> Erase the background before drawing the window.  
  
-   <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> Draw the non-client area of the window.  
  
-   <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> Draw all owned windows.  
  
##  \<a name="cwindow__rcdefault">\</a>  CWindow::rcDefault  
 Contains default window dimensions.  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
##  \<a name="cwindow__redrawwindow">\</a>  CWindow::RedrawWindow  
 Updates a specified rectangle or region in the client area.  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Remarks  
 See [RedrawWindow](http://msdn.microsoft.com/library/windows/desktop/dd162911) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#28](../vs140/codesnippet/CPP/cwindow-class_28.cpp)]  
  
##  \<a name="cwindow__releasedc">\</a>  CWindow::ReleaseDC  
 Releases a device context.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Remarks  
 See [ReleaseDC](http://msdn.microsoft.com/library/windows/desktop/dd162920) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#9](../vs140/codesnippet/CPP/cwindow-class_9.cpp)]  
  
##  \<a name="cwindow__resizeclient">\</a>  CWindow::ResizeClient  
 Resizes the window to the specified client area size.  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 New width of the window in pixels.  
  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 New height of the window in pixels.  
  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 A flag indicating whether to redraw changes. Default is **FALSE**, indicating the window does not redraw changes.  
  
##  \<a name="cwindow__screentoclient">\</a>  CWindow::ScreenToClient  
 Converts screen coordinates to client coordinates.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Remarks  
 See [ScreenToClient](http://msdn.microsoft.com/library/windows/desktop/dd162952) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The second version of this method allows you to convert the coordinates of a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
##  \<a name="cwindow__scrollwindow">\</a>  CWindow::ScrollWindow  
 Scrolls the specified client area.  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
### Remarks  
 See [ScrollWindow](http://msdn.microsoft.com/library/windows/desktop/bb787591) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__scrollwindowex">\</a>  CWindow::ScrollWindowEx  
 Scrolls the specified client area with additional features.  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Remarks  
 See [ScrollWindowEx](http://msdn.microsoft.com/library/windows/desktop/bb787593) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__senddlgitemmessage">\</a>  CWindow::SendDlgItemMessage  
 Sends a message to a control.  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
### Remarks  
 See [SendDlgItemMessage](http://msdn.microsoft.com/library/windows/desktop/ms645515) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__sendmessage">\</a>  CWindow::SendMessage  
 Sends a message to the window and does not return until the window procedure has processed the message.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Remarks  
 See [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#29](../vs140/codesnippet/CPP/cwindow-class_29.cpp)]  
  
##  \<a name="cwindow__sendmessagetodescendants">\</a>  CWindow::SendMessageToDescendants  
 Sends the specified message to all immediate children of the <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 [in] The message to be sent.  
  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 [in] If **TRUE** (the default value), the message will be sent to all descendant windows; otherwise, it will be sent only to the immediate child windows.  
  
### Remarks  
 If <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> is **TRUE**, the message is additionally sent to all other descendant windows.  
  
##  \<a name="cwindow__sendnotifymessage">\</a>  CWindow::SendNotifyMessage  
 Sends a message to the window.  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Remarks  
 See [SendNotifyMessage](http://msdn.microsoft.com/library/windows/desktop/ms644953) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If the window was created by the calling thread, <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> does not return until the window procedure has processed the message. Otherwise, it returns immediately.  
  
##  \<a name="cwindow__setactivewindow">\</a>  CWindow::SetActiveWindow  
 Activates the window.  
  
<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
### Remarks  
 See [SetActiveWindow](http://msdn.microsoft.com/library/windows/desktop/ms646311) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#30](../vs140/codesnippet/CPP/cwindow-class_30.cpp)]  
  
##  \<a name="cwindow__setcapture">\</a>  CWindow::SetCapture  
 Sends all subsequent mouse input to the window.  
  
<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
### Remarks  
 See [SetCapture](http://msdn.microsoft.com/library/windows/desktop/ms646262) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setclipboardviewer">\</a>  CWindow::SetClipboardViewer  
 Adds the window to the Clipboard viewer chain.  
  
<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
### Remarks  
 See [SetClipboardViewer](http://msdn.microsoft.com/library/windows/desktop/ms649052) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setdlgctrlid">\</a>  CWindow::SetDlgCtrlID  
 Sets the identifier of the window to the specified value.  
  
<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 [in] The new value to set for the window's identifier.  
  
### Return Value  
 If successful, the previous identifier of the window; otherwise 0.  
  
##  \<a name="cwindow__setdlgitemint">\</a>  CWindow::SetDlgItemInt  
 Changes a control's text to the string representation of an integer value.  
  
<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
### Remarks  
 See [SetDlgItemInt](http://msdn.microsoft.com/library/windows/desktop/ms645518) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setdlgitemtext">\</a>  CWindow::SetDlgItemText  
 Changes a control's text.  
  
<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
### Remarks  
 See [SetDlgItemText](http://msdn.microsoft.com/library/windows/desktop/ms645521) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setfocus">\</a>  CWindow::SetFocus  
 Sets the input focus to the window.  
  
<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
### Remarks  
 See [SetFocus](http://msdn.microsoft.com/library/windows/desktop/ms646312) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#31](../vs140/codesnippet/CPP/cwindow-class_31.cpp)]  
  
##  \<a name="cwindow__setfont">\</a>  CWindow::SetFont  
 Changes the window's current font by sending a [WM_SETFONT](http://msdn.microsoft.com/library/windows/desktop/ms632642) message to the window.  
  
<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 [in] The handle to the new font.  
  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 [in] If **TRUE** (the default value), the window is redrawn. Otherwise, it is not.  
  
##  \<a name="cwindow__sethotkey">\</a>  CWindow::SetHotKey  
 Associates a hot key with the window by sending a **WM_SETHOTKEY** message.  
  
<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 [in] The virtual key code of the hot key. For a list of of standard virtual key codes, see Winuser.h.  
  
 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 [in] The modifiers of the hot key. For a list of possible values, see **WM_SETHOTKEY** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 For a list of possible return values, see [WM_SETHOTKEY](http://msdn.microsoft.com/library/windows/desktop/ms646284) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__seticon">\</a>  CWindow::SetIcon  
 Sets the window's large or small icon to the icon identified by <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 [in] The handle to a new icon.  
  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 [in] If **TRUE** (the default value), the method sets a large icon. Otherwise, it sets a small icon.  
  
### Return Value  
 The handle to the previous icon.  
  
### Remarks  
 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> sends a [WM_SETICON](http://msdn.microsoft.com/library/windows/desktop/ms632643) message to the window.  
  
##  \<a name="cwindow__setmenu">\</a>  CWindow::SetMenu  
 Changes the window's current menu.  
  
<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
### Remarks  
 See [SetMenu](http://msdn.microsoft.com/library/windows/desktop/ms647995) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setparent">\</a>  CWindow::SetParent  
 Changes the parent window.  
  
<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
### Remarks  
 See [SetParent](http://msdn.microsoft.com/library/windows/desktop/ms633541) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#32](../vs140/codesnippet/CPP/cwindow-class_32.cpp)]  
  
##  \<a name="cwindow__setredraw">\</a>  CWindow::SetRedraw  
 Sets or clears the redraw flag by sending a [WM_SETREDRAW](http://msdn.microsoft.com/library/windows/desktop/dd145219) message to the window.  
  
<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 [in] Specifies the state of the redraw flag. If **TRUE** (the default value), the redraw flag is set; if **FALSE**, the flag is cleared.  
  
### Remarks  
 Call <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> to allow changes to be redrawn or to prevent changes from being redrawn.  
  
### Example  
 [!code[NVC_ATL_Windowing#33](../vs140/codesnippet/CPP/cwindow-class_33.cpp)]  
  
##  \<a name="cwindow__setscrollinfo">\</a>  CWindow::SetScrollInfo  
 Sets the parameters of a scroll bar.  
  
<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
### Remarks  
 See [SetScrollInfo](http://msdn.microsoft.com/library/windows/desktop/bb787595) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setscrollpos">\</a>  CWindow::SetScrollPos  
 Changes the position of the scroll box.  
  
<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
### Remarks  
 See [SetScrollPos](http://msdn.microsoft.com/library/windows/desktop/bb787597) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setscrollrange">\</a>  CWindow::SetScrollRange  
 Changes the scroll bar range.  
  
<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
### Remarks  
 See [SetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787599) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__settimer">\</a>  CWindow::SetTimer  
 Creates a timer event.  
  
<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
### Remarks  
 See [SetTimer](http://msdn.microsoft.com/library/windows/desktop/ms644906) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setwindowcontexthelpid">\</a>  CWindow::SetWindowContextHelpId  
 Sets the window's help context identifier.  
  
<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowContextHelpId](http://msdn.microsoft.com/library/windows/desktop/bb762101) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setwindowlong">\</a>  CWindow::SetWindowLong  
 Sets a 32-bit value at a specified offset into the extra window memory.  
  
<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633591) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  To write code that is compatible with both 32-bit and 64-bit versions of Windows, use [CWindow::SetWindowLongPtr](../vs140/cwindow--setwindowlongptr.md).  
  
##  \<a name="cwindow__setwindowlongptr">\</a>  CWindow::SetWindowLongPtr  
 Changes an attribute of the specified window, and also sets a value at the specified offset in the extra window memory.  
  
<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowLongPtr](http://msdn.microsoft.com/library/windows/desktop/ms644898) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 This function supersedes the <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> method. To write code that is compatible with both 32-bit and 64-bit versions of Windows, use <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>.  
  
##  \<a name="cwindow__setwindowplacement">\</a>  CWindow::SetWindowPlacement  
 Sets the show state and positions.  
  
<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowPlacement](http://msdn.microsoft.com/library/windows/desktop/ms633544) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setwindowpos">\</a>  CWindow::SetWindowPos  
 Sets the size, position, and Z order.  
  
<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The second version of this method uses a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure to set the window's new position, width, and height.  
  
##  \<a name="cwindow__setwindowrgn">\</a>  CWindow::SetWindowRgn  
 Sets the window region of a window.  
  
<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowRgn](http://msdn.microsoft.com/library/windows/desktop/dd145102) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__setwindowtext">\</a>  CWindow::SetWindowText  
 Changes the window's text.  
  
<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowText](http://msdn.microsoft.com/library/windows/desktop/ms633546) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#34](../vs140/codesnippet/CPP/cwindow-class_34.cpp)]  
  
##  \<a name="cwindow__setwindowword">\</a>  CWindow::SetWindowWord  
 Sets a 16-bit value at a specified offset into the extra window memory.  
  
<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
### Remarks  
 See [SetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633591) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__showcaret">\</a>  CWindow::ShowCaret  
 Displays the system caret.  
  
<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
### Remarks  
 See [ShowCaret](http://msdn.microsoft.com/library/windows/desktop/ms648406) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#35](../vs140/codesnippet/CPP/cwindow-class_35.cpp)]  
  
##  \<a name="cwindow__showownedpopups">\</a>  CWindow::ShowOwnedPopups  
 Shows or hides the pop-up windows owned by the window.  
  
<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
### Remarks  
 See [ShowOwnedPopups](http://msdn.microsoft.com/library/windows/desktop/ms633547) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__showscrollbar">\</a>  CWindow::ShowScrollBar  
 Shows or hides a scroll bar.  
  
<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
### Remarks  
 See [ShowScrollBar](http://msdn.microsoft.com/library/windows/desktop/bb787601) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__showwindow">\</a>  CWindow::ShowWindow  
 Sets the window's show state.  
  
<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
### Remarks  
 See [ShowWindow](http://msdn.microsoft.com/library/windows/desktop/ms633548) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#36](../vs140/codesnippet/CPP/cwindow-class_36.cpp)]  
  
##  \<a name="cwindow__showwindowasync">\</a>  CWindow::ShowWindowAsync  
 Sets the show state of a window created by a different thread.  
  
<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
### Remarks  
 See [ShowWindowAsync](http://msdn.microsoft.com/library/windows/desktop/ms633549) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__updatewindow">\</a>  CWindow::UpdateWindow  
 Updates the client area.  
  
<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
### Remarks  
 See [UpdateWindow](http://msdn.microsoft.com/library/windows/desktop/dd145167) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_ATL_Windowing#37](../vs140/codesnippet/CPP/cwindow-class_37.cpp)]  
  
##  \<a name="cwindow__validaterect">\</a>  CWindow::ValidateRect  
 Validates the client area within the specified rectangle.  
  
<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
### Remarks  
 See [ValidateRect](http://msdn.microsoft.com/library/windows/desktop/dd145194) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__validatergn">\</a>  CWindow::ValidateRgn  
 Validates the client area within the specified region.  
  
<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
### Remarks  
 See [ValidateRgn](http://msdn.microsoft.com/library/windows/desktop/dd145195) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwindow__winhelp">\</a>  CWindow::WinHelp  
 Starts Windows Help.  
  
<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
### Remarks  
 See [WinHelp](http://msdn.microsoft.com/library/windows/desktop/bb762267) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)