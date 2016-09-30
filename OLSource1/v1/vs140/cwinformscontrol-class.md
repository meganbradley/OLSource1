---
title: "CWinFormsControl Class"
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
  - "CWinFormsControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC [C++], Windows Forms support"
  - "CWinFormsControl class"
  - "Windows Forms [C++], MFC support"
ms.assetid: 6406dd7b-fb89-4a18-ac3a-c010d6b6289a
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsControl Class
Provides the basic functionality for hosting of a Windows Forms control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A .NET Framework Windows Forms control to be displayed in the MFC application.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CWinFormsControl::CWinFormsControl](#cwinformscontrol__cwinformscontrol)|Constructs an MFC Windows Forms control wrapper object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWinFormsControl::CreateManagedControl](#cwinformscontrol__createmanagedcontrol)|Creates a Windows Forms control in an MFC container.|  
|[CWinFormsControl::GetControl](#cwinformscontrol__getcontrol)|Retrieves a pointer to the Windows Forms control.|  
|[CWinFormsControl::GetControlHandle](#cwinformscontrol__getcontrolhandle)|Retrieves a handle to the Windows Forms control.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CWinFormsControl::operator -&gt;](#cwinformscontrol__operator_-_gt_)|Replaces [GetControl](#cwinformscontrol__getcontrol) in expressions.|  
|[CWinFormsControl::operator TManagedControl^](#cwinformscontrol__operator_tmanagedcontrol^)|Casts a type as a pointer to a Windows Forms control.|  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class provides the basic functionality for hosting of a Windows Forms control.  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
 Your MFC code should not cache Window handles (usually stored in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>). Some Windows Forms control properties require that the underlying Win32 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> be destroyed and recreated using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The MFC Windows Forms implementation handles the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> events of the controls to update the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member.  
  
> [!NOTE]
>  MFC Windows Forms integration works only in projects which link dynamically with MFC (in which AFXDLL is defined).  
  
## Requirements  
 **Header:** afxwinforms.h  
  
##  \<a name="cwinformscontrol__createmanagedcontrol">\</a>  CWinFormsControl::CreateManagedControl  
 Creates a Windows Forms control in an MFC container.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The data type of the control to be created. Must be a \<xref:System.Type*?displayProperty=fullName> data type.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The window style to apply to the control. Specify a combination of [Window Styles](../vs140/window-styles.md). Currently, only the following styles are supported: WS_TABSTOP, WS_VISIBLE, WS_DISABLED and WS_GROUP.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A [RECT Structure](../vs140/rect-structure.md) that defines the coordinates of the upper-left and lower-right corners of the control (first overload only).  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The handle of the static place holder control placed in the Resource Editor. The newly created Windows Forms control replaces the static control, assuming its position, z-order, and styles (second overload only).  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The resource ID number to be assigned to the newly created control.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An instance of a Windows Forms control to be associated with the [CWinFormsControl](../vs140/cwinformscontrol-class.md) object (fourth overload only).  
  
### Return Value  
 If successful, returns a nonzero value. If unsuccessful, returns zero.  
  
### Remarks  
 This method instantiates a .NET Framework Windows Forms control in an MFC container.  
  
 The first overload of the method accepts a .NET Framework data type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> so that MFC can instantiate a new object of this type. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> must be a \<xref:System.Type*?displayProperty=fullName> data type.  
  
 The second overload of the method creates a Windows Forms control based on the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> template parameter of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class. The size and position of the control is based on the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> structure passed to the method. Only <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> matters for the styles.  
  
 The third overload of the method creates a Windows Forms control that replaces a static control, destroying it and assuming its position, z-order, and styles. The static control serves only as a placeholder for the Windows Forms control. When creating the control, this overload combines the styles from <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> with the static control's resource styles.  
  
 The fourth overload of the method allows you to pass in an already instantiated Windows Forms control <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> that MFC will wrap. It must be of the same type as the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> template parameter of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class.  
  
 See [Using a Windows Form User Control in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md) for samples on using Windows Form controls.  
  
##  \<a name="cwinformscontrol__cwinformscontrol">\</a>  CWinFormsControl::CWinFormsControl  
 Constructs an MFC Windows Forms control wrapper object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The Windows Forms control is instantiated when you call [CreateManagedControl](#cwinformscontrol__createmanagedcontrol).  
  
##  \<a name="cwinformscontrol__getcontrol">\</a>  CWinFormsControl::GetControl  
 Retrieves a pointer to the Windows Forms control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the Windows Forms control.  
  
### Example  
  See [CWinFormsControl::CreateManagedControl](#cwinformscontrol__createmanagedcontrol).  
  
##  \<a name="cwinformscontrol__getcontrolhandle">\</a>  CWinFormsControl::GetControlHandle  
 Retrieves a handle to the Windows Forms control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns a handle to the Windows Forms control.  
  
### Remarks  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a helper method that returns the window handle stored in the .NET Framework control properties. The window handle value is copied to [CWnd::m_hWnd](../vs140/cwnd-class.md#cwnd__m_hwnd) during the call to [CWnd::Attach](../vs140/cwnd-class.md#cwnd__attach).  
  
##  \<a name="cwinformscontrol__operator_-_gt_">\</a>  CWinFormsControl::operator -&gt;  
 Replaces [GetControl](#cwinformscontrol__getcontrol) in expressions.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This operator provides a convenient syntax that replaces <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in expressions.  
  
 For more information on Windows Forms, see [Using a Windows Form User Control in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
##  \<a name="cwinformscontrol__operator_tmanagedcontrol_xor">\</a>  CWinFormsControl::operator TManagedControl^  
 Casts a type as a pointer to a Windows Forms control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This operator passes <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to functions that accept a pointer to a Windows Forms control.  
  
## See Also  
 [CWinFormsDialog Class](../vs140/cwinformsdialog-class.md)   
 [CWinFormsView Class](../vs140/cwinformsview-class.md)