---
title: "CMFCAcceleratorKey Class"
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
  - "CMFCAcceleratorKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCAcceleratorKey class"
ms.assetid: d140fbf7-23db-45ea-a63e-414a5ec7b3d5
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAcceleratorKey Class
A helper class that implements virtual key mapping and formatting.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAcceleratorKey::CMFCAcceleratorKey](#cmfcacceleratorkey__cmfcacceleratorkey)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAcceleratorKey::Format](#cmfcacceleratorkey__format)|Translates the ACCEL structure to its visual representation.|  
|[CMFCAcceleratorKey::SetAccelerator](#cmfcacceleratorkey__setaccelerator)|Sets the shortcut key for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Accelerator keys are also known as shortcut keys. If you want to display keyboard shortcuts that a user enters, the [CMFCAcceleratorKeyAssignCtrl Class](../vs140/cmfcacceleratorkeyassignctrl-class.md) maps keyboard shortcuts, such as Alt+Shift+S, to a custom text format, such as "Alt + Shift + S". Each <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object maps a single shortcut key to a text format.  
  
 For more information about how to use shortcut keys and accelerator tables, see                [CKeyboardManager](../vs140/ckeyboardmanager-class.md).  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object and how to use its <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method.  
  
 [!code[NVC_MFC_RibbonApp#30](../vs140/codesnippet/CPP/cmfcacceleratorkey-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCAcceleratorKey](../vs140/cmfcacceleratorkey-class.md)  
  
## Requirements  
 **Header:** afxacceleratorkey.h  
  
##  \<a name="cmfcacceleratorkey__cmfcacceleratorkey">\</a>  CMFCAcceleratorKey::CMFCAcceleratorKey  
 Constructs a [CMFCAcceleratorKey](../vs140/cmfcacceleratorkey-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to a shortcut key.  
  
### Remarks  
 If you do not provide a shortcut key when you create a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, use the [CMFCAcceleratorKey::SetAccelerator](#cmfcacceleratorkey__setaccelerator) method to associate a shortcut key with your <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcacceleratorkey__format">\</a>  CMFCAcceleratorKey::Format  
 Translates the ACCEL structure to its associated string value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object where the method writes the translated shortcut key.  
  
### Remarks  
 This method retrieves the string format of the associated shortcut key. You can set the string format of a [CMFCAcceleratorKey](../vs140/cmfcacceleratorkey-class.md) object using either the constructor or the method [CMFCAcceleratorKey::SetAccelerator](#cmfcacceleratorkey__setaccelerator).  
  
##  \<a name="cmfcacceleratorkey__setaccelerator">\</a>  CMFCAcceleratorKey::SetAccelerator  
 Sets the shortcut key for the [CMFCAcceleratorKey](../vs140/cmfcacceleratorkey-class.md) object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to a shortcut key.  
  
### Remarks  
 Use this method to set the shortcut key for a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if you did not provide a shortcut key when you created the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CKeyboardManager](../vs140/ckeyboardmanager-class.md)