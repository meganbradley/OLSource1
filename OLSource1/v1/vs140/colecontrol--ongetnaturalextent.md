---
title: "COleControl::OnGetNaturalExtent"
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
  - "COleControl.OnGetNaturalExtent"
  - "OnGetNaturalExtent"
  - "COleControl::OnGetNaturalExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetNaturalExtent method"
ms.assetid: 7242a771-e788-4af9-b39d-260878e28722
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetNaturalExtent
Called by the framework in response to a container's **IViewObjectEx::GetNaturalExtent** request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies how the object is to be represented. Representations include content, an icon, a thumbnail, or a printed document. Valid values are taken from the enumeration [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**.  
  
 *lindex*  
 The portion of the object that is of interest. Currently only -1 is valid.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure defining the target device for which the object's size should be returned.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the information context for the target device indicated by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter from which the object can extract device metrics and test the device's capabilities. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **NULL**, the object should ignore the value in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.  
  
 *pExtentInfo*  
 Points to the **DVEXTENTINFO** structure that specifies sizing data. The **DVEXTENTINFO** structure is:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 The structure member <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can take one of two values:  
  
-   **DVEXTENT_CONTENT** Inquire how big the control should be to exactly fit content (snap-to-size)  
  
-   **DVEXTENT_INTEGRAL** When resizing, pass proposed size to control  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Points to sizing data returned by control. The returned sizing data is set to -1 for any dimension that was not adjusted.  
  
## Return Value  
 Nonzero if it successfully returns or adjusts the size; otherwise 0.  
  
## Remarks  
 Override this function to return the object's display size closest to the proposed size and extent mode in the **DVEXTENTINFO** structure. The default implementation returns **FALSE** and makes no adjustments to the size.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnGetViewExtent](../vs140/colecontrol--ongetviewextent.md)