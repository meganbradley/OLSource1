---
title: "CMFCPropertySheet::SetLook"
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
  - "SetLook"
  - "CMFCPropertySheet::SetLook"
  - "CMFCPropertySheet.SetLook"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLook method"
ms.assetid: 68ca5533-228f-4564-8f3d-597905129e73
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::SetLook
Specifies the appearance of the property sheet.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 One of the enumeration values that specifies the appearance of the property sheet. The default style for a property sheet is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see the table in the Remarks section of this topic.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The width of the navigation control, in pixels. The default value is 100.  
  
## Remarks  
 To display a property sheet in a style other than the default, call this method before you create the property sheet window.  
  
 The following table lists the enumeration values that can be specified in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|(Default) Displays a tab for each property page. Tabs are displayed at the top of the property sheet and are stacked if there are more tabs than will fit in a single row.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Displays a list of navigation buttons, in the style of the Microsoft Outlook bar, at the left side of the property sheet. Each button in the list corresponds to a property page. The framework displays scroll arrows if there are more buttons than will fit in the visible area of the list.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Displays a tree control at the left side of the property sheet. Each parent or child node of the tree control corresponds to a property page. The framework displays scroll arrows if there are more nodes than will fit in the visible area of the tree control.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Displays a tab, in the style of Microsoft OneNote, for each property page. The framework displays tabs at the top of the property sheet and scroll arrows if there are more tabs than will fit in a single row.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Displays a list at the left side of the property sheet. Each list item corresponds to a property page. The framework displays scroll arrows if there are more list items than will fit in the visible area of the list.|  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyPage Class](../vs140/cmfcpropertypage-class.md)   
 [CMFCPropertySheet::GetLook](../vs140/cmfcpropertysheet--getlook.md)