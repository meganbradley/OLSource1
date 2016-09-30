---
title: "CMFCPropertyGridCtrl::SetCustomColors"
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
  - "CMFCPropertyGridCtrl.SetCustomColors"
  - "CMFCPropertyGridCtrl::SetCustomColors"
  - "SetCustomColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCustomColors method"
ms.assetid: e38e1c8c-e3eb-41a0-8a1f-fbd4b87d88c4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::SetCustomColors
Specifies custom colors for various elements of the property grid control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The background color of property values.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The color of property names and property value text.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The background color of a property group.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The new text color of property group.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The background color of the description area.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The color of text in the description area.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The color of lines that are drawn between properties.  
  
## Remarks  
 For any parameter, specify the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> color value to use the default color for that element of the property grid control.  
  
 To customize the appearance of a specific property, derive a class from the [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md) class and then override the [CMFCPropertyGridProperty::OnDrawName](../vs140/cmfcpropertygridproperty--ondrawname.md), [CMFCPropertyGridProperty::OnDrawValue](../vs140/cmfcpropertygridproperty--ondrawvalue.md), [CMFCPropertyGridProperty::OnDrawExpandBox](../vs140/cmfcpropertygridproperty--ondrawexpandbox.md), and [CMFCPropertyGridProperty::OnDrawButton](../vs140/cmfcpropertygridproperty--ondrawbutton.md) methods.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CMFCPropertyGridCtrl::GetCustomColors](../vs140/cmfcpropertygridctrl--getcustomcolors.md)