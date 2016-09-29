---
title: "CMFCPropertyGridProperty::CMFCPropertyGridProperty"
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
  - "CMFCPropertyGridProperty"
  - "CMFCPropertyGridProperty::CMFCPropertyGridProperty"
  - "CMFCPropertyGridProperty.CMFCPropertyGridProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridProperty class, constructor"
ms.assetid: 7ff07cc6-5507-4c16-bbfe-7bc98204fae8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::CMFCPropertyGridProperty
Constructs a `CMFCPropertyGridProperty` object.  
  
## Syntax  
  
```  
CMFCPropertyGridProperty(  
   const CString& strGroupName,  
   DWORD_PTR dwData=0,  
   BOOL bIsValueList=FALSE   
);  
CMFCPropertyGridProperty(  
   const CString& strName,  
   const _variant_t& varValue,  
   LPCTSTR lpszDescr=NULL,  
   DWORD_PTR dwData=0,  
   LPCTSTR lpszEditMask=NULL,  
   LPCTSTR lpszEditTemplate=NULL,  
   LPCTSTR lpszValidChars=NULL   
);  
```  
  
#### Parameters  
 [in] `strGroupName`  
 The group name. A *group* is a collection of related properties in a property grid control. If the control is displayed hierarchically, the *group name* is displayed as a category title in the row above the group.  
  
 [in] `dwData`  
 Application-specific data, such as an integer or a pointer to other data that is associated with the property. The default value is 0.  
  
 [in] `strName`  
 The name of the property.  
  
 [in] `varValue`  
 The property value.  
  
 [in] `lpszDescr`  
 The property description. The default value is `NULL`.  
  
 [in] `lpszEditMask`  
 The edit mask, if the property is a masked edit control. The default value is `NULL`.  
  
 [in] `lpszEditTemplate`  
 The edit template, if the property is a masked edit control. The default value is `NULL`.  
  
 [in] `lpszValidChars`  
 A list of valid characters, if the property is a masked edit control. The default value is `NULL`.  
  
 [in] `bIsValueList`  
 `TRUE` if the property represents a list of values; `FALSE` if the property represents a single value. The default value is `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)