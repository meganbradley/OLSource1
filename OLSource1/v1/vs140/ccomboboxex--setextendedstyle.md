---
title: "CComboBoxEx::SetExtendedStyle"
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
  - "CComboBoxEx.SetExtendedStyle"
  - "CComboBoxEx::SetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetExtendedStyle method"
ms.assetid: e9ee0d43-08d3-4520-bed8-7c1b19e606b6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::SetExtendedStyle
Call this member function to set the extended styles used for a combo box extended control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value that indicates which styles in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are to be affected. Only the extended styles in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be changed. All other styles will be maintained as is. If this parameter is zero, then all of the styles in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will be affected.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value that contains the combo box control extended styles to set for the control.  
  
## Return Value  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value that contains the extended styles previously used for the control.  
  
## Remarks  
 See [ComboBoxEx Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb775742) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about these styles.  
  
 To create a combo box extended control with extended windows styles, use [CreateEx](../vs140/ccomboboxex--createex.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::GetExtendedStyle](../vs140/ccomboboxex--getextendedstyle.md)