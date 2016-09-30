---
title: "CEdit::SetHandle"
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
  - "CEdit::SetHandle"
  - "SetHandle"
  - "CEdit.SetHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHandle method"
  - "CEdit class, multiple-line operations"
ms.assetid: d77ab538-b233-4386-a07e-2913e5fb0e05
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::SetHandle
Call this function to set the handle to the local memory that will be used by a multiple-line edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hBuffer*  
 Contains a handle to the local memory. This handle must have been created by a previous call to the [LocalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366723) Windows function using the **LMEM_MOVEABLE** flag. The memory is assumed to contain a null-terminated string. If this is not the case, the first byte of the allocated memory should be set to 0.  
  
## Remarks  
 The edit control will then use this buffer to store the currently displayed text instead of allocating its own buffer.  
  
 This member function is processed only by multiple-line edit controls.  
  
 Before an application sets a new memory handle, it should use the [GetHandle](../vs140/cedit--gethandle.md) member function to get the handle to the current memory buffer and free that memory using the **LocalFree** Windows function.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clears the undo buffer (the [CanUndo](../vs140/cedit--canundo.md) member function then returns 0) and the internal modification flag (the [GetModify](../vs140/cedit--getmodify.md) member function then returns 0). The edit-control window is redrawn.  
  
 You can use this member function in a multiple-line edit control in a dialog box only if you have created the dialog box with the **DS_LOCALEDIT** style flag set.  
  
> [!NOTE]
>  **GetHandle** will not work with Windows 95/98. If you call **GetHandle** in Windows 95/98, it will return **NULL**. **GetHandle** will work as documented under Windows NT, versions 3.51 and later.  
  
 For more information, see [EM_SETHANDLE](http://msdn.microsoft.com/library/windows/desktop/bb761641), [LocalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366723), and [LocalFree](http://msdn.microsoft.com/library/windows/desktop/aa366730) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#22](../vs140/codesnippet/CPP/cedit--sethandle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::CanUndo](../vs140/cedit--canundo.md)   
 [CEdit::GetHandle](../vs140/cedit--gethandle.md)   
 [CEdit::GetModify](../vs140/cedit--getmodify.md)