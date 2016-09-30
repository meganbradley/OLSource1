---
title: "CMFCImagePaintArea Class"
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
  - "CMFCImagePaintArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCImagePaintArea class"
ms.assetid: c59eec22-f15a-4e58-8c4d-4a18a41f4452
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCImagePaintArea Class
Provides the picture area that you use to modify an image in an image editor dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCImagePaintArea::CMFCImagePaintArea](#cmfcimagepaintarea__cmfcimagepaintarea)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCImagePaintArea::GetMode](#cmfcimagepaintarea__getmode)|Retrieves the current drawing mode.|  
|[CMFCImagePaintArea::SetBitmap](#cmfcimagepaintarea__setbitmap)|Sets the bitmap image for the picture area.|  
|[CMFCImagePaintArea::SetColor](#cmfcimagepaintarea__setcolor)|Sets the current drawing color.|  
|[CMFCImagePaintArea::SetMode](#cmfcimagepaintarea__setmode)|Sets the current drawing mode.|  
  
### Remarks  
 This class is not intended to be used directly from your code.  
  
 The framework uses this class to display the picture area in an image editor dialog box. For more information about the image editor dialog box, see [CMFCImageEditorDialog Class](../vs140/cmfcimageeditordialog-class.md).  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class, set the current drawing color, set the current drawing mode, and set the bitmap image for the picture area.  
  
 [!code[NVC_MFC_RibbonApp#37](../vs140/codesnippet/CPP/cmfcimagepaintarea-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CButton](../vs140/cbutton-class.md)  
  
 [CMFCImagePaintArea](../vs140/cmfcimagepaintarea-class.md)  
  
## Requirements  
 **Header:** afximagepaintarea.h  
  
##  \<a name="cmfcimagepaintarea__cmfcimagepaintarea">\</a>  CMFCImagePaintArea::CMFCImagePaintArea  
 Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|A pointer to the dialog box that is the parent of the image editor.|  
  
##  \<a name="cmfcimagepaintarea__getmode">\</a>  CMFCImagePaintArea::GetMode  
 Retrieves the current drawing mode.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value that specifies the current drawing mode.  
  
##  \<a name="cmfcimagepaintarea__setbitmap">\</a>  CMFCImagePaintArea::SetBitmap  
 Sets the bitmap image for the picture area.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The new bitmap image to display.|  
  
### Remarks  
 If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, this method sets the size of the modifiable paint area to zero. Otherwise, it sets the size of the modifiable paint area to the size of the provided bitmap image.  
  
##  \<a name="cmfcimagepaintarea__setcolor">\</a>  CMFCImagePaintArea::SetColor  
 Sets the current drawing color.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The new drawing color.|  
  
### Remarks  
 When you select a color from the image editor palette bar or color picker, the framework calls this method to update the current drawing color. The initial drawing color is black (a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value of 0).  
  
 The drawing color is used by the image editor dialog box for all drawing modes except for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information about drawing modes, see [CMFCImagePaintArea::IMAGE_EDIT_MODE Enumeration](../vs140/cmfcimagepaintarea--image_edit_mode-enumeration.md).  
  
##  \<a name="cmfcimagepaintarea__setmode">\</a>  CMFCImagePaintArea::SetMode  
 Sets the current drawing mode.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value that specifies the current drawing mode.|  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCImageEditorDialog Class](../vs140/cmfcimageeditordialog-class.md)