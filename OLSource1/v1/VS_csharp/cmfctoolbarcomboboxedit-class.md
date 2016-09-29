---
title: "CMFCToolBarComboBoxEdit Class"
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
  - "CMFCComboEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarComboBoxEdit class"
  - "CMFCToolBarComboBoxEdit::PreTranslateMessage method"
ms.assetid: 4789c34a-ce58-48ba-a26f-38748b601352
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxEdit Class
The framework uses the `CMFCToolBarComboBoxEdit` class to create a toolbar button that behaves like an editable combo box control.  
  
## Syntax  
  
```  
class CMFCToolBarComboBoxEdit : public CEdit  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarComboBoxEdit::CMFCToolBarComboBoxEdit](#cmfctoolbarcomboboxedit__cmfctoolbarcomboboxedit)|Constructs a `CMFCToolBarComboBoxEdit` object.|  
|`CMFCToolBarComboBoxEdit::~CMFCToolBarComboBoxEdit`|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|`CMFCToolBarComboBoxEdit::PreTranslateMessage`|Translates window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CWnd::PreTranslateMessage](../VS_csharp/cwnd-class.md#cwnd__pretranslatemessage).)|  
  
### Remarks  
 Derive a class from the `CMFCToolBarComboBoxEdit` class to customize its edit operations.  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 [CWnd](../VS_csharp/cwnd-class.md)  
  
 [CEdit](../VS_csharp/cedit-class.md)  
  
 [CMFCToolBarComboBoxEdit](../VS_csharp/cmfctoolbarcomboboxedit-class.md)  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
##  <a name="cmfctoolbarcomboboxedit__cmfctoolbarcomboboxedit"></a>  CMFCToolBarComboBoxEdit::CMFCToolBarComboBoxEdit  
 Constructs a `CMFCToolBarComboBoxEdit` object.  
  
```  
CMFCToolBarComboBoxEdit(  
   CMFCToolBarComboBoxButton& combo  
);  
```  
  
### Parameters  
 [in] `combo`  
 A reference to a [CMFCToolBarComboBoxButton](../VS_csharp/cmfctoolbarcomboboxbutton-class.md) object, which is a toolbar button that contains a combo box control.  
  
### Example  
 The following example demonstrates how to construct an object of the `CMFCToolBarComboBoxEdit` class. This code snippet is part of the [IE Demo sample](../VS_csharp/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#5](../VS_csharp/codesnippet/CPP/cmfctoolbarcomboboxedit-class_1.cpp)]  
  
## See Also  
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [Classes](../VS_csharp/mfc-classes.md)   
 [CMFCToolBarComboBoxButton Class](../VS_csharp/cmfctoolbarcomboboxbutton-class.md)   
 [CMFCToolBarComboBoxButton:CreateEdit](../VS_csharp/cmfctoolbarcomboboxbutton-class.md#cmfctoolbarcomboboxbutton__createedit)