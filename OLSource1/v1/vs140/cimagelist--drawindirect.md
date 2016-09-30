---
title: "CImageList::DrawIndirect"
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
  - "CImageList.DrawIndirect"
  - "DrawIndirect"
  - "CLR_DEFAULT"
  - "CLR_NONE"
  - "CImageList::DrawIndirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLR_DEFAULT"
  - "CLR_NONE"
  - "DrawIndirect method"
ms.assetid: dd6883a6-d79c-4680-ab92-26442616107c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::DrawIndirect
Call this member function to draw an image from an image list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pimldp*  
 A pointer to an [IMAGELISTDRAWPARAMS](http://msdn.microsoft.com/library/windows/desktop/bb761395) structure that contains information about the draw operation.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the destination device context. You must delete this [CDC](../vs140/cdc-class.md) object when you are done with it.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of the image to be drawn.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure containing the x– and y– coordinates where the image will be drawn.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure indicating the size of the image to be drawn.  
  
 *ptOrigin*  
 A [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure containing the x– and y–coordinates specifying the upper left corner of the drawing operation with respect to the image itself. Pixels of the image that are to the left of the x–coordinate and above the y–coordinate are not drawn.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Flag specifying the drawing style and, optionally, the overlay image. See the Remarks section for information on the overlay image. The MFC default implementation, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, draws the image using the background color for the image list. If the background color is the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value, the image is drawn transparently using a mask.  
  
 Other possible styles are described under the **fStyle** member of the [IMAGELISTDRAWPARAMS](http://msdn.microsoft.com/library/windows/desktop/bb761395) structure.  
  
 *dwRop*  
 Value specifying a raster-operation code. These codes define how the color data for the source rectangle will be combined with the color data for the destination rectangle to achieve the final color. MFC's default implementation, **SRCCOPY**, copies the source rectangle directly to the destination rectangle. This parameter is ignored if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter does not include the **ILD_ROP** flag.  
  
 Other possible values are described under the **dwRop** member of the [IMAGELISTDRAWPARAMS](http://msdn.microsoft.com/library/windows/desktop/bb761395) structure.  
  
 *rgbBack*  
 The image background color, by default <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This parameter can be an application-defined RGB value or one of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Default background color. The image is drawn using the image list background color.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|No background color. The image is drawn transparently.|  
  
 *rgbFore*  
 Image foreground color, by default <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This parameter can be an application-defined RGB value or one of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Default foreground color. The image is drawn using the system highlight color as the foreground color.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|No blend color. The image is blended with the color of the destination device context.|  
  
 This parameter is used only if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> includes the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> flag.  
  
 *fState*  
 Flag specifying the drawing state. This member can contain one or more image list state flags.  
  
 *Frame*  
 Affects the behavior of saturate and alpha-blending effects.  
  
 When used with **ILS_SATURATE**, this member holds the value that is added to each color component of the RGB triplet for each pixel in the icon.  
  
 When used with **ILS_APLHA**, this member holds the value for the alpha channel. This value can be from 0 to 255, with 0 being completely transparent, and 255 being completely opaque.  
  
 *crEffect*  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value used for glow and shadow effects.  
  
## Return Value  
 **TRUE** if the image is successfully drawn; otherwise **FALSE**.  
  
## Remarks  
 Use the first version if you want to fill the Win32 structure yourself. Use the second version if you want to take advantage of one or more of MFC's default arguments, or avoid managing the structure.  
  
 An overlay image is an image that is drawn on top of the primary image, specified in this member function by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter. Draw an overlay mask by using the [Draw](../vs140/cimagelist--draw.md) member function with the one-based index of the overlay mask specified by using the [INDEXTOOVERLAYMASK](http://msdn.microsoft.com/library/windows/desktop/bb761408) macro.  
  
## Example  
 [!code[NVC_MFC_CImageList#11](../vs140/codesnippet/CPP/cimagelist--drawindirect_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::SetOverlayImage](../vs140/cimagelist--setoverlayimage.md)