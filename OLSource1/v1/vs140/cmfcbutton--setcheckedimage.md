---
title: "CMFCButton::SetCheckedImage"
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
  - "CMFCButton.SetCheckedImage"
  - "CMFCButton::SetCheckedImage"
  - "SetCheckedImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCheckedImage method"
ms.assetid: 97a2730f-446c-485b-a548-be3123b3ea5f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::SetCheckedImage
Sets the image for a checked button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the icon that contains the bitmap and mask for the new image.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify that bitmap resources be destroyed automatically; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Handle to the icon that contains the image for the selected state.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the image for the non-selected state.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the image for the selected state.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies a transparent color for the button background; that is, the face of the button. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to use the color value RGB(192, 192, 192); <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to use the color value defined by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Resource ID for the non-selected image.  
  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Resource ID for the selected image.  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Handle to the icon for the disabled image.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the disabled image.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Resource ID of the disabled bitmap.  
  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to use only 32-bit images that use the alpha channel; <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, to not use only alpha channel images. The default is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)