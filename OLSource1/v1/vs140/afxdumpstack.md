---
title: "AfxDumpStack"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AfxDumpStack
  - AFX_DUMP_STACK_TARGET_ODS
  - AFX_DUMP_STACK_TARGET_DEFAULT
  - AFX_DUMP_STACK_TARGET_CLIPBOARD
  - AFX_DUMP_STACK_TARGET_TRACE
  - AFX/AfxDumpStack
  - AFX_DUMP_STACK_TARGET_BOTH
dev_langs: 
  - C++
helpviewer_keywords: 
  - AFX_DUMP_STACK_TARGET_DEFAULT constant
  - AfxDumpStack function
  - AFX_DUMP_STACK_TARGET_ODS constant
  - stack dumping
  - AFX_DUMP_STACK_TARGET_TRACE constant
  - stack, dumping
  - AFX_DUMP_STACK_TARGET_BOTH constant
  - AFX_DUMP_STACK_TARGET_CLIPBOARD constant
ms.assetid: e7bb9ba4-31cc-4bf6-8e10-7c7c93e9c330
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxDumpStack
This global function can be used to generate an image of the current stack.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxDumpStack(  
   DWORD dwTarget = AFX_STACK_DUMP_TARGET_DEFAULT  
);  
```  
  
#### Parameters  
 *dwTarget*  
 Indicates the target of the dump output. Possible values, which can be combined using the bitwise-OR (**&#124;**) operator, are as follows:  
  
-   **AFX_STACK_DUMP_TARGET_TRACE** Sends output by means of the [TRACE](../vs140/trace.md) macro. The **TRACE** macro generates output in debug builds only; it generates no output in release builds. Also, **TRACE** can be redirected to other targets besides the debugger.  
  
-   **AFX_STACK_DUMP_TARGET_DEFAULT** Sends dump output to the default target. For a debug build, output goes to the **TRACE** macro. In a release build, output goes to the Clipboard.  
  
-   **AFX_STACK_DUMP_TARGET_CLIPBOARD** Sends output to the Clipboard only. The data is placed on the Clipboard as plain text using the **CF_TEXT** Clipboard format.  
  
-   **AFX_STACK_DUMP_TARGET_BOTH** Sends output to the Clipboard and to the **TRACE** macro, simultaneously.  
  
-   **AFX_STACK_DUMP_TARGET_ODS** Sends output directly to the debugger by means of the Win32 function **OutputDebugString()**. This option will generate debugger output in both debug and release builds when a debugger is attached to the process. **AFX_STACK_DUMP_TARGET_ODS** always reaches the debugger (if it is attached) and cannot be redirected.  
  
## Remarks  
 The example below reflects a single line of the output generated from calling `AfxDumpStack` from a button handler in an MFC dialog application:  
  
 `=== begin AfxDumpStack output ===`  
  
 `00427D55: DUMP2\DEBUG\DUMP2.EXE! void AfxDumpStack(unsigned long) + 181 bytes`  
  
 `0040160B: DUMP2\DEBUG\DUMP2.EXE! void CDump2Dlg::OnClipboard(void) + 14 bytes`  
  
 `0044F884: DUMP2\DEBUG\DUMP2.EXE! int _AfxDispatchCmdMsg(class CCmdTarget *,`  
  
 `unsigned int,int,void ( CCmdTarget::*)(void),void *,unsigned int,struct AFX_CMDHANDLE`  
  
 `0044FF7B: DUMP2\DEBUG\DUMP2.EXE! virtual int CCmdTarget::OnCmdMsg(unsigned`  
  
 `int,int,void *,struct AFX_CMDHANDLERINFO *) + 626 bytes`  
  
 `00450C71: DUMP2\DEBUG\DUMP2.EXE! virtual int CDialog::OnCmdMsg(unsigned`  
  
 `int,int,void *,struct AFX_CMDHANDLERINFO *) + 36 bytes`  
  
 `00455B27: DUMP2\DEBUG\DUMP2.EXE! virtual int CWnd::OnCommand(unsigned`  
  
 `int,long) + 312 bytes`  
  
 `00454D3D: DUMP2\DEBUG\DUMP2.EXE! virtual int CWnd::OnWndMsg(unsigned`  
  
 `int,unsigned int,long,long *) + 83 bytes`  
  
 `00454CC0: DUMP2\DEBUG\DUMP2.EXE! virtual long CWnd::WindowProc(unsigned`  
  
 `int,unsigned int,long) + 46 bytes`  
  
 `004528D9: DUMP2\DEBUG\DUMP2.EXE! long AfxCallWndProc(class CWnd *,struct`  
  
 `HWND__ *,unsigned int,unsigned int,long) + 237 bytes`  
  
 `00452D34: DUMP2\DEBUG\DUMP2.EXE! long AfxWndProc(struct HWND__ *,unsigned`  
  
 `int,unsigned int,long) + 129 bytes`  
  
 `BFF73663: WINDOWS\SYSTEM\KERNEL32.DLL! ThunkConnect32 + 2148 bytes`  
  
 `BFF928E0: WINDOWS\SYSTEM\KERNEL32.DLL! UTUnRegister + 2492 bytes`  
  
 `=== end AfxDumpStack() output ===`  
  
 Each line in the output above indicates the address of the last function call, the full path name of the module that contains the function call, and the function prototype called. If the function call on the stack does not happen at the exact address of the function, an offset of bytes is shown.  
  
 For example, the following table describes the first line of the above output:  
  
|Output|Description|  
|------------|-----------------|  
|`00427D55:`|The return address of the last function call.|  
|`DUMP2\DEBUG\DUMP2.EXE!`|The full path name of the module that contains the function call.|  
|`void AfxDumpStack(unsigned long)`|The function prototype called.|  
|`+ 181 bytes`|The offset in bytes from the address of the function prototype (in this case, `void AfxDumpStack(unsigned long)`) to the return address (in this case, `00427D55`).|  
  
 `AfxDumpStack` is available in debug and nondebug versions of the MFC libraries; however, the function is always linked statically, even when your executable file uses MFC in a shared DLL. In shared-library implementations, the function is found in the MFCS42.LIB library (and its variants).  
  
 To use this function successfully:  
  
-   The file IMAGEHLP.DLL must be on your path. If you do not have this DLL, the function will display an error message. See [Image Help Library](http://msdn.microsoft.com/library/windows/desktop/ms680321) for information on the function set provided by IMAGEHLP.  
  
-   The modules that have frames on the stack must include debugging information. If they do not contain debugging information, the function will still generate a stack trace, but the trace will be less detailed.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [afxDump](../vs140/afxdump--cdumpcontext-in-mfc-.md)