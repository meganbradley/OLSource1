---
title: "CHeaderCtrl::GetOverflowRect"
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
  - "GetOverflowRect method"
  - "CHeaderCtrl::GetOverflowRect"
  - "CHeaderCtrl.GetOverflowRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOverflowRect method"
ms.assetid: 661259b2-f01a-4323-a987-ccde53237b52
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::GetOverflowRect
Gets the bounding rectangle of the overflow button of the current header control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives the bounding rectangle information.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this function is successful; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the header control contains more items than can be simultaneously displayed, the control can display an overflow button that scrolls to items that are not visible. The header control must have the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> styles to display the overflow button. The bounding rectangle encloses the overflow button and exists only when the overflow button is displayed. For more information, see [Header Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775241).  
  
 This method sends the [HDM_GETOVERFLOWRECT](http://msdn.microsoft.com/library/windows/desktop/bb775345) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, that is used to access the current header control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#6](../vs140/codesnippet/CPP/cheaderctrl--getoverflowrect_1.h)]  
  
## Example  
 The following code example demonstrates the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method. In an earlier section of the code, we created a header control with five columns. However, you can drag a column separator so that the column is not visible. If some columns are not visible, the header control draws an overflow button. The following code example draws a 3D rectangle around the location of the overflow button.  
  
 [!code[NVC_MFC_CHeaderCtrl_s4#3](../vs140/codesnippet/CPP/cheaderctrl--getoverflowrect_2.cpp)]  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [HDM_GETOVERFLOWRECT](http://msdn.microsoft.com/library/windows/desktop/bb775345)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)