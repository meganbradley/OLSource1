---
title: "CDC::DrawState"
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
  - "CDC::DrawState"
  - "CDC.DrawState"
  - "DrawState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, displaying images"
  - "DrawState method"
  - "CDC class, image state"
  - "rendering images"
  - "CDC class, simple drawing functions"
  - "visual effects"
ms.assetid: bdf92d57-c45f-45f5-92b8-e66a74467837
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawState
Call this member function to display an image and apply a visual effect to indicate a state, such as a disabled or default state.  
  
> [!NOTE]
>  For all <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> states except **DSS_NORMAL**, the image is converted to monochrome before the visual effect is applied.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the location of the image.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the size of the image.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A handle to a bitmap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Flags that specify the image type and state. See [DrawState](http://msdn.microsoft.com/library/windows/desktop/dd162496) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for the possible <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> types and states.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A handle to a brush.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to a CBitmap object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to a CBrush object.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A handle to an icon.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to text.  
  
 *bPrefixText*  
 Text that may contain an accelerator mnemonic. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter specifies the address of the string, and the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter specifies the length. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is 0, the string is assumed to be null-terminated.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Length of the text string pointed to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is 0, the string is assumed to be null-terminated.  
  
 *lpDrawProc*  
 A pointer to a callback function used to render an image. This parameter is required if the image type in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is **DST_COMPLEX**. It is optional and can be **NULL** if the image type is **DST_TEXT**. For all other image types, this parameter is ignored. For more information about the callback function, see the [DrawStateProc](http://msdn.microsoft.com/library/windows/desktop/dd162497) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Specifies information about the image. The meaning of this parameter depends on the image type.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DrawState](http://msdn.microsoft.com/library/windows/desktop/dd162496)   
 [DrawStateProc](http://msdn.microsoft.com/library/windows/desktop/dd162497)