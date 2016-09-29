---
title: "CImageList::Draw"
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
  - "ILD_BLEND25"
  - "CImageList.Draw"
  - "ILD_BLEND50"
  - "ILD_OVERLAYMASK"
  - "ILD_TRANSPARENT"
  - "ILD_NORMAL"
  - "CImageList::Draw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ILD_BLEND25"
  - "ILD_BLEND50"
  - "ILD_NORMAL"
  - "ILD_TRANSPARENT"
  - "ILD_OVERLAYMASK"
  - "Draw method"
ms.assetid: 8799ff57-6540-41f7-b1c2-153c6cef8ba4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::Draw
Call this function to draw the image that is being dragged during a drag-and-drop operation.  
  
## Syntax  
  
```  
  
      BOOL Draw(  
   CDC* pDC,  
   int nImage,  
   POINT pt,  
   UINT nStyle   
);  
```  
  
#### Parameters  
 `pDC`  
 Pointer to the destination device context.  
  
 `nImage`  
 Zero-based index of the image to draw.  
  
 `pt`  
 Location at which to draw within the specified device context.  
  
 `nStyle`  
 Flag specifying the drawing style. It can be one or more of these values:  
  
|Value|Meaning|  
|-----------|-------------|  
|`ILD_BLEND25`, **ILD_FOCUS**|Draws the image, blending 25 percent with the system highlight color. This value has no effect if the image list does not contain a mask.|  
|`ILD_BLEND50`, **ILD_SELECTED**, **ILD_BLEND**|Draws the image, blending 50 percent with the system highlight color. This value has no effect if the image list does not contain a mask.|  
|**ILD_MASK**|Draws the mask.|  
|`ILD_NORMAL`|Draws the image using the background color for the image list. If the background color is the `CLR_NONE` value, the image is drawn transparently using the mask.|  
|`ILD_TRANSPARENT`|Draws the image transparently using the mask, regardless of the background color.|  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [CImageList::SetOverlayImage](../vs140/cimagelist--setoverlayimage.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::BeginDrag](../vs140/cimagelist--begindrag.md)   
 [CImageList::EndDrag](../vs140/cimagelist--enddrag.md)   
 [CImageList::DragMove](../vs140/cimagelist--dragmove.md)   
 [CImageList::DrawEx](../vs140/cimagelist--drawex.md)