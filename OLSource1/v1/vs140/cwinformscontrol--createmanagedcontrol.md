---
title: "CWinFormsControl::CreateManagedControl"
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
  - "CWinFormsControl::CreateManagedControl"
  - "CreateManagedControl"
  - "CWinFormsControl.CreateManagedControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateManagedControl method"
ms.assetid: 066d3e8d-d912-45c7-b36b-f7a48dd75ce7
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsControl::CreateManagedControl
Creates a Windows Forms control in an MFC container.  
  
## Syntax  
  
```  
inline BOOL CreateManagedControl(  
   System::Type^ pType,  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   int nID  
)  
inline BOOL CreateManagedControl(  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   int nID  
);  
inline BOOL CreateManagedControl(  
   DWORD dwStyle,  
   int nPlaceHolderID,  
   CWnd* pParentWnd  
);  
inline BOOL CreateManagedControl(  
   typename TManagedControl^ pControl,  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   int nID  
);  
```  
  
#### Parameters  
 `pType`  
 The data type of the control to be created. Must be a <xref:System.Type*?displayProperty=fullName> data type.  
  
 `dwStyle`  
 The window style to apply to the control. Specify a combination of [Window Styles](../vs140/window-styles.md). Currently, only the following styles are supported: WS_TABSTOP, WS_VISIBLE, WS_DISABLED and WS_GROUP.  
  
 `rect`  
 A [RECT Structure](../vs140/rect-structure.md) that defines the coordinates of the upper-left and lower-right corners of the control (first overload only).  
  
 `nPlaceHolderID`  
 The handle of the static place holder control placed in the Resource Editor. The newly created Windows Forms control replaces the static control, assuming its position, z-order, and styles (second overload only).  
  
 `pParentWnd`  
 A pointer to the parent window.  
  
 `nID`  
 The resource ID number to be assigned to the newly created control.  
  
 `pControl`  
 An instance of a Windows Forms control to be associated with the [CWinFormsControl](../vs140/cwinformscontrol-class.md) object (fourth overload only).  
  
## Return Value  
 If successful, returns a nonzero value. If unsuccessful, returns zero.  
  
## Remarks  
 This method instantiates a .NET Framework Windows Forms control in an MFC container.  
  
 The first overload of the method accepts a .NET Framework data type `pType` so that MFC can instantiate a new object of this type. `pType` must be a <xref:System.Type*?displayProperty=fullName> data type.  
  
 The second overload of the method creates a Windows Forms control based on the `TManagedControl` template parameter of the `CWinFormsControl` class. The size and position of the control is based on the `RECT` structure passed to the method. Only `dwStyle` matters for the styles.  
  
 The third overload of the method creates a Windows Forms control that replaces a static control, destroying it and assuming its position, z-order, and styles. The static control serves only as a placeholder for the Windows Forms control. When creating the control, this overload combines the styles from `dwStyle` with the static control's resource styles.  
  
 The fourth overload of the method allows you to pass in an already instantiated Windows Forms control `pControl` that MFC will wrap. It must be of the same type as the `TManagedControl` template parameter of the `CWinFormsControl` class.  
  
 See [Using a Windows Form User Control in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md) for samples on using Windows Form controls.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [CWinFormsControl Class](../vs140/cwinformscontrol-class.md)   
 [GetControl](../vs140/cwinformscontrol--getcontrol.md)