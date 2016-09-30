---
title: "CMFCPropertySheet::SetIconsList"
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
  - "CMFCPropertySheet.SetIconsList"
  - "CMFCPropertySheet::SetIconsList"
  - "SetIconsList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetIconsList method"
ms.assetid: 705c3860-b3c6-42e4-b0c3-de807f6dd9c3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::SetIconsList
Specifies the list of images that are used in the navigation control of the Outlook pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The resource ID of an image list.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The width, in pixels, of icons in the image list.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The transparent image color. The parts of the image that are this color will be transparent. The default value is the color magenta, RGB(255,0,255).  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A handle to an existing image list.  
  
## Return Value  
 In the first method overload syntax, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the property sheet is in the style of Microsoft Outlook, the framework displays a list of navigation buttons, called the Outlook pane control, at the left of the property sheet. Use this method to set the image list to be used by the Outlook pane control.  
  
 For more information about the methods that support this method, see [CImageList::Create](../vs140/cimagelist--create.md) and [CImageList::Add](../vs140/cimagelist--add.md). For more information about how to set the style of a property sheet, see [CMFCPropertySheet::SetLook](../vs140/cmfcpropertysheet--setlook.md).  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CImageList::Create](../vs140/cimagelist--create.md)   
 [CImageList::Add](../vs140/cimagelist--add.md)   
 [CMFCPropertySheet::SetLook](../vs140/cmfcpropertysheet--setlook.md)