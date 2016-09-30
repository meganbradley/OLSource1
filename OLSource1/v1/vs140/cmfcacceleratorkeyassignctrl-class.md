---
title: "CMFCAcceleratorKeyAssignCtrl Class"
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
  - "CMFCAcceleratorKeyAssignCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCAcceleratorKeyAssignCtrl class"
ms.assetid: 89fb8e62-596e-4e71-8c9a-32740347aaab
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAcceleratorKeyAssignCtrl Class
The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class extends the [CEdit Class](../vs140/cedit-class.md) to support extra system buttons such as ALT, CONTROL, and SHIFT.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAcceleratorKeyAssignCtrl::CMFCAcceleratorKeyAssignCtrl](#cmfcacceleratorkeyassignctrl__cmfcacceleratorkeyassignctrl)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAcceleratorKeyAssignCtrl::GetAccel](#cmfcacceleratorkeyassignctrl__getaccel)|Retrieves the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure for a shortcut key pressed in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[CMFCAcceleratorKeyAssignCtrl::IsFocused](#cmfcacceleratorkeyassignctrl__isfocused)||  
|[CMFCAcceleratorKeyAssignCtrl::IsKeyDefined](#cmfcacceleratorkeyassignctrl__iskeydefined)|Determines whether a shortcut key has been defined.|  
|[CMFCAcceleratorKeyAssignCtrl::PreTranslateMessage](#cmfcacceleratorkeyassignctrl__pretranslatemessage)|Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage).)|  
|[CMFCAcceleratorKeyAssignCtrl::ResetKey](#cmfcacceleratorkeyassignctrl__resetkey)|Resets the shortcut key.|  
  
## Remarks  
 This class extends the functionality of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class by supporting shortcut keys, also known as accelerator keys. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class functions as a [CEdit Class](../vs140/cedit-class.md) and it can also recognize system buttons.  
  
 This class maps physical shortcut key combinations to string values. For example, assume the key combination ALT + B is mapped to the string "Alt + B". When the user presses this key combination in a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object, "Alt + B" is displayed to the user. For more information about the mapping between shortcut keys and a string format, see [CMFCAcceleratorKey Class](../vs140/cmfcacceleratorkey-class.md).  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object and use its <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method to reset the shortcut key.  
  
 [!code[NVC_MFC_RibbonApp#31](../vs140/codesnippet/CPP/cmfcacceleratorkeyassignctrl-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CEdit](../vs140/cedit-class.md)  
  
 [CMFCAcceleratorKeyAssignCtrl](../vs140/cmfcacceleratorkeyassignctrl-class.md)  
  
## Requirements  
 **Header:** afxacceleratorkeyassignctrl.h  
  
##  \<a name="cmfcacceleratorkeyassignctrl__cmfcacceleratorkeyassignctrl">\</a>  CMFCAcceleratorKeyAssignCtrl::CMFCAcceleratorKeyAssignCtrl  
 Constructs a [CMFCAcceleratorKeyAssignCtrl](../vs140/cmfcacceleratorkeyassignctrl-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cmfcacceleratorkeyassignctrl__getaccel">\</a>  CMFCAcceleratorKeyAssignCtrl::GetAccel  
 Retrieves the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure for a shortcut key pressed in the [CMFCAcceleratorKeyAssignCtrl](../vs140/cmfcacceleratorkeyassignctrl-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> structure that describes the shortcut key.  
  
### Remarks  
 Use this function to retrieve the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure for a shortcut key that the user entered into your <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcacceleratorkeyassignctrl__isfocused">\</a>  CMFCAcceleratorKeyAssignCtrl::IsFocused  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcacceleratorkeyassignctrl__iskeydefined">\</a>  CMFCAcceleratorKeyAssignCtrl::IsKeyDefined  
 Determines whether a shortcut key has been defined in the [CMFCAcceleratorKeyAssignCtrl](../vs140/cmfcacceleratorkeyassignctrl-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the user has already pressed a valid combination of keys that define a shortcut key; otherwise 0.  
  
### Remarks  
 Use this function to determine whether the user entered a valid shortcut key in your <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object. If a shortcut key exists, you can use [CMFCAcceleratorKeyAssignCtrl::GetAccel](#cmfcacceleratorkeyassignctrl__getaccel) method to obtain the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> structure associated with this shortcut key.  
  
##  \<a name="cmfcacceleratorkeyassignctrl__pretranslatemessage">\</a>  CMFCAcceleratorKeyAssignCtrl::PreTranslateMessage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcacceleratorkeyassignctrl__resetkey">\</a>  CMFCAcceleratorKeyAssignCtrl::ResetKey  
 Resets the shortcut key.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The function clears the edit control text. This includes any shortcut keys that the user pressed.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCAcceleratorKey Class](../vs140/cmfcacceleratorkey-class.md)